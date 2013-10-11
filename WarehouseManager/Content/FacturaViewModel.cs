using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Properties;

namespace WarehouseManager
{
    class FacturaViewModel : INotifyPropertyChanged
    {
        private Factura Model;
        public void ViewModel(Factura model)
        {
            this.Model = model;
        }

        public int IdProvedor
        {
            get { return Model.IdProvedor; }
            set
            {
                Model.IdProvedor = value;
                OnPropertyChanged("IdProvedor");
            }
        }

        public DateTime Fecha
        {
            get { return Model.Fecha; }
            set
            {
                Model.Fecha = value;
                OnPropertyChanged("Fecha");
            }
        }

        public int IdFactura
        {
            get { return Model.IdFactura; }
            set
            {
                Model.IdFactura = value;
                OnPropertyChanged("IdFactura");
            }
        }

        public string NoFactura
        {
            get { return Model.NoFactura; }
            set
            {
                Model.NoFactura = value;
                OnPropertyChanged("NoFactura");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }
    }
}
