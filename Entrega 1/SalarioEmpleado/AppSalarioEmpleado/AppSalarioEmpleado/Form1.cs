using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_LogicaSalario;

namespace AppSalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Instanciar la lógica del negocio

            Salario objeto1 = new Salario();
            int sueldo, dias;
            try
            {


                sueldo = Convert.ToInt32(textDias.Text);
                dias = Convert.ToInt32(textSueldo.Text);

                // Enviar los valores a la lógica de negocio

                objeto1.setSueldo = sueldo;
                objeto1.setDias = dias;

                if (objeto1.Calcular())
                {
                    textSalario.Text = objeto1.getSalario.ToString();
                    return;

                }
                MessageBox.Show(objeto1.geterror);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
