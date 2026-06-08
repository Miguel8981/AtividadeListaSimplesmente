namespace AtividadeListaSimplesmente;

public class Lista
{
    public No inicio;

    public Lista()
    {
        inicio = null;
    }

    public bool estaVazia()
    {
        return inicio == null;
    }

    public void inserirOrdenado(Disciplina disciplina)
    {
        No novo = new No(disciplina);

        if (estaVazia() || disciplina.nome.CompareTo(inicio.disciplina.nome) < 0)
        {
            novo.prox = inicio;
            inicio = novo;
            return;
        }

        No atual = inicio;

        while (atual.prox != null &&
               atual.prox.disciplina.nome.CompareTo(disciplina.nome) < 0)
        {
            atual = atual.prox;
        }

        novo.prox = atual.prox;
        atual.prox = novo;
    }

    public bool buscar(string nome)
    {
        No atual = inicio;

        while (atual != null)
        {
            if (atual.disciplina.nome == nome)
                return true;

            atual = atual.prox;
        }

        return false;
    }

    public void remover(string nome)
    {
        if (estaVazia())
        {
            Console.WriteLine("Lista vazia!");
            return;
        }

        if (inicio.disciplina.nome == nome)
        {
            inicio = inicio.prox;
            return;
        }

        No atual = inicio;

        while (atual.prox != null &&
               atual.prox.disciplina.nome != nome)
        {
            atual = atual.prox;
        }

        if (atual.prox != null)
        {
            atual.prox = atual.prox.prox;
        }
        else
        {
            Console.WriteLine("Disciplina nao encontrada!");
        }
    }

    public void percurso()
    {
        No atual = inicio;

        while (atual != null)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Nome: " + atual.disciplina.nome);
            Console.WriteLine("Periodo: " + atual.disciplina.periodo);
            Console.WriteLine("Carga Horaria: " + atual.disciplina.cargaHoraria);
            Console.WriteLine("Professor: " + atual.disciplina.professorResponsavel);

            atual = atual.prox;
        }
    }
}