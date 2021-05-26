using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MissedAssignment1
{
    
    public partial class ShowData : Form
    {
        ArrayList studentlist;
        MonthofAdmin m;
        public ShowData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentlist = new ArrayList();
            studentlist.Add(new Student(1, first:"Jacob", last: "Miller", addr:"Va Beach, VA", MonthofAdmin.Jan, Grades.A));
            dataGridView1.DataSource = studentlist;
            AdminBox.Visible = false;
            dataGridView1.Visible = false;
            dropAdmin.DataSource = Enum.GetValues(typeof(MonthofAdmin));
            GradeBox.DataSource = Enum.GetValues(typeof(Grades));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AdminBox.Visible = true;
            if (txtID.Text != string.Empty && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtCityState.Text != string.Empty)
            {
                studentlist.Add(new Student(Int32.Parse(txtID.Text), txtFirstName.Text, txtLastName.Text, txtCityState.Text, (MonthofAdmin)dropAdmin.SelectedValue, (Grades)GradeBox.SelectedValue));
            }
            refreshdata();
            
        }
        private void refreshdata()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentlist;
            txtID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCityState.Clear();
            dropAdmin.Text = "Select Month";
            GradeBox.Text = "Select Grade";
            
        }

        private void dropAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AdminBox.Visible = false;
            studentlist.RemoveAt(dataGridView1.CurrentRow.Index);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentlist;
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            AdminBox.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
