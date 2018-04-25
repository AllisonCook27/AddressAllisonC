/*
 * Created by: Allison Cook
 * Created on: April 23, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Address Program
 * This program asks for the users address
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressAllisonC
{
    public partial class frmAddress : Form
    {
        public frmAddress()
        {
            InitializeComponent();
        }
        private void PrintAddress(string city, string street, string province, string postalCode)
        {
            //showing the address
            MessageBox.Show("Your address is: " + street + " street " + city + " " + province + " " + postalCode);
        }
        private void PrintAddress(string appartNumber, string city, string street, string province, string postalCode)
        {
            //showing the address
            MessageBox.Show("Your address is: " + appartNumber + " " + street + " street " + city + " " + province + " " + postalCode);
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare variables
            string appartNumber, city, street, province, postalCode;

            //get the user info
            appartNumber = txtAppartement.Text;
            city = txtCity.Text;
            street = txtStreet.Text;
            province = txtprovince.Text;
            postalCode = txtPostal.Text;

            //make sure they enter the nessiary info
            if (street == "")
            {
                //show an error message
                MessageBox.Show("Please enter a street", "Address Program");
            }
            else if (city == "")
            {
                //show an error message
                MessageBox.Show("Please enter a city", "Address Program");
            }
            else if (province == "")
            {
                //show an error message
                MessageBox.Show("Please enter a province", "Address Program");
            }
            else if (postalCode == "")
            {
                //show an error message
                MessageBox.Show("Please enter a postal code", "Address Program");
            }
            else if (appartNumber == "")
            {
                //call the print address
                PrintAddress(city, street, province, postalCode);
            }
            else
            {
                //call the print address
                PrintAddress(appartNumber, city, street, province, postalCode);
            }

        }
    }
}
