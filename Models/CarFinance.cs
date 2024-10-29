using System;
using System.ComponentModel.DataAnnotations;
namespace CarQuest.Models;

public class CarFinance
{
    [Required(ErrorMessage = "Please enter the loan amount.")]
    [Range(1, 100000, ErrorMessage = "Loan amount must be between 1 and 100,000.")]
    public decimal? LoanAmount { get; set; }

    [Required(ErrorMessage = "Please enter a yearly interest rate.")]
    [Range(0.1, 20.0, ErrorMessage = "Yearly interest rate must be between 0.1 and 20.0.")]
    public decimal? YearlyInterestRate { get; set; }

    [Required(ErrorMessage = "Please enter a number of years.")]
    [Range(1, 30, ErrorMessage = "Loan term must be between 1 and 30 years.")]
    public int? Years { get; set; }

    public decimal? CalculateMonthlyPayment()
    {
        if (LoanAmount == null || YearlyInterestRate == null || Years == null)
        {
            return null;
        }

        decimal loanAmount = LoanAmount.Value;
        decimal monthlyInterestRate = YearlyInterestRate.Value / 12 / 100;
        int totalPayments = Years.Value * 12;

        if (monthlyInterestRate == 0) // Handle zero interest rate
        {
            return loanAmount / totalPayments;
        }

        decimal monthlyPayment = loanAmount *
            (monthlyInterestRate * (decimal)Math.Pow((1 + (double)monthlyInterestRate), totalPayments) /
            ((decimal)Math.Pow((1 + (double)monthlyInterestRate), totalPayments) - 1));

        return monthlyPayment;
    }
}

