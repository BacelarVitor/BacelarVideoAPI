--Server=localhost\SQLEXPRESS;Database=IntcomTest;Trusted_Connection=True;
IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'IntcomTest')
  BEGIN
    CREATE DATABASE IntcomTest
  END

CREATE TABLE [dbo].[Cliente](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Nome] [nvarchar](50) NOT NULL,
    [Email] [nvarchar](50) NOT NULL UNIQUE,
    [Senha] [nvarchar](50) NOT NULL,
    [DataCriacao] [datetime] NOT NULL,
    [DataAtualizacao] [datetime] NULL
)

CREATE TABLE [dbo].[Filme](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Duracao] [nvarchar](30) NOT NULL,
	[AnoLancamento] [int] NOT NULL,
	[Sinopse] [nvarchar](2000) NOT NULL,
    [Titulo] [nvarchar](80) NOT NULL UNIQUE,
	[Direcao] [nvarchar](80) NOT NULL,
	[Capa] [nvarchar](500) NOT NULL,
	[Generos] [nvarchar](150) NOT NULL,
    [DataCriacao] [datetime] NOT NULL,
    [DataAtualizacao] [datetime] NULL
)

CREATE TABLE [dbo].[Locacao](
    [Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [ClienteId] [int] NOT NULL,
	[FilmeId] [int] NOT NULL,
	[Ativa] [bit] NOT NULL,
	[DataDevolucao] [datetime] NULL,
    [DataCriacao] [datetime] NOT NULL,
    [DataAtualizacao] [datetime] NULL,
	CONSTRAINT FK_LocacaoCliente_Cliente FOREIGN KEY (ClienteId) REFERENCES [dbo].[Cliente](Id) 
	ON DELETE CASCADE
    ON UPDATE CASCADE,
	CONSTRAINT FK_LocacaoFilme_Filme FOREIGN KEY (FilmeId) REFERENCES [dbo].[Filme](Id)
	ON DELETE CASCADE
    ON UPDATE CASCADE
)

INSERT INTO Cliente (Nome, Email, Senha, DataCriacao) Values ('Teste', 'teste@intcom.com', 'teste', GETDATE())
INSERT INTO Cliente (Nome, Email, Senha, DataCriacao) Values ('Vitor', 'vitor@gmail.com', 'teste', GETDATE())
INSERT INTO Cliente (Nome, Email, Senha, DataCriacao) Values ('Mauricio', 'mauricio@intcom.com', 'teste', GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'The Lord of the Rings: The Fellowship of the Ring',
	'An ancient Ring thought lost for centuries has been found, and through a strange twist in fate has been given to a small Hobbit named Frodo. When Gandalf discovers the Ring is in fact the One Ring of the Dark Lord Sauron, Frodo must make an epic quest to the Cracks of Doom in order to destroy it! However he does not go alone. He is joined by Gandalf, Legolas the elf, Gimli the Dwarf, Aragorn, Boromir and his three Hobbit friends Merry, Pippin and Samwise. Through mountains, snow, darkness, forests, rivers and plains, facing evil and danger at every corner the Fellowship of the Ring must go. Their quest to destroy the One Ring is the only hope for the end of the Dark Lords reign!',
	'Peter Jackson',
	'https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg',
	'Action, Adventure, Drama, Fantasy',
	'178 min',
	2001,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'The Lord of the Rings: The Two Towers',
	'While Frodo and Sam, now accompanied by a new guide, continue their hopeless journey towards the land of shadow to destroy the One Ring, each member of the broken fellowship plays their part in the battle against the evil wizard Saruman and his armies of Isengard.',
	'Peter Jackson',
	'https://m.media-amazon.com/images/M/MV5BNGE5MzIyNTAtNWFlMC00NDA2LWJiMjItMjc4Yjg1OWM5NzhhXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
	'Adventure, Drama, Fantasy',
	'179 min',
	2002,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'The Lord of the Rings: The Return of the King',
	'The final confrontation between the forces of good and evil fighting for control of the future of Middle-earth. Hobbits: Frodo and Sam reach Mordor in their quest to destroy the \"one ring\", while Aragorn leads the forces of good against Sauron''s evil army at the stone city of Minas Tirith.',
	'Peter Jackson',
	'https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
	'Adventure, Drama, Fantasy',
	'201 min',
	2003,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode I - The Phantom Menace',
	'The evil Trade Federation, led by Nute Gunray is planning to take over the peaceful world of Naboo. Jedi Knights Qui-Gon Jinn and Obi-Wan Kenobi are sent to confront the leaders. But not everything goes to plan. The two Jedi escape, and along with their new Gungan friend, Jar Jar Binks head to Naboo to warn Queen Amidala, but droids have already started to capture Naboo and the Queen is not safe there. Eventually, they land on Tatooine, where they become friends with a young boy known as Anakin Skywalker. Qui-Gon is curious about the boy, and sees a bright future for him. The group must now find a way of getting to Coruscant and to finally solve this trade dispute, but there is someone else hiding in the shadows. Are the Sith really extinct? Is the Queen really who she says she is? And what''s so special about this young boy?',
	'George Lucas',
	'https://m.media-amazon.com/images/M/MV5BYTRhNjcwNWQtMGJmMi00NmQyLWE2YzItODVmMTdjNWI0ZDA2XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'136 min',
	1999,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode II - Attack of the Clones',
	'Ten years after the invasion of Naboo, the Galactic Republic is facing a Separatist movement and the former queen and now Senator Padmé Amidala travels to Coruscant to vote on a project to create an army to help the Jedi to protect the Republic. Upon arrival, she escapes from an attempt to kill her, and Obi-Wan Kenobi and his Padawan Anakin Skywalker are assigned to protect her. They chase the shape-shifter Zam Wessell but she is killed by a poisoned dart before revealing who hired her. The Jedi Council assigns Obi-Wan Kenobi to discover who has tried to kill Amidala and Anakin to protect her in Naboo. Obi-Wan discovers that the dart is from the planet Kamino, and he heads to the remote planet. He finds an army of clones that has been under production for years for the Republic and that the bounty hunter Jango Fett was the matrix for the clones. Meanwhile Anakin and Amidala fall in love with each other, and he has nightmarish visions of his mother. They travel to his home planet, Tatooine, to see his mother, and he discovers that she has been abducted by Tusken Raiders. Anakin finds his mother dying, and he kills all the Tusken tribe, including the women and children. Obi-Wan follows Jango Fett to the planet Geonosis where he discovers who is behind the Separatist movement. He transmits his discoveries to Anakin since he cannot reach the Jedi Council. Who is the leader of the Separatist movement? Will Anakin receive Obi-Wan''s message? And will the secret love between Anakin and Amidala succeed?',
	'George Lucas',
	'https://m.media-amazon.com/images/M/MV5BMDAzM2M0Y2UtZjRmZi00MzVlLTg4MjEtOTE3NzU5ZDVlMTU5XkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'142 min',
	2002,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode III - Revenge of the Sith',
	'Near the end of the Clone Wars, Darth Sidious has revealed himself and is ready to execute the last part of his plan to rule the galaxy. Sidious is ready for his new apprentice, Darth Vader, to step into action and kill the remaining Jedi. Vader, however, struggles to choose the dark side and save his wife or remain loyal to the Jedi order.',
	'George Lucas',
	'https://m.media-amazon.com/images/M/MV5BNTc4MTc3NTQ5OF5BMl5BanBnXkFtZTcwOTg0NjI4NA@@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'140 min',
	2005,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode IV - A New Hope',
	'The Imperial Forces, under orders from cruel Darth Vader, hold Princess Leia hostage in their efforts to quell the rebellion against the Galactic Empire. Luke Skywalker and Han Solo, captain of the Millennium Falcon, work together with the companionable droid duo R2-D2 and C-3PO to rescue the beautiful princess, help the Rebel Alliance and restore freedom and justice to the Galaxy.',
	'George Lucas',
	'https://m.media-amazon.com/images/M/MV5BNzVlY2MwMjktM2E4OS00Y2Y3LWE3ZjctYzhkZGM3YzA1ZWM2XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'121 min',
	1977,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode V - The Empire Strikes Back',
	'Luke Skywalker, Han Solo, Princess Leia and Chewbacca face attack by the Imperial forces and its AT-AT walkers on the ice planet Hoth. While Han and Leia escape in the Millennium Falcon, Luke travels to Dagobah in search of Yoda. Only with the Jedi master''s help will Luke survive when the dark side of the Force beckons him into the ultimate duel with Darth Vader.',
	'Irvin Kershner',
	'https://m.media-amazon.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'124 min',
	1980,
	GETDATE())

INSERT INTO Filme (Titulo, Sinopse, Direcao, Capa, Generos, Duracao, AnoLancamento, DataCriacao) 
Values (
	'Star Wars: Episode VI - Return of the Jedi',
	'Luke Skywalker battles horrible Jabba the Hut and cruel Darth Vader to save his comrades in the Rebel Alliance and triumph over the Galactic Empire. Han Solo and Princess Leia reaffirm their love and team with Chewbacca, Lando Calrissian, the Ewoks and the androids C-3PO and R2-D2 to aid in the disruption of the Dark Side and the defeat of the evil emperor.',
	'Richard Marquand',
	'https://m.media-amazon.com/images/M/MV5BOWZlMjFiYzgtMTUzNC00Y2IzLTk1NTMtZmNhMTczNTk0ODk1XkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg',
	'Action, Adventure, Fantasy, Sci-Fi',
	'131 min',
	1983,
	GETDATE())