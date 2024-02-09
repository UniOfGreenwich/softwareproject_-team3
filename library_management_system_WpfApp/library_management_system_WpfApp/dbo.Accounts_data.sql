CREATE TABLE [dbo].[Accounts_data] (
    [Id]       INT        NOT NULL,
    [Name]     NCHAR (10) NULL,
    [Password] NCHAR (10) NULL,
    [Role]     NCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO [dbo].[Accounts_data] (Name, Password, Role)
VALUES ('Test_User', 'TestPW', '1')

