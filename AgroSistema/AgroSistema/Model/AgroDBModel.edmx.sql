
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 08/05/2013 16:43:05
-- Generated from EDMX file: C:\Users\Win7VM\documents\visual studio 2012\Projects\AgroSistema\AgroSistema\Model\AgroDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [AgroDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsuariosAcesso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Acessoes] DROP CONSTRAINT [FK_UsuariosAcesso];
GO
IF OBJECT_ID(N'[dbo].[FK_AplicacaoProdutoAplicacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutoAplicacaos] DROP CONSTRAINT [FK_AplicacaoProdutoAplicacao];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasAplicacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aplicacaos] DROP CONSTRAINT [FK_FazendasAplicacao];
GO
IF OBJECT_ID(N'[dbo].[FK_ImplementosAplicacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Aplicacaos] DROP CONSTRAINT [FK_ImplementosAplicacao];
GO
IF OBJECT_ID(N'[dbo].[FK_CentrodeCustoProdDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdDocEntradas] DROP CONSTRAINT [FK_CentrodeCustoProdDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasCentrodeCusto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CentrodeCustoes] DROP CONSTRAINT [FK_FazendasCentrodeCusto];
GO
IF OBJECT_ID(N'[dbo].[FK_DocEntradaProdDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdDocEntradas] DROP CONSTRAINT [FK_DocEntradaProdDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_FornecedorDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocEntradas] DROP CONSTRAINT [FK_FornecedorDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_SafrasDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DocEntradas] DROP CONSTRAINT [FK_SafrasDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutosEstoque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Estoques] DROP CONSTRAINT [FK_ProdutosEstoque];
GO
IF OBJECT_ID(N'[dbo].[FK_SafrasEstoque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Estoques] DROP CONSTRAINT [FK_SafrasEstoque];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasFuncionarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Funcionarios] DROP CONSTRAINT [FK_FazendasFuncionarios];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasImplementos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Implementos] DROP CONSTRAINT [FK_FazendasImplementos];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasProdDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdDocEntradas] DROP CONSTRAINT [FK_FazendasProdDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasSafras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Safras] DROP CONSTRAINT [FK_FazendasSafras];
GO
IF OBJECT_ID(N'[dbo].[FK_FazendasTalhoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Talhoes] DROP CONSTRAINT [FK_FazendasTalhoes];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutosProdDocEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdDocEntradas] DROP CONSTRAINT [FK_ProdutosProdDocEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_Tipo_ProdutoProdutos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [FK_Tipo_ProdutoProdutos];
GO
IF OBJECT_ID(N'[dbo].[FK_UnidadeMedidasProdutos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [FK_UnidadeMedidasProdutos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Acessoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Acessoes];
GO
IF OBJECT_ID(N'[dbo].[Aplicacaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Aplicacaos];
GO
IF OBJECT_ID(N'[dbo].[CentrodeCustoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CentrodeCustoes];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[DocEntradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DocEntradas];
GO
IF OBJECT_ID(N'[dbo].[Estoques]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estoques];
GO
IF OBJECT_ID(N'[dbo].[Fazendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fazendas];
GO
IF OBJECT_ID(N'[dbo].[Fornecedors]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fornecedors];
GO
IF OBJECT_ID(N'[dbo].[Funcionarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Funcionarios];
GO
IF OBJECT_ID(N'[dbo].[Implementos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Implementos];
GO
IF OBJECT_ID(N'[dbo].[ProdDocEntradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdDocEntradas];
GO
IF OBJECT_ID(N'[dbo].[ProdutoAplicacaos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutoAplicacaos];
GO
IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO
IF OBJECT_ID(N'[dbo].[Safras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Safras];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Talhoes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Talhoes];
GO
IF OBJECT_ID(N'[dbo].[Tipo_Produto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tipo_Produto];
GO
IF OBJECT_ID(N'[dbo].[UnidadeMedidas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UnidadeMedidas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Acessoes'
CREATE TABLE [dbo].[Acessoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Modulo] nvarchar(max)  NOT NULL,
    [Alterar] bit  NOT NULL,
    [Visualizar] bit  NOT NULL,
    [Excluir] bit  NOT NULL,
    [Usuario_Id] int  NOT NULL
);
GO

-- Creating table 'Aplicacaos'
CREATE TABLE [dbo].[Aplicacaos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Data_Cadastro] datetime  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Data_Aplicacao] datetime  NOT NULL,
    [Finalizada] bit  NOT NULL,
    [AreaAplicada] int  NOT NULL,
    [Horas_incial] time  NOT NULL,
    [Horas_final] int  NOT NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL,
    [Implemento_Cod_Implementos] int  NOT NULL
);
GO

-- Creating table 'CentrodeCustoes'
CREATE TABLE [dbo].[CentrodeCustoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomeFantasia] nvarchar(max)  NOT NULL,
    [Cnpj] nvarchar(max)  NOT NULL,
    [IE] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [DataCadastro] datetime  NOT NULL,
    [Obs] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [RazaoSocial] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DocEntradas'
CREATE TABLE [dbo].[DocEntradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NDoc] nvarchar(max)  NOT NULL,
    [Serie] nvarchar(max)  NULL,
    [ChaveAcesso] nvarchar(max)  NULL,
    [DataEmissao] datetime  NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [Fornecedor_Cod_Fornecedor] int  NOT NULL,
    [Safra_Cod_Safra] int  NOT NULL
);
GO

-- Creating table 'Estoques'
CREATE TABLE [dbo].[Estoques] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantidade] int  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Produto_Cod_Produto] int  NOT NULL,
    [Safra_Cod_Safra] int  NOT NULL
);
GO

-- Creating table 'Fazendas'
CREATE TABLE [dbo].[Fazendas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome_fazenda] nvarchar(max)  NOT NULL,
    [Nome_Proprietario] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NULL,
    [UF] nvarchar(max)  NULL,
    [Telefone] nvarchar(max)  NULL,
    [Encarregado] nvarchar(max)  NULL,
    [Area_total] nvarchar(max)  NOT NULL,
    [Area_Agricola] nvarchar(max)  NOT NULL,
    [CPF_CNPJ] nvarchar(max)  NOT NULL,
    [IE] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Fornecedors'
CREATE TABLE [dbo].[Fornecedors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NomeFantasia] nvarchar(max)  NOT NULL,
    [Cnpj] nvarchar(max)  NOT NULL,
    [IE] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [DataCadastro] datetime  NOT NULL,
    [Obs] nvarchar(max)  NOT NULL,
    [Tipo_Fornecedor] nvarchar(max)  NOT NULL,
    [RazaoSocial] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Funcionarios'
CREATE TABLE [dbo].[Funcionarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cargo] nvarchar(max)  NOT NULL,
    [Nome_Funcionario] nvarchar(max)  NOT NULL,
    [Rg] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [UF] nvarchar(max)  NULL,
    [Data_Admissao] datetime  NOT NULL,
    [Data_Demissao] datetime  NULL,
    [Telefone] nvarchar(max)  NULL,
    [Salario_Atual] decimal(18,0)  NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL
);
GO

-- Creating table 'Implementos'
CREATE TABLE [dbo].[Implementos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL,
    [Ano] nvarchar(max)  NOT NULL,
    [Chassi] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Valor_Hora] decimal(18,0)  NOT NULL,
    [Data_Compra] datetime  NOT NULL,
    [Vendida] bit  NOT NULL,
    [Venda] decimal(18,0)  NOT NULL,
    [Placa] nvarchar(max)  NOT NULL,
    [Data_Venda] datetime  NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL
);
GO

-- Creating table 'ProdDocEntradas'
CREATE TABLE [dbo].[ProdDocEntradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorUnitario] decimal(18,0)  NOT NULL,
    [Quantidade] decimal(18,0)  NOT NULL,
    [Produto_Cod_Produto] int  NOT NULL,
    [CentrodeCusto_Cod_CentroCusto] int  NOT NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL,
    [DocEntrada_Cod_DocEntrada] int  NOT NULL
);
GO

-- Creating table 'ProdutoAplicacaos'
CREATE TABLE [dbo].[ProdutoAplicacaos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Produto] nvarchar(max)  NOT NULL,
    [Quantidade] nvarchar(max)  NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [Aplicacao_Cod_Aplicacao] int  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [PrecoCompra] decimal(18,0)  NOT NULL,
    [PrecoVenda] decimal(18,0)  NOT NULL,
    [Tipo_Produto_Cod_TipoProduto] int  NOT NULL,
    [UnidadeMedida_Cod_UnidadeMedida] int  NOT NULL
);
GO

-- Creating table 'Safras'
CREATE TABLE [dbo].[Safras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataInicio] datetime  NOT NULL,
    [DataFinal] datetime  NULL,
    [Curtivo] nvarchar(max)  NOT NULL,
    [TipoPlantio] nvarchar(max)  NOT NULL,
    [Finaliza] bit  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Talhoes'
CREATE TABLE [dbo].[Talhoes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Talhao] nvarchar(max)  NOT NULL,
    [Area] decimal(18,0)  NOT NULL,
    [Fazenda_Cod_Fazenda] int  NOT NULL
);
GO

-- Creating table 'Tipo_Produto'
CREATE TABLE [dbo].[Tipo_Produto] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TipoProduto] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UnidadeMedidas'
CREATE TABLE [dbo].[UnidadeMedidas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Unidade] nvarchar(max)  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [DataCadastro] datetime  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Acessoes'
ALTER TABLE [dbo].[Acessoes]
ADD CONSTRAINT [PK_Acessoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Aplicacaos'
ALTER TABLE [dbo].[Aplicacaos]
ADD CONSTRAINT [PK_Aplicacaos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CentrodeCustoes'
ALTER TABLE [dbo].[CentrodeCustoes]
ADD CONSTRAINT [PK_CentrodeCustoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DocEntradas'
ALTER TABLE [dbo].[DocEntradas]
ADD CONSTRAINT [PK_DocEntradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estoques'
ALTER TABLE [dbo].[Estoques]
ADD CONSTRAINT [PK_Estoques]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fazendas'
ALTER TABLE [dbo].[Fazendas]
ADD CONSTRAINT [PK_Fazendas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fornecedors'
ALTER TABLE [dbo].[Fornecedors]
ADD CONSTRAINT [PK_Fornecedors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [PK_Funcionarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Implementos'
ALTER TABLE [dbo].[Implementos]
ADD CONSTRAINT [PK_Implementos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProdDocEntradas'
ALTER TABLE [dbo].[ProdDocEntradas]
ADD CONSTRAINT [PK_ProdDocEntradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProdutoAplicacaos'
ALTER TABLE [dbo].[ProdutoAplicacaos]
ADD CONSTRAINT [PK_ProdutoAplicacaos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Safras'
ALTER TABLE [dbo].[Safras]
ADD CONSTRAINT [PK_Safras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'Talhoes'
ALTER TABLE [dbo].[Talhoes]
ADD CONSTRAINT [PK_Talhoes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tipo_Produto'
ALTER TABLE [dbo].[Tipo_Produto]
ADD CONSTRAINT [PK_Tipo_Produto]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UnidadeMedidas'
ALTER TABLE [dbo].[UnidadeMedidas]
ADD CONSTRAINT [PK_UnidadeMedidas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Usuario_Id] in table 'Acessoes'
ALTER TABLE [dbo].[Acessoes]
ADD CONSTRAINT [FK_UsuariosAcesso]
    FOREIGN KEY ([Usuario_Id])
    REFERENCES [dbo].[Usuarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UsuariosAcesso'
CREATE INDEX [IX_FK_UsuariosAcesso]
ON [dbo].[Acessoes]
    ([Usuario_Id]);
GO

-- Creating foreign key on [Aplicacao_Cod_Aplicacao] in table 'ProdutoAplicacaos'
ALTER TABLE [dbo].[ProdutoAplicacaos]
ADD CONSTRAINT [FK_AplicacaoProdutoAplicacao]
    FOREIGN KEY ([Aplicacao_Cod_Aplicacao])
    REFERENCES [dbo].[Aplicacaos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AplicacaoProdutoAplicacao'
CREATE INDEX [IX_FK_AplicacaoProdutoAplicacao]
ON [dbo].[ProdutoAplicacaos]
    ([Aplicacao_Cod_Aplicacao]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'Aplicacaos'
ALTER TABLE [dbo].[Aplicacaos]
ADD CONSTRAINT [FK_FazendasAplicacao]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasAplicacao'
CREATE INDEX [IX_FK_FazendasAplicacao]
ON [dbo].[Aplicacaos]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Implemento_Cod_Implementos] in table 'Aplicacaos'
ALTER TABLE [dbo].[Aplicacaos]
ADD CONSTRAINT [FK_ImplementosAplicacao]
    FOREIGN KEY ([Implemento_Cod_Implementos])
    REFERENCES [dbo].[Implementos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ImplementosAplicacao'
CREATE INDEX [IX_FK_ImplementosAplicacao]
ON [dbo].[Aplicacaos]
    ([Implemento_Cod_Implementos]);
GO

-- Creating foreign key on [CentrodeCusto_Cod_CentroCusto] in table 'ProdDocEntradas'
ALTER TABLE [dbo].[ProdDocEntradas]
ADD CONSTRAINT [FK_CentrodeCustoProdDocEntrada]
    FOREIGN KEY ([CentrodeCusto_Cod_CentroCusto])
    REFERENCES [dbo].[CentrodeCustoes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CentrodeCustoProdDocEntrada'
CREATE INDEX [IX_FK_CentrodeCustoProdDocEntrada]
ON [dbo].[ProdDocEntradas]
    ([CentrodeCusto_Cod_CentroCusto]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'CentrodeCustoes'
ALTER TABLE [dbo].[CentrodeCustoes]
ADD CONSTRAINT [FK_FazendasCentrodeCusto]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasCentrodeCusto'
CREATE INDEX [IX_FK_FazendasCentrodeCusto]
ON [dbo].[CentrodeCustoes]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [DocEntrada_Cod_DocEntrada] in table 'ProdDocEntradas'
ALTER TABLE [dbo].[ProdDocEntradas]
ADD CONSTRAINT [FK_DocEntradaProdDocEntrada]
    FOREIGN KEY ([DocEntrada_Cod_DocEntrada])
    REFERENCES [dbo].[DocEntradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DocEntradaProdDocEntrada'
CREATE INDEX [IX_FK_DocEntradaProdDocEntrada]
ON [dbo].[ProdDocEntradas]
    ([DocEntrada_Cod_DocEntrada]);
GO

-- Creating foreign key on [Fornecedor_Cod_Fornecedor] in table 'DocEntradas'
ALTER TABLE [dbo].[DocEntradas]
ADD CONSTRAINT [FK_FornecedorDocEntrada]
    FOREIGN KEY ([Fornecedor_Cod_Fornecedor])
    REFERENCES [dbo].[Fornecedors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FornecedorDocEntrada'
CREATE INDEX [IX_FK_FornecedorDocEntrada]
ON [dbo].[DocEntradas]
    ([Fornecedor_Cod_Fornecedor]);
GO

-- Creating foreign key on [Safra_Cod_Safra] in table 'DocEntradas'
ALTER TABLE [dbo].[DocEntradas]
ADD CONSTRAINT [FK_SafrasDocEntrada]
    FOREIGN KEY ([Safra_Cod_Safra])
    REFERENCES [dbo].[Safras]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SafrasDocEntrada'
CREATE INDEX [IX_FK_SafrasDocEntrada]
ON [dbo].[DocEntradas]
    ([Safra_Cod_Safra]);
GO

-- Creating foreign key on [Produto_Cod_Produto] in table 'Estoques'
ALTER TABLE [dbo].[Estoques]
ADD CONSTRAINT [FK_ProdutosEstoque]
    FOREIGN KEY ([Produto_Cod_Produto])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutosEstoque'
CREATE INDEX [IX_FK_ProdutosEstoque]
ON [dbo].[Estoques]
    ([Produto_Cod_Produto]);
GO

-- Creating foreign key on [Safra_Cod_Safra] in table 'Estoques'
ALTER TABLE [dbo].[Estoques]
ADD CONSTRAINT [FK_SafrasEstoque]
    FOREIGN KEY ([Safra_Cod_Safra])
    REFERENCES [dbo].[Safras]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SafrasEstoque'
CREATE INDEX [IX_FK_SafrasEstoque]
ON [dbo].[Estoques]
    ([Safra_Cod_Safra]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'Funcionarios'
ALTER TABLE [dbo].[Funcionarios]
ADD CONSTRAINT [FK_FazendasFuncionarios]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasFuncionarios'
CREATE INDEX [IX_FK_FazendasFuncionarios]
ON [dbo].[Funcionarios]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'Implementos'
ALTER TABLE [dbo].[Implementos]
ADD CONSTRAINT [FK_FazendasImplementos]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasImplementos'
CREATE INDEX [IX_FK_FazendasImplementos]
ON [dbo].[Implementos]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'ProdDocEntradas'
ALTER TABLE [dbo].[ProdDocEntradas]
ADD CONSTRAINT [FK_FazendasProdDocEntrada]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasProdDocEntrada'
CREATE INDEX [IX_FK_FazendasProdDocEntrada]
ON [dbo].[ProdDocEntradas]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'Safras'
ALTER TABLE [dbo].[Safras]
ADD CONSTRAINT [FK_FazendasSafras]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasSafras'
CREATE INDEX [IX_FK_FazendasSafras]
ON [dbo].[Safras]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Fazenda_Cod_Fazenda] in table 'Talhoes'
ALTER TABLE [dbo].[Talhoes]
ADD CONSTRAINT [FK_FazendasTalhoes]
    FOREIGN KEY ([Fazenda_Cod_Fazenda])
    REFERENCES [dbo].[Fazendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_FazendasTalhoes'
CREATE INDEX [IX_FK_FazendasTalhoes]
ON [dbo].[Talhoes]
    ([Fazenda_Cod_Fazenda]);
GO

-- Creating foreign key on [Produto_Cod_Produto] in table 'ProdDocEntradas'
ALTER TABLE [dbo].[ProdDocEntradas]
ADD CONSTRAINT [FK_ProdutosProdDocEntrada]
    FOREIGN KEY ([Produto_Cod_Produto])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutosProdDocEntrada'
CREATE INDEX [IX_FK_ProdutosProdDocEntrada]
ON [dbo].[ProdDocEntradas]
    ([Produto_Cod_Produto]);
GO

-- Creating foreign key on [Tipo_Produto_Cod_TipoProduto] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_Tipo_ProdutoProdutos]
    FOREIGN KEY ([Tipo_Produto_Cod_TipoProduto])
    REFERENCES [dbo].[Tipo_Produto]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tipo_ProdutoProdutos'
CREATE INDEX [IX_FK_Tipo_ProdutoProdutos]
ON [dbo].[Produtos]
    ([Tipo_Produto_Cod_TipoProduto]);
GO

-- Creating foreign key on [UnidadeMedida_Cod_UnidadeMedida] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_UnidadeMedidasProdutos]
    FOREIGN KEY ([UnidadeMedida_Cod_UnidadeMedida])
    REFERENCES [dbo].[UnidadeMedidas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UnidadeMedidasProdutos'
CREATE INDEX [IX_FK_UnidadeMedidasProdutos]
ON [dbo].[Produtos]
    ([UnidadeMedida_Cod_UnidadeMedida]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------