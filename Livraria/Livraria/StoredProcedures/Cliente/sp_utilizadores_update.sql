CREATE PROCEDURE [dbo].[sp_utilizadores_update]
	@Id_Utilizador int,
	@Nome NVARCHAR(MAX),
	@Email NVARCHAR(MAX)

AS
BEGIN
	UPDATE dbo.Utilizador
	SET [Nome] = @Nome
	WHERE Id_Utilizador = @Id_Utilizador
END