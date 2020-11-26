using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CrudOperations crud = new CrudOperations();

            //crud.displayDepartment();

            //crud.displayDepartmentById(50);

            //crud.updateDepartment(50,"IT");

            //crud.insertDepartment(100,"IT",125);

            //crud.displayDepartment();

            crud.displayByProc();
        }
    }
}
