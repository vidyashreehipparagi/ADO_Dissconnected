using ADODisconnected.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADO_Dissconnected
{
    public partial class Form1 : Form
    {
        StudentCrud crud;
        DataTable table;
        public Form1()
        {
            InitializeComponent();
            crud = new StudentCrud();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = crud.GetAllCourses();
            cbSubjects.DataSource = table;
            cbSubjects.DisplayMember = "Cname";
            cbSubjects.ValueMember = "Cid";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btSave1_Click(object sender, EventArgs e)
        {
            try
            {
                Student p = new Student();
                p.Sname = txName.Text;
                p.Rollno = Convert.ToInt32(txRollno.Text);
                p.Cid = Convert.ToInt32(cbSubjects.SelectedValue);
                int res = crud.AddStudents(p);
                if (res > 0)
                {
                    MessageBox.Show("Record inserted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = crud.GetStudentById(Convert.ToInt32(txSid.Text));
                if (stu.Sid > 0)
                {
                    List<Courses> list = new List<Courses>();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        Courses c = new Courses();
                        c.Cid = Convert.ToInt32(table.Rows[i]["Cid"]);
                        c.Cname = table.Rows[i]["Cname"].ToString();
                        list.Add(c);
                    }
                    foreach (Courses item in list)
                    {
                        if (item.Cid == stu.Cid)
                        {
                            cbSubjects.Text = item.Cname;
                            break;
                        }
                    }
                    txName.Text = stu.Sname;
                    txRollno.Text = stu.Rollno.ToString();

                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)



            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Student p = new Student();
                p.Sid = Convert.ToInt32(txSid.Text);
                p.Sname = txName.Text;
                p.Rollno = Convert.ToInt32(txRollno.Text);
                p.Cid = Convert.ToInt32(cbSubjects.SelectedValue);
                int res = crud.UpdateStudent(p);
                if (res > 0)
                {
                    MessageBox.Show("Record updated..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            try
            {

                int res = crud.DeleteStudent(Convert.ToInt32(txSid.Text));
                if (res > 0)
                {
                    MessageBox.Show("Record deleted..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            DataSet ds = crud.GetStudents();
            dataGridView1.DataSource = ds.Tables["Student"];
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btShowAll_Click(object sender, EventArgs e)
        {
            DataTable table = crud.GetAllProducts();
            dataGridView1.DataSource = table;



        }
    }

}
