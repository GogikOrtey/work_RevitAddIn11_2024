using Application.Commands;
using Nice3point.Revit.Toolkit.External;
using RevitAddIn.Commands;

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
            var panel = Application.CreatePanel("Проект RevitAddIn11", "Application");

            panel.AddPushButton<StartupCommand>("Кнопка 1")
                .SetLargeImage("/RevitAddIn;component/Resources/Icons/ico_new_1_32.png");

            panel.AddPushButton<StartupCommand2>("Кнопка 2")
                .SetLargeImage("/RevitAddIn;component/Resources/Icons/ico_new_2_32.png");
        }
    }
}