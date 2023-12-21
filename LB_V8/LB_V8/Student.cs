using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_V8
{
    public class Student : Human
    {
        #region Properties
        public string University { get; set; }
        #endregion
        #region Methods
        public void DoStudy() { }
        public override string ToString()
        {
            return string.Format("Class Student: \n FullName: {0}, Height: {1}, Width: {2}, University: {3}",
            FullName,
            Height,
            Weight,
            University
                );
        }
        #endregion
    }
}
