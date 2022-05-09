namespace ApplicationLayer
{
    partial class ResetPasswordForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cMasterPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nMasterPassword = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter master password :";
            // 
            // cMasterPassword
            // 
            this.cMasterPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMasterPassword.Location = new System.Drawing.Point(279, 96);
            this.cMasterPassword.Name = "cMasterPassword";
            this.cMasterPassword.PasswordChar = '●';
            this.cMasterPassword.Size = new System.Drawing.Size(308, 30);
            this.cMasterPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(31, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm master password :";
            // 
            // nMasterPassword
            // 
            this.nMasterPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nMasterPassword.Location = new System.Drawing.Point(279, 35);
            this.nMasterPassword.Name = "nMasterPassword";
            this.nMasterPassword.PasswordChar = '●';
            this.nMasterPassword.Size = new System.Drawing.Size(308, 30);
            this.nMasterPassword.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(381, 173);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(141, 51);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.submitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.submitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(73, 173);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(141, 51);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(625, 272);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.nMasterPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cMasterPassword);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPasswordForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResetPasswordForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cMasterPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nMasterPassword;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}