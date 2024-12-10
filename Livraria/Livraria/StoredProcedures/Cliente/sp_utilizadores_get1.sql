CREATE PROCEDURE [dbo].[sp_utilizadores_get1]
	@Id_Utilizador INT = 1
AS
BEGIN
	SELECT * 
	FROM Utilizador U
	WHERE (U.[Id_Utilizador] = @Id_Utilizador OR @IId_Utilizador IS NULL)
END

