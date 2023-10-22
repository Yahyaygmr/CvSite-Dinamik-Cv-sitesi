using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class HobbyManager : IGenericService<Hobby>
    {
        IHobbyDal _hobbyDal;

        public HobbyManager(IHobbyDal hobbyDal)
        {
            _hobbyDal = hobbyDal;
        }

        public void TAdd(Hobby t)
        {
            _hobbyDal.Insert(t);
        }

        public void TDelete(Hobby t)
        {
            _hobbyDal.Delete(t);
        }

        public Hobby TGetByID(int id)
        {
            return _hobbyDal.GetByID(id);
        }

        public List<Hobby> TGetList()
        {
            return _hobbyDal.GetList();
        }

        public List<Hobby> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Hobby t)
        {
            _hobbyDal.Update(t);
        }
    }
}
