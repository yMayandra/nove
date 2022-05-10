using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nove.View
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        private void Calculartabuada() 
        {
            int num = 0;
            num = Convert.ToInt32(tbxNumero.Text);

            for (int i = 0; i<= 10; i++)
            {
                lbxResultado.Items.Add(num + " x " +  i +" = " + num*i);
            }
            tbxNumero.Focus();
            tbxNumero.SelectAll();
        }
        private void Limpartela()
        {
            lbxResultado.Items.Clear();
            tbxNumero.Clear();
            tbxNumero.Focus();
        }

        private void main_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrWhiteSpace(tbxNumero.Text))
                {
                    MessageBox.Show("Digite um Numero");
                    tbxNumero.Focus();
                    tbxNumero.SelectAll();
                    return;
                }
            }
            else
            {
                lbxResultado.Items.Clear();
                Calculartabuada();
            }
            
            if (e.KeyChar == 27)
            {
                Limpartela();
            }
        }
    }
}
