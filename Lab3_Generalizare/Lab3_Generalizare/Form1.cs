using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;

namespace Lab3_Generalizare
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        SqlDataAdapter daParinte = new SqlDataAdapter();
        SqlDataAdapter daCopii = new SqlDataAdapter();

        BindingSource bsParinte;
        BindingSource bsCopii;

        DataSet ds = new DataSet();

        SqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
            string parentTableName = ConfigurationSettings.AppSettings["parentTableName"];
            string childTableName = ConfigurationSettings.AppSettings["childTableName"];

            labelParent.Text = parentTableName;
            labelChild.Text = childTableName;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            conn = new SqlConnection(conString);

            string select1 = ConfigurationSettings.AppSettings["select1"];
            daParinte.SelectCommand = new SqlCommand(select1, conn);

            string select2 = ConfigurationSettings.AppSettings["select2"];
            daCopii = new SqlDataAdapter(select2, conn);

            string parentTableName = ConfigurationSettings.AppSettings["parentTableName"];
            string childTableName = ConfigurationSettings.AppSettings["childTableName"];
            string sharedId = ConfigurationSettings.AppSettings["sharedId"];

            ds.Clear();
            daParinte.Fill(ds, parentTableName);
            daCopii.Fill(ds, childTableName);
            
            cb = new SqlCommandBuilder(daCopii);
            ds.Relations.Add("FK_Copii_Parinte", ds.Tables[parentTableName].Columns[sharedId], ds.Tables[childTableName].Columns[sharedId]);

            bsParinte = new BindingSource();
            bsParinte.DataSource = ds;
            bsParinte.DataMember = parentTableName;

            bsCopii = new BindingSource();
            bsCopii.DataSource = bsParinte;
            bsCopii.DataMember = "FK_Copii_Parinte";

            DGProfesori.DataSource = bsParinte;
            DGPalarii.DataSource = bsCopii;

            List<string> columnNamesList = new List<string>(ConfigurationManager.AppSettings["childColumnNames"].Split(','));
            int y = 0;
            foreach (string column in columnNamesList)
            {
                y += 40;

                Label label = new Label();
                label.Text = column + ": ";
                label.Location = new System.Drawing.Point(0, y);
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(70, y);
                textBox.Name = "text" + column;
                panel1.Controls.Add(label);
                panel1.Controls.Add(textBox);

                textBox.DataBindings.Add("Text", bsCopii, column);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string parentTableName = ConfigurationSettings.AppSettings["parentTableName"];

            string childTableName = ConfigurationSettings.AppSettings["childTableName"];
            string childColumnNames = ConfigurationSettings.AppSettings["childColumnNames"];
            string columnNamesInsertParameters = ConfigurationSettings.AppSettings["columnNamesInsertParameters"];

            List<string> columnNamesList = new List<string>(ConfigurationManager.AppSettings["childColumnNames"].Split(','));

            SqlCommand cmd = new SqlCommand("INSERT INTO " + childTableName + " (" + childColumnNames + ") VALUES (" + columnNamesInsertParameters + ")", conn);

            foreach (string column in columnNamesList) {
                TextBox textBox = (TextBox)panel1.Controls["text" + column];
                cmd.Parameters.AddWithValue("@" + column, textBox.Text);
            }
            conn.Open();
            cmd.ExecuteNonQuery();

            ds.Clear();

            daParinte.Fill(ds, parentTableName);
            daCopii.Fill(ds, childTableName);

            bsParinte.DataSource = ds;
            bsParinte.DataMember = parentTableName;

            bsCopii.DataSource = bsParinte;
            bsCopii.DataMember = "FK_Copii_Parinte";

            DGProfesori.DataSource = bsParinte;
            DGPalarii.DataSource = bsCopii;

            conn.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string childTableName = ConfigurationSettings.AppSettings["childTableName"];
            daCopii.Update(ds, childTableName);           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string childTableName = ConfigurationSettings.AppSettings["childTableName"];
            daCopii.Update(ds, childTableName);
        }

        private void DGPalarii_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
