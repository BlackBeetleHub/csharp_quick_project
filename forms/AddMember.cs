using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.src;

namespace WindowsFormsApp1.forms
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UserContext db = new UserContext())
            {
                Family member = new Family ();
                member.firts_name = firstNameTextBox.Text;
                member.second_name = secondNameTextBox.Text;
                member.details = detailsTextBox.Text;

                db.Users.Add(member);
                db.SaveChanges();
            }
        }
    }
}
