USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_UPDATE_ANNEE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_UPDATE_ANNEE]
@idAnnee INT   , 
@descriptionAnnee VARCHAR(50) ,
@saisiEnCours BIT 
AS
BEGIN
	IF @saisiEnCours = 1  
	BEGIN
		--toute les autres saisis sont mis a null 
		UPDATE ANNEE SET SaisiEnCoursAnnee  = 0 where dateSupression is null 
	END
		UPDATE ANNEE  
		SET descriptionAnnee = @descriptionAnnee , SaisiEnCoursAnnee = @saisiEnCours 
		WHERE (@idAnnee = idAnnee ) and (dateSupression is null ) 
END
GO
