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
            this.label1 = new System.Windows.Forms.Label();
            this.rbHome = new System.Windows.Forms.RadioButton();
            this.rbWork = new System.Windows.Forms.RadioButton();
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
            // rbHome
            // 
            this.rbHome.AutoSize = true;
            this.rbHome.Checked = true;
            this.rbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHome.Location = new System.Drawing.Point(12, 38);
            this.rbHome.Name = "rbHome";
            this.rbHome.Size = new System.Drawing.Size(338, 33);
            this.rbHome.TabIndex = 11;
            this.rbHome.TabStop = true;
            this.rbHome.Text = "Connect to BoG on localhost";
            this.rbHome.UseVisualStyleBackColor = true;
            // 
            // rbWork
            // 
            this.rbWork.AutoSize = true;
            this.rbWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbWork.Location = new System.Drawing.Point(11, 77);
            this.rbWork.Name = "rbWork";
            this.rbWork.Size = new System.Drawing.Size(347, 33);
            this.rbWork.TabIndex = 12;
            this.rbWork.Text = "Connect to BoG on ces-web3";
            this.rbWork.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 255);
            this.Controls.Add(this.rbWork);
            this.Controls.Add(this.rbHome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbHome;
        private System.Windows.Forms.RadioButton rbWork;
    }
}

