
CREATE TABLE Communities(
  CommunityID    INTEGER IDENTITY(1,1) PRIMARY KEY
  ,FirstName      VARCHAR(3) NOT NULL 
  ,LastName       VARCHAR(4) NOT NULL
  ,Age            INTEGER  NOT NULL
  ,sex            VARCHAR(6) NOT NULL
  ,Language       VARCHAR(30)
  ,Region         VARCHAR(11) NOT NULL
  ,SubcityOrZone  VARCHAR(30)
  ,Sefer          VARCHAR(30)
  ,Woreda         VARCHAR(30)
  ,Kebele         VARCHAR(30)
  ,Occupation     VARCHAR(30)
  ,HouseNo        VARCHAR(30)
  ,PhoneNo        INTEGER  NOT NULL
  ,Latitude       VARCHAR(30)
  ,Longitude      VARCHAR(30)
  ,fever          VARCHAR(4) NOT NULL
  ,cough          VARCHAR(4) NOT NULL
  ,HasSOB         VARCHAR(5) NOT NULL
  ,FormStatus     VARCHAR(10) NOT NULL
  ,travleHx       VARCHAR(4) NOT NULL
  ,haveSex        VARCHAR(4) NOT NULL
  ,animalMarket   VARCHAR(4) NOT NULL
  ,healthFacility VARCHAR(4) NOT NULL
  ,employee     VARCHAR(16) NOT NULL
);