
namespace ApplicationLayer
{
    partial class ForgotPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassForm));
            this.label3 = new System.Windows.Forms.Label();
            this.sendPassTextBox = new System.Windows.Forms.TextBox();
            this.sendPassBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(22, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter email";
            // 
            // sendPassTextBox
            // 
            this.sendPassTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPassTextBox.Location = new System.Drawing.Point(26, 61);
            this.sendPassTextBox.Name = "sendPassTextBox";
            this.sendPassTextBox.Size = new System.Drawing.Size(579, 30);
            this.sendPassTextBox.TabIndex = 6;
            // 
            // sendPassBtn
            // 
            this.sendPassBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.sendPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.sendPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.sendPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendPassBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPassBtn.ForeColor = System.Drawing.Color.White;
            this.sendPassBtn.Location = new System.Drawing.Point(26, 125);
            this.sendPassBtn.Name = "sendPassBtn";
            this.sendPassBtn.Size = new System.Drawing.Size(297, 51);
            this.sendPassBtn.TabIndex = 11;
            this.sendPassBtn.Text = "Send verfication code on mail";
            this.sendPassBtn.UseVisualStyleBackColor = true;
            this.sendPassBtn.Click += new System.EventHandler(this.sendPassBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(444, 125);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(141, 51);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(617, 211);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendPassBtn);
            this.Controls.Add(this.sendPassTextBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgotPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Pass";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendPassTextBox;
        private System.Windows.Forms.Button sendPassBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}