namespace Lab3_Generalizare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGProfesori = new System.Windows.Forms.DataGridView();
            this.DGPalarii = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelParent = new System.Windows.Forms.Label();
            this.labelChild = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGProfesori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPalarii)).BeginInit();
            this.SuspendLayout();
            // 
            // DGProfesori
            // 
            this.DGProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProfesori.Location = new System.Drawing.Point(23, 57);
            this.DGProfesori.Name = "DGProfesori";
            this.DGProfesori.RowTemplate.Height = 24;
            this.DGProfesori.Size = new System.Drawing.Size(492, 150);
            this.DGProfesori.TabIndex = 0;
            // 
            // DGPalarii
            // 
            this.DGPalarii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPalarii.Location = new System.Drawing.Point(23, 253);
            this.DGPalarii.Name = "DGPalarii";
            this.DGPalarii.RowTemplate.Height = 24;
            this.DGPalarii.Size = new System.Drawing.Size(492, 150);
            this.DGPalarii.TabIndex = 1;
            this.DGPalarii.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGPalarii_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(556, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 41);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Adauga";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(683, 91);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 41);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(818, 91);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(82, 41);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Modifica";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(556, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 243);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParent.Location = new System.Drawing.Point(20, 34);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(82, 20);
            this.labelParent.TabIndex = 6;
            this.labelParent.Text = "Profesori:";
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChild.Location = new System.Drawing.Point(20, 230);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(61, 20);
            this.labelChild.TabIndex = 7;
            this.labelChild.Text = "Palarii:";
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(603, 34);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(260, 34);
            this.displayButton.TabIndex = 8;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.labelChild);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.DGPalarii);
            this.Controls.Add(this.DGProfesori);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGProfesori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGPalarii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGProfesori;
        private System.Windows.Forms.DataGridView DGPalarii;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.Button displayButton;
    }
}

