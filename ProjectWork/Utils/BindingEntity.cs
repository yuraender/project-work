using System.ComponentModel;
using System.Windows.Forms;

namespace ProjectWork.Utils {

    public class BindingEntity<T> : INotifyPropertyChanged {

        private T _value;
        public T Value {
            get => _value;
            set {
                _value = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged() {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(null));
            }
        }

        public override string ToString() {
            return _value.ToString();
        }
    }
}
