#region Namespaces
using System;
using System.Reflection;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
#endregion

namespace PostAddinCommand
{
  class App : IExternalApplication
  {
    public const string Caption
      = "Post Add-in Command";

    static string _namespace_prefix
      = typeof( App ).Namespace + ".";

    const string _name = "Dummy2";

    const string _class_name = "Cmd" + _name;

    const string _tooltip
      = "Test command two for PostAddinCommand";

    public Result OnStartup(
      UIControlledApplication a )
    {
      Assembly exe = Assembly.GetExecutingAssembly();
      string path = exe.Location;

      // Create ribbon panel

      RibbonPanel p = a.CreateRibbonPanel( Caption );

      // Create command button

      PushButtonData d = new PushButtonData(
        _name, _name, path,
        _namespace_prefix + _class_name );

      d.ToolTip = _tooltip;

      RibbonItem i = p.AddItem( d );

      return Result.Succeeded;
    }

    public Result OnShutdown( UIControlledApplication a )
    {
      return Result.Succeeded;
    }
  }
}
