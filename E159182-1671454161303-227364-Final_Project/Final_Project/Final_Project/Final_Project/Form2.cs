using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class Frmstudentreg : Form
    {
        public Frmstudentreg()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-5USK0K2\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True;Encrypt=False");
        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblskillsinternational2_Click(object sender, EventArgs e)
        {

        }

        private void lblcontactnum_Click(object sender, EventArgs e)
        {

        }

        private void Frmstudentreg_Load(object sender, EventArgs e)
        {
          con.Open();
            string query_select = "SELECT * FROM registration";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            SqlDataReader row= cmnd.ExecuteReader();
            comboxregno.Items.Add("New Register");
            while(row.Read())
            {
                comboxregno.Items.Add(row[0].ToString());
                    

            }
            con.Close();
               
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            try
            {


                int regno = int.Parse(comboxregno.Text);
                string firstName = txtfirstname.Text;
                string lastName = txtlastname.Text;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                string gender;

                if (radiobtnmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address = txtaddress.Text;
                string email = txtemail.Text;
                int mobilePhone = int.Parse(txtmobilephone.Text);
                int homePhone = int.Parse(txthomephone.Text);
                string parentName = txtparentname.Text;
                string nic = txtnic.Text;
                int contactNo = int.Parse(txtcontacnum.Text);
                string query_insert = "insert into registration values('" + regno + "','" + firstName + "','" + lastName + "','" + Convert.ToDateTime(dateTimePicker1.Value) + "','" + gender + "','" + address + "','" + email + "'," + mobilePhone + "," + homePhone + ",'" + parentName + "','" + nic + "'," + contactNo + ")";

                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);

                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Recoard Added Successfully!", "Registered Student!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
            }




        }

        private void comboxregno_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            int x = Convert.ToInt32(comboxregno.SelectedItem.ToString());
            SqlCommand cmd = new(@"SELECT
             [regNo]
            ,[firstName]
            ,[lastName]
            ,[dateOfBirth]
            ,[gender]
            ,[address]
            ,[email]
            ,[mobilePhone]
            ,[homePhone]
            ,[parentName]
            ,[nic]
            ,[contactNo]
             FROM registration WHERE regNo = '" + x + "'", con);

            SqlDataReader reader;
            reader= cmd.ExecuteReader();
            if (reader.Read()) 
            {
                comboxregno.Text = reader["regNo"].ToString();
                txtfirstname.Text = reader["firstName"].ToString();
                txtlastname.Text = reader["lastName"].ToString() ;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                dateTimePicker1.Text= reader["dateOfBirth"].ToString();
                if (reader["gender"].ToString() == "Male")
                { 
                    radiobtnmale.Checked = true;
                    radiobtnfemale.Checked = false;
                }
                else
                {
                    radiobtnmale.Checked = false;
                    radiobtnfemale.Checked = true;
                }
                txtaddress.Text = reader["address"].ToString();
                txtemail.Text = reader["email"].ToString();
                txtmobilephone.Text = reader["mobilePhone"].ToString();
                txthomephone.Text = reader["homePhone"].ToString();
                txtparentname.Text = reader["parentName"].ToString();
                txtnic.Text = reader["nic"].ToString();
                txtcontacnum.Text = reader["contactNo"].ToString();
            }
            else
            {
                MessageBox.Show("No Data");
            }
            con.Close();
        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void radiobtnmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radiobtnfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void lblparentname_Click(object sender, EventArgs e)
        {

        }

        private void lbladdress_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string regNo = comboxregno.Text;
            if (regNo != "New Register")
            {
                int regno = int.Parse(comboxregno.Text);
                string firstName = txtfirstname.Text;
                string lastName = txtlastname.Text;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                string gender;

                if (radiobtnmale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string address= txtaddress.Text;
                string email = txtemail.Text;
                int mobilePhone = int.Parse(txtmobilephone.Text);
                int homePhone = int.Parse(txthomephone.Text);
                string parentName = txtparentname.Text;
                string nic = txtnic.Text;
                int contactNo = int.Parse(txtcontacnum.Text);

                string query_insert = "UPDATE registration SET regNo = '" + regNo + "',firstName = '" + firstName + "',lastName = '" + lastName + "',dateOfBirth = '" + Convert.ToDateTime(dateTimePicker1.Value) + "',gender ='" + gender + "',address = '" + address + "',email ='" + email + "',mobilePhone = '" + mobilePhone + "', homePhone ='" + homePhone + "',parentName ='" + parentName + "', nic = '" + nic + "',contactNo ='" + contactNo + "' WHERE regNO =" + regNo;

                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record updated Successfully!", "Updated Student",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            comboxregno.Text = "";
            txtfirstname.Text = "";
            txtlastname.Text = "";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            DateTime thisDay = DateTime.Today;
            dateTimePicker1.Text= thisDay.ToString();

            radiobtnmale.Checked= false;
            radiobtnfemale.Checked= false;

            txtaddress.Text = "";
            txtemail.Text = "";
            txtmobilephone.Text = "";
            txthomephone.Text = "";
            txtparentname.Text = "";
            txtnic.Text = "";
            txtcontacnum.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to Delete this Recoard...?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
            string no = comboxregno.Text;

                string query_insert = "DELETE FROM registration WHERE regNo = " + no + "";
                con.Open();
                SqlCommand cmnd = new SqlCommand(query_insert, con);
                _ = cmnd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!", "Deleted Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                comboxregno.Text = "";
                txtfirstname.Text = "";
                txtlastname.Text = "";
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "dd/MM/yyyy";
                DateTime thisDay = DateTime.Today;
                dateTimePicker1.Text = thisDay.ToString();

                radiobtnmale.Checked = false;
                radiobtnfemale.Checked = false;

                txtaddress.Text = "";
                txtemail.Text = "";
                txtmobilephone.Text = "";
                txthomephone.Text = "";
                txtparentname.Text = "";
                txtnic.Text = "";
                txtcontacnum.Text = "";
            }
            else if (result == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void linklbllogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure,Do you really want to Logout...,?","Logout",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes) 
            {
                frmlogin obj = new frmlogin();
                obj.Show();
                this.Close();
            }
            else if (result==DialogResult.Yes)
            {
                Frmstudentreg obj= new Frmstudentreg();
                obj.Show();
                this.Close();
            }
           
        }

        private void linklblexit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) 
            {
            Application.Exit();
            }
            else if (result == DialogResult.Yes) 
            {
            this.Close();
            }
        }
    }
}
