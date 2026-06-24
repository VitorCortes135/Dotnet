namespace CalculadoraWindows
{
    public partial class txtCalculadora : Form



      
       
    {
        double  numero1;
        string operacao;
      
        public txtCalculadora()
        {
            InitializeComponent();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDisplay.Text += btn.Text;

            btn1 = (Button)sender;
            txtDisplay.Text += btn1.Text;
            btn2 = (Button)sender;
            txtDisplay.Text += btn2.Text;
            btn3 = (Button)sender;
            txtDisplay.Text += btn3.Text;
            btn4 = (Button)sender;
            txtDisplay.Text += btn4.Text;
            btn5 = (Button)sender;
            txtDisplay.Text += btn5.Text;
            btn6 = (Button)sender;
            txtDisplay.Text += btn6.Text;
            btn7 = (Button)sender;
            txtDisplay.Text += btn7.Text;
            btn8 = (Button)sender;
            txtDisplay.Text += btn8.Text;
            btn9 = (Button)sender;
            txtDisplay.Text += btn9.Text;
            btn0 = (Button)sender;
            txtDisplay.Text += btn0.Text;
        }





        

        private void AdicionarNumero(string numero)
        {
            txtDisplay.Text = numero;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
           txtDisplay.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
          txtDisplay.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           txtDisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
           txtDisplay.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
           numero1 =
                Convert.ToDouble(txtDisplay.Text);
            operacao = "+";
          
        }

       

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double numero2 =
                Convert.ToDouble(txtDisplay.Text);
            double resultado = 0;
            txtDisplay.Clear();
            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    txtDisplay.Text = resultado.ToString();
                    break;
                    case "-":
                    resultado = numero1 - numero2;
                    break;
                    case "*":   
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero2 != 0 ? numero1 / numero2 : 0;
                        break;
            }
            txtDisplay.Text = resultado.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            numero1=
            Convert.ToDouble(txtDisplay.Text);
                operacao = "-" ;
            
            

        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text); operacao = "*" ;
           
        }

        private void btnBarra_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtDisplay.Text) ; operacao = "/" ;
           
        }
    }
}
