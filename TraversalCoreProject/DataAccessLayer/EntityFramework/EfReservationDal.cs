using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWhitReservationByAccepted(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Approved" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWhitReservationByPrevious(int id)
        {
            using (var context = new Context())
            {
                return context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Past Booking" && x.AppUserId == id).ToList();
            }
        }

        public List<Reservation> GetListWhitReservationByWaitApproval(int id)
        {
            using (var context= new Context())
            {
                return context.Reservations.Include(x=>x.Destination).Where(x=>x.Status== "Waiting for Approval" && x.AppUserId==id).ToList();
            }
        }
    }
}
