using System;
using System.Collections.Generic;
using System.Text;
using RJ.Domaine;
using System.Linq;
namespace RJ.Service
{
    class ProviderManager
    {   //////////////////////////////semaine5-seance1///////////////////////////////////////
        List<Provider> providers;
        public ProviderManager(List<Provider> providers)
        {
            this.providers = providers;
        }
        public List<Provider> GetProviderByName(string name)
        {
            var query = from prov in providers
                        where prov.UserName.Contains(name)
                        select prov;
            return query.ToList();
        }

        public Provider GetFirstProviderByName(string name)
        {
            var query = from prov in providers
                        where prov.UserName.Contains(name)
                        select prov;
            return query.First();
        }

        public Provider GetProviderById(int id)
        {
            var query = from prov in providers
                        where prov.Id==id
                        select prov;
            return query.Single();

        }
    }
}
