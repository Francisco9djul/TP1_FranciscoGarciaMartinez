using MaterialSkin2DotNet.Controls;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FormularioTP1
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ------------funciones---------------
        public bool CompararCadenas(string texto1, string texto2)
        {
            return texto1 == texto2;
        }

        public bool EsNumeroPrimo(int numero)
        {
            // Los números menores a 2 no son primos
            if (numero < 2)
                return false;

            // Verifica si el número tiene divisores distintos de 1 y él mismo
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }

        //-----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }


        private void textBox6_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string texto1 = textBox1.Text;
            string texto2 = textBox2.Text;

            bool sonIguales = CompararCadenas(texto1, texto2);

            if (sonIguales)
            {
                textBox4.Text = "Las cadenas son iguales.";
            }
            else
            {
                textBox4.Text = "Las cadenas son diferentes.";
            }

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Convertir el texto del TextBox a un número entero
            if (int.TryParse(textBox3.Text, out int numero))
            {
                // Llamar a la función para verificar si el número es primo
                bool esPrimo = EsNumeroPrimo(numero);

                // Mostrar el resultado en el Label
                if (esPrimo)
                {
                    textBox5.Text = $"{numero} es un número primo.";
                }
                else
                {
                    textBox5.Text = $"{numero} no es un número primo.";
                }
            }
            else
            {
                // Mostrar un mensaje de error si la conversión falla
                textBox5.Text = "Por favor, ingrese un número válido.";
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            textBox6.Text = $"{DateTime.Now}";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
