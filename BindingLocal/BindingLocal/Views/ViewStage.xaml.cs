using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingLocal.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ViewStage : DataTemplate
  {
    public ViewStage()
    {
      InitializeComponent();
    }

    //public static implicit operator Page(ViewStage v)
    //{
      
    //}
  }
}