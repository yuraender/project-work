using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace ProjectWork.Utils {

    public static class Extensions {

        public static V GetOrDefault<K, V>(this IDictionary<K, V> collection, K key, V defaultValue) {
            if (collection.ContainsKey(key)) {
                return collection[key];
            } else {
                return defaultValue;
            }
        }

        public static void ComputeIfAbsent<K, V>(this IDictionary<K, V> collection, K key, V value) {
            if (collection.ContainsKey(key)) {
                collection[key] = value;
            } else {
                collection.Add(key, value);
            }
        }

        public static string GetDescription(this Enum value) {
            FieldInfo field = value.GetType().GetField(value.ToString());
            object[] attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length == 0
                ? value.ToString()
                : ((DescriptionAttribute) attributes[0]).Description;
        }
    }
}
