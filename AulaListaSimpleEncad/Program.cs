using AtividadeListaSimplesmente;

Lista lista = new Lista();

int op;

do
{
    Console.WriteLine("\n1 - Inserir Inicio");
    Console.WriteLine("2 - Inserir Fim");
    Console.WriteLine("3 - Remover Inicio");
    Console.WriteLine("4 - Remover Fim");
    Console.WriteLine("5 - Buscar");
    Console.WriteLine("6 - Mostrar");
    Console.WriteLine("0 - Sair");

    op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.Write("Valor: ");
            lista.inserirInicio(Convert.ToInt32(Console.ReadLine()));
            break;

        case 2:
            Console.Write("Valor: ");
            lista.inserirFim(Convert.ToInt32(Console.ReadLine()));
            break;

        case 3:
            lista.removerInicio();
            break;

        case 4:
            lista.removerFim();
            break;

        case 5:
            Console.Write("Valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (lista.buscar(valor))
                Console.WriteLine("Encontrado!");
            else
                Console.WriteLine("Nao encontrado!");
            break;

        case 6:
            lista.percurso();
            break;
    }

} while (op != 0);