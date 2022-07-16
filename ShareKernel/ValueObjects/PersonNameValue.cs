using ShareKernel.Core;
using ShareKernel.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.ValueObjects
{
    public record PersonNameValue : ValueObject
    {
        public string Name { get; }

        public PersonNameValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if(name.Length > 500)
            {
                throw new BussinessRuleValidationException("el nombre de la persoanl debe ser menor a 500 caracteres");
            }
            Name = name;
        }

        public static implicit operator string(PersonNameValue value)
        {
            return value.Name;
        }

        public static implicit operator PersonNameValue(string name)
        {
            return new PersonNameValue(name);
        }
    }
}
