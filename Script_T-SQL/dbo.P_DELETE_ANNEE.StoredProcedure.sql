USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_DELETE_ANNEE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_DELETE_ANNEE]
@idAnnee INT   
AS
BEGIN
	UPDATE ANNEE 
	 SET dateSupression = GETDATE()  
	WHERE (@idAnnee = idAnnee ) 
END
GO
