namespace aula_03;

class Televisao
{   
    //o metódp construtor possui mesmo
    //nome da class. Ele não possui retorno (nem mesmo o void)
    //Este metódo é executado sempre que a classe é criada


    //Get: permite que seja executada a 
    //leitura do valor atuaç da propriedade
    //Set: permite que seja atribuído um 
    //valor para a propriedade
    
    //as propriedades e metódos possuem modificadores de acesso 
    //public: visiveis a todo projeto
    //internal: visiveis somente no namespace
    //protected: visiveis somente na classe e nas classes que herdam
    //private: visiveis somente na classe que foram criados

    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }
}