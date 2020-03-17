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

            InfoListBox.DataSource = carList;
            InfoListBox.DisplayMember = "ShowInfo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DataAccess db = new DataAccess();
            carList = db.GetInfo(NameInput.Text);
            

        }
    }
}