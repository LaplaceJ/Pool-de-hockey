USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_TYPE_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_TYPE_PARIEUR]
@idParieur Int 
AS
BEGIN
	SELECT	typePar  
	FROM PARIEUR
	WHERE (idPar = @idParieur) and (dateSupression is null )  
END
GO
