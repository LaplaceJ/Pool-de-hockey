USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_JOUEUR_DGV_CHOIX]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_JOUEUR_DGV_CHOIX]
	@JoueurParieurSeulement TINYINT,
	@Annee INT,
	@IdParieur INT 

AS
BEGIN
	SELECT CONCAT(j.nomJoueur ,' ' ,  j.prenomJoueur) as Joueur ,CONCAT(t.nomEquipe ,' (' ,  t.villeEquipe , ')') as Equipe  , j.idPos as Pos, jou.cote as Cote , jou.buts as Buts ,jou.passes as Passes , (jou.passes + jou.buts) as Pts , j.idJoueur	

	From JOUEUR j
	JOIN JOUE jou
		On j.idJoueur = jou.idJoueur
	JOIN Position pos 
		on
		pos.idPos = j.idPos
	JOIN EQUIPE t
		On t.idEquipe = jou.idEquipe
	LEFT JOIN CHOISIT c
		On c.idJoueur = j.idJoueur
	
	Where

		(jou.idAnnee = @Annee)
		And
		((@JoueurParieurSeulement = 2) Or(c.idAnnee = @Annee))
		And
		((@JoueurParieurSeulement = 2) Or (c.idParieur = @idParieur))
		And
		(j.dateSuppression is null)
		and
		(t.dateSupression is null)

	GROUP BY j.prenomJoueur , j.nomJoueur , t.nomEquipe , t.villeEquipe , j.idPos , jou.buts , jou.cote ,jou.passes , j.idJoueur
	ORDER BY  Pts DESC , jou.cote  
END
GO
