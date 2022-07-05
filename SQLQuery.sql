/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/30/2022 10:05:36 PM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_HOLDBY_CUSTOMER')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_HOLDBY_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ACCOUNT') and o.name = 'FK_ACCOUNT_MAINTAIN_BRANCH')
alter table ACCOUNT
   drop constraint FK_ACCOUNT_MAINTAIN_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADD_LOAN') and o.name = 'FK_ADD_LOAN_ADD_LOAN_LOAN')
alter table ADD_LOAN
   drop constraint FK_ADD_LOAN_ADD_LOAN_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADD_LOAN') and o.name = 'FK_ADD_LOAN_ADD_LOAN2_EMPLOYEE')
alter table ADD_LOAN
   drop constraint FK_ADD_LOAN_ADD_LOAN2_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AVAILEDBY') and o.name = 'FK_AVAILEDB_AVAILEDBY_LOAN')
alter table AVAILEDBY
   drop constraint FK_AVAILEDB_AVAILEDBY_LOAN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('AVAILEDBY') and o.name = 'FK_AVAILEDB_AVAILEDBY_CUSTOMER')
alter table AVAILEDBY
   drop constraint FK_AVAILEDB_AVAILEDBY_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BANK') and o.name = 'FK_BANK_ADD_BANK_ADMIN')
alter table BANK
   drop constraint FK_BANK_ADD_BANK_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_ADD_BRANC_ADMIN')
alter table BRANCH
   drop constraint FK_BRANCH_ADD_BRANC_ADMIN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_HAS_A_BANK')
alter table BRANCH
   drop constraint FK_BRANCH_HAS_A_BANK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CUTOMER_PHONE') and o.name = 'FK_CUTOMER__HASA_CUSTOMER')
alter table CUTOMER_PHONE
   drop constraint FK_CUTOMER__HASA_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORK_FOR_BRANCH')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORK_FOR_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE_PHONE') and o.name = 'FK_EMPLOYEE_OWN_EMPLOYEE')
alter table EMPLOYEE_PHONE
   drop constraint FK_EMPLOYEE_OWN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('LOAN') and o.name = 'FK_LOAN_OFFER_BRANCH')
alter table LOAN
   drop constraint FK_LOAN_OFFER_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'HOLDBY_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.HOLDBY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ACCOUNT')
            and   name  = 'MAINTAIN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ACCOUNT.MAINTAIN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADD_LOAN')
            and   name  = 'ADD_LOAN2_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADD_LOAN.ADD_LOAN2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADD_LOAN')
            and   name  = 'ADD_LOAN_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADD_LOAN.ADD_LOAN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADD_LOAN')
            and   type = 'U')
   drop table ADD_LOAN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AVAILEDBY')
            and   name  = 'AVAILEDBY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index AVAILEDBY.AVAILEDBY2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('AVAILEDBY')
            and   name  = 'AVAILEDBY_FK'
            and   indid > 0
            and   indid < 255)
   drop index AVAILEDBY.AVAILEDBY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AVAILEDBY')
            and   type = 'U')
   drop table AVAILEDBY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANK')
            and   name  = 'ADD_BANK_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANK.ADD_BANK_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANK')
            and   type = 'U')
   drop table BANK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'ADD_BRANCH_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.ADD_BRANCH_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'HAS_A_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.HAS_A_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CUTOMER_PHONE')
            and   name  = 'HASA_FK'
            and   indid > 0
            and   indid < 255)
   drop index CUTOMER_PHONE.HASA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUTOMER_PHONE')
            and   type = 'U')
   drop table CUTOMER_PHONE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORK_FOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORK_FOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE_PHONE')
            and   name  = 'OWN_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE_PHONE.OWN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE_PHONE')
            and   type = 'U')
   drop table EMPLOYEE_PHONE
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOAN')
            and   name  = 'OFFER_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOAN.OFFER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAN')
            and   type = 'U')
   drop table LOAN
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   ACCOUNTNUMBER        bigint              identity(1,1),
   BRANCH_ID            bigint               ,
   SSN                  bigint               ,
   BALANCE              bit                  ,
   ACCOUNTTYPE          varchar(200)         ,
   constraint PK_ACCOUNT primary key (ACCOUNTNUMBER)
)
go

/*==============================================================*/
/* Index: MAINTAIN_FK                                           */
/*==============================================================*/




create nonclustered index MAINTAIN_FK on ACCOUNT (BRANCH_ID ASC)
go

/*==============================================================*/
/* Index: HOLDBY_FK                                             */
/*==============================================================*/




create nonclustered index HOLDBY_FK on ACCOUNT (SSN ASC)
go

/*==============================================================*/
/* Table: ADD_LOAN                                              */
/*==============================================================*/
create table ADD_LOAN (
   LOANNUMBER           bigint              identity(1,1),
   LOANTYPE             char(200)           ,
   EMPLOYEE_ID          bigint               ,
   constraint PK_ADD_LOAN primary key (LOANNUMBER, LOANTYPE, EMPLOYEE_ID)
)
go

/*==============================================================*/
/* Index: ADD_LOAN_FK                                           */
/*==============================================================*/




create nonclustered index ADD_LOAN_FK on ADD_LOAN (LOANNUMBER ASC,
  LOANTYPE ASC)
go

/*==============================================================*/
/* Index: ADD_LOAN2_FK                                          */
/*==============================================================*/




create nonclustered index ADD_LOAN2_FK on ADD_LOAN (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   PASSWORD_ADMIN       varchar(100)         not null,
   USERNAMEADMIN        varchar(200)         not null unique,
   constraint PK_ADMIN primary key (USERNAMEADMIN)
)
go

/*==============================================================*/
/* Table: AVAILEDBY                                             */
/*==============================================================*/
create table AVAILEDBY (
   LOANNUMBER           bigint               ,
   LOANTYPE             char(200)            ,
   SSN                  bigint              ,
   constraint PK_AVAILEDBY primary key (LOANNUMBER, LOANTYPE, SSN)
)
go

/*==============================================================*/
/* Index: AVAILEDBY_FK                                          */
/*==============================================================*/




create nonclustered index AVAILEDBY_FK on AVAILEDBY (LOANNUMBER ASC,
  LOANTYPE ASC)
go

/*==============================================================*/
/* Index: AVAILEDBY2_FK                                         */
/*==============================================================*/




create nonclustered index AVAILEDBY2_FK on AVAILEDBY (SSN ASC)
go

/*==============================================================*/
/* Table: BANK                                                  */
/*==============================================================*/
create table BANK (
   CODE                 bigint               identity(1,1),
   USERNAMEADMIN        varchar(200)         ,
   NAMEBANK             char(300)            ,
   STREETBANK           char(300)            null,
   CITYBANK             char(300)            null,
   COUNTRYBANK          char(300)            null,
   constraint PK_BANK primary key (CODE)
)
go

/*==============================================================*/
/* Index: ADD_BANK_FK                                           */
/*==============================================================*/




create nonclustered index ADD_BANK_FK on BANK (USERNAMEADMIN ASC)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   BRANCH_ID            bigint               identity(1,1),
   CODE                 bigint              ,
   USERNAMEADMIN        varchar(200)         ,
   NAME_BRANCH          char(200)            ,
   STREET_BRANCH        char(10)             null,
   CITY_BRANCH          varchar(100)         null,
   COUNTRY_BRANCH       char(10)             null,
   constraint PK_BRANCH primary key (BRANCH_ID)
)
go

/*==============================================================*/
/* Index: HAS_A_FK                                              */
/*==============================================================*/




create nonclustered index HAS_A_FK on BRANCH (CODE ASC)
go

/*==============================================================*/
/* Index: ADD_BRANCH_FK                                         */
/*==============================================================*/




create nonclustered index ADD_BRANCH_FK on BRANCH (USERNAMEADMIN ASC)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   FNAME                char(200)            ,
   MIDDLENAME           char(200)           ,
   LNAME                char(200)            ,
   SSN                  bigint              identity(1,1),
   CITY_CUSTOMER        char(200)            null,
   STREET_CUSTOMER      char(200)            null,
   USERNAME_C           varchar(100)         unique,
   PASSWORD_C           varchar(100)         ,
   constraint PK_CUSTOMER primary key (SSN)
)
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('CUSTOMER')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'USERNAME_C')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'CUSTOMER', 'column', 'USERNAME_C'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOT NULL',
   'user', @CurrentUser, 'table', 'CUSTOMER', 'column', 'USERNAME_C'
go

/*==============================================================*/
/* Table: CUTOMER_PHONE                                         */
/*==============================================================*/
create table CUTOMER_PHONE (
   PHONE                bigint               ,
   SSN_CUSTOMER         bigint               ,
   SSN                  bigint               ,
   constraint PK_CUTOMER_PHONE primary key (SSN_CUSTOMER, PHONE)
)
go

/*==============================================================*/
/* Index: HASA_FK                                               */
/*==============================================================*/




create nonclustered index HASA_FK on CUTOMER_PHONE (SSN ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   EMPLOYEE_ID          bigint              identity(1,1),
   BRANCH_ID            bigint ,             
   STREET_EMPLOYEE      varchar(100)         null,
   CITY_EMPLOYEE        varchar(100)         null,
   COUNTRY_EMPLOYEE     varchar(100)         null,
   FNAME_EMPLOYEE       varchar(100)         ,
   LNAME_EMPLOYEE       varchar(100)         ,
   USERNAME_E           varchar(100)          unique,
   PASSWORD_E           varchar(100)         ,
   constraint PK_EMPLOYEE primary key (EMPLOYEE_ID)
)
go

if exists(select 1 from sys.extended_properties p where
      p.major_id = object_id('EMPLOYEE')
  and p.minor_id = (select c.column_id from sys.columns c where c.object_id = p.major_id and c.name = 'USERNAME_E')
)
begin
   declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_dropextendedproperty 'MS_Description', 
   'user', @CurrentUser, 'table', 'EMPLOYEE', 'column', 'USERNAME_E'

end


select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   'NOT NULL',
   'user', @CurrentUser, 'table', 'EMPLOYEE', 'column', 'USERNAME_E'
go

/*==============================================================*/
/* Index: WORK_FOR_FK                                           */
/*==============================================================*/




create nonclustered index WORK_FOR_FK on EMPLOYEE (BRANCH_ID ASC)
go

/*==============================================================*/
/* Table: EMPLOYEE_PHONE                                        */
/*==============================================================*/
create table EMPLOYEE_PHONE (
   PHONE_EMPLOYEE       bigint               ,
   EMPLOYEEID           bigint               ,
   EMPLOYEE_ID          bigint               ,
   constraint PK_EMPLOYEE_PHONE primary key (EMPLOYEEID, PHONE_EMPLOYEE)
)
go

/*==============================================================*/
/* Index: OWN_FK                                                */
/*==============================================================*/




create nonclustered index OWN_FK on EMPLOYEE_PHONE (EMPLOYEE_ID ASC)
go

/*==============================================================*/
/* Table: LOAN                                                  */
/*==============================================================*/
create table LOAN (
   LOANNUMBER           bigint           identity(1,1)    not null,
   LOANAMOUNT           bigint               null,
   LOANTYPE             char(200)            ,
   BRANCH_ID            bigint              ,
   STATUS               varchar(100)         ,
   constraint PK_LOAN primary key (LOANNUMBER, LOANTYPE)
)
go

/*==============================================================*/
/* Index: OFFER_FK                                              */
/*==============================================================*/




create nonclustered index OFFER_FK on LOAN (BRANCH_ID ASC)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_HOLDBY_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table ACCOUNT
   add constraint FK_ACCOUNT_MAINTAIN_BRANCH foreign key (BRANCH_ID)
      references BRANCH (BRANCH_ID)
go

alter table ADD_LOAN
   add constraint FK_ADD_LOAN_ADD_LOAN_LOAN foreign key (LOANNUMBER, LOANTYPE)
      references LOAN (LOANNUMBER, LOANTYPE)
go

alter table ADD_LOAN
   add constraint FK_ADD_LOAN_ADD_LOAN2_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID)
go

alter table AVAILEDBY
   add constraint FK_AVAILEDB_AVAILEDBY_LOAN foreign key (LOANNUMBER, LOANTYPE)
      references LOAN (LOANNUMBER, LOANTYPE)
go

alter table AVAILEDBY
   add constraint FK_AVAILEDB_AVAILEDBY_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table BANK
   add constraint FK_BANK_ADD_BANK_ADMIN foreign key (USERNAMEADMIN)
      references ADMIN (USERNAMEADMIN)
go

alter table BRANCH
   add constraint FK_BRANCH_ADD_BRANC_ADMIN foreign key (USERNAMEADMIN)
      references ADMIN (USERNAMEADMIN)
go

alter table BRANCH
   add constraint FK_BRANCH_HAS_A_BANK foreign key (CODE)
      references BANK (CODE)
go

alter table CUTOMER_PHONE
   add constraint FK_CUTOMER__HASA_CUSTOMER foreign key (SSN)
      references CUSTOMER (SSN)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORK_FOR_BRANCH foreign key (BRANCH_ID)
      references BRANCH (BRANCH_ID)
go

alter table EMPLOYEE_PHONE
   add constraint FK_EMPLOYEE_OWN_EMPLOYEE foreign key (EMPLOYEE_ID)
      references EMPLOYEE (EMPLOYEE_ID)
go

alter table LOAN
   add constraint FK_LOAN_OFFER_BRANCH foreign key (BRANCH_ID)
      references BRANCH (BRANCH_ID)
go

SELECT  NAME_BRANCH as NameOfBranch FROM BRANCH as B
inner join ACCOUNT as A
   on A.ACCOUNTNUMBER = B.BRANCH_ID
    group by NAME_BRANCH
 HAVING count(ACCOUNTNUMBER)=0

   SELECT  NAME_BRANCH as NameOfBranch FROM BRANCH as B
inner join EMPLOYEE as E
   on E.EMPLOYEE_ID = B.BRANCH_ID
   group by NAME_BRANCH 
   HAVING count(EMPLOYEE_ID)=0

   select TOP 1 E.EMPLOYEE_ID as ID,  FNAME_EMPLOYEE +' '+LNAME_EMPLOYEE as EmployeeFullName , max(AL.LOANNUMBER) as NumberOfLoans
from EMPLOYEE as E inner join ADD_LOAN as AL on  E.EMPLOYEE_ID = AL.EMPLOYEE_ID
inner join LOAN as L on   L.LOANNUMBER = AL.LOANNUMBER 
Group by FNAME_EMPLOYEE +' '+LNAME_EMPLOYEE , E. EMPLOYEE_ID 


SELECT C.SSN AS ID, C.FNAME +' '+ C.MIDDLENAME+' '+ C.LNAME AS FullName  , count(LOANNUMBER) as numberOfLoans
FROM CUSTOMER AS C inner join AVAILEDBY as A on C.SSN=A.SSN
GROUP BY FNAME +' '+ MIDDLENAME+' '+ LNAME ,C.SSN
Having count(LOANNUMBER)= (
select max(LOANNUMBER) from AVAILEDBY as A where A.SSN=C.SSN );

SELECT C.SSN AS ID, FNAME +' '+ MIDDLENAME+' '+ LNAME AS FullName 
FROM CUSTOMER AS C inner join AVAILEDBY AS A  on C.SSN=A.SSN
GROUP BY FNAME +' '+ MIDDLENAME+' '+ LNAME ,C.SSN
HAVING count(LOANNUMBER)=0

SELECT C.SSN AS ID, FNAME +' '+ MIDDLENAME+' '+ LNAME AS FullName ,STREET_CUSTOMER+' '+CITY_CUSTOMER AS Adderss ,PHONE AS Phone ,count(DISTINCT EMPLOYEE_ID) as numberOfEmployee
from CUSTOMER AS C INNER JOIN CUTOMER_PHONE AS CP ON C.SSN=CP.SSN
INNER JOIN AVAILEDBY AS A ON C.SSN=A.SSN
INNER JOIN LOAN AS L ON A.LOANNUMBER=L.LOANNUMBER
INNER JOIN ADD_LOAN AS AL ON L.LOANNUMBER=AL.LOANNUMBER
GROUP BY C.SSN, FNAME +' '+ MIDDLENAME+' '+ LNAME  ,STREET_CUSTOMER+' '+CITY_CUSTOMER  ,PHONE

 