using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace RuleBasedHostelAllocation
{
    public partial class AddHostelDetails : Form
    {
        string hostel;
        string hType;
        int noOfBlocks;
        private OleDbConnection cn;
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ArrayList aBlockName;
        private ArrayList aNumberOfRooms;
        private ArrayList aNumberOfBedSpace;
        private ArrayList aFirstRoomNumber;


        public AddHostelDetails(string hostel, string hType, int noOfBlocks)
        {
            InitializeComponent();
            this.hostel = hostel;
            this.hType = hType;
            this.noOfBlocks = noOfBlocks;
            cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\HostelAllocationDb.accdb;Persist Security Info=True");
            cmd = new OleDbCommand();
            cmd.Connection = cn;
            if (hType == "Multi-Blocks") createBlockList();
        }

        private void createBlockList()
        {
            ArrayList aBlockName = new ArrayList();
            ArrayList aNumberOfRooms = new ArrayList();
            ArrayList aNumberOfBedSpace = new ArrayList();
            ArrayList aFirstRoomNumber = new ArrayList();
        }

        private void AddHostelDetails_Load(object sender, EventArgs e)
        {
            txtHostelName.Text = hostel;
            txtHostelType.Text = hType;
            txtNumberOfBlocks.Text = noOfBlocks.ToString();
            if (hType == "Single-Block")
            {
                grpSingleBlock.Visible = true;
                grpMultiBlocks.Visible = false;
            }
            else
            {
                grpSingleBlock.Visible = false;
                grpMultiBlocks.Visible = true;
                CmdSave.Enabled = false;
                lstBlocks.View = View.Details;
                lstBlocks.GridLines = true;
                lstBlocks.FullRowSelect = true;
                //Add Column Header for listView 1
                lstBlocks.Columns.Add("Block Name", 200);
                lstBlocks.Columns.Add("No of Rooms", 100);
                lstBlocks.Columns.Add("No of Bed Space", 120);
                lstBlocks.Columns.Add("First Room No", 100);
                lstBlocks.Items.Clear();
                
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (hType == "Single-Block")
                saveSingleBlockDetails();
            else
                saveMultipleBlocksDetails();
        }

        private void saveSingleBlockDetails()
        {
            try
            {
                if (isAllEntryFilled())
                {
                    string hostelName = txtHostelName.Text;
                    string blockName = txtBlockName.Text;
                    int numberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
                    int numberOfBedSpace = Convert.ToInt32(txtNumberOfBedSpace.Text);
                    int firstRoomNumber = Convert.ToInt32(txtFirstRoomNumber.Text);

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


        private bool isAllEntryFilled()
        {
            bool isEntryFilled = false;

            if ((txtHostelName.Text == ""))
            {
                MessageBox.Show("Please type the hostel name", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtHostelName.Focus();
                return isEntryFilled;
            }
            else if ((txtBlockName.Text == ""))
            {
                MessageBox.Show("Please type the Block Name", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBlockName.Focus();
                return isEntryFilled;
            }
            else if ((txtNumberOfRooms.Text == ""))
            {
                MessageBox.Show("Please type the number of rooms", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumberOfRooms.Focus();
                return isEntryFilled;
            }
            else if ((txtNumberOfBedSpace.Text == ""))
            {
                MessageBox.Show("Please type the number of bed space per room in the hostel", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumberOfBedSpace.Focus();
                return isEntryFilled;
            }
            else if ((txtFirstRoomNumber.Text == ""))
            {
                MessageBox.Show("Please type the first room number for this block(hall)", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFirstRoomNumber.Focus();
                return isEntryFilled;
            }
            else
                return true;

        }

        private void saveMultipleBlocksDetails()
        {
            try
            {
                if (aBlockName.Count == this.noOfBlocks)
                {
                    string hostelName = txtHostelName.Text;
                    for (int i = 0; i < aBlockName.Count; i++)
                    {
                        cn.Open();
                        cmd.CommandText = "insert into TblHostelDetails values('" + hostelName + "','" + (string)aBlockName[i] + "'," + (int)aNumberOfRooms[i] + "," + (int)aNumberOfBedSpace[i] + "," + (int)aFirstRoomNumber[i] + ")";
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    MessageBox.Show("New hostel details has been saved successfully!!!", "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                }
            }
            catch (Exception er)
            {
                cn.Close();
                MessageBox.Show(er.Message, "Rule Based Allocation App.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBlocks_Click(object sender, EventArgs e)
        {
            if (isAllEntryFilled())
            {
                string[] arr = new string[5];
                ListViewItem itm;
    
                string blockName = txtBlockName.Text;
                int numberOfRooms = Convert.ToInt32(txtNumberOfRooms.Text);
                int numberOfBedSpace = Convert.ToInt32(txtNumberOfBedSpace.Text);
                int firstRoomNumber = Convert.ToInt32(txtFirstRoomNumber.Text);
                if (aBlockName.Count < this.noOfBlocks)
                {
                    aBlockName.Add(blockName);
                    aNumberOfRooms.Add(numberOfRooms);
                    aNumberOfBedSpace.Add(numberOfBedSpace);
                    aFirstRoomNumber.Add(firstRoomNumber);
                    //add items to ListView
                    arr[0] = blockName;
                    arr[1] = numberOfRooms.ToString();
                    arr[2] = numberOfBedSpace.ToString();
                    arr[3] = firstRoomNumber.ToString();

                    itm = new ListViewItem(arr);
                    lstBlocks.Items.Add(itm);

                }
                if (aBlockName.Count == this.noOfBlocks) CmdSave.Enabled = true;
            }

        }

        
        
    }
}
