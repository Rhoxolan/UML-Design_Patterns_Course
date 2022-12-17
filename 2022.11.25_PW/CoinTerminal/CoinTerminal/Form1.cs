using CoinTerminalClassLibrary;

namespace CoinTerminal
{
    public partial class Form1 : Form
    {
        private int Sum = 0;
        private CoinHandleFacade coinHandleFacade;

        public Form1()
        {
            InitializeComponent();
            coinHandleFacade = new();
        }

        private void buttonPut_Click(object sender, EventArgs e)
        {
            Coin coin = new Coin
            {
                D = numericUpDownD.Value,
                Thickness = numericUpDownThickness.Value,
                Mass = numericUpDownMass.Value
            };

            int value = coinHandleFacade.CoinHandle(coin);
            if (value == 0)
            {
                textBox1.Text = $"Coin error!";
                return;
            }
            textBox1.Text = $"Added {value} Hryvnia";
            Sum += value;
            textBox2.Text = Sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = Sum.ToString();
        }
    }
}