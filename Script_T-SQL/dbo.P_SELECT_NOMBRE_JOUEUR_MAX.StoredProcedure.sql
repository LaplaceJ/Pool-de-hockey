USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_NOMBRE_JOUEUR_MAX]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_NOMBRE_JOUEUR_MAX] 
AS
BEGIN
	SELECT valeurParam
	FROM PARAMETRE
	WHERE codeParam LIKE 'nombreMaximunDeJoueur'
END
GO
