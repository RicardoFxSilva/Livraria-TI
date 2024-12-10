CREATE PROCEDURE [dbo].[sp_utilizadores_delete]
	@Id_Utilizador INT
AS
BEGIN
	DELETE
	FROM dbo.Utilizador
	WHERE Id_Utilizador = @Id_Utilizador
END