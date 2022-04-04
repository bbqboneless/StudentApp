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
    public partial class Form1 : Form
    {
        GetDataFacade f;
        public Form1()
        {
            InitializeComponent();
            f = new GetDataFacade();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(f.GetPass(textBox1.Text, textBox2.Text) == true)
            {
                User usuario = f.GetUser(textBox1.Text);
                if (usuario.type == "student")
                {
                    new FormStudent(usuario).Show();
                    Hide();
                } else if (usuario.type == "teacher") {
                    new FormTeacher(usuario).Show();
                    Hide();
                } else if (usuario.type == "supervisor")
                {
                    new FormSupervisor(usuario).Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }
        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
