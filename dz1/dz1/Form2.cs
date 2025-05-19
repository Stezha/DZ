using System;
using System.Drawing;
using System.Windows.Forms;

namespace dz1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public string form1Value;
        public int leftPosition;
        private void Form2_Load(object sender, EventArgs e)
        {

            textBox1.Text = form1Value;
            Left = leftPosition;
        }


        public bool Large = true;


        void sizeButtonClick(object sender, EventArgs e)
        {
            if (!Large)
                this.Size = new Size(300, 200);
            else
                this.Size = new Size(600, 400);

            Large = !Large;
        }
    }
}
