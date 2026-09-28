using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroCliente
{
    public partial class telaCliente : Form //": FORM" é herança
    {
        public telaCliente()//construtor, so inicializa os componenetes, cria na maquina os inputs etc
        {
            InitializeComponent();
        }

        private void telaCliente_Load(object sender, EventArgs e)
        {
            //tudo que eu quero que inicie junto da tela, logo ai iniciar, NÃO PODE APAGAR OS COMPONENTES NO FODASSE
        }

        private void tituloPagina_Click(object sender, EventArgs e)
        {

        }

        private void excluir_Click(object sender, EventArgs e)
        {
           Excluir exc = new Excluir();
           exc.ShowDialog();

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            Cadastrar cad = new Cadastrar();//declarar uma classe e assimila a tela
            cad.ShowDialog();//mostrar a tela

        }//fim do metodo cadastrar

        private void consultar_Click(object sender, EventArgs e)
        {
            Consultar con = new Consultar();
            con.ShowDialog();

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Atualizar atu = new Atualizar();
            atu.ShowDialog();

        }
    }
}
