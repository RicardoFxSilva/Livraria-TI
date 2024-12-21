-- Tabela de Relacionamento entre Livro e Autor
CREATE TABLE LivroAutor (
    Id_Livro INT,
    Id_Autor INT,
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Autor) REFERENCES Autor(Id_Autor)
);