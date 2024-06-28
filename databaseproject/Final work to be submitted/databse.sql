/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     15/5/2024 1:17:29 AM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING_PAYMENT')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING_PAYMENT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING2_TRAIN_SE')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING2_TRAIN_SE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOKING') and o.name = 'FK_BOOKING_BOOKING3_USER')
alter table BOOKING
   drop constraint FK_BOOKING_BOOKING3_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CANCELS') and o.name = 'FK_CANCELS_CANCELS_USER')
alter table CANCELS
   drop constraint FK_CANCELS_CANCELS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CANCELS') and o.name = 'FK_CANCELS_CANCELS2_TRAIN_SE')
alter table CANCELS
   drop constraint FK_CANCELS_CANCELS2_TRAIN_SE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PAYMENT') and o.name = 'FK_PAYMENT_PAYS_USER')
alter table PAYMENT
   drop constraint FK_PAYMENT_PAYS_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRAIN_SEATS') and o.name = 'FK_TRAIN_SE_SEATING_TRAIN')
alter table TRAIN_SEATS
   drop constraint FK_TRAIN_SE_SEATING_TRAIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('TRIP') and o.name = 'FK_TRIP_CONSISTS_TRAIN')
alter table TRIP
   drop constraint FK_TRIP_CONSISTS_TRAIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING3_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOKING')
            and   name  = 'BOOKING_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOKING.BOOKING_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOKING')
            and   type = 'U')
   drop table BOOKING
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CANCELS')
            and   name  = 'CANCELS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CANCELS.CANCELS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CANCELS')
            and   name  = 'CANCELS_FK'
            and   indid > 0
            and   indid < 255)
   drop index CANCELS.CANCELS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CANCELS')
            and   type = 'U')
   drop table CANCELS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PAYMENT')
            and   name  = 'PAYS_FK'
            and   indid > 0
            and   indid < 255)
   drop index PAYMENT.PAYS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PAYMENT')
            and   type = 'U')
   drop table PAYMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAIN')
            and   type = 'U')
   drop table TRAIN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRAIN_SEATS')
            and   type = 'U')
   drop table TRAIN_SEATS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TRIP')
            and   name  = 'CONSISTS_FK'
            and   indid > 0
            and   indid < 255)
   drop index TRIP.CONSISTS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TRIP')
            and   type = 'U')
   drop table TRIP
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: BOOKING                                               */
/*==============================================================*/
create table BOOKING (
   PAYMENT_ID           int                  not null,
   TRANSACTION_ID       int                  not null,
   SEAT_NUMBER          int                  not null,
   USER_ID              int                  not null,
   BOOKING_ID           int                  not null,
   PRICE                float(53)           null,
   constraint PK_BOOKING primary key (PAYMENT_ID, TRANSACTION_ID, SEAT_NUMBER, USER_ID)
)
go

/*==============================================================*/
/* Index: BOOKING_FK                                            */
/*==============================================================*/
create index BOOKING_FK on BOOKING (
PAYMENT_ID ASC,
TRANSACTION_ID ASC
)
go

/*==============================================================*/
/* Index: BOOKING2_FK                                           */
/*==============================================================*/
create index BOOKING2_FK on BOOKING (
SEAT_NUMBER ASC
)
go

/*==============================================================*/
/* Index: BOOKING3_FK                                           */
/*==============================================================*/
create index BOOKING3_FK on BOOKING (
USER_ID ASC
)
go

/*==============================================================*/
/* Table: CANCELS                                               */
/*==============================================================*/
create table CANCELS (
   USER_ID              int                  not null,
   SEAT_NUMBER          int                  not null,
   CANCEL_ID            int                  not null,
   CANCELATION_DATE     datetime             null,
   constraint PK_CANCELS primary key (USER_ID, SEAT_NUMBER)
)
go

/*==============================================================*/
/* Index: CANCELS_FK                                            */
/*==============================================================*/
create index CANCELS_FK on CANCELS (
USER_ID ASC
)
go

/*==============================================================*/
/* Index: CANCELS2_FK                                           */
/*==============================================================*/
create index CANCELS2_FK on CANCELS (
SEAT_NUMBER ASC
)
go

/*==============================================================*/
/* Table: PAYMENT                                               */
/*==============================================================*/
create table PAYMENT (
   PAYMENT_ID           int                  not null,
   TRANSACTION_ID       int                  not null,
   USER_ID              int                  not null,
   AMOUNT               int                  null,
   METHOD               varchar(255)         null,
   CARD_NUMBER          int                  null,
   EXPIRY_DATE          datetime             null,
   PAYMENT_STATUS       varchar(255)         null,
   TRANSACTION_DATE     datetime             null,
   REFUND_DATE          datetime             null,
   REFUND_AMOUNT        int                  null,
   constraint PK_PAYMENT primary key nonclustered (PAYMENT_ID, TRANSACTION_ID)
)
go

/*==============================================================*/
/* Index: PAYS_FK                                               */
/*==============================================================*/
create index PAYS_FK on PAYMENT (
USER_ID ASC
)
go

/*==============================================================*/
/* Table: TRAIN                                                 */
/*==============================================================*/
create table TRAIN (
   TRAIN_ID             int                  not null,
   Trip_ID              int                  null,
   CAPACITY             int                  null,
   DEPARTUE_STATION     varchar(20)          null,
   constraint PK_TRAIN primary key nonclustered (TRAIN_ID)
)
go

/*==============================================================*/
/* Table: TRAIN_SEATS                                           */
/*==============================================================*/
create table TRAIN_SEATS (
   SEAT_NUMBER          int                  not null,
   TRAIN_ID             int                  not null,
   ROW                  int                  null,
   LANE                 char(5)              null,
   CLASS                varchar(20)          null,
   constraint PK_TRAIN_SEATS primary key nonclustered (SEAT_NUMBER)
)
go

/*==============================================================*/
/* Table: TRIP                                                  */
/*==============================================================*/
create table TRIP (
   TRIP_ID              int                  not null,
   TRAIN_ID             int                  not null,
   DURATION             int                  null,
   DEPARTURE_TIME       datetime             null,
   ARRIVAL_TIME         datetime             null,
   DISTANCE             int                  null,
   DESTINATION          varchar(255)         null,
   TRAIN_NUMBER         int                  null,
   constraint PK_TRIP primary key nonclustered (TRIP_ID)
)
go

/*==============================================================*/
/* Index: CONSISTS_FK                                           */
/*==============================================================*/
create index CONSISTS_FK on TRIP (
TRAIN_ID ASC
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USER_ID              int                  not null,
   NAME                 varchar(255)         null,
   LOCATION             varchar(255)         null,
   GENDER               varchar(255)         null,
   IS_ADMIN             bit                  null,
   PHONE_NUMBER         int                  null,
   COUNTRY_KEY          char(255)            null,
   constraint PK_USER primary key nonclustered (USER_ID)
)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING_PAYMENT foreign key (PAYMENT_ID, TRANSACTION_ID)
      references PAYMENT (PAYMENT_ID, TRANSACTION_ID)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING2_TRAIN_SE foreign key (SEAT_NUMBER)
      references TRAIN_SEATS (SEAT_NUMBER)
go

alter table BOOKING
   add constraint FK_BOOKING_BOOKING3_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

alter table CANCELS
   add constraint FK_CANCELS_CANCELS_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

alter table CANCELS
   add constraint FK_CANCELS_CANCELS2_TRAIN_SE foreign key (SEAT_NUMBER)
      references TRAIN_SEATS (SEAT_NUMBER)
go

alter table PAYMENT
   add constraint FK_PAYMENT_PAYS_USER foreign key (USER_ID)
      references "USER" (USER_ID)
go

alter table TRAIN_SEATS
   add constraint FK_TRAIN_SE_SEATING_TRAIN foreign key (TRAIN_ID)
      references TRAIN (TRAIN_ID)
go

alter table TRIP
   add constraint FK_TRIP_CONSISTS_TRAIN foreign key (TRAIN_ID)
      references TRAIN (TRAIN_ID)
go

