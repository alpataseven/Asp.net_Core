using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal _servicedal;

        public ServiceManager(IServiceDal servicedal)
        {
            _servicedal = servicedal;
        }

        public List<Service> GetList()
        {
            return _servicedal.GetList();
        }

        public void TAdd(Service t)
        {
            _servicedal.Insert(t);
        }

        public void TDelete(Service t)
        {
            _servicedal.Delete(t);
        }

        public Service TGetById(int id)
        {
            return _servicedal.GetById(id);
        }

        public void TUpdate(Service t)
        {
            _servicedal.Update(t);
        }
    }
}
