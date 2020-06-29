CREATE TABLE [dbo].[Presente]
(
	[Id] INT NOT NULL CONSTRAINT [PK PRESENTE] PRIMARY KEY, 
    [Descricao] VARCHAR(50) NOT NULL, 
    [Tipo] INT NOT NULL, 
    [Marca] INT NOT NULL, 
    [Finalidade] INT NOT NULL, 
    [Cor] VARCHAR(50) NOT NULL, 
    [Tamanho] DECIMAL(10, 2) NOT NULL, 
    [Preco] DECIMAL(10, 2) NOT NULL, 
    [Fornecedor] INT NOT NULL, 
    CONSTRAINT [FK_Presente_ToTipo] FOREIGN KEY ([Tipo]) REFERENCES Tipo(Id), 
    CONSTRAINT [FK_Presente_ToMarca] FOREIGN KEY ([Marca]) REFERENCES [Marca](Id), 
    CONSTRAINT [FK_Presente_ToFinalidade] FOREIGN KEY ([Finalidade]) REFERENCES [Finalidade](Id), 
    CONSTRAINT [FK_Presente_ToFornecedor] FOREIGN KEY ([Fornecedor]) REFERENCES [Fornecedor](Id)
)
