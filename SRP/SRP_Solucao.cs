//    Single Responsibility Principle (SRP)
//    Uma classe deve ter um único motivo para mudar, ou seja, ela deve ter apenas uma responsabilidade  

namespace DESAFIO_SOLID.SRP
{
    internal class SRP_Solucao
    {
        public class Funcionario
        {
            public string? Nome { get; set; }
            public decimal SalarioBase { get; set; }
        }

        // O correto seria igual eu fiz voce separaria as responsabilidades em classe onde cada classe faz uma coisa

        public class CalculadoraSalario
        {
            public decimal CalcularSalario(Funcionario f)
            {
                return f.SalarioBase * 1.1m;
            }
        }

        public class RepositorioFuncionario
        {
            public void Salvar(Funcionario f)
            {

            }
        }

        public class GeradorRelatorio
        {
            public void Gerar(Funcionario f)
            {

            }
        }
    }
}
