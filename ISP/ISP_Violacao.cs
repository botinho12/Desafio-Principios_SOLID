//      Interface Segregation Principle (ISP)
//      Nenhuma classe deve ser forçada a implementar métodos que não utiliza.

namespace DESAFIO_SOLID.ISP
{
    internal class ISP_Violacao
    {
        //Aqui a nossa Interface IFuncionario ela tem varios metodos que um funcionario nao devia ter
        public interface IFuncionario
        {
            void Trabalhar();
            void TirarFerias();
            void FazerRelatorio();

            void FazerAtendimentoCliente();
        }

        // Aqui temos a classe Desenvolvedor que herda de IFuncionario porem IFuncionario tem metodos que o desenvolvedor nao vai ultilizar e isso viola o - Interface Segregation Principle (ISP)
        public class Desenvolvedor : IFuncionario
        {
            public void Trabalhar()
            {

            }

            public void TirarFerias()
            {

            }

            public void FazerRelatorio()
            {

            }

            // Desenvolvedor não faz atendimento ao cliente
            public void FazerAtendimentoCliente()
            {
                throw new NotImplementedException(); 
            }
        }

    }
}
