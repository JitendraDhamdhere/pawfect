CREATE TABLE [dbo].[BillDetailsTable] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [BillId]      NVARCHAR (50)  NULL,
    [ProductName] NVARCHAR (100) NULL,
    [Price]       INT            NULL,
    [Quantity]    INT            NULL,
    [Total]       INT            NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[BillInfoTable] (
    [Id]            INT            IDENTITY (1, 1) NOT NULL,
    [BillId]        NVARCHAR (50)  NULL,
    [CustomerName]  NVARCHAR (100) NULL,
    [ContactNo]     NVARCHAR (10)  NULL,
    [Total]         INT            NULL,
    [Discount]      INT            NULL,
    [DiscountPrice] INT            NULL,
    [GrandTotal]    INT            NULL,
    [BillDate]      DATE           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[CategoryTable] (
    [ID]       INT            IDENTITY (1, 1) NOT NULL,
    [Category] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[CustomerTable] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [CustomerId]   NVARCHAR (20)  NULL,
    [CustomerName] NVARCHAR (50)  NULL,
    [EmailAddress] NVARCHAR (50)  NULL,
    [Contact]      NVARCHAR (10)  NULL,
    [Address]      NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[DoctorTable] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [DoctorId]   NVARCHAR (20)  NULL,
    [DoctorName] NVARCHAR (100) NULL,
    [Email]      NVARCHAR (50)  NULL,
    [Contact]    NVARCHAR (10)  NULL,
    [Gender]     NVARCHAR (6)   NULL,
    [Address]    NVARCHAR (MAX) NULL,
    [Salary]     INT            NULL,
    [DateOfJoin] DATE           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[EmployeeTable] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [EmployeeId]   NVARCHAR (20)  NULL,
    [EmployeeName] NVARCHAR (100) NULL,
    [Email]        NVARCHAR (50)  NULL,
    [Contact]      NVARCHAR (10)  NULL,
    [Gender]       NVARCHAR (6)   NULL,
    [Address]      NVARCHAR (MAX) NULL,
    [Salary]       INT            NULL,
    [DateOfJoin]   DATE           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[ProductTB] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [ProductID]   VARCHAR (255)   NULL,
    [ProductName] TEXT            NULL,
    [Category]    TEXT            NULL,
    [Quantity]    INT             NULL,
    [Price]       DECIMAL (10, 2) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[StockTable] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [ProductId]   NVARCHAR (50) NULL,
    [ProductName] NVARCHAR (50) NULL,
    [Brands]      NVARCHAR (50) NULL,
    [Quantity]    INT           NULL,
    [UOM]         NVARCHAR (50) NULL,
    [Price]       INT           NULL,
    [TotalPrice]  INT           NULL,
    [StockDate]   DATE          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[SupplierTable] (
    [ID]        INT           IDENTITY (1, 1) NOT NULL,
    [SupID]     VARCHAR (50)  NULL,
    [SupName]   VARCHAR (100) NULL,
    [ContactNo] VARCHAR (15)  NULL,
    [Address]   VARCHAR (255) NULL,
    [Category]  VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[UserTable] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [Name]     VARCHAR (100) NOT NULL,
    [Mail]     VARCHAR (100) NOT NULL,
    [Password] VARCHAR (255) NOT NULL,
    [UType]    CHAR (10)     NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

