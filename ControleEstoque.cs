namespace Controle_de_Estoque_C_;

class Program
{
    static void Main(string[] args)
    {
     
       Estoque estoque = new Estoque();


       int menu = 0;
       do
       {
            Console.WriteLine("\n[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada de Estoque");
            Console.WriteLine("[5] Saída de Estoque");
            Console.WriteLine("[0] Sair");
            menu = Convert.ToInt32(Console.ReadLine());

            if (menu == 1)
            {
                Jogo novoJogo = new Jogo();

                Console.WriteLine("Informe o nome do jogo: ");
                novoJogo.Nome = Console.ReadLine();

                Console.WriteLine("Preço: ");
                novoJogo.Preco = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a publicadora: ");
                novoJogo.Publisher = Console.ReadLine();

                Console.WriteLine("Ano do jogo: ");
                novoJogo.Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe plataforma: ");
                novoJogo.Plataform = Console.ReadLine();

                estoque.Adicionar(novoJogo);


            }
            else if (menu == 2)
            {
                Console.WriteLine("\nItens no Estoque:");
                estoque.Listar();
            }
            else if (menu == 3)
            {
                estoque.Remover();
            }
            else if (menu == 4)
            {
                estoque.Entrada();
            }
            else if (menu == 5)
            {
                estoque.Saida();
            }
       } while (menu != 0);




    }
    
    
    
        
    
}
