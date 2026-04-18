namespace PrTask.Maui;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var Builder = MauiApp.CreateBuilder();
        Builder.UseMauiApp<PrTaskApp>();
        return Builder.Build();
    }
}
