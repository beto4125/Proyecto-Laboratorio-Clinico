﻿namespace WindowsFormsApplication1
{
    partial class frm_act_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_lab));
            this.lbl_id_lab = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_correo = new System.Windows.Forms.Label();
            this.Lbl_telefono = new System.Windows.Forms.Label();
            this.Lbl_direccion = new System.Windows.Forms.Label();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_inventario_suministro = new System.Windows.Forms.Label();
            this.gpb_datos_labs = new System.Windows.Forms.GroupBox();
            this.txt_id_labs = new System.Windows.Forms.TextBox();
            this.gpb_vista_labs = new System.Windows.Forms.GroupBox();
            this.dgv_labs = new System.Windows.Forms.DataGridView();
            this.txt_busc_lab = new System.Windows.Forms.TextBox();
            this.lbl_busca_lab = new System.Windows.Forms.Label();
            this.btn_renovar_lab = new System.Windows.Forms.Button();
            this.btn_busc_lab = new System.Windows.Forms.Button();
            this.btn_elim_pcnt = new System.Windows.Forms.Button();
            this.btn_actlz_pcnt = new System.Windows.Forms.Button();
            this.btn_guardar_pcnt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpb_datos_labs.SuspendLayout();
            this.gpb_vista_labs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_id_lab
            // 
            this.lbl_id_lab.AutoSize = true;
            this.lbl_id_lab.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lbl_id_lab.Location = new System.Drawing.Point(6, 19);
            this.lbl_id_lab.Name = "lbl_id_lab";
            this.lbl_id_lab.Size = new System.Drawing.Size(117, 20);
            this.lbl_id_lab.TabIndex = 26;
            this.lbl_id_lab.Text = "Id Laboratorio:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(129, 172);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(195, 23);
            this.txt_telefono.TabIndex = 24;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(129, 143);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(309, 23);
            this.txt_correo.TabIndex = 23;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(129, 78);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(309, 59);
            this.txt_direccion.TabIndex = 22;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 48);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(309, 23);
            this.txt_nombre.TabIndex = 21;
            // 
            // Lbl_correo
            // 
            this.Lbl_correo.AutoSize = true;
            this.Lbl_correo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_correo.Location = new System.Drawing.Point(58, 142);
            this.Lbl_correo.Name = "Lbl_correo";
            this.Lbl_correo.Size = new System.Drawing.Size(65, 20);
            this.Lbl_correo.TabIndex = 19;
            this.Lbl_correo.Text = "Correo:";
            // 
            // Lbl_telefono
            // 
            this.Lbl_telefono.AutoSize = true;
            this.Lbl_telefono.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_telefono.Location = new System.Drawing.Point(48, 172);
            this.Lbl_telefono.Name = "Lbl_telefono";
            this.Lbl_telefono.Size = new System.Drawing.Size(75, 20);
            this.Lbl_telefono.TabIndex = 18;
            this.Lbl_telefono.Text = "Telefono:";
            // 
            // Lbl_direccion
            // 
            this.Lbl_direccion.AutoSize = true;
            this.Lbl_direccion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_direccion.Location = new System.Drawing.Point(39, 78);
            this.Lbl_direccion.Name = "Lbl_direccion";
            this.Lbl_direccion.Size = new System.Drawing.Size(84, 20);
            this.Lbl_direccion.TabIndex = 17;
            this.Lbl_direccion.Text = "Direccion:";
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Lbl_nombre.Location = new System.Drawing.Point(51, 48);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 16;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // Lbl_inventario_suministro
            // 
            this.Lbl_inventario_suministro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_inventario_suministro.AutoSize = true;
            this.Lbl_inventario_suministro.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold);
            this.Lbl_inventario_suministro.Location = new System.Drawing.Point(558, 9);
            this.Lbl_inventario_suministro.Name = "Lbl_inventario_suministro";
            this.Lbl_inventario_suministro.Size = new System.Drawing.Size(180, 34);
            this.Lbl_inventario_suministro.TabIndex = 15;
            this.Lbl_inventario_suministro.Text = "Laboratorios";
            // 
            // gpb_datos_labs
            // 
            this.gpb_datos_labs.Controls.Add(this.txt_id_labs);
            this.gpb_datos_labs.Controls.Add(this.txt_telefono);
            this.gpb_datos_labs.Controls.Add(this.Lbl_nombre);
            this.gpb_datos_labs.Controls.Add(this.lbl_id_lab);
            this.gpb_datos_labs.Controls.Add(this.Lbl_direccion);
            this.gpb_datos_labs.Controls.Add(this.Lbl_telefono);
            this.gpb_datos_labs.Controls.Add(this.txt_correo);
            this.gpb_datos_labs.Controls.Add(this.Lbl_correo);
            this.gpb_datos_labs.Controls.Add(this.txt_direccion);
            this.gpb_datos_labs.Controls.Add(this.txt_nombre);
            this.gpb_datos_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_labs.Location = new System.Drawing.Point(12, 120);
            this.gpb_datos_labs.Name = "gpb_datos_labs";
            this.gpb_datos_labs.Size = new System.Drawing.Size(459, 210);
            this.gpb_datos_labs.TabIndex = 28;
            this.gpb_datos_labs.TabStop = false;
            this.gpb_datos_labs.Text = "Datos Generales";
            // 
            // txt_id_labs
            // 
            this.txt_id_labs.Location = new System.Drawing.Point(121, 19);
            this.txt_id_labs.Name = "txt_id_labs";
            this.txt_id_labs.Size = new System.Drawing.Size(203, 23);
            this.txt_id_labs.TabIndex = 27;
            this.txt_id_labs.TextChanged += new System.EventHandler(this.txt_id_labs_TextChanged);
            // 
            // gpb_vista_labs
            // 
            this.gpb_vista_labs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_vista_labs.Controls.Add(this.dgv_labs);
            this.gpb_vista_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_labs.Location = new System.Drawing.Point(477, 119);
            this.gpb_vista_labs.Name = "gpb_vista_labs";
            this.gpb_vista_labs.Size = new System.Drawing.Size(771, 210);
            this.gpb_vista_labs.TabIndex = 29;
            this.gpb_vista_labs.TabStop = false;
            this.gpb_vista_labs.Text = "Laboratorios";
            // 
            // dgv_labs
            // 
            this.dgv_labs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_labs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labs.Location = new System.Drawing.Point(6, 22);
            this.dgv_labs.Name = "dgv_labs";
            this.dgv_labs.Size = new System.Drawing.Size(759, 182);
            this.dgv_labs.TabIndex = 0;
            this.dgv_labs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_labs_CellContentClick);
            // 
            // txt_busc_lab
            // 
            this.txt_busc_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busc_lab.Location = new System.Drawing.Point(628, 90);
            this.txt_busc_lab.Name = "txt_busc_lab";
            this.txt_busc_lab.Size = new System.Drawing.Size(354, 20);
            this.txt_busc_lab.TabIndex = 143;
            this.txt_busc_lab.TextChanged += new System.EventHandler(this.txt_busc_lab_TextChanged);
            // 
            // lbl_busca_lab
            // 
            this.lbl_busca_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busca_lab.AutoSize = true;
            this.lbl_busca_lab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_lab.Location = new System.Drawing.Point(560, 92);
            this.lbl_busca_lab.Name = "lbl_busca_lab";
            this.lbl_busca_lab.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_lab.TabIndex = 142;
            this.lbl_busca_lab.Text = "Buscar:";
            this.lbl_busca_lab.Click += new System.EventHandler(this.lbl_busca_lab_Click);
            // 
            // btn_renovar_lab
            // 
            this.btn_renovar_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_renovar_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_renovar_lab.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_renovar_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_renovar_lab.Location = new System.Drawing.Point(1059, 60);
            this.btn_renovar_lab.Name = "btn_renovar_lab";
            this.btn_renovar_lab.Size = new System.Drawing.Size(65, 54);
            this.btn_renovar_lab.TabIndex = 145;
            this.btn_renovar_lab.Text = "RENOVAR";
            this.btn_renovar_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_renovar_lab.UseVisualStyleBackColor = true;
            this.btn_renovar_lab.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_busc_lab
            // 
            this.btn_busc_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_busc_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_lab.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_lab.Location = new System.Drawing.Point(988, 62);
            this.btn_busc_lab.Name = "btn_busc_lab";
            this.btn_busc_lab.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_lab.TabIndex = 144;
            this.btn_busc_lab.Text = "BUSCAR";
            this.btn_busc_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_lab.UseVisualStyleBackColor = true;
            this.btn_busc_lab.Click += new System.EventHandler(this.btn_busc_lab_Click);
            // 
            // btn_elim_pcnt
            // 
            this.btn_elim_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_pcnt.Location = new System.Drawing.Point(212, 60);
            this.btn_elim_pcnt.Name = "btn_elim_pcnt";
            this.btn_elim_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_pcnt.TabIndex = 141;
            this.btn_elim_pcnt.Text = "ELIMINAR";
            this.btn_elim_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_pcnt.UseVisualStyleBackColor = true;
            this.btn_elim_pcnt.Click += new System.EventHandler(this.btn_elim_pcnt_Click);
            // 
            // btn_actlz_pcnt
            // 
            this.btn_actlz_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_pcnt.Location = new System.Drawing.Point(112, 60);
            this.btn_actlz_pcnt.Name = "btn_actlz_pcnt";
            this.btn_actlz_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_pcnt.TabIndex = 140;
            this.btn_actlz_pcnt.Text = "ACTUALIZAR";
            this.btn_actlz_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_pcnt.UseVisualStyleBackColor = true;
            this.btn_actlz_pcnt.Click += new System.EventHandler(this.btn_actlz_pcnt_Click);
            // 
            // btn_guardar_pcnt
            // 
            this.btn_guardar_pcnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_pcnt.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_pcnt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_pcnt.Location = new System.Drawing.Point(12, 60);
            this.btn_guardar_pcnt.Name = "btn_guardar_pcnt";
            this.btn_guardar_pcnt.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_pcnt.TabIndex = 139;
            this.btn_guardar_pcnt.Text = "GUARDAR";
            this.btn_guardar_pcnt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_pcnt.UseVisualStyleBackColor = true;
            this.btn_guardar_pcnt.Click += new System.EventHandler(this.btn_guardar_pcnt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1130, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 102);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frm_act_lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 337);
            this.Controls.Add(this.btn_renovar_lab);
            this.Controls.Add(this.btn_busc_lab);
            this.Controls.Add(this.txt_busc_lab);
            this.Controls.Add(this.lbl_busca_lab);
            this.Controls.Add(this.btn_elim_pcnt);
            this.Controls.Add(this.btn_actlz_pcnt);
            this.Controls.Add(this.btn_guardar_pcnt);
            this.Controls.Add(this.gpb_vista_labs);
            this.Controls.Add(this.gpb_datos_labs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_inventario_suministro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Laboratorio";
            this.Load += new System.EventHandler(this.frm_act_lab_Load);
            this.gpb_datos_labs.ResumeLayout(false);
            this.gpb_datos_labs.PerformLayout();
            this.gpb_vista_labs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_id_lab;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label Lbl_correo;
        private System.Windows.Forms.Label Lbl_telefono;
        private System.Windows.Forms.Label Lbl_direccion;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_inventario_suministro;
        private System.Windows.Forms.GroupBox gpb_datos_labs;
        private System.Windows.Forms.TextBox txt_id_labs;
        private System.Windows.Forms.GroupBox gpb_vista_labs;
        private System.Windows.Forms.DataGridView dgv_labs;
        private System.Windows.Forms.Button btn_elim_pcnt;
        private System.Windows.Forms.Button btn_actlz_pcnt;
        private System.Windows.Forms.Button btn_guardar_pcnt;
        private System.Windows.Forms.Button btn_busc_lab;
        internal System.Windows.Forms.TextBox txt_busc_lab;
        internal System.Windows.Forms.Label lbl_busca_lab;
        private System.Windows.Forms.Button btn_renovar_lab;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}