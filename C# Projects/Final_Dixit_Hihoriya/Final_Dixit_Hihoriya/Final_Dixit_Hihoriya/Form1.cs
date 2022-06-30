using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Dixit_Hihoriya
{
    public partial class Form1 : Form
    {
        int totalObj;
        int curObject = 0;
        List<City> cityObject = new List<City>();
        List<string> sortList = new List<string>();
        List<string> sTypes = new List<string> { "Name", "Country" };
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void InitializeGui()
        {
            cityObject = City.GetCities();
            totalObj = cityObject.Count;
            cityObject.ForEach((c) =>
            {
                this.sortList.Add($"{c.Name} , {c.Country}");
            });
            sortBox.Items.Add("Name");
            sortBox.Items.Add("Country");
            lstCity.DataSource = this.sortList;
        }

        private void preB_Click(object sender, EventArgs e)
        {
            if (curObject > 0)
            {
                --curObject;
            }
            else
            {
                curObject = totalObj;
            }
            city.Text = cityObject[curObject].Name;
            country.Text = cityObject[curObject].Country;
            dec.Text = cityObject[curObject].Description;
            picCity.Image = Image.FromFile(cityObject[curObject].Image);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadB_Click(object sender, EventArgs e)
        {
            curObject = 0;
            city.Text = cityObject[curObject].Name;
            country.Text = cityObject[curObject].Country;
            dec.Text = cityObject[curObject].Description;
            picCity.Image = Image.FromFile(cityObject[curObject].Image);
        }

        private void nextB_Click(object sender, EventArgs e)
        {
            if (curObject < totalObj - 1)
            {
                ++curObject;
            }
            else
            {
                curObject = 0;
            }
            city.Text = cityObject[curObject].Name;
            country.Text = cityObject[curObject].Country;
            dec.Text = cityObject[curObject].Description;
            picCity.Image = Image.FromFile(cityObject[curObject].Image);

        }

        private void sort_Click(object sender, EventArgs e)
        {
            if (sortBox.Text == "Name")
            {
                this.sortList = this.sortList.OrderBy(q => q.Split(',')[0]).ToList();
                lstCity.DataSource = this.sortList;
            }
            else
            {
                this.sortList = this.sortList.OrderBy(q => q.Split(',')[1]).ToList();
                lstCity.DataSource = this.sortList;
            }

        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
