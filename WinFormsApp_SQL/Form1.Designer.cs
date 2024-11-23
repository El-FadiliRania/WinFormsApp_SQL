namespace WinFormsApp_SQL
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
            idbtn = new Label();
            Nombtn = new Label();
            Autbtn = new Label();
            titbtn = new Label();
            Typbtn = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnselect = new Button();
            btndelete = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // idbtn
            // 
            idbtn.AutoSize = true;
            idbtn.Location = new Point(114, 92);
            idbtn.Name = "idbtn";
            idbtn.Size = new Size(53, 20);
            idbtn.TabIndex = 0;
            idbtn.Text = "idLivre";
            idbtn.Click += label1_Click;
            // 
            // Nombtn
            // 
            Nombtn.AutoSize = true;
            Nombtn.Location = new Point(113, 149);
            Nombtn.Name = "Nombtn";
            Nombtn.Size = new Size(42, 20);
            Nombtn.TabIndex = 1;
            Nombtn.Text = "Nom";
            Nombtn.Click += label2_Click;
            // 
            // Autbtn
            // 
            Autbtn.AutoSize = true;
            Autbtn.Location = new Point(113, 208);
            Autbtn.Name = "Autbtn";
            Autbtn.Size = new Size(53, 20);
            Autbtn.TabIndex = 2;
            Autbtn.Text = "Auteur";
            // 
            // titbtn
            // 
            titbtn.AutoSize = true;
            titbtn.Location = new Point(114, 266);
            titbtn.Name = "titbtn";
            titbtn.Size = new Size(39, 20);
            titbtn.TabIndex = 3;
            titbtn.Text = "Titre";
            titbtn.Click += titbtn_Click;
            // 
            // Typbtn
            // 
            Typbtn.AutoSize = true;
            Typbtn.Location = new Point(113, 333);
            Typbtn.Name = "Typbtn";
            Typbtn.Size = new Size(40, 20);
            Typbtn.TabIndex = 4;
            Typbtn.Text = "Type";
            Typbtn.Click += Typbtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 201);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(200, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(200, 259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(200, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(217, 27);
            textBox5.TabIndex = 9;
            // 
            // btnselect
            // 
            btnselect.Location = new Point(561, 111);
            btnselect.Name = "btnselect";
            btnselect.Size = new Size(157, 41);
            btnselect.TabIndex = 10;
            btnselect.Text = "Select";
            btnselect.UseVisualStyleBackColor = true;
            btnselect.Click += btnselect_Click;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(561, 236);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(157, 41);
            btndelete.TabIndex = 12;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(561, 293);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 39);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(561, 169);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 41);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btndelete);
            Controls.Add(btnselect);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Typbtn);
            Controls.Add(titbtn);
            Controls.Add(Autbtn);
            Controls.Add(Nombtn);
            Controls.Add(idbtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idbtn;
        private Label Nombtn;
        private Label Autbtn;
        private Label titbtn;
        private Label Typbtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnselect;
        private Button btndelete;
        private Button btnInsert;
        private Button btnUpdate;
    }
}
