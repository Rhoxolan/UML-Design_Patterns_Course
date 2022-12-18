using System.Drawing;

namespace Printer
{
    public partial class Form1 : Form
    {
        Printer printer;

        public Form1()
        {
            InitializeComponent();
            printer = new()
            {
                State = new OffPrinterState()
            };
        }

        private void buttonOn_Click(object sender, EventArgs e)
        {
            textBox1.Text = printer.On();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            textBox1.Text = printer.Off();
        }

        private void buttonRefillPaper_Click(object sender, EventArgs e)
        {
            textBox1.Text = printer.RefillPaper((int)numericUpDown1.Value);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            textBox1.Text = printer.Print();
        }
    }
}