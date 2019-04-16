using System;
using System.Runtime.CompilerServices;

namespace FunctionalFluent.Model
{
    public sealed class Money :IEquatable<Money>
    {
        public  Money(decimal amount,string currency) 
        {
            Currency = currency;
            Amount = amount;
        }

        public string Currency { get; }
        public decimal Amount { get; }
        public Money Scale(decimal factor) => new Money(this.Amount * factor, this.Currency);

        public Money Subtract(Money moneytobeSubtracted) => new Money(this.Amount - moneytobeSubtracted.Amount, this.Currency);

        public static Money operator *(Money amount, decimal factor) => amount.Scale(factor);

        public static Money operator -(Money money1, Money money2) => money1.Subtract(money2);

        public override bool Equals(object obj) =>
            this.Equals(obj as Money);

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Currency != null ? Currency.GetHashCode() : 0) * 397) ^ Amount.GetHashCode();
            }
        }

        public bool Equals(Money other) =>
            other != null &&
            this.Amount == other.Amount &&
            this.Currency == other.Currency;

        public override string ToString() => $"{this.Amount} {this.Currency}";
    }
}
