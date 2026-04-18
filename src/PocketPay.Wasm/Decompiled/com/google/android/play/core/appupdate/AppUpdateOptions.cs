namespace WillowMaze.Wasm.Decompiled;


public abstract class AppUpdateOptions {
    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder JvBuFWUAOXGSSdPo(com.google.android.play.core.appupdate.AppUpdateOptions$Builder appUpdateOptions$Builder, bool z) {
        return appUpdateOptions$Builder.setAllowAssetPackDeletion(z);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder VkloypukybjdzoDP(int i) {
        return newBuilder(i);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder cjzBfcHdgKcsaTFY(com.google.android.play.core.appupdate.zzv zzvVar, int i) {
        return zzvVar.setAppUpdateType(i);
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions DefaultOptions(int i) {
        return qhrEJtAEGdsDbvpP(VkloypukybjdzoDP(i));
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions$Builder newBuilder(int i) {
        com.google.android.play.core.appupdate.zzv zzvVar = new com.google.android.play.core.appupdate.zzv();
        cjzBfcHdgKcsaTFY(zzvVar, i);
        JvBuFWUAOXGSSdPo(zzvVar, false);
        return zzvVar;
    }

    public static com.google.android.play.core.appupdate.AppUpdateOptions QhrEJtAEGdsDbvpP(com.google.android.play.core.appupdate.AppUpdateOptions$Builder appUpdateOptions$Builder) {
        return appUpdateOptions$Builder.build();
    }

    public abstract bool AllowAssetPackDeletion();

    public abstract int AppUpdateType();
}

