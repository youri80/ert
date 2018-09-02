using System;
namespace Ert.Core.Model
{
    public class Share
    {
        public string Mfif
        {
            get;
            set;
        }

        public string Cls
        {
            get;
            set;
        }

        public DateTime StartDate{
            get;
            set;
        }

        public DateTime? EndDate
        {
            get;
            set;
        }
    }
}
