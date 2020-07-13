using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Inicia o jogo com label, botao e masked box da quantidade de palitos que deseja retirar invisiveis

            label2.Visible = false;
            buttonretirar.Visible = false;
            maskedTextBox1.Visible = false;
            this.Text = "Jogo do Palito"; // titulo do form
        }

        int x;
        bool jogada = false;
       

        private void buttonjogar_Click(object sender, EventArgs e)
        {
            int valor1 = (int)nupdquantidade.Value;
            if (valor1 == 30 || valor1 == 26 || valor1 == 22) // refere-se a quantidade a ser removida que vai ser sempre 1
            {
                richTextBox1.AppendText("Eu começo!" + Environment.NewLine); //quantidade de palitos que iniciou
                richTextBox1.AppendText("Retiro 1 Palito" + Environment.NewLine); // quantidade de palitos que foi retirado
                richTextBox1.AppendText("Sua Vez..." + Environment.NewLine); // sua vez de jogar
                x = (valor1 - 1); // valor1 menos 1
                richTextBox1.AppendText("Restam " + x.ToString() + " Palitos" + Environment.NewLine); // quantidade de palitos que sobraram
                jogada = false;
            }

            if (valor1 == 29 || valor1 == 28 || valor1 == 25 || valor1 == 24 || valor1 == 21 || valor1 == 20)// refere-se a quantidade a ser removida que vai ser sempre 3
            {
                richTextBox1.AppendText("Eu começo!" + Environment.NewLine); //quantidade de palitos que iniciou
                richTextBox1.AppendText("Retiro 3 Palitos" + Environment.NewLine); // quantidade de palitos que foi retirado pelo computador
                richTextBox1.AppendText("Sua Vez..." + Environment.NewLine);// sua vez de jogar
                x = (valor1 - 3); // valor1 referente ao if menos 3 
                richTextBox1.AppendText("Restam " + x.ToString() + " Palitos" + Environment.NewLine);// quantidade de palitos que sobraram
                jogada = false;
            }

            if (valor1 == 27 || valor1 == 23)// refere-se a quantidade a ser removida que vai ser sempre 2
            {
                richTextBox1.AppendText("Eu começo!" + Environment.NewLine); //quantidade de palitos que iniciou
                richTextBox1.AppendText("Retiro 2 Palito" + Environment.NewLine); // quantidade de palitos que foi retirado pelo computador
                richTextBox1.AppendText("Sua Vez..." + Environment.NewLine); // sua vez de jogar
                x = (valor1 - 2); // efetua  o menos um referente  ai if //
                richTextBox1.AppendText("Restam " + x.ToString() + " Palitos" + Environment.NewLine);// quantidade de palitos que sobraram
                jogada = false;
                // remove de 4 em 4  29/25/21/17/13/9/5***************//
            }

            // Assim que clicar em jogar ele ativa os 3 componentes para retirar os palitos e desabilita o botao jogar da quantidade de palitos
            label2.Visible = true;
            buttonretirar.Visible = true;
            maskedTextBox1.Visible = true;
            buttonjogar.Enabled = false;
            maskedTextBox1.Focus(); //cursor voltado para o jogador digitar quantidade que deseja retirar

        }

        private void buttonretirar_Click(object sender, EventArgs e)
        {


            //se o campo que o jogador vai inserir a quantidade de palitos a retirar estiver vazio
            if (maskedTextBox1.Text == "".ToString())
            {
                //aparecera uma mensagem informando que o preenchimento e obrigatorio
                MessageBox.Show("Preenchimento obrigatorio da quantidade de palitos a remover.");
            }
            //caso contrario executa todas as acoes do codigo
            else
            {
                int retira = Convert.ToInt32(maskedTextBox1.Text); //convertendo para inteiro pois maskedtextbox recebe texto





                if (retira != 1 && retira != 2 && retira != 3) // verificar se  o numero digitado e diferente de 1, 2 ou 3
                {
                    // mensagem informando ao usuario caso o numero foi diferente do if, vai informar que nao aceita o valor
                    // maskedTextBox1.Focus() = cursor voltado para o jogador digitar quantidade que deseja retirar
                    MessageBox.Show("São permitidos retirar 1 a 3 palitos por jogada", "Error" + MessageBoxIcon.Error + maskedTextBox1.Focus());
                    maskedTextBox1.Clear(); //limpar campo
                }


                else
                {
                    {
                        jogada = true;
                        // se o x for igual a 5 e a jogada for verdadeira
                        if (x == 5 && jogada == true)
                        {
                            // 5 menos o valor inserido pelo jogador (1,2 ou 3)
                            x = x - retira;
                            richTextBox1.AppendText("Voce retirou " + retira + " Palitos"); //quantidade de palitos removidos
                            richTextBox1.AppendText("Restam " + x + " Palitos"); //quantidade de palitos que restaram

                            //se o x for igual a 4
                            if (x == 4)
                            {
                                // 4 menos 3
                                x = x - 3;
                                richTextBox1.AppendText("Retiro 3 palitos" + Environment.NewLine); //quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez..." + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos" + Environment.NewLine); //quantidade de palitos que restaram

                            }

                            //se o x for igual a 3
                            if (x == 3)
                            {
                                // 3 menos 2
                                x = x - 2;
                                richTextBox1.AppendText("Retiro 2 palitos" + Environment.NewLine); //quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez..." + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos" + Environment.NewLine); //quantidade de palitos que restaram
                            }

                            //se o x for igual a 2
                            if (x == 2)
                            {
                                //2 menos 3
                                x = x - 3;
                                richTextBox1.AppendText("Retiro 1 palito" + Environment.NewLine); //quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez..." + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos" + Environment.NewLine); //quantidade de palitos que restaram
                            }

                            //se o x for igual a 1
                            if (x == 1)
                            {
                                //1 menos 1
                                x = x - 1;
                                MessageBox.Show("Voce perdeu...", "kkkk muito facil!"); //mensagem informando que voce perdeu o jogo
                                // quando finalizar o jogo aparece uma mensagem perguntando ao jogador se deseja jogar novamente com opcao de sim ou nao
                                DialogResult dialogResult = MessageBox.Show("Deseja jogar de novo", "Desafio", MessageBoxButtons.YesNo);

                                // se o jogador clicar em sim
                                if
                                    (dialogResult == DialogResult.Yes)
                                {
                                    // limpa tudo e inicia o jogo
                                    richTextBox1.Clear();
                                    label2.Visible = false;
                                    buttonretirar.Visible = false;
                                    maskedTextBox1.Visible = false;
                                    buttonjogar.Enabled = true;
                                }

                                // se o usuario clicar em nao
                                else if (dialogResult == DialogResult.No)
                                {
                                    Environment.Exit(1); //finaliza o jogo // (0) verdadeiro = deixa o jogo rodando;  (1) falso = fecha o jogo
                                }
                            }
                        }
                        else
                        {
                            richTextBox1.AppendText("Você Retirou " + retira + " Palitos" + Environment.NewLine); // quantidade de palitos removidos
                            x -= retira; // subtrair a quantidade retirada
                            richTextBox1.AppendText("Restam " + x + " Palitos" + Environment.NewLine); // quantidade de palitos que sobraram
                            maskedTextBox1.Clear(); // limpa o campo para inserir um novo numero para ser removido

                            if (retira == 2)
                            {
                                jogada = false;
                                x = x - 2; //logica de 4 em 4 **** 2 mais 2 =4 //
                                richTextBox1.AppendText("Retiro 2 palitos" + Environment.NewLine); // quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez... " + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos " + Environment.NewLine); // quantidade de palitos que restaram
                            }

                            if (retira == 3)
                            {
                                jogada = false;
                                x = x - 1;  //logica de 4 em 4 **** 3 mais 1 =4 //
                                richTextBox1.AppendText("Retiro 3 palitos" + Environment.NewLine); // quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez... " + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos " + Environment.NewLine); // quantidade de palitos que restaram
                            }
                            if (retira == 1)
                            {
                                jogada = false;
                                x = x - 3;//logica de 4 em 4 **** 1 mais 3 =4 //
                                richTextBox1.AppendText("Retiro 3 palitos " + Environment.NewLine); // quantidade de palitos removidos
                                richTextBox1.AppendText("Sua vez..." + Environment.NewLine); // mensagem informando que e a sua vez de jogar
                                richTextBox1.AppendText("Restam " + x + " Palitos" + Environment.NewLine); // quantidade de palitos que restaram
                            }
                            maskedTextBox1.Focus(); //cursor voltado para o jogador digitar quantidade que deseja retirar
                            
                            //se x for menor que 1
                            if(x<1)
                            {
                                //aparece uma mensagem dizendo que a maquina perdeu, ou seja, o jogador venceu!
                                MessageBox.Show("Eu perdi", "Impossivel");
                                // quando finalizar o jogo aparece uma mensagem perguntando ao jogador se deseja jogar novamente com opcao de sim ou nao
                                DialogResult dialogResult = MessageBox.Show("Deseja jogar de novo", "Desafio", MessageBoxButtons.YesNo);

                                // se o jogador clicar em sim
                                if
                                    (dialogResult == DialogResult.Yes)
                                {
                                    // limpa tudo e inicia o jogo
                                    richTextBox1.Clear();
                                    label2.Visible = false;
                                    buttonretirar.Visible = false;
                                    maskedTextBox1.Visible = false;
                                    buttonjogar.Enabled = true;
                                }

                                // se o usuario clicar em nao
                                else if (dialogResult == DialogResult.No)
                                {
                                    Environment.Exit(1); //finaliza o jogo // (0) verdadeiro = deixa o jogo rodando;  (1) falso = fecha o jogo
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nupdquantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void buttonjogar_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
