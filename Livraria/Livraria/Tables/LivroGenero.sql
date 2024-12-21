-- Tabela de Relacionamento entre Livro e G nero
CREATE TABLE LivroGenero (
    Id_Livro INT,
    Id_Genero INT,
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Genero) REFERENCES Genero(Id_Genero)
);