
namespace Fase_2_Luis_Huertas
{
    partial class Frmclave
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmclave));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textclave = new System.Windows.Forms.TextBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTRUCURA DE DATOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Luis Miguel Huertas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acceso al sistema ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // textclave
            // 
            this.textclave.Location = new System.Drawing.Point(190, 174);
            this.textclave.Name = "textclave";
            this.textclave.PasswordChar = '*';
            this.textclave.Size = new System.Drawing.Size(100, 23);
            this.textclave.TabIndex = 4;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(159, 220);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(120, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "SPA MASCOTAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Frmclave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 273);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.textclave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frmclave";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Frmclave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textclave;
        private System.Windows.Forms.Button btn_Ingresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}

