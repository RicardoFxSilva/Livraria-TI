Create PROCEDURE [dbo].[sp_utilizadores_insert]
	@Nome NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @Password NVARCHAR(MAX),
    @Morada NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO dbo.Utilizador([NomeUtilizador],[Email],[Password],[Morada])
            VALUES (@Nome, @Email, @Password, @Morada)
    END