using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace FileIO
{
    public partial class Form6 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;  // it is not provider specific

        public Form6()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(str);

        }
        public DataSet GetAllStudent()
        {
            da = new SqlDataAdapter("select * from Student", con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "stud");// give alias to the DataTable in DataSet
            return ds;

        }


        private void BtnSave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].NewRow();
                row["name"] = txtName.Text;
                row["percentage"] = txtPercent.Text;
                ds.Tables["stud"].Rows.Add(row);
                int result = da.Update(ds.Tables["stud"]);// reflect the change to main DB
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnUpdate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row["name"] = txtName.Text;
                    row["Percentage"] = txtPercent.Text;

                    int result = da.Update(ds.Tables["stud"]);// reflect the change to main DB
                    if (result == 1)
                    {
                        MessageBox.Show("Record updated");
                    }
                }
                else
                {
                    MessageBox.Show("RollNo not found to update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDelete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["stud"]);// reflect the change to main DB
                    if (result == 1)
                    {
                        MessageBox.Show("Record deleted");
                    }
                }
                else
                {
                    MessageBox.Show("RollNo not found to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["emp"].Rows.Find(txtRollNo.Text);
                if (row != null)
                {
                    txtName.Text = row["name"].ToString();
                    txtPercent.Text = row["salary"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
              // dataGridView1.DataSource = ds.Tables["stud"]; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void richTextbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



