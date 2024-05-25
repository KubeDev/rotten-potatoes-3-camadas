using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Rotten_Potatoes.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    FilmeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titulo = table.Column<string>(type: "text", nullable: true),
                    Resumo = table.Column<string>(type: "text", nullable: true),
                    Duracao = table.Column<string>(type: "text", nullable: true),
                    Lancamento = table.Column<string>(type: "text", nullable: true),
                    Categoria = table.Column<string>(type: "text", nullable: true),
                    Elenco = table.Column<string>(type: "text", nullable: true),
                    Direcao = table.Column<string>(type: "text", nullable: true),
                    Slide = table.Column<string>(type: "text", nullable: true),
                    Thumb = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.FilmeId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    FilmeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Filmes_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "Filmes",
                        principalColumn: "FilmeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FilmeId",
                table: "Reviews",
                column: "FilmeId");


            migrationBuilder.InsertData(
table: "Filmes",
columns: new[] {
            "Titulo",
            "Resumo",
"Duracao",
"Lancamento",
"Categoria",
"Elenco",
"Direcao",
"Slide",
"Thumb"
},
values: new object[,]
{
  {
      "STAR WARS: O DESPERTAR DA FORÇA",
      "Décadas após a queda de Darth Vader e do Império, surge uma nova ameaça: a Primeira Ordem, uma organização sombria que busca minar o poder da República e que tem Kylo Ren (Adam Driver), o General Hux (Domhnall Gleeson) e o Líder Supremo Snoke (Andy Serkis) como principais expoentes. Eles conseguem capturar Poe Dameron (Oscar Isaac), um dos principais pilotos da Resistência, que antes de ser preso envia através do pequeno robô BB-8 o mapa de onde vive o mitológico Luke Skywalker (Mark Hamill). Ao fugir pelo deserto, BB-8 encontra a jovem Rey (Daisy Ridley), que vive sozinha catando destroços de naves antigas. Paralelamente, Poe recebe a ajuda de Finn (John Boyega), um stormtrooper que decide abandonar o posto repentinamente. Juntos, eles escapam do domínio da Primeira Ordem.",
      "2h 15 min",
      "Dezembro de 2015",
      "Aventura, Ação, Ficção científica",
      "Daisy Ridley, John Boyega, Adam Driver",
      "J.J. Abrams",
      "/imagensfilme/star_wars_07-slide.jpg",
      "/imagensfilme/star_wars_07-thumb.jpg"
    },
    {
      "SENHOR DOS ANÉIS - AS DUAS TORRES",
      "Após a captura de Merry (Dominic Monaghan) e Pippy (Billy Boyd) pelos orcs, a Sociedade do Anel é dissolvida. Enquanto que Frodo (Elijah Wood) e Sam (Sean Astin) seguem sua jornada rumo à Montanha da Perdição para destruir o Um Anel, Aragorn (Viggo Mortensen), Legolas (Orlando Bloom) e Gimli (John Rhys-Davies) partem para resgatar os hobbits sequestrados.",
      "2h 59 min",
      "Dezembro de 2002",
      "Fantasia, Aventura",
      "Elijah Wood, Sean Astin, Viggo Mortensen",
      "Peter Jackson",
      "/imagensfilme/BANNER-SENHORDOSANEIS.png",
      "/imagensfilme/THUMB-SENHORDOSANEIS.png"
    },
    {
      "STAR TREK",
      "James Tiberious Kirk (Chris Pine) é um jovem rebelde inconformado com a morte de seu pai. Certo dia, recebe convite para fazer parte da formação de novos cadetes para a Frota Estelar. Uma vez lá conhece Spock (Zachary Quinto), um vulcano que optou por deixar seu planeta porque é metade humano e discordava do preconceito. Durante o treinamento, e também na primeira missão, os dois vivenciam novas experiências provocadas por seus estilos diametralmente opostos. Assim, Spock, o cerebral, e Kirk, o passional, viverão uma grande aventura ao lado de outros tradicionais integrantes da tripulação da U.S.S. Enterprise, a mais avançada nave espacial da época.",
      "2h 08 min",
      "Maio de 2009",
      "Ação, Aventura, Ficção científica",
      "Chris Pine, Zachary Quinto, Eric Bana",
      "J.J. Abrams",
      "/imagensfilme/BANNER-STARTREK.png",
      "/imagensfilme/THUMB-STARTREK.png"
    },
    {
      "LIGA DA JUSTIÇA",
      "Em Liga da Justiça, impulsionado pela restauração de sua fé na humanidade e inspirado pelo ato altruísta do Superman (Henry Cavill), Bruce Wayne (Ben Affleck) convoca sua nova aliada Diana Prince (Gal Gadot) para o combate contra um inimigo ainda maior, recém-despertado. Juntos, Batman e Mulher-Maravilha buscam e recrutam com agilidade um time de meta-humanos, mas mesmo com a formação da liga de heróis sem precedentes - Batman, Mulher-Maraviha, Aquaman (Jason Momoa), Cyborg (Ray Fisher) e Flash (Ezra Miller) -, poderá ser tarde demais para salvar o planeta de um catastrófico ataque.",
      "2h 00 min",
      "Novembro de 2017",
      "Ação, Ficção científica",
      "Ben Affleck, Henry Cavill, Gal Gadot",
      "Zack Snyder",
      "/imagensfilme/BANNER-justiceleague.png",
      "/imagensfilme/THUMB-justiceleague.png"
    },
    {
      "MATRIX",
      "Em um futuro próximo, Thomas Anderson (Keanu Reeves), um jovem programador de computador que mora em um cubículo escuro, é atormentado por estranhos pesadelos nos quais encontra-se conectado por cabos e contra sua vontade, em um imenso sistema de computadores do futuro. Em todas essas ocasiões, acorda gritando no exato momento em que os eletrodos estão para penetrar em seu cérebro. À medida que o sonho se repete, Anderson começa a ter dúvidas sobre a realidade. Por meio do encontro com os misteriosos Morpheus (Laurence Fishburne) e Trinity (Carrie-Anne Moss), Thomas descobre que é, assim como outras pessoas, vítima do Matrix, um sistema inteligente e artificial que manipula a mente das pessoas, criando a ilusão de um mundo real enquanto usa os cérebros e corpos dos indivíduos para produzir energia. Morpheus, entretanto, está convencido de que Thomas é Neo, o aguardado messias capaz de enfrentar o Matrix e conduzir as pessoas de volta à realidade e à liberdade.",
      "2h 15 min",
      "Maio de 1999",
      "Ação, Ficção científica",
      "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss",
      "Lana Wachowski, Lilly Wachowski",
      "/imagensfilme/BANNER-MATRIX.png",
      "/imagensfilme/THUMB-MATRIX.png"
    },
    {
      "JOGOS VORAZES: A ESPERANÇA - PARTE 1",
      "Após ser resgatada do Massacre Quaternário pela resistência ao governo tirânico do presidente Snow (Donald Sutherland), Katniss Everdeen (Jennifer Lawrence) está abalada. Temerosa e sem confiança, ela agora vive no Distrito 13 ao lado da mãe (Paula Malcomson) e da irmã, Prim (Willow Shields). A presidente Alma Coin (Julianne Moore) e Plutarch Heavensbee (Philip Seymour Hoffman) querem que Katniss assuma o papel do tordo, o símbolo que a resistência precisa para mobilizar a população. Após uma certa relutância, Katniss aceita a proposta desde que a resistência se comprometa a resgatar Peeta Mellark (Josh Hutcherson) e os demais Vitoriosos, mantidos prisioneiros pela Capital.",
      "2h 03 min",
      "Novembro de 2014",
      "Ação, Drama, Ficção científica",
      "Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth",
      "Francis Lawrence",
      "/imagensfilme/BANNER-jogosvorazes.png",
      "/imagensfilme/THUMB-jogosvorazes.png"
    },
    {
      "KARATÊ KID - A HORA DA VERDADE",
      "Daniel Larusso (Ralph Macchio) e sua mãe (Randee Heller) recentemente se mudaram de Nova Jersey para o sul da Califórnia. Porém, Daniel não consegue se ambientar em sua nova morada, até que conhece Ali Mills (Elisabeth Shue), uma garota atraente que gosta dele. Porém, a situação de Daniel se complica quando o ex-namorado de Ali, Johnny Lawrence (William Zabka), e sua gangue começam a atormentá-lo. Um dia, quando é cercado pela gangue de Johnny, ele é salvo por um Miyagi, um veterano japonês (Pat Morita) mestre na arte do karatê. Disposto a ajudar Daniel, Miyagi resolve passar-lhe os ensinamentos do karatê, para que ele possa se defender da gangue de Johnny.",
      "2h 06 min",
      "Julho de 1984",
      "Ação, Drama",
      "Ralph Macchio, Pat Morita, Elisabeth Shue",
      "John G. Avildsen",
      "/imagensfilme/BANNER-KARATEKID.png",
      "/imagensfilme/THUMB-KARATEKID.png"
    },
    {
      "FRAGMENTADO",
      "Kevin (James McAvoy) possui 23 personalidades distintas e consegue alterná-las quimicamente em seu organismo apenas com a força do pensamento. Um dia, ele sequestra três adolescentes que encontra em um estacionamento. Vivendo em cativeiro, elas passam a conhecer as diferentes facetas de Kevin e precisam encontrar algum meio de escapar.",
      "1h 57 min",
      "Março de 2017",
      "Suspense, Fantasia, Terror",
      "James McAvoy, Anya Taylor-Joy, Betty Buckley",
      "M. Night Shyamalan",
      "/imagensfilme/BANNER-fragmentado.png",
      "/imagensfilme/THUMB-fragmentado.png"
    },
    {
      "HARRY POTTER E AS RELÍQUIAS DA MORTE - PARTE 2",
      "Em Harry Potter e as Relíquias da Morte - Parte 2, Harry Potter (Daniel Radcliffe) e seus amigos Rony Weasley (Rupert Grint) e Hermione Granger (Emma Watson) seguem à procura das horcruxes. O objetivo do trio é encontrá-las e, em seguida, destruí-las, de forma a eliminar lorde Voldemort (Ralph Fiennes) de uma vez por todas. Com a ajuda do duende Grampo (Warwick Davis), eles entram no banco Gringotes de forma a invadir o cofre de Bellatrix Lestrange (Helena Bonham Carter). De lá retornam ao castelo de Hogwarts, onde precisam encontrar mais uma horcrux. Paralelamente, Voldemort prepara o ataque definitivo ao castelo.",
      "2h 10 min",
      "Julho de 2011",
      "Fantasia, Aventura",
      "Daniel Radcliffe, Will Dunn, Rohan Gotobed, Alfie McIlwain",
      "David Yates",
      "/imagensfilme/BANNER-harrypotter.png",
      "/imagensfilme/THUMB-harrypotter.png"
    },
    {
      "OS CAÇA-FANTASMAS",
      "Em Nova York Peter Venkman (Bill Murray), Ray Stantz (Dan Aykroyd) e Egon Spengler (Harold Ramis) são três cientistas do departamento de psicologia da Columbia University, que se dedicam ao estudo de casos paranormais. Quando a subvenção termina eles são despedidos e Venkman sugere que abram um negócio próprio, a exterminadora de fantasmas Ghostbusters. Inicialmente eles só têm despesas e nenhum cliente, mas eis que surge Dana Barrett (Sigourney Weaver), uma violoncelista que teve uma experiência assustadora em seu apartamento.",
      "1h 45 min",
      "Dezembro de 1984",
      "Comédia , Ação, Fantasia",
      "Bill Murray, Dan Aykroyd, Harold Ramis",
      "Ivan Reitman",
      "/imagensfilme/BANNER-ghostbusters.png",
      "/imagensfilme/THUMB-ghostbusters.png"
    }
});
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Filmes");
        }
    }
}
