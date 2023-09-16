using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWhitReservationByWaitApproval(int id);
        List<Reservation> GetListWhitReservationByAccepted(int id);
        List<Reservation> GetListWhitReservationByPrevious(int id);
    }
}
