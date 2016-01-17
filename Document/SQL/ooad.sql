/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     1/12/2016 8:59:45 AM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHITIETLICHTRINH') and o.name = 'FK_CHITIETL_FK_LT_CTL_LICHTRIN')
alter table CHITIETLICHTRINH
   drop constraint FK_CHITIETL_FK_LT_CTL_LICHTRIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CHITIETLICHTRINH') and o.name = 'FK_CHITIETL_FK_CTLT_D_DOITAC')
alter table CHITIETLICHTRINH
   drop constraint FK_CHITIETL_FK_CTLT_D_DOITAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DIEMDULICH') and o.name = 'FK_DIEMDULI_FK_NV_DDL_NHANVIEN')
alter table DIEMDULICH
   drop constraint FK_DIEMDULI_FK_NV_DDL_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DOITAC') and o.name = 'FK_DOITAC_FK_NV_DT_NHANVIEN')
alter table DOITAC
   drop constraint FK_DOITAC_FK_NV_DT_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LICHTRINH') and o.name = 'FK_LICHTRIN_FK_T_LT_TOUR')
alter table LICHTRINH
   drop constraint FK_LICHTRIN_FK_T_LT_TOUR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('NHANVIEN') and o.name = 'FK_NHANVIEN_FK_MP_NV_PHONGBAN')
alter table NHANVIEN
   drop constraint FK_NHANVIEN_FK_MP_NV_PHONGBAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TOUR') and o.name = 'FK_TOUR_FK_NV_T_NHANVIEN')
alter table TOUR
   drop constraint FK_TOUR_FK_NV_T_NHANVIEN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TOUR') and o.name = 'FK_TOUR_FK_T_KH_KHACHHAN')
alter table TOUR
   drop constraint FK_TOUR_FK_T_KH_KHACHHAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TOUR') and o.name = 'FK_TOUR_HUONGDANV_DOITAC')
alter table TOUR
   drop constraint FK_TOUR_HUONGDANV_DOITAC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TOUR') and o.name = 'FK_TOUR_NHAXE_DOITAC')
alter table TOUR
   drop constraint FK_TOUR_NHAXE_DOITAC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHITIETLICHTRINH')
            and   name  = 'FK_CTLT_DT_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHITIETLICHTRINH.FK_CTLT_DT_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHITIETLICHTRINH')
            and   name  = 'FK_LT_CTLT_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHITIETLICHTRINH.FK_LT_CTLT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHITIETLICHTRINH')
            and   type = 'U')
   drop table CHITIETLICHTRINH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DIEMDULICH')
            and   name  = 'FK_NV_DDL_FK'
            and   indid > 0
            and   indid < 255)
   drop index DIEMDULICH.FK_NV_DDL_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DIEMDULICH')
            and   type = 'U')
   drop table DIEMDULICH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DOITAC')
            and   name  = 'FK_NV_DT_FK'
            and   indid > 0
            and   indid < 255)
   drop index DOITAC.FK_NV_DT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DOITAC')
            and   type = 'U')
   drop table DOITAC
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHACHHANG')
            and   type = 'U')
   drop table KHACHHANG
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LICHTRINH')
            and   name  = 'FK_T_LT_FK'
            and   indid > 0
            and   indid < 255)
   drop index LICHTRINH.FK_T_LT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LICHTRINH')
            and   type = 'U')
   drop table LICHTRINH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('NHANVIEN')
            and   name  = 'FK_MP_NV_FK'
            and   indid > 0
            and   indid < 255)
   drop index NHANVIEN.FK_MP_NV_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('NHANVIEN')
            and   type = 'U')
   drop table NHANVIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONGBAN')
            and   type = 'U')
   drop table PHONGBAN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TOUR')
            and   name  = 'NHAXE_FK'
            and   indid > 0
            and   indid < 255)
   drop index TOUR.NHAXE_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TOUR')
            and   name  = 'HUONGDANVIEN_FK'
            and   indid > 0
            and   indid < 255)
   drop index TOUR.HUONGDANVIEN_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TOUR')
            and   name  = 'FK_T_KH_FK'
            and   indid > 0
            and   indid < 255)
   drop index TOUR.FK_T_KH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TOUR')
            and   name  = 'FK_NV_T_FK'
            and   indid > 0
            and   indid < 255)
   drop index TOUR.FK_NV_T_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TOUR')
            and   type = 'U')
   drop table TOUR
go

/*==============================================================*/
/* Table: CHITIETLICHTRINH                                      */
/*==============================================================*/
create table CHITIETLICHTRINH (
   MACHITIETLICHTRINH   int                  not null IDENTITY( 1, 1 ),
   MADOITAC             int                  null,
   MALICHTRINH          int                  null,
   NOIDUNG              NVARCHAR(1000)                 null,
   THOIGIAN             varchar(5)           null,
   constraint PK_CHITIETLICHTRINH primary key nonclustered (MACHITIETLICHTRINH)
)
go

/*==============================================================*/
/* Index: FK_LT_CTLT_FK                                         */
/*==============================================================*/
create index FK_LT_CTLT_FK on CHITIETLICHTRINH (
MALICHTRINH ASC
)
go

/*==============================================================*/
/* Index: FK_CTLT_DT_FK                                         */
/*==============================================================*/
create index FK_CTLT_DT_FK on CHITIETLICHTRINH (
MADOITAC ASC
)
go

/*==============================================================*/
/* Table: DIEMDULICH                                            */
/*==============================================================*/
create table DIEMDULICH (
   MADIEMDULICH         int                  not null IDENTITY( 1, 1 ),
   MANHANVIEN           int                  null,
   TENDIEMDULICH        NVARCHAR(1000)                 null,
   MOTA                 NVARCHAR(1000)                 null,
   constraint PK_DIEMDULICH primary key nonclustered (MADIEMDULICH)
)
go

/*==============================================================*/
/* Index: FK_NV_DDL_FK                                          */
/*==============================================================*/
create index FK_NV_DDL_FK on DIEMDULICH (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Table: DOITAC                                                */
/*==============================================================*/
create table DOITAC (
   MADOITAC             int                  not null IDENTITY( 1, 1 ),
   MANHANVIEN           int                  null,
   TENDOITAC            NVARCHAR(1000)                 null,
   NGUOILIENHE          NVARCHAR(1000)                 null,
   DIENTHOAI            varchar(14)          null,
   DANHGIADOITAC        NVARCHAR(1000)                 null,
   DIACHI               NVARCHAR(1000)                 null,
   EMAIL                varchar(100)         null,
   LOAIDOITAC           varchar(20)          null,
   constraint PK_DOITAC primary key nonclustered (MADOITAC)
)
go

/*==============================================================*/
/* Index: FK_NV_DT_FK                                           */
/*==============================================================*/
create index FK_NV_DT_FK on DOITAC (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Table: KHACHHANG                                             */
/*==============================================================*/
create table KHACHHANG (
   MAKHACHHANG          int                  not null IDENTITY( 1, 1 ),
   MANHANVIEN			int					 not null,
   TENDONVI             NVARCHAR(1000)                 null,
   NGUOIDAIDIEN         NVARCHAR(1000)                 null,
   GIOITINH             varchar(5)           null,
   EMAIL                varchar(100)         null,
   DIENTHOAI            varchar(14)          null,
   SONGUOI              int                  null,
   DIACHI               NVARCHAR(1000)                 null,
   LOAIKHACHHANG        varchar(10)          null,
   constraint PK_KHACHHANG primary key nonclustered (MAKHACHHANG)
)
go

/*==============================================================*/
/* Table: LICHTRINH                                             */
/*==============================================================*/
create table LICHTRINH (
   MALICHTRINH          int                  not null IDENTITY( 1, 1 ),
   MATOUR               int                  null,
   TENLICHTRINH         NVARCHAR(1000)                 null,
   NGAY                 int                  null,
   constraint PK_LICHTRINH primary key nonclustered (MALICHTRINH)
)
go

/*==============================================================*/
/* Index: FK_T_LT_FK                                            */
/*==============================================================*/
create index FK_T_LT_FK on LICHTRINH (
MATOUR ASC
)
go

/*==============================================================*/
/* Table: NHANVIEN                                              */
/*==============================================================*/
create table NHANVIEN (
   MANHANVIEN           int                  not null IDENTITY( 1, 1 ),
   MAPHONG              varchar(5)           null,
   HOTEN                NVARCHAR(1000)                 null,
   CMND                 varchar(14)          null,
   DIACHI               NVARCHAR(1000)                 null,
   NGAYSINH             datetime             null,
   QUEQUAN              NVARCHAR(1000)                 null,
   SODT                 varchar(14)          null,
   EMAIL                varchar(50)          null,
   GIOITINH             varchar(5)           null,
   MatKhau              char(25)             null,
   constraint PK_NHANVIEN primary key nonclustered (MANHANVIEN)
)
go

/*==============================================================*/
/* Index: FK_MP_NV_FK                                           */
/*==============================================================*/
create index FK_MP_NV_FK on NHANVIEN (
MAPHONG ASC
)
go

/*==============================================================*/
/* Table: PHONGBAN                                              */
/*==============================================================*/
create table PHONGBAN (
   MAPHONG              varchar(5)           not null,
   TENPHONG             NVARCHAR(1000)                 null,
   constraint PK_PHONGBAN primary key nonclustered (MAPHONG)
)
go

/*==============================================================*/
/* Table: TOUR                                                  */
/*==============================================================*/
create table TOUR (
   MATOUR               int                  not null IDENTITY( 1, 1 ),
   HUONGDANVIEN         int                  null,
   MAKHACHHANG          int                  not null,
   NHAXE                int                  null,
   MANHANVIEN           int                  null,
   TENTOUR              NVARCHAR(1000)                 null,
   THOIGIAN             NVARCHAR(1000)                 null,
   NGAYDI               datetime             null,
   TONGGIATOUR          int                  null,
   TRANGTHAI            varchar(10)          null,
   UUDAI                NVARCHAR(1000)                 null,
   GHICHU               NVARCHAR(1000)                 null,
   NgayLapTour          datetime             null,
   constraint PK_TOUR primary key nonclustered (MATOUR)
)
go

/*==============================================================*/
/* Index: FK_NV_T_FK                                            */
/*==============================================================*/
create index FK_NV_T_FK on TOUR (
MANHANVIEN ASC
)
go

/*==============================================================*/
/* Index: FK_T_KH_FK                                            */
/*==============================================================*/
create index FK_T_KH_FK on TOUR (
MAKHACHHANG ASC
)
go

/*==============================================================*/
/* Index: HUONGDANVIEN_FK                                       */
/*==============================================================*/
create index HUONGDANVIEN_FK on TOUR (
HUONGDANVIEN ASC
)
go

/*==============================================================*/
/* Index: NHAXE_FK                                              */
/*==============================================================*/
create index NHAXE_FK on TOUR (
NHAXE ASC
)
go

alter table CHITIETLICHTRINH
   add constraint FK_CHITIETL_FK_LT_CTL_LICHTRIN foreign key (MALICHTRINH)
      references LICHTRINH (MALICHTRINH)
go

alter table CHITIETLICHTRINH
   add constraint FK_CHITIETL_FK_CTLT_D_DOITAC foreign key (MADOITAC)
      references DOITAC (MADOITAC)
go

alter table DIEMDULICH
   add constraint FK_DIEMDULI_FK_NV_DDL_NHANVIEN foreign key (MANHANVIEN)
      references NHANVIEN (MANHANVIEN)
go

alter table DOITAC
   add constraint FK_DOITAC_FK_NV_DT_NHANVIEN foreign key (MANHANVIEN)
      references NHANVIEN (MANHANVIEN)
go

alter table LICHTRINH
   add constraint FK_LICHTRIN_FK_T_LT_TOUR foreign key (MATOUR)
      references TOUR (MATOUR)
go

alter table NHANVIEN
   add constraint FK_NHANVIEN_FK_MP_NV_PHONGBAN foreign key (MAPHONG)
      references PHONGBAN (MAPHONG)
go

alter table TOUR
   add constraint FK_TOUR_FK_NV_T_NHANVIEN foreign key (MANHANVIEN)
      references NHANVIEN (MANHANVIEN)
go

alter table TOUR
   add constraint FK_TOUR_FK_T_KH_KHACHHAN foreign key (MAKHACHHANG)
      references KHACHHANG (MAKHACHHANG)
go

alter table TOUR
   add constraint FK_TOUR_HUONGDANV_DOITAC foreign key (HUONGDANVIEN)
      references DOITAC (MADOITAC)
go

alter table TOUR
   add constraint FK_TOUR_NHAXE_DOITAC foreign key (NHAXE)
      references DOITAC (MADOITAC)
go

alter table KHACHHANG
   add constraint FK_LICHTRIN_FK_T_LT_KH foreign key (MANHANVIEN)
      references NHANVIEN (MANHANVIEN)
go

