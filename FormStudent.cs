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
    public partial class FormStudent : Form
    {
        private User usuario;
        GetDataFacade f;
        List<Score> grades;
        public FormStudent(User u)
        {
            InitializeComponent();
            f = new GetDataFacade();
            usuario = u;
            grades = f.GetStudentScore(usuario.username);
            float avg = 0;
            label2.Text = usuario.name;
            label4.Text = usuario.major;
            label6.Text = usuario.birth_date.ToString();
            label8.Text = usuario.city;
            foreach(Score s in grades)
            {
                string subject = f.GetSubject(s.subject_id).name;
                string[] st = { subject, s.score.ToString() };
                avg += s.score;
                dataGridView1.Rows.Add(st);
            }
            avg /= grades.Count;
            label10.Text = avg.ToString();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog();
            DialogResult dr = saveF.ShowDialog();
            if(dr != DialogResult.OK)
            {
                return;
            }
            try
            {
                Exporter ex = ExportFactory.ExporterFactory();
                ex.Download(grades, saveF.FileName);
                MessageBox.Show("File saved successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
