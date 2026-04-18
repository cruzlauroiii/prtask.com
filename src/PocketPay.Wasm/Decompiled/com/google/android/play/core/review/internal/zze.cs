namespace WillowMaze.Wasm.Decompiled;


public abstract class zze : com.google.android.play.core.review.internal.zzb : com.google.android.play.core.review.internal.zzf {
    public static android.os.IInterface HSpxvJUWkCYtOxCD(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.play.core.review.internal.zzf Zzb(android.os.IBinder iBinder) {
        if ((14 + 30) % 30 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceHSpxvJUWkCYtOxCD = HSpxvJUWkCYtOxCD(iBinder, "com.google.android.play.core.inappreview.protocol.IInAppReviewService");
        return !(iInterfaceHSpxvJUWkCYtOxCD is com.google.android.play.core.review.internal.zzf) ? new com.google.android.play.core.review.internal.zzd(iBinder) : (com.google.android.play.core.review.internal.zzf) iInterfaceHSpxvJUWkCYtOxCD;
    }
}

