namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            textValor_unit = new TextBox();
            Preco_unitario = new Label();
            button_adicionar = new Button();
            label_data = new Label();
            text_quantidade = new TextBox();
            text_descrição = new TextBox();
            text_nome = new TextBox();
            dateTime_data = new DateTimePicker();
            label_quantidade = new Label();
            label_descrição = new Label();
            label_nome = new Label();
            button_lista_produtos = new Button();
            button_vendas = new Button();
            button_Fornecedores = new Button();
            button_sair = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textValor_unit);
            groupBox1.Controls.Add(Preco_unitario);
            groupBox1.Controls.Add(button_adicionar);
            groupBox1.Controls.Add(label_data);
            groupBox1.Controls.Add(text_quantidade);
            groupBox1.Controls.Add(text_descrição);
            groupBox1.Controls.Add(text_nome);
            groupBox1.Controls.Add(dateTime_data);
            groupBox1.Controls.Add(label_quantidade);
            groupBox1.Controls.Add(label_descrição);
            groupBox1.Controls.Add(label_nome);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(27, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(723, 325);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar produtos";
            // 
            // textValor_unit
            // 
            textValor_unit.Location = new Point(90, 130);
            textValor_unit.Name = "textValor_unit";
            textValor_unit.PlaceholderText = "0,0";
            textValor_unit.Size = new Size(100, 23);
            textValor_unit.TabIndex = 11;
            // 
            // Preco_unitario
            // 
            Preco_unitario.AutoSize = true;
            Preco_unitario.Location = new Point(6, 138);
            Preco_unitario.Name = "Preco_unitario";
            Preco_unitario.Size = new Size(64, 15);
            Preco_unitario.TabIndex = 10;
            Preco_unitario.Text = "Preço_Unit";
            // 
            // button_adicionar
            // 
            button_adicionar.Location = new Point(31, 283);
            button_adicionar.Name = "button_adicionar";
            button_adicionar.Size = new Size(75, 23);
            button_adicionar.TabIndex = 1;
            button_adicionar.Text = "Adicionar";
            button_adicionar.UseVisualStyleBackColor = true;
            button_adicionar.Click += button_adicionar_Click;
            // 
            // label_data
            // 
            label_data.AutoSize = true;
            label_data.Location = new Point(8, 165);
            label_data.Name = "label_data";
            label_data.Size = new Size(31, 15);
            label_data.TabIndex = 8;
            label_data.Text = "Data";
            // 
            // text_quantidade
            // 
            text_quantidade.Location = new Point(90, 101);
            text_quantidade.Name = "text_quantidade";
            text_quantidade.PlaceholderText = "0";
            text_quantidade.Size = new Size(100, 23);
            text_quantidade.TabIndex = 7;
            // 
            // text_descrição
            // 
            text_descrição.Location = new Point(90, 73);
            text_descrição.Name = "text_descrição";
            text_descrição.Size = new Size(100, 23);
            text_descrição.TabIndex = 6;
            // 
            // text_nome
            // 
            text_nome.Location = new Point(90, 44);
            text_nome.Name = "text_nome";
            text_nome.Size = new Size(100, 23);
            text_nome.TabIndex = 5;
            // 
            // dateTime_data
            // 
            dateTime_data.Location = new Point(90, 159);
            dateTime_data.Name = "dateTime_data";
            dateTime_data.Size = new Size(231, 23);
            dateTime_data.TabIndex = 4;
            // 
            // label_quantidade
            // 
            label_quantidade.AutoSize = true;
            label_quantidade.Location = new Point(6, 109);
            label_quantidade.Name = "label_quantidade";
            label_quantidade.Size = new Size(69, 15);
            label_quantidade.TabIndex = 2;
            label_quantidade.Text = "Quantidade";
            // 
            // label_descrição
            // 
            label_descrição.AutoSize = true;
            label_descrição.Location = new Point(6, 81);
            label_descrição.Name = "label_descrição";
            label_descrição.Size = new Size(58, 15);
            label_descrição.TabIndex = 1;
            label_descrição.Text = "Descrição";
            // 
            // label_nome
            // 
            label_nome.AutoSize = true;
            label_nome.Location = new Point(6, 52);
            label_nome.Name = "label_nome";
            label_nome.Size = new Size(40, 15);
            label_nome.TabIndex = 0;
            label_nome.Text = "Nome";
            label_nome.Click += label_nome_Click;
            // 
            // button_lista_produtos
            // 
            button_lista_produtos.Location = new Point(35, 393);
            button_lista_produtos.Name = "button_lista_produtos";
            button_lista_produtos.Size = new Size(112, 23);
            button_lista_produtos.TabIndex = 1;
            button_lista_produtos.Text = "lista de produtos";
            button_lista_produtos.UseVisualStyleBackColor = true;
            button_lista_produtos.Click += button_lista_produtos_Click;
            // 
            // button_vendas
            // 
            button_vendas.Location = new Point(202, 393);
            button_vendas.Name = "button_vendas";
            button_vendas.Size = new Size(75, 23);
            button_vendas.TabIndex = 2;
            button_vendas.Text = "Vendas";
            button_vendas.UseVisualStyleBackColor = true;
            button_vendas.Click += button_vendas_Click;
            // 
            // button_Fornecedores
            // 
            button_Fornecedores.Location = new Point(334, 393);
            button_Fornecedores.Name = "button_Fornecedores";
            button_Fornecedores.Size = new Size(75, 23);
            button_Fornecedores.TabIndex = 3;
            button_Fornecedores.Text = "Fornecedores";
            button_Fornecedores.UseVisualStyleBackColor = true;
            button_Fornecedores.Click += button4_Click;
            // 
            // button_sair
            // 
            button_sair.Location = new Point(475, 393);
            button_sair.Name = "button_sair";
            button_sair.Size = new Size(75, 23);
            button_sair.TabIndex = 4;
            button_sair.Text = "Sair";
            button_sair.UseVisualStyleBackColor = true;
            button_sair.Click += button_sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_sair);
            Controls.Add(button_Fornecedores);
            Controls.Add(button_vendas);
            Controls.Add(button_lista_produtos);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label_nome;
        private Button button_adicionar;
        private Label label_data;
        private TextBox text_quantidade;
        private TextBox text_descrição;
        private TextBox text_nome;
        private DateTimePicker dateTime_data;
        private Label label_quantidade;
        private Label label_descrição;
        private Button button_lista_produtos;
        private Button button_vendas;
        private Button button_Fornecedores;
        private Button button_sair;
        private TextBox textValor_unit;
        private Label Preco_unitario;
    }
}