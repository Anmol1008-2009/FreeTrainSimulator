using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Microsoft.Xna.Framework;

namespace FreeTrainSimulator.Android;

[Activity(
    Label = "FTS Android POC",
    MainLauncher = true,
    Icon = "@android:drawable/ic_menu_compass",
    ConfigurationChanges = ConfigChanges.Orientation |
                           ConfigChanges.ScreenSize |
                           ConfigChanges.Keyboard |
                           ConfigChanges.KeyboardHidden,
    ScreenOrientation = ScreenOrientation.SensorLandscape,
    Exported = true)]
public sealed class MainActivity : AndroidGameActivity
{
    private Game? game;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        game = new TestGame();
        SetContentView((View)game.Services.GetService(typeof(View))!);
        game.Run();
    }

    protected override void OnPause()
    {
        game?.Exit();
        base.OnPause();
    }
}
