using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Domain.ValueObjects
{
    public record PeronalTipo: ValueObject
    {
        public int Value { get; }
        public PeronalTipo(int value)
        {
            if (value == 0)
            {
                throw new BussinessRuleValidationException("Se debe ingresar el tipo de personal");
            }
            else if (value == 1)
            {
                throw new BussinessRuleValidationException("El tipo no esta en el catalogo");
            }
            Value = value;
        }

        public static implicit operator int(PeronalTipo value)
        {
            return value.Value;
        }

        public static implicit operator PeronalTipo(int value)
        {
            return new PeronalTipo(value);
        }
    }
}
