using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin_Exchange
{
    static class Exchanger
    {
        private const double _usdtogbp = 0.72523;
        private const double _usdtocan = 1.25427;
        private const double _usdtoeur = 0.83572;
        private const double _gpbtousd = 1.37887;
        private const double _gpbtocan = 1.72947;
        private const double _gbptoeur = 1.15195;
        private const double _cantousd = 0.79728;
        private const double _cantogbp = 0.57848;
        private const double _cantoeur = 0.66645;
        private const double _eurtousd = 1.19648;
        private const double _eurtogbp = 0.86826;
        private const double _eurtocan = 1.50040;
        private static double _newCurrency;
        private static double _usdCurrency;

        public static void AssignCurrency(double Currency)
        {
            _newCurrency = Currency;
        }

        public static double USDtoUSD(double Currency)
        {
            AssignCurrency(Currency);

            if (_newCurrency == 0)
            {
                _newCurrency = Math.Round((Currency), 2);
                _usdCurrency = _newCurrency;
            }
            else
            {
                _usdCurrency = Math.Round((Currency), 2);
            }

            return _newCurrency;
        }

        public static double USDtoGBP(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _usdtogbp), 2);
            GBPtoUSD(_newCurrency);
            return _newCurrency;
        }

        public static double USDtoCAN(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _usdtocan), 2);
            CANtoUSD(_newCurrency);
            return _newCurrency;
        }

        public static double USDtoEUR(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _usdtoeur), 2);
            EURtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double GBPtoGBP(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency), 2);
            GBPtoUSD(_newCurrency);
            return _newCurrency;
        }

        public static double GBPtoUSD(double Currency)
        {
            AssignCurrency(Currency);

            if (_newCurrency == 0)
            {
                _newCurrency = Math.Round((Currency * _gpbtousd), 2);
                _usdCurrency = _newCurrency;
            }
            else
            {
                _usdCurrency = Math.Round((Currency * _gpbtousd), 2);
            }

            return _newCurrency;
        }

        public static double GBPtoCAN(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _gpbtocan), 2);
            CANtoUSD(_newCurrency);
            return _newCurrency;
        }

        public static double GBPtoEUR(double Currency)
        {
            AssignCurrency(Currency);

            if (_newCurrency == 0)
            {
                _newCurrency = Math.Round((Currency * _gbptoeur), 2);
            }
            EURtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double CANtoCAN(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency), 2);
            CANtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double CANtoUSD(double Currency)
        {

            AssignCurrency(Currency);

            if (_newCurrency == 0)
            {
                _newCurrency = Math.Round((Currency * _cantousd), 2);
                _usdCurrency = _newCurrency;
            }
            else
            {
                _usdCurrency = Math.Round((Currency * _cantousd), 2);
            }

            return _newCurrency;
        }
        public static double CANtoGBP(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _cantogbp), 2);
            GBPtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double CANtoEUR(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _cantoeur), 2);
            EURtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double EURtoEUR(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency), 2);
            EURtoUSD(_newCurrency);

            return _newCurrency;
        }
        public static double EURtoUSD(double Currency)
        {

            AssignCurrency(Currency);

            if (_newCurrency == 0)
            {
                _newCurrency = Math.Round((Currency * _eurtousd), 2);
                _usdCurrency = _newCurrency;
            }
            else
            {
                _usdCurrency = Math.Round((Currency * _eurtousd), 2);
            }
            return _newCurrency;
        }
        public static double EURtoGBP(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _eurtogbp), 2);
            GBPtoUSD(_newCurrency);
            return _newCurrency;
        }
        public static double EURtoCAN(double Currency)
        {
            AssignCurrency(Currency);
            _newCurrency = Math.Round((Currency * _eurtocan), 2);
            CANtoUSD(_newCurrency);
            USD();
            return _newCurrency;
        }

        public static double USD()
        {
            return _usdCurrency;
        }


    }
}
