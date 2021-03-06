USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_AJOUTER_ANNEE]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_AJOUTER_ANNEE]
@descriptionAnnee VARCHAR(50),
@saisieEnCours BIT , 
@transfertJoueur BIT  


AS
BEGIN
	BEGIN TRY
	BEGIN TRANSACTION
	-- TRUE == transfert Joueur donc transaction 
		IF @saisieEnCours = 1 
		BEGIN
			UPDATE ANNEE SET SaisiEnCoursAnnee = 0 WHERE dateSupression is null 
		END

		If @transfertJoueur  =  1 
		Begin
			

			DECLARE @idJoueur INT  
			DECLARE @idEquipe INT  
			DECLARE @cote INT 
			DECLARE @buts INT
			DECLARE @passes INT
			DECLARE @idAnnee INT

			SET @idAnnee = (SELECT a.idAnnee FROM Annee a 
				where a.descriptionAnnee IN  
					(select MAX(descriptionAnnee)  
					 FROM Annee WHERE (dateSupression IS NULL) ))
			
			--ON AJOUTE l'annee
			INSERT INTO ANNEE(descriptionAnnee , SaisiEnCoursAnnee ) VALUES ( @descriptionAnnee , @saisieEnCours )

			DECLARE CurseurIdJoueur CURSOR FOR
				 SELECT j.idJoueur , j.idEquipe , j.cote , j.buts , j.passes
				 FROM JOUE j  	
				 JOIN ANNEE a On
				 a.idAnnee = j.idAnnee
				 --copie les Joueurs de l'annee avec la description la plus élevée 
				 WHERE a.idAnnee = @idAnnee 
				
			OPEN CurseurIdJoueur
			
			
			FETCH NEXT FROM CurseurIdJoueur INTO @idJoueur , @idEquipe , @cote,@buts,@passes

			
			WHILE @@FETCH_STATUS = 0
				BEGIN
					INSERT INTO JOUE VALUES (@idJoueur ,@idEquipe , (SELECT IDENT_CURRENT('ANNEE')) ,@cote , @buts ,@passes  )
					FETCH NEXT FROM CurseurIdJoueur INTO @idJoueur , @idEquipe , @cote,@buts,@passes
				END
			CLOSE CurseurIdJoueur

			-- on libère la mémoire
			DEALLOCATE CurseurIdJoueur

			END
		-- FALSE == non transfert des Joueur pas besoins de transaction 
		If @transfertJoueur  =  0
		BEGIN
			INSERT INTO ANNEE(descriptionAnnee , SaisiEnCoursAnnee ) VALUES ( @descriptionAnnee , @saisieEnCours )
			-- fermeture du curseur
		END
			
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
