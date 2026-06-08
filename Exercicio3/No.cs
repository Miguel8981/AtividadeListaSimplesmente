namespace AtividadeListaSimplesmente;

public class No
{
    public Disciplina disciplina;
    public No prox;

    public No(Disciplina disciplina)
    {
        this.disciplina = disciplina;
        this.prox = null;
    }
}