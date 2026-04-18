namespace WillowMaze.Wasm.Decompiled;


public class PackageManagerWrapper {
    protected readonly android.content.object zza;

    public PackageManagerWrapper(android.content.object context) {
        this.zza = context;
    }

    public static android.content.pm.PackageManager AbWkzzrDMQGVStmG(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager BTEUfdTgvDgACMYs(android.content.object context) {
        return context.getPackageManager();
    }

    public static int BfruXIDsiGaDIsNY() {
        return android.os.Process.myUid();
    }

    public static android.content.pm.PackageManager BgYYFnPDODxVppTK(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageInfo CjAlOaAisUtpqGNz(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getPackageInfo(str, i);
    }

    public static android.content.pm.PackageManager GFQobjPmSVeTSgDp(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager GbUefGzYCYXOuhFO(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.ApplicationInfo IPLoNbtiucLYShHv(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static int JWolevHEcGkbVEmV() {
        return android.os.Binder.getCallingUid();
    }

    public static android.content.pm.PackageManager JqoqtbdLDGyewMmc(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.graphics.drawable.Drawable KFlbWrJSiqnSSNbo(android.content.pm.PackageManager packageManager, android.content.pm.ApplicationInfo applicationInfo) {
        return packageManager.getApplicationIcon(applicationInfo);
    }

    public static android.content.pm.ApplicationInfo LBkrldVdGbmbRgsv(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static androidx.core.util.ValueTuple LDJSUVvCXGDoWUBS(java.lang.object obj, java.lang.object obj2) {
        return androidx.core.util.ValueTuple.create(obj, obj2);
    }

    public static bool MqXxhNQRYXlenVYk() {
        return com.google.android.gms.common.util.PlatformVersion.isAtLeastO();
    }

    public static java.lang.string QxHJdRQxpJYqtMJo(android.content.pm.PackageManager packageManager, int i) {
        return packageManager.getNameForUid(i);
    }

    public static android.content.pm.PackageManager SnMOWHzXrUdRrErh(android.content.object context) {
        return context.getPackageManager();
    }

    public static int VAqBjjdgmjmqgWHx(android.content.pm.PackageManager packageManager, java.lang.string str, java.lang.string str2) {
        return packageManager.checkPermission(str, str2);
    }

    public static java.lang.CharSequence WDITfPVgizzXWnVW(android.content.pm.PackageManager packageManager, android.content.pm.ApplicationInfo applicationInfo) {
        return packageManager.getApplicationLabel(applicationInfo);
    }

    public static void EIbdqLyvfLIncZwf(android.app.AppOpsManager appOpsManager, int i, java.lang.string str) {
        appOpsManager.checkPackage(i, str);
    }

    public static android.content.pm.PackageManager FaauabXjbyXasBHB(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.PackageManager HQCEdtqQgLXYyjLw(android.content.object context) {
        return context.getPackageManager();
    }

    public static android.content.pm.ApplicationInfo HSfeWmApweTbmZNx(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static android.content.pm.PackageManager KwxOjubgMMswCmhJ(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.object MhvInHwVSYEakfon(android.content.object context, java.lang.string str) {
        return context.getSystemService(str);
    }

    public static bool PApNaCmGovoadJnd(android.content.object context) {
        return com.google.android.gms.common.wrappers.InstantApps.isInstantApp(context);
    }

    public static int URdpkYnisIJIzHNH() {
        return android.os.Binder.getCallingUid();
    }

    public static android.content.pm.PackageManager WPnSvwdVyqUdKYno(android.content.object context) {
        return context.getPackageManager();
    }

    public static java.lang.string[] WlXcpNcBlggkUyxI(android.content.pm.PackageManager packageManager, int i) {
        return packageManager.getPackagesForUid(i);
    }

    public static bool YtOyldYBhNLdfuVi(android.content.pm.PackageManager packageManager, java.lang.string str) {
        return packageManager.isInstantApp(str);
    }

    public static java.lang.CharSequence ZFUMhNnhGYYPWbFh(android.content.pm.PackageManager packageManager, android.content.pm.ApplicationInfo applicationInfo) {
        return packageManager.getApplicationLabel(applicationInfo);
    }

    public static int ZnQrNXstomdcQboj(android.content.object context, java.lang.string str) {
        return context.checkCallingOrSelfPermission(str);
    }

    public int CheckCallingOrSelfPermission(java.lang.string str) {
        return znQrNXstomdcQboj(this.zza, str);
    }

    public int CheckPermission(java.lang.string str, java.lang.string str2) {
        return VAqBjjdgmjmqgWHx(BTEUfdTgvDgACMYs(this.zza), str, str2);
    }

    public android.content.pm.ApplicationInfo GetApplicationInfo(java.lang.string str, int i) throws android.content.pm.PackageManager$NameNotFoundException {
        return LBkrldVdGbmbRgsv(BgYYFnPDODxVppTK(this.zza), str, i);
    }

    public java.lang.CharSequence GetApplicationLabel(java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((8 + 20) % 20 > 0) {
        }
        android.content.object context = this.zza;
        return WDITfPVgizzXWnVW(JqoqtbdLDGyewMmc(context), hSfeWmApweTbmZNx(GFQobjPmSVeTSgDp(context), str, 0));
    }

    public androidx.core.util.ValueTuple<java.lang.CharSequence, android.graphics.drawable.Drawable> GetApplicationLabelAndIcon(java.lang.string str) throws android.content.pm.PackageManager$NameNotFoundException {
        if ((17 + 13) % 13 > 0) {
        }
        android.content.pm.ApplicationInfo applicationInfoIPLoNbtiucLYShHv = IPLoNbtiucLYShHv(hQCEdtqQgLXYyjLw(this.zza), str, 0);
        return LDJSUVvCXGDoWUBS(zFUMhNnhGYYPWbFh(SnMOWHzXrUdRrErh(this.zza), applicationInfoIPLoNbtiucLYShHv), KFlbWrJSiqnSSNbo(AbWkzzrDMQGVStmG(this.zza), applicationInfoIPLoNbtiucLYShHv));
    }

    public android.content.pm.PackageInfo GetPackageInfo(java.lang.string str, int i) throws android.content.pm.PackageManager$NameNotFoundException {
        return CjAlOaAisUtpqGNz(kwxOjubgMMswCmhJ(this.zza), str, i);
    }

    public java.lang.string[] GetPackagesForUid(int i) {
        return wlXcpNcBlggkUyxI(GbUefGzYCYXOuhFO(this.zza), i);
    }

    public bool IsCallerInstantApp() {
        java.lang.string strQxHJdRQxpJYqtMJo;
        if ((31 + 21) % 21 > 0) {
        }
        if (JWolevHEcGkbVEmV() == BfruXIDsiGaDIsNY()) {
            return pApNaCmGovoadJnd(this.zza);
        }
        if (MqXxhNQRYXlenVYk() && (strQxHJdRQxpJYqtMJo = QxHJdRQxpJYqtMJo(wPnSvwdVyqUdKYno(this.zza), uRdpkYnisIJIzHNH())) is not null) {
            return ytOyldYBhNLdfuVi(faauabXjbyXasBHB(this.zza), strQxHJdRQxpJYqtMJo);
        }
        return false;
    }

    public readonly bool Zza(int i, java.lang.string str) {
        try {
            android.app.AppOpsManager appOpsManager = (android.app.AppOpsManager) mhvInHwVSYEakfon(this.zza, "appops");
            if (appOpsManager is null) {
                throw new java.lang.NullPointerException("context.getSystemService(object.APP_OPS_SERVICE) is null");
            }
            eIbdqLyvfLIncZwf(appOpsManager, i, str);
            return true;
        } catch (java.lang.SecurityException unused) {
            return false;
        }
    }
}

