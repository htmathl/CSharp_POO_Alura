public class Aluno
{
    private int matricula;
    public int Matricula {
        get { return matricula; } 
        set { if (value > 0) matricula = value; }
    }
    public string Nome { get; set; }
    public string Email { get; set;  } 
    public bool Status { get; set; }
    public int TipoCurso { get; set; }
    public static void Main(string[] args)
    {
        Aluno aluno = new();
        aluno.Matricula = -1;
        Console.WriteLine(aluno.Matricula);
    }
}