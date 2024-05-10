namespace ConsoleApplication1.SistemaLoja
{
    public class Funcionario 
    {
        private string nome;
        private string cargo;
        private string cpf;
        private double salario;

        protected Funcionario(string nome, string cpf, double salario, string cargo)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
            this.cargo = cargo;
        }
        
        
    }
}