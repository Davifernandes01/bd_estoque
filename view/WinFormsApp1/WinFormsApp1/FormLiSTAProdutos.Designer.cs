namespace WinFormsApp1
{
    partial class FormLiSTAProdutos
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
            dataGridView1 = new DataGridView();
            Column_nome = new DataGridViewTextBoxColumn();
            Column_descrição = new DataGridViewTextBoxColumn();
            Column_quantidade = new DataGridViewTextBoxColumn();
            Column_preco_unit = new DataGridViewTextBoxColumn();
            Column1_data_entrada = new DataGridViewTextBoxColumn();
            Column1_data_saida = new DataGridViewTextBoxColumn();
            label_nome = new Label();
            label2_desc = new Label();
            label_quant = new Label();
            label_precoUni = new Label();
            label_data_entrada = new Label();
            label_data_saida = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1_atualizar = new Button();
            button_deletar = new Button();
            button_sair = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_nome, Column_descrição, Column_quantidade, Column_preco_unit, Column1_data_entrada, Column1_data_saida });
            dataGridView1.Location = new Point(245, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 484);
            dataGridView1.TabIndex = 0;
            // 
            // Column_nome
            // 
            Column_nome.HeaderText = "Nome";
            Column_nome.Name = "Column_nome";
            // 
            // Column_descrição
            // 
            Column_descrição.HeaderText = "Descrição";
            Column_descrição.Name = "Column_descrição";
            // 
            // Column_quantidade
            // 
            Column_quantidade.HeaderText = "Quantidade";
            Column_quantidade.Name = "Column_quantidade";
            // 
            // Column_preco_unit
            // 
            Column_preco_unit.HeaderText = "Preço_Unitario";
            Column_preco_unit.Name = "Column_preco_unit";
            // 
            // Column1_data_entrada
            // 
            Column1_data_entrada.HeaderText = "Data_Entrada";
            Column1_data_entrada.Name = "Column1_data_entrada";
            // 
            // Column1_data_saida
            // 
            Column1_data_saida.HeaderText = "Data_Saida";
            Column1_data_saida.Name = "Column1_data_saida";
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Location = new Point(19, 115);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(40, 15);
            label_nome.TabIndex = 1;
            label_nome.Text = "Nome";
            // 
            // label2_desc
            // 
            label2_desc.AutoSize = true;
            label2_desc.Location = new Point(19, 152);
            label2_desc.Name = "label2_desc";
            label2_desc.Size = new Size(58, 15);
            label2_desc.TabIndex = 2;
            label2_desc.Text = "Descrição";
            // 
            // label_quant
            // 
            label_quant.AutoSize = true;
            label_quant.Location = new Point(19, 191);
            label_quant.Name = "label_quant";
            label_quant.Size = new Size(69, 15);
            label_quant.TabIndex = 3;
            label_quant.Text = "Quantidade";
            // 
            // label_precoUni
            // 
            label_precoUni.AutoSize = true;
            label_precoUni.Location = new Point(19, 225);
            label_precoUni.Name = "label_precoUni";
            label_precoUni.Size = new Size(63, 15);
            label_precoUni.TabIndex = 4;
            label_precoUni.Text = "Preço_unit";
            // 
            // label_data_entrada
            // 
            label_data_entrada.AutoSize = true;
            label_data_entrada.Location = new Point(19, 258);
            label_data_entrada.Name = "label_data_entrada";
            label_data_entrada.Size = new Size(76, 15);
            label_data_entrada.TabIndex = 5;
            label_data_entrada.Text = "Data_entrada";
            // 
            // label_data_saida
            // 
            label_data_saida.AutoSize = true;
            label_data_saida.Location = new Point(19, 287);
            label_data_saida.Name = "label_data_saida";
            label_data_saida.Size = new Size(63, 15);
            label_data_saida.TabIndex = 6;
            label_data_saida.Text = "Data_saida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 183);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 217);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 250);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(128, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(98, 287);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(128, 23);
            dateTimePicker2.TabIndex = 12;
            // 
            // button1_atualizar
            // 
            button1_atualizar.Location = new Point(2, 407);
            button1_atualizar.Name = "button1_atualizar";
            button1_atualizar.Size = new Size(75, 23);
            button1_atualizar.TabIndex = 13;
            button1_atualizar.Text = "Atualizar";
            button1_atualizar.UseVisualStyleBackColor = true;
            // 
            // button_deletar
            // 
            button_deletar.Location = new Point(83, 407);
            button_deletar.Name = "button_deletar";
            button_deletar.Size = new Size(75, 23);
            button_deletar.TabIndex = 14;
            button_deletar.Text = "Deletar";
            button_deletar.UseVisualStyleBackColor = true;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(164, 407);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(75, 23);
            button_sair.TabIndex = 15;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_sair_Click;
            // 
            // FormLiSTAProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(button_sair);
            Controls.Add(button_deletar);
            Controls.Add(button1_atualizar);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_data_saida);
            Controls.Add(label_data_entrada);
            Controls.Add(label_precoUni);
            Controls.Add(label_quant);
            Controls.Add(label2_desc);
            Controls.Add(label_nome);
            Controls.Add(dataGridView1);
            Name = "FormLiSTAProdutos";
            Text = "Lista de produtos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_nome;
        private DataGridViewTextBoxColumn Column_descrição;
        private DataGridViewTextBoxColumn Column_quantidade;
        private DataGridViewTextBoxColumn Column_preco_unit;
        private DataGridViewTextBoxColumn Column1_data_entrada;
        private DataGridViewTextBoxColumn Column1_data_saida;
        private Label label_nome;
        private Label label2_desc;
        private Label label_quant;
        private Label label_precoUni;
        private Label label_data_entrada;
        private Label label_data_saida;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1_atualizar;
        private Button button_deletar;
        private Button button_sair;
    }
}