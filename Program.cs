Banda legiaoUrbana = new Banda("Legião Urbana");

Album asQuatroEstações = new Album("As Quatro Estações");

Musica musica1 = new Musica(legiaoUrbana, "Que País É Este")
{
    Duracao = 178,
    Disponivel = true,
};

Musica musica2 = new Musica(legiaoUrbana, "Faroeste Caboclo")
{
    Duracao = 546,
    Disponivel = false,
};

asQuatroEstações.AdicionarMusica(musica1);
asQuatroEstações.AdicionarMusica(musica2);


legiaoUrbana.AdicionarAlbum(asQuatroEstações);
legiaoUrbana.ExibirDiscografia();

musica1.ExibirFichaTecnica();