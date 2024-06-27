CREATE TABLE [dbo].[studenttab] (
    [Nrmat]    CHAR (10)    NOT NULL,
    [Nume]              VARCHAR (50) NULL,
    [pPrenume]           VARCHAR (50) NULL,
    [IT]  CHAR (11)    NULL,
    [CNP]               VARCHAR (13) NULL,
    [DI]    DATETIME     NULL,
    [CI]  NCHAR (10)   NULL,
    [MA] NCHAR (10)   NULL,
    PRIMARY KEY CLUSTERED ([Nrmat] ASC)
);

