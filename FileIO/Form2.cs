using System;
using System .Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;



namespace FileIO
{
    public partial class Form2 : Form 
    {
        FileStream fs;
               public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        
        private void btmBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\dept.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept = (Department)binaryFormatter.Deserialize(fs);
                txtId.Text = dept.DeptId.ToString();
                txtName.Text = dept.DeptName;
                textLocation.Text = dept.Location;
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\dept.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtId.Text);
                dept.DeptName = txtName.Text;
                dept.Location = textLocation.Text;
                binaryFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
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
                fs = new FileStream(@"C:\Tesla\dept.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtId.Text);
                dept.DeptName = txtName.Text;
                dept.Location = textLocation.Text;
                soapFormatter.Serialize(fs, dept);
                MessageBox.Show("Done !");
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
                fs = new FileStream(@"C:\Tesla\dept.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Department dept = new Department();
                dept = (Department)soapFormatter.Deserialize(fs);
                txtId.Text = dept.DeptId.ToString();
                txtName.Text = dept.DeptName;
                textLocation.Text = dept.Location;
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
                fs = new FileStream(@"C:\Tesla\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtId.Text);
                dept.DeptName = txtName.Text;
                dept.Location = textLocation.Text;
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Done !");
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
                fs = new FileStream(@"C:\Tesla\dept.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Department));
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtId.Text);
                dept.DeptName = txtName.Text;
                dept.Location = textLocation.Text;
                xmlSerializer.Serialize(fs, dept);
                MessageBox.Show("Done !");
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

        private void BtnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"C:\Tesla\dept.json", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.DeptId = Convert.ToInt32(txtId.Text);
                dept.DeptName = txtName.Text;
                dept.Location = textLocation.Text;
                JsonSerializer.Serialize<Department>(fs, dept);
                MessageBox.Show("Done !");
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

        private void BtnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\Tesla\dept.json", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                dept = JsonSerializer.Deserialize<Department>(fs);
                txtId.Text = dept.DeptId.ToString();
                txtName.Text = dept.DeptName;
                textLocation.Text = dept.Location;
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

        private void btnBinaryWrite_Click_1(object sender, EventArgs e)
        {

        }
    }
}




