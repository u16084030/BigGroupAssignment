using MalariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MalariaAPI.ViewModels
{
    public class UserVM
    {
        public Specialist user;

        public void RefreshGUID(DiseaseDBEntities db)
        {
            db.Configuration.ProxyCreationEnabled = false;
            user.UserGUID = Guid.NewGuid().ToString();
            user.GUIDExpiry = DateTime.Now.AddMinutes(30);
            var guids = db.Specialists.Where(zz => zz.UserGUID == user.UserGUID).Count();
            if(guids > 0)
            {
                RefreshGUID(db);
            }
            else
            {
                var u = db.Specialists.Where(cc => cc.SpecialistID == user.SpecialistID).FirstOrDefault();
                db.Entry(u).CurrentValues.SetValues(user);
                db.SaveChanges();
            }
        }

        public bool IsLoggedIn(DiseaseDBEntities db)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var guids = db.Specialists.Where(zz => zz.UserGUID == user.UserGUID && zz.GUIDExpiry > DateTime.Now).Count();
            if(guids > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLoggedIn(DiseaseDBEntities db, string uGUID)
        {
            db.Configuration.ProxyCreationEnabled = false;
            user = db.Specialists.Where(zz => zz.UserGUID == uGUID && zz.GUIDExpiry > DateTime.Now).FirstOrDefault();
            if(user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}