USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_MPD_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_MPD_PARIEUR]
	@adresseMail VARCHAR(250)
AS
BEGIN
	SELECT P.sel , P.hash , P.idPar
	FROM PARIEUR P 
	WHERE 
		(@adresseMail = p.courrielPar) and (P.dateSupression is null )
END
GO
