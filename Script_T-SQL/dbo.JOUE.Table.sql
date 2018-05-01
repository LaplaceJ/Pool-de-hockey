USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  Table [dbo].[JOUE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JOUE](
	[idJoueur] [int] NOT NULL,
	[idEquipe] [int] NOT NULL,
	[idAnnee] [int] NOT NULL,
	[cote] [int] NOT NULL CONSTRAINT [DF_JOUE_cote]  DEFAULT ((0)),
	[buts] [int] NOT NULL,
	[passes] [int] NOT NULL,
 CONSTRAINT [PK_JOUE] PRIMARY KEY CLUSTERED 
(
	[idJoueur] ASC,
	[idEquipe] ASC,
	[idAnnee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[JOUE]  WITH CHECK ADD  CONSTRAINT [FK_JOUE_ANNEE] FOREIGN KEY([idAnnee])
REFERENCES [dbo].[ANNEE] ([idAnnee])
GO
ALTER TABLE [dbo].[JOUE] CHECK CONSTRAINT [FK_JOUE_ANNEE]
GO
ALTER TABLE [dbo].[JOUE]  WITH CHECK ADD  CONSTRAINT [FK_JOUE_EQUIPE] FOREIGN KEY([idEquipe])
REFERENCES [dbo].[EQUIPE] ([idEquipe])
GO
ALTER TABLE [dbo].[JOUE] CHECK CONSTRAINT [FK_JOUE_EQUIPE]
GO
ALTER TABLE [dbo].[JOUE]  WITH CHECK ADD  CONSTRAINT [FK_JOUE_JOUEUR] FOREIGN KEY([idJoueur])
REFERENCES [dbo].[JOUEUR] ([idJoueur])
GO
ALTER TABLE [dbo].[JOUE] CHECK CONSTRAINT [FK_JOUE_JOUEUR]
GO
