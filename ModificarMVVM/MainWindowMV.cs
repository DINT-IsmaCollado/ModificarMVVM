using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificarMVVM
{
    class MainWindowMV : INotifyPropertyChanged
    {
        IsmaBDEntities contexto;


        public MainWindowMV(IsmaBDEntities contexto)
        {
            this.contexto = contexto;
        }

        public void Modificar()
        {
            contexto.SaveChanges();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
