using System;

namespace MultiBooks_Utility
{
  public class AppConst
  {
    // Paths images données
    public static string ImagePathBooks = @"\images\Books\";
    public static string ImagePathBooksView = @"/images/Books/";

    public static string ImagePathAuthors = @"\images\Authors\";
    public static string ImagePathAuthorsView = @"/images/Authors/";

    // Constantes pour les notifications: éviter les string magiques dans le code
    public const string Success = "Success";
    public const string Error = "Error";

    }
}
