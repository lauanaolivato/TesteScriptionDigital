namespace FormularioContato
{
    partial class frmAddEditContato
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSave = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.txtContatoNome = new System.Windows.Forms.TextBox();
            this.contatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.contatoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.contatoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(293, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "&Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(8, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(75, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome Contato";
            // 
            // txtContatoNome
            // 
            this.txtContatoNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource, "NomeDoContato", true));
            this.txtContatoNome.Location = new System.Drawing.Point(88, 28);
            this.txtContatoNome.Name = "txtContatoNome";
            this.txtContatoNome.Size = new System.Drawing.Size(280, 20);
            this.txtContatoNome.TabIndex = 0;
            this.txtContatoNome.TextChanged += new System.EventHandler(this.txtContatoNome_TextChanged);
            // 
            // contatoBindingSource
            // 
            this.contatoBindingSource.DataSource = typeof(FormularioContato.Contato);
            // 
            // txtTelefone
            // 
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource1, "Telefone", true));
            this.txtTelefone.Location = new System.Drawing.Point(88, 66);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(280, 20);
            this.txtTelefone.TabIndex = 1;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // contatoBindingSource1
            // 
            this.contatoBindingSource1.DataSource = typeof(FormularioContato.Contato);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contatoBindingSource2, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(88, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // contatoBindingSource2
            // 
            this.contatoBindingSource2.DataSource = typeof(FormularioContato.Contato);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // frmAddEditContato
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 198);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContatoNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddEditContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/EditContato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditContato_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contatoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtContatoNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource contatoBindingSource;
        private System.Windows.Forms.BindingSource contatoBindingSource1;
        private System.Windows.Forms.BindingSource contatoBindingSource2;
    }
}