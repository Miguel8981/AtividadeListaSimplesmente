namespace AtividadeListaSimplesmente;

public class Lista
{
    public No inicio;
    public No fim;

    public Lista()
    {
        inicio = null;
        fim = null;
    }

    public bool estaVazia()
    {
        return inicio == null;
    }

    public void inserirInicio(Funcionario funcionario)
    {
        No novo = new No(funcionario);

        if (estaVazia())
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            novo.prox = inicio;
            inicio = novo;
        }
    }

    public void inserirFim(Funcionario funcionario)
    {
        No novo = new No(funcionario);

        if (estaVazia())
        {
            inicio = novo;
            fim = novo;
        }
        else
        {
            fim.prox = novo;
            fim = novo;
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

    public bool buscar(string nome)
    {
        No aux = inicio;

        while (aux != null)
        {
            if (aux.funcionario.nome == nome)
                return true;

            aux = aux.prox;
        }

        return false;
    }

    public void percurso()
    {
        No aux = inicio;

        while (aux != null)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Nome: " + aux.funcionario.nome);
            Console.WriteLine("Idade: " + aux.funcionario.idade);
            Console.WriteLine("Telefone: " + aux.funcionario.telefone);
            Console.WriteLine("Salario: " + aux.funcionario.salario);

            aux = aux.prox;
        }
    }
}