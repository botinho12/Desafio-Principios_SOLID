//     Liskov Substitution Principle (LSP)
//     Uma subclasse deve poder substituir a classe base sem alterar o funcionamento correto do programa.

namespace DESAFIO_SOLID.LSP
{
    internal class LSP_Violacao
    {
        public class Retangulo
        {
            public virtual int Largura { get; set; }
            public virtual int Altura { get; set; }

            public int CalcularArea() => Largura * Altura;
        }

        // Aqui a subclasse quadrado herda da classe Retangulo porem a classe retangula tem um metodo CalcularArea ja definido,
        // mas sabemos que o jeito de calcular a area do quadrado e do retangulo sao diferentes e isso viola - Liskov Substitution Principle (LSP)
        public class Quadrado : Retangulo
        {
            public override int Largura
            {
                set
                {
                    base.Largura = value;
                    base.Altura = value; // força o quadrado a manter os lados iguais
                }
            }

            public override int Altura
            {
                set
                {
                    base.Largura = value;
                    base.Altura = value;
                }
            }
        }
    }
}
