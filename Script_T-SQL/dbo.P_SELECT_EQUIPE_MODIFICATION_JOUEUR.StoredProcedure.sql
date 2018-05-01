USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_EQUIPE_MODIFICATION_JOUEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_EQUIPE_MODIFICATION_JOUEUR]
AS
BEGIN
	SELECT	CONCAT(nomEquipe ,' (' ,  villeEquipe , ')') as Equipe , idEquipe
	FROM EQUIPE
	WHERE dateSupression is null 
	ORDER BY nomEquipe
END
GO
