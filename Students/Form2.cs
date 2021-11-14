using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Students
{
    public partial class Form2 : Form
    {
        public string getText { get { return this.textBox1.Text; } set { this.textBox1.Text = value; } }
        public Form2()
        {
            InitializeComponent();
        }
        public void AddAdress()
        {
            string country = this.textBox1.Text;
            string city = this.textBox2.Text;
            int house = Convert.ToInt32(this.textBox3.Text);
            Adress adresnew = new Adress(city, country, house);

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
