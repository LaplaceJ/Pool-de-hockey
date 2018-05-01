USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_UPDATE_PARIEUR]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_UPDATE_PARIEUR]
@nomParieur varchar(50) ,
@prenomParieur varchar(50) ,
@mail varchar(50) ,
@typePar int,
@IdPar int


AS
BEGIN
	
	UPDATE PARIEUR SET prenomPar = @prenomParieur  , typePar = @typePar , nomPar = @nomParieur ,courrielPar = @mail 
	WHERE (idPar = @IdPar ) and (dateSupression is null ) 	
END
GO
