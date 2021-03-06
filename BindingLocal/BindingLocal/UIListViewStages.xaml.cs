﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindingLocal
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class UiListViewStages : ContentPage
  {
    public UiListViewStages()
    {
      InitializeComponent();
      var stages = DAL.DalStages.RetourStages();
      LstStages.ItemsSource = stages;
    }
  }
}