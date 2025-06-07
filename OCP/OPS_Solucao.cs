//     Open/Closed Principle (OCP)
//     As classes devem ser abertas para extensão, mas fechadas para modificação.

namespace DESAFIO_SOLID.OCP
{
    internal class OPS_Solucao
    {
        // O correto seria Criar uma classe abstrata somente com as propriedades que todo funcionario usa 
        public abstract class Funcionario
        {
            public string Nome { get; set; }
            public decimal SalarioBase { get; set; }

            //Aqui a gente obriga as subclasses a implementar este metodo
            public abstract decimal CalcularSalario();
        }

        // A calculadora agora ficaria assim somente esperando o tipo do funcionario 
        public class CalculadoraSalario
        {
            public decimal Calcular(Funcionario f)
            {
                return f.CalcularSalario();
            }
        }

        // E ai você teria uma subclasse para cada tipo que herda de funcionario
        public class Desenvolvedor : Funcionario
        {
            public override decimal CalcularSalario() => SalarioBase * 1.2m;
        }

        public class Gerente : Funcionario
        {
            public override decimal CalcularSalario() => SalarioBase * 1.5m;
        }
    }
}
