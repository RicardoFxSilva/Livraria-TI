CREATE PROCEDURE [dbo].[sp_livro_insert]
	@Id_Livro int,
	@Titulo NVARCHAR(MAX),
	@Preco DECIMAL(10,2),
	@Descricao NVARCHAR(MAX),
	@Capa NVARCHAR(MAX),
	@Editora NVARCHAR(MAX)


AS
BEGIN
	INSERT INTO dbo.Livro([Titulo], [Preco], [Descricao], [Capa], [Editora])
			VALUES(@Titulo,@Preco,@Descricao,@Capa,@Editora)
END