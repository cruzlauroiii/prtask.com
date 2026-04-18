namespace WillowMaze.Wasm.Decompiled;

public interface P0fc7c052
{
    void BoardingNewsInfoRead();
    void DeviceSectionRead();
    List<object> GetBoardingNewsPages();
    List<object> GetBoardingPages();
    p47fbe948 GetBoardingSettings();
    p45ebb4c3 GetLauncherBoardingSettings();
    p54060cd2 GetStatisticBoardingSettings();
    bool IsAppInfoReadFirstTime();
    bool IsDeviceSectionInfoReadFirstTime();
    bool IsLKSectionInfoReadFirstTime();
    bool IsNeedShowBoarding();
    bool IsNeedShowBoardingNews();
    bool IsNotFiscalReceiptsInfoReadFirstTime();
    void LkSectionRead();
    void NotFiscalReceiptsRead();
    void SetBoardingSettings(p47fbe948 P0);
}
