CREATE PROCEDURE [dbo].[sp_utilizadores_get]
	@Id_Utilizador INT = NULL
AS
BEGIN
	SELECT * 
	FROM Utilizador U
	WHERE (U.[Id_Utilizador] = @Id_Utilizador OR @Id_Utilizador IS NULL)
END

