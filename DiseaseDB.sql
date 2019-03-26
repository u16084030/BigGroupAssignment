CREATE DATABASE DiseaseDB

CREATE TABLE Disease(
DiseaseID int IDENTITY(1,1) PRIMARY KEY,
CommonName varchar(40), 
ScientificName varchar(60),
Pathogen varchar(30),		/*eg. virus, bacteria or other microorganism*/
IncubationPeriod varchar(20),	/*time for symptoms to appear after infection*/
DiseaseDescription varchar(150), )

CREATE TABLE Subtype(	/*eg. Hepatitis A, B, C...*/
SubtypeID int IDENTITY(1,1) PRIMARY KEY,
DiseaseID int FOREIGN KEY REFERENCES Disease(DiseaseID),
SubtypeName varchar(40),
Strain varchar(60),	/*if subtype has a different scientific name/ strain*/
SubtypeDescription varchar(80), )

CREATE TABLE Cause(
CauseID int IDENTITY(1,1) PRIMARY KEY,
DiseaseID int FOREIGN KEY REFERENCES Disease(DiseaseID),
CauseDescription varchar(80),
CauseRanking varchar(20), )	/*high likelihood or causation, moderate, low*/

CREATE TABLE Prevention(
PreventID int IDENTITY(1,1) PRIMARY KEY,
CauseID int FOREIGN KEY REFERENCES Cause(CauseID),
PreventDescription varchar(60),
PreventEffective varchar(20), )	/* strong effectiveness, moderate, low */

CREATE TABLE SuppliesList(	/* supplies that may be needed for prevention method eg. kettle -> to boil water -> to kill pathogens */
SupplyID int IDENTITY(1,1) PRIMARY KEY,
PreventID int FOREIGN KEY REFERENCES Prevention(PreventID),
SupplyName varchar(40),
AvailableAt varchar(60), )	/* where can this supply be accessed or purchased */

CREATE TABLE Symptom(
SymptomID int IDENTITY(1,1) PRIMARY KEY,
DiseaseID int FOREIGN KEY REFERENCES Disease(DiseaseID),
SymptomName varchar(40),
SymptomDescription varchar(60),
SymptomSeverity varchar(20),	/* high - needs hospitalisation, moderate, low - least concern, just monitor*/
SymptomAppears varchar(40),	/*how early in the progression of the disease do you expect this symptom to appear*/
DefiningCharacteristic varchar(10), )	/* is this symptom a defining characteristic of the disease or could it be linked to a number of diseases*/

CREATE TABLE Treatment(
TreatmentID int IDENTITY(1,1) PRIMARY KEY,
TreatmentName varchar(40),
TreatmentDescription varchar(80),
AvailableAt varchar(40),	/* where can this treatment be accessed*/
TreatmentDuration varchar(60), /*how long will it take to work/ how long should you do it for*/
AfterCare varchar(60),	/*what needs to be done after symptom disappears*/
TreatmentEffective varchar(20), /*same as Preventeffective*/
Aftermath varchar(60), )	/* are there any permanent side effects eg. scarring? Should I expect flareups or am I cured for good?*/ 

CREATE TABLE Symptom_Treatment(
SymptomTreatmentID int IDENTITY(1,1) PRIMARY KEY,
SymptomID int FOREIGN KEY REFERENCES Symptom(SymptomID),
TreatmentID int FOREIGN KEY REFERENCES Treatment(TreatmentID), )

CREATE TABLE ActiveArea(	/*eg. East Africa, South America, Middle East*/
AreaID int IDENTITY(1,1) PRIMARY KEY,
DiseaseID int FOREIGN KEY REFERENCES Disease(DiseaseID),
AreaName varchar(40), )

CREATE TABLE Outbreak(
OutbreakID int IDENTITY(1,1) PRIMARY KEY,
AreaID int FOREIGN KEY REFERENCES ActiveArea(AreaID),
OutbreakDate date,
OutbreakCity varchar(40),
NumberOfCasualties int,	
OutbreakDescription varchar(80), )	/*eg. 4 quarrantined, 1 deceased*/

CREATE TABLE Specialist(
SpecialistID int IDENTITY(1,1) PRIMARY KEY,
DiseaseID int FOREIGN KEY REFERENCES Disease(DiseaseID),
FirstName varchar(20),
LastName varchar(40),
ContactNumber varchar(20),
Email varchar(50),
Qualification varchar(40), /*eg. MD, University of Manchester, specialising in Immunology*/
Hospital varchar(40), )

GO