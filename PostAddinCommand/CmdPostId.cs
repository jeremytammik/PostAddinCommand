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
  /// another external tool command defined by a
  /// custom add-in.
  /// </summary>
  [Transaction( TransactionMode.ReadOnly )]
  public class CmdPostId : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      UIApplication uiapp = commandData.Application;

      // External tool commands defined by add-ins are
      // identified by the client id specified in 
      // the add-in manifest. It is also listed in the 
      // journal file when the command is launched 
      // manually.

      //string name
      //  = "64b3d907-37cf-4cab-8bbc-3de9b66a3efa"; // --> id 35024

      RevitCommandId id_addin_external_tool_cmd
        = RevitCommandId.LookupPostableCommandId(
          (PostableCommand) 35024 );

      uiapp.PostCommand( id_addin_external_tool_cmd );

      return Result.Succeeded;
    }
  }
}
