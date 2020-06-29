CREATE TABLE [dbo].[Fornecedor]
(
	[Id] INT NOT NULL CONSTRAINT [PK FORNECEDOR] PRIMARY KEY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Telefone] VARCHAR(14) NOT NULL, 
    [Cidade] VARCHAR(50) NOT NULL, 
    [Estado] VARCHAR(2) NOT NULL, 
    [Logradouro] VARCHAR(50) NOT NULL, 
    [Numero] VARCHAR(5) NOT NULL, 
    [CNPJ] VARCHAR(18) NOT NULL, 
    [Email] VARCHAR(100) NOT NULL, 
    [Banco] VARCHAR(3) NOT NULL, 
    [Agencia] VARCHAR(4) NOT NULL, 
    [ContaCorrente] VARCHAR(7) NOT NULL
)
