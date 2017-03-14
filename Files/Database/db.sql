CREATE TABLE [dbo].[Fabricantes] (
    [FabricanteID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nome]         NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Fabricantes] PRIMARY KEY CLUSTERED ([FabricanteID] ASC)
);

CREATE TABLE [dbo].[Categorias] (
    [CategoriaID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [Nome]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Categorias] PRIMARY KEY CLUSTERED ([CategoriaID] ASC)
);