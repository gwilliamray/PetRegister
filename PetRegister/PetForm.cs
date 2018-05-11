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
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
        }

        Customer currentCustomer = null;
        Pet currentPet = null;
        public Pet AddPet(Customer petOwner)
        {
            currentCustomer = petOwner;
            this.Text = "Add Pet";
            lblCustomer.Text = petOwner.ToString();
            cboSex.SelectedIndex = 0;
            cboFurType.SelectedIndex = 0;
            pnlCat.Visible = false;
            pnlDog.Visible = false;

            rdoDog.Checked = true;
            this.ShowDialog();

            return currentPet;
        }

        private void btnPetAction_Click(object sender, EventArgs e)
        {
            string petName;
            string breed;
            string petSex;
            bool vaccination;


            try
            {
                petName = txtPetName.Text;
                breed = txtPetBreed.Text;
                petSex = cboSex.SelectedItem.ToString();
                vaccination = chkVaccinated.Checked;
                // now create the Pet
                if(rdoDog.Checked)
                {
                    string theJob = txtDogsJob.Text;
                    bool school = chkSchool.Checked;

                    currentPet = new Dog(petName, breed, petSex, vaccination, currentCustomer, theJob,school);
                }
                else
                {
                    string theFurType = cboFurType.SelectedItem.ToString();
                    bool declawed = chkDeclawed.Checked;

                    currentPet = new Cat(petName, breed, petSex, vaccination, currentCustomer, theFurType, declawed);


                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFurType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdoDog_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoDog.Checked )
            {
                pnlDog.Visible = true;
                pnlCat.Visible = false;
                btnPetAction.Text = "Save Dog";
            }
            else
            {
                pnlCat.Visible = true;
                pnlDog.Visible = false;
                btnPetAction.Text = "Save Cat";
            }
        }
    }
}
