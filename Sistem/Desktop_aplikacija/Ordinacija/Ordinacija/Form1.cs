using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordinacija
{
    public partial class Login : Form
    {
        //podaci za prijavu
        private String korisnickoIme = null;
        private String lozinka = null;


        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            korisnickoIme = txtKorisnickoIme.Text;
            lozinka = txtLozinka.Text;

            //provjera ulaznih podataka
            

        }

    }
}
