USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_UPDATE_NOUVEAU_PASSWORD]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_UPDATE_NOUVEAU_PASSWORD]
	@idParieur INT   , 
	@NouveauSel VARCHAR(50) ,
	@NouveauHash VARCHAR(50)

AS
BEGIN
	UPDATE PARIEUR  
	SET sel = @NouveauSel , hash = @NouveauHash 

	WHERE (@idParieur = idPar ) and (dateSupression is null ) 
END
GO
