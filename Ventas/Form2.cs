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
    public partial class Form2 :Form
        {
        private int i = 0;
        public Form2()
            {
            InitializeComponent();
            }

        private void btnAgr_Click(object sender, EventArgs e)
            {
                {
                //Agregamos nueva fila
                int i = DTclientes.Rows.Add();

                //Agregar info
                DTclientes.Rows[i].Cells[0].Value = Convert.ToDecimal(txtDNI.Text);
                DTclientes.Rows[i].Cells[1].Value = txtNombre.Text;
                DTclientes.Rows[i].Cells[2].Value = txtApellido.Text;


                //Limpia
                txtDNI.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";

                }
            }

        private void btnQuitar_Click(object sender, EventArgs e)
            {
            if (i != -1)
                {
                DTclientes.Rows.RemoveAt(i);
                }
            }
        }
    }
