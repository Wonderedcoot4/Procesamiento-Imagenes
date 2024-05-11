
namespace WindowsFormsApp1
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FotosBttn = new System.Windows.Forms.Button();
            this.VideosBttn = new System.Windows.Forms.Button();
            this.CamaraBtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(399, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "FotoTeca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(334, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Donde los recuerdos renance";
            // 
            // FotosBttn
            // 
            this.FotosBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FotosBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FotosBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotosBttn.Location = new System.Drawing.Point(189, 349);
            this.FotosBttn.Name = "FotosBttn";
            this.FotosBttn.Size = new System.Drawing.Size(187, 92);
            this.FotosBttn.TabIndex = 2;
            this.FotosBttn.Text = "Fotografias";
            this.FotosBttn.UseVisualStyleBackColor = false;
            this.FotosBttn.Click += new System.EventHandler(this.FotosBttn_Click);
            // 
            // VideosBttn
            // 
            this.VideosBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.VideosBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VideosBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideosBttn.Location = new System.Drawing.Point(733, 349);
            this.VideosBttn.Name = "VideosBttn";
            this.VideosBttn.Size = new System.Drawing.Size(187, 92);
            this.VideosBttn.TabIndex = 3;
            this.VideosBttn.Text = "Videos";
            this.VideosBttn.UseVisualStyleBackColor = false;
            this.VideosBttn.Click += new System.EventHandler(this.VideosBttn_Click);
            // 
            // CamaraBtton
            // 
            this.CamaraBtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CamaraBtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CamaraBtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CamaraBtton.Location = new System.Drawing.Point(465, 349);
            this.CamaraBtton.Name = "CamaraBtton";
            this.CamaraBtton.Size = new System.Drawing.Size(187, 92);
            this.CamaraBtton.TabIndex = 4;
            this.CamaraBtton.Text = "Camara";
            this.CamaraBtton.UseVisualStyleBackColor = false;
            this.CamaraBtton.Click += new System.EventHandler(this.CamaraBtton_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1146, 520);
            this.Controls.Add(this.CamaraBtton);
            this.Controls.Add(this.VideosBttn);
            this.Controls.Add(this.FotosBttn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FotosBttn;
        private System.Windows.Forms.Button VideosBttn;
        private System.Windows.Forms.Button CamaraBtton;
    }
}

