using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

namespace Final_Project
{
    public partial class frmlogin : Form

    {
        public int logAttempt = 0;

        public frmlogin()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-5USK0K2\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True;Encrypt=False");

        private void lplpassword_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtpassword.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }
        
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed) con.Open();
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string query_select = "SELECT * FROM login WHERE username ='" + username + "' AND password ='" + password + "'";
            SqlCommand cmnd = new SqlCommand(query_select, con);
            using (var row = cmnd.ExecuteReader())
            {
                if (row.HasRows)
                {
                    this.Hide();
                    Frmstudentreg obj = new Frmstudentreg();
                    obj.Show();
                }
                else
                {
                    logAttempt += 1;

                    if (logAttempt == 3)
                    {
                        MessageBox.Show("You have exceeded the maximum number of login attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtusername.Enabled = false;
                        txtpassword.Enabled = false;
                        btnlogin.Enabled = false;

                        this.Hide();
                        frmsplash obj = new frmsplash();
                        obj.Show();
                    }
                    else
                        
                    MessageBox.Show("Invalid Login Credentials, Please check Username & Password and try again!", "Invalid Logn Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Reset();
                        txtusername.Clear();
                        txtpassword.Clear();
                        txtusername.Focus(); 
                    

                    
                  
                }
            }
             
        }
        public void Reset()
        {
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result ==DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void checkboxshowpw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxshowpw.Checked) 
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}