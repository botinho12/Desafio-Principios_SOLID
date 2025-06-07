//     Open/Closed Principle (OCP)
//     As classes devem ser abertas para extensão, mas fechadas para modificação.

namespace DESAFIO_SOLID.OCP
{
    internal class OCP_Violacao
    {
        public class Funcionario
        {
            public string? Nome { get; set; }
            public string? Cargo { get; set; }
            public decimal SalarioBase { get; set; }
        }

        // Aqui toda vez que a gente for cadastrar um novo cargo teremos que atualizar a classe CalculadoraSalario oque viola o - Open/Closed Principle (OCP)

        public class CalculadoraSalario
        {
            public decimal Calcular(Funcionario f)
            {
                if (f.Cargo == "Desenvolvedor")
                    return f.SalarioBase * 1.2m;
                else if (f.Cargo == "Gerente")
                    return f.SalarioBase * 1.5m;
                else
                    return f.SalarioBase;
            }
        }

    }
}
