﻿namespace WindowsFormsApplication1
{
    partial class Manejo_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manejo_Usuarios));
            this.btn_rnv_user = new System.Windows.Forms.Button();
            this.btn_busc_user = new System.Windows.Forms.Button();
            this.txt_busc_user = new System.Windows.Forms.TextBox();
            this.lbl_busca_user = new System.Windows.Forms.Label();
            this.pl_lab_user = new System.Windows.Forms.PictureBox();
            this.btn_elim_user = new System.Windows.Forms.Button();
            this.btn_actlz_user = new System.Windows.Forms.Button();
            this.btn_guardar_user = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.gpb_datos_user = new System.Windows.Forms.GroupBox();
            this.txt_id_user = new System.Windows.Forms.TextBox();
            this.txt_descp_cargo_emp = new System.Windows.Forms.TextBox();
            this.txt_id_emp_user = new System.Windows.Forms.TextBox();
            this.lbl_id_user = new System.Windows.Forms.Label();
            this.txt_nombre_user = new System.Windows.Forms.TextBox();
            this.Lbl_id_lab_user = new System.Windows.Forms.Label();
            this.Lbl_nombre_user = new System.Windows.Forms.Label();
            this.txt_id_lab_user = new System.Windows.Forms.TextBox();
            this.lbl_contra_user = new System.Windows.Forms.Label();
            this.Lbl_id_emp_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpb_vista_user = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gpb_labs_user = new System.Windows.Forms.GroupBox();
            this.dgv_labs_user = new System.Windows.Forms.DataGridView();
            this.gpb_emps_user = new System.Windows.Forms.GroupBox();
            this.dgv_emps_user = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).BeginInit();
            this.gpb_datos_user.SuspendLayout();
            this.gpb_vista_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpb_labs_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labs_user)).BeginInit();
            this.gpb_emps_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emps_user)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rnv_user
            // 
            this.btn_rnv_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_rnv_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rnv_user.Image = global::WindowsFormsApplication1.Properties.Resources.Recargar;
            this.btn_rnv_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rnv_user.Location = new System.Drawing.Point(644, 59);
            this.btn_rnv_user.Name = "btn_rnv_user";
            this.btn_rnv_user.Size = new System.Drawing.Size(65, 54);
            this.btn_rnv_user.TabIndex = 158;
            this.btn_rnv_user.Text = "RENOVAR";
            this.btn_rnv_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rnv_user.UseVisualStyleBackColor = true;
            // 
            // btn_busc_user
            // 
            this.btn_busc_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_busc_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_busc_user.Image = global::WindowsFormsApplication1.Properties.Resources.Buscar;
            this.btn_busc_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_busc_user.Location = new System.Drawing.Point(575, 61);
            this.btn_busc_user.Name = "btn_busc_user";
            this.btn_busc_user.Size = new System.Drawing.Size(65, 52);
            this.btn_busc_user.TabIndex = 157;
            this.btn_busc_user.Text = "BUSCAR";
            this.btn_busc_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_busc_user.UseVisualStyleBackColor = true;
            // 
            // txt_busc_user
            // 
            this.txt_busc_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_busc_user.Location = new System.Drawing.Point(454, 93);
            this.txt_busc_user.Name = "txt_busc_user";
            this.txt_busc_user.Size = new System.Drawing.Size(115, 20);
            this.txt_busc_user.TabIndex = 156;
            // 
            // lbl_busca_user
            // 
            this.lbl_busca_user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_busca_user.AutoSize = true;
            this.lbl_busca_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_busca_user.Location = new System.Drawing.Point(386, 93);
            this.lbl_busca_user.Name = "lbl_busca_user";
            this.lbl_busca_user.Size = new System.Drawing.Size(62, 20);
            this.lbl_busca_user.TabIndex = 155;
            this.lbl_busca_user.Text = "Buscar:";
            // 
            // pl_lab_user
            // 
            this.pl_lab_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_lab_user.Image = ((System.Drawing.Image)(resources.GetObject("pl_lab_user.Image")));
            this.pl_lab_user.Location = new System.Drawing.Point(717, 8);
            this.pl_lab_user.Name = "pl_lab_user";
            this.pl_lab_user.Size = new System.Drawing.Size(100, 105);
            this.pl_lab_user.TabIndex = 154;
            this.pl_lab_user.TabStop = false;
            // 
            // btn_elim_user
            // 
            this.btn_elim_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_elim_user.Image = global::WindowsFormsApplication1.Properties.Resources.Delete_;
            this.btn_elim_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elim_user.Location = new System.Drawing.Point(212, 61);
            this.btn_elim_user.Name = "btn_elim_user";
            this.btn_elim_user.Size = new System.Drawing.Size(94, 54);
            this.btn_elim_user.TabIndex = 153;
            this.btn_elim_user.Text = "ELIMINAR";
            this.btn_elim_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elim_user.UseVisualStyleBackColor = true;
            // 
            // btn_actlz_user
            // 
            this.btn_actlz_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actlz_user.Image = global::WindowsFormsApplication1.Properties.Resources.Refresh;
            this.btn_actlz_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_actlz_user.Location = new System.Drawing.Point(112, 61);
            this.btn_actlz_user.Name = "btn_actlz_user";
            this.btn_actlz_user.Size = new System.Drawing.Size(94, 54);
            this.btn_actlz_user.TabIndex = 152;
            this.btn_actlz_user.Text = "ACTUALIZAR";
            this.btn_actlz_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_actlz_user.UseVisualStyleBackColor = true;
            // 
            // btn_guardar_user
            // 
            this.btn_guardar_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar_user.Image = global::WindowsFormsApplication1.Properties.Resources.Save_icon1;
            this.btn_guardar_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_user.Location = new System.Drawing.Point(12, 61);
            this.btn_guardar_user.Name = "btn_guardar_user";
            this.btn_guardar_user.Size = new System.Drawing.Size(94, 54);
            this.btn_guardar_user.TabIndex = 151;
            this.btn_guardar_user.Text = "GUARDAR";
            this.btn_guardar_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_user.UseVisualStyleBackColor = true;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(370, 8);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(111, 32);
            this.lbl_usuario.TabIndex = 150;
            this.lbl_usuario.Text = "Usuario";
            // 
            // gpb_datos_user
            // 
            this.gpb_datos_user.Controls.Add(this.comboBox1);
            this.gpb_datos_user.Controls.Add(this.label1);
            this.gpb_datos_user.Controls.Add(this.txt_id_user);
            this.gpb_datos_user.Controls.Add(this.txt_descp_cargo_emp);
            this.gpb_datos_user.Controls.Add(this.txt_id_emp_user);
            this.gpb_datos_user.Controls.Add(this.lbl_id_user);
            this.gpb_datos_user.Controls.Add(this.txt_nombre_user);
            this.gpb_datos_user.Controls.Add(this.Lbl_id_lab_user);
            this.gpb_datos_user.Controls.Add(this.Lbl_nombre_user);
            this.gpb_datos_user.Controls.Add(this.txt_id_lab_user);
            this.gpb_datos_user.Controls.Add(this.lbl_contra_user);
            this.gpb_datos_user.Controls.Add(this.Lbl_id_emp_user);
            this.gpb_datos_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_datos_user.Location = new System.Drawing.Point(12, 121);
            this.gpb_datos_user.Name = "gpb_datos_user";
            this.gpb_datos_user.Size = new System.Drawing.Size(385, 198);
            this.gpb_datos_user.TabIndex = 159;
            this.gpb_datos_user.TabStop = false;
            this.gpb_datos_user.Text = "Informacion General";
            // 
            // txt_id_user
            // 
            this.txt_id_user.Location = new System.Drawing.Point(119, 19);
            this.txt_id_user.Name = "txt_id_user";
            this.txt_id_user.Size = new System.Drawing.Size(174, 23);
            this.txt_id_user.TabIndex = 155;
            // 
            // txt_descp_cargo_emp
            // 
            this.txt_descp_cargo_emp.Location = new System.Drawing.Point(118, 75);
            this.txt_descp_cargo_emp.Name = "txt_descp_cargo_emp";
            this.txt_descp_cargo_emp.PasswordChar = '*';
            this.txt_descp_cargo_emp.Size = new System.Drawing.Size(256, 23);
            this.txt_descp_cargo_emp.TabIndex = 145;
            // 
            // txt_id_emp_user
            // 
            this.txt_id_emp_user.Location = new System.Drawing.Point(172, 104);
            this.txt_id_emp_user.Name = "txt_id_emp_user";
            this.txt_id_emp_user.Size = new System.Drawing.Size(202, 23);
            this.txt_id_emp_user.TabIndex = 145;
            // 
            // lbl_id_user
            // 
            this.lbl_id_user.AutoSize = true;
            this.lbl_id_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_user.Location = new System.Drawing.Point(9, 19);
            this.lbl_id_user.Name = "lbl_id_user";
            this.lbl_id_user.Size = new System.Drawing.Size(86, 20);
            this.lbl_id_user.TabIndex = 152;
            this.lbl_id_user.Text = "Id Usuario:";
            // 
            // txt_nombre_user
            // 
            this.txt_nombre_user.Location = new System.Drawing.Point(119, 48);
            this.txt_nombre_user.Name = "txt_nombre_user";
            this.txt_nombre_user.Size = new System.Drawing.Size(255, 23);
            this.txt_nombre_user.TabIndex = 143;
            // 
            // Lbl_id_lab_user
            // 
            this.Lbl_id_lab_user.AutoSize = true;
            this.Lbl_id_lab_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_lab_user.Location = new System.Drawing.Point(9, 135);
            this.Lbl_id_lab_user.Name = "Lbl_id_lab_user";
            this.Lbl_id_lab_user.Size = new System.Drawing.Size(141, 20);
            this.Lbl_id_lab_user.TabIndex = 149;
            this.Lbl_id_lab_user.Text = "Id de Laboratorio:";
            // 
            // Lbl_nombre_user
            // 
            this.Lbl_nombre_user.AutoSize = true;
            this.Lbl_nombre_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_nombre_user.Location = new System.Drawing.Point(9, 48);
            this.Lbl_nombre_user.Name = "Lbl_nombre_user";
            this.Lbl_nombre_user.Size = new System.Drawing.Size(72, 20);
            this.Lbl_nombre_user.TabIndex = 144;
            this.Lbl_nombre_user.Text = "Nombre:";
            // 
            // txt_id_lab_user
            // 
            this.txt_id_lab_user.Location = new System.Drawing.Point(172, 135);
            this.txt_id_lab_user.Name = "txt_id_lab_user";
            this.txt_id_lab_user.Size = new System.Drawing.Size(202, 23);
            this.txt_id_lab_user.TabIndex = 150;
            // 
            // lbl_contra_user
            // 
            this.lbl_contra_user.AutoSize = true;
            this.lbl_contra_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lbl_contra_user.Location = new System.Drawing.Point(9, 75);
            this.lbl_contra_user.Name = "lbl_contra_user";
            this.lbl_contra_user.Size = new System.Drawing.Size(99, 20);
            this.lbl_contra_user.TabIndex = 146;
            this.lbl_contra_user.Text = "Contraseña:";
            // 
            // Lbl_id_emp_user
            // 
            this.Lbl_id_emp_user.AutoSize = true;
            this.Lbl_id_emp_user.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Lbl_id_emp_user.Location = new System.Drawing.Point(9, 104);
            this.Lbl_id_emp_user.Name = "Lbl_id_emp_user";
            this.Lbl_id_emp_user.Size = new System.Drawing.Size(130, 20);
            this.Lbl_id_emp_user.TabIndex = 146;
            this.Lbl_id_emp_user.Text = "Id de Empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(9, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 156;
            this.label1.Text = "Permiso:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 24);
            this.comboBox1.TabIndex = 158;
            // 
            // gpb_vista_user
            // 
            this.gpb_vista_user.Controls.Add(this.dataGridView1);
            this.gpb_vista_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_vista_user.Location = new System.Drawing.Point(404, 121);
            this.gpb_vista_user.Name = "gpb_vista_user";
            this.gpb_vista_user.Size = new System.Drawing.Size(410, 198);
            this.gpb_vista_user.TabIndex = 160;
            this.gpb_vista_user.TabStop = false;
            this.gpb_vista_user.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // gpb_labs_user
            // 
            this.gpb_labs_user.Controls.Add(this.dgv_labs_user);
            this.gpb_labs_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_labs_user.Location = new System.Drawing.Point(434, 325);
            this.gpb_labs_user.Name = "gpb_labs_user";
            this.gpb_labs_user.Size = new System.Drawing.Size(380, 122);
            this.gpb_labs_user.TabIndex = 162;
            this.gpb_labs_user.TabStop = false;
            this.gpb_labs_user.Text = "Laboratorios";
            // 
            // dgv_labs_user
            // 
            this.dgv_labs_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_labs_user.Location = new System.Drawing.Point(6, 19);
            this.dgv_labs_user.Name = "dgv_labs_user";
            this.dgv_labs_user.Size = new System.Drawing.Size(368, 94);
            this.dgv_labs_user.TabIndex = 0;
            // 
            // gpb_emps_user
            // 
            this.gpb_emps_user.Controls.Add(this.dgv_emps_user);
            this.gpb_emps_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_emps_user.Location = new System.Drawing.Point(12, 325);
            this.gpb_emps_user.Name = "gpb_emps_user";
            this.gpb_emps_user.Size = new System.Drawing.Size(416, 122);
            this.gpb_emps_user.TabIndex = 161;
            this.gpb_emps_user.TabStop = false;
            this.gpb_emps_user.Text = "Empleados";
            // 
            // dgv_emps_user
            // 
            this.dgv_emps_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emps_user.Location = new System.Drawing.Point(6, 19);
            this.dgv_emps_user.Name = "dgv_emps_user";
            this.dgv_emps_user.Size = new System.Drawing.Size(397, 94);
            this.dgv_emps_user.TabIndex = 0;
            // 
            // Manejo_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 452);
            this.Controls.Add(this.gpb_labs_user);
            this.Controls.Add(this.gpb_emps_user);
            this.Controls.Add(this.gpb_vista_user);
            this.Controls.Add(this.gpb_datos_user);
            this.Controls.Add(this.btn_rnv_user);
            this.Controls.Add(this.btn_busc_user);
            this.Controls.Add(this.txt_busc_user);
            this.Controls.Add(this.lbl_busca_user);
            this.Controls.Add(this.pl_lab_user);
            this.Controls.Add(this.btn_elim_user);
            this.Controls.Add(this.btn_actlz_user);
            this.Controls.Add(this.btn_guardar_user);
            this.Controls.Add(this.lbl_usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manejo_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pl_lab_user)).EndInit();
            this.gpb_datos_user.ResumeLayout(false);
            this.gpb_datos_user.PerformLayout();
            this.gpb_vista_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpb_labs_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_labs_user)).EndInit();
            this.gpb_emps_user.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emps_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rnv_user;
        private System.Windows.Forms.Button btn_busc_user;
        internal System.Windows.Forms.TextBox txt_busc_user;
        internal System.Windows.Forms.Label lbl_busca_user;
        internal System.Windows.Forms.PictureBox pl_lab_user;
        private System.Windows.Forms.Button btn_elim_user;
        private System.Windows.Forms.Button btn_actlz_user;
        private System.Windows.Forms.Button btn_guardar_user;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.GroupBox gpb_datos_user;
        internal System.Windows.Forms.TextBox txt_id_user;
        internal System.Windows.Forms.TextBox txt_descp_cargo_emp;
        internal System.Windows.Forms.TextBox txt_id_emp_user;
        internal System.Windows.Forms.Label lbl_id_user;
        internal System.Windows.Forms.TextBox txt_nombre_user;
        internal System.Windows.Forms.Label Lbl_id_lab_user;
        internal System.Windows.Forms.Label Lbl_nombre_user;
        internal System.Windows.Forms.TextBox txt_id_lab_user;
        internal System.Windows.Forms.Label lbl_contra_user;
        internal System.Windows.Forms.Label Lbl_id_emp_user;
        internal System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gpb_vista_user;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gpb_labs_user;
        private System.Windows.Forms.DataGridView dgv_labs_user;
        private System.Windows.Forms.GroupBox gpb_emps_user;
        private System.Windows.Forms.DataGridView dgv_emps_user;
    }
}