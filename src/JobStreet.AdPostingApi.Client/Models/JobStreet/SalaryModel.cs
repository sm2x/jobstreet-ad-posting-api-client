﻿
namespace JobStreet.AdPostingApi.Client.Models.JobStreet
{
    public class SalaryModel
    {
        public SalaryModel()
        {
        }

        public SalaryModel(SalaryModel model)
        {
            this.Minimum = model.Minimum;
            this.Maximum = model.Maximum;
            this.CurrencyCode = model.CurrencyCode;
            this.Display = model.Display;
        }

        public decimal Minimum { get; set; }

        public decimal Maximum { get; set; }

        public int? CurrencyCode { get; set; }

        public bool Display { get; set; }
    }
}
