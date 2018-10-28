USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[spDeactiveNV]    Script Date: 10/28/2018 11:01:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spDeactiveNV]
@MANV char(8) ='8'
AS
BEGIN
	Update NHANVIEN
	set TRANG_THAI = 0 where MANV = @MANV
	exec [spDisableLogin] @MANV
END
