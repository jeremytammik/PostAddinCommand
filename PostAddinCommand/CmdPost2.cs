#region Namespaces
using System;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
#endregion

namespace PostAddinCommand
{
  /// <summary>
  /// External command to programmatically launch 
  /// a custom button command.
  /// </summary>
  [Transaction( TransactionMode.ReadOnly )]
  public class CmdPost2 : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      UIApplication uiapp = commandData.Application;

      // External tool commands defined by add-ins are
      // identified by the string listed in the 
      // journal file when the command is launched 
      // manually.

      string name_addin_button_cmd
        = "CustomCtrl_%CustomCtrl_%"
          + "Add-Ins%Post Add-in Command%Dummy2"; // --> id 6417

      RevitCommandId id_addin_button_cmd
        = RevitCommandId.LookupCommandId(
          name_addin_button_cmd );

      uiapp.PostCommand( id_addin_button_cmd );

      return Result.Succeeded;
    }
  }
}
