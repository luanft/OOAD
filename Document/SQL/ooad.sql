/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     1/8/2016 3:37:30 PM                          */
/*==============================================================*/


IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('CHITIETLICHTRINH') AND O.NAME = 'FK_CHITIETL_FK_LT_CTL_LICHTRIN')
ALTER TABLE CHITIETLICHTRINH
   DROP CONSTRAINT FK_CHITIETL_FK_LT_CTL_LICHTRIN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('CHITIETLICHTRINH') AND O.NAME = 'FK_CHITIETL_FK_CTLT_D_DOITAC')
ALTER TABLE CHITIETLICHTRINH
   DROP CONSTRAINT FK_CHITIETL_FK_CTLT_D_DOITAC
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('DIEMDULICH') AND O.NAME = 'FK_DIEMDULI_FK_NV_DDL_NHANVIEN')
ALTER TABLE DIEMDULICH
   DROP CONSTRAINT FK_DIEMDULI_FK_NV_DDL_NHANVIEN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('DOITAC') AND O.NAME = 'FK_DOITAC_FK_NV_DT_NHANVIEN')
ALTER TABLE DOITAC
   DROP CONSTRAINT FK_DOITAC_FK_NV_DT_NHANVIEN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('LICHTRINH') AND O.NAME = 'FK_LICHTRIN_FK_T_LT_TOUR')
ALTER TABLE LICHTRINH
   DROP CONSTRAINT FK_LICHTRIN_FK_T_LT_TOUR
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('NHANVIEN') AND O.NAME = 'FK_NHANVIEN_FK_MP_NV_PHONGBAN')
ALTER TABLE NHANVIEN
   DROP CONSTRAINT FK_NHANVIEN_FK_MP_NV_PHONGBAN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('TOUR') AND O.NAME = 'FK_TOUR_FK_NV_T_NHANVIEN')
ALTER TABLE TOUR
   DROP CONSTRAINT FK_TOUR_FK_NV_T_NHANVIEN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('TOUR') AND O.NAME = 'FK_TOUR_FK_T_KH_KHACHHAN')
ALTER TABLE TOUR
   DROP CONSTRAINT FK_TOUR_FK_T_KH_KHACHHAN
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('TOUR') AND O.NAME = 'FK_TOUR_HUONGDANV_DOITAC')
ALTER TABLE TOUR
   DROP CONSTRAINT FK_TOUR_HUONGDANV_DOITAC
go

IF EXISTS (SELECT 1
   FROM SYS.SYSREFERENCES R JOIN SYS.SYSOBJECTS O ON (O.ID = R.CONSTID AND O.TYPE = 'F')
   WHERE R.FKEYID = OBJECT_ID('TOUR') AND O.NAME = 'FK_TOUR_NHAXE_DOITAC')
ALTER TABLE TOUR
   DROP CONSTRAINT FK_TOUR_NHAXE_DOITAC
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('CHITIETLICHTRINH')
            AND   NAME  = 'FK_CTLT_DT_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX CHITIETLICHTRINH.FK_CTLT_DT_FK
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('CHITIETLICHTRINH')
            AND   NAME  = 'FK_LT_CTLT_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX CHITIETLICHTRINH.FK_LT_CTLT_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('CHITIETLICHTRINH')
            AND   TYPE = 'U')
   DROP TABLE CHITIETLICHTRINH
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('DIEMDULICH')
            AND   NAME  = 'FK_NV_DDL_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX DIEMDULICH.FK_NV_DDL_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('DIEMDULICH')
            AND   TYPE = 'U')
   DROP TABLE DIEMDULICH
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('DOITAC')
            AND   NAME  = 'FK_NV_DT_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX DOITAC.FK_NV_DT_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('DOITAC')
            AND   TYPE = 'U')
   DROP TABLE DOITAC
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('KHACHHANG')
            AND   TYPE = 'U')
   DROP TABLE KHACHHANG
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('LICHTRINH')
            AND   NAME  = 'FK_T_LT_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX LICHTRINH.FK_T_LT_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('LICHTRINH')
            AND   TYPE = 'U')
   DROP TABLE LICHTRINH
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('NHANVIEN')
            AND   NAME  = 'FK_MP_NV_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX NHANVIEN.FK_MP_NV_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('NHANVIEN')
            AND   TYPE = 'U')
   DROP TABLE NHANVIEN
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('PHONGBAN')
            AND   TYPE = 'U')
   DROP TABLE PHONGBAN
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('TOUR')
            AND   NAME  = 'NHAXE_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX TOUR.NHAXE_FK
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('TOUR')
            AND   NAME  = 'HUONGDANVIEN_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX TOUR.HUONGDANVIEN_FK
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('TOUR')
            AND   NAME  = 'FK_T_KH_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX TOUR.FK_T_KH_FK
go

IF EXISTS (SELECT 1
            FROM  SYSINDEXES
           WHERE  ID    = OBJECT_ID('TOUR')
            AND   NAME  = 'FK_NV_T_FK'
            AND   INDID > 0
            AND   INDID < 255)
   DROP INDEX TOUR.FK_NV_T_FK
go

IF EXISTS (SELECT 1
            FROM  SYSOBJECTS
           WHERE  ID = OBJECT_ID('TOUR')
            AND   TYPE = 'U')
   DROP TABLE TOUR
go

/*==============================================================*/
/* Table: CHITIETLICHTRINH                                      */
/*==============================================================*/
CREATE TABLE CHITIETLICHTRINH (
   MACHITIETLICHTRINH   INT                  NOT NULL,
   MALICHTRINH          INT                  NULL,
   MADOITAC             INT                  NULL,
   NOIDUNG              TEXT                 NULL,
   THOIGIAN             VARCHAR(5)           NULL,
   CONSTRAINT PK_CHITIETLICHTRINH PRIMARY KEY NONCLUSTERED (MACHITIETLICHTRINH)
)
go

/*==============================================================*/
/* Index: FK_LT_CTLT_FK                                         */
/*==============================================================*/
CREATE INDEX FK_LT_CTLT_FK ON CHITIETLICHTRINH (
MALICHTRINH ASC
)
go

/*==============================================================*/
/* Index: FK_CTLT_DT_FK                                         */
/*==============================================================*/
CREATE INDEX FK_CTLT_DT_FK ON CHITIETLICHTRINH (
MADOITAC ASC
)
go

/*==============================================================*/
/* Table: DIEMDULICH                                            */
/*==============================================================*/
CREATE TABLE DIEMDULICH (
   MADIEMDULICH         INT                  NOT NULL,
   MANHANVIEN           INT                  NULL,
   TENDIEMDULICH        TEXT                 NULL,
   MOTA                 TEXT                 NULL,
   CONSTRAINT PK_DIEMDULICH PRIMARY KEY NONCLUSTERED (MADIEMDULICH)
)
go

/*==============================================================*/
/* Index: FK_NV_DDL_FK                                          */
/*==============================================================*/
CREATE INDEX FK_NV_DDL_FK ON DIEMDULICH (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Table: DOITAC                                                */
/*==============================================================*/
CREATE TABLE DOITAC (
   MADOITAC             INT                  NOT NULL,
   MANHANVIEN           INT                  NULL,
   TENDOITAC            TEXT                 NULL,
   NGUOILIENHE          TEXT                 NULL,
   DIENTHOAI            VARCHAR(14)          NULL,
   DANHGIADOITAC        TEXT                 NULL,
   DIACHI               TEXT                 NULL,
   EMAIL                VARCHAR(100)         NULL,
   LOAIDOITAC           VARCHAR(20)          NULL,
   CONSTRAINT PK_DOITAC PRIMARY KEY NONCLUSTERED (MADOITAC)
)
go

/*==============================================================*/
/* Index: FK_NV_DT_FK                                           */
/*==============================================================*/
CREATE INDEX FK_NV_DT_FK ON DOITAC (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
CREATE TABLE KHACHHANG (
   MAKHACHHANG          INT                  NOT NULL,
   TENDONVI             TEXT                 NULL,
   NGUOIDAIDIEN         TEXT                 NULL,
   GIOITINH             VARCHAR(5)           NULL,
   EMAIL                VARCHAR(100)         NULL,
   DIENTHOAI            VARCHAR(14)          NULL,
   SONGUOI              INT                  NULL,
   DIACHI               TEXT                 NULL,
   LOAIKHACHHANG        VARCHAR(10)          NULL,
   CONSTRAINT PK_KHACHHANG PRIMARY KEY NONCLUSTERED (MAKHACHHANG)
)
go

/*==============================================================*/
/* Table: LICHTRINH                                             */
/*==============================================================*/
CREATE TABLE LICHTRINH (
   MALICHTRINH          INT                  NOT NULL,
   MATOUR               INT                  NULL,
   TENLICHTRINH         TEXT                 NULL,
   NGAY                 INT                  NULL,
   CONSTRAINT PK_LICHTRINH PRIMARY KEY NONCLUSTERED (MALICHTRINH)
)
go

/*==============================================================*/
/* Index: FK_T_LT_FK                                            */
/*==============================================================*/
CREATE INDEX FK_T_LT_FK ON LICHTRINH (
MATOUR ASC
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
CREATE TABLE NHANVIEN (
   MANHANVIEN           INT                  NOT NULL,
   MAPHONG              VARCHAR(5)           NULL,
   HOTEN                TEXT                 NULL,
   CMND                 VARCHAR(14)          NULL,
   DIACHI               TEXT                 NULL,
   NGAYSINH             DATETIME             NULL,
   QUEQUAN              TEXT                 NULL,
   SODT                 VARCHAR(14)          NULL,
   EMAIL                VARCHAR(50)          NULL,
   GIOITINH             VARCHAR(5)           NULL,
   CONSTRAINT PK_NHANVIEN PRIMARY KEY NONCLUSTERED (MANHANVIEN)
)
go

/*==============================================================*/
/* Index: FK_MP_NV_FK                                           */
/*==============================================================*/
CREATE INDEX FK_MP_NV_FK ON NHANVIEN (
MAPHONG ASC
)
go

/*==============================================================*/
/* Table: PHONGBAN                                              */
/*==============================================================*/
CREATE TABLE PHONGBAN (
   MAPHONG              VARCHAR(5)           NOT NULL,
   TENPHONG             TEXT                 NULL,
   CONSTRAINT PK_PHONGBAN PRIMARY KEY NONCLUSTERED (MAPHONG)
)
go

/*==============================================================*/
/* Table: TOUR                                                  */
/*==============================================================*/
CREATE TABLE TOUR (
   MATOUR               INT                  NOT NULL,
   MANHANVIEN           INT                  NULL,
   MAKHACHHANG          INT                  NOT NULL,
   NHAXE                INT                  NULL,
   HUONGDANVIEN         INT                  NULL,
   TENTOUR              TEXT                 NULL,
   THOIGIAN             TEXT                 NULL,
   NGAYDI               DATETIME             NULL,
   TONGGIATOUR          INT                  NULL,
   TRANGTHAI            VARCHAR(10)          NULL,
   UUDAI                TEXT                 NULL,
   GHICHU               TEXT                 NULL,
   CONSTRAINT PK_TOUR PRIMARY KEY NONCLUSTERED (MATOUR)
)
go

/*==============================================================*/
/* Index: FK_NV_T_FK                                            */
/*==============================================================*/
CREATE INDEX FK_NV_T_FK ON TOUR (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Index: FK_T_KH_FK                                            */
/*==============================================================*/
CREATE INDEX FK_T_KH_FK ON TOUR (
MAKHACHHANG ASC
)
go

/*==============================================================*/
/* Index: HUONGDANVIEN_FK                                       */
/*==============================================================*/
CREATE INDEX HUONGDANVIEN_FK ON TOUR (
NHAXE ASC
)
go

/*==============================================================*/
/* Index: NHAXE_FK                                              */
/*==============================================================*/
CREATE INDEX NHAXE_FK ON TOUR (
HUONGDANVIEN ASC
)
go

ALTER TABLE CHITIETLICHTRINH
   ADD CONSTRAINT FK_CHITIETL_FK_LT_CTL_LICHTRIN FOREIGN KEY (MALICHTRINH)
      REFERENCES LICHTRINH (MALICHTRINH)
go

ALTER TABLE CHITIETLICHTRINH
   ADD CONSTRAINT FK_CHITIETL_FK_CTLT_D_DOITAC FOREIGN KEY (MADOITAC)
      REFERENCES DOITAC (MADOITAC)
go

ALTER TABLE DIEMDULICH
   ADD CONSTRAINT FK_DIEMDULI_FK_NV_DDL_NHANVIEN FOREIGN KEY (MANHANVIEN)
      REFERENCES NHANVIEN (MANHANVIEN)
go

ALTER TABLE DOITAC
   ADD CONSTRAINT FK_DOITAC_FK_NV_DT_NHANVIEN FOREIGN KEY (MANHANVIEN)
      REFERENCES NHANVIEN (MANHANVIEN)
go

ALTER TABLE LICHTRINH
   ADD CONSTRAINT FK_LICHTRIN_FK_T_LT_TOUR FOREIGN KEY (MATOUR)
      REFERENCES TOUR (MATOUR)
go

ALTER TABLE NHANVIEN
   ADD CONSTRAINT FK_NHANVIEN_FK_MP_NV_PHONGBAN FOREIGN KEY (MAPHONG)
      REFERENCES PHONGBAN (MAPHONG)
go

ALTER TABLE TOUR
   ADD CONSTRAINT FK_TOUR_FK_NV_T_NHANVIEN FOREIGN KEY (MANHANVIEN)
      REFERENCES NHANVIEN (MANHANVIEN)
go

ALTER TABLE TOUR
   ADD CONSTRAINT FK_TOUR_FK_T_KH_KHACHHAN FOREIGN KEY (MAKHACHHANG)
      REFERENCES KHACHHANG (MAKHACHHANG)
go

ALTER TABLE TOUR
   ADD CONSTRAINT FK_TOUR_HUONGDANV_DOITAC FOREIGN KEY (NHAXE)
      REFERENCES DOITAC (MADOITAC)
go

ALTER TABLE TOUR
   ADD CONSTRAINT FK_TOUR_NHAXE_DOITAC FOREIGN KEY (HUONGDANVIEN)
      REFERENCES DOITAC (MADOITAC)
go

