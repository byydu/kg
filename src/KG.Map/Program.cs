namespace KG.Map;

internal static class Program
{
  [STAThread]
  private static void Main()
  {
    ApplicationConfiguration.Initialize();
    Application.Run(new Views.MainForm());
  }
}