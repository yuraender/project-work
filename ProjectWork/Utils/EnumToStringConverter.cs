using System;
using System.ComponentModel;
using System.Globalization;

namespace ProjectWork.Utils {

    public class EnumToStringConverter : TypeConverter {

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) {
            return (sourceType.Equals(typeof(Enum)));
        }

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return (destinationType.Equals(typeof(string)));
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) {
            return base.ConvertFrom(context, culture, value);
        }

        public override object ConvertTo(
            ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType
        ) {
            if (!value.GetType().BaseType.Equals(typeof(Enum))) {
                throw new ArgumentException("Can only convert an enum.");
            }
            if (!destinationType.Equals(typeof(string))) {
                throw new ArgumentException("Can only convert to string.");
            }
            return ((Enum) value as Enum).GetDescription();
        }
    }
}
