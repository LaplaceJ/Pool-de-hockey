USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_lastIdModifierInserer]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_lastIdModifierInserer]

AS
BEGIN
	
	SELECT valeurParam 
	FROM PARAMETRE
	WHERE codeParam = 'idApresModAjout'
END
GO
