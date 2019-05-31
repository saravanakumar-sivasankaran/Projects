using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatten
{
    public class DependencyInjection
    {
        static void Main()
        {
            Client cl = null;

            School s = new School();
            cl = new Client(s);
            cl.Name();

            College c = new College();
            cl = new Client(c);
            cl.Name();

            // Wait for user
            Console.ReadKey();
        }      
    }

    public interface Iservice
    {
        void GetName();
    }

    public class School : Iservice
    {
        public void GetName() { Console.WriteLine("School Name: ABS "); }
    }

    public class College : Iservice
    {
        public void GetName() { Console.WriteLine("College Name: ZAX "); }
    }

    public class Client
    {
        private Iservice _service;

        public Client(Iservice service)
        {
            _service = service;
        }

        public void Name()
        {
            _service.GetName();
        }
    }
}
