using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FreeTrainSimulator.Android;

internal sealed class TestGame : Game
{
    private readonly GraphicsDeviceManager graphics;

    public TestGame()
    {
        graphics = new GraphicsDeviceManager(this)
        {
            SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight,
            IsFullScreen = true
        };
    }

    protected override void Initialize()
    {
        Window.Title = "FTS Android POC";
        base.Initialize();
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        base.Draw(gameTime);
    }
}
