USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_INSERT_JOUEUR_ET_JOUE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_INSERT_JOUEUR_ET_JOUE]
@nomJoueur varchar(50) ,
@prenomJoueur varchar(50) ,
@idPos varchar(2) ,
@cote int ,
@buts int ,
@passes int ,
@idEquipe int ,
@idAnnee int 


AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION
	INSERT INTO JOUEUR (prenomJoueur , nomJoueur , dateSuppression , idPos) VALUES ( @prenomJoueur , @nomJoueur , null , @idPos ) 

	INSERT INTO JOUE VALUES ((SELECT IDENT_CURRENT('JOUEUR') ) ,@idEquipe , @idAnnee ,@cote , @buts ,@passes  )

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
