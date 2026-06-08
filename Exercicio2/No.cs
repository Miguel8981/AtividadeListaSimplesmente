namespace AtividadeListaSimplesmente;

public class No
{
    public Funcionario funcionario;
    public No prox;

    public No(Funcionario funcionario)
    {
        this.funcionario = funcionario;
        this.prox = null;
    }
}