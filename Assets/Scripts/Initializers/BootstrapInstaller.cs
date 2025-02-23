using FlappyBird.Character;
using FlappyBird.Core;
using VContainer;
using VContainer.Unity;

public class BootstrapInstaller : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<GameState>(Lifetime.Singleton);
        builder.RegisterComponentInHierarchy<CharacterConfigBase>();
        builder.RegisterComponentInHierarchy<InitCharacter>();
    }
}
