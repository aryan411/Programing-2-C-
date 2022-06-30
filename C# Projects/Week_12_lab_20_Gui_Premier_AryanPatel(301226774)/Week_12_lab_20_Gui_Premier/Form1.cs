using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_12_lab_20_Gui_Premier
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers = new Dictionary<string, Premier>();
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
            //lstPremier.DataSource = new List<string>();
            //lstPremier.Items.Add("Narendra");


        }

        private void picPremier_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstPremier_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGui(lstPremier.SelectedValue.ToString()); //give the selected value
            // lstPremier.SelectedItem.ToString(); //give the selected item
           // lstPremier.SelectedItems;
        }
        public void InitializeGui()
        {
            List<Premier> premierObjs = new List<Premier>();
            premierObjs = Premier.GetPremiers();
            premierObjs.ForEach((p) =>
            {
                this.premiers.Add(p.GenerateKey(), p);
            });
            lstPremier.DataSource = this.premiers.Keys.ToList<string>();

        }
        public void UpdateGui(string key)
        {
            Premier selectedP = this.premiers.GetValueOrDefault(key);
            name.Text = selectedP.Name;
            lifeLable.Text = selectedP.Life;
            startEndLabel.Text = selectedP.Start + selectedP.End;
            picPremier.Image = Image.FromFile($"images\\{key}.jpg");
        }
    }
}
