USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  StoredProcedure [dbo].[P_SELECT_PARIEUR_DGV]    Script Date: 13/12/2016 20:35:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[P_SELECT_PARIEUR_DGV] 
AS
BEGIN
	SELECT	CONCAT(p.nomPar , ',' , p.prenomPar) as Parieur , r.defRef as Type , p.courrielPar as Courriel , p.idPar
	FROM PARIEUR p 
	JOIN REF_PARIEUR r ON
		r.typePar = p.typePar 
	WHERE (p.dateSupression is null ) 
	GROUP BY r.defRef , p.courrielPar , p.prenomPar ,  p.nomPar , p.typePar , p.idPar
	ORDER BY p.nomPar 
END
GO
