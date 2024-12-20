using Application.Commands;
using Nice3point.Revit.Toolkit.External;

namespace Application
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "Application");

            panel.AddPushButton<StartupCommand>("Проект 11")
                .SetImage("/Application;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/Application;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}