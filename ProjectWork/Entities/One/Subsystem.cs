using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace ProjectWork.Entities.One {

    public class Subsystem {

        public string Name {
            get; set;
        }
        public List<Characteristic> Characteristics {
            get; set;
        }
        public List<Implementation> Implementations {
            get; set;
        }

        public override string ToString() {
            return Name;
        }

        public class Implementation {

            [JsonIgnore]
            public Subsystem Owner {
                get; set;
            }
            public Dictionary<Characteristic, double> Values {
                get; set;
            }

            public override string ToString() {
                StringBuilder sb = new StringBuilder();
                if (Owner != null) {
                    sb.Append(Owner.Name).Append(" ");
                }
                sb.Append(string.Join("; ", Values.Values));
                return sb.ToString();
            }
        }
    }
}
