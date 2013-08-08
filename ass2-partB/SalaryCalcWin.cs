using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Person[] list = new Person[50];
        private int current; //EnteredRecord
        private int index; //CurrentRecord

        public Form1()
        {
            InitializeComponent();
            current = 0;
            index = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Clear()
        {
            txtFullName.Text = "";
            txtStreetNo.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtPostCode.Text = "";
            txtPhoneNo.Text = "";
            
            txtFullName.Enabled = true;
            txtStreetNo.Enabled = true;
            txtAddress.Enabled = true;
            txtState.Enabled = true;
            txtPostCode.Enabled = true;
            txtPhoneNo.Enabled = true;
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (current == list.Length)
                MessageBox.Show("Product list is full - can\'t add any more stock");
            else
            {
                if (txtFullName.Text == "" || txtStreetNo.Text == "" || txtAddress.Text == "" || txtState.Text == "")
                    MessageBox.Show("Please make sure Text Boxes are filled");
                else
                {
                    if (txtPostCode.Text.Length != 4 || txtPostCode.Text == "")
                        MessageBox.Show("Post Code must be 4 digits in length");
                    else
                    {
                        if (txtPhoneNo.Text.Length > 10)
                            MessageBox.Show("Phone number must be no greater than 10 digits");
                        else
                        {
                            int salary = 0;
                            if (int.TryParse(txtSalary.Text, out salary) == false)
                                MessageBox.Show("Please check the Salary Text Box value");
                            else
                            {
                                list[current] = new Person();
                                list[current].FullName = txtFullName.Text;
                                list[current].StreetNo = txtStreetNo.Text;
                                list[current].Address = txtAddress.Text;
                                list[current].State = txtState.Text;
                                list[current].PostCode = txtPostCode.Text;
                                list[current].PhoneNo = txtPhoneNo.Text;
                                list[current].Salary = salary;

                                index = current;
                                lstPerson.Items.Add(list[current].ToString());
                                current++;
                                Clear();

                            }
                        }
                    }
                }
            }

        }

        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

