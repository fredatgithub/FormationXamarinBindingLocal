using System.Collections.Generic;
using BindingLocal.Model;

namespace BindingLocal.DAL
{
  public static class DalStages
  {
    public static List<Stage> RetourStages()
    {
      var listeStages = new List<Stage>
      {
        new Stage
        {
          NomStage = "Stage1",
          DescriptionStage =
            "Stage Xamarin 1 : Vous découvrirez dans ce stage les capacités multiplateformes du framework Xamarin.Forms intégré à Visual Studio. Vous développerez et testerez des applications pour les téléphones mobiles iOS, Android et Windows Phone via les langages C# et XAML.  ",
          ImageStage = "ery_1.jpg"
        },
        new Stage
        {
          NomStage = "Stage2",
          DescriptionStage =
            "Stage Xamarin 2 : Vous découvrirez dans ce stage les capacités multiplateformes du framework Xamarin.Forms intégré à Visual Studio. Vous développerez et testerez des applications pour les téléphones mobiles iOS, Android et Windows Phone via les langages C# et XAML.",
          ImageStage = "ery_2.jpg"
        },
        new Stage
        {
          NomStage = "Stage3",
          DescriptionStage =
            "Stage Xamarin 3 : Vous découvrirez dans ce stage les capacités multiplateformes du framework Xamarin.Forms intégré à Visual Studio. Vous développerez et testerez des applications pour les téléphones mobiles iOS, Android et Windows Phone via les langages C# et XAML.",
          ImageStage = "ery_3.jpg"
        },
        new Stage
        {
          NomStage = "Stage4",
          DescriptionStage =
            "Stage Xamarin 4 : Vous découvrirez dans ce stage les capacités multiplateformes du framework Xamarin.Forms intégré à Visual Studio. Vous développerez et testerez des applications pour les téléphones mobiles iOS, Android et Windows Phone via les langages C# et XAML.",
          ImageStage = "ery_4.jpg"
        },
        new Stage
        {
          NomStage = "Stage5",
          DescriptionStage =
            "Stage Xamarin 5 : Vous découvrirez dans ce stage les capacités multiplateformes du framework Xamarin.Forms intégré à Visual Studio. Vous développerez et testerez des applications pour les téléphones mobiles iOS, Android et Windows Phone via les langages C# et XAML.",
          ImageStage = "ery_5.jpg"
        }
      };
      return listeStages;
    }
  }
}