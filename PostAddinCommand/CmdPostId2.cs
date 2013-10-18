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
  /// a custom button command via it id.
  /// </summary>
  [Transaction( TransactionMode.ReadOnly )]
  public class CmdPostId2 : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      UIApplication uiapp = commandData.Application;

      RevitCommandId id_addin_button_cmd
        = RevitCommandId.LookupPostableCommandId(
          (PostableCommand) 6417 );

      uiapp.PostCommand( id_addin_button_cmd );

      return Result.Succeeded;
    }
  }
}
