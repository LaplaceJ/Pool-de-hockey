USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_UPDATE_JOUEUR_ET_JOUE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_UPDATE_JOUEUR_ET_JOUE]
@nomJoueur varchar(50) ,
@prenomJoueur varchar(50) ,
@idPos varchar(2) ,
@cote int ,
@buts int ,
@passes int ,
@idEquipe int ,
@idAnnee int  , 
@idJoueur int 


AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION

	UPDATE JOUEUR SET nomJoueur = @nomJoueur  , prenomJoueur = @prenomJoueur 
	, idPos = @idPos  WHERE (idJoueur = @idJoueur ) and (dateSuppression is null ) 

	UPDATE JOUE SET idEquipe = @idEquipe , cote = @cote , buts = @buts , passes = @passes 
	WHERE (idJoueur = @idJoueur) and (idAnnee = @idAnnee) 

	--DELETE FROM JOUE WHERE (idJoueur = @idJoueur) and (idAnnee = @idAnnee)
	COMMIT TRANSACTION

	END TRY
	BEGIN CATCH
	PRINT ''
	PRINT 'ERROR_NUMBER: ' + CONVERT(VARCHAR(10),ERROR_NUMBER())
	PRINT 'ERROR_MESSAGE: ' + ERROR_MESSAGE()
	PRINT 'ERROR_LINE: ' + CONVERT(VARCHAR(10),ERROR_LINE())
	PRINT 'ERROR_SEVERITY: ' + CONVERT(VARCHAR(10),ERROR_SEVERITY())
	PRINT 'ERROR_STATE: ' + CONVERT(VARCHAR(10),ERROR_STATE())


		ROLLBACK TRANSACTION
	END CATCH
END
GO
