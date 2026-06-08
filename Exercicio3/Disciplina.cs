namespace AtividadeListaSimplesmente;

public class Disciplina
{
    public string nome;
    public int periodo;
    public int cargaHoraria;
    public string professorResponsavel;

    public Disciplina(string nome, int periodo, int cargaHoraria, string professorResponsavel)
    {
        this.nome = nome;
        this.periodo = periodo;
        this.cargaHoraria = cargaHoraria;
        this.professorResponsavel = professorResponsavel;
    }
}