using System;
namespace Ert.Core.Model
{
    public class Calculation
    {
        public DateTime NavDate
        {
            get;
            set;
        }

        /// <summary>
        /// Aktuelles GJ-Ende (bezogen NavDate)
        /// </summary>
        /// <value>The business year end.</value>
        public DateTime BusinessYearEnd 
        {
            get;
            set;
        }

        /// <summary>
        /// Letztes GJ-Ende (bezogen auf NavDate)
        /// </summary>
        /// <value>The last business year end.</value>
        public DateTime LastBusinessYearEnd{

            get;
            set;
        }

        /// <summary>
        /// Vorletzes GJ-Ende (bezogen auf NavDate)
        /// </summary>
        /// <value>The previous last business year end.</value>
        public DateTime PrevLastBusinessYearEnd
        {
            get;
            set;
        }

        /// <summary>
        /// Datum der Aktienwerte
        /// </summary>
        /// <value>The share value.</value>
        public DateTime ShareValueDate {
            get;set;
        }

        public int CalcualtionID{
            get;set;
        }


      
    }
}
