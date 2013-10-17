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
  /// another external command defined by a custom 
  /// add-in.
  /// </summary>
  [Transaction( TransactionMode.ReadOnly )]
  public class CmdPost : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      UIApplication uiapp = commandData.Application;

      // Built-in Revit commands are listed in the 
      // PostableCommand enumeration

      //RevitCommandId id = RevitCommandId.LookupPostableCommandId( 
      //  PostableCommand.SheetIssuesOrRevisions );

      // External commands defined by add-ins are 
      // identified by the client id specified in 
      // the add-in manifest

      string name
        //= "64b3d907-37cf-4cab-8bbc-3de9b66a3efa:PostAddinCommand.CmdDummy"; // --> id null
        = "64b3d907-37cf-4cab-8bbc-3de9b66a3efa"; // --> id 35024

      RevitCommandId id 
        = RevitCommandId.LookupCommandId( 
          name );

      uiapp.PostCommand( id );

      return Result.Succeeded;
    }
  }
}
