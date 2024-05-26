using CalculationSimulatorAPI.Dominio.Calculation.CDB;
using CalculationSimulatorAPI.Dominio.Calculation.IR;
using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Facade
{
    public class Facade
    {
        private ICalculeCDB _CalculeCDB;
        private ICalculeIR _CalculeIR;

        private decimal _valueInitial;
        private int _numberOfMonths;

        public decimal resultGross { get; set; }
        public decimal resultNet { get; set; }        


        public Facade(decimal valueInitial, int numberOfMonths)
        {
            _valueInitial = valueInitial;
            _numberOfMonths = numberOfMonths;

            _CalculeCDB = new CalculeCDB(_valueInitial);
            _CalculeIR =  new CalculeIR(_valueInitial);
        }

        public void CalculateValueCDB()
        {         
            var valorFinalCDB = _CalculeCDB.CalculateValueCDB(_numberOfMonths);
            var valorIf = _CalculeIR.CalculateIncomeTax(valorFinalCDB, _numberOfMonths);

            resultGross = valorFinalCDB;
            resultNet = valorFinalCDB - valorIf;
        }
    }
}
