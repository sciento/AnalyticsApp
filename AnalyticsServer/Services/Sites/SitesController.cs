using AnalyticsServer.Models;
using AnalyticsServer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AnalyticsServer.Controller
{
    public class SitesController
    {
        private Guid SiteId;
        private Guid UserId;
        private RequestUser ru = new RequestUser();
        private AnalyticsEntities ae = new AnalyticsEntities();

        private List<Sites> sites;


        public SitesController(string id, string pid)
        {
            UserId = new Guid(id);
            SiteId = new Guid(pid);
        }

        public SitesController(string id)
        {
            UserId = new Guid(id);
        }

        public void GetAll()
        {
            sites = ae.Sites.Where(s => s.UserId == UserId).ToList();
        }

        public void Get()
        {
            sites = ae.Sites.Where(s => s.UserId == UserId && s.Id == SiteId).ToList();
        }


    }
}