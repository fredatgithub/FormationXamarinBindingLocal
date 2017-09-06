using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BindingLocal.Model;

namespace BindingLocal
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class PagePerson : ContentPage
  {
    Person p = null;
    public PagePerson()
    {
      InitializeComponent();
      p = new Person {Age = 25, Name = "james"};
      rootStack.BindingContext = p;
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
      p.Age++;
      lblAge.Text = p.Age.ToString();
    }
  }
}