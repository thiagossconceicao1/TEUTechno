
namespace FrmComponentes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ltbFrutas = new System.Windows.Forms.ListBox();
            this.gpbFrutas = new System.Windows.Forms.GroupBox();
            this.lblBanana = new System.Windows.Forms.Label();
            this.lblMaca = new System.Windows.Forms.Label();
            this.lblPera = new System.Windows.Forms.Label();
            this.lblMelancia = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.txtFrutassel = new System.Windows.Forms.TextBox();
            this.lbFrutasel = new System.Windows.Forms.Label();
            this.cbbFrutaslistadas = new System.Windows.Forms.ComboBox();
            this.lblFrutaslist = new System.Windows.Forms.Label();
            this.lblFrutassel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtSelecione = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.gpbFrutas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbFrutas
            // 
            this.ltbFrutas.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbFrutas.FormattingEnabled = true;
            this.ltbFrutas.ItemHeight = 29;
            this.ltbFrutas.Location = new System.Drawing.Point(480, 137);
            this.ltbFrutas.Name = "ltbFrutas";
            this.ltbFrutas.Size = new System.Drawing.Size(179, 207);
            this.ltbFrutas.TabIndex = 7;
            this.ltbFrutas.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gpbFrutas
            // 
            this.gpbFrutas.Controls.Add(this.lblSair);
            this.gpbFrutas.Controls.Add(this.lblMelancia);
            this.gpbFrutas.Controls.Add(this.lblPera);
            this.gpbFrutas.Controls.Add(this.lblMaca);
            this.gpbFrutas.Controls.Add(this.lblBanana);
            this.gpbFrutas.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFrutas.Location = new System.Drawing.Point(45, 170);
            this.gpbFrutas.Name = "gpbFrutas";
            this.gpbFrutas.Size = new System.Drawing.Size(200, 195);
            this.gpbFrutas.TabIndex = 2;
            this.gpbFrutas.TabStop = false;
            this.gpbFrutas.Text = "Frutas";
            this.gpbFrutas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBanana
            // 
            this.lblBanana.AutoSize = true;
            this.lblBanana.Location = new System.Drawing.Point(26, 37);
            this.lblBanana.Name = "lblBanana";
            this.lblBanana.Size = new System.Drawing.Size(64, 29);
            this.lblBanana.TabIndex = 0;
            this.lblBanana.Text = "1-Banana";
            // 
            // lblMaca
            // 
            this.lblMaca.AutoSize = true;
            this.lblMaca.Location = new System.Drawing.Point(26, 65);
            this.lblMaca.Name = "lblMaca";
            this.lblMaca.Size = new System.Drawing.Size(58, 29);
            this.lblMaca.TabIndex = 1;
            this.lblMaca.Text = "2- Maça";
            // 
            // lblPera
            // 
            this.lblPera.AutoSize = true;
            this.lblPera.Location = new System.Drawing.Point(26, 94);
            this.lblPera.Name = "lblPera";
            this.lblPera.Size = new System.Drawing.Size(53, 29);
            this.lblPera.TabIndex = 2;
            this.lblPera.Text = "3- Pera";
            // 
            // lblMelancia
            // 
            this.lblMelancia.AutoSize = true;
            this.lblMelancia.Location = new System.Drawing.Point(26, 123);
            this.lblMelancia.Name = "lblMelancia";
            this.lblMelancia.Size = new System.Drawing.Size(79, 29);
            this.lblMelancia.TabIndex = 3;
            this.lblMelancia.Text = "4- Melancia";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Location = new System.Drawing.Point(26, 152);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(53, 29);
            this.lblSair.TabIndex = 4;
            this.lblSair.Text = "5- Sair ";
            // 
            // txtFrutassel
            // 
            this.txtFrutassel.Location = new System.Drawing.Point(76, 400);
            this.txtFrutassel.Name = "txtFrutassel";
            this.txtFrutassel.Size = new System.Drawing.Size(100, 20);
            this.txtFrutassel.TabIndex = 1;
            // 
            // lbFrutasel
            // 
            this.lbFrutasel.AutoSize = true;
            this.lbFrutasel.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrutasel.Location = new System.Drawing.Point(71, 368);
            this.lbFrutasel.Name = "lbFrutasel";
            this.lbFrutasel.Size = new System.Drawing.Size(115, 29);
            this.lbFrutasel.TabIndex = 4;
            this.lbFrutasel.Text = "Frutas selecionada";
            this.lbFrutasel.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbbFrutaslistadas
            // 
            this.cbbFrutaslistadas.FormattingEnabled = true;
            this.cbbFrutaslistadas.Location = new System.Drawing.Point(499, 399);
            this.cbbFrutaslistadas.Name = "cbbFrutaslistadas";
            this.cbbFrutaslistadas.Size = new System.Drawing.Size(121, 21);
            this.cbbFrutaslistadas.TabIndex = 6;
            // 
            // lblFrutaslist
            // 
            this.lblFrutaslist.AutoSize = true;
            this.lblFrutaslist.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutaslist.Location = new System.Drawing.Point(494, 367);
            this.lblFrutaslist.Name = "lblFrutaslist";
            this.lblFrutaslist.Size = new System.Drawing.Size(110, 29);
            this.lblFrutaslist.TabIndex = 6;
            this.lblFrutaslist.Text = "Fruta selecionada";
            // 
            // lblFrutassel
            // 
            this.lblFrutassel.AutoSize = true;
            this.lblFrutassel.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrutassel.Location = new System.Drawing.Point(475, 105);
            this.lblFrutassel.Name = "lblFrutassel";
            this.lblFrutassel.Size = new System.Drawing.Size(93, 29);
            this.lblFrutassel.TabIndex = 7;
            this.lblFrutassel.Text = "Frutas listadas";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 119);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(233, 29);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Digite o número para selecionar a fruta:";
            // 
            // txtSelecione
            // 
            this.txtSelecione.Location = new System.Drawing.Point(45, 144);
            this.txtSelecione.Name = "txtSelecione";
            this.txtSelecione.Size = new System.Drawing.Size(200, 20);
            this.txtSelecione.TabIndex = 0;
            this.txtSelecione.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(322, 144);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 37);
            this.btnSelecionar.TabIndex = 3;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(322, 264);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 37);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(322, 322);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 37);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(322, 207);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 37);
            this.btnInserir.TabIndex = 4;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.txtSelecione);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblFrutassel);
            this.Controls.Add(this.lblFrutaslist);
            this.Controls.Add(this.cbbFrutaslistadas);
            this.Controls.Add(this.lbFrutasel);
            this.Controls.Add(this.txtFrutassel);
            this.Controls.Add(this.gpbFrutas);
            this.Controls.Add(this.ltbFrutas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frutas";
            this.gpbFrutas.ResumeLayout(false);
            this.gpbFrutas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ltbFrutas;
        private System.Windows.Forms.GroupBox gpbFrutas;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblMelancia;
        private System.Windows.Forms.Label lblPera;
        private System.Windows.Forms.Label lblMaca;
        private System.Windows.Forms.Label lblBanana;
        private System.Windows.Forms.TextBox txtFrutassel;
        private System.Windows.Forms.Label lbFrutasel;
        private System.Windows.Forms.ComboBox cbbFrutaslistadas;
        private System.Windows.Forms.Label lblFrutaslist;
        private System.Windows.Forms.Label lblFrutassel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtSelecione;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnInserir;
    }
}

