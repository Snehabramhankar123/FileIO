using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace FileIO
{
    public partial class Student : Form
    {
        FileStream fs;
        public Student()
        {
            InitializeComponent();
        }
        private void Student_Load(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                StudentDemo s1 = new StudentDemo();
                s1.RollNo = Convert.ToInt32(txtRollNo.Text);
                s1.Name = txtName.Text;
                s1.Percentage =Convert.ToDouble(txtPercent.Text);
                binaryFormatter.Serialize(fs, s1);
                MessageBox.Show("Done!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void BtnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student", FileMode.Open, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                StudentDemo s1 = new StudentDemo();
                s1 = (StudentDemo)binaryFormatter.Deserialize(fs);
                txtRollNo.Text = s1.RollNo.ToString();
                txtName.Text = s1.Name.ToString();
                txtPercent.Text = s1.Percentage.ToString();
            }
                  catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentDemo));
                StudentDemo s1 = new StudentDemo();
                s1.RollNo = Convert.ToInt32(txtRollNo.Text);
                s1.Name = txtName.Text;
                s1.Percentage = Convert.ToDouble(txtPercent.Text);
                xmlSerializer.Serialize(fs, s1);
                MessageBox.Show("Done!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.xml", FileMode.Open, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(StudentDemo));
                StudentDemo s1 = new StudentDemo();
                s1 = (StudentDemo)xmlSerializer.Deserialize(fs);
                txtRollNo.Text = s1.RollNo.ToString();
                txtName.Text = s1.Name.ToString();
                txtPercent.Text = s1.Percentage.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.xml", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                StudentDemo s1 = new StudentDemo();
                s1.RollNo = Convert.ToInt32(txtRollNo.Text);
                s1.Name = txtName.Text;
                s1.Percentage = Convert.ToDouble(txtPercent.Text);
                soapFormatter.Serialize(fs, s1);
                MessageBox.Show("Done!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.soap", FileMode.Open, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                StudentDemo s1 = new StudentDemo();
                txtRollNo.Text = s1.RollNo.ToString();
                txtName.Text = s1.Name.ToString();
                txtPercent.Text = s1.Percentage.ToString();
                s1 = (StudentDemo)soapFormatter.Deserialize(fs);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.json", FileMode.Create, FileAccess.Write);
                
                StudentDemo s1 = new StudentDemo();
                s1.RollNo = Convert.ToInt32(txtRollNo.Text);
                s1.Name = txtName.Text;
                s1.Percentage = Convert.ToDouble(txtPercent.Text);
                JsonSerializer.Serialize<StudentDemo>(fs, s1);
                MessageBox.Show("Done!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\student.json", FileMode.Open, FileAccess.Write);
                
                StudentDemo s1 = new StudentDemo();
                s1 = JsonSerializer.Deserialize<StudentDemo>(fs);
                txtRollNo.Text = s1.RollNo.ToString();
                txtName.Text = s1.Name.ToString();
                txtPercent.Text = s1.Percentage.ToString();

                
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void txtRollNo_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
