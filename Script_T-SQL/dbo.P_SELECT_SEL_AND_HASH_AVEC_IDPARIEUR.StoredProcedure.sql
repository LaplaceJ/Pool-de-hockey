USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_SEL_AND_HASH_AVEC_IDPARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_SEL_AND_HASH_AVEC_IDPARIEUR]
@idParieur int 
AS
BEGIN
	SELECT	sel , hash 
	FROM PARIEUR
	WHERE (idPar = @idParieur ) and (dateSupression is null ) 
END
GO
