namespace AtividadeListaSimplesmente;
public class Lista{ //SE - Simplesmente Encadeada

    //Atributos
    public No? inicio; //cabeça
    public No? fim; //cauda

    //Construtor
    public Lista(){
        this.inicio = null;
        this.fim = null;
    }

    public Boolean estaVazia(){
        if(inicio == null && fim == null){
            return(true); //Lista está vazia
        }
        return(false);
    }

    public void inserirInicio(int Valor){
        No novoNo = new No(Valor);

        if (this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void inserirFim(int Valor){
        No novoNo = new No(Valor);

        if(this.estaVazia()){
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else{
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public Boolean buscar(int chave){
        
        No noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            if(noAtual.valor == chave) return(true); //Encontrou o elemento
            noAtual = noAtual.prox;
        }
        return(false); //Não encontrou o elemento!
    }


    public void percurso(){
        
        No noAtual = this.inicio; //Copia do inicio

        while(noAtual != null){
            Console.WriteLine(noAtual.valor + "-> ");
            noAtual = noAtual.prox;
        }
    }
    public void removerInicio()
    {
    if (estaVazia())
    {
        Console.WriteLine("Lista vazia!");
        return;
    }

    inicio = inicio.prox;

    if (inicio == null)
        fim = null;
     }
   public void removerFim()
    {
    if (estaVazia())
    {
        Console.WriteLine("Lista vazia!");
        return;
    }

    if (inicio == fim)
    {
        inicio = null;
        fim = null;
        return;
    }

    No aux = inicio;

    while (aux.prox != fim)
    {
        aux = aux.prox;
    }

    aux.prox = null;
    fim = aux;
    }
}