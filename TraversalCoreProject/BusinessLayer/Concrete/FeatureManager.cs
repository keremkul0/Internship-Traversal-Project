using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FeatureManager:IFeature1Service
    {
        IFeature1Dal _feature1Dal;

        public FeatureManager(IFeature1Dal feature1Dal) 
        {
            _feature1Dal=feature1Dal;
        }

        public void TAdd(Feature1 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature1 t)
        {
            throw new NotImplementedException();
        }

        public Feature1 TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature1> TGetList()
        {
            return _feature1Dal.GetList();
        }

        public void TUpdate(Feature1 t)
        {
            throw new NotImplementedException();
        }
    }
}
