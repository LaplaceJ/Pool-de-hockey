USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_NOM_PRENOM_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_NOM_PRENOM_PARIEUR]
	@IdParieur INT 

AS
BEGIN
	SELECT CONCAT(p.nomPar ,', ' , p.prenomPar ) 	

	FROM PARIEUR p 
	WHERE 
		(p.idPar = @IdParieur) and
		(p.dateSupression is null )  
END
GO
