USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_DELETE_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_DELETE_PARIEUR]
@IdPar int 


AS
BEGIN
	
	UPDATE PARIEUR  SET dateSupression = GETDATE()  WHERE  idPar = @IdPar 	
END
GO
