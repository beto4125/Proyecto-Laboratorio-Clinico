﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_act_inventario : Form
    {
        public frm_act_inventario()
        {
            InitializeComponent();
        }

        string codigo = "";
        Boolean Editar;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void grid() {
            string config = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
            string query = String.Format("SELECT * FROM {0}", "inventario_suministro");
            MySqlConnection conexao = new MySqlConnection(config);
            conexao.Open(); MySqlCommand command = new MySqlCommand(query, conexao);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable data = new DataTable(); adapter.Fill(data);
            dgv_vista_inv_sumin.DataSource = data;

        }
        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_aseg_Click(object sender, EventArgs e)
        {
            if (txt_nombre_sm.Text == "" || txt_direccion.Text == "" || txt_cantidad.Text == "" || txt_prec_comp_inv_sumin.Text == "" || txt_prec_vent_inv_sumin.Text == "" || cbo_id_laboratorio.Text == "")
            {
                MessageBox.Show("No se han llenado todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Editar)
                {
                    Conexionmysql.ObtenerConexion();
                    int NumVal = Int32.Parse(codigo);
                    String Query = "update inventario_suministro set pk_id_simin = " + txt_id_inv_sumin.Text + ", existencia_sumin = " + txt_cantidad.Text + ", nombre_sumin = '" + txt_nombre_sm.Text + "', costo_por_unidad_inv_sumin = " + txt_prec_comp_inv_sumin.Text + ", precio_venta_unidad_inv_sumin = " + txt_prec_vent_inv_sumin.Text + ", detalle_sumin = " + txt_direccion.Text + ", pk_id_lab = " + cbo_id_laboratorio.Text + " where pk_id_simin = " + NumVal + ";";
                    cl_gridysql.EjecutarMySql(Query);
                    grid();
                    Conexionmysql.ObtenerConexion();
                    //this.LimpiarCajaTextoEtiqueta();
                    Editar = false;
                }
                else
                {

                    try
                    {
                        string MyConnection2 = "server=localhost; database=proyecto_laboratorio; uid=root; pwd=;";
                        String Query = "insert into inventario_suministro(pk_id_simin, existencia_sumin, nombre_sumin, costo_por_unidad_inv_sumin, precio_venta_unidad_inv_sumin, detalle_sumin, pk_id_lab)values(" + txt_id_inv_sumin.Text + "," + txt_cantidad.Text + ",'" + txt_nombre_sm.Text + "'," + txt_prec_comp_inv_sumin.Text + "," + txt_prec_vent_inv_sumin.Text + "," + txt_direccion.Text + "," + cbo_id_laboratorio.Text + ");";
                        MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                        MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                        MySqlDataReader MyReader2;
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MessageBox.Show("Registro ingresado exitosamente");
                        MyConn2.Close();
                        grid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void frm_act_inventario_Load(object sender, EventArgs e)
        {
            grid();
        }

        private void btn_actlz_aseg_Click(object sender, EventArgs e)
        {
            Editar = true;
            codigo = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
            txt_id_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
            txt_nombre_sm.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[2].Value.ToString();
            txt_direccion.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[5].Value.ToString();
            txt_cantidad.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[1].Value.ToString();
            txt_prec_comp_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[3].Value.ToString();
            txt_prec_vent_inv_sumin.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[4].Value.ToString();
            cbo_id_laboratorio.Text = this.dgv_vista_inv_sumin.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_elim_inv_sumin_Click(object sender, EventArgs e)
        {
            codigo = this.dgv_vista_inv_sumin.CurrentRow.Cells[0].Value.ToString();
            if (codigo == "")
            {
                MessageBox.Show("No se ha seleccionado nada para realizar la eliminacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //preguntamos al usuario si desea eliminar el registro por completo
                var resultado = MessageBox.Show("¿Realmente desea eliminar el registro?", "confirme el borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Proceder a evaluar el resultado
                if (resultado == DialogResult.Yes)//si el usuario hizo click en el boton yes
                {
                    //procedo a hacer el borrado
                    //me conecto a la base de datos
                    Conexionmysql.ObtenerConexion();
                    //armar query...
                    int NumVal = Int32.Parse(codigo);
                    String Query = "delete from inventario_suministro where pk_id_simin = " + NumVal + ";";
                    //ejecutar query
                    cl_gridysql.EjecutarMySql(Query);
                    //Actualize la grid
                    grid();
                    //desconectamos de la base de datos
                    Conexionmysql.Desconectar();
                }
                else
                {
                    //no pasa nada
                    return;
                }
            }
        }

        private void btn_busc_tip_exam_Click(object sender, EventArgs e)
        {
            if (txt_busc_tips_exam.Text == "")
            {
                MessageBox.Show("No se ha escrito nada para realizar la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cl_gridysql.ActualizarGridMuestra(this.dgv_vista_inv_sumin, "select * from inventario_suministro where pk_id_simin like '" + txt_busc_tips_exam.Text + "%';");
            }
        }
    }
}
