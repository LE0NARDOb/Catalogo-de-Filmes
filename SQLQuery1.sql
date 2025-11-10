IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CatalogoFilmes')
CREATE DATABASE [CatalogoFilmes];
GO

USE [CatalogoFilmes];
GO

CREATE TABLE Generos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(30) NOT NULL
);
GO

CREATE TABLE Filmes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100) NOT NULL,
    Sinopse NVARCHAR(MAX),
    AnoLancamento INT NOT NULL,
    Diretor NVARCHAR(100),
    Poster NVARCHAR(200)
);
GO

CREATE TABLE FilmesGeneros (
    FilmeId INT NOT NULL,
    GeneroId INT NOT NULL,
    PRIMARY KEY (FilmeId, GeneroId),
    FOREIGN KEY (FilmeId) REFERENCES Filmes(Id) ON DELETE CASCADE,
    FOREIGN KEY (GeneroId) REFERENCES Generos(Id) ON DELETE CASCADE
);
GO

INSERT INTO Generos (Nome) VALUES
(N'A��o'), (N'Com�dia'), (N'Drama'), (N'Fic��o Cient�fica'),
(N'Terror'), (N'Aventura'), (N'Romance');
GO

INSERT INTO Filmes (Titulo, Sinopse, AnoLancamento, Diretor, Poster) VALUES
(N'Vingadores: Ultimato', N'Ap�s os eventos devastadores de "Guerra Infinita", o universo est� em ru�nas.', 2019, N'Anthony Russo, Joe Russo', N'/images/vingadores.jpg'),
(N'Parasita', N'Toda a fam�lia de Ki-taek est� desempregada, vivendo num por�o sujo e apertado.', 2019, N'Bong Joon Ho', N'/images/parasita.jpg'),
(N'O Poderoso Chef�o', N'Uma fam�lia mafiosa luta para estabelecer sua supremacia nos Estados Unidos.', 1972, N'Francis Ford Coppola', N'/images/poderoso-chefao.jpg');
GO

INSERT INTO FilmesGeneros (FilmeId, GeneroId) VALUES
(1, 1),
(1, 4), 
(1, 6), 
(2, 3),
(3, 3); 
GO