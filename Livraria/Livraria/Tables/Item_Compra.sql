-- CriaÃ§Ã£o da Tabela de Itens de Compra
CREATE TABLE Item_Compra (
    Id_Item INT PRIMARY KEY IDENTITY(1,1),
    Preco DECIMAL(10, 2),
    Quantidade INT,
    Id_Livro INT,
    Id_Compra INT,
    FOREIGN KEY (Id_Livro) REFERENCES Livro(Id_Livro),
    FOREIGN KEY (Id_Compra) REFERENCES Compra(Id_Compra)
);