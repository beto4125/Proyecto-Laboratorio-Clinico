﻿namespace WindowsFormsApplication1
{
    partial class Area_de_laboratorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_de_laboratorio));
            this.Pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_area_laboratorio = new System.Windows.Forms.Label();
            this.btn_guardar_area = new System.Windows.Forms.Button();
            this.btn_actlz_area = new System.Windows.Forms.Button();
            this.btn_elim_area = new System.Windows.Forms.Button();
            this.gbp_datos_area_lab = new System.Windows.Forms.GroupBox();
            this.id_area_lab = new System.Windows.Forms.Label();
            this.id_lab = new System.Windows.Forms.Label();
            this.ubicacion_area_lab = new System.Windows.Forms.Label();
            this.descrip_area_lab = new System.Windows.Forms.Label();
            this.txt_id_area_lab = new System.Windows.Forms.TextBox();
            this.txt_id_lab = new System.Windows.Forms.TextBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.txt_descrip_area = new System.Windows.Forms.TextBox();
            this.gbp_vista_labs = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscar_lab = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar_lab = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).BeginInit();
            this.gbp_datos_area_lab.SuspendLayout();
            this.gbp_vista_labs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_logo
            // 
            this.Pic_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("Pic_logo.Image")));
            this.Pic_logo.Location = new System.Drawing.Point(718, 12);
            this.Pic_logo.Name = "Pic_logo";
            this.Pic_logo.Size = new System.Drawing.Size(100, 100);
            this.Pic_logo.TabIndex = 55;
            this.Pic_logo.TabStop = false;
            // 
            // lbl_area_laboratorio
            // 
            this.lbl_area_laboratorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_area_laboratorio.AutoSize = true;
            this.lbl_area_laboratorio.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_laboratorio.Location = new System.Drawing.Point(268, 25);
            this.lbl_area_laboratorio.Name = "lbl_area_laboratorio";
            this.lbl_area_laboratorio.Size = new System.Drawing.Size(291, 34);
            this.lbl_area_laboratorio.TabIndex = 56;
            this.lbl_area_laboratorio.Text = "Área de Laboratorio";
            // 
            // btn_guardar_area
            // 
            this.btn_guardar_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_area.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_area.Location = new System.Drawing.Point(12, 86);
            this.btn_guardar_area.Name = "btn_guardar_area";
            this.btn_guardar_area.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_area.TabIndex = 68;
            this.btn_guardar_area.Text = "GUARDAR";
            this.btn_guardar_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_area.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_area
            // 
            this.btn_actlz_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_area.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_area.Location = new System.Drawing.Point(112, 86);
            this.btn_actlz_area.Name = "btn_actlz_area";
            this.btn_actlz_area.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_area.TabIndex = 150;
            this.btn_actlz_area.Text = "ACTUALIZAR";
            this.btn_actlz_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_area.UseVisualStyleBackColor = true;
            // 
            // btn_elim_area
            // 
            this.btn_elim_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_area.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_area.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_area.Location = new System.Drawing.Point(212, 86);
            this.btn_elim_area.Name = "btn_elim_area";
            this.btn_elim_area.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_area.TabIndex = 151;
            this.btn_elim_area.Text = "ELIMINAR";
            this.btn_elim_area.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_area.UseVisualStyleBackColor = true;
            // 
            // gbp_datos_area_lab
            // 
            this.gbp_datos_area_lab.Controls.Add(this.txt_descrip_area);
            this.gbp_datos_area_lab.Controls.Add(this.txt_ubicacion);
            this.gbp_datos_area_lab.Controls.Add(this.txt_id_lab);
            this.gbp_datos_area_lab.Controls.Add(this.txt_id_area_lab);
            this.gbp_datos_area_lab.Controls.Add(this.descrip_area_lab);
            this.gbp_datos_area_lab.Controls.Add(this.ubicacion_area_lab);
            this.gbp_datos_area_lab.Controls.Add(this.id_lab);
            this.gbp_datos_area_lab.Controls.Add(this.id_area_lab);
            this.gbp_datos_area_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_datos_area_lab.Location = new System.Drawing.Point(12, 167);
            this.gbp_datos_area_lab.Name = "gbp_datos_area_lab";
            this.gbp_datos_area_lab.Size = new System.Drawing.Size(344, 317);
            this.gbp_datos_area_lab.TabIndex = 152;
            this.gbp_datos_area_lab.TabStop = false;
            this.gbp_datos_area_lab.Text = "Ingreso de datos";
            // 
            // id_area_lab
            // 
            this.id_area_lab.AutoSize = true;
            this.id_area_lab.Location = new System.Drawing.Point(6, 30);
            this.id_area_lab.Name = "id_area_lab";
            this.id_area_lab.Size = new System.Drawing.Size(153, 18);
            this.id_area_lab.TabIndex = 0;
            this.id_area_lab.Text = "Id Área de Laboratorio";
            // 
            // id_lab
            // 
            this.id_lab.AutoSize = true;
            this.id_lab.Location = new System.Drawing.Point(6, 90);
            this.id_lab.Name = "id_lab";
            this.id_lab.Size = new System.Drawing.Size(99, 18);
            this.id_lab.TabIndex = 1;
            this.id_lab.Text = "Id Laboratorio";
            // 
            // ubicacion_area_lab
            // 
            this.ubicacion_area_lab.AutoSize = true;
            this.ubicacion_area_lab.Location = new System.Drawing.Point(6, 147);
            this.ubicacion_area_lab.Name = "ubicacion_area_lab";
            this.ubicacion_area_lab.Size = new System.Drawing.Size(74, 18);
            this.ubicacion_area_lab.TabIndex = 2;
            this.ubicacion_area_lab.Text = "Ubicación";
            // 
            // descrip_area_lab
            // 
            this.descrip_area_lab.AutoSize = true;
            this.descrip_area_lab.Location = new System.Drawing.Point(6, 204);
            this.descrip_area_lab.Name = "descrip_area_lab";
            this.descrip_area_lab.Size = new System.Drawing.Size(143, 18);
            this.descrip_area_lab.TabIndex = 3;
            this.descrip_area_lab.Text = "Descripción del área";
            // 
            // txt_id_area_lab
            // 
            this.txt_id_area_lab.Location = new System.Drawing.Point(9, 61);
            this.txt_id_area_lab.Name = "txt_id_area_lab";
            this.txt_id_area_lab.Size = new System.Drawing.Size(315, 24);
            this.txt_id_area_lab.TabIndex = 4;
            // 
            // txt_id_lab
            // 
            this.txt_id_lab.Location = new System.Drawing.Point(9, 111);
            this.txt_id_lab.Name = "txt_id_lab";
            this.txt_id_lab.Size = new System.Drawing.Size(315, 24);
            this.txt_id_lab.TabIndex = 5;
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Location = new System.Drawing.Point(9, 168);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(315, 24);
            this.txt_ubicacion.TabIndex = 6;
            // 
            // txt_descrip_area
            // 
            this.txt_descrip_area.Location = new System.Drawing.Point(9, 234);
            this.txt_descrip_area.Multiline = true;
            this.txt_descrip_area.Name = "txt_descrip_area";
            this.txt_descrip_area.Size = new System.Drawing.Size(315, 77);
            this.txt_descrip_area.TabIndex = 7;
            // 
            // gbp_vista_labs
            // 
            this.gbp_vista_labs.Controls.Add(this.dataGridView1);
            this.gbp_vista_labs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbp_vista_labs.Location = new System.Drawing.Point(371, 167);
            this.gbp_vista_labs.Name = "gbp_vista_labs";
            this.gbp_vista_labs.Size = new System.Drawing.Size(447, 317);
            this.gbp_vista_labs.TabIndex = 153;
            this.gbp_vista_labs.TabStop = false;
            this.gbp_vista_labs.Text = "Laboratorios";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(747, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 54);
            this.button1.TabIndex = 155;
            this.button1.Text = "RENOVAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_lab
            // 
            this.btn_buscar_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_lab.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_buscar_lab.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_buscar_lab.Location = new System.Drawing.Point(676, 120);
            this.btn_buscar_lab.Name = "btn_buscar_lab";
            this.btn_buscar_lab.Size = new System.Drawing.Size(65, 52);
            this.btn_buscar_lab.TabIndex = 156;
            this.btn_buscar_lab.Text = "BUSCAR";
            this.btn_buscar_lab.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscar_lab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 157;
            this.label1.Text = "Buscar";
            // 
            // txt_buscar_lab
            // 
            this.txt_buscar_lab.Location = new System.Drawing.Point(442, 131);
            this.txt_buscar_lab.Name = "txt_buscar_lab";
            this.txt_buscar_lab.Size = new System.Drawing.Size(228, 20);
            this.txt_buscar_lab.TabIndex = 158;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // Area_de_laboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 496);
            this.Controls.Add(this.txt_buscar_lab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar_lab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbp_vista_labs);
            this.Controls.Add(this.gbp_datos_area_lab);
            this.Controls.Add(this.btn_elim_area);
            this.Controls.Add(this.btn_actlz_area);
            this.Controls.Add(this.btn_guardar_area);
            this.Controls.Add(this.lbl_area_laboratorio);
            this.Controls.Add(this.Pic_logo);
            this.Name = "Area_de_laboratorio";
            this.Text = "Area de laboratorio";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_logo)).EndInit();
            this.gbp_datos_area_lab.ResumeLayout(false);
            this.gbp_datos_area_lab.PerformLayout();
            this.gbp_vista_labs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox Pic_logo;
        internal System.Windows.Forms.Label lbl_area_laboratorio;
        private System.Windows.Forms.Button btn_guardar_area;
        private System.Windows.Forms.Button btn_actlz_area;
        private System.Windows.Forms.Button btn_elim_area;
        private System.Windows.Forms.GroupBox gbp_datos_area_lab;
        private System.Windows.Forms.TextBox txt_descrip_area;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.TextBox txt_id_lab;
        private System.Windows.Forms.TextBox txt_id_area_lab;
        private System.Windows.Forms.Label descrip_area_lab;
        private System.Windows.Forms.Label ubicacion_area_lab;
        private System.Windows.Forms.Label id_lab;
        private System.Windows.Forms.Label id_area_lab;
        private System.Windows.Forms.GroupBox gbp_vista_labs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buscar_lab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_buscar_lab;
    }
}