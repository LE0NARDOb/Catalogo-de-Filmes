-- Verifica se o banco de dados já existe e, se não, o cria.
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CatalogoFilmes')
CREATE DATABASE [CatalogoFilmes];
GO

-- Define o banco de dados a ser utilizado
USE [CatalogoFilmes];
GO

-- Tabela de Gêneros
CREATE TABLE Generos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(30) NOT NULL
);
GO

-- Tabela de Filmes
CREATE TABLE Filmes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(100) NOT NULL,
    Sinopse NVARCHAR(MAX),
    AnoLancamento INT NOT NULL,
    Diretor NVARCHAR(100),
    Poster NVARCHAR(200)
);
GO

-- Tabela de Ligação (Muitos-para-Muitos) entre Filmes e Gêneros
CREATE TABLE FilmesGeneros (
    FilmeId INT NOT NULL,
    GeneroId INT NOT NULL,
    PRIMARY KEY (FilmeId, GeneroId),
    FOREIGN KEY (FilmeId) REFERENCES Filmes(Id) ON DELETE CASCADE,
    FOREIGN KEY (GeneroId) REFERENCES Generos(Id) ON DELETE CASCADE
);
GO

-- Inserir alguns Gêneros de exemplo
INSERT INTO Generos (Nome) VALUES
(N'Ação'), (N'Comédia'), (N'Drama'), (N'Ficção Científica'),
(N'Terror'), (N'Aventura'), (N'Romance');
GO

-- Inserir alguns Filmes de exemplo para teste
INSERT INTO Filmes (Titulo, Sinopse, AnoLancamento, Diretor, Poster) VALUES
(N'Vingadores: Ultimato', N'Após os eventos devastadores de "Guerra Infinita", o universo está em ruínas.', 2019, N'Anthony Russo, Joe Russo', N'/images/vingadores.jpg'),
(N'Parasita', N'Toda a família de Ki-taek está desempregada, vivendo num porão sujo e apertado.', 2019, N'Bong Joon Ho', N'/images/parasita.jpg'),
(N'O Poderoso Chefão', N'Uma família mafiosa luta para estabelecer sua supremacia nos Estados Unidos.', 1972, N'Francis Ford Coppola', N'/images/poderoso-chefao.jpg');
GO

-- Ligar os filmes aos seus gêneros
INSERT INTO FilmesGeneros (FilmeId, GeneroId) VALUES
(1, 1), -- Vingadores -> Ação
(1, 4), -- Vingadores -> Ficção Científica
(1, 6), -- Vingadores -> Aventura
(2, 3), -- Parasita -> Drama
(3, 3); -- O Poderoso Chefão -> Drama
GO