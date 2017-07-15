using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace FormsAssistControl
{
    public class ObservableBaseObject:INotifyPropertyChanged
    {
        public ObservableBaseObject()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged = delegate {
        };

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
