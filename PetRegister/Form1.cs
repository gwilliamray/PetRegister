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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customer> ourCustomers = new List<Customer>();
        List<Pet> ourPets = new List<Pet>();
        List<Licence> allLicence = new List<Licence>();

        Customer currentCustomer = null;
        Customers ListofCustomers = new Customers();

        private void Form1_Load(object sender, EventArgs e)
        {
            ourCustomers = ListofCustomers.GetAllCustomers();

            DisplayCustomers();
            btnEditCustomer.Enabled = false;
            btnAddPet.Enabled = false;


        }

        private void DisplayCustomers()
        {
            lstCustomers.Items.Clear();
            foreach(Customer c in ourCustomers)
            {
                lstCustomers.Items.Add(c);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer aCustomer = null;
            CustomerForm frmCustomerAdd = new CustomerForm();

            aCustomer = frmCustomerAdd.CreateCutomer();

            if (aCustomer != null)
            {
                ListofCustomers.AddCustomer(aCustomer);
                ourCustomers.Add(aCustomer);
                DisplayCustomers();
            }


        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCustomer = (Customer)lstCustomers.SelectedItem;

            if (currentCustomer != null)
            {
                if (currentCustomer.ThePet == null)
                { 
                btnEditCustomer.Enabled = true;
                btnAddPet.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Sorry only one pet ", "Pet overflow error!");
                }
            }
            else
            {
                MessageBox.Show("Try selecting again!");
            }

        }

        private void ShowLicence()
        {
            lstLicence.Items.Clear();
            foreach(Licence l in allLicence)
            {
                lstLicence.Items.Add(l.Id + l.Fee.ToString("c"));
            }

        }
        private void ShowPets()
        {
            lstPets.Items.Clear();
            allLicence.Clear();
            foreach(Pet p in ourPets)
            {
                lstPets.Items.Add(p);
                allLicence.Add(p.PetOwner.PetLicence);

            }
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            CustomerForm frmCustomerForm = new CustomerForm();

            frmCustomerForm.EditCustomer(currentCustomer);

            DisplayCustomers();
            btnEditCustomer.Enabled = false;

        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            PetForm frmAddPetForm = new PetForm();
            Pet currentPet = null;
            if(currentCustomer != null)
            {
                currentPet = frmAddPetForm.AddPet(currentCustomer);
                // if valid pet then add to the pet Collection
                if (currentPet != null)
                {
                    ourPets.Add(currentPet);
                    ShowPets();
                    DisplayCustomers();
                    ShowLicence();
                }
            }
            else
            {
                MessageBox.Show("Must choose a Pet Owner first", "Form Error");
            }

            btnAddPet.Enabled = false;
            btnEditCustomer.Enabled = false;

        }

        private void lstPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pet selectedPet = (Pet)lstPets.SelectedItem;

            MessageBox.Show(selectedPet.PetOwner.FirstName + " " + selectedPet.PetOwner.LastName + " Pet Licence: " + selectedPet.PetOwner.PetLicence.Id);
        }
    }
}
