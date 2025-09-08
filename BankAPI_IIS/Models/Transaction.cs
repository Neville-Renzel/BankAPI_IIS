using System;
using System.Collections.Generic;

namespace BankAPI_IIS.Models;

public partial class Transaction
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public string TransactionType { get; set; } = null!;

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    public DateTime TransactionDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;
}
