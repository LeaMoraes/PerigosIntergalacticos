using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerigosIntergalacticos.Modelos
{
    public class Controle
    {

        //O armazem das variaveis dos Json's ficarão aqui
        //O motivo de eu jogar eles aqui, é que a classe Controle, sera a classe de conversa com outras classes
        //E com outros Forms
        //Para isso eu consegui achar e aprender a usar o Static
        //Esse modificador faz com que uma mudança permaneça até eu fechar a aplicação
        //Então isso será otimo nesse projeto, ou até mesmo no PIM
        #region Procurados.json Variaveis
        public static string RA = "";
        public static string Nome = "";
        public static string Sobrenome = "";
        public static string Especie = "";
        public static string Idade = "";
        public static string Altura = "";
        public static string Peso = "";
        public static string NivelProcurado = "";
        public static string Icone = "";
        #endregion

        #region Localização.json Variaveis
        public static string Ra = "";
        public static string ID_Galaxia = "";
        public static string Local_Nascimento_Galaxia = "";
        public static string Local_Nascimento_Planeta = "";
        public static string Local_Nascimento_Pais = "";
        public static string Local_Nascimento_Estado = "";
        public static string Local_Nascimento_Cidade = "";
        public static string Local_Nascimento_Data = "";
        public static string Ultima_Localização_Galaxia = "";
        public static string Ultima_Localização_Planeta = "";
        public static string Ultima_Localização_Pais = "";
        public static string Ultima_Localização_Estado = "";
        public static string Ultima_Localização_Cidade = "";
        public static string Ultima_Localização_Data = "";
        #endregion

        public string RaDesejado = "";
        public string statusProcurado = "";
        public string statusLocalizacao = "";
        public string mensagem = "";
        public string json = "";

        public void ProcurarProcurado(string CaminhoArquivoJson, string RaDesejado)
        {
            LeituraJSON leiturajson = new LeituraJSON();
            leiturajson.AcharProcurado(CaminhoArquivoJson, RaDesejado);
            statusProcurado = leiturajson.mensagem;

        }

        public void ProcurarLocalizacao(string CaminhoArquivoJson, string RaDesejado)
        {
            LeituraJSON leiturajson = new LeituraJSON();
            leiturajson.AcharLocalizacao(CaminhoArquivoJson, RaDesejado);
            statusLocalizacao = leiturajson.mensagem;

        }

    }
}
