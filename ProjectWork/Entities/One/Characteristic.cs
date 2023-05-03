using ProjectWork.Utils;
using System.ComponentModel;

namespace ProjectWork.Entities.One {

    public class Characteristic {

        public string Name {
            get; set;
        }
        public double Min {
            get; set;
        }
        public double Max {
            get; set;
        }
        public CharacteristicType Type {
            get; set;
        }
        public CharacteristicCriteria Criteria {
            get; set;
        }

        public override bool Equals(object obj) {
            if (obj == null || !GetType().Equals(obj.GetType())) {
                return false;
            }
            Characteristic other = (Characteristic) obj;
            return (Name, Min, Max, Type, Criteria)
                .Equals((other.Name, other.Min, other.Max, other.Type, other.Criteria));
        }

        public override int GetHashCode() {
            return (Name, Min, Max, Type, Criteria).GetHashCode();
        }

        public override string ToString() {
            return $"{Name}, {Min}-{Max}, {Type.GetDescription()}, {Criteria.GetDescription()}";
        }
    }

    [TypeConverter(typeof(EnumToStringConverter))]
    public enum CharacteristicType {

        [Description("Складывается")]
        Additive,
        [Description("Умножается")]
        Multiplicative
    }

    [TypeConverter(typeof(EnumToStringConverter))]
    public enum CharacteristicCriteria {

        [Description("В пределах")]
        Range,
        [Description("Максимальное")]
        Max
    }
}
