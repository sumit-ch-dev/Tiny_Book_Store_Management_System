
namespace Tiny_Book_Store_Management_System
{
    partial class Form5Manager_Delete
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
            this.label1Manager_Id = new System.Windows.Forms.Label();
            this.button1Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.dms = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(524, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 29);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1Manager_Id
            // 
            this.label1Manager_Id.AutoSize = true;
            this.label1Manager_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Manager_Id.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1Manager_Id.Location = new System.Drawing.Point(331, 278);
            this.label1Manager_Id.Name = "label1Manager_Id";
            this.label1Manager_Id.Size = new System.Drawing.Size(171, 25);
            this.label1Manager_Id.TabIndex = 22;
            this.label1Manager_Id.Text = "Manager Name";
            this.label1Manager_Id.Click += new System.EventHandler(this.label1Manager_Id_Click);
            // 
            // button1Delete
            // 
            this.button1Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Delete.Location = new System.Drawing.Point(392, 340);
            this.button1Delete.Name = "button1Delete";
            this.button1Delete.Size = new System.Drawing.Size(110, 30);
            this.button1Delete.TabIndex = 20;
            this.button1Delete.Text = "Delete";
            this.button1Delete.UseVisualStyleBackColor = true;
            this.button1Delete.Click += new System.EventHandler(this.button1Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(379, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Delete the Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(555, 340);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(110, 30);
            this.Back.TabIndex = 20;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dms
            // 
            this.dms.AutoSize = true;
            this.dms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dms.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dms.Location = new System.Drawing.Point(436, 253);
            this.dms.Name = "dms";
            this.dms.Size = new System.Drawing.Size(0, 24);
            this.dms.TabIndex = 22;
            this.dms.Click += new System.EventHandler(this.label1Manager_Id_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.CadetBlue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logout.Location = new System.Drawing.Point(487, 481);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(120, 36);
            this.logout.TabIndex = 28;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form5Manager_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 752);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dms);
            this.Controls.Add(this.label1Manager_Id);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1Delete);
            this.Name = "Form5Manager_Delete";
            this.Text = "Form5Manager_Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1Manager_Id;
        private System.Windows.Forms.Button button1Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label dms;
        private System.Windows.Forms.Button logout;
    }
}