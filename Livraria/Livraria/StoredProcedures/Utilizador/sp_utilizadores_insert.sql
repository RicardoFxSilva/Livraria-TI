Create PROCEDURE [dbo].[sp_Utilizador_insert]
	@Nome NVARCHAR(MAX),
    @Email NVARCHAR(MAX),
    @Password NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO dbo.Utilizador([Nome],[Email],[Password])
            VALUES (@Nome, @Email, @Password)
    END