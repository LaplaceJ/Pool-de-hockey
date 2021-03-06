USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_PDF2]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_PDF2]
@idParieur int ,
@idAnnee int 


AS
BEGIN
SELECT   j.nomJoueur , j.prenomJoueur  , jou.buts ,  jou.passes , (SUM( jou.passes) + SUM(jou.buts) ) as  points , e.nomEquipe , e.villeEquipe
		FROM Joue jou
		JOIN Annee a ON
		a.idAnnee = jou.idAnnee
		JOIN Joueur j ON
		j.idJoueur = jou.idJoueur
		JOIN EQUIPE e ON
			e.idEquipe = jou.idEquipe
	WHERE  (jou.idJoueur IN 
		(SELECT  c.idJoueur 
		FROM Choisit c
		JOIN ANNEE a
			ON a.idAnnee = c.idAnnee
		JOIN PARIEUR p 
			ON	p.idPar = c.idParieur
		JOIN JOUEUR j 
			ON j.idJoueur = c.idJoueur
		WHERE (c.idParieur = @idParieur) and (c.idAnnee = @idAnnee ) 
			and ( j.dateSuppression is null ) and (p.dateSupression is null ) 
			and(a.dateSupression is null )  ))
			 and
	 (jou.idAnnee =@idAnnee ) and (a.dateSupression is null )
			 and (j.dateSuppression is null ) and (e.dateSupression is  null ) 
	GROUP BY j.nomJoueur , j.prenomJoueur  , jou.buts ,  jou.passes ,  e.nomEquipe , e.villeEquipe

END
	

GO
