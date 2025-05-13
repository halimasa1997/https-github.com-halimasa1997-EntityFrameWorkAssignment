using EntityFrameWork.Context;
using EntityFrameWork.Model;

namespace EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirLines airLines = new AirLines ("Alsalam", 34, "alsalam@gmail", "Ali");
            AirLines airl1 = airLines;
         ApplicationDbContext _context = new ApplicationDbContext();
            _context.Airliness.Add(airl1);
            _context.SaveChanges();
        
        }
    }
}
