# Perigos Intergalacticos

Perigos Intergalacticos é um trabalho que meu professor Fernando pediu até o dia 16/04/2024, ele pediu uma aplicação simples que tivesse o RA dos alunos, e conforme a gente fosse entregando, o professor pediria uma atualização do sistema.

Perigos Intergalacticos é uma lista de criminosos de varias galaxias, quando selecionado um RA (Registro Alienigina) o sistema vai mostrar as informações basicas e junto vai mostrar o nivel de perigo do criminoso, caso o usuario queira ver mais informações, do criminoso, ele pode selecionar o botão "Mais Informações", onde vai apresentar não só os dados pessoais, mas tambem as informações de localização.

##
O projeto Perigos Intergalacticos foi feito pensando em aprender banco de dados e a sequencia de conversa entre o sistema e o usuario.

Para que o projeto funcionasse, foi preciso aprender algumas coisas que ainda não foi apresentado em aula, ou que não sera apresentado.
1. Para o meu sistema ler os arquivos Json, foi usado uma biblioteca chamada "Newtonsoft.json", esta biblioteca disponibiliza a função Serialize e Deserialize, basicamente "Guardar Informação" e "Puxar Informação".
2. Quando a gente puxa as informações do Json, ele puxa de todos os criminosos, para que o sistema puxasse o crimonoso certo, foi usado as listas (List), eu ainda não entendi muito bem como funciona o metodo List funciona, mas no meu sistema ele foi usado da seguinte maneira: Caso Ra do procurado não bata com o Ra Desejado, pular para o proximo RA (Pelo o que meu professor Reverdan disse, a List vai ser o proximo conteudo da aula que ele vai passar, talvez passando dessa aula eu ja consiga entender um pouco mais). 
3. Ja com todas as informações do procurado em mãos, o sistema precisa guardar em algum lugar, para quando uma janela for puxar esses dados, não precisar executar toda essa função novamente, nisso foi usado a modificação chamada Static, quando uma informação é guardada numa variavel estatica, a informação vai permanecer até acontecer algum evento de alterar, ou até o sistema fechar 

##
Esta atividade vai ser atualizada conforme eu for recebendo mais atividade do professor Fernando, e para isso eu ja tenho planejado algumas atualizações, como:
1. Lista de crimes de cada procurado
2. Enviar Autoridades
3. Historico de captura
4. Recompensas



