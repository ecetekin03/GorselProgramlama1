USE [GP]
GO
/****** Object:  Table [dbo].[Kisiler]    Script Date: 14.04.2025 21:35:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisiler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Gun] [int] NULL,
	[Ay] [nvarchar](20) NULL,
	[Yil] [int] NULL,
	[Burc] [nvarchar](20) NULL,
	[Yorum] [nvarchar](255) NULL,
	[BurcResmi] [nvarchar](255) NULL,
	[VKI] [float] NULL,
	[VKIYorum] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
