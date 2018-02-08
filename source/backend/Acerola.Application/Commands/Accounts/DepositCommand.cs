﻿namespace Acerola.Application.Commands.Accounts
{
    using MediatR;
    using System;
    using System.Runtime.Serialization;
    using Acerola.Domain.Accounts;

    [DataContract]
    public class DepositCommand : IRequest<Transaction>
    {
        [DataMember]
        public Guid AccountId { get; set; }

        [DataMember]
        public Double Amount { get; set; }
    }
}
