
namespace WindowsFormsApp1
{
    partial class MainScreen
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
            this.PanelMenuLateral = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelMenuLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.PanelMenuLateral.Controls.Add(this.label1);
            this.PanelMenuLateral.Controls.Add(this.panel1);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(212, 635);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "FotoTeca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(3, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 593);
            this.panel1.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1054, 635);
            this.Controls.Add(this.PanelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.PanelMenuLateral.ResumeLayout(false);
            this.PanelMenuLateral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMenuLateral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}