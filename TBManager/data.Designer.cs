namespace TBManager
{
    partial class data
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
            this.dep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dep_insert = new System.Windows.Forms.Button();
            this.sec_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.TextBox();
            this.reg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.f_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.f_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.f_mob = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.f_dep = new System.Windows.Forms.ComboBox();
            this.c_id = new System.Windows.Forms.TextBox();
            this.c_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dep
            // 
            this.dep.Location = new System.Drawing.Point(169, 136);
            this.dep.Name = "dep";
            this.dep.Size = new System.Drawing.Size(100, 20);
            this.dep.TabIndex = 0;
            this.dep.TextChanged += new System.EventHandler(this.dep_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "new dep";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dep_insert
            // 
            this.dep_insert.Location = new System.Drawing.Point(295, 132);
            this.dep_insert.Name = "dep_insert";
            this.dep_insert.Size = new System.Drawing.Size(75, 23);
            this.dep_insert.TabIndex = 2;
            this.dep_insert.Text = "Insert";
            this.dep_insert.UseVisualStyleBackColor = true;
            this.dep_insert.Click += new System.EventHandler(this.sep_insert_Click);
            // 
            // sec_insert
            // 
            this.sec_insert.Location = new System.Drawing.Point(295, 176);
            this.sec_insert.Name = "sec_insert";
            this.sec_insert.Size = new System.Drawing.Size(75, 23);
            this.sec_insert.TabIndex = 5;
            this.sec_insert.Text = "Insert";
            this.sec_insert.UseVisualStyleBackColor = true;
            this.sec_insert.Click += new System.EventHandler(this.sec_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "new sec";
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(169, 176);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(100, 20);
            this.sec.TabIndex = 3;
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(598, 263);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(75, 23);
            this.reg.TabIndex = 8;
            this.reg.Text = "Register";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // f_name
            // 
            this.f_name.Location = new System.Drawing.Point(495, 117);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(100, 20);
            this.f_name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Faculty ID";
            // 
            // f_id
            // 
            this.f_id.Location = new System.Drawing.Point(495, 144);
            this.f_id.Name = "f_id";
            this.f_id.Size = new System.Drawing.Size(100, 20);
            this.f_id.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Faculty email ID";
            // 
            // f_mail
            // 
            this.f_mail.Location = new System.Drawing.Point(495, 170);
            this.f_mail.Name = "f_mail";
            this.f_mail.Size = new System.Drawing.Size(100, 20);
            this.f_mail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "faculty dep";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "faculty mobile";
            // 
            // f_mob
            // 
            this.f_mob.Location = new System.Drawing.Point(495, 222);
            this.f_mob.Name = "f_mob";
            this.f_mob.Size = new System.Drawing.Size(100, 20);
            this.f_mob.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "new cource";
            // 
            // f_dep
            // 
            this.f_dep.FormattingEnabled = true;
            this.f_dep.Location = new System.Drawing.Point(495, 197);
            this.f_dep.Name = "f_dep";
            this.f_dep.Size = new System.Drawing.Size(100, 21);
            this.f_dep.TabIndex = 20;
            this.f_dep.SelectedIndexChanged += new System.EventHandler(this.f_dep_SelectedIndexChanged);
            // 
            // c_id
            // 
            this.c_id.Location = new System.Drawing.Point(169, 216);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(57, 20);
            this.c_id.TabIndex = 17;
            // 
            // c_name
            // 
            this.c_name.Location = new System.Drawing.Point(232, 216);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(57, 20);
            this.c_name.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Registration Forms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cource id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cource Name";
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "ALL",
            "NOT ALL"});
            this.cb2.Location = new System.Drawing.Point(495, 244);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(100, 21);
            this.cb2.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(420, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Access To";
            // 
            // data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.f_dep);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.f_mob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.f_mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.f_id);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.f_name);
            this.Controls.Add(this.sec_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.dep_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dep);
            this.Name = "data";
            this.Text = "data";
            this.Load += new System.EventHandler(this.data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dep_insert;
        private System.Windows.Forms.Button sec_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sec;
        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox f_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox f_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox f_mob;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox f_dep;
        private System.Windows.Forms.TextBox c_id;
        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.Label label12;
    }
}