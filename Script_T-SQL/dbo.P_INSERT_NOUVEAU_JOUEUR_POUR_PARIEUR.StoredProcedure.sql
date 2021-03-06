USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_INSERT_NOUVEAU_JOUEUR_POUR_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_INSERT_NOUVEAU_JOUEUR_POUR_PARIEUR]

	@idJoueur INT  , 
	@idParieur INT   ,
	@idAnnee INT ,
	@suppression BIT 

AS
BEGIN
IF	@suppression = 1 
	EXEC P_DELETE_JOUEUR_POUR_PARIEUR @idParieur , @idAnnee
ELSE
	INSERT INTO CHOISIT (idJoueur , idParieur , idAnnee )  VALUES ( @idJoueur ,@idParieur ,@idAnnee )	
	
END
GO
