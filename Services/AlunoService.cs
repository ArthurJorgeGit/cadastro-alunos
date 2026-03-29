using CadastroAlunos.Models;
namespace CadastroAlunos.Services
{

    public class AlunoService
    {
        private List<Aluno> alunos = new List<Aluno>();
        private int proximoId = 1;

        public List<Aluno> Alunos
        {
            get { return this.Alunos; }
            set { this.Alunos = value; }
        }
        public int ProximoId
        {
            get { return this.proximoId; }
            set { this.proximoId = value; }
        }
       
        public void Cadastrar(Aluno aluno)
        {
            aluno.Id = proximoId;
            alunos.Add(aluno);
            proximoId++;
        }
        public void ListarTodos()
        {
            if (alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado");
            }
            foreach (Aluno i in alunos)
            {
                i.ExibirInfo();
            }
        }
        public void BuscarPorNome(string nome)
        {
            bool encontrou = false;
            foreach (Aluno i in alunos)
            {
                if (i.Nome.Contains(nome))
                {
                    encontrou = true;
                    i.ExibirInfo();
                }
            }
            if (encontrou == false)
            {
                Console.WriteLine("Nenhum aluno encontrado.");
            }
        }
        public void Remover(int id)
        {
            bool encontrou = false;
            foreach (Aluno i in alunos)
            {
                if (i.Id == id)
                {
                    alunos.Remove(i);
                    encontrou = true;
                    break;
                }
            }
            if (encontrou == false)
            {
                Console.WriteLine("Aluno não encontrado.");
            }
        }
    }
}