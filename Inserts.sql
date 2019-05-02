USE DiseaseDB

INSERT INTO Disease VALUES ('Malaria', 'Plasmodium', 'Protozoan', '7-15 days', 
'Malaria is a blood borne illness caused by protozoa of the genus Plasmodium' )

INSERT INTO Subtype VALUES (1, 'Falciparum malaria', 'P. falciparum', 'Most deadly strain'), 
(1, 'Benign tertian malaria', 'P. vivax', 'Generally benign but can result in death, often due to splenomegaly'),
(1, 'Tertian malaria', 'P. ovale', 'Rare compared to falciparum and vivax, seldom deadly'),
(1, 'Quartan malaria', 'P. malariae', 'Common but seldom deadly, quartan fever pattern'),
(1, 'Primate malaria', 'P. knowlesi', 'Rare in humans but can be transmitted from primates to humans')


INSERT INTO Cause VALUES (1, 'Bite of an infected female Anopheles mosquito', 'high'), 
(1, 'Sharing needles with infected person', 'low'),
(1, 'Blood transfusion from infected person', 'moderate'),
(1, 'From mother to fetus through the placenta', 'low'),
(1, 'From mother to infant during birthing process', 'low')


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

INSERT INTO SuppliesList VALUES(1, 'repellent spray', 'pharmacies, supermarkets'),
(1, 'repellent cream', 'pharmacies, supermarkets'),
(1, 'mosquito coils', 'pharmacies, supermarkets'),
(1, 'mosquito mats', 'pharmacies, supermarkets'),
(1, 'citronella candles', 'supermarkets'),
(2, 'mosquito nets for beds', 'supermarkets, camping/outdoor stores'),
(2, 'insect screens for windows and doors', 'specialist companies'),
(2, 'fan/air conditioning', 'supermarkets, specialist companies'),
(2, 'long sleeved shirts and long pants', 'clothing stores'), 
(4, 'prescription pills', 'pharmacies only with a doctors prescription'),
(4, 'non-prescription pills', 'pharmacies over-the-counter'),
(5,'coffee grounds (sprinkle in water)', 'supermarkets'),
(5, 'fish and other pond predators', 'special breeders, garden centres'),
(6, 'sterile needles', 'pharmacies, online stores'),
(7, 'open flames - lighters, gas stoves, etc.', 'supermarkets'),
(7, 'boiling water', 'any means necessary'),
(7, 'bleach', 'supermarkets'),
(9, 'antimalarial drugs', 'in hospital after transfusion')

INSERT INTO Symptom VALUES (1, 'fever', 'high body temperature, sweating, flushed appearance', 'moderate-severe', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(1, 'chills', 'feeling abnormally cold, shivering, shaking', 'moderate-severe', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(1, 'vomiting', 'forceful expulsion of stomach contents through mouth', 'moderate', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(1, 'headaches', 'severe pain in the region of the head or neck', 'moderate', 'weak after infection', 'no')/**/
INSERT INTO Symptom VALUES(1, 'jaundice', 'yellowing of skin and sclera caused by liver complications', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(1, 'seizures', 'symptoms due to excessive neuronal activity in brain', 'severe','as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(1, 'coma', 'state of prolonged unconsciousness, person cant be awakened', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(1, 'muscle pain and fatigue', 'abnormal tiredness & pain or weakness in muscles', 'moderate', 'week after infection', 'no')/**/
INSERT INTO Symptom VALUES(1, 'delirium and confusion', 'sudden change in mental state, confusion, nonsensical speech', 'severe', 'as infection worsens', 'no')/**/
INSERT INTO Symptom VALUES(1, 'photophobia', 'sudden sensitivity to light, causing pain', 'moderate', 'week after infection', 'no')/**/


INSERT INTO ActiveArea VALUES (1, 'South Africa'), (1, 'Tanzania'), (1, 'India'), (1, 'Indonesia'), (1, 'Haiti'),
(1, 'Mozambique'), (1, 'Uganda'), (1, 'Dominican Republic')

INSERT INTO Outbreak VALUES (1, '2018-12-22', 'Giyani, Limpopo', 6, '20 infected, 6 dead, 2 relapsed, 12 recovered'),
(1, '2018-12-28', 'Phaloborwa, Limpopo', 2, '13 infected, 2 dead, 0 relapsed, 11 recovered'),
(3, '2019-01-13', 'Mumbai, Maharashtra', 12, '35 infected, 12 dead, 7 relapsed, 16 recovered'), 
(4, '2019-01-15', 'Nabire, Papua', 4, '5 infected, 4 dead, 0 relapsed, 1 recovered'),
(7, '2019-02-01', 'Kabale, Kabale', 3, '17 infected, 3 dead, 5 relapsed, 9 recovered'),
(3, '2019-02-21', 'New Delhi, Delhi', 0, '16 infected, 0 dead, 2 relapsed, 14 recovered')


INSERT INTO Specialist VALUES (1, 'Jim', 'Andrews', NULL, NULL, NULL, '0615924430', 'andrews11@gmail.com', 'PhD Immunology, University of Pretoria', 'Netcare Hospital Polokwane'),
(1, 'Yolandi', 'Kleinhans', NULL, NULL, NULL, '0720469583', 'yolandik@gmail.com', 'MD, University of Cape Town', 'Middelburg Hospital'),
(1, 'Guy', 'Patel', NULL, NULL, NULL, '0612938574', 'guypatel@gmail.com', 'MD, University of Mumbai', 'Kohinoor Hospital')


INSERT INTO Treatment VALUES (1, 'Quinine', 'Quinine is the most common drug used in malaria treatment', 'Pharmacies only with prescription', '7-10 days', 'primaquine to reduce chances of relapse', 'high', 'relapse can occur even months or years after infection'),
(1, 'Artemisinin-based combination therapies', 'Also a very common combination of treatments', 'Hospitals', '7-10 days', 'primaquine to reduce chances of relapse', 'high', 'relapse can occur even months or years after infection')

GO
