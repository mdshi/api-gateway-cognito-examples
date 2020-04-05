CREATE TABLE [dbo].[Travelers] (
    [TravelerID]       INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]        VARCHAR (50) NOT NULL,
    [MiddleName]       VARCHAR (50) NOT NULL,
    [LastName]         VARCHAR (50) NOT NULL,
    [Gender]           VARCHAR (6)  NOT NULL,
    [Age]              INT          NOT NULL,
    [Nationality]      VARCHAR (11) NOT NULL,
    [PassportNo]       VARCHAR(50)          NOT NULL,
    [SeatNumber]       VARCHAR(50)          NOT NULL,
    [hasFever]         BIT  NOT NULL,
    [hasSOB]           BIT  NOT NULL,
    [hasCough]         BIT  NOT NULL,
    [TravelFrom]       VARCHAR (50) NOT NULL,
    [TransitFrom]      VARCHAR (50) NOT NULL,
    [PhoneNo]          NVARCHAR(50)          NOT NULL,
    [FlightNumber]     NVARCHAR(50)          NOT NULL,
    [selectedLanguage] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([TravelerID] ASC)
);

