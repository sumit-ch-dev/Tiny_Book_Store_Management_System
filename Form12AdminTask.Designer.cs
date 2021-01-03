
namespace Tiny_Book_Store_Management_System
{
    partial class Form12AdminTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1Add_New_Manager_Entry = new System.Windows.Forms.Button();
            this.button2Manager_List = new System.Windows.Forms.Button();
            this.button3Delete_Manager = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(413, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Task";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1Add_New_Manager_Entry
            // 
            this.button1Add_New_Manager_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Add_New_Manager_Entry.Location = new System.Drawing.Point(415, 224);
            this.button1Add_New_Manager_Entry.Name = "button1Add_New_Manager_Entry";
            this.button1Add_New_Manager_Entry.Size = new System.Drawing.Size(224, 40);
            this.button1Add_New_Manager_Entry.TabIndex = 1;
            this.button1Add_New_Manager_Entry.Text = "Add New Manager Entry";
            this.button1Add_New_Manager_Entry.UseVisualStyleBackColor = true;
            this.button1Add_New_Manager_Entry.Click += new System.EventHandler(this.button1Add_New_Manager_Entry_Click);
            // 
            // button2Manager_List
            // 
            this.button2Manager_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Manager_List.Location = new System.Drawing.Point(417, 283);
            this.button2Manager_List.Name = "button2Manager_List";
            this.button2Manager_List.Size = new System.Drawing.Size(222, 40);
            this.button2Manager_List.TabIndex = 2;
            this.button2Manager_List.Text = "Manager List";
            this.button2Manager_List.UseVisualStyleBackColor = true;
            this.button2Manager_List.Click += new System.EventHandler(this.button2Manager_List_Click);
            // 
            // button3Delete_Manager
            // 
            this.button3Delete_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Delete_Manager.Location = new System.Drawing.Point(420, 342);
            this.button3Delete_Manager.Name = "button3Delete_Manager";
            this.button3Delete_Manager.Size = new System.Drawing.Size(219, 40);
            this.button3Delete_Manager.TabIndex = 3;
            this.button3Delete_Manager.Text = "Delete Manager";
            this.button3Delete_Manager.UseVisualStyleBackColor = true;
            this.button3Delete_Manager.Click += new System.EventHandler(this.button3Delete_Manager_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.CadetBlue;
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logout.Location = new System.Drawing.Point(469, 426);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(120, 36);
            this.logout.TabIndex = 28;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // Form12AdminTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1084, 752);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.button3Delete_Manager);
            this.Controls.Add(this.button2Manager_List);
            this.Controls.Add(this.button1Add_New_Manager_Entry);
            this.Controls.Add(this.label1);
            this.Name = "Form12AdminTask";
            this.Text = "Form12AdminTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1Add_New_Manager_Entry;
        private System.Windows.Forms.Button button2Manager_List;
        private System.Windows.Forms.Button button3Delete_Manager;
        private System.Windows.Forms.Button logout;
    }
}