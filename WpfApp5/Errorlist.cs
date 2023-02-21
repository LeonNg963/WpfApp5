using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp5.ViewModel
{
    class Errorlist : INotifyPropertyChanged
    {
        private static readonly Errorlist DummyChild = new Errorlist();

        private readonly ObservableCollection<Errorlist> children;
        private readonly Errorlist parent;

        private string error;
        private string value_str;
        private SolidColorBrush color;
        private int value;


        public Errorlist(Errorlist parent, bool lazyLoadChildren)
        {
            this.parent = parent;

            children = new ObservableCollection<Errorlist>();

            if (lazyLoadChildren)
                children.Add(DummyChild);
        }

        // This is used to create the DummyChild instance.
        public Errorlist()
        {
        }

        public ObservableCollection<Errorlist> Children
        {
            get { return children; }
        }

        /// <summary>
        /// Returns true if this object's Children have not yet been populated.
        /// </summary>
        public bool HasDummyChild
        {
            get { return Children.Count == 1 && Children[0] == DummyChild; }
        }

        public string ERROR
        {
            get { return error; }
            set { error = value; }
        }
        public SolidColorBrush Status
        {
            get { return color; }
            set { color = value;  OnPropertyChanged("Status"); }
        }
        public String Status_str
        {
            get { return value_str; }
            set { value_str = value; }
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Errorlist Parent
        {
            get { return parent; }
        }
        #region INotifyPropertyChanged members

        /// <summary>
        /// Raised when a property on this object has a new value.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises this object's PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The property that has a new value.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion INotifyPropertyChanged members

    }
}
