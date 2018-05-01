USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_ANNEE_FOR_DGV_CHOIX]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_ANNEE_FOR_DGV_CHOIX]
AS
BEGIN
	SELECT * 
	FROM ANNEE a
	WHERE (a.dateSupression is null )   
	ORDER BY a.descriptionAnnee
	
END
GO
