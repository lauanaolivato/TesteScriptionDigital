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
    public partial class Form1 : Form
    {
        ContatoEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ContatoEntities();
            contatoBindingSource.DataSource = db.Contatoes.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (frmAddEditContato frm = new frmAddEditContato(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contatoBindingSource.DataSource = db.Contatoes.ToList();
            }
        }

        private void btnedd_Click(object sender, EventArgs e)
        {
            if (contatoBindingSource.Current == null)
                return;
            using (frmAddEditContato frm = new frmAddEditContato(contatoBindingSource.Current as Contato))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contatoBindingSource.DataSource = db.Contatoes.ToList();
            }

        }

        private void btndele_Click(object sender, EventArgs e)
        {
            if (contatoBindingSource.Current != null)
            {
                if(MessageBox.Show("Você Tem Certeza Que Quer Deletar Esse Contato?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Contatoes.Remove(contatoBindingSource.Current as Contato);
                    contatoBindingSource.RemoveCurrent();
                    db.SaveChanges();
               }
            }
        }
    }
}
