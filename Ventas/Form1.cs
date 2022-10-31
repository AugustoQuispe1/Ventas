using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
    {
    public partial class Form1 :Form
        {
        private int n = 0;
        public Form1()
            {
            InitializeComponent();
            }

        private void btnAgregar_Click(object sender, EventArgs e)
            {
            //Agregamos nueva fila
            int n = dtgvProductos.Rows.Add();

            //Agregar info
            dtgvProductos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtProducto.Text;
            dtgvProductos.Rows[n].Cells[2].Value = Convert.ToDecimal(txtPrecio.Text);


            //Limpiar
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";

            }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
            {
             n = e.RowIndex;

            if(n!=-1)
                {
                lblInformacion.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
                }
            }

        private void btnBorrar_Click(object sender, EventArgs e)
            {
            if (n!=-1)
                {
                dtgvProductos.Rows.RemoveAt(n);
                }
            }

        private void btnCliente_Click(object sender, EventArgs e)
            {
            //Llamaos al otro formulario
            Form formulario = new Form2();
            formulario.Show();
            }
        }
    }
