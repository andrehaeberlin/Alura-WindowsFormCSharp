namespace CursoWindowsForms
{
    partial class Frm_ArquivoImagem_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_ArquivoImagem = new System.Windows.Forms.Label();
            this.Pic_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ArquivoImagem
            // 
            this.Lbl_ArquivoImagem.AutoSize = true;
            this.Lbl_ArquivoImagem.Location = new System.Drawing.Point(24, 23);
            this.Lbl_ArquivoImagem.Name = "Lbl_ArquivoImagem";
            this.Lbl_ArquivoImagem.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ArquivoImagem.TabIndex = 0;
            this.Lbl_ArquivoImagem.Text = "label1";
            // 
            // Pic_Image
            // 
            this.Pic_Image.Location = new System.Drawing.Point(27, 55);
            this.Pic_Image.Name = "Pic_Image";
            this.Pic_Image.Size = new System.Drawing.Size(209, 156);
            this.Pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_Image.TabIndex = 1;
            this.Pic_Image.TabStop = false;
            // 
            // Frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pic_Image);
            this.Controls.Add(this.Lbl_ArquivoImagem);
            this.Name = "Frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(670, 397);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ArquivoImagem;
        private System.Windows.Forms.PictureBox Pic_Image;
    }
}
