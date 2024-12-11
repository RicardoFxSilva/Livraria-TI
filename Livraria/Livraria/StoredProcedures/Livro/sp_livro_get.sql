CREATE PROCEDURE [dbo].[sp_livro_get]
	@Id_Livro INT = NULL
AS
BEGIN
	SELECT * 
	FROM Livro L
	WHERE (L.[Id_Livro] = @Id_Livro OR @Id_Livro IS NULL)
END

