using ProjectWork.Utils;
using System.Collections.Generic;
using static ProjectWork.Entities.One.Subsystem;

namespace ProjectWork.Entities.One {

    public class Combination {

        public List<Implementation> Implementations {
            get; set;
        }

        private readonly Dictionary<Characteristic, double> comboValues;

        public Combination() {
            comboValues = new Dictionary<Characteristic, double>();
        }

        public bool IsValid() {
            foreach (KeyValuePair<Characteristic, double> pair in Calculate()) {
                if (pair.Key.Criteria != CharacteristicCriteria.Range) {
                    continue;
                }
                if (pair.Value <= pair.Key.Min || pair.Value > pair.Key.Max) {
                    return false;
                }
            }
            return true;
        }

        public Dictionary<Characteristic, double> Calculate() {
            if (comboValues.Count == 0) {
                foreach (Implementation implementation in Implementations) {
                    foreach (KeyValuePair<Characteristic, double> pair in implementation.Values) {
                        switch (pair.Key.Type) {
                            case CharacteristicType.Additive: {
                                comboValues.ComputeIfAbsent(pair.Key,
                                    comboValues.GetOrDefault(pair.Key, 0.0D) + pair.Value);
                                break;
                            }
                            case CharacteristicType.Multiplicative: {
                                comboValues.ComputeIfAbsent(pair.Key,
                                    comboValues.GetOrDefault(pair.Key, 1.0D) * pair.Value);
                                break;
                            }
                        }
                    }
                }
            }
            return comboValues;
        }

        public override string ToString() {
            return "Связка";
        }
    }
}
