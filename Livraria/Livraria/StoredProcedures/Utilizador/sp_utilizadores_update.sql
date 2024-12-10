CREATE PROCEDURE [dbo].[sp_utilizadores_update]
	@Id_Utilizador int,
	@NomeUtilizador NVARCHAR(MAX),
	@Email NVARCHAR(MAX)

AS
BEGIN
	UPDATE dbo.Utilizador
	SET [NomeUtilizador] = @NomeUtilizador
	WHERE Id_Utilizador = @Id_Utilizador
END