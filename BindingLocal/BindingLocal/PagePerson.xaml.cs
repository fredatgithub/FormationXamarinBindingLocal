using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BindingLocal.Model;

namespace BindingLocal
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class PagePerson : ContentPage
  {
    public PagePerson()
    {
      Person p = null;
      InitializeComponent();
      p = new Person {Age = 25, Name = "james"};
      rootStack.BindingContext = p;
    }
  }
}