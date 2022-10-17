using SistemaEstacionamento.Data;
using SistemaEstacionamento.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstacionamento
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connManager conn = new connManager();
            dbUsuario db = new dbUsuario();

            frmMenu frm = new frmMenu();
            frm.Show();
            Hide();

            //ds = conn.retornaDados(db.authenticarUsuario(txtLogin.Text, txtSenha.Text));

            //if (ds!= null)
            //{
            //    lblErro.Visible = false;
            //    frmMenu frm = new frmMenu();
            //    frm.Show();
            //    Hide();
            //}
            //else
            //{
            //    lblErro.Visible = true;
            //}
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
        }

    }
}
