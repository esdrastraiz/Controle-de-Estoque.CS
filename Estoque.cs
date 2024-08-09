
public class Estoque
{


    Jogo[] jogos = new Jogo[0];


    public void Adicionar(Jogo jogo)
    {
        Jogo[] novoVetor = new Jogo[jogos.Length + 1];
        for (int pos = 0; pos < jogos.Length; pos++)
        {
            Jogo item = Livros[pos];
            novoVetor[pos] = item;
        }
        novoVetor[novoVetor.Length - 1] = jogo;

        jogos = novoVetor;


    }
    
    public void Listar()
    {
        
        int cont = 1;
        foreach (Jogo item in jogos)
        {
            Console.WriteLine($"{cont}. {item.Nome} ({item.Preco}) - {item.Estoque} no estoque");
            cont++;
        }


    }
    
    public void Entrada(int pos, int qtd)
    {
        Jogo jogo = jogos[pos - 1];
        jogo.Estoque += qtd;
    }

    public void Saida(int pos, int qtd)
    {
        Jogo jogo = jogos[pos - 1];
        jogo.Estoque -= qtd;
    }

    public void Remover(int pos)
    {
        Jogo jogo = jogos[pos - 1];
        jogo.Estoque - qtd;
    }




}