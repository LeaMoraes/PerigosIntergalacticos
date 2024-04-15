using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerigosIntergalacticos.Modelos;

namespace PerigosIntergalacticos
{
    public partial class MaisInformacoes : Form
    {


        public MaisInformacoes()
        {
            InitializeComponent();
            this.Text = ("Mais Informações: " + Controle.Nome);
            //Informações Basicas
            lblTitulo.Text = (Controle.Nome + " " + Controle.Sobrenome);
            lblEspecie.Text = ("Especie: " + Controle.Especie);
            lblIdade.Text = ("Idade: " + Controle.Idade);
            lblRA.Text = ("RA: " + Controle.RA);
            lblIDGalaxia.Text = ("ID Galaxia: " + Controle.ID_Galaxia);
            lblAltura.Text = ("Altura: " + Controle.Altura);
            lblPeso.Text = ("Peso: " + Controle.Peso);
            lblNivelProcurado.Text = ("Nivel de Procurado: " + Controle.NivelProcurado);
            //Informações Local Nascimento
            lblLocalNascimentoGalaxia.Text = ("Galaxia: " + Controle.Local_Nascimento_Galaxia);
            lblLocalNascimentoPlaneta.Text = ("Planeta: " + Controle.Local_Nascimento_Planeta);
            lblLocalNascimentoPais.Text = ("Pais: " + Controle.Local_Nascimento_Pais);
            lblLocalNascimentoEstado.Text = ("Estado: " + Controle.Local_Nascimento_Estado);
            lblLocalNascimentoCidade.Text = ("Cidade: " + Controle.Local_Nascimento_Cidade);
            lblLocalNascimentoData.Text = ("Data: " + Controle.Local_Nascimento_Data);
            //Informações Ultima Localização
            lblUltimaLocalizacaoGalaxia.Text = ("Galaxia: " + Controle.Ultima_Localização_Galaxia);
            lblUltimaLocalizacaoPlaneta.Text = ("Planeta: " + Controle.Ultima_Localização_Planeta);
            lblUltimaLocalizacaoPais.Text = ("Pais: " + Controle.Ultima_Localização_Pais);
            lblUltimaLocalizacaoEstado.Text = ("Estado: " + Controle.Ultima_Localização_Estado);
            lblUltimaLocalizacaoCidade.Text = ("Cidade: " + Controle.Ultima_Localização_Cidade);
            lblUltimaLocalizacaoData.Text = ("Data: " + Controle.Ultima_Localização_Data);
        }


        private void MaisInformacoes_Load(object sender, EventArgs e)
        {
            
        }

    }
}
