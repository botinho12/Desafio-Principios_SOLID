//     Liskov Substitution Principle (LSP)
//     Uma subclasse deve poder substituir a classe base sem alterar o funcionamento correto do programa.

namespace DESAFIO_SOLID.LSP
{
    internal class LSP_Solucao
    {
        // Aqui a gente cria uma classe abstrata para lidar somente com o calculo da area 
        public abstract class Forma
        {
            public abstract int CalcularArea();
        }

        // A classe (RETANGULO) agora herda da classe (FORMA) oque obriga ela a implementar o metodo calcularArea porem pode adptar ele para a maneira correta de calcular a area do RETANGULO

        public class Retangulo : Forma
        {
            public int Largura { get; set; }
            public int Altura { get; set; }

            public override int CalcularArea() => Largura * Altura;
        }

        // Aqui a mesma coisa  classe (QUADRADO) agora herda da classe (FORMA) oque obriga ela a implementar o metodo calcularArea porem pode adptar ele para a maneira correta de calcular a area do QUADRADO

        public class Quadrado : Forma
        {
            public int Lado { get; set; }

            public override int CalcularArea() => Lado * Lado;
        }
    }
}
