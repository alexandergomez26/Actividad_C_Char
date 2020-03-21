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
            // instanciar la lógica de negocio

            Notas objeto1 = new Notas();
            int nota1, nota2, nota3, nota4;
            try
            {


                nota1 = Convert.ToInt32(textNota1.Text);
                nota2 = Convert.ToInt32(textNota2.Text);
                nota3 = Convert.ToInt32(textNota3.Text);
                nota4 = Convert.ToInt32(textNota4.Text);

                // Enviar los valores a la lógica de negocio

                objeto1.setNota1 = nota1;
                objeto1.setNota2 = nota2;
                objeto1.setNota3 = nota3;
                objeto1.setNota4 = nota4;

                if (objeto1.Multiplicar())
                {
                    textPromedio.Text = objeto1.getPromedio.ToString();
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
