﻿
namespace WindowsFormsApp1
{
    partial class Fotografias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fotografias));
            this.FotoOriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.SubirFotoBtn = new System.Windows.Forms.Button();
            this.SaveImgBttn = new System.Windows.Forms.Button();
            this.StartScreenBttn = new System.Windows.Forms.Button();
            this.FiltroPixeladoBtn = new System.Windows.Forms.Button();
            this.CanalAzulFiltroBttn = new System.Windows.Forms.Button();
            this.NegativoFiltroBttn = new System.Windows.Forms.Button();
            this.SobelFiltroBttn = new System.Windows.Forms.Button();
            this.GradianteFiltroBttn = new System.Windows.Forms.Button();
            this.trackBarEdicion = new System.Windows.Forms.TrackBar();
            this.FiltroRojoBttn = new System.Windows.Forms.Button();
            this.AberracionCromaBttn = new System.Windows.Forms.Button();
            this.ColorizarFiltroBttn = new System.Windows.Forms.Button();
            this.EspejoFiltroBttn = new System.Windows.Forms.Button();
            this.ContrasteFiltroBttn = new System.Windows.Forms.Button();
            this.FotoFiltroPicBox = new System.Windows.Forms.PictureBox();
            this.HistogramPicBox = new System.Windows.Forms.PictureBox();
            this.HistoButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotoOriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoFiltroPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FotoOriginalPictureBox
            // 
            this.FotoOriginalPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FotoOriginalPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FotoOriginalPictureBox.Image")));
            this.FotoOriginalPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FotoOriginalPictureBox.Name = "FotoOriginalPictureBox";
            this.FotoOriginalPictureBox.Size = new System.Drawing.Size(601, 366);
            this.FotoOriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoOriginalPictureBox.TabIndex = 0;
            this.FotoOriginalPictureBox.TabStop = false;
            // 
            // SubirFotoBtn
            // 
            this.SubirFotoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubirFotoBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.SubirFotoBtn.FlatAppearance.BorderSize = 10;
            this.SubirFotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubirFotoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubirFotoBtn.Location = new System.Drawing.Point(32, 389);
            this.SubirFotoBtn.Name = "SubirFotoBtn";
            this.SubirFotoBtn.Size = new System.Drawing.Size(187, 92);
            this.SubirFotoBtn.TabIndex = 4;
            this.SubirFotoBtn.Text = "Subir Foto";
            this.SubirFotoBtn.UseVisualStyleBackColor = false;
            this.SubirFotoBtn.Click += new System.EventHandler(this.SubirFotoBtn_Click);
            // 
            // SaveImgBttn
            // 
            this.SaveImgBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveImgBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveImgBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveImgBttn.Location = new System.Drawing.Point(385, 389);
            this.SaveImgBttn.Name = "SaveImgBttn";
            this.SaveImgBttn.Size = new System.Drawing.Size(187, 92);
            this.SaveImgBttn.TabIndex = 6;
            this.SaveImgBttn.Text = "Guardar Foto";
            this.SaveImgBttn.UseVisualStyleBackColor = false;
            this.SaveImgBttn.Click += new System.EventHandler(this.SaveImgBttn_Click);
            // 
            // StartScreenBttn
            // 
            this.StartScreenBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StartScreenBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartScreenBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartScreenBttn.Location = new System.Drawing.Point(199, 560);
            this.StartScreenBttn.Name = "StartScreenBttn";
            this.StartScreenBttn.Size = new System.Drawing.Size(187, 92);
            this.StartScreenBttn.TabIndex = 7;
            this.StartScreenBttn.Text = "Volver al inicio";
            this.StartScreenBttn.UseVisualStyleBackColor = false;
            this.StartScreenBttn.Click += new System.EventHandler(this.StartScreenBttn_Click);
            // 
            // FiltroPixeladoBtn
            // 
            this.FiltroPixeladoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FiltroPixeladoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiltroPixeladoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroPixeladoBtn.Location = new System.Drawing.Point(1415, 12);
            this.FiltroPixeladoBtn.Name = "FiltroPixeladoBtn";
            this.FiltroPixeladoBtn.Size = new System.Drawing.Size(187, 92);
            this.FiltroPixeladoBtn.TabIndex = 8;
            this.FiltroPixeladoBtn.Text = "Pixelado";
            this.FiltroPixeladoBtn.UseVisualStyleBackColor = false;
            this.FiltroPixeladoBtn.Click += new System.EventHandler(this.FiltroPixeladoBtn_Click);
            this.FiltroPixeladoBtn.MouseLeave += new System.EventHandler(this.FiltroPixeladoBtn_MouseLeave);
            this.FiltroPixeladoBtn.MouseHover += new System.EventHandler(this.FiltroPixeladoBtn_MouseHover);
            // 
            // CanalAzulFiltroBttn
            // 
            this.CanalAzulFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CanalAzulFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CanalAzulFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanalAzulFiltroBttn.Location = new System.Drawing.Point(1667, 12);
            this.CanalAzulFiltroBttn.Name = "CanalAzulFiltroBttn";
            this.CanalAzulFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.CanalAzulFiltroBttn.TabIndex = 9;
            this.CanalAzulFiltroBttn.Text = "Canal Azul";
            this.CanalAzulFiltroBttn.UseVisualStyleBackColor = false;
            this.CanalAzulFiltroBttn.Click += new System.EventHandler(this.CanalAzulFiltroBttn_Click);
            this.CanalAzulFiltroBttn.MouseLeave += new System.EventHandler(this.CanalAzulFiltroBttn_MouseLeave);
            this.CanalAzulFiltroBttn.MouseHover += new System.EventHandler(this.CanalAzulFiltroBttn_MouseHover);
            // 
            // NegativoFiltroBttn
            // 
            this.NegativoFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NegativoFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NegativoFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NegativoFiltroBttn.Location = new System.Drawing.Point(1667, 126);
            this.NegativoFiltroBttn.Name = "NegativoFiltroBttn";
            this.NegativoFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.NegativoFiltroBttn.TabIndex = 11;
            this.NegativoFiltroBttn.Text = "Negativo";
            this.NegativoFiltroBttn.UseVisualStyleBackColor = false;
            this.NegativoFiltroBttn.Click += new System.EventHandler(this.NegativoFiltroBttn_Click);
            this.NegativoFiltroBttn.MouseLeave += new System.EventHandler(this.NegativoFiltroBttn_MouseLeave);
            this.NegativoFiltroBttn.MouseHover += new System.EventHandler(this.NegativoFiltroBttn_MouseHover);
            // 
            // SobelFiltroBttn
            // 
            this.SobelFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SobelFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SobelFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SobelFiltroBttn.Location = new System.Drawing.Point(1415, 126);
            this.SobelFiltroBttn.Name = "SobelFiltroBttn";
            this.SobelFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.SobelFiltroBttn.TabIndex = 10;
            this.SobelFiltroBttn.Text = "Sobel";
            this.SobelFiltroBttn.UseVisualStyleBackColor = false;
            this.SobelFiltroBttn.Click += new System.EventHandler(this.SobelFiltroBttn_Click);
            this.SobelFiltroBttn.MouseLeave += new System.EventHandler(this.SobelFiltroBttn_MouseLeave);
            this.SobelFiltroBttn.MouseHover += new System.EventHandler(this.SobelFiltroBttn_MouseHover);
            // 
            // GradianteFiltroBttn
            // 
            this.GradianteFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GradianteFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GradianteFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradianteFiltroBttn.Location = new System.Drawing.Point(1415, 244);
            this.GradianteFiltroBttn.Name = "GradianteFiltroBttn";
            this.GradianteFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.GradianteFiltroBttn.TabIndex = 12;
            this.GradianteFiltroBttn.Text = "Gradiante";
            this.GradianteFiltroBttn.UseVisualStyleBackColor = false;
            this.GradianteFiltroBttn.Click += new System.EventHandler(this.GradianteFiltroBttn_Click);
            this.GradianteFiltroBttn.MouseLeave += new System.EventHandler(this.GradianteFiltroBttn_MouseLeave);
            this.GradianteFiltroBttn.MouseHover += new System.EventHandler(this.GradianteFiltroBttn_MouseHover);
            // 
            // trackBarEdicion
            // 
            this.trackBarEdicion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBarEdicion.Location = new System.Drawing.Point(631, 436);
            this.trackBarEdicion.Maximum = 100;
            this.trackBarEdicion.Minimum = 1;
            this.trackBarEdicion.Name = "trackBarEdicion";
            this.trackBarEdicion.Size = new System.Drawing.Size(342, 45);
            this.trackBarEdicion.TabIndex = 34;
            this.trackBarEdicion.TickFrequency = 0;
            this.trackBarEdicion.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarEdicion.Value = 10;
            // 
            // FiltroRojoBttn
            // 
            this.FiltroRojoBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FiltroRojoBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FiltroRojoBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroRojoBttn.Location = new System.Drawing.Point(1667, 244);
            this.FiltroRojoBttn.Name = "FiltroRojoBttn";
            this.FiltroRojoBttn.Size = new System.Drawing.Size(187, 92);
            this.FiltroRojoBttn.TabIndex = 13;
            this.FiltroRojoBttn.Text = "Canal Rojo";
            this.FiltroRojoBttn.UseVisualStyleBackColor = false;
            this.FiltroRojoBttn.Click += new System.EventHandler(this.FiltroRojoBttn_Click);
            this.FiltroRojoBttn.MouseLeave += new System.EventHandler(this.FiltroRojoBttn_MouseLeave);
            this.FiltroRojoBttn.MouseHover += new System.EventHandler(this.FiltroRojoBttn_MouseHover);
            // 
            // AberracionCromaBttn
            // 
            this.AberracionCromaBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AberracionCromaBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AberracionCromaBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AberracionCromaBttn.Location = new System.Drawing.Point(1415, 364);
            this.AberracionCromaBttn.Name = "AberracionCromaBttn";
            this.AberracionCromaBttn.Size = new System.Drawing.Size(187, 92);
            this.AberracionCromaBttn.TabIndex = 14;
            this.AberracionCromaBttn.Text = "Aberracion";
            this.AberracionCromaBttn.UseVisualStyleBackColor = false;
            this.AberracionCromaBttn.Click += new System.EventHandler(this.AberracionCromaBttn_Click);
            this.AberracionCromaBttn.MouseLeave += new System.EventHandler(this.AberracionCromaBttn_MouseLeave);
            this.AberracionCromaBttn.MouseHover += new System.EventHandler(this.AberracionCromaBttn_MouseHover);
            // 
            // ColorizarFiltroBttn
            // 
            this.ColorizarFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColorizarFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColorizarFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorizarFiltroBttn.Location = new System.Drawing.Point(1667, 364);
            this.ColorizarFiltroBttn.Name = "ColorizarFiltroBttn";
            this.ColorizarFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.ColorizarFiltroBttn.TabIndex = 15;
            this.ColorizarFiltroBttn.Text = "Colorizar";
            this.ColorizarFiltroBttn.UseVisualStyleBackColor = false;
            this.ColorizarFiltroBttn.Click += new System.EventHandler(this.ColorizarFiltroBttn_Click);
            this.ColorizarFiltroBttn.MouseLeave += new System.EventHandler(this.ColorizarFiltroBttn_MouseLeave);
            this.ColorizarFiltroBttn.MouseHover += new System.EventHandler(this.ColorizarFiltroBttn_MouseHover);
            // 
            // EspejoFiltroBttn
            // 
            this.EspejoFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EspejoFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EspejoFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EspejoFiltroBttn.Location = new System.Drawing.Point(1415, 485);
            this.EspejoFiltroBttn.Name = "EspejoFiltroBttn";
            this.EspejoFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.EspejoFiltroBttn.TabIndex = 16;
            this.EspejoFiltroBttn.Text = "Espejo";
            this.EspejoFiltroBttn.UseVisualStyleBackColor = false;
            this.EspejoFiltroBttn.Click += new System.EventHandler(this.EspejoFiltroBttn_Click);
            this.EspejoFiltroBttn.MouseLeave += new System.EventHandler(this.EspejoFiltroBttn_MouseLeave);
            this.EspejoFiltroBttn.MouseHover += new System.EventHandler(this.EspejoFiltroBttn_MouseHover);
            // 
            // ContrasteFiltroBttn
            // 
            this.ContrasteFiltroBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContrasteFiltroBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ContrasteFiltroBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContrasteFiltroBttn.Location = new System.Drawing.Point(1667, 485);
            this.ContrasteFiltroBttn.Name = "ContrasteFiltroBttn";
            this.ContrasteFiltroBttn.Size = new System.Drawing.Size(187, 92);
            this.ContrasteFiltroBttn.TabIndex = 17;
            this.ContrasteFiltroBttn.Text = "Constraste";
            this.ContrasteFiltroBttn.UseVisualStyleBackColor = false;
            this.ContrasteFiltroBttn.Click += new System.EventHandler(this.ContrasteFiltroBttn_Click);
            this.ContrasteFiltroBttn.MouseLeave += new System.EventHandler(this.ContrasteFiltroBttn_MouseLeave);
            this.ContrasteFiltroBttn.MouseHover += new System.EventHandler(this.ContrasteFiltroBttn_MouseHover);
            // 
            // FotoFiltroPicBox
            // 
            this.FotoFiltroPicBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FotoFiltroPicBox.Image = ((System.Drawing.Image)(resources.GetObject("FotoFiltroPicBox.Image")));
            this.FotoFiltroPicBox.Location = new System.Drawing.Point(878, 0);
            this.FotoFiltroPicBox.Name = "FotoFiltroPicBox";
            this.FotoFiltroPicBox.Size = new System.Drawing.Size(513, 366);
            this.FotoFiltroPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoFiltroPicBox.TabIndex = 35;
            this.FotoFiltroPicBox.TabStop = false;
            this.FotoFiltroPicBox.Paint += new System.Windows.Forms.PaintEventHandler(this.FotoFiltroPicBox_Paint);
            // 
            // HistogramPicBox
            // 
            this.HistogramPicBox.Location = new System.Drawing.Point(607, 117);
            this.HistogramPicBox.Name = "HistogramPicBox";
            this.HistogramPicBox.Size = new System.Drawing.Size(265, 249);
            this.HistogramPicBox.TabIndex = 36;
            this.HistogramPicBox.TabStop = false;
            // 
            // HistoButton
            // 
            this.HistoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HistoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HistoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoButton.Location = new System.Drawing.Point(1045, 389);
            this.HistoButton.Name = "HistoButton";
            this.HistoButton.Size = new System.Drawing.Size(187, 92);
            this.HistoButton.TabIndex = 37;
            this.HistoButton.Text = "Revisar Histograma";
            this.HistoButton.UseVisualStyleBackColor = false;
            this.HistoButton.Click += new System.EventHandler(this.HistoButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(631, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Valor = 0;";
            // 
            // Fotografias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1866, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoButton);
            this.Controls.Add(this.HistogramPicBox);
            this.Controls.Add(this.FotoFiltroPicBox);
            this.Controls.Add(this.trackBarEdicion);
            this.Controls.Add(this.ContrasteFiltroBttn);
            this.Controls.Add(this.EspejoFiltroBttn);
            this.Controls.Add(this.ColorizarFiltroBttn);
            this.Controls.Add(this.AberracionCromaBttn);
            this.Controls.Add(this.FiltroRojoBttn);
            this.Controls.Add(this.GradianteFiltroBttn);
            this.Controls.Add(this.NegativoFiltroBttn);
            this.Controls.Add(this.SobelFiltroBttn);
            this.Controls.Add(this.CanalAzulFiltroBttn);
            this.Controls.Add(this.FiltroPixeladoBtn);
            this.Controls.Add(this.StartScreenBttn);
            this.Controls.Add(this.SaveImgBttn);
            this.Controls.Add(this.SubirFotoBtn);
            this.Controls.Add(this.FotoOriginalPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fotografias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fotografias";
            this.Load += new System.EventHandler(this.Fotografias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotoOriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEdicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FotoFiltroPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistogramPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox FotoOriginalPictureBox;
        private System.Windows.Forms.Button SubirFotoBtn;
        private System.Windows.Forms.Button SaveImgBttn;
        private System.Windows.Forms.Button StartScreenBttn;
        private System.Windows.Forms.Button FiltroPixeladoBtn;
        private System.Windows.Forms.Button CanalAzulFiltroBttn;
        private System.Windows.Forms.Button NegativoFiltroBttn;
        private System.Windows.Forms.Button SobelFiltroBttn;
        private System.Windows.Forms.Button GradianteFiltroBttn;
        private System.Windows.Forms.TrackBar trackBarEdicion;
        private System.Windows.Forms.Button FiltroRojoBttn;
        private System.Windows.Forms.Button AberracionCromaBttn;
        private System.Windows.Forms.Button ColorizarFiltroBttn;
        private System.Windows.Forms.Button EspejoFiltroBttn;
        private System.Windows.Forms.Button ContrasteFiltroBttn;
        private System.Windows.Forms.PictureBox FotoFiltroPicBox;
        private System.Windows.Forms.PictureBox HistogramPicBox;
        private System.Windows.Forms.Button HistoButton;
        private System.Windows.Forms.Label label1;
    }
}