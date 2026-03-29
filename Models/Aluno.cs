public class Aluno
{
    private int id;
    private string nome;
    private string email;
    private string curso;

    public int Id
    {
        get{return this.id;}
        set{this.id = value;}
    }
    public string Nome
    {
        get{return this.nome;}
        set{this.nome = value;}
    }
    public string Email
    {
        get{return this.email;}
        set{this.email = value;}
    }
    public string Curso
    {
        get{return this.curso;}
        set{this.curso = value;}
    }
    public Aluno(string nome, string email, string curso)
    {
        this.nome = nome;
        this.email = email;
        this.curso = curso;
    }
    public void ExibirInfo()
    {
        Console.WriteLine($"ID: {this.Id} | Nome: {this.Nome} | Email: {this.Email} | Curso: {this.Curso}");
    }
}