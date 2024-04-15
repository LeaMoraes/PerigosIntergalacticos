using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using static PerigosIntergalacticos.Modelos.Controle;

namespace PerigosIntergalacticos.Modelos
{

    //Criar isso só foi possivel com a biblioteca Newtonsoft.Json

    #region Variaveis Procurados.json
    public class Procurado
    {
        public string RA = "";
        public string Nome = "";
        public string Sobrenome = "";
        public string Especie = "";
        public string Idade = "";
        public string Altura = "";
        public string Peso = "";
        public string NivelProcurado = "";
        public string Icone = "";
    }
    #endregion

    #region Variaveis Localização.json
    public class Localizacao
    {
        //Variaveis que estão no arquivo JSON
        public string RA = "";
        public string ID_Galaxia = "";
        public DetalhesLocalizacao Local_Nascimento;
        public DetalhesLocalizacao Ultima_Localização;
    }

    public class DetalhesLocalizacao
    {
        //Coleção para grupo das mesmas variaveis
        //No caso eu estou usando as mesmas variaveis para Local_Nascimento e Ultima_Localização
        //É meio confuso, mas eu consegui entender mais ou menos
        public string Galaxia { get; set; }
        public string Planeta { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Data { get; set; }
    }
    #endregion

    public class LeituraJSON
    {

        public string mensagem = "";
        public string jsonString = "";

        public void VerificarArquivo(string CaminhoArquivoJson)
        {
            //Este metodo vai verificar se existe o arquivo Json na pasta
            //Se tiver, ele segue o procedimento
            //Se não tiver, ferrou pra mim quando o professor Fernando for testar
            if (File.Exists(CaminhoArquivoJson))
            {
                jsonString = File.ReadAllText(CaminhoArquivoJson); 
            }
            else 
            { 
                mensagem = "Arquivo não encontrado!!"; 
            }
            
        }

        public Procurado DeserializarJsonProcurado(string RaDesejado)
        {
            //Aqui consegue ser um pouco confuso tambem, vou tentar explicar
            //Eu estou criando uma lista chamado procurados, nessa lista vai ter o arquivo Json
            //Eu estou fazendo uma Disserialização (Não sei a palavra), basicamente estou tirando o conteudo de um Json
            //Este Return, ele vai retornar o Procurado que tenha o mesmo RA
            //A conversa é meio que "Vai descendo as variaveis, caso tenha um valor RA igual o que eu tenho, retornar"
            //A mesma coisa vale para o metoto DeserializarJsonLocalizacao, então não vou repetir comentario
            List<Procurado> procurados = JsonConvert.DeserializeObject<List<Procurado>>(jsonString);
            return procurados.Find(p => p.RA == RaDesejado);

        }

        public Localizacao DeserializarJsonLocalizacao(string RaDesejado)
        {
            List<Localizacao> localizacao = JsonConvert.DeserializeObject<List<Localizacao>>(jsonString);
            return localizacao.Find(l => l.RA == RaDesejado);
        }


        public void AcharProcurado(string CaminhoArquivoJson, string RaDesejado)
        {
            //Aqui ja é a ação mesmo, eu estou verificando se existe o arquivo Json
            //Quando não tem, o metodo vai retornar uma mensagem, se não retornar a mensagem, quer dizer que existe
            //Essa parte vai ser meio confusa
            //Eu estou criando um objeto "procurado" e estou colocando nele todas as variaveis do meu Json
            //Eu aproveito esse intermedio e eu mando jogar na classe Controle
            //Estou fazendo isso pois o conteudo que vai ficar na classe Controle, não vai sumir
            //Explicação disso vai ficar na classe controle
            //Lembrando que essa mesma ação vai se repetir no metodo AcharLocalizacao, então não sera nescessario eu repetir este texto
            VerificarArquivo(CaminhoArquivoJson);
            if (mensagem.Equals(""))
            {
                Procurado procurado = DeserializarJsonProcurado(RaDesejado);
                if (procurado != null)
                {
                    mensagem = "Procurado encontrado com sucesso";
                    Controle.RA = RaDesejado;
                    Controle.Nome = procurado.Nome;
                    Controle.Sobrenome = procurado.Sobrenome;
                    Controle.Especie = procurado.Especie;
                    Controle.Idade = procurado.Idade;
                    Controle.Altura = procurado.Altura;
                    Controle.Peso = procurado.Peso;
                    Controle.NivelProcurado = procurado.NivelProcurado;
                    Controle.Icone = procurado.Icone;
                }
                else
                {
                    mensagem = "Procurado não encontrado";
                }
            }


        }

        public void AcharLocalizacao(string CaminhoArquivoJson, string RaDesejado)
        {
            VerificarArquivo(CaminhoArquivoJson);
            if (mensagem.Equals(""))
            {
                Localizacao localizacao = DeserializarJsonLocalizacao(RaDesejado);
                if (localizacao != null)
                {
                    mensagem = "Localização encontrada com sucesso";
                    Controle.Ra = RaDesejado;
                    Controle.ID_Galaxia = localizacao.ID_Galaxia;
                    Controle.Local_Nascimento_Galaxia = localizacao.Local_Nascimento.Galaxia;
                    Controle.Local_Nascimento_Planeta = localizacao.Local_Nascimento.Planeta;
                    Controle.Local_Nascimento_Pais = localizacao.Local_Nascimento.Pais;
                    Controle.Local_Nascimento_Estado = localizacao.Local_Nascimento.Estado;
                    Controle.Local_Nascimento_Cidade = localizacao.Local_Nascimento.Cidade;
                    Controle.Local_Nascimento_Data = localizacao.Local_Nascimento.Data;
                    Controle.Ultima_Localização_Galaxia = localizacao.Ultima_Localização.Galaxia;
                    Controle.Ultima_Localização_Planeta = localizacao.Ultima_Localização.Planeta;
                    Controle.Ultima_Localização_Pais = localizacao.Ultima_Localização.Pais;
                    Controle.Ultima_Localização_Estado = localizacao.Ultima_Localização.Estado;
                    Controle.Ultima_Localização_Cidade = localizacao.Ultima_Localização.Cidade;
                    Controle.Ultima_Localização_Data = localizacao.Ultima_Localização.Data;
                }
                else
                {
                    mensagem = "Localização não encontrada";
                }
            }


        }

    }
}
