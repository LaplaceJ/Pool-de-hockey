USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_INSERT_Parieur]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_INSERT_Parieur]
@nomParieur varchar(50) ,
@prenomParieur varchar(50) ,
@mail varchar(50) ,
@typePar int 



AS
BEGIN
	
INSERT INTO PARIEUR( prenomPar , nomPar , typePar , courrielPar) VALUES ( @prenomParieur , @nomParieur , @typePar , @mail ) 
	
END
GO
