
namespace Tiny_Book_Store_Management_System
{
    partial class Form1Home
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
            this.label1LogInAs = new System.Windows.Forms.Label();
            this.button1Admin = new System.Windows.Forms.Button();
            this.button2Manager = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1LogInAs
            // 
            this.label1LogInAs.AutoSize = true;
            this.label1LogInAs.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1LogInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1LogInAs.Location = new System.Drawing.Point(194, 224);
            this.label1LogInAs.Name = "label1LogInAs";
            this.label1LogInAs.Size = new System.Drawing.Size(137, 31);
            this.label1LogInAs.TabIndex = 0;
            this.label1LogInAs.Text = "Log In As";
            // 
            // button1Admin
            // 
            this.button1Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Admin.Location = new System.Drawing.Point(250, 483);
            this.button1Admin.Name = "button1Admin";
            this.button1Admin.Size = new System.Drawing.Size(110, 39);
            this.button1Admin.TabIndex = 1;
            this.button1Admin.Text = "Admin";
            this.button1Admin.UseVisualStyleBackColor = true;
            this.button1Admin.Click += new System.EventHandler(this.button1Admin_Click);
            // 
            // button2Manager
            // 
            this.button2Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Manager.Location = new System.Drawing.Point(612, 483);
            this.button2Manager.Name = "button2Manager";
            this.button2Manager.Size = new System.Drawing.Size(110, 39);
            this.button2Manager.TabIndex = 1;
            this.button2Manager.Text = "Manager";
            this.button2Manager.UseVisualStyleBackColor = true;
            this.button2Manager.Click += new System.EventHandler(this.button2Manager_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tiny_Book_Store_Management_System.Properties.Resources.Manager;
            this.pictureBox2.Location = new System.Drawing.Point(557, 302);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tiny_Book_Store_Management_System.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(191, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exit.Location = new System.Drawing.Point(440, 620);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(113, 35);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2Manager);
            this.Controls.Add(this.button1Admin);
            this.Controls.Add(this.label1LogInAs);
            this.Name = "Form1Home";
            this.Text = "Form1Home";
            this.Load += new System.EventHandler(this.Form1Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1LogInAs;
        private System.Windows.Forms.Button button1Admin;
        private System.Windows.Forms.Button button2Manager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button exit;
    }
}

