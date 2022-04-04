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
    public partial class FormSupervisor : Form
    {
        private User usuario;
        GetDataFacade f;
        public FormSupervisor(User u)
        {
            InitializeComponent();
            f = new GetDataFacade();
            usuario = u;
            label2.Text = usuario.name;
            label4.Text = usuario.birth_date.ToString();
            label6.Text = usuario.city.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Hide();
        }
    }
}
