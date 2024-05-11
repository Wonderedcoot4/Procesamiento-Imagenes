
namespace WindowsFormsApp1
{
    partial class CamaraForm
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
            this.camaraBox = new System.Windows.Forms.PictureBox();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivateCam = new System.Windows.Forms.Button();
            this.CloseCameraBttn = new System.Windows.Forms.Button();
            this.startScreenButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FaceTrackbttnn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camaraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // camaraBox
            // 
            this.camaraBox.BackColor = System.Drawing.Color.White;
            this.camaraBox.Location = new System.Drawing.Point(226, -4);
            this.camaraBox.Name = "camaraBox";
            this.camaraBox.Size = new System.Drawing.Size(878, 528);
            this.camaraBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camaraBox.TabIndex = 0;
            this.camaraBox.TabStop = false;
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(226, 560);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(287, 21);
            this.cbCamera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(223, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elija una camara";
            // 
            // ActivateCam
            // 
            this.ActivateCam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateCam.Location = new System.Drawing.Point(579, 560);
            this.ActivateCam.Name = "ActivateCam";
            this.ActivateCam.Size = new System.Drawing.Size(214, 91);
            this.ActivateCam.TabIndex = 3;
            this.ActivateCam.Text = "Activar Camara";
            this.ActivateCam.UseVisualStyleBackColor = true;
            this.ActivateCam.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseCameraBttn
            // 
            this.CloseCameraBttn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseCameraBttn.Location = new System.Drawing.Point(890, 560);
            this.CloseCameraBttn.Name = "CloseCameraBttn";
            this.CloseCameraBttn.Size = new System.Drawing.Size(214, 91);
            this.CloseCameraBttn.TabIndex = 4;
            this.CloseCameraBttn.Text = "Apagar Camara";
            this.CloseCameraBttn.UseVisualStyleBackColor = true;
            this.CloseCameraBttn.Click += new System.EventHandler(this.CloseCameraBttn_Click);
            // 
            // startScreenButton
            // 
            this.startScreenButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startScreenButton.Location = new System.Drawing.Point(1, 700);
            this.startScreenButton.Name = "startScreenButton";
            this.startScreenButton.Size = new System.Drawing.Size(214, 91);
            this.startScreenButton.TabIndex = 5;
            this.startScreenButton.Text = "Volver al inicio";
            this.startScreenButton.UseVisualStyleBackColor = true;
            this.startScreenButton.Click += new System.EventHandler(this.startScreenButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(579, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "Activar Camara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FaceTrackbttnn
            // 
            this.FaceTrackbttnn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaceTrackbttnn.Location = new System.Drawing.Point(1128, 349);
            this.FaceTrackbttnn.Name = "FaceTrackbttnn";
            this.FaceTrackbttnn.Size = new System.Drawing.Size(214, 91);
            this.FaceTrackbttnn.TabIndex = 6;
            this.FaceTrackbttnn.Text = "Detectar Rostros";
            this.FaceTrackbttnn.UseVisualStyleBackColor = true;
            // 
            // CamaraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(74)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1354, 793);
            this.Controls.Add(this.FaceTrackbttnn);
            this.Controls.Add(this.startScreenButton);
            this.Controls.Add(this.CloseCameraBttn);
            this.Controls.Add(this.ActivateCam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.camaraBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CamaraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CamaraForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CamaraForm_FormClosing);
            this.Load += new System.EventHandler(this.CamaraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.camaraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox camaraBox;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ActivateCam;
        private System.Windows.Forms.Button CloseCameraBttn;
        private System.Windows.Forms.Button startScreenButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FaceTrackbttnn;
    }
}