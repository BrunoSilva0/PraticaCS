using System.Collections.Generic;

namespace ConsoleApplication1.SistemaLoja
{
    public class Produto {
        private string nome;
        private string marca;
        private double preco;
        private int quantidade;

        public Produto(string nome, string marca, double preco) {
            this.nome = nome;
            this.marca = marca;
            this.preco = preco;
        }

        public List<Produto> retornarPorNome(string nome, int codigoLoja) {
            return null;
        }
        public List<Produto> retornarPorMarca(string marca, int codigoLoja){
            return null;
        }
        public List<Produto> retornarPorPreco(double preco, int codigoLoja){
            return null;
        }
        public int retornarQuantidade(Produto produto, int codigoLoja) {
            return 0;
        }

        
        // vazios por agora pois vou adicionar os métodos depois que o resto estiver pronto
    }
}