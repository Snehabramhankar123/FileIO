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

namespace FileIO
{
    public partial class Form1 : Form

    {
        FileStream fs;
        BinaryWriter bw;
        BinaryReader br;
        StreamWriter sw;


        public Form1()
        {
            InitializeComponent();
        }



        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Tesla";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder exists");

                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Tesla\sample.txt ";
                if (File.Exists(path))
                {
                    MessageBox.Show("file exits");
                }
                else
                    File.Create(path);
                {
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                
            
        

            }
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

       

        

        private void btnStramWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\testFile.txt", FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }

        }

        private void BinaryWrite_Click(object sender, EventArgs e)
        {

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {

        }
    }
       
        
    
}
