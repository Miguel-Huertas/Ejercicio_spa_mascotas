
namespace Fase_2_Luis_Huertas
{
    partial class Confirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmar));
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_si = new System.Windows.Forms.Button();
            this.bnt_no = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(67, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "SPA MASCOTAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirme salida del programa ";
            // 
            // btn_si
            // 
            this.btn_si.Image = ((System.Drawing.Image)(resources.GetObject("btn_si.Image")));
            this.btn_si.Location = new System.Drawing.Point(48, 159);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(75, 71);
            this.btn_si.TabIndex = 22;
            this.btn_si.Text = "SI";
            this.btn_si.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_si.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // bnt_no
            // 
            this.bnt_no.Image = ((System.Drawing.Image)(resources.GetObject("bnt_no.Image")));
            this.bnt_no.Location = new System.Drawing.Point(187, 159);
            this.bnt_no.Name = "bnt_no";
            this.bnt_no.Size = new System.Drawing.Size(75, 71);
            this.bnt_no.TabIndex = 23;
            this.bnt_no.Text = "NO";
            this.bnt_no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bnt_no.UseVisualStyleBackColor = true;
            this.bnt_no.Click += new System.EventHandler(this.bnt_no_Click);
            // 
            // Confirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 257);
            this.Controls.Add(this.bnt_no);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Confirmar";
            this.Text = "Confirmar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button bnt_no;
    }
}