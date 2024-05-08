namespace ConsoleApplication1.SistemaLoja
{
    public abstract class Funcionario {
        private string nome;
        private string cpf;
        private double salario;

        public abstract string retornarCargo(string cargoPesquisa);
        public abstract double retornarSalario(int horasTrabalhadas, string cargo);
    }
}