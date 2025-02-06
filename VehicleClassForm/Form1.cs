using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleClassLibrary;
using OurFirstClassLibrary;
namespace VehicleClassForm
{
    public partial class Form1 : Form
    {
        RentalService rentalService = new RentalService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserProfile newUser = new UserProfile("Charles", 30);
        }
    }
}
