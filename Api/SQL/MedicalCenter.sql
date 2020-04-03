CREATE TABLE MedicalCenters(
   MedicalID         INTEGER IDENTITY(1,1) PRIMARY KEY
  ,firstName         VARCHAR(6) NOT NULL
  ,middleName        VARCHAR(6) NOT NULL
  ,lastName          VARCHAR(6) NOT NULL
  ,nationality       VARCHAR(6) NOT NULL
  ,email             VARCHAR(6) NOT NULL
  ,sex               VARCHAR(6) NOT NULL
  ,age               INTEGER  NOT NULL
  ,region            VARCHAR(6) NOT NULL
  ,subcity           VARCHAR(6) NOT NULL
  ,zone              VARCHAR(6) NOT NULL
  ,woreda            VARCHAR(6) NOT NULL
  ,kebele            VARCHAR(6) NOT NULL
  ,houseNumber       VARCHAR(6) NOT NULL
  ,phoneNumber       VARCHAR(6) NOT NULL
  ,occupation        VARCHAR(6) NOT NULL
  ,callDate          VARCHAR(24) NOT NULL
  ,callerType        VARCHAR(6) NOT NULL
  ,fever             VARCHAR(4) NOT NULL
  ,cough             VARCHAR(4) NOT NULL
  ,headache          VARCHAR(4) NOT NULL
  ,runnyNose         VARCHAR(4) NOT NULL
  ,feelingUnwell     VARCHAR(4) NOT NULL
  ,shortnessOfBreath VARCHAR(4) NOT NULL
  ,bodyPain          VARCHAR(4) NOT NULL
  ,travelHx          VARCHAR(4) NOT NULL
  ,haveSex           VARCHAR(4) NOT NULL
  ,animalMarket      VARCHAR(4) NOT NULL
  ,healthFacility    VARCHAR(4) NOT NULL
  ,receiverName      VARCHAR(6) NOT NULL
  ,source            VARCHAR(6) NOT NULL
  ,formStatus        VARCHAR(6) NOT NULL
);