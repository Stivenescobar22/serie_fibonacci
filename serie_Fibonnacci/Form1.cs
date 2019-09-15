using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serie_Fibonnacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string numero = txtnumero.Text;

            lsbsucesion.Items.Clear();

            int num = int.Parse(numero);
            int numero1 = 0;
            int numero2 = 1;
            int sumnumero3 = 0;


            lsbsucesion.Items.Add(numero1);
            lsbsucesion.Items.Add(numero2);

            lblmensaje.Text = " sucesion fibonaccci - Limite " + num;
            lblmensaje.Visible = true;

            

            for (int i = 3; i <= num; i++){

                if (i <= num){

                    sumnumero3 = numero1 + numero2;
                    lsbsucesion.Items.Add(sumnumero3);
                    numero1 = numero2;
                    numero2 = sumnumero3;

                }

                txtnumero.Text = "";
                txtnumero.Focus();
            }

           
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            lsbsucesion.Items.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)){

                e.Handled = false;

            }else if (char.IsControl(e.KeyChar)){

                e.Handled = false;

            }else if (char.IsSeparator(e.KeyChar)){

                e.Handled = false;
            }else{

                MessageBox.Show("Solo se admiten Numeros"
                    , "Mensaje de Advertencia"
                    ,MessageBoxButtons.OK
                    ,MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }
        }
    }
}
