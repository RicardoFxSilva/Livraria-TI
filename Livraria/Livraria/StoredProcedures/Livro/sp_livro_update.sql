CREATE PROCEDURE [dbo].[sp_livro_update]
	@Id_Livro int,
	@Titulo NVARCHAR(MAX),
	@Preco DECIMAL(10,2),
	@Descricao NVARCHAR(MAX),
	@Capa NVARCHAR(MAX),
	@Editora NVARCHAR(MAX)


AS
BEGIN
	UPDATE dbo.Livro
	SET [Titulo] = @Titulo, [Preco] = @Preco, [Descricao] = @Descricao, [Capa] = @Capa, [Editora] = @Editora
	WHERE Id_Livro = @Id_Livro
END