using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioContato
{

    public partial class frmAddEditContato : Form
    {
        ContatoEntities db;
        public frmAddEditContato(Contato obj)
        {
            InitializeComponent();
            db = new ContatoEntities();
            if (obj == null)
            {
                contatoBindingSource.DataSource = new Contato();
                db.Contatoes.Add(contatoBindingSource.Current as Contato);
            }
            else
            {
                contatoBindingSource.DataSource = obj;
                db.Contatoes.Attach(contatoBindingSource.Current as Contato);

            }
        }

        private void frmAddEditContato_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (String.IsNullOrEmpty(txtContatoNome.Text))
                {
                    MessageBox.Show("Por Favor Coloque Seu Nome de Contato", "menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContatoNome.Focus();
                    e.Cancel = true;
                    return;
                }

                db.SaveChanges();
                e.Cancel = false;

            }
            e.Cancel = false;
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtContatoNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}