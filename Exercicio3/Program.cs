using AtividadeListaSimplesmente;

Lista lista = new Lista();

int op;

do
{
    Console.WriteLine("\n1 - Inserir Disciplina");
    Console.WriteLine("2 - Buscar Disciplina");
    Console.WriteLine("3 - Remover Disciplina");
    Console.WriteLine("4 - Mostrar Disciplinas");
    Console.WriteLine("0 - Sair");

    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Periodo: ");
            int periodo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Carga Horaria: ");
            int carga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Professor: ");
            string professor = Console.ReadLine();

            Disciplina d = new Disciplina(
                nome,
                periodo,
                carga,
                professor
            );

            lista.inserirOrdenado(d);
            break;

        case 2:

            Console.Write("Nome da disciplina: ");
            nome = Console.ReadLine();

            if (lista.buscar(nome))
                Console.WriteLine("Disciplina encontrada!");
            else
                Console.WriteLine("Disciplina nao encontrada!");

            break;

        case 3:

            Console.Write("Nome da disciplina: ");
            nome = Console.ReadLine();

            lista.remover(nome);
            break;

        case 4:

            lista.percurso();
            break;
    }

} while (op != 0);