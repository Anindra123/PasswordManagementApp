
namespace ApplicationLayer
{
    partial class UserDashBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBoardForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.updateAccountBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPassDataGridView = new System.Windows.Forms.DataGridView();
            this.updatePassBtn = new System.Windows.Forms.Button();
            this.deletePassBtn = new System.Windows.Forms.Button();
            this.viewSelectedPassBtn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.updateAccountBtn,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1141, 126);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 126);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 126);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = global::ApplicationLayer.Properties.Resources.add_1_icon;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(168, 123);
            this.toolStripButton2.Text = "Store new password";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // updateAccountBtn
            // 
            this.updateAccountBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAccountBtn.ForeColor = System.Drawing.Color.White;
            this.updateAccountBtn.Image = global::ApplicationLayer.Properties.Resources.Male_user_edit_icon;
            this.updateAccountBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAccountBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateAccountBtn.Name = "updateAccountBtn";
            this.updateAccountBtn.Size = new System.Drawing.Size(176, 123);
            this.updateAccountBtn.Text = "Update your account";
            this.updateAccountBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.updateAccountBtn.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.updateAccountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = global::ApplicationLayer.Properties.Resources.logout_icon;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 123);
            this.toolStripButton1.Text = "Sign Out";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewSelectedPassBtn);
            this.panel1.Controls.Add(this.deletePassBtn);
            this.panel1.Controls.Add(this.updatePassBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(889, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 618);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showPassDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 618);
            this.panel2.TabIndex = 2;
            // 
            // showPassDataGridView
            // 
            this.showPassDataGridView.AllowUserToAddRows = false;
            this.showPassDataGridView.AllowUserToDeleteRows = false;
            this.showPassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showPassDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPassDataGridView.Location = new System.Drawing.Point(0, 0);
            this.showPassDataGridView.Name = "showPassDataGridView";
            this.showPassDataGridView.ReadOnly = true;
            this.showPassDataGridView.RowHeadersWidth = 51;
            this.showPassDataGridView.RowTemplate.Height = 24;
            this.showPassDataGridView.Size = new System.Drawing.Size(889, 618);
            this.showPassDataGridView.TabIndex = 0;
            // 
            // updatePassBtn
            // 
            this.updatePassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatePassBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.updatePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.updatePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.updatePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePassBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatePassBtn.ForeColor = System.Drawing.Color.White;
            this.updatePassBtn.Location = new System.Drawing.Point(20, 16);
            this.updatePassBtn.Name = "updatePassBtn";
            this.updatePassBtn.Size = new System.Drawing.Size(213, 68);
            this.updatePassBtn.TabIndex = 8;
            this.updatePassBtn.Text = "Update Selected";
            this.updatePassBtn.UseVisualStyleBackColor = true;
            // 
            // deletePassBtn
            // 
            this.deletePassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePassBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.deletePassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.deletePassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.deletePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePassBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePassBtn.ForeColor = System.Drawing.Color.White;
            this.deletePassBtn.Location = new System.Drawing.Point(20, 192);
            this.deletePassBtn.Name = "deletePassBtn";
            this.deletePassBtn.Size = new System.Drawing.Size(213, 68);
            this.deletePassBtn.TabIndex = 9;
            this.deletePassBtn.Text = "Remove Selected";
            this.deletePassBtn.UseVisualStyleBackColor = true;
            // 
            // viewSelectedPassBtn
            // 
            this.viewSelectedPassBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewSelectedPassBtn.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.viewSelectedPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.viewSelectedPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.viewSelectedPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSelectedPassBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSelectedPassBtn.ForeColor = System.Drawing.Color.White;
            this.viewSelectedPassBtn.Location = new System.Drawing.Point(20, 101);
            this.viewSelectedPassBtn.Name = "viewSelectedPassBtn";
            this.viewSelectedPassBtn.Size = new System.Drawing.Size(213, 68);
            this.viewSelectedPassBtn.TabIndex = 10;
            this.viewSelectedPassBtn.Text = "View Selected";
            this.viewSelectedPassBtn.UseVisualStyleBackColor = true;
            // 
            // UserDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1141, 744);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserDashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.showPassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton updateAccountBtn;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView showPassDataGridView;
        private System.Windows.Forms.Button deletePassBtn;
        private System.Windows.Forms.Button updatePassBtn;
        private System.Windows.Forms.Button viewSelectedPassBtn;
    }
}