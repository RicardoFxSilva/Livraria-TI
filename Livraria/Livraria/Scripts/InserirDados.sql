-- CriaÃ§Ã£o da Tabela Utilizador
use Livraria;
GO

-- inserir dados ás tabelas incluindo o admin
INSERT INTO Utilizador (NomeUtilizador, Email, Password, Morada)
VALUES 
('admin', 'admin@admin.com', '123', 'administrador'),
('João Silva', 'joao.silva@example.com', 'qwe123!', 'Rua A, nº 1'),
('Maria Costa', 'maria.costa@example.com', 'abc@456', 'Rua B, nº 2'),
('Carlos Santos', 'carlos.santos@example.com', '123XYZ!', 'Rua C, nº 3'),
('Ana Oliveira', 'ana.oliveira@example.com', 'Ana#789', 'Rua D, nº 4'),
('Luís Martins', 'luis.martins@example.com', 'Luis$123', 'Rua E, nº 5'),
('Clara Almeida', 'clara.almeida@example.com', 'Clara_456', 'Rua F, nº 6'),
('Pedro Rodrigues', 'pedro.rodrigues@example.com', 'Pedro@2023', 'Rua G, nº 7'),
('Beatriz Lopes', 'beatriz.lopes@example.com', 'Bea#321', 'Rua H, nº 8'),
('Miguel Fernandes', 'miguel.fernandes@example.com', 'Mig_4567', 'Rua I, nº 9'),
('Helena Nogueira', 'helena.nogueira@example.com', 'H@2024!', 'Rua J, nº 10'),
('Ricardo Sousa', 'ricardo.sousa@example.com', 'Ric123$', 'Rua K, nº 11'),
('Sofia Cardoso', 'sofia.cardoso@example.com', 'Sof%456', 'Rua L, nº 12'),
('André Monteiro', 'andre.monteiro@example.com', 'And_789!', 'Rua M, nº 13'),
('Carolina Ramos', 'carolina.ramos@example.com', 'Caro@123', 'Rua N, nº 14');
GO

INSERT INTO Autor (NomeAutor)
VALUES 
('J.K. Rowling'),
('George R.R. Martin'),
('Stephen King'),
('Jane Austen'),
('Mark Twain'),
('Agatha Christie'),
('Ernest Hemingway'),
('F. Scott Fitzgerald'),
('Charles Dickens'),
('Leo Tolstoy'),
('J.R.R. Tolkien'),
('Virginia Woolf'),
('Gabriel García Márquez'),
('Harper Lee'),
('Isabel Allende');
GO

INSERT INTO Genero (Genero)
VALUES 
('Ficção'),
('Fantasia'),
('Mistério'),
('Romance'),
('Aventura'),
('Terror'),
('Biografia'),
('Histórico'),
('Ciência'),
('Filosofia'),
('Drama'),
('Humor'),
('Autoajuda'),
('Infantil'),
('Clássico');
GO

INSERT INTO Livro (Titulo, Preco, Descricao, Capa, Editora)
VALUES 
('O Senhor dos Anéis', 49.99, 'Em uma terra fantástica e única, um hobbit recebe de presente de seu tio um anel mágico e maligno que precisa ser destruído antes que caia nas mãos do mal. Para isso, o hobbit Frodo tem um caminho árduo pela frente, onde encontra perigo, medo e seres bizarros. Ao seu lado para o cumprimento desta jornada, ele aos poucos pode contar com outros hobbits, um elfo, um anão, dois humanos e um mago, totalizando nove seres que formam a Sociedade do Anel.',NULL, 'HarperCollins'),
('Game of Thrones', 59.99, 'O primeiro volume da série As Crônicas de Gelo e Fogo mergulha no continente fictício de Westeros, onde famílias nobres lutam pelo controle do Trono de Ferro. Em meio a traições, alianças e conflitos, o inverno se aproxima, trazendo consigo perigos ainda maiores do que as disputas pelo poder.',NULL, 'Bantam Books'),
('It - A Coisa', 39.50, 'Na pequena cidade de Derry, um grupo de amigos enfrenta uma entidade maligna que assume a forma de seus piores medos, muitas vezes manifestando-se como o palhaço Pennywise. Anos depois, eles retornam à cidade para cumprir uma promessa de infância: enfrentar A Coisa uma última vez.',NULL, 'Suma'),
('Orgulho e Preconceito', 29.90, 'Elizabeth Bennet, uma jovem espirituosa, enfrenta desafios em sua busca por amor e felicidade em meio às rígidas normas sociais do início do século XIX. Sua relação com o orgulhoso Sr. Darcy começa tumultuada, mas evolui à medida que ambos aprendem a superar seus preconceitos.' ,NULL, 'Penguin Books'),
('As Aventuras de Tom Sawyer', 19.99, 'Tom Sawyer é um jovem travesso que vive às margens do rio Mississippi. Suas aventuras incluem buscar tesouros escondidos, testemunhar um crime e escapar de perigos mortais, sempre com seu amigo Huckleberry Finn ao lado.',NULL, 'Oxford Press'),
('Assassinato no Expresso do Oriente', 25.50, 'O famoso detetive Hercule Poirot embarca no Expresso do Oriente, mas a viagem é interrompida pelo assassinato de um passageiro. Poirot deve resolver o caso em um ambiente claustrofóbico, onde todos são suspeitos e nada é o que parece.',NULL, 'Collins Crime Club'),
('O Velho e o Mar', 34.90, 'Um velho pescador cubano chamado Santiago enfrenta a luta de sua vida ao capturar um gigantesco marlim em alto-mar. A obra explora temas de perseverança, solidão e a conexão do homem com a natureza.',NULL, 'Scribner'),
('O Grande Gatsby', 21.80, 'Ambientado na efervescente década de 1920, o romance conta a história de Jay Gatsby, um homem misterioso e ambicioso, e sua obsessão por Daisy Buchanan. Através do olhar de Nick Carraway, o leitor é levado a explorar os excessos, a decadência e o vazio do sonho americano.',NULL, 'Scribner'),
('David Copperfield', 28.00, 'Uma obra semi-autobiográfica que segue a vida de David Copperfield, desde sua infância difícil até se tornar um escritor renomado. O livro aborda temas como perseverança, amizade e amor, enquanto explora as injustiças sociais da era vitoriana.',NULL, 'Chapman & Hall'),
('Guerra e Paz', 64.90, 'Um épico literário que combina ficção e história, acompanhando várias famílias aristocráticas durante as Guerras Napoleônicas na Rússia. O romance aborda questões de amor, guerra, destino e a busca por sentido na vida.',NULL, 'Vintage Books'),
('O Hobbit', 44.99, 'Bilbo Bolseiro, um hobbit tranquilo, é inesperadamente arrastado para uma jornada épica com um grupo de anões em busca de recuperar seu tesouro roubado pelo dragão Smaug. Pelo caminho, Bilbo encontra perigos, amigos e um anel mágico.',NULL, 'HarperCollins'),
('Mrs. Dalloway', 22.50, 'A narrativa acompanha um único dia na vida de Clarissa Dalloway, uma mulher da alta sociedade londrina. Enquanto organiza uma festa, suas reflexões revelam questões profundas sobre identidade, mortalidade e o papel da mulher na sociedade.',NULL, 'Hogarth Press'),
('Cem Anos de Solidão', 37.90, 'Uma saga multigeracional da família Buendía na fictícia cidade de Macondo. A obra, um marco do realismo mágico, explora temas de amor, solidão, poder e a passagem do tempo, enquanto mistura elementos fantásticos e históricos.',NULL, 'Harper Perennial'),
('O Sol é para Todos', 32.80, 'Ambientado no sul dos Estados Unidos durante a Grande Depressão, o romance é narrado pela jovem Scout Finch, cuja visão inocente contrasta com as tensões raciais de sua cidade. Seu pai, o advogado Atticus Finch, defende um homem negro acusado injustamente de um crime.',NULL, 'J.B. Lippincott & Co.'),
('A Casa dos Espíritos', 39.99, 'Um romance multigeracional que mistura realismo mágico e história política, narrando a saga da família Trueba. A obra aborda temas como opressão, revolução, amor e memória, enquanto entrelaça eventos pessoais e sociais no Chile.',NULL, 'Editorial Sudamericana');
GO

INSERT INTO Compra (Data_Compra, Estado_Compra, Estado_Encomenda, Data_Entrega, Id_Utilizador)
VALUES 
(GETDATE(), 1, 0, DATEADD(DAY, 5, GETDATE()), 1),
(GETDATE(), 0, 1, DATEADD(DAY, 3, GETDATE()), 2),
(GETDATE(), 1, 1, DATEADD(DAY, 7, GETDATE()), 3),
(GETDATE(), 1, 0, DATEADD(DAY, 4, GETDATE()), 4),
(GETDATE(), 0, 0, NULL, 5),
(GETDATE(), 1, 1, DATEADD(DAY, 2, GETDATE()), 6),
(GETDATE(), 0, 1, DATEADD(DAY, 6, GETDATE()), 7),
(GETDATE(), 1, 0, DATEADD(DAY, 1, GETDATE()), 8),
(GETDATE(), 1, 1, DATEADD(DAY, 3, GETDATE()), 9),
(GETDATE(), 1, 0, DATEADD(DAY, 8, GETDATE()), 10),
(GETDATE(), 0, 0, NULL, 11),
(GETDATE(), 1, 1, DATEADD(DAY, 5, GETDATE()), 12),
(GETDATE(), 1, 0, DATEADD(DAY, 4, GETDATE()), 13),
(GETDATE(), 0, 1, DATEADD(DAY, 2, GETDATE()), 14),
(GETDATE(), 1, 1, DATEADD(DAY, 3, GETDATE()), 15);
GO

INSERT INTO Item_Compra (Preco, Quantidade, Id_Livro, Id_Compra)
VALUES 
(49.99, 1, 1, 1),
(59.99, 2, 2, 2),
(39.50, 1, 3, 3),
(29.90, 3, 4, 4),
(19.99, 1, 5, 5),
(25.50, 2, 6, 6),
(34.90, 1, 7, 7),
(21.80, 4, 8, 8),
(28.00, 2, 9, 9),
(64.90, 1, 10, 10),
(44.99, 1, 11, 11),
(22.50, 3, 12, 12),
(37.90, 2, 13, 13),
(32.80, 1, 14, 14),
(39.99, 1, 15, 15);
GO

INSERT INTO LivroGenero (Id_Livro, Id_Genero)
VALUES 
(1, 2), (2, 3), (3, 6), (4, 4), (5, 5), 
(6, 3), (7, 8), (8, 1), (9, 9), (10, 8),
(11, 2), (12, 7), (13, 9), (14, 4), (15, 10);
GO

INSERT INTO LivroAutor (Id_Livro, Id_Autor)
VALUES 
(1, 11), (2, 2), (3, 3), (4, 4), (5, 5),
(6, 6), (7, 7), (8, 8), (9, 9), (10, 10),
(11, 11), (12, 12), (13, 13), (14, 14), (15, 15);
GO