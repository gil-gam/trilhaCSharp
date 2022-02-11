using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;
using WebSupplier.Domain.Tools;

namespace WebSupplier.Domain.Models
{
    public class Email : Entity
    {
    public Guid SupplierId { get; private set; }

    public string EmailAddress { get; private set; }

    public Supplier Supplier { get; private set; }

    protected Email() { }

    public Email(Guid supplierId, string emailAddress)
    {
        SupplierId = supplierId;
        SetEmail(emailAddress);
    }

    public void SetEmail(string value)
    {
        //DomainValidation.ValidateIsNullOrEmpty(value, "The Email is mandatory.");
        EmailAddress = value;
    }

}
}
