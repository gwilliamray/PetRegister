using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetRegister
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        Customer aCustomer = null;
        string flag = "Add";
        public Customer CreateCutomer()
        {
            this.Text = "Add Customer";

            this.ShowDialog();


            return aCustomer;

        }

        public void EditCustomer(Customer theCustomer)
        {
            aCustomer = theCustomer;
            txtFirstName.Text = aCustomer.FirstName;
            txtLastName.Text = aCustomer.LastName;
            txtAddress.Text = aCustomer.Address;
            txtEmail.Text = aCustomer.Email;
            txtPhone.Text = aCustomer.Phone;
            txtDateofBirth.Text = Convert.ToString(aCustomer.DateOfBirth);

            this.Text = "Edit Customer";
            btnAction.Text = "Edit";
            flag = "Edit";
            this.ShowDialog();



            //return aCustomer;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string fName;
            string lName;
            string email;
            DateTime birthday;
            string address;
            string phone;

            

            try
            {
                fName = txtFirstName.Text;
                lName = txtLastName.Text;
                email = txtEmail.Text;
                birthday = Convert.ToDateTime(txtDateofBirth.Text);
                address = txtAddress.Text;
                phone = txtPhone.Text;

                if (flag == "Add")
                {
                    aCustomer = new Customer(fName, lName, email, phone, birthday, address);
                }
                else if(flag == "Edit")
                {
                    aCustomer.FirstName = fName;
                    aCustomer.LastName = lName;
                    aCustomer.Email = email;
                    aCustomer.Phone = phone;
                    aCustomer.Address = address;
                    aCustomer.DateOfBirth = birthday;

                }
                this.Close();
            }
            catch (PhoneNumberExecption ex)
            {
                MessageBox.Show(ex.Message);
                txtPhone.Focus();
                txtPhone.SelectAll();

            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                txtDateofBirth.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Wierd Happened");
            }

           

        }
    }
}
