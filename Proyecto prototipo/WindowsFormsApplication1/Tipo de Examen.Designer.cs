﻿namespace WindowsFormsApplication1
{
    partial class frm_act_examenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_act_examenes));
            this.Lbl_id_examen = new System.Windows.Forms.Label();
            this.Lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_id_xmn = new System.Windows.Forms.TextBox();
            this.gpb_tip_exam = new System.Windows.Forms.GroupBox();
            this.gpb_vista_tips_exam = new System.Windows.Forms.GroupBox();
            this.dgv_vist_tips_exam = new System.Windows.Forms.DataGridView();
            this.btn_busc_tip_exam = new System.Windows.Forms.Button();
            this.btn_actlz_aseg = new System.Windows.Forms.Button();
            this.btn_guardar_aseg = new System.Windows.Forms.Button();
            this.lbl_busc_tip_exam = new System.Windows.Forms.Label();
            this.txt_busc_tips_exam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.gpb_tip_exam.SuspendLayout();
            this.gpb_vista_tips_exam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_tips_exam)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_id_examen
            // 
            this.Lbl_id_examen.AutoSize = true;
            this.Lbl_id_examen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_id_examen.Location = new System.Drawing.Point(21, 19);
            this.Lbl_id_examen.Name = "Lbl_id_examen";
            this.Lbl_id_examen.Size = new System.Drawing.Size(91, 20);
            this.Lbl_id_examen.TabIndex = 48;
            this.Lbl_id_examen.Text = "Id examen:";
            // 
            // Lbl_descripcion
            // 
            this.Lbl_descripcion.AutoSize = true;
            this.Lbl_descripcion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descripcion.Location = new System.Drawing.Point(12, 77);
            this.Lbl_descripcion.Name = "Lbl_descripcion";
            this.Lbl_descripcion.Size = new System.Drawing.Size(100, 20);
            this.Lbl_descripcion.TabIndex = 46;
            this.Lbl_descripcion.Text = "Descripcion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(118, 77);
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(278, 166);
            this.txt_direccion.TabIndex = 45;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.Location = new System.Drawing.Point(40, 48);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre.TabIndex = 44;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(118, 48);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(278, 23);
            this.txt_nombre.TabIndex = 43;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(366, 9);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(232, 34);
            this.Lbl_titulo.TabIndex = 41;
            this.Lbl_titulo.Text = "Tipo de Examen";
            this.Lbl_titulo.Click += new System.EventHandler(this.Lbl_titulo_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(842, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 101);
            this.PictureBox1.TabIndex = 42;
            this.PictureBox1.TabStop = false;
            // 
            // txt_id_xmn
            // 
            this.txt_id_xmn.Location = new System.Drawing.Point(118, 19);
            this.txt_id_xmn.Name = "txt_id_xmn";
            this.txt_id_xmn.Size = new System.Drawing.Size(191, 23);
            this.txt_id_xmn.TabIndex = 49;
            // 
            // gpb_tip_exam
            // 
            this.gpb_tip_exam.Controls.Add(this.Lbl_id_examen);
            this.gpb_tip_exam.Controls.Add(this.txt_id_xmn);
            this.gpb_tip_exam.Controls.Add(this.txt_nombre);
            this.gpb_tip_exam.Controls.Add(this.Lbl_nombre);
            this.gpb_tip_exam.Controls.Add(this.Lbl_descripcion);
            this.gpb_tip_exam.Controls.Add(this.txt_direccion);
            this.gpb_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_tip_exam.Location = new System.Drawing.Point(12, 115);
            this.gpb_tip_exam.Name = "gpb_tip_exam";
            this.gpb_tip_exam.Size = new System.Drawing.Size(402, 251);
            this.gpb_tip_exam.TabIndex = 50;
            this.gpb_tip_exam.TabStop = false;
            this.gpb_tip_exam.Text = "Informacion del Examen";
            // 
            // gpb_vista_tips_exam
            // 
            this.gpb_vista_tips_exam.Controls.Add(this.dgv_vist_tips_exam);
            this.gpb_vista_tips_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_tips_exam.Location = new System.Drawing.Point(420, 116);
            this.gpb_vista_tips_exam.Name = "gpb_vista_tips_exam";
            this.gpb_vista_tips_exam.Size = new System.Drawing.Size(522, 250);
            this.gpb_vista_tips_exam.TabIndex = 51;
            this.gpb_vista_tips_exam.TabStop = false;
            this.gpb_vista_tips_exam.Text = "Tipos de Examenes";
            // 
            // dgv_vist_tips_exam
            // 
            this.dgv_vist_tips_exam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vist_tips_exam.Location = new System.Drawing.Point(6, 18);
            this.dgv_vist_tips_exam.Name = "dgv_vist_tips_exam";
            this.dgv_vist_tips_exam.Size = new System.Drawing.Size(510, 226);
            this.dgv_vist_tips_exam.TabIndex = 0;
            // 
            // btn_busc_tip_exam
            // 
            this.btn_busc_tip_exam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_busc_tip_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_tip_exam.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_tip_exam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_busc_tip_exam.Location = new System.Drawing.Point(722, 78);
            this.btn_busc_tip_exam.Name = "btn_busc_tip_exam";
            this.btn_busc_tip_exam.Size = new System.Drawing.Size(114, 40);
            this.btn_busc_tip_exam.TabIndex = 134;
            this.btn_busc_tip_exam.Text = "BUSCAR";
            this.btn_busc_tip_exam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_busc_tip_exam.UseVisualStyleBackColor = true;
            this.btn_busc_tip_exam.Click += new System.EventHandler(this.btn_busc_tip_exam_Click);
            // 
            // btn_actlz_aseg
            // 
            this.btn_actlz_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_aseg.Location = new System.Drawing.Point(112, 55);
            this.btn_actlz_aseg.Name = "btn_actlz_aseg";
            this.btn_actlz_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_aseg.TabIndex = 133;
            this.btn_actlz_aseg.Text = "ACTUALIZAR";
            this.btn_actlz_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_aseg.UseVisualStyleBackColor = true;
            this.btn_actlz_aseg.Click += new System.EventHandler(this.btn_actlz_aseg_Click);
            // 
            // btn_guardar_aseg
            // 
            this.btn_guardar_aseg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_aseg.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_aseg.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_aseg.Location = new System.Drawing.Point(12, 55);
            this.btn_guardar_aseg.Name = "btn_guardar_aseg";
            this.btn_guardar_aseg.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_aseg.TabIndex = 132;
            this.btn_guardar_aseg.Text = "GUARDAR";
            this.btn_guardar_aseg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_aseg.UseVisualStyleBackColor = true;
            this.btn_guardar_aseg.Click += new System.EventHandler(this.btn_guardar_aseg_Click);
            // 
            // lbl_busc_tip_exam
            // 
            this.lbl_busc_tip_exam.AutoSize = true;
            this.lbl_busc_tip_exam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busc_tip_exam.Location = new System.Drawing.Point(428, 95);
            this.lbl_busc_tip_exam.Name = "lbl_busc_tip_exam";
            this.lbl_busc_tip_exam.Size = new System.Drawing.Size(62, 20);
            this.lbl_busc_tip_exam.TabIndex = 50;
            this.lbl_busc_tip_exam.Text = "Buscar:";
            // 
            // txt_busc_tips_exam
            // 
            this.txt_busc_tips_exam.Location = new System.Drawing.Point(496, 95);
            this.txt_busc_tips_exam.Name = "txt_busc_tips_exam";
            this.txt_busc_tips_exam.Size = new System.Drawing.Size(220, 20);
            this.txt_busc_tips_exam.TabIndex = 51;
            // 
            // frm_act_examenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 374);
            this.Controls.Add(this.lbl_busc_tip_exam);
            this.Controls.Add(this.btn_busc_tip_exam);
            this.Controls.Add(this.txt_busc_tips_exam);
            this.Controls.Add(this.btn_actlz_aseg);
            this.Controls.Add(this.btn_guardar_aseg);
            this.Controls.Add(this.gpb_vista_tips_exam);
            this.Controls.Add(this.gpb_tip_exam);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_act_examenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de Examenes";
            this.Load += new System.EventHandler(this.frm_act_examenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.gpb_tip_exam.ResumeLayout(false);
            this.gpb_tip_exam.PerformLayout();
            this.gpb_vista_tips_exam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vist_tips_exam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Lbl_id_examen;
        internal System.Windows.Forms.Label Lbl_descripcion;
        internal System.Windows.Forms.TextBox txt_direccion;
        internal System.Windows.Forms.Label Lbl_nombre;
        internal System.Windows.Forms.TextBox txt_nombre;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Lbl_titulo;
        internal System.Windows.Forms.TextBox txt_id_xmn;
        private System.Windows.Forms.GroupBox gpb_tip_exam;
        private System.Windows.Forms.GroupBox gpb_vista_tips_exam;
        private System.Windows.Forms.DataGridView dgv_vist_tips_exam;
        private System.Windows.Forms.Button btn_busc_tip_exam;
        private System.Windows.Forms.Button btn_actlz_aseg;
        private System.Windows.Forms.Button btn_guardar_aseg;
        internal System.Windows.Forms.Label lbl_busc_tip_exam;
        internal System.Windows.Forms.TextBox txt_busc_tips_exam;
    }
}