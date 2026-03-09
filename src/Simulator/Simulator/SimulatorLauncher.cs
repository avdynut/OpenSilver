using DotNetForHtml5.EmulatorWithoutJavascript;
using System.Reflection;

namespace OpenSilver.Simulator
{
    public static class SimulatorLauncher
    {
        internal static SimulatorLaunchParameters Parameters { get; private set; }

        public static int Start(Type userApplicationType, SimulatorLaunchParameters parameters = null)
        {
            ArgumentNullException.ThrowIfNull(userApplicationType);

            Parameters = parameters ?? new SimulatorLaunchParameters();

            void appCreationDelegate()
            {
                var app = Activator.CreateInstance(userApplicationType);
                var initializeComponentMethod = userApplicationType.GetMethod("InitializeComponent");
                initializeComponentMethod?.Invoke(app, null);
            }
            return Start(appCreationDelegate, userApplicationType.Assembly, parameters);
        }

        public static int Start(Action appCreationDelegate, Assembly appAssembly, SimulatorLaunchParameters parameters = null)
        {
            Parameters = parameters ?? new SimulatorLaunchParameters();
            if (appCreationDelegate == null)
            {
                throw new ArgumentNullException(nameof(appCreationDelegate));
            }

            if (appAssembly == null)
            {
                throw new ArgumentNullException(nameof(appAssembly));
            }

            App app = new App();
            app.InitializeComponent();
            return app.Run(new MainWindow(appCreationDelegate, appAssembly, parameters));
        }
    }
}

