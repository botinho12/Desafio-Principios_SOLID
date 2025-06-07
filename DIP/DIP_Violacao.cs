//     Dependency Inversion Principle (DIP)
//     Módulos de alto nível não devem depender de módulos de baixo nível, ambos devem depender de abstrações.

namespace DESAFIO_SOLID.DIP
{
    internal class DIP_Violacao
    {
        //Aqui a gente tem a implementação concreta BancoDeDados 
        public class BancoDeDados
        {
            public void Salvar(string dados)
            {
                Console.WriteLine("Salvando dados no banco...");
            }
        }

        // E aqui o ClienteService depende diretamente da implementação do BancoDeDados oque viola o -   Dependency Inversion Principle (DIP)
        public class ClienteService
        {
            private BancoDeDados banco = new BancoDeDados();

            public void SalvarCliente(string nome)
            {
                banco.Salvar(nome);
            }
        }

    }
}
