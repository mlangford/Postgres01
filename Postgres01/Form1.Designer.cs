namespace Postgres01
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOpen.Location = new System.Drawing.Point(12, 167);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 60);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open Connection";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Enabled = false;
            this.btnClose.Location = new System.Drawing.Point(196, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 60);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Connection";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(165, 50);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(509, 22);
            this.txtUser.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.Location = new System.Drawing.Point(14, 50);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 29);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "User";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.White;
            this.txtPwd.Location = new System.Drawing.Point(164, 85);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '#';
            this.txtPwd.Size = new System.Drawing.Size(509, 22);
            this.txtPwd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(13, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Password";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtDb
            // 
            this.txtDb.BackColor = System.Drawing.Color.White;
            this.txtDb.Location = new System.Drawing.Point(164, 124);
            this.txtDb.Name = "txtDb";
            this.txtDb.Size = new System.Drawing.Size(509, 22);
            this.txtDb.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(13, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Database";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtServer
            // 
            this.txtServer.BackColor = System.Drawing.Color.White;
            this.txtServer.Location = new System.Drawing.Point(163, 15);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(509, 22);
            this.txtServer.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(12, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Server";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "~connection status~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

