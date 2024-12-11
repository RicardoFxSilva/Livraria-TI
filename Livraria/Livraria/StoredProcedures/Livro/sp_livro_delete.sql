CREATE PROCEDURE [dbo].[sp_livro_delete]
	@Id_Livro int
AS
BEGIN
	DELETE
	FROM dbo.Livro
	WHERE Id_Livro = @Id_Livro
END