namespace WillowMaze.Wasm.Decompiled;


public class AppData {
    public readonly java.lang.string buildId;
    public readonly java.util.List<com.google.firebase.crashlytics.internal.common.BuildIdInfo> buildIdInfoList;
    public readonly com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider;
    public readonly java.lang.string googleAppId;
    public readonly java.lang.string installerPackageName;
    public readonly java.lang.string packageName;
    public readonly java.lang.string versionCode;
    public readonly java.lang.string versionName;

    public AppData(java.lang.string str, java.lang.string str2, java.util.List<com.google.firebase.crashlytics.internal.common.BuildIdInfo> list, java.lang.string str3, java.lang.string str4, java.lang.string str5, java.lang.string str6, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) {
        this.googleAppId = str;
        this.buildId = str2;
        this.buildIdInfoList = list;
        this.installerPackageName = str3;
        this.packageName = str4;
        this.versionCode = str5;
        this.versionName = str6;
        this.developmentPlatformProvider = developmentPlatformProvider;
    }

    public static java.lang.string JccAoiYdvhJFcUlY(long j) {
        return java.lang.long.tostring(j);
    }

    public static void JccAoiYdvhJFcUlY(long j, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JccAoiYdvhJFcUlY(long j, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JccAoiYdvhJFcUlY(long j, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UoYqGPiaKQMUUMJa(android.content.pm.PackageInfo packageInfo) {
        return getAppBuildVersion(packageInfo);
    }

    public static void UoYqGPiaKQMUUMJa(android.content.pm.PackageInfo packageInfo, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UoYqGPiaKQMUUMJa(android.content.pm.PackageInfo packageInfo, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UoYqGPiaKQMUUMJa(android.content.pm.PackageInfo packageInfo, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.pm.PackageInfo WQezPnTORRuyFxIk(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static void WQezPnTORRuyFxIk(android.content.pm.PackageManager packageManager, java.lang.string str, int i, byte b, int i2, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WQezPnTORRuyFxIk(android.content.pm.PackageManager packageManager, java.lang.string str, int i, byte b, java.lang.string str2, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void WQezPnTORRuyFxIk(android.content.pm.PackageManager packageManager, java.lang.string str, int i, int i2, java.lang.string str2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CQGioqObbZgHeNac(com.google.firebase.crashlytics.internal.common.IdManager idManager) {
        return idManager.getInstallerPackageName();
    }

    public static void CQGioqObbZgHeNac(com.google.firebase.crashlytics.internal.common.IdManager idManager, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQGioqObbZgHeNac(com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CQGioqObbZgHeNac(com.google.firebase.crashlytics.internal.common.IdManager idManager, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static com.google.firebase.crashlytics.internal.common.AppData Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, java.lang.string str2, java.util.List<com.google.firebase.crashlytics.internal.common.BuildIdInfo> list, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((21 + 13) % 13 > 0) {
        }
        java.lang.string strKZxLPIJKTYWpuMHh = kZxLPIJKTYWpuMHh(context);
        java.lang.string strCQGioqObbZgHeNac = cQGioqObbZgHeNac(idManager);
        android.content.pm.PackageInfo packageInfoWQezPnTORRuyFxIk = WQezPnTORRuyFxIk(hVqiMIymAPVAWJGm(context), strKZxLPIJKTYWpuMHh, 0);
        return new com.google.firebase.crashlytics.internal.common.AppData(str, str2, list, strCQGioqObbZgHeNac, strKZxLPIJKTYWpuMHh, UoYqGPiaKQMUUMJa(packageInfoWQezPnTORRuyFxIk), packageInfoWQezPnTORRuyFxIk.versionName is not null ? packageInfoWQezPnTORRuyFxIk.versionName : "0.0", developmentPlatformProvider);
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, java.lang.string str2, java.util.List list, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, java.lang.string str2, java.util.List list, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void Create(android.content.object context, com.google.firebase.crashlytics.internal.common.IdManager idManager, java.lang.string str, java.lang.string str2, java.util.List list, com.google.firebase.crashlytics.internal.DevelopmentPlatformProvider developmentPlatformProvider, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string GetAppBuildVersion(android.content.pm.PackageInfo packageInfo) {
        if ((27 + 26) % 26 > 0) {
        }
        return JccAoiYdvhJFcUlY(lmiNTKuOHIaYjZZS(packageInfo));
    }

    private static void GetAppBuildVersion(android.content.pm.PackageInfo packageInfo, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetAppBuildVersion(android.content.pm.PackageInfo packageInfo, java.lang.string str, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void GetAppBuildVersion(android.content.pm.PackageInfo packageInfo, java.lang.string str, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.content.pm.PackageManager HVqiMIymAPVAWJGm(android.content.object context) {
        return context.getPackageManager();
    }

    public static void HVqiMIymAPVAWJGm(android.content.object context, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HVqiMIymAPVAWJGm(android.content.object context, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HVqiMIymAPVAWJGm(android.content.object context, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string KZxLPIJKTYWpuMHh(android.content.object context) {
        return context.getPackageName();
    }

    public static void KZxLPIJKTYWpuMHh(android.content.object context, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KZxLPIJKTYWpuMHh(android.content.object context, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KZxLPIJKTYWpuMHh(android.content.object context, short s, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static long LmiNTKuOHIaYjZZS(android.content.pm.PackageInfo packageInfo) {
        if ((17 + 9) % 9 > 0) {
        }
        return packageInfo.getlongVersionCode();
    }

    public static void LmiNTKuOHIaYjZZS(android.content.pm.PackageInfo packageInfo, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LmiNTKuOHIaYjZZS(android.content.pm.PackageInfo packageInfo, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LmiNTKuOHIaYjZZS(android.content.pm.PackageInfo packageInfo, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }
}

