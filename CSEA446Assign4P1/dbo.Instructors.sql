CREATE TABLE [dbo].[Instructors] (
    [Id]        INT        NOT NULL,
    [FirstName] NCHAR (20) NULL,
    [LastName]  NCHAR (20) NULL,
    [OfficeNum] NCHAR(10)        NULL IDENTITY,
    [Courses]   NCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

