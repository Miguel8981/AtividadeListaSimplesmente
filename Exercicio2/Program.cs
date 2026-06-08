using AtividadeListaSimplesmente;

Lista lista = new Lista();

int op;

do
{
    Console.WriteLine("\n1 - Inserir Inicio");
    Console.WriteLine("2 - Inserir Fim");
    Console.WriteLine("3 - Buscar");
    Console.WriteLine("4 - Remover Inicio");
    Console.WriteLine("5 - Remover Fim");
    Console.WriteLine("6 - Mostrar Funcionarios");
    Console.WriteLine("0 - Sair");

    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Funcionario f = new Funcionario(nome, idade, telefone, salario);

            lista.inserirInicio(f);
            break;
        }

        case 2:
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();

            Console.Write("Salario: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Funcionario f = new Funcionario(nome, idade, telefone, salario);

            lista.inserirFim(f);
            break;
        }

        case 3:
        {
            Console.Write("Nome para buscar: ");
            string nome = Console.ReadLine();

            if (lista.buscar(nome))
                Console.WriteLine("Funcionario encontrado!");
            else
                Console.WriteLine("Funcionario nao encontrado!");

            break;
        }

        case 4:
            lista.removerInicio();
            break;

        case 5:
            lista.removerFim();
            break;

        case 6:
            lista.percurso();
            break;
    }

} while (op != 0);