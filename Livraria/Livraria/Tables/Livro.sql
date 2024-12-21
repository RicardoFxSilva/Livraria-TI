-- CriaÃ§Ã£o da Tabela Livro
CREATE TABLE Livro (
    Id_Livro INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(75),
    Preco DECIMAL(10, 2),
    Descricao Varchar(750), 
    Capa VARCHAR(255),
    Editora VARCHAR(75)
);