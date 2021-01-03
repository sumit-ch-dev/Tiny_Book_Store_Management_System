
namespace Tiny_Book_Store_Management_System
{
    partial class Form2Admin_Log_In
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
            this.button2Manager = new System.Windows.Forms.Button();
            this.button1Admin = new System.Windows.Forms.Button();
            this.label1LogInAs = new System.Windows.Forms.Label();
            this.label2Admin_Id = new System.Windows.Forms.Label();
            this.label3Password = new System.Windows.Forms.Label();
            this.button3Ok = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2Manager
            // 
            this.button2Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Manager.Location = new System.Drawing.Point(652, 385);
            this.button2Manager.Name = "button2Manager";
            this.button2Manager.Size = new System.Drawing.Size(110, 39);
            this.button2Manager.TabIndex = 4;
            this.button2Manager.Text = "Manager";
            this.button2Manager.UseVisualStyleBackColor = true;
            // 
            // button1Admin
            // 
            this.button1Admin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Admin.Location = new System.Drawing.Point(290, 385);
            this.button1Admin.Name = "button1Admin";
            this.button1Admin.Size = new System.Drawing.Size(110, 39);
            this.button1Admin.TabIndex = 5;
            this.button1Admin.Text = "Admin";
            this.button1Admin.UseVisualStyleBackColor = false;
            // 
            // label1LogInAs
            // 
            this.label1LogInAs.AutoSize = true;
            this.label1LogInAs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1LogInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1LogInAs.Location = new System.Drawing.Point(208, 107);
            this.label1LogInAs.Name = "label1LogInAs";
            this.label1LogInAs.Size = new System.Drawing.Size(137, 31);
            this.label1LogInAs.TabIndex = 3;
            this.label1LogInAs.Text = "Log In As";
            // 
            // label2Admin_Id
            // 
            this.label2Admin_Id.AutoSize = true;
            this.label2Admin_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Admin_Id.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2Admin_Id.Location = new System.Drawing.Point(288, 513);
            this.label2Admin_Id.Name = "label2Admin_Id";
            this.label2Admin_Id.Size = new System.Drawing.Size(144, 25);
            this.label2Admin_Id.TabIndex = 8;
            this.label2Admin_Id.Text = "Admin Name";
            // 
            // label3Password
            // 
            this.label3Password.AutoSize = true;
            this.label3Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Password.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3Password.Location = new System.Drawing.Point(318, 562);
            this.label3Password.Name = "label3Password";
            this.label3Password.Size = new System.Drawing.Size(114, 25);
            this.label3Password.TabIndex = 8;
            this.label3Password.Text = "Password";
            // 
            // button3Ok
            // 
            this.button3Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Ok.Location = new System.Drawing.Point(498, 619);
            this.button3Ok.Name = "button3Ok";
            this.button3Ok.Size = new System.Drawing.Size(110, 39);
            this.button3Ok.TabIndex = 4;
            this.button3Ok.Text = "Ok";
            this.button3Ok.UseVisualStyleBackColor = true;
            this.button3Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(449, 566);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(232, 31);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(449, 513);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 31);
            this.textBox1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tiny_Book_Store_Management_System.Properties.Resources.Manager;
            this.pictureBox2.Location = new System.Drawing.Point(579, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Book_Store_Management_System.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(214, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msg.Location = new System.Drawing.Point(358, 453);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 24);
            this.msg.TabIndex = 8;
            // 
            // Form2Admin_Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3Password);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.label2Admin_Id);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3Ok);
            this.Controls.Add(this.button2Manager);
            this.Controls.Add(this.button1Admin);
            this.Controls.Add(this.label1LogInAs);
            this.Name = "Form2Admin_Log_In";
            this.Text = "Form2Admin_Log_In";
            this.Load += new System.EventHandler(this.Form2Admin_Log_In_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2Manager;
        private System.Windows.Forms.Button button1Admin;
        private System.Windows.Forms.Label label1LogInAs;
        private System.Windows.Forms.Label label2Admin_Id;
        private System.Windows.Forms.Label label3Password;
        private System.Windows.Forms.Button button3Ok;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label msg;
    }
}