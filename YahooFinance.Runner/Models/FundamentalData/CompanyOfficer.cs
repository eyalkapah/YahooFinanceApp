namespace YahooFinance.Runner.Models.FundamentalData
{
    public class CompanyOfficer
    {
        public int MaxAge { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Title { get; set; }

        public int YearBorn { get; set; }

        public int FiscalYear { get; set; }

        public Value TotalPay { get; set; }

        public Value ExercisedValue { get; set; }

        public Value UnexercisedValue { get; set; }
    }
}
