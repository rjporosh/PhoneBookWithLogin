using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticPB
{
    public partial class HomePage : Form
    {
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving
        int count =1;
        int clickCount = 0;

        
      //  Register r=new Register();
        
        public HomePage()
        {
            InitializeComponent();
        }

        private void picShow_Click(object sender, EventArgs e)
        {

            picShow.Image = StaticPB.Properties.Resources.hide;

            if (count % 2 == 0)
            {
                picShow.Image = StaticPB.Properties.Resources.show;
                txtPassword.PasswordChar = '*';
            }
            else
            {
                picShow.Image = StaticPB.Properties.Resources.hide;
                txtPassword.PasswordChar = '\0';
            }
            count++;
        }

        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                    p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void lblMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtType.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
           // MessageBox.Show("Page Under Construction");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var isOk = isValid(txtPassword, lblPassword) &
                       isValid(txtType, lblType) &
                       isValid(txtUsername, lblUserName);
            if (isOk)
            {
                string connection =
                    @"data source=mylaptop\sqlexpress;initial catalog=MultipleLogin;integrated security=True;multisubnetfailover=False;MultipleActiveResultSets=True;App=EntityFramework";
                SqlConnection con = new SqlConnection(connection);
                SqlDataAdapter sda = new SqlDataAdapter("Select Type from tblMultipleLogin Where UserName= '" + txtUsername.Text + "'and Password ='" + txtPassword.Text + " ' and Type ='"+txtType.Text+" ' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    //MessageBox.Show("Login Success", "Congrates");
                    if (checkBox1.Checked)
                    {
                        Properties.Settings.Default.Username = txtUsername.Text;
                        Properties.Settings.Default.Password = txtPassword.Text;
                        Properties.Settings.Default.Type = txtType.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Username = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.Type = "";
                        Properties.Settings.Default.Save();
                    }
                    this.Hide();
                     
                    MessageBox.Show("Login Success", "Congrates");
                    MessageBox.Show("WelCome dear " + txtUsername.Text);
                    Main m = new Main(txtUsername.Text,txtType.Text);
                    m.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Incorrect User Name Or Password");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill All the field.");
            }


            clickCount++;
        }

        private bool isValid(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label)
        {
            var validity = true;
            if (textBox.Text == "")
            {
                validity = false;
                label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff0000");
                textBox.BackColor = System.Drawing.Color.Red;
               // textBox.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                validity = true;
                label.ForeColor = System.Drawing.Color.LightGray;
                textBox.BackColor = System.Drawing.Color.LightGray;
            }


            return validity;
        }

        private bool isValid(System.Windows.Forms.ComboBox comboBox, System.Windows.Forms.Label label)
        {
            var validity = true;
            if (comboBox.Text == "")
            {
                validity = false;
                label.ForeColor = System.Drawing.Color.Red;

            }
            else
            {
                validity = true;
                label.ForeColor = System.Drawing.Color.LightGray;
            }

            return validity;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = Properties.Settings.Default.Password;
            txtType.Text = Properties.Settings.Default.Type;
        }

        private void txtType_MouseLeave(object sender, EventArgs e)
        {
            if (txtType.Text == "" && clickCount>0)
            {
               // MessageBox.Show("Plz Select Type");
            }
        }
    }
}
