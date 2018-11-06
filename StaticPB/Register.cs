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

    public partial class Register : Form
    {
        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving
        int count = 1;
        private int clickCount = 0;
        int Available = 1;
        private int PasswordMatched = 0;
        HomePage h = new HomePage();
        tblRegister modelRegister = new tblRegister();
        private tblMultipleLogin modelLogin = new tblMultipleLogin();

        public Register()
        {
            InitializeComponent();

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void picShow1_Click(object sender, EventArgs e)
        {
            picShow1.Image = StaticPB.Properties.Resources.hide;

            if (count % 2 == 0)
            {
                picShow1.Image = StaticPB.Properties.Resources.show;
                txtConfirmPassword.PasswordChar = '*';
            }
            else
            {
                picShow1.Image = StaticPB.Properties.Resources.hide;
                txtConfirmPassword.PasswordChar = '\0';
            }

            count++;

        }

        void CheckPassword()
        {
            if (txtConfirmPassword.Text == txtPassword.Text )
            {
                PasswordMatched = 1;
                picCorrect.Image = StaticPB.Properties.Resources.Available;
                picMatch.Image = StaticPB.Properties.Resources.Available;
                picCorrect.Visible = true;
                picMatch.Visible = true;
                lblPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff0000");
                lblConfirmPassword.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff0000");
            }
            else
            {
                PasswordMatched = 0;
                picCorrect.Image = StaticPB.Properties.Resources.X;
                picMatch.Image = StaticPB.Properties.Resources.X;
                picCorrect.Visible = true;
                picMatch.Visible = true;
                lblPassword.ForeColor = System.Drawing.Color.LightGray;
                lblConfirmPassword.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        void CheckUsernameIsAvailable()
        {
            String Connection =
                @"data source=mylaptop\sqlexpress;initial catalog=MultipleLogin;integrated security=True;multisubnetfailover=False;MultipleActiveResultSets=True;App=EntityFramework";
            SqlConnection con = new SqlConnection(Connection);
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "Select * from tblMultipleLogin Where UserName= '" + txtUsername.Text + "' And Type= '" + txtType.Text + "'", con);

            //new SqlDataAdapter(
            //    "Select * from tblMultipleLogin Where UserName= '" + txtUsername.Text + "'and Password ='" + txtPassword.Text + "' And Type= '" + txtType.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                

                //picAvailable.Image = StaticPB.Properties.Resources.X;
                
                picAvailable.Visible = true;
                MessageBox.Show("User Exist");
                picAvailable.Image = StaticPB.Properties.Resources.X;

                txtUsername.Text = "";
                txtUsername.BackColor = System.Drawing.Color.Red;
                txtUsername.ForeColor = System.Drawing.Color.Black;
                lblUserName.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff0000");
                Available = 1;
            }
            else
            {
               
                 picAvailable.Image = StaticPB.Properties.Resources.Available;
                txtUsername.BackColor = System.Drawing.Color.LightGray;
                lblUserName.ForeColor = System.Drawing.Color.LightGray;
                picAvailable.Visible = true;
                Available = 0;

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtType.Text = "";
        }

        private bool isValid(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Label label)
        {
            var validity = true;
            if (textBox.Text == "")
            {
                validity = false;
                label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#1aff0000");
                // textBox.ForeColor = System.Drawing.Color.Red;
                textBox.BackColor = System.Drawing.Color.Red;
                textBox.ForeColor = System.Drawing.Color.LightGray;

            }
            else
            {
                validity = true;
                label.ForeColor = System.Drawing.Color.LightGray;
                //textBox.ForeColor = System.Drawing.Color.LightGray;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            h.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CheckUsernameIsAvailable();
            CheckPassword();
            var isOk = isValid(txtPassword, lblPassword) &
                       isValid(txtType, lblType) &
                       isValid(txtConfirmPassword,lblConfirmPassword)&
                       isValid(txtFullName, lblFullName) &
                       isValid(txtUsername, lblUserName);
            if (isOk && Available==0 && PasswordMatched==1)
            {
              
                
                    modelRegister.FullName = txtFullName.Text.Trim();
                    modelLogin.UserName = modelRegister.UserName = txtUsername.Text.Trim();
                    modelLogin.Password = modelRegister.Password = txtPassword.Text.Trim();
                    modelLogin.Type = modelRegister.Type = txtType.Text.Trim();

                using (DBEntities db = new DBEntities())
                {
                    if (modelRegister.Id == 0 & modelLogin.Id == 0 && Available ==0 && PasswordMatched == 1 ) //Insert
                    //    if (modelRegister.Id == 0 & modelLogin.Id == 0 & Available < 1 & PasswordMatched == 1)
                       {

                        db.tblRegisters.Add(modelRegister);
                        db.tblMultipleLogins.Add(modelLogin);
                        db.SaveChanges();
                        MessageBox.Show("Registered Successfully", "Registered");


                       }
                    else //Update
                    {

                    //    db.Entry(modelRegister).State = EntityState.Modified;
                    //    db.Entry(modelLogin).State = EntityState.Modified;

                      MessageBox.Show("Registration failed", "Error");
                    }
                   

                }

                //  Clear();
                    // PopulateGridView();
                }

            clickCount++;
        }

        private void title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        private void title_MouseMove(object sender, MouseEventArgs e)
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

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            //CheckUsernameIsAvailable();
            if (clickCount > 0)
            {

            }
           
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            if ( txtPassword.Text!="")
            {
                CheckPassword();
                picMatch.Visible = true;
                picCorrect.Visible = false;
               // MessageBox.Show("Plz check your password.");
            }
            else
            {
                picMatch.Image = StaticPB.Properties.Resources.X;
                picCorrect.Visible = false;
            }

        }

        private void txtConfirmPassword_MouseLeave(object sender, EventArgs e)
        {
            if ( txtConfirmPassword.Text!="" )
            {
                CheckPassword();
                picCorrect.Visible = true;
                picMatch.Visible = false;
                //MessageBox.Show("Plz check password Again");
            }
            else
            {
                picCorrect.Image = StaticPB.Properties.Resources.X;
                picMatch.Visible = false;
            }
                
        }

        private void txtType_MouseLeave(object sender, EventArgs e)
        {
            if (txtType.Text=="" || clickCount>=0)
            {
                if(clickCount>0)
                 MessageBox.Show("Make sure you  Selected Type");
            }
           
        }
    }

    }
        