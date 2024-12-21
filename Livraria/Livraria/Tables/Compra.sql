-- CriaÃ§Ã£o da Tabela de Compras
CREATE TABLE Compra (
    Id_Compra INT PRIMARY KEY IDENTITY(1,1),
    Data_Compra DATETIME,
    Estado_Compra BIT,
    Estado_Encomenda BIT,
    Data_Entrega DATETIME,
    Id_Utilizador INT,
    FOREIGN KEY (Id_Utilizador) REFERENCES Utilizador(Id_Utilizador)
);