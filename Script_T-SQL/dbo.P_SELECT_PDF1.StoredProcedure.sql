USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_PDF1]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_PDF1]
@idAnnee int 

AS
BEGIN
	SELECT   CONCAT(p.nomPar , ' ' , p.prenomPar ) nomParieur,  (SUM( jou.passes) + SUM(  jou.buts) ) as  points , p.idPar 
	from Parieur p 
		JOIN Choisit c  ON
		c.idParieur = p.idPar
		JOIN Joue jou ON
		jou.idJoueur = c.idJoueur
		AND
		jou.idAnnee = c.idAnnee
		JOIN Annee ON
		Annee.idAnnee = c.idAnnee
	WHERE  ( c.idAnnee = @idAnnee ) and (jou.idJoueur = c.idJoueur) and (p.dateSupression is null ) 
	GROUP BY p.nomPar ,  p.prenomPar , p.idPar
	ORDER BY points  desc ,  nomParieur 

END




GO
