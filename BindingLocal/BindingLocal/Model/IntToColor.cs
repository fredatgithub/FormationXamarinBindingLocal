using System;
using System.Globalization;
using XF =  Xamarin.Forms;

namespace BindingLocal.Model
{
  internal class IntToColor : XF.IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (targetType != typeof(XF.Color))
      {
        return null;
      }

      int age = int.Parse(value.ToString());
      return age > 30 ? XF.Color.Green : XF.Color.Aqua;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}