namespace CRUD_SistemaFinanceiro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txbTipo = new TextBox();
            txbDescricao = new TextBox();
            label2 = new Label();
            txbValor = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            btnRegistro = new Button();
            txbValorUP = new TextBox();
            label5 = new Label();
            txbDescricaoUP = new TextBox();
            label6 = new Label();
            btnAtualizar = new Button();
            txbIDUP = new TextBox();
            label7 = new Label();
            btnConsulta = new Button();
            btnRemover = new Button();
            txbID = new TextBox();
            btnFiltrar = new Button();
            btnConsultarUP = new Button();
            lblSaldo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(391, 273);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 89);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Tipo";
            // 
            // txbTipo
            // 
            txbTipo.Location = new Point(489, 118);
            txbTipo.Name = "txbTipo";
            txbTipo.Size = new Size(86, 23);
            txbTipo.TabIndex = 2;
            // 
            // txbDescricao
            // 
            txbDescricao.Location = new Point(489, 187);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(117, 23);
            txbDescricao.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 158);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Descricao";
            // 
            // txbValor
            // 
            txbValor.Location = new Point(489, 260);
            txbValor.Name = "txbValor";
            txbValor.Size = new Size(86, 23);
            txbValor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 231);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(489, 339);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 305);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 8;
            label4.Text = "Data do Lançamento";
            // 
            // btnRegistro
            // 
            btnRegistro.Location = new Point(489, 390);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(80, 26);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Registrar";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // txbValorUP
            // 
            txbValorUP.Location = new Point(884, 260);
            txbValorUP.Name = "txbValorUP";
            txbValorUP.Size = new Size(86, 23);
            txbValorUP.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(884, 231);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Valor";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // txbDescricaoUP
            // 
            txbDescricaoUP.Location = new Point(884, 187);
            txbDescricaoUP.Name = "txbDescricaoUP";
            txbDescricaoUP.Size = new Size(117, 23);
            txbDescricaoUP.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(884, 158);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 10;
            label6.Text = "Descricao";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(884, 320);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(75, 23);
            btnAtualizar.TabIndex = 14;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // txbIDUP
            // 
            txbIDUP.Location = new Point(884, 118);
            txbIDUP.Name = "txbIDUP";
            txbIDUP.Size = new Size(86, 23);
            txbIDUP.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(884, 89);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 15;
            label7.Text = "ID do Lançamento";
            // 
            // btnConsulta
            // 
            btnConsulta.Location = new Point(35, 393);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new Size(98, 33);
            btnConsulta.TabIndex = 17;
            btnConsulta.Text = "Consultar";
            btnConsulta.UseVisualStyleBackColor = true;
            btnConsulta.Click += btnConsulta_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(260, 40);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 18;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // txbID
            // 
            txbID.Location = new Point(134, 42);
            txbID.Name = "txbID";
            txbID.Size = new Size(100, 23);
            txbID.TabIndex = 19;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(351, 41);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 20;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnConsultarUP
            // 
            btnConsultarUP.Location = new Point(1002, 118);
            btnConsultarUP.Name = "btnConsultarUP";
            btnConsultarUP.Size = new Size(75, 23);
            btnConsultarUP.TabIndex = 21;
            btnConsultarUP.Text = "Consultar";
            btnConsultarUP.UseVisualStyleBackColor = true;
            btnConsultarUP.Click += btnConsultarUP_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(172, 404);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(36, 15);
            lblSaldo.TabIndex = 22;
            lblSaldo.Text = "Saldo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 597);
            Controls.Add(lblSaldo);
            Controls.Add(btnConsultarUP);
            Controls.Add(btnFiltrar);
            Controls.Add(txbID);
            Controls.Add(btnRemover);
            Controls.Add(btnConsulta);
            Controls.Add(txbIDUP);
            Controls.Add(label7);
            Controls.Add(btnAtualizar);
            Controls.Add(txbValorUP);
            Controls.Add(label5);
            Controls.Add(txbDescricaoUP);
            Controls.Add(label6);
            Controls.Add(btnRegistro);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(txbValor);
            Controls.Add(label3);
            Controls.Add(txbDescricao);
            Controls.Add(label2);
            Controls.Add(txbTipo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txbTipo;
        private TextBox txbDescricao;
        private Label label2;
        private TextBox txbValor;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button btnRegistro;
        private TextBox txbValorUP;
        private Label label5;
        private TextBox txbDescricaoUP;
        private Label label6;
        private Button btnAtualizar;
        private TextBox txbIDUP;
        private Label label7;
        private Button btnConsulta;
        private Button btnRemover;
        private TextBox txbID;
        private Button btnFiltrar;
        private Button btnConsultarUP;
        private Label lblSaldo;
    }
}
