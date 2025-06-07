//    Single Responsibility Principle (SRP)
//    Uma classe deve ter um único motivo para mudar, ou seja, ela deve ter apenas uma responsabilidade.

namespace DESAFIO_SOLID.SRP
{
    internal class SRP_Violacao
    {
        public class Funcionario
        {
            public string? Nome { get; set; }
            public decimal SalarioBase { get; set; }

            // Aqui como podemos ver a classe funcionario tem mais de uma resposabilidade oque viola o principio Single Responsibility Principle (SRP) 
            public decimal CalcularSalario()
            {
                
                return SalarioBase * 1.1m;
            }

            public void SalvarNoBanco()
            {
                
            }

            public void GerarRelatorio()
            {
                
            }
        }

    }
}
