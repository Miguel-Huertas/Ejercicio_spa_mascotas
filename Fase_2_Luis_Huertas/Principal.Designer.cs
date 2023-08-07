
namespace Fase_2_Luis_Huertas
{
    partial class SPA_Mascotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SPA_Mascotas));
            this.Identificación = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Ide = new System.Windows.Forms.TextBox();
            this.txt_Nbre = new System.Windows.Forms.TextBox();
            this.txt_N_Mtas = new System.Windows.Forms.TextBox();
            this.txt_Costo = new System.Windows.Forms.TextBox();
            this.combo_Estrato = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt_3 = new System.Windows.Forms.RadioButton();
            this.ops_2 = new System.Windows.Forms.RadioButton();
            this.opt_1 = new System.Windows.Forms.RadioButton();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.bnt_Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.error_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_nom = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_nom_mas = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nom_mas)).BeginInit();
            this.SuspendLayout();
            // 
            // Identificación
            // 
            this.Identificación.AutoSize = true;
            this.Identificación.Location = new System.Drawing.Point(12, 39);
            this.Identificación.Name = "Identificación";
            this.Identificación.Size = new System.Drawing.Size(79, 15);
            this.Identificación.TabIndex = 0;
            this.Identificación.Text = "Identificación";
            this.Identificación.Click += new System.EventHandler(this.Identificación_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servicio elegido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estrato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre mascota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre ";
            // 
            // txt_Ide
            // 
            this.txt_Ide.Location = new System.Drawing.Point(115, 36);
            this.txt_Ide.Name = "txt_Ide";
            this.txt_Ide.Size = new System.Drawing.Size(154, 23);
            this.txt_Ide.TabIndex = 5;
            // 
            // txt_Nbre
            // 
            this.txt_Nbre.Location = new System.Drawing.Point(115, 65);
            this.txt_Nbre.Name = "txt_Nbre";
            this.txt_Nbre.Size = new System.Drawing.Size(203, 23);
            this.txt_Nbre.TabIndex = 6;
            // 
            // txt_N_Mtas
            // 
            this.txt_N_Mtas.Location = new System.Drawing.Point(115, 94);
            this.txt_N_Mtas.Name = "txt_N_Mtas";
            this.txt_N_Mtas.Size = new System.Drawing.Size(203, 23);
            this.txt_N_Mtas.TabIndex = 7;
            // 
            // txt_Costo
            // 
            this.txt_Costo.Enabled = false;
            this.txt_Costo.Location = new System.Drawing.Point(115, 262);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Size = new System.Drawing.Size(332, 23);
            this.txt_Costo.TabIndex = 8;
            this.txt_Costo.TextChanged += new System.EventHandler(this.txt_Costo_TextChanged);
            // 
            // combo_Estrato
            // 
            this.combo_Estrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Estrato.FormattingEnabled = true;
            this.combo_Estrato.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.combo_Estrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.combo_Estrato.Location = new System.Drawing.Point(115, 126);
            this.combo_Estrato.Name = "combo_Estrato";
            this.combo_Estrato.Size = new System.Drawing.Size(121, 23);
            this.combo_Estrato.TabIndex = 9;
            this.combo_Estrato.SelectedIndexChanged += new System.EventHandler(this.combo_Estrato_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opt_3);
            this.groupBox1.Controls.Add(this.ops_2);
            this.groupBox1.Controls.Add(this.opt_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 101);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Servicio";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // opt_3
            // 
            this.opt_3.AutoSize = true;
            this.opt_3.Location = new System.Drawing.Point(22, 69);
            this.opt_3.Name = "opt_3";
            this.opt_3.Size = new System.Drawing.Size(341, 19);
            this.opt_3.TabIndex = 2;
            this.opt_3.TabStop = true;
            this.opt_3.Text = "Baño, corte, Vacunas antigarrapatas y Antiparásitos $100.000";
            this.opt_3.UseVisualStyleBackColor = true;
            this.opt_3.CheckedChanged += new System.EventHandler(this.opt_3_CheckedChanged);
            // 
            // ops_2
            // 
            this.ops_2.AutoSize = true;
            this.ops_2.Location = new System.Drawing.Point(22, 44);
            this.ops_2.Name = "ops_2";
            this.ops_2.Size = new System.Drawing.Size(258, 19);
            this.ops_2.TabIndex = 1;
            this.ops_2.TabStop = true;
            this.ops_2.Text = "Baño, corte y vacuna antigarrapatas, $80.000";
            this.ops_2.UseVisualStyleBackColor = true;
            this.ops_2.CheckedChanged += new System.EventHandler(this.ops_2_CheckedChanged);
            // 
            // opt_1
            // 
            this.opt_1.AutoSize = true;
            this.opt_1.Location = new System.Drawing.Point(22, 19);
            this.opt_1.Name = "opt_1";
            this.opt_1.Size = new System.Drawing.Size(136, 19);
            this.opt_1.TabIndex = 0;
            this.opt_1.TabStop = true;
            this.opt_1.Text = "Baño y corte, $45.000";
            this.opt_1.UseVisualStyleBackColor = true;
            this.opt_1.CheckedChanged += new System.EventHandler(this.opt_1_CheckedChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(95, 291);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(62, 64);
            this.btn_Guardar.TabIndex = 14;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Enabled = false;
            this.btn_Mostrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Mostrar.Image")));
            this.btn_Mostrar.Location = new System.Drawing.Point(217, 291);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(75, 64);
            this.btn_Mostrar.TabIndex = 15;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // bnt_Salir
            // 
            this.bnt_Salir.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Salir.Image")));
            this.bnt_Salir.Location = new System.Drawing.Point(372, 291);
            this.bnt_Salir.Name = "bnt_Salir";
            this.bnt_Salir.Size = new System.Drawing.Size(75, 64);
            this.bnt_Salir.TabIndex = 16;
            this.bnt_Salir.Text = "salir";
            this.bnt_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bnt_Salir.UseVisualStyleBackColor = true;
            this.bnt_Salir.Click += new System.EventHandler(this.bnt_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(409, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 87);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label7.Location = new System.Drawing.Point(194, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "SPA MASCOTAS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // error_id
            // 
            this.error_id.ContainerControl = this;
            // 
            // error_nom
            // 
            this.error_nom.ContainerControl = this;
            // 
            // error_nom_mas
            // 
            this.error_nom_mas.ContainerControl = this;
            // 
            // SPA_Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 367);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnt_Salir);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_Estrato);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.txt_N_Mtas);
            this.Controls.Add(this.txt_Nbre);
            this.Controls.Add(this.txt_Ide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Identificación);
            this.Name = "SPA_Mascotas";
            this.Text = "SPA_Mascotas";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_nom_mas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Identificación;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Ide;
        private System.Windows.Forms.TextBox txt_Nbre;
        private System.Windows.Forms.TextBox txt_N_Mtas;
        private System.Windows.Forms.TextBox txt_Costo;
        private System.Windows.Forms.ComboBox combo_Estrato;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt_1;
        private System.Windows.Forms.RadioButton opt_3;
        private System.Windows.Forms.RadioButton ops_2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button bnt_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider error_id;
        private System.Windows.Forms.ErrorProvider error_nom;
        private System.Windows.Forms.ErrorProvider error_nom_mas;
    }
}