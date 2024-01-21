using System.Runtime.InteropServices;

class GerenciadorEstoque
{

    // Vetor irá começar com 0 posições
    Produtos[] produtos = new Produtos[0];

    public void Adicionar(Produtos novoProduto)
    {
        // Vai criar um novo vetor com 1 posição a mais do meu vetor inicial
        Produtos[] novoVetor = new Produtos[produtos.Length + 1];

        // Vai passar por todo o vetor e copiar os valores pra o novo
        for (int pos = 0; pos < produtos.Length; pos++)
            novoVetor[pos] = produtos[pos];

        // Posição -1 é a ultima, então, o novoProduto sera adicionado na nova posição, a ultima.
        novoVetor[novoVetor.Length - 1] = novoProduto;

        // o vetor produtos vai receber os valores do novoVetor.
        produtos = novoVetor;

    }

    public void Listar()
    {
        for (int pos = 0; pos < produtos.Length; pos++)
        {
            Produtos item = produtos[pos];
            // 1. Mac Mini M2 - 256gb - 8gb - (R$ 5000) - 0 no estoque!
            Console.WriteLine($"[{pos + 1}] {item.Nome} - {item.Armazenamento}gb SSD - {item.MemoriaRam}gb RAM - (R${item.Preco}) - {item.Quantidade} no estoque!");
        }
    }

    public void Remover(int posRemover)
    {
        Produtos[] novoVetor = new Produtos[produtos.Length - 1];

        for (int pos = 0; pos < novoVetor.Length; pos++)
        {
            if (pos >= posRemover)
                novoVetor[pos] = produtos[pos + 1];
            else
                novoVetor[pos] = produtos[pos];
        }
        produtos = novoVetor;

    }

    public void Entrada(int posicao, int qtd)
    {
        produtos[posicao].Quantidade += qtd;
    }

    public void Saida(int posicao, int qtd)
    {
        produtos[posicao].Quantidade -= qtd;
    }
}