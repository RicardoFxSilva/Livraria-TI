-- Criação da Base de Dados
DROP DATABASE Livraria;
CREATE DATABASE Livraria;
-- Criação da Tabela Utilizador
CREATE TABLE Utilizador (
    Id_Utilizador INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100),
    Email VARCHAR(100),
    Senha VARCHAR(50),
    Morada VARCHAR(100)
);

-- Criação da Tabela Autor
CREATE TABLE Autor (
    Id_Autor INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(50)
);

-- Criação da Tabela Genero
CREATE TABLE Genero (
    Id_Genero INT PRIMARY KEY IDENTITY(1,1),
    Genero VARCHAR(50)
);

-- Criação da Tabela Livro
CREATE TABLE Livro (
    Id_Livro INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(75),
    Preco DECIMAL(10, 2),
    Capa VARCHAR(255),
    Editora VARCHAR(75)
);

-- Tabela de Relacionamento entre Livro e G�nero
CREATE TABLE LivroGenero (
    Id_Livro INT,
    Id_Genero INT,
    PRIMARY KEY (Id_Livro, Id_Genero),
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Genero) REFERENCES Genero(Id_Genero)
);

-- Tabela de Relacionamento entre Livro e Autor
CREATE TABLE LivroAutor (
    Id_Livro INT,
    Id_Autor INT,
    PRIMARY KEY (Id_Livro, Id_Autor),
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Autor) REFERENCES Autor(Id_Autor)
);

-- Criação da Tabela de Compras
CREATE TABLE Compra (
    Id_Compra INT PRIMARY KEY IDENTITY(1,1),
    Data_Compra DATETIME,
    Estado_Compra BIT,
    Estado_Encomenda BIT,
    Data_Entrega DATETIME,
    Id_Utilizador INT,
    FOREIGN KEY (Id_Utilizador) REFERENCES Utilizador(Id_Utilizador)
);

-- Criação da Tabela de Itens de Compra
CREATE TABLE Item_Compra (
    Id_Item INT PRIMARY KEY IDENTITY(1,1),
    Preco DECIMAL(10, 2),
    Quantidade INT,
    Id_Livro INT,
    Id_Compra INT,
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Compra) REFERENCES Compra(Id_Compra)
);

-- inserir dados ás tabelas incluindo o admin
INSERT INTO Utilizador (Nome, Email, Senha, Morada)
VALUES 
('admin', 'admin@admin.com', '123', 'administrador'),
('João Silva', 'joao.silva@example.com', 'qwe123!', 'Rua A, nº 1'),
('Maria Costa', 'maria.costa@example.com', 'abc@456', 'Rua B, nº 2'),
('Carlos Santos', 'carlos.santos@example.com', '123XYZ!', 'Rua C, nº 3'),
('Ana Oliveira', 'ana.oliveira@example.com', 'Ana#789', 'Rua D, nº 4'),
('Luís Martins', 'luis.martins@example.com', 'Luis$123', 'Rua E, nº 5'),
('Clara Almeida', 'clara.almeida@example.com', 'Clara_456', 'Rua F, nº 6'),
('Pedro Rodrigues', 'pedro.rodrigues@example.com', 'Pedro@2023', 'Rua G, nº 7'),
('Beatriz Lopes', 'beatriz.lopes@example.com', 'Bea#321', 'Rua H, nº 8'),
('Miguel Fernandes', 'miguel.fernandes@example.com', 'Mig_4567', 'Rua I, nº 9'),
('Helena Nogueira', 'helena.nogueira@example.com', 'H@2024!', 'Rua J, nº 10'),
('Ricardo Sousa', 'ricardo.sousa@example.com', 'Ric123$', 'Rua K, nº 11'),
('Sofia Cardoso', 'sofia.cardoso@example.com', 'Sof%456', 'Rua L, nº 12'),
('André Monteiro', 'andre.monteiro@example.com', 'And_789!', 'Rua M, nº 13'),
('Carolina Ramos', 'carolina.ramos@example.com', 'Caro@123', 'Rua N, nº 14');


INSERT INTO Autor (Nome)
VALUES 
('J.K. Rowling'),
('George R.R. Martin'),
('Stephen King'),
('Jane Austen'),
('Mark Twain'),
('Agatha Christie'),
('Ernest Hemingway'),
('F. Scott Fitzgerald'),
('Charles Dickens'),
('Leo Tolstoy'),
('J.R.R. Tolkien'),
('Virginia Woolf'),
('Gabriel García Márquez'),
('Harper Lee'),
('Isabel Allende');


INSERT INTO Genero (Genero)
VALUES 
('Ficção'),
('Fantasia'),
('Mistério'),
('Romance'),
('Aventura'),
('Terror'),
('Biografia'),
('Histórico'),
('Ciência'),
('Filosofia'),
('Drama'),
('Humor'),
('Autoajuda'),
('Infantil'),
('Clássico');


INSERT INTO Livro (Titulo, Preco, Capa, Editora)
VALUES 
('O Senhor dos Anéis', 49.99, NULL, 'HarperCollins'),
('Game of Thrones', 59.99, NULL, 'Bantam Books'),
('It - A Coisa', 39.50, NULL, 'Suma'),
('Orgulho e Preconceito', 29.90, NULL, 'Penguin Books'),
('As Aventuras de Tom Sawyer', 19.99, NULL, 'Oxford Press'),
('Assassinato no Expresso do Oriente', 25.50, NULL, 'Collins Crime Club'),
('O Velho e o Mar', 34.90, NULL, 'Scribner'),
('O Grande Gatsby', 21.80, NULL, 'Scribner'),
('David Copperfield', 28.00, NULL, 'Chapman & Hall'),
('Guerra e Paz', 64.90, NULL, 'Vintage Books'),
('O Hobbit', 44.99, NULL, 'HarperCollins'),
('Mrs. Dalloway', 22.50, NULL, 'Hogarth Press'),
('Cem Anos de Solidão', 37.90, NULL, 'Harper Perennial'),
('O Sol é para Todos', 32.80, NULL, 'J.B. Lippincott & Co.'),
('A Casa dos Espíritos', 39.99, NULL, 'Editorial Sudamericana');


INSERT INTO Compra (Data_Compra, Estado_Compra, Estado_Encomenda, Data_Entrega, Id_Utilizador)
VALUES 
(GETDATE(), 1, 0, DATEADD(DAY, 5, GETDATE()), 1),
(GETDATE(), 0, 1, DATEADD(DAY, 3, GETDATE()), 2),
(GETDATE(), 1, 1, DATEADD(DAY, 7, GETDATE()), 3),
(GETDATE(), 1, 0, DATEADD(DAY, 4, GETDATE()), 4),
(GETDATE(), 0, 0, NULL, 5),
(GETDATE(), 1, 1, DATEADD(DAY, 2, GETDATE()), 6),
(GETDATE(), 0, 1, DATEADD(DAY, 6, GETDATE()), 7),
(GETDATE(), 1, 0, DATEADD(DAY, 1, GETDATE()), 8),
(GETDATE(), 1, 1, DATEADD(DAY, 3, GETDATE()), 9),
(GETDATE(), 1, 0, DATEADD(DAY, 8, GETDATE()), 10),
(GETDATE(), 0, 0, NULL, 11),
(GETDATE(), 1, 1, DATEADD(DAY, 5, GETDATE()), 12),
(GETDATE(), 1, 0, DATEADD(DAY, 4, GETDATE()), 13),
(GETDATE(), 0, 1, DATEADD(DAY, 2, GETDATE()), 14),
(GETDATE(), 1, 1, DATEADD(DAY, 3, GETDATE()), 15);


INSERT INTO Item_Compra (Preco, Quantidade, Id_Livro, Id_Compra)
VALUES 
(49.99, 1, 1, 1),
(59.99, 2, 2, 2),
(39.50, 1, 3, 3),
(29.90, 3, 4, 4),
(19.99, 1, 5, 5),
(25.50, 2, 6, 6),
(34.90, 1, 7, 7),
(21.80, 4, 8, 8),
(28.00, 2, 9, 9),
(64.90, 1, 10, 10),
(44.99, 1, 11, 11),
(22.50, 3, 12, 12),
(37.90, 2, 13, 13),
(32.80, 1, 14, 14),
(39.99, 1, 15, 15);

INSERT INTO LivroGenero (Id_Livro, Id_Genero)
VALUES 
(1, 2), (2, 3), (3, 6), (4, 4), (5, 5), 
(6, 3), (7, 8), (8, 1), (9, 9), (10, 8),
(11, 2), (12, 7), (13, 9), (14, 4), (15, 10);

INSERT INTO LivroAutor (Id_Livro, Id_Autor)
VALUES 
(1, 11), (2, 2), (3, 3), (4, 4), (5, 5),
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10),
(11, 11), (12, 12), (13, 13), (14, 14), (15, 15);

select * from LivroAutor;