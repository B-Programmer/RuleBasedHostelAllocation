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
    public partial class FrmStudentDetails : Form
    {
        string userName;
        string userType;
        //Student student;
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\HostelAllocationDb.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCareerGuidanceMIS\ComputerizedCareerGuidanceMIS\CareerDb.accdb");
        
        private OleDbCommand cmd;
        private OleDbDataReader dr;

        public FrmStudentDetails(string uName, string uType)
        {
            InitializeComponent();
            userName = uName;
            userType = uType;
            
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
                if (isAllEntryFilled())
                {
                    string StudentName = txtStudentName.Text;
                    string MatricNo = txtStudentMatric.Text;
                    string Sex = cboStudentSex.Text;
                    string Level = cboStudentLevel.Text;
                    string Department = cboStudentDepartment.Text;
                    string Address = txtStudentAddress.Text;
                    string PhoneNo = txtStudentPhoneNo.Text;
                    string NextOfKinName = txtNextOfKinName.Text;
                    string NextOfKinPhone = txtNextOfKinPhone.Text;
                    

                    cn.Open();
                    cmd.CommandText = "insert into TblHostelDetails values('" + hostelName + "','" + blockName + "'," + numberOfRooms + "," + numberOfBedSpace + "," + firstRoomNumber + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New hostel details has been saved successfully!!!", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Hide();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
