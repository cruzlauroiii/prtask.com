namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\t\bf\u0018\u00002\u00020\u0001J\b\u0010\u000b\u001a\u00020\u0003H&J\u000e\u0010\f\u001a\b\u0012\u0004\u0012\u00020\u000e0\rH&J\u000e\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00100\rH&J\b\u0010\u0011\u001a\u00020\u0003H&J\b\u0010\u0012\u001a\u00020\u0013H&J\b\u0010\u001c\u001a\u00020\u0003H&J\b\u0010\u001d\u001a\u00020\u0003H&J\b\u0010\u001e\u001a\u00020\u0003H&J\b\u0010\u001f\u001a\u00020\u0013H&J\b\u0010 \u001a\u00020\u0013H&J\b\u0010!\u001a\u00020\u0013H&R\u0012\u0010\u0002\u001a\u00020\u0003X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0002\u0010\u0004R\u0018\u0010\u0005\u001a\u00020\u0006X¦\u000e¢\u0006\f\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\nR\u0012\u0010\u0014\u001a\u00020\u0015X¦\u0004¢\u0006\u0006\u001a\u0004\b\u0016\u0010\u0017R\u0012\u0010\u0018\u001a\u00020\u0019X¦\u0004¢\u0006\u0006\u001a\u0004\b\u001a\u0010\u001b¨\u0006\""}, d2 = {"Lpc02fdf0f/pb3f20355/p0fc7c052;", "", "isAppInfoReadFirstTime", "", "()Z", "boardingHashSettings", "Lpc02fdf0f/pf5e638cc/p47fbe948;", "getBoardingHashSettings", "()Lpc02fdf0f/pf5e638cc/p47fbe948;", "setBoardingHashSettings", "(Lpc02fdf0f/pf5e638cc/p47fbe948;)V", "isNeedShowBoarding", "getBoardingPages", "", "Lpc02fdf0f/pf5e638cc/pb7b32cec;", "getBoardingNewsPages", "Lpc02fdf0f/pf5e638cc/p49afdbf3;", "isNeedShowBoardingNews", "boardingNewsInfoRead", "", "launcherBoardingHashSettings", "Lpf3e08b51/p07214c67/p45ebb4c3;", "getLauncherBoardingHashSettings", "()Lpf3e08b51/p07214c67/p45ebb4c3;", "statisticBoardingHashSettings", "Lpa912a94d/pf5e638cc/p54060cd2;", "getStatisticBoardingHashSettings", "()Lpa912a94d/pf5e638cc/p54060cd2;", "isDeviceSectionInfoReadFirstTime", "isLKSectionInfoReadFirstTime", "isNotFiscalReceiptsInfoReadFirstTime", "deviceSectionRead", "lkSectionRead", "notFiscalReceiptsRead", "feature-boarding-api_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface p0fc7c052 {
    void boardingNewsInfoRead();

    void deviceSectionRead();

    java.util.List<pc02fdf0f.pf5e638cc.p49afdbf3> getBoardingNewsPages();

    java.util.List<pc02fdf0f.pf5e638cc.pb7b32cec> getBoardingPages();

    pc02fdf0f.pf5e638cc.p47fbe948 getBoardingHashSettings();

    pf3e08b51.p07214c67.p45ebb4c3 getLauncherBoardingHashSettings();

    pa912a94d.pf5e638cc.p54060cd2 getStatisticBoardingHashSettings();

    bool isAppInfoReadFirstTime();

    bool isDeviceSectionInfoReadFirstTime();

    bool isLKSectionInfoReadFirstTime();

    bool isNeedShowBoarding();

    bool isNeedShowBoardingNews();

    bool isNotFiscalReceiptsInfoReadFirstTime();

    void lkSectionRead();

    void notFiscalReceiptsRead();

    void setBoardingHashSettings(pc02fdf0f.pf5e638cc.p47fbe948 p47fbe948Var);
}

