CREATE TABLE Travelers(
   FirstName        VARCHAR(50) NOT NULL PRIMARY KEY
  ,MiddleName       VARCHAR(50) NOT NULL
  ,LastName         VARCHAR(50) NOT NULL
  ,Gender           VARCHAR(6) NOT NULL
  ,Age              INTEGER  NOT NULL
  ,Nationality      VARCHAR(11) NOT NULL
  ,PassportNo       INTEGER  NOT NULL
  ,SeatNumber       INTEGER  NOT NULL
  ,hasFever         VARCHAR(8) NOT NULL
  ,hasSOB           VARCHAR(8) NOT NULL
  ,hasCough         VARCHAR(8) NOT NULL
  ,TravelFrom       VARCHAR(11) NOT NULL
  ,TransitFrom      VARCHAR(11) NOT NULL
  ,PhoneNo          INTEGER  NOT NULL
  ,FlightNumber     INTEGER  NOT NULL
  ,selectedLanguage VARCHAR(10) NOT NULL
);