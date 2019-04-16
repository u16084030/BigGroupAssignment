USE DiseaseDB

INSERT INTO Disease VALUES ('Malaria', 'Plasmodium', 'Protozoan', '7-15 days', 
'Malaria is a blood borne illness caused by protozoa of the genus Plasmodium' )

INSERT INTO Subtype VALUES (5, 'Falciparum malaria', 'P. falciparum', 'Most deadly strain'), 
(5, 'Benign tertian malaria', 'P. vivax', 'Generally benign but can result in death, often due to splenomegaly'),
(5, 'Tertian malaria', 'P. ovale', 'Rare compared to falciparum and vivax, seldom deadly'),
(5, 'Quartan malaria', 'P. malariae', 'Common but seldom deadly, quartan fever pattern'),
(5, 'Primate malaria', 'P. knowlesi', 'Rare in humans but can be transmitted from primates to humans')


INSERT INTO Cause VALUES (5, 'Bite of an infected female Anopheles mosquito', 'high'), 
(5, 'Sharing needles with infected person', 'low'),
(5, 'Blood transfusion from infected person', 'moderate'),
(5, 'From mother to fetus through the placenta', 'low'),
(5, 'From mother to infant during birthing process', 'low')


INSERT INTO Prevention VALUES (1, 'Use repellents to prevent bites', 'high')/**/
INSERT INTO Prevention VALUES(1, 'Use physical barriers to prevent mosquitoes from biting', 'high')/**/
INSERT INTO Prevention VALUES(1, 'Stay inside dusk-dawn, close windows & doors', 'moderate')/**/
INSERT INTO Prevention VALUES(1, 'Take a course of preventative tablets', 'high')/**/
INSERT INTO Prevention VALUES(1, 'Avoid areas with large bodies of stagnant water', 'moderate')/**/
INSERT INTO Prevention VALUES(2, 'Use a new needle every time & for every person', 'high')/**/
INSERT INTO Prevention VALUES(2, 'Thoroughly disinfect needles after every use', 'moderate')/**/
INSERT INTO Prevention VALUES(3, 'Screening for specific antimalarial immunoglobulin', 'moderate')/**/
INSERT INTO Prevention VALUES(3, 'Administration of antimalarials to transfusion recipients', 'moderate')/**/
INSERT INTO Prevention VALUES(4, 'Avoid travelling in high risk areas/seasons during pregnancy', 'high')/**/
INSERT INTO Prevention VALUES(5, 'Avoid mixing blood between baby & mother during childbirth', 'low')/**/

INSERT INTO SuppliesList VALUES(36, 'repellent spray', 'pharmacies, supermarkets'),
(36, 'repellent cream', 'pharmacies, supermarkets'),
(36, 'mosquito coils', 'pharmacies, supermarkets'),
(36, 'mosquito mats', 'pharmacies, supermarkets'),
(36, 'citronella candles', 'supermarkets'),
(37, 'mosquito nets for beds', 'supermarkets, camping/outdoor stores'),
(37, 'insect screens for windows and doors', 'specialist companies'),
(37, 'fan/air conditioning', 'supermarkets, specialist companies'),
(37, 'long sleeved shirts and long pants', 'clothing stores'), 
(39, 'prescription pills', 'pharmacies only with a doctors prescription'),
(39, 'non-prescription pills', 'pharmacies over-the-counter'),
(40,'coffee grounds (sprinkle in water)', 'supermarkets'),
(40, 'fish and other pond predators', 'special breeders, garden centres'),
(41, 'sterile needles', 'pharmacies, online stores'),
(42, 'open flames - lighters, gas stoves, etc.', 'supermarkets'),
(42, 'boiling water', 'any means necessary'),
(42, 'bleach', 'supermarkets'),
(45, 'antimalarial drugs', 'in hospital after transfusion')

INSERT INTO Symptom VALUES (5, 'fever', 'high body temperature, sweating, flushed appearance', 'moderate-severe', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(5, 'chills', 'feeling abnormally cold, shivering, shaking', 'moderate-severe', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(5, 'vomiting', 'forceful expulsion of stomach contents through mouth', 'moderate', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(5, 'headaches', 'severe pain in the region of the head or neck', 'moderate', 'weak after infection', 'no')/**/
INSERT INTO Symptom VALUES(5, 'jaundice', 'yellowing of skin and sclera caused by liver complications', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(5, 'seizures', 'symptoms due to excessive neuronal activity in brain', 'severe','as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(5, 'coma', 'state of prolonged unconsciousness, person cant be awakened', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(5, 'muscle pain and fatigue', 'abnormal tiredness & pain or weakness in muscles', 'moderate', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(5, 'delirium and confusion', 'sudden change in mental state, confusion, nonsensical speech', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(5, 'photophobia', 'sudden sensitivity to light, causing pain', 'moderate', 'week after infection', 'no')/**/


INSERT INTO ActiveArea VALUES (5, 'South Africa'), (5, 'Tanzania'), (5, 'India'), (5, 'Indonesia'), (5, 'Haiti'),
(5, 'Mozambique'), (5, 'Uganda'), (5, 'Dominican Republic')

INSERT INTO Outbreak VALUES (1, '2018-12-22', 'Giyani, Limpopo', 6, '20 infected, 6 dead, 2 relapsed, 12 recovered'),
(1, '2018-12-28', 'Phaloborwa, Limpopo', 2, '13 infected, 2 dead, 0 relapsed, 11 recovered'),
(3, '2019-01-13', 'Mumbai, Maharashtra', 12, '35 infected, 12 dead, 7 relapsed, 16 recovered'), 
(4, '2019-01-15', 'Nabire, Papua', 4, '5 infected, 4 dead, 0 relapsed, 1 recovered'),
(7, '2019-02-01', 'Kabale, Kabale', 3, '17 infected, 3 dead, 5 relapsed, 9 recovered'),
(3, '2019-02-21', 'New Delhi, Delhi', 0, '16 infected, 0 dead, 2 relapsed, 14 recovered')


INSERT INTO Specialist VALUES (5, 'Jim', 'Andrews', NULL, NULL, NULL, '0615924430', 'andrews11@gmail.com', 'PhD Immunology, University of Pretoria', 'Netcare Hospital Polokwane'),
(5, 'Yolandi', 'Kleinhans', NULL, NULL, NULL, '0720469583', 'yolandik@gmail.com', 'MD, University of Cape Town', 'Middelburg Hospital'),
(5, 'Guy', 'Patel', NULL, NULL, NULL, '0612938574', 'guypatel@gmail.com', 'MD, University of Mumbai', 'Kohinoor Hospital')


INSERT INTO Treatment VALUES (5, 'Quinine', 'Quinine is the most common drug used in malaria treatment', 'Pharmacies only with prescription', '7-10 days', 'primaquine to reduce chances of relapse', 'high', 'relapse can occur even months or years after infection'),
(5, 'Artemisinin-based combination therapies', 'Also a very common combination of treatments', 'Hospitals', '7-10 days', 'primaquine to reduce chances of relapse', 'high', 'relapse can occur even months or years after infection')

GO
