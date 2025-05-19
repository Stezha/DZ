using System;
using System.Windows.Forms;

namespace dz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            go.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text)
                && !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            go.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text)
                && !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "sum", "exp", "abs" });


            go.Enabled = false;

        }

        void goClick(object sender, EventArgs e)
        {

            double firstVar, secondVar, resultVar = 0;
            int selectedItem;

            firstVar = Convert.ToDouble(textBox1.Text);
            secondVar = Convert.ToDouble(textBox2.Text);

            selectedItem = comboBox1.SelectedIndex;


            if (selectedItem < 0)
            {
                MessageBox.Show("Не выбрана математическая операция", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (selectedItem == 0)
            {
                resultVar = firstVar + secondVar;
            }
            if (selectedItem == 1)
            {
                resultVar = Math.Exp(firstVar);
            }
            if (selectedItem == 2)
            {
                resultVar = Math.Abs(firstVar - secondVar);
            }


            textBox3.Text = resultVar.ToString();
        }

        public double form1Value;
        void ButtonSkipClick(object sender, EventArgs e)
        {
            Form2 myForm2 = new Form2();
            myForm2.form1Value = textBox3.Text;
            myForm2.Show();
            myForm2.leftPosition = Left + Width;
        }


    }
}
