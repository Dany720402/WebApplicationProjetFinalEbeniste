USE [DB_PRODUIT]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Telephone] [nvarchar](20) NULL,
	[Adresse] [nvarchar](500) NULL,
	[MotdePasse] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](255) NOT NULL,
	[Prenom] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Message] [nvarchar](500) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meubles]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meubles](
	[MeubleID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](255) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[StyleID] [int] NOT NULL,
	[Prix] [float] NULL,
	[TypeDeBois] [nvarchar](100) NULL,
	[DateCreation] [datetime2](7) NULL,
	[ImageURL] [nvarchar](500) NULL,
 CONSTRAINT [PK_Meubles] PRIMARY KEY CLUSTERED 
(
	[MeubleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[UserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersItems]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [int] NOT NULL,
	[Price] [float] NOT NULL,
	[MeubleID] [int] NOT NULL,
	[OrderId] [int] NOT NULL,
 CONSTRAINT [PK_OrdersItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShoppingCarItems]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShoppingCarItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MeubleID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[ShoppingCartId] [nvarchar](max) NULL,
 CONSTRAINT [PK_ShoppingCarItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 2025-04-27 20:52:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Styles](
	[StyleID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Styles] PRIMARY KEY CLUSTERED 
(
	[StyleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT (N'') FOR [MotdePasse]
GO
ALTER TABLE [dbo].[Meubles]  WITH CHECK ADD  CONSTRAINT [FK_Meubles_Styles_StyleID] FOREIGN KEY([StyleID])
REFERENCES [dbo].[Styles] ([StyleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Meubles] CHECK CONSTRAINT [FK_Meubles_Styles_StyleID]
GO
ALTER TABLE [dbo].[OrdersItems]  WITH CHECK ADD  CONSTRAINT [FK_OrdersItems_Meubles_MeubleID] FOREIGN KEY([MeubleID])
REFERENCES [dbo].[Meubles] ([MeubleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdersItems] CHECK CONSTRAINT [FK_OrdersItems_Meubles_MeubleID]
GO
ALTER TABLE [dbo].[OrdersItems]  WITH CHECK ADD  CONSTRAINT [FK_OrdersItems_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrdersItems] CHECK CONSTRAINT [FK_OrdersItems_Orders_OrderId]
GO
ALTER TABLE [dbo].[ShoppingCarItems]  WITH CHECK ADD  CONSTRAINT [FK_ShoppingCarItems_Meubles_MeubleID] FOREIGN KEY([MeubleID])
REFERENCES [dbo].[Meubles] ([MeubleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ShoppingCarItems] CHECK CONSTRAINT [FK_ShoppingCarItems_Meubles_MeubleID]
GO
