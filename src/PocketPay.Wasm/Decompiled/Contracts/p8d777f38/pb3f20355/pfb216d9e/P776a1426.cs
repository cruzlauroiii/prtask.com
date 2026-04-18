namespace WillowMaze.Wasm.Decompiled;

public interface P776a1426
{
    void ClearLocale();
    pf3d67c3a GetLocaleType();
    List<object> GetLocales();
    CultureInfo GetSystemLocale();
    bool IsFirstLaunch();
    void SetFirstLaunch(bool P0);
    void UpdateConfiguration(object P0);
    void UpdateLocale(string P0);
}
