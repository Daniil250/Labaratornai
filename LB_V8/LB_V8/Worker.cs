using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_V8
{
    public class Worker : Human
    {
        #region Properties
        public double Salary { get; set; }
        #endregion
        #region Methods
        public void DoWork() { }
        public override string ToString()
        {
            return string.Format(
                "Class Worker: \n FullName: {0}, Height: {1}, Width: {2}, Salary: {3}",
                FullName,
                Height,
                Weight,
                Salary
            );
        }
        #endregion
    }
}
