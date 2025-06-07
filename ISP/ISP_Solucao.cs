//      Interface Segregation Principle (ISP)
//      Nenhuma classe deve ser forçada a implementar métodos que não utiliza.

namespace DESAFIO_SOLID.ISP
{
    internal class ISP_Solucao
    {
        //Aqui ja temos uma inteface para cada Serviço
        public interface ITrabalhador
        {
            void Trabalhar();
            void TirarFerias();
        }

        public interface IRelatorio
        {
            void FazerRelatorio();
        }

        public interface IAtendimentoCliente
        {
            void FazerAtendimentoCliente();
        }

        // E o Desenvolvedor so herda aquilo que ele irá ultilizar 
        public class Desenvolvedor : ITrabalhador, IRelatorio
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
        }

        //Aqui tambem o Atendente herda somente das interfaces que ele precisa sem ficar com metodos desnecessarios

        public class Atendente : ITrabalhador, IAtendimentoCliente
        {
            public void Trabalhar()
            {
                
            }

            public void TirarFerias()
            {
                
            }

            public void FazerAtendimentoCliente()
            {
               
            }
        }

    }
}
