using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Users us1 = new Users {LastName = "Vadim", FirstName = "Bezhkov",
                Email = "vadimbezhkov3112@gmail.com",Login="Vadim", Password="123",
                SecondName="Alexandrovich",TimeRegistration = DateTime.Now };
            Users us3;
         
            //using (UserContext db = new UserContext())
            //{
            //    //if (us3 != null)
                
            //    //us3.DateBirth = null;
            //    //db.SaveChanges();
            //    db.Users.Add(us1);
            //    //db.Users.Attach(us3);
            //    db.SaveChanges();
            //    //Users us1 = db.Users.FirstOrDefault(e=>e.Login=="Vadim");
            //    //us1.DateBirth = new DateTime(1988,12,31);
            //    //db.SaveChanges();
            //    //foreach (Users u in db.Users)
            //    //    Console.WriteLine("{0}.{1} - {2}", u.ID, u.LastName, u.FirstName);
            //}
            using (UserContext db = new UserContext())
            {
                us3 = db.Users.FirstOrDefault(e => e.Login == "Vadim");
            }
            using (UserContext db = new UserContext())
            {
                if (us3 != null)
                {
                    
                    us3.DateBirth = null;
                    db.Entry(us3).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    //if (us3 != null)
                    //{
                    //    db.Users.Attach(us3);
                    //    us3.DateBirth = null;
                    //    db.SaveChanges();
                    //}
                }
            }
            //using (UserContext db1 = new UserContext())
            //{
            //    if (us3 != null)
            //    {
            //        //db1.Users.Attach(us3);
            //        us3.DateBirth = null;
            //        db1.SaveChanges();
            //    }
            //}
            //using (UserContext db = new UserContext())
            //{
            //    if (us3 != null)
            //    {
            //        db.Users.Attach(us3);
            //        us3.DateBirth = new DateTime(1988, 12, 31);
            //        db.SaveChanges();
            //    }
            //}

            Console.ReadKey();
        }
    }
}
