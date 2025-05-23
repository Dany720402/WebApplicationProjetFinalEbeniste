USE [DB_PRODUIT]
GO
/****** Object:  Table [dbo].[Meubles]    Script Date: 2025-04-28 19:19:38 ******/
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
ALTER TABLE [dbo].[Meubles]  WITH CHECK ADD  CONSTRAINT [FK_Meubles_Styles_StyleID] FOREIGN KEY([StyleID])
REFERENCES [dbo].[Styles] ([StyleID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Meubles] CHECK CONSTRAINT [FK_Meubles_Styles_StyleID]
GO
