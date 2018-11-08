using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticPB
{
    
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("data source=mylaptop\\sqlexpress;initial catalog=MultipleLogin;integrated security=True;multisubnetfailover=False;MultipleActiveResultSets=True;App=EntityFramework");
        tblMultipleLogin mLogin=new tblMultipleLogin();
        tblMain model=new tblMain();
        HomePage h =new HomePage();
        string uType;
        string uName;
        SqlDataAdapter adapt;
        DataTable dt ;
        public Main(string Name,string tt)
        {
            InitializeComponent();
            uName=Name;
            uType = tt;
            lblName.Text =Name+"'s";
            btnDelete.Enabled = false;
           
            userTableOnly();
        }

        void userTableOnly()
        {
            
           
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tblMain where UserName = '"+uName+"' and Type = '"+uType+"' ",con);
            dt = new DataTable();
            sda.Fill(dt);
            DataTable tempDT = new DataTable();
            tempDT = dt.DefaultView.ToTable(true, "Id", "UserName","PersonName","PhoneNumber","Type");
            //Now bind this to DataGridView
            dgvMain.DataSource = tempDT;
            con.Close();
        }


        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt32(dgvMain.CurrentRow.Cells["Id"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.tblMains.Where(x => x.Id == model.Id).FirstOrDefault();
                    txtName.Text = model.PersonName;
                    txtPhoneNumber.Text = model.PhoneNumber;
                    uName = model.UserName;
                    uType = model.Type;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.UserName = uName;
            model.Type = uType;
            model.PersonName = txtName.Text.Trim();
            model.PhoneNumber = txtPhoneNumber.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                if (model.Id == 0) //Insert
                {
                    db.tblMains.Add(model);
                    db.SaveChanges();
                    MessageBox.Show("Saved new Successfully");
                }
                else //Update
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("Updated Successfully");
                }
                    
            }
            Clear();
            userTableOnly();
            //MessageBox.Show("Submitted Successfully");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Contact ?", uName+"'s PhoneBook", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DBEntities db = new DBEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.tblMains.Attach(model);
                    db.tblMains.Remove(model);
                    db.SaveChanges();
                    userTableOnly();
                    MessageBox.Show("Deleted Successfully");
                    Clear();
                    
                }
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            model.UserName = uName;
            model.Type = uType;
            btnSave.Text = "Add New";
            btnDelete.Enabled = false;
            model.Id = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HomePage h= new HomePage();
            this.Hide();
            h.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
            con.Open();

            //    SearchDirectionHint by Person Name Only
            adapt = new SqlDataAdapter("select * from tblMain where PersonName like '" + txtSearch.Text + "%' and UserName = '" + uName + "' and Type= '" + uType + "'", con);
            dt=new DataTable();
            adapt.Fill(dt);
            dgvMain.DataSource = dt;
            con.Close();
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvMain.CurrentRow.Index != -1)
            {
                model.Id = Convert.ToInt32(dgvMain.CurrentRow.Cells["Id"].Value);
                using (DBEntities db = new DBEntities())
                {
                    model = db.tblMains.Where(x => x.Id == model.Id).FirstOrDefault();
                    txtName.Text = model.PersonName;
                    txtPhoneNumber.Text = model.PhoneNumber;
                    uName = model.UserName;
                    uType = model.Type;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
