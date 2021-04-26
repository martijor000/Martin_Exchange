using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Exchange
{
    class ExchangeMonitor
    {
        private double _newDollars;
        private int _monitorAmount;

        public ExchangeMonitor()
        {

        }

        public void IncrementAmount()
        {
            _monitorAmount++;
        }


        public int TotalTransactions
        {
            get { return _monitorAmount; }
        }


        public double TotalUSD(double goodjob)
        {
            _newDollars = _newDollars + goodjob;
            return _newDollars;
        }
    }
}
