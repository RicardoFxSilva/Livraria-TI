CREATE PROCEDURE [dbo].[sp_livro_get1]
	@Id_Livro INT = 1
AS
BEGIN
	SELECT * 
	FROM Livro L
	WHERE (L.[Id_Livro] = @Id_Livro OR @Id_Livro IS NULL)
END

