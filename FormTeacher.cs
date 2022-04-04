using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto21
{
    public partial class FormTeacher : Form
    {
        private User usuario;
        GetDataFacade f;
        List<Score> grades;
        public FormTeacher(User u)
        {
            InitializeComponent();
            f = new GetDataFacade();
            usuario = u;
            grades = f.GetTeacherScore(usuario.username);
            label3.Text = usuario.name;
            label5.Text = usuario.birth_date.ToString();
            label7.Text = usuario.city;
            foreach (Score s in grades)
            {
                string subject = f.GetUser(s.student).name;
                string[] st = { subject, s.score.ToString() };
                dataGridView1.Rows.Add(st);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}
