using System.ComponentModel;
using BindingLocal.Annotations;

namespace BindingLocal.Model
{
  internal class Person : INotifyPropertyChanged
  {
    private int _age;
    public string Name { get; set; }

    public int Age
    {
      get { return _age; }
      set
      {
        if (this._age == value)
        {
          return;
        }

        _age = value;
        OnPropertyChanged(nameof(Age));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}