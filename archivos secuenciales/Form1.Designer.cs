﻿namespace archivos_secuenciales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxBrand = new ComboBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtSearch = new TextBox();
            btnRegister = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            listBoxGames = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBoxBrand
            // 
            comboBoxBrand.FormattingEnabled = true;
            comboBoxBrand.Location = new Point(12, 12);
            comboBoxBrand.Name = "comboBoxBrand";
            comboBoxBrand.Size = new Size(121, 23);
            comboBoxBrand.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 111);
            txtName.Name = "txtName";
            txtName.Size = new Size(207, 23);
            txtName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 187);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(207, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 260);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(207, 23);
            txtSearch.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(324, 12);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(423, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(526, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(626, 11);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBoxGames
            // 
            listBoxGames.FormattingEnabled = true;
            listBoxGames.ItemHeight = 15;
            listBoxGames.Location = new Point(324, 66);
            listBoxGames.Name = "listBoxGames";
            listBoxGames.Size = new Size(377, 304);
            listBoxGames.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 20);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 10;
            label2.Text = "Name games";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 11;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 242);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 12;
            label4.Text = "Search by Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxGames);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnRegister);
            Controls.Add(txtSearch);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(comboBoxBrand);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBrand;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtSearch;
        private Button btnRegister;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnSearch;
        private ListBox listBoxGames;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
