using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RuleBasedHostelAllocation
{
    public partial class FrmAddNewHostel : Form
    {
        private OleDbConnection cn;
        private OleDbCommand cmd;
        private OleDbDataReader dr;

        public FrmAddNewHostel()
        {
            InitializeComponent();
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\HostelAllocationDb.accdb;Persist Security Info=True");
            cmd = new OleDbCommand();
            cmd.Connection = cn;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CmdNext_Click(object sender, EventArgs e)
        {
            try
            {
                if ((isAllEntryFilled()) && (!isRegistered(txtHostelName.Text)))
                {
                    string hostelName = txtHostelName.Text;
                    string hostelCategory = cboHostelCategory.Text;
                    string hostelType = cboHostelType.Text;
                    int numberOfBlocks = Convert.ToInt32(txtNumberOfBlocks.Text);
                    string hostelLocation = txtHostelLocation.Text;

                    cn.Open();
                    cmd.CommandText = "insert into TblHostel values('" + hostelName + "','" + hostelCategory + "','" + hostelType + "'," + numberOfBlocks + ",'" + hostelLocation + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New hostel has been successfully created!!! Proceed to fill the hostel details", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Hide();
                    AddHostelDetails f1 = new AddHostelDetails(hostelName, hostelType, numberOfBlocks);
                    f1.Show();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtHostelName.Text == ""))
            {
                MessageBox.Show("Please type the hostel name", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHostelName.Focus();
                return isEntryFilled;
            }
            else if ((cboHostelCategory.Text == ""))
            {
                MessageBox.Show("Please select the hostel category", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboHostelCategory.Focus();
                return isEntryFilled;
            }
            else if ((cboHostelType.Text == ""))
            {
                MessageBox.Show("Please select the hostel type", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboHostelType.Focus();
                return isEntryFilled;
            }
            else if ((txtNumberOfBlocks.Text == ""))
            {
                MessageBox.Show("Please type the number of blocks or halls in the hostel", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumberOfBlocks.Focus();
                return isEntryFilled;
            }
            else if ((txtHostelLocation.Text == ""))
            {
                MessageBox.Show("Please type the hostel Location", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHostelLocation.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private bool isRegistered(string hostel)
        {
            bool isHostelRegistered = false;
            try
            {
                if (cn.State == ConnectionState.Open) cn.Close();
                cn.Open();
                cmd.CommandText = "select * from TblHostel where HostelName = '" + hostel + "'";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Fail to create new hostel, hosel name already exists. Duplicate hostel found. ", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    isHostelRegistered = true;
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Rule Based Allocation App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isHostelRegistered;

        }

    }
}
