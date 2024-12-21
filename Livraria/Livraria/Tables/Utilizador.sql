CREATE TABLE Utilizador (
    Id_Utilizador INT PRIMARY KEY IDENTITY(1,1),
    NomeUtilizador VARCHAR(100),
    Email VARCHAR(100),
    Password VARCHAR(50),
    Morada VARCHAR(100)
);