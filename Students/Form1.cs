using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Students
{
    public partial class Form1 : Form
    {
        private List<Teacher> list;
        private Form2 f2 = new Form2();
        private List<Student> list1 = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            list = new List<Teacher>();
            InitialModel();
            InitialComboBox();
            InitialComboBox2();
            DataTable(list);
            DataTableStudent(list1);
            SearchAge(list1);
        }
        public void FindStudent()
        {
            if (list1.Count > 0)
            {
                list1.Clear();
            }
            string type = this.comboBox1.SelectedItem.ToString();
            for (int i = 0; i < list.Count; i++)
            {

                List<Student> listStudent = list[i].getCourseWorkStudents();
                for (int j = 0; j < listStudent.Count; j++)
                {
                    if (type == listStudent[j].TypeStudent.ToString())
                    {
                        list1.Add(listStudent[j]);
                    }
                }
            }
            DataTableStudent(list1);
            SearchAge(list1);
        }
        private void DataTableStudent(List<Student> list)
        {

            DataTable tabel = new DataTable("name");
            tabel.Columns.Add("Id");
            tabel.Columns.Add("Name");
            tabel.Columns.Add("Surname");
            tabel.Columns.Add("Group");
            tabel.Columns.Add("Type");
            tabel.Columns.Add("Age");
            tabel.Columns.Add("City");
            tabel.Columns.Add("Street");
            tabel.Columns.Add("House");


            for (int i = 0; i < list.Count; i++)
                tabel.Rows.Add(i + 1, list[i].Name, list[i].Surname, list[i].Age, list[i].Group, list[i].TypeStudent, list[i].Adress.City, list[i].Adress.Street, list[i].Adress.House);


            this.dataGridView2.DataSource = tabel;
        }
        private void DataTable(List<Teacher> list)
        {

            DataTable tabel = new DataTable("name");
            tabel.Columns.Add("Id");
            tabel.Columns.Add("Name");
            tabel.Columns.Add("Surname");
            tabel.Columns.Add("Age");
            tabel.Columns.Add("City");
            tabel.Columns.Add("Street");
            tabel.Columns.Add("House");

            for (int i = 0; i < list.Count; i++)
                tabel.Rows.Add(i + 1, list[i].Name, list[i].Surname, list[i].Age, list[i].Adress.City, list[i].Adress.Street, list[i].Adress.House);


            this.dataGridView1.DataSource = tabel;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void InitialComboBox()
        {
            this.comboBox1.Items.Add("exelent");
            this.comboBox1.Items.Add("good");
            this.comboBox1.Items.Add("three");
            this.comboBox1.Items.Add("bad");
            this.comboBox1.Items.Add("very bad");
        }
        public void InitialModel()
        {
            Adress adres1 = new Adress("Kherson", "Universitetska", 12);
            Student student1 = new Student(121, "Nazar", "Nurlanov", 18, adres1, typeStudent.exelent);
            Student student2 = new Student(122, "Nazar", "Nurlanov", 19, adres1, typeStudent.good);
            Student student3 = new Student(121, "Natalia", "Nurzanova", 17, adres1, typeStudent.exelent);
            Student student4 = new Student(123, "Anastasia", "Koryagina", 18, adres1, typeStudent.exelent);
            Student student5 = new Student(121, "Ivan", "Safontev", 19, adres1, typeStudent.exelent);
            Teacher teacher1 = new Teacher(2, 4567, "Olga", "Gnedkova", 30, adres1);
            Teacher teacher2 = new Teacher(3, 4567, "Anastasia", "Bistryanceva", 30, adres1);
            teacher1.AddCourseWorkStudent(student1);
            teacher1.AddCourseWorkStudent(student2);
            teacher2.AddCourseWorkStudent(student3);
            teacher2.AddCourseWorkStudent(student4);
            teacher2.AddCourseWorkStudent(student5);
            list.Add(teacher1);
            list.Add(teacher2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FindStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(f2.getText);
        }
        public void InitialTreeView()
        {
            TreeNode root = new TreeNode();
            root.Name = "Root";
            root.Text = "List";
            this.treeView1.Nodes.Add(root);
            for (int i = 0; i < list.Count; i++)
            {
                this.treeView1.Nodes[0].Nodes.Add(list[i].Name + " " + list[i].Surname);
                List<Student> listStudent = list[i].getCourseWorkStudents();
                for (int j = 0; j < listStudent.Count; j++)
                    this.treeView1.Nodes[0].Nodes[i].Nodes.Add(listStudent[j].Name + " " + listStudent[j].Surname);
            }
            /*
            this.treeView1.Nodes[0].Nodes.Add("text1");
            this.treeView1.Nodes[0].Nodes.Add("text2");
            this.treeView1.Nodes[0].Nodes[0].Nodes.Add("text1.1");
            this.treeView1.Nodes[0].Nodes[1].Nodes.Add("text1.2");*/

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialTreeView();

        }
        private void SearchAge(List<Student> list1)
        {
            this.chart1.Series["Age"].Points.Clear();
            for (int i = 0; i < list1.Count; i++)
            {
                this.chart1.Series["Age"].Points.AddXY(list1[i].Name, list1[i].Age);
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adress adress = new Adress("Kherson", "Universietska", 12);
            string name = this.textBox4.Text;
            string surname = this.textBox5.Text;
            int salary = Convert.ToInt32(this.textBox7.Text);
            int age = Convert.ToInt32(this.textBox6.Text);
            int MaxNumberOfCourseWorks = Convert.ToInt32(this.textBox8.Text);
            Teacher teacher = new Teacher(MaxNumberOfCourseWorks, salary, name, surname, age, adress);
            list.Add(teacher);
            DataTable(list);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            f2.Show();
        }
        public void InitialComboBox2()
        {
            this.comboBox2.Items.Add("exelent");
            this.comboBox2.Items.Add("good");
            this.comboBox2.Items.Add("three");
            this.comboBox2.Items.Add("bad");
            this.comboBox2.Items.Add("very bad");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Adress adress = new Adress("Kherson", "Universietska", 12);
            string name = this.textBox9.Text;
            string surname = this.textBox10.Text;
            int age = Convert.ToInt32(this.textBox12.Text);
            int group = Convert.ToInt32(this.textBox11.Text);
            Student student = new Student(group, name, surname, age, adress, typeStudent.bad);
            list1.Add(student);

        }
    }
}