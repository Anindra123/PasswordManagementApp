
namespace ApplicationLayer
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.signInBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.signInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.signInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.signInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(284, 232);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(178, 66);
            this.signInBtn.TabIndex = 1;
            this.signInBtn.Text = "Sign In";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.quitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.quitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(284, 319);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(178, 66);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationLayer.Properties.Resources.FastPass_logos_white;
            this.pictureBox1.Location = new System.Drawing.Point(261, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.signInBtn);
            this.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}