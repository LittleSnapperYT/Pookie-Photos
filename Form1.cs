using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PookiePhotos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files (JPG,PNG,JPEG,BMP,GIF,TIFF,WMF,EMF,ICON,SVG)|*.JPG;*.PNG;*.JPEG;*.BMP;*.GIF;*.TIFF;*.WMF;*.EMF;*.ICO;*.SVG";
            file.Title = "What File?";
            file.ShowDialog();
            pictureBox1.Image = Image.FromFile(file.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Count() == 2)
                pictureBox1.Image = Image.FromFile(arguments[1]);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.openToolStripMenuItem,this.aboutToolStripMenuItem,this.quitToolStripMenuItem,this.resetPhotoToolStripMenuItem});
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null) 
            {
                var filenames = data as string[];
                if (filenames.Length > 0)
                {
                    pictureBox1.Image = Image.FromFile(filenames[0]);
                }  
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files (JPG,PNG,JPEG,BMP,GIF,TIFF,WMF,EMF,ICON,SVG)|*.JPG;*.PNG;*.JPEG;*.BMP;*.GIF;*.TIFF;*.WMF;*.EMF;*.ICO;*.SVG" ;
            file.Title = "What File?";
            file.ShowDialog();
            pictureBox1.Image = Image.FromFile(file.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(JPG, PNG, JPEG, BMP, GIF, TIFF, WMF, EMF, ICON, SVG) | *.JPG; *.PNG; *.JPEG; *.BMP; *.GIF; *.TIFF; *.WMF; *.EMF; *.ICO; *.SVG";
            file.Title = "What File?";
            file.ShowDialog();
            pictureBox1.Image = Image.FromFile(file.FileName);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Image Files (JPG,PNG,JPEG)|*.JPG;*.PNG;*.JPEG";
            save.Title = "Save Where?";
            save.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI","This Application was made by Little Snapper YT Please subscribe to support him.");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
