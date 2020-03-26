using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Form1 : Form
    {
        List<CarName> carList = new List<CarName>();
        public Form1()
        { 
            InitializeComponent();

            UpdateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            carList = db.GetInfo(nameInput.Text);
            UpdateList();
        }

        private void UpdateList()
        {
            InfoListBox.DataSource = carList;
            InfoListBox.DisplayMember = "ShowInfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertCar(insertCarId.Text, insertNameOfCar.Text, insertYear.Text, insertColor.Text);

            insertCarId.Text = "";
            insertNameOfCar.Text = "";
            insertYear.Text = "";
            insertColor.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteCar(deleteInputName.Text);
        }
    }
}