class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    
    //se trata de uma propriedade que só é possível fazer a leitura - Equivalente a propriedade só ter o GET
    public string Descricao =>
        $"A música {Nome} pertence à banda/artista {Artista}";

    public void exibirDados()
    {
        Console.WriteLine($"Nome do música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} Segundos");
        if (Disponivel)
        {
            Console.WriteLine($"A música { Nome } está disponível no seu plano, faça um bom proveito");
        }
        else
        {
            Console.WriteLine($"Assine o plano Premium para ouvir {Nome}");
        }

        Console.WriteLine(Descricao);
    }
}