using CadastroAlunos.Models;
using CadastroAlunos.Services;

class Program
{
    static void Main(string[] args)
    {
        AlunoService service = new AlunoService();
        int opcao;
        do
        {
            Console.WriteLine("=== SISTEMA DE CADASTRO DE ALUNOS ===");
            Console.WriteLine("1. Cadastrar aluno");
            Console.WriteLine("2. Listar alunos");
            Console.WriteLine("3. Buscar por nome");
            Console.WriteLine("4. Remover aluno");
            Console.WriteLine("0. Sair");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Informe o Nome do aluno:");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe o Email do aluno:");
                string email = Console.ReadLine();
                Console.WriteLine("Informe o Curso do aluno:");
                string curso = Console.ReadLine();
                Aluno aluno = new Aluno(nome,email,curso);
                service.Cadastrar(aluno);
                break;

                case 2:
                service.ListarTodos();
                break;

                case 3:
                Console.WriteLine("Informe o nome do aluno:");
                nome = Console.ReadLine();
                service.BuscarPorNome(nome);
                break;

                case 4:
                Console.WriteLine("Informe o id do Aluno:");
                int id = int.Parse(Console.ReadLine());
                service.Remover(id);
                break;

                case 0:
                Console.WriteLine("Saindo...");
                break;

                default:
                Console.WriteLine("Número inválido!");
                break;

            }

        }while (opcao != 0);
    }
}