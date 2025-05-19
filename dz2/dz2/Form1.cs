using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dz2
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

        string filename;

        private void open_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "rtf files (*.rtf) |*.rtf";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        filename = openFileDialog1.FileName;
                        richTextBox1.LoadFile(filename);
                        toolStripStatusLabel1.Text = openFileDialog1.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка : Не получилось прочитать файл, подробнее:" + ex.Message);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Pen pen = new Pen(Color.Red, 2);
                int x = 10;
                int y = 10;
                int size = 90;
                g.DrawRectangle(pen, x, y, size, size);
            }

            pictureBox1.Image = bmp;
        }

        private void Save_picture_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PNG Image|*.png";
                sfd.Title = "Сохранить картинку";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Изображение сохранено.");
                }
            }
            else
            {
                MessageBox.Show("Нет изображения для сохранения.");
            }
        }
    }
}