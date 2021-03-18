using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIleDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBtn_Click(object sender, EventArgs e)
        {
            pictureOFD.Filter = "Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            pictureOFD.FilterIndex = 1;
            if (pictureOFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(pictureOFD.FileName))
                {
                    guna2CirclePictureBox1.Image = Image.FromFile(pictureOFD.FileName);
                }
            }
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            descriptionOFD.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt || ";
            descriptionOFD.FilterIndex = 1;
            if (descriptionOFD.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(descriptionOFD.FileName))
                {
                    descriptionTxt.Text = reader.ReadToEnd();
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            descriptionSVD.Filter = "All Files(*.*)|*.*|Text Files(*.txt)| *.txt || ";
            descriptionSVD.FilterIndex = 1;
            if (descriptionSVD.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(descriptionSVD.FileName))
                {
                    writer.Write(descriptionTxt.Text);
                }
            }
        }
    }
}
