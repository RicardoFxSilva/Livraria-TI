CREATE PROCEDURE [dbo].[sp_compras_get]
	@Id_Compra INT = NULL
AS
BEGIN
	SELECT * 
	FROM Compra C
	WHERE (C.[Id_Compra] = @Id_Compra OR @Id_Compra IS NULL)
END

