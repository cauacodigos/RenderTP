using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace treinoRender
{
    public partial class Form1: Form
    {
        private bool renderizar = false;
        List <Produto> produtos = new List <Produto> ();
        public Form1()
        {
            InitializeComponent();
        }
        private void render()
        {
            Label lbl_Nome = new Label()
            {
                Name = "lbl_nome",
                Text = "Nome",
                Location = new Point(290, 134),
                Size = new Size(85, 65)
            };
            this.Controls.Add(lbl_Nome);

            TextBox txt_Nome = new TextBox()
            {
                Name = "txt_Nome",
                Location = new Point(400, 134),
                Width = 100
            };
            this.Controls.Add(txt_Nome);

            Label lbl_Preco = new Label()
            {
                Name = "lbl_Preco",
                Text = "Preco",
                Location = new Point(290, 200),
                Size = new Size(85, 65)
            };
            this.Controls.Add(lbl_Preco);

            TextBox txt_Preco = new TextBox()
            {
                Name = "txt_Preco",
                Location = new Point(400, 200),
                Width = 100
            };
            this.Controls.Add(txt_Preco);

            Label lbl_Quant = new Label()
            {
                Name = "lbl_Quant",
                Text = "Quantidade",
                Location = new Point(290, 266),
                Size = new Size(85, 65)
            };
            this.Controls.Add(lbl_Quant);

            TextBox txt_Quant = new TextBox()
            {
                Name = "txt_Quant",
                Location = new Point(400, 266),
                Width = 100
            };
            this.Controls.Add(txt_Quant);

            Label lbl_Desc = new Label()
            {
                Name = "lbl_Desc",
                Text = "Descricao",
                Location = new Point(290, 332),
                Size = new Size(85, 65)
            };
            this.Controls.Add(lbl_Desc);

            TextBox txt_Desc = new TextBox()
            {
                Name = "txt_Desc",
                Location = new Point(400, 332),
                Width = 100
            };
            this.Controls.Add(txt_Desc);

            Button btn_Salvar = new Button()
            {
                Name = "btn_Salvar",
                Text = "Salvar",
                Location = new Point(400, 400),
                Size = new Size(100, 30),
            };

            btn_Salvar.Click += (s, e) =>
            {
                MessageBox.Show("Produto salvo com sucesso!");
            };
            this.Controls.Add(btn_Salvar);


            Button btn_Criar = new Button()
            {
                Name = "btn_Criar",
                Text = "Criar grid",
                Location = new Point(290, 400),
                Size = new Size(100, 30)
            };
            this.Controls.Add(btn_Criar);

            btn_Criar.Click += (s, e) =>
            {
                string nome = txt_Nome.Text;
                double preco = double.Parse(txt_Preco.Text);
                int quant = int.Parse(txt_Quant.Text);
                string desc = txt_Desc.Text;

                Produto p = new Produto(nome, preco, quant, desc);
                produtos.Add(p);

                foreach (Produto produtos in produtos)
                {
                    Console.WriteLine(produtos);

                    gv1.Rows.Add(nome, preco, quant, desc);
                }

            }; 
            this.Controls.Add(btn_Criar);
                
        }


        private void btn_renderizar_Click(object sender, EventArgs e)
        {
            if (!renderizar )
            {
               this.render();
            }
            
            
        }
    }
}
