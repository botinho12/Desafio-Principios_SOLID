//     Dependency Inversion Principle (DIP)
//     Módulos de alto nível não devem depender de módulos de baixo nível, ambos devem depender de abstrações.

namespace DESAFIO_SOLID.DIP
{
    internal class DIP_Solucao
    {
        // Interface que define o contrato para salvar dados
        public interface IRepositorio
        {
            void Salvar(string dados);
        }

        // Implementação concreta do repositório (Banco de Dados)
        public class BancoDeDados : IRepositorio
        {
            public void Salvar(string dados)
            {
                Console.WriteLine("Salvando dados no banco...");
            }
        }

        // Agora o ClienteService depende inteiramente da interface (IRepositorio) e nao da implementação concreta
        public class ClienteService
        {
            private readonly IRepositorio repositorio;

            // A dependência é injetada via construtor
            public ClienteService(IRepositorio repositorio)
            {
                this.repositorio = repositorio;
            }

            public void SalvarCliente(string nome)
            {
                repositorio.Salvar(nome);
            }
        }

        //Assim voce fica livre para mudar o repositorio sem precisar mudar o Service

    }
}

