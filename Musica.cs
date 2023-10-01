class Musica
{
    public Musica(Banda artista, string? nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string? Nome { get; }
    public Banda? Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    /*Quando temos somente o "get", podemos usar uma função lambda!
    Ou seja, seria o mesmo que escrever:
    
    public string DescricaoResumida 
    {
        get
        {
            return $"A música {Nome} Pertence à Banda {Artista}";
        }
    }
    */

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.Write($"Disponível: ");

        if (Disponivel)
        {
            Console.WriteLine("sim");
        }
        else
        {
            Console.Write("Adquira o plano Plus para ouvir!");
        }
    }
}