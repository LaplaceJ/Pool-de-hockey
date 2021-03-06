USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  Table [dbo].[PARAMETRE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PARAMETRE](
	[codeParam] [varchar](50) NOT NULL,
	[valeurParam] [int] NOT NULL,
 CONSTRAINT [PK_PARAMETRE] PRIMARY KEY CLUSTERED 
(
	[codeParam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
