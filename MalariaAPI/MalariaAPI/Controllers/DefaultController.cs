using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Cors;//check back
using System.Data.Entity;
using MalariaAPI.Models;
using System.Dynamic;

namespace MalariaAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DefaultController : ApiController
    {
        [System.Web.Http.Route("api/ActiveArea/searchActiveAreas/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchActiveAreas(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getActiveAreas(db.ActiveAreas.ToList(), id);
        }

        private List<dynamic> getActiveAreas(List<ActiveArea> forClient, string search)
        {
            List<dynamic> dynamicActiveAreas = new List<dynamic>();
            foreach (ActiveArea activeArea in forClient)
            {
                if (activeArea.AreaName == search)
                {
                    dynamic dynamicActiveArea = new ExpandoObject();
                    dynamicActiveArea.AreaID = activeArea.AreaID;
                    dynamicActiveArea.DiseaseID = activeArea.DiseaseID;
                    dynamicActiveArea.AreaName = activeArea.AreaName;
                    dynamicActiveAreas.Add(dynamicActiveArea);
                    return dynamicActiveAreas;
                }
            }
            return null;
        }

        [System.Web.Http.Route("api/Outbreak/searchOutbreaks/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchOutbreaks(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getOutbreaks(db.Outbreaks.ToList(), id);
        }

        private List<dynamic> getOutbreaks(List<Outbreak> forClient, string search)
        {
            List<dynamic> dynamicOutbreaks = new List<dynamic>();
            foreach (Outbreak outbreak in forClient)
            {
                if (outbreak.OutbreakCity == search)
                {
                    dynamic dynamicOutbreak = new ExpandoObject();
                    dynamicOutbreak.OutbreakID = outbreak.OutbreakID;
                    dynamicOutbreak.AreaID = outbreak.AreaID;
                    dynamicOutbreak.OutbreakCity = outbreak.OutbreakCity;
                    dynamicOutbreak.OutbreakDate = outbreak.OutbreakDate;
                    dynamicOutbreak.OutbreakDescription = outbreak.OutbreakDescription;
                    dynamicOutbreak.NumberOfCasualties = outbreak.NumberOfCasualties;
                    dynamicOutbreaks.Add(dynamicOutbreak);

                    return dynamicOutbreaks;
                }
            }

            return null;
        }

        [System.Web.Http.Route("api/Cause/searchCauses/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchCauses(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getCauses(db.Causes.ToList(), id);
        }

        private List<dynamic> getCauses(List<Cause> forClient, string search)
        {
            List<dynamic> dynamicCauses = new List<dynamic>();
            foreach (Cause cause in forClient)
            {
                if (cause.CauseRanking == search)
                {
                    dynamic dynamicCause = new ExpandoObject();
                    dynamicCause.CauseID = cause.CauseID;
                    dynamicCause.DiseaseID = cause.DiseaseID;
                    dynamicCause.CauseDescription = cause.CauseDescription;
                    dynamicCause.CauseRanking = cause.CauseRanking;
                    dynamicCauses.Add(dynamicCause);

                    
                }
            }

            return dynamicCauses;
        }

        [System.Web.Http.Route("api/Prevention/searchPreventions/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchPreventions(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getPreventions(db.Preventions.ToList(), id);
        }

        private List<dynamic> getPreventions(List<Prevention> forClient, string search)
        {
            List<dynamic> dynamicPreventions = new List<dynamic>();
            foreach (Prevention prevention in forClient)
            {
                if (prevention.PreventEffective == search)
                {
                    dynamic dynamicPrevention = new ExpandoObject();
                    dynamicPrevention.CauseID = prevention.CauseID;
                    dynamicPrevention.PreventID = prevention.PreventID;
                    dynamicPrevention.PreventDescription = prevention.PreventDescription;
                    dynamicPrevention.PreventEffective = prevention.PreventEffective;
                    dynamicPreventions.Add(dynamicPrevention);

                    
                }
            }

            return dynamicPreventions;
        }

        [System.Web.Http.Route("api/SuppliesList/searchSuppliesLists/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchSuppliesLists(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSuppliesLists(db.SuppliesLists.ToList(), id);
        }

        private List<dynamic> getSuppliesLists(List<SuppliesList> forClient, string search)
        {
            List<dynamic> dynamicSuppliesLists = new List<dynamic>();
            foreach (SuppliesList suppliesList in forClient)
            {
                if (suppliesList.SupplyName == search)
                {
                    dynamic dynamicSuppliesList = new ExpandoObject();
                    dynamicSuppliesList.SupplyID = suppliesList.SupplyID;
                    dynamicSuppliesList.PreventID = suppliesList.PreventID;
                    dynamicSuppliesList.SupplyName = suppliesList.SupplyName;
                    dynamicSuppliesList.AvailableAt = suppliesList.AvailableAt;
                    dynamicSuppliesLists.Add(dynamicSuppliesList);

                    return dynamicSuppliesLists;

                }
            }

            return null;
        }

        [System.Web.Http.Route("api/Disease/searchDiseases/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchDiseases(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getDiseases(db.Diseases.ToList(), id);
        }

        private List<dynamic> getDiseases(List<Disease> forClient, string search)
        {
            List<dynamic> dynamicDiseases = new List<dynamic>();
            foreach (Disease disease in forClient)
            {
                if (disease.CommonName == search)
                {
                    dynamic dynamicDisease = new ExpandoObject();
                    dynamicDisease.DiseaseID = disease.DiseaseID;
                    dynamicDisease.CommonName = disease.CommonName;
                    dynamicDisease.DiseaseDescription = disease.DiseaseDescription;
                    dynamicDisease.ScientificName = disease.ScientificName;
                    dynamicDisease.Pathogen = disease.Pathogen;
                    dynamicDisease.IncubationPeriod = disease.IncubationPeriod;
                    dynamicDiseases.Add(dynamicDisease);

                    return dynamicDiseases;
                }
            }

            return null;
        }

        [System.Web.Http.Route("api/Specialist/searchSpecialists/{id}")]
        [System.Web.Mvc.HttpPost]
        public Boolean searchSpecialists(string id, string user, string pass)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSpecialists(db.Specialists.ToList(), id, pass);
        }

        private Boolean getSpecialists(List<Specialist> forClient, string search, string pass)
        {
            List<dynamic> dynamicSpecialists = new List<dynamic>();
            foreach (Specialist specialist in forClient)
            {
                if (specialist.FirstName == search )
                {
                    if(specialist.UserPassword == pass)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        [System.Web.Http.Route("api/Subtype/searchSubtypes/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchSubtypes(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSubtypes(db.Subtypes.ToList(), id);
        }

        private List<dynamic> getSubtypes(List<Subtype> forClient, string search)
        {
            List<dynamic> dynamicSubtypes = new List<dynamic>();
            foreach (Subtype subtype in forClient)
            {
                if (subtype.SubtypeName == search)
                {
                    dynamic dynamicSubtype = new ExpandoObject();
                    dynamicSubtype.SubtypeID = subtype.SubtypeID;
                    dynamicSubtype.DiseaseID = subtype.DiseaseID;
                    dynamicSubtype.SubtypeDescription = subtype.SubtypeDescription;
                    dynamicSubtype.SubtypeName = subtype.SubtypeName;
                    dynamicSubtype.Strain = subtype.Strain;
                    dynamicSubtypes.Add(dynamicSubtype);

                    return dynamicSubtypes;

                }
            }

            return null;
        }

        [System.Web.Http.Route("api/Symptom/searchSymptoms/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchSymptoms(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getSymptoms(db.Symptoms.ToList(), id);
        }

        private List<dynamic> getSymptoms(List<Symptom> forClient, string search)
        {
            List<dynamic> dynamicSymptoms = new List<dynamic>();
            foreach (Symptom symptom in forClient)
            {
                if (symptom.SymptomName == search)
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
                    return dynamicSymptoms;

                }
            }

            return null;
        }

        [System.Web.Http.Route("api/Treatment/searchTreatments/{id}")]
        [System.Web.Mvc.HttpPost]
        public List<dynamic> searchTreatments(string id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;
            return getTreatments(db.Treatments.ToList(), id);
        }

        private List<dynamic> getTreatments(List<Treatment> forClient, string search)
        {
            List<dynamic> dynamicTreatments = new List<dynamic>();
            foreach (Treatment treatment in forClient)
            {
                if (treatment.TreatmentEffective == search)
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
            }

            return dynamicTreatments;
        }

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


        [System.Web.Http.Route("api/Cause/getCauseById/{id}")]
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult getCauseById(int id)
        {
            DiseaseDBEntities db = new DiseaseDBEntities();
            db.Configuration.ProxyCreationEnabled = false;

            

            
            db.Configuration.ProxyCreationEnabled = false;
            List<dynamic> dynamicCauses = new List<dynamic>();
            foreach (Cause cause in db.Causes.ToList())
            {
                if (cause.CauseID == id)
                {
                    dynamic dynamicCause = new ExpandoObject();
                    dynamicCause.CauseID = cause.CauseID;
                    dynamicCause.DiseaseID = cause.DiseaseID;
                    dynamicCause.CauseDescription = cause.CauseDescription;
                    dynamicCause.CauseRanking = cause.CauseRanking;
                    dynamicCauses.Add(dynamicCause);
                }
            }
            //return dynamicCauses;
            //dynamic dynamicCause = new ExpandoObject();
            //CauseDetail objCause = new CauseDetail();
            //int ID = Convert.ToInt32(id);
            //try
            //{
            //    dynamicCause = db.Causes.Find(ID);
            //    if (dynamicCause == null)
            //    {
            //        return NotFound();
            //    }

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //var response = Request.CreateResponse(HttpStatusCode.OK, dynamicCause);
            //response.Headers.Add("Access-Control-Allow-Origin", "*");
            //return response;

            return Ok(dynamicCauses);
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
                dynamicPrevention.PreventID = prevention.PreventID;
                dynamicPrevention.PreventDescription = prevention.PreventDescription;
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
                dynamicSuppliesList.PreventID = suppliesList.PreventID;
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

        [System.Web.Http.Route("api/ActiveArea/deleteActiveArea/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteActiveArea(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid area id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.ActiveAreas
                    .Where(s => s.AreaID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }


        [System.Web.Http.Route("api/Outbreak/deleteOutbreak/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteOutbreak(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid outbreak id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Outbreaks
                    .Where(s => s.OutbreakID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }


        [System.Web.Http.Route("api/Cause/deleteCause/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteCause(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid cause id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Causes
                    .Where(s => s.CauseID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }


        [System.Web.Http.Route("api/Prevention/deletePrevention/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deletePrevention(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid prevention id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Preventions
                    .Where(s => s.PreventID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/SuppliesList/deleteSuppliesList/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteSuppliesList(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid supply id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.SuppliesLists
                    .Where(s => s.SupplyID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Disease/deleteDisease/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteDisease(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid disease id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Diseases
                    .Where(s => s.DiseaseID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Specialist/deleteSpecialist/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteSpecialist(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid specialist id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Specialists
                    .Where(s => s.SpecialistID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Subtype/deleteSubtype/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteSubtype(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid subtype id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Subtypes
                    .Where(s => s.SubtypeID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Symptom/deleteSymptom/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteSymptom(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid symptom id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Symptoms
                    .Where(s => s.SymptomID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Treatment/deleteTreatment/{id}")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult deleteTreatment(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid treatment id");

            using (var ctx = new DiseaseDBEntities())
            {
                var area = ctx.Treatments
                    .Where(s => s.TreatmentID == id)
                    .FirstOrDefault();

                ctx.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [System.Web.Http.Route("api/ActiveArea/updateActiveArea")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateActiveArea(ActiveArea area)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingArea = ctx.ActiveAreas.Where(s => s.AreaID == area.AreaID)
                                                        .FirstOrDefault<ActiveArea>();

                if (existingArea != null)
                {
                    existingArea.DiseaseID = area.DiseaseID;
                    existingArea.AreaName = area.AreaName;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }


        [System.Web.Http.Route("api/Outbreak/updateOutbreak")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateOutbreak(Outbreak outbreak)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingOutbreak = ctx.Outbreaks.Where(s => s.OutbreakID == outbreak.OutbreakID)
                                                        .FirstOrDefault<Outbreak>();

                if (existingOutbreak != null)
                {
                    existingOutbreak.AreaID = outbreak.AreaID;
                    existingOutbreak.OutbreakCity = outbreak.OutbreakCity;
                    existingOutbreak.OutbreakDate = outbreak.OutbreakDate;
                    existingOutbreak.OutbreakDescription = outbreak.OutbreakDescription;
                    existingOutbreak.NumberOfCasualties = outbreak.NumberOfCasualties;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Cause/updateCause")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateCause(Cause Cause)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingCause = ctx.Causes.Where(s => s.CauseID == Cause.CauseID)
                                                        .FirstOrDefault<Cause>();

                if (existingCause != null)
                {
                    existingCause.DiseaseID = Cause.DiseaseID;
                    existingCause.CauseDescription = Cause.CauseDescription;
                    existingCause.CauseRanking = Cause.CauseRanking;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }

        [System.Web.Http.Route("api/Prevention/updatePrevention")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updatePrevention(Prevention Prevention)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingPrevention = ctx.Preventions.Where(s => s.PreventID == Prevention.PreventID)
                                                        .FirstOrDefault<Prevention>();

                if (existingPrevention != null)
                {
                    existingPrevention.CauseID = Prevention.CauseID;
                    existingPrevention.PreventDescription = Prevention.PreventDescription;
                    existingPrevention.PreventEffective = Prevention.PreventEffective;


                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }

        [System.Web.Http.Route("api/SuppliesList/updateSuppliesList")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateSuppliesList(SuppliesList SuppliesList)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingSuppliesList = ctx.SuppliesLists.Where(s => s.SupplyID == SuppliesList.SupplyID)
                                                        .FirstOrDefault<SuppliesList>();

                if (existingSuppliesList != null)
                {
                    existingSuppliesList.SupplyName = SuppliesList.SupplyName;
                    existingSuppliesList.AvailableAt = SuppliesList.AvailableAt;
                    existingSuppliesList.PreventID = SuppliesList.PreventID;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Disease/updateDisease")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateDisease(Disease Disease)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingDisease = ctx.Diseases.Where(s => s.DiseaseID == Disease.DiseaseID)
                                                        .FirstOrDefault<Disease>();

                if (existingDisease != null)
                {
                    existingDisease.CommonName = Disease.CommonName;
                    existingDisease.ScientificName = Disease.ScientificName;
                    existingDisease.Pathogen = Disease.Pathogen;
                    existingDisease.DiseaseDescription = Disease.DiseaseDescription;
                    existingDisease.IncubationPeriod = Disease.IncubationPeriod;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Specialist/updateSpecialist")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateSpecialist(Specialist Specialist)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingSpecialist = ctx.Specialists.Where(s => s.SpecialistID == Specialist.SpecialistID)
                                                        .FirstOrDefault<Specialist>();

                if (existingSpecialist != null)
                {
                    existingSpecialist.DiseaseID = Specialist.DiseaseID;
                    existingSpecialist.FirstName = Specialist.FirstName;
                    existingSpecialist.LastName = Specialist.LastName;
                    existingSpecialist.UserGUID = Specialist.UserGUID;
                    existingSpecialist.UserPassword = Specialist.UserPassword;
                    existingSpecialist.ContactNumber = Specialist.ContactNumber;
                    existingSpecialist.Email = Specialist.Email;
                    existingSpecialist.GUIDExpiry = Specialist.GUIDExpiry;
                    existingSpecialist.Hospital = Specialist.Hospital;
                    existingSpecialist.Qualification = Specialist.Qualification;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Subtype/updateSubtype")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateSubtype(Subtype Subtype)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingSubtype = ctx.Subtypes.Where(s => s.SubtypeID == Subtype.SubtypeID)
                                                        .FirstOrDefault<Subtype>();

                if (existingSubtype != null)
                {
                    existingSubtype.SubtypeDescription = Subtype.SubtypeDescription;
                    existingSubtype.SubtypeName = Subtype.SubtypeName;
                    existingSubtype.Strain = Subtype.Strain;
                    existingSubtype.DiseaseID = Subtype.DiseaseID;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Symptom/updateSymptom")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateSymptom(Symptom Symptom)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingSymptom = ctx.Symptoms.Where(s => s.SymptomID == Symptom.SymptomID)
                                                        .FirstOrDefault<Symptom>();

                if (existingSymptom != null)
                {
                    existingSymptom.DiseaseID = Symptom.DiseaseID;
                    existingSymptom.DefiningCharacteristic = Symptom.DefiningCharacteristic;
                    existingSymptom.SymptomAppears = Symptom.SymptomAppears;
                    existingSymptom.SymptomDescription = Symptom.SymptomDescription;
                    existingSymptom.SymptomName = Symptom.SymptomName;
                    existingSymptom.SymptomSeverity = Symptom.SymptomSeverity;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

        [System.Web.Http.Route("api/Treatment/updateTreatment")]
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult updateTreatment(Treatment Treatment)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new DiseaseDBEntities())
            {
                var existingTreatment = ctx.Treatments.Where(s => s.TreatmentID == Treatment.TreatmentID)
                                                        .FirstOrDefault<Treatment>();

                if (existingTreatment != null)
                {
                    existingTreatment.TreatmentDuration = Treatment.TreatmentDuration;
                    existingTreatment.TreatmentEffective = Treatment.TreatmentEffective;
                    existingTreatment.TreatmentName = Treatment.TreatmentName;
                    existingTreatment.TreatmentDescription = Treatment.TreatmentDescription;
                    existingTreatment.DiseaseID = Treatment.DiseaseID;
                    existingTreatment.AfterCare = Treatment.AfterCare;
                    existingTreatment.Aftermath = Treatment.Aftermath;
                    existingTreatment.AvailableAt = Treatment.AvailableAt;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }


            return Ok();
        }

    }
}
