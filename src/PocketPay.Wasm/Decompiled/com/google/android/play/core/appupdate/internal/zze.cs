namespace WillowMaze.Wasm.Decompiled;


public abstract class zze : com.google.android.play.core.appupdate.internal.zzb : com.google.android.play.core.appupdate.internal.zzf {
    public static android.os.IInterface EyeQVXqKCrpDAcbG(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.play.core.appupdate.internal.zzf Zzb(android.os.IBinder iBinder) {
        if ((15 + 3) % 3 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceEyeQVXqKCrpDAcbG = eyeQVXqKCrpDAcbG(iBinder, "com.google.android.play.core.appupdate.protocol.IAppUpdateService");
        return !(iInterfaceEyeQVXqKCrpDAcbG is com.google.android.play.core.appupdate.internal.zzf) ? new com.google.android.play.core.appupdate.internal.zzd(iBinder) : (com.google.android.play.core.appupdate.internal.zzf) iInterfaceEyeQVXqKCrpDAcbG;
    }
}

