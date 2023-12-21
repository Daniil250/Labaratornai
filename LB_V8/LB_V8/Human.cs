using LB_V8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_V8
{
    public interface IHuman
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Height { get; set; }
        double Weight { get; set; }
    }
    public class Human : IHuman, IComparable<Human>
    {
        #region Propeties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Height { get; set; }
        public double Weight { get; set; }
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        #endregion
        #region Methods
        public int CompareTo(Human other)
        {
            return string.Compare(other.FullName, FullName,
                StringComparison.InvariantCultureIgnoreCase);
        }
        public override string ToString()
        {
            return string.Format("Class Human: \n FullName: {0}, Height: {1}, Width: {2}",
                FullName,
                Height, Weight);
        }
        #endregion
    }
}
