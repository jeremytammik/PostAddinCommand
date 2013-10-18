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
  /// Dummy command for testing purposes,
  /// lauched programmatically by CmdPost.
  /// </summary>
  [Transaction( TransactionMode.ReadOnly )]
  class CmdDummy2 : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      TaskDialog.Show( "Test Command", "Hello from CmdDummy2!" );

      return Result.Succeeded;
    }
  }
}
