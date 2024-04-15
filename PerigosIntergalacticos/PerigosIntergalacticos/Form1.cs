using PerigosIntergalacticos.Modelos;

namespace PerigosIntergalacticos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        public string RaSelecionado = "";
        public string JsonProcurados = "Teste antes de executar";
        string ArquivoJsonProcurados = @"Banco de Dados\Procurados.json";
        string ArquivoJsonLocalizacao = @"Banco de Dados\Localização.json";


        private void lblProcuradoRA_TextChanged(object sender, EventArgs e)
        {
            lblProcuradoRA.Text = "RA";
        }



        private void btnMaisInformacoes_Click(object sender, EventArgs e)
        {
            MaisInformacoes maisinformacoes = new MaisInformacoes();
            maisinformacoes.Show();

        }

        public void PuxarProcurado(string ArquivoJsonProcurados, string RaSelecionado)
        {
            Controle controle = new Controle();
            controle.ProcurarProcurado(ArquivoJsonProcurados, RaSelecionado);
            lblMensagem.Text = controle.mensagem;
            lblMensagemProcurado.Text = controle.statusProcurado;  //Vai me atualizar sobre o arquivo do Procurado
        }

        public void PuxarLocalizacao(string ArquivoJsonLocalizacao, string RaSelecionado)
        {
            Controle controle = new Controle();
            controle.ProcurarLocalizacao(ArquivoJsonLocalizacao, RaSelecionado);
            lblMensagem.Text = controle.mensagem;
            lblMensagemLocalizacao.Text = controle.statusLocalizacao;    //Vai me atualizar sobre o arquivo da Localização
        }

        public void AtualizarProcurado()
        {
            if (lblMensagemProcurado.Text.Equals("Procurado encontrado com sucesso"))
            {
                lblProcuradoRA.Text = ("RA: " + Controle.RA);
                lblProcuradoNome.Text = ("Nome: " + Controle.Nome);
                lblProcuradoSobrenome.Text = ("Sobrenome: " + Controle.Sobrenome);
                lblProcuradoEspecie.Text = ("Especie: " + Controle.Especie);
                lblProcuradoIdade.Text = ("Idade: " + Controle.Idade);
                lblProcuradoAltura.Text = ("Altura: " + Controle.Altura);
                lblProcuradoPeso.Text = ("Peso: " + Controle.Peso);
                lblProcuradoNivel.Text = ("Nivel de Procurado: " + Controle.NivelProcurado);
                lblProcuradoTitulo.Text = (Controle.Nome + " " + Controle.Sobrenome);
                if (!Controle.Icone.Equals(""))
                {

                    ptbProcuradoIcone.ImageLocation = Controle.Icone;

                }
                else
                {
                    ptbProcuradoIcone.ImageLocation = @"Imagens\DefaultAvatarIcon.jpg";
                }
            }
        }

        public void AtualizarLocalizacao()
        {
            if (lblMensagemLocalizacao.Text.Equals("Localização encontrada com sucesso"))
            {

                lblProcuradoGalaxia.Text = ("Galaxia: " + Controle.Local_Nascimento_Galaxia);
                lblProcuradoPlaneta.Text = ("Planeta: " + Controle.Local_Nascimento_Planeta);

            }
        }

        public void AtualizarInformacoes(string ArquivoJsonProcurados, string ArquivoJsonLocalizacao, string RaSelecionado)
        {
            PuxarProcurado(ArquivoJsonProcurados, RaSelecionado);
            AtualizarProcurado();
            PuxarLocalizacao(ArquivoJsonLocalizacao, RaSelecionado);
            AtualizarLocalizacao();
            lblMensagem.Text = "Sequencia feita com sucesso, procurado de agora: " + Controle.Nome;
        }

        private void cbbSelecaoRA_TextChanged(object sender, EventArgs e)
        {
            RaSelecionado = cbbSelecaoRA.Text;
            AtualizarInformacoes(ArquivoJsonProcurados, ArquivoJsonLocalizacao, RaSelecionado);
        }
    }
}
