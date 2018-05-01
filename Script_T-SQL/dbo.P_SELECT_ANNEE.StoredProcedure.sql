USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_ANNEE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_ANNEE]

AS
BEGIN
	
	SELECT descriptionAnnee , SaisiEnCoursAnnee , idAnnee 
	FROM ANNEE
	WHERE dateSupression is null 
	ORDER BY descriptionAnnee
END
GO
