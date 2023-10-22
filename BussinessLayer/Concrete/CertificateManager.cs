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
    public class CertificateManager: IGenericService<Certificate>
    {
        ICertificateDal _certificateDal;

        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public void TAdd(Certificate t)
        {
            _certificateDal.Update(t);
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public Certificate TGetByID(int id)
        {
            return _certificateDal.GetByID(id);
        }

        public List<Certificate> TGetList()
        {
            return _certificateDal.GetList();
        }

        public List<Certificate> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
