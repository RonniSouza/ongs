using System;
using System.Collections.Generic;

namespace Ongs.Domain.Entities
{
    public abstract class Base
    {
        public long Id { get; set; }
        public IReadOnlyCollection<string> Errors => _errors;
        internal List<string> _errors;

        public abstract bool Validate();
    }
}
