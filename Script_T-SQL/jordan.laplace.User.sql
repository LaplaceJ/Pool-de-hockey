USE [A2016_BDDCS_LaplaceJordan]
GO
/****** Object:  User [jordan.laplace]    Script Date: 13/12/2016 20:35:50 ******/
CREATE USER [jordan.laplace] FOR LOGIN [jordan.laplace] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [jordan.laplace]
GO
