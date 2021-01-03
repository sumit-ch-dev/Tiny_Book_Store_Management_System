
namespace Tiny_Book_Store_Management_System
{
    partial class Form4New_Manager_Entry
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3Password = new System.Windows.Forms.Label();
            this.label2Manager_Id = new System.Windows.Forms.Label();
            this.button1Create = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.mgs = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(443, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 29);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(443, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 29);
            this.textBox2.TabIndex = 24;
            // 
            // label3Password
            // 
            this.label3Password.AutoSize = true;
            this.label3Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Password.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3Password.Location = new System.Drawing.Point(305, 195);
            this.label3Password.Name = "label3Password";
            this.label3Password.Size = new System.Drawing.Size(114, 25);
            this.label3Password.TabIndex = 21;
            this.label3Password.Text = "Password";
            // 
            // label2Manager_Id
            // 
            this.label2Manager_Id.AutoSize = true;
            this.label2Manager_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Manager_Id.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2Manager_Id.Location = new System.Drawing.Point(248, 138);
            this.label2Manager_Id.Name = "label2Manager_Id";
            this.label2Manager_Id.Size = new System.Drawing.Size(171, 25);
            this.label2Manager_Id.TabIndex = 22;
            this.label2Manager_Id.Text = "Manager Name";
            this.label2Manager_Id.Click += new System.EventHandler(this.label2Manager_Name_Click);
            // 
            // button1Create
            // 
            this.button1Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Create.Location = new System.Drawing.Point(443, 300);
            this.button1Create.Name = "button1Create";
            this.button1Create.Size = new System.Drawing.Size(110, 39);
            this.button1Create.TabIndex = 20;
            this.button1Create.Text = "Create";
            this.button1Create.UseVisualStyleBackColor = true;
            this.button1Create.Click += new System.EventHandler(this.button1Create_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(565, 300);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(110, 39);
            this.Back.TabIndex = 20;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // mgs
            // 
            this.mgs.AutoSize = true;
            this.mgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgs.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.mgs.Location = new System.Drawing.Point(402, 356);
            this.mgs.Name = "mgs";
            this.mgs.Size = new System.Drawing.Size(0, 33);
            this.mgs.TabIndex = 25;
            this.mgs.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.Yellow;
            this.lab.Location = new System.Drawing.Point(411, 28);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(280, 39);
            this.lab.TabIndex = 22;
            this.lab.Text = "Create Manager";
            this.lab.Click += new System.EventHandler(this.label2Manager_Name_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.CadetBlue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logout.Location = new System.Drawing.Point(511, 439);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(120, 36);
            this.logout.TabIndex = 27;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form4New_Manager_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 752);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.mgs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3Password);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.label2Manager_Id);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1Create);
            this.Name = "Form4New_Manager_Entry";
            this.Text = "Form4New_Manager_Entry";
            this.Load += new System.EventHandler(this.Form4New_Manager_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3Password;
        private System.Windows.Forms.Label label2Manager_Id;
        private System.Windows.Forms.Button button1Create;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label mgs;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Button logout;
    }
}