using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using MalariaAPI.Models;
using System.Dynamic;

namespace MalariaAPI.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        [System.Web.Http.Route("api/ActiveArea/getAllActiveAreas")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllActiveAreas()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getActiveAreasReturnList(db.ActiveAreas.ToList());
        }

        private List<dynamic> getActiveAreasReturnList(List<ActiveArea> forClient)
        {
            List<dynamic> dynamicActiveAreas = new List<dynamic>();
            foreach (ActiveArea activeArea in forClient)
            {
                dynamic dynamicActiveArea = new ExpandoObject();
                dynamicActiveArea.AreaID = activeArea.AreaID;
                dynamicActiveArea.DiseaseID = activeArea.DiseaseID;
                dynamicActiveArea.AreaName = activeArea.AreaName;
                dynamicActiveAreas.Add(dynamicActiveArea);
            }

            return dynamicActiveAreas;
        }


        [System.Web.Http.Route("api/Outbreak/getAllOutbreaks")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllOutbreaks()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getOutbreaksReturnList(db.Outbreaks.ToList());
        }

        private List<dynamic> getOutbreaksReturnList(List<Outbreak> forClient)
        {
            List<dynamic> dynamicOutbreaks = new List<dynamic>();
            foreach (Outbreak outbreak in forClient)
            {
                dynamic dynamicOutbreak = new ExpandoObject();
                dynamicOutbreak.OutbreakID = outbreak.OutbreakID;
                dynamicOutbreak.AreaID = outbreak.AreaID;
                dynamicOutbreak.OutbreakCity = outbreak.OutbreakCity;
                dynamicOutbreak.OutbreakDate = outbreak.OutbreakDate;
                dynamicOutbreak.OutbreakDescription = outbreak.OutbreakDescription;
                dynamicOutbreak.NumberOfCasualties = outbreak.NumberOfCasualties;
                dynamicOutbreaks.Add(dynamicOutbreak);
            }

            return dynamicOutbreaks;
        }

        [System.Web.Http.Route("api/Cause/getAllCauses")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllCauses()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getCausesReturnList(db.Causes.ToList());
        }

        private List<dynamic> getCausesReturnList(List<Cause> forClient)
        {
            List<dynamic> dynamicCauses = new List<dynamic>();
            foreach (Cause cause in forClient)
            {
                dynamic dynamicCause = new ExpandoObject();
                dynamicCause.CauseID = cause.CauseID;
                dynamicCause.DiseaseID = cause.DiseaseID;
                dynamicCause.CauseDescription = cause.CauseDescription;
                dynamicCause.CauseRanking = cause.CauseRanking;
                dynamicCauses.Add(dynamicCause);
            }

            return dynamicCauses;
        }

        [System.Web.Http.Route("api/Prevention/getAllPreventions")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllPreventions()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getPreventionsReturnList(db.Preventions.ToList());
        }

        private List<dynamic> getPreventionsReturnList(List<Prevention> forClient)
        {
            List<dynamic> dynamicPreventions = new List<dynamic>();
            foreach (Prevention prevention in forClient)
            {
                dynamic dynamicPrevention = new ExpandoObject();
                dynamicPrevention.CauseID = prevention.CauseID;
                dynamicPrevention.PreventionID = prevention.PreventID;
                dynamicPrevention.PreventionDescription = prevention.PreventDescription;
                dynamicPrevention.PreventEffective = prevention.PreventEffective;
                dynamicPreventions.Add(dynamicPrevention);
            }

            return dynamicPreventions;
        }

        [System.Web.Http.Route("api/SuppliesList/getAllSuppliesLists")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllSuppliesLists()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSuppliesListsReturnList(db.SuppliesLists.ToList());
        }

        private List<dynamic> getSuppliesListsReturnList(List<SuppliesList> forClient)
        {
            List<dynamic> dynamicSuppliesLists = new List<dynamic>();
            foreach (SuppliesList suppliesList in forClient)
            {
                dynamic dynamicSuppliesList = new ExpandoObject();
                dynamicSuppliesList.SupplyID = suppliesList.SupplyID;
                dynamicSuppliesList.SuppliesListID = suppliesList.PreventID;
                dynamicSuppliesList.SupplyName = suppliesList.SupplyName;
                dynamicSuppliesList.AvailableAt = suppliesList.AvailableAt;
                dynamicSuppliesLists.Add(dynamicSuppliesList);
            }

            return dynamicSuppliesLists;
        }

        [System.Web.Http.Route("api/Disease/getAllDiseases")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllDiseases()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getDiseasesReturnList(db.Diseases.ToList());
        }

        private List<dynamic> getDiseasesReturnList(List<Disease> forClient)
        {
            List<dynamic> dynamicDiseases = new List<dynamic>();
            foreach (Disease disease in forClient)
            {
                dynamic dynamicDisease = new ExpandoObject();
                dynamicDisease.DiseaseID = disease.DiseaseID;
                dynamicDisease.CommonName = disease.CommonName;
                dynamicDisease.DiseaseDescription = disease.DiseaseDescription;
                dynamicDisease.ScientificName = disease.ScientificName;
                dynamicDisease.Pathogen = disease.Pathogen;
                dynamicDisease.IncubationPeriod = disease.IncubationPeriod;
                dynamicDiseases.Add(dynamicDisease);
            }

            return dynamicDiseases;
        }

        [System.Web.Http.Route("api/Specialist/getAllSpecialists")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllSpecialists()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSpecialistsReturnList(db.Specialists.ToList());
        }

        private List<dynamic> getSpecialistsReturnList(List<Specialist> forClient)
        {
            List<dynamic> dynamicSpecialists = new List<dynamic>();
            foreach (Specialist specialist in forClient)
            {
                dynamic dynamicSpecialist = new ExpandoObject();
                dynamicSpecialist.SpecialistID = specialist.SpecialistID;
                dynamicSpecialist.DiseaseID = specialist.DiseaseID;
                dynamicSpecialist.FirstName = specialist.FirstName;
                dynamicSpecialist.LastName = specialist.LastName;
                dynamicSpecialist.UserPassword = specialist.UserPassword;
                dynamicSpecialist.UserGUID = specialist.UserGUID;
                dynamicSpecialist.GUIDExpiry = specialist.GUIDExpiry;
                dynamicSpecialist.ContactNumber = specialist.ContactNumber;
                dynamicSpecialist.Qualification = specialist.Qualification;
                dynamicSpecialist.Email = specialist.Email;
                dynamicSpecialist.Hospital = specialist.Hospital;
                dynamicSpecialists.Add(dynamicSpecialist);
            }

            return dynamicSpecialists;
        }

        [System.Web.Http.Route("api/Subtype/getAllSubtypes")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllSubtypes()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSubtypesReturnList(db.Subtypes.ToList());
        }

        private List<dynamic> getSubtypesReturnList(List<Subtype> forClient)
        {
            List<dynamic> dynamicSubtypes = new List<dynamic>();
            foreach (Subtype subtype in forClient)
            {
                dynamic dynamicSubtype = new ExpandoObject();
                dynamicSubtype.SubtypeID = subtype.SubtypeID;
                dynamicSubtype.DiseaseID = subtype.DiseaseID;
                dynamicSubtype.SubtypeDescription = subtype.SubtypeDescription;
                dynamicSubtype.SubtypeName = subtype.SubtypeName;
                dynamicSubtype.Strain = subtype.Strain;
                dynamicSubtypes.Add(dynamicSubtype);
            }

            return dynamicSubtypes;
        }

        [System.Web.Http.Route("api/Symptom/getAllSymptoms")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllSymptoms()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSymptomsReturnList(db.Symptoms.ToList());
        }

        private List<dynamic> getSymptomsReturnList(List<Symptom> forClient)
        {
            List<dynamic> dynamicSymptoms = new List<dynamic>();
            foreach (Symptom symptom in forClient)
            {
                dynamic dynamicSymptom = new ExpandoObject();
                dynamicSymptom.SymptomID = symptom.SymptomID;
                dynamicSymptom.DiseaseID = symptom.DiseaseID;
                dynamicSymptom.SymptomDescription = symptom.SymptomDescription;
                dynamicSymptom.SymptomAppears = symptom.SymptomAppears;
                dynamicSymptom.SymptomName = symptom.SymptomName;
                dynamicSymptom.SymptomSeverity = symptom.SymptomSeverity;
                dynamicSymptom.DefiningCharacteristic = symptom.DefiningCharacteristic;
                dynamicSymptoms.Add(dynamicSymptom);
            }

            return dynamicSymptoms;
        }

        [System.Web.Http.Route("api/Treatment/getAllTreatments")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> getAllTreatments()
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getTreatmentsReturnList(db.Treatments.ToList());
        }

        private List<dynamic> getTreatmentsReturnList(List<Treatment> forClient)
        {
            List<dynamic> dynamicTreatments = new List<dynamic>();
            foreach (Treatment treatment in forClient)
            {
                dynamic dynamicTreatment = new ExpandoObject();
                dynamicTreatment.TreatmentID = treatment.TreatmentID;
                dynamicTreatment.DiseaseID = treatment.DiseaseID;
                dynamicTreatment.TreatmentDescription = treatment.TreatmentDescription;
                dynamicTreatment.TreatmentDuration = treatment.TreatmentDuration;
                dynamicTreatment.TreatmentEffective = treatment.TreatmentEffective;
                dynamicTreatment.TreatmentName = treatment.TreatmentName;
                dynamicTreatment.AfterCare = treatment.AfterCare;
                dynamicTreatment.Aftermath = treatment.Aftermath;
                dynamicTreatment.AvailableAt = treatment.AvailableAt;
                dynamicTreatments.Add(dynamicTreatment);
            }

            return dynamicTreatments;
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        [System.Web.Http.Route("api/ActiveArea/addActiveAreas")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addActiveAreas([FromBody] List<ActiveArea> activeAreas)
        {
            if (activeAreas != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.ActiveAreas.AddRange(activeAreas);
                db.SaveChanges();
                return getAllActiveAreas();
            }

            else return null;
        }

        [System.Web.Http.Route("api/ActiveArea/addActiveArea")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addActiveArea([FromBody] ActiveArea activeArea)
        {
            if (activeArea != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.ActiveAreas.Add(activeArea);
                db.SaveChanges();
                return getAllActiveAreas();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Outbreak/addOutbreaks")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addOutbreaks([FromBody] List<Outbreak> outbreaks)
        {
            if (outbreaks != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Outbreaks.AddRange(outbreaks);
                db.SaveChanges();
                return getAllOutbreaks();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Outbreak/addOutbreak")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addOutbreak([FromBody] Outbreak outbreak)
        {
            if (outbreak != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Outbreaks.Add(outbreak);
                db.SaveChanges();
                return getAllOutbreaks();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Cause/addCauses")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addCauses([FromBody] List<Cause> Causes)
        {
            if (Causes != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Causes.AddRange(Causes);
                db.SaveChanges();
                return getAllCauses();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Cause/addCause")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addCause([FromBody] Cause Cause)
        {
            if (Cause != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Causes.Add(Cause);
                db.SaveChanges();
                return getAllCauses();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Prevention/addPreventions")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addPreventions([FromBody] List<Prevention> Preventions)
        {
            if (Preventions != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Preventions.AddRange(Preventions);
                db.SaveChanges();
                return getAllPreventions();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Prevention/addPrevention")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addPrevention([FromBody] Prevention Prevention)
        {
            if (Prevention != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Preventions.Add(Prevention);
                db.SaveChanges();
                return getAllPreventions();
            }

            else return null;
        }

        [System.Web.Http.Route("api/SuppliesList/addSuppliesLists")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSuppliesLists([FromBody] List<SuppliesList> SuppliesLists)
        {
            if (SuppliesLists != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.SuppliesLists.AddRange(SuppliesLists);
                db.SaveChanges();
                return getAllSuppliesLists();
            }

            else return null;
        }

        [System.Web.Http.Route("api/SuppliesList/addSuppliesList")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSuppliesList([FromBody] SuppliesList SuppliesList)
        {
            if (SuppliesList != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.SuppliesLists.Add(SuppliesList);
                db.SaveChanges();
                return getAllSuppliesLists();
            }

            else return null;

        }

        [System.Web.Http.Route("api/Specialist/addSpecialists")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSpecialists([FromBody] List<Specialist> Specialists)
        {
            if (Specialists != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Specialists.AddRange(Specialists);
                db.SaveChanges();
                return getAllSpecialists();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Specialist/addSpecialist")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSpecialist([FromBody] Specialist Specialist)
        {
            if (Specialist != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Specialists.Add(Specialist);
                db.SaveChanges();
                return getAllSpecialists();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Disease/addDiseases")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addDiseases([FromBody] List<Disease> Diseases)
        {
            if (Diseases != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Diseases.AddRange(Diseases);
                db.SaveChanges();
                return getAllDiseases();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Disease/addDisease")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addDisease([FromBody] Disease Disease)
        {
            if (Disease != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Diseases.Add(Disease);
                db.SaveChanges();
                return getAllDiseases();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Subtype/addSubtypes")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSubtypes([FromBody] List<Subtype> Subtypes)
        {
            if (Subtypes != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Subtypes.AddRange(Subtypes);
                db.SaveChanges();
                return getAllSubtypes();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Subtype/addSubtype")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSubtype([FromBody] Subtype Subtype)
        {
            if (Subtype != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Subtypes.Add(Subtype);
                db.SaveChanges();
                return getAllSubtypes();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Symptom/addSymptoms")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSymptoms([FromBody] List<Symptom> Symptoms)
        {
            if (Symptoms != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Symptoms.AddRange(Symptoms);
                db.SaveChanges();
                return getAllSymptoms();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Symptom/addSymptom")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addSymptom([FromBody] Symptom Symptom)
        {
            if (Symptom != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Symptoms.Add(Symptom);
                db.SaveChanges();
                return getAllSymptoms();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Treatment/addTreatments")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addTreatments([FromBody] List<Treatment> Treatments)
        {
            if (Treatments != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Treatments.AddRange(Treatments);
                db.SaveChanges();
                return getAllTreatments();
            }

            else return null;
        }

        [System.Web.Http.Route("api/Treatment/addTreatment")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> addTreatment([FromBody] Treatment Treatment)
        {
            if (Treatment != null)
            {
                DiseaseDBEntities db = new DiseaseDBEntities();
                db.Configuration.ProxyCreationEnabled = false;
                db.Treatments.Add(Treatment);
                db.SaveChanges();
                return getAllTreatments();
            }

            else return null;
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
