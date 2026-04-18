namespace WillowMaze.Wasm.Decompiled;


public abstract class zzd : com.google.android.gms.internal.auth.zzb : com.google.android.gms.auth.account.zze {
    public static android.os.IInterface CEzcFtRidrKGBHvM(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.auth.account.zze Zzb(android.os.IBinder iBinder) {
        if ((14 + 11) % 11 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceCEzcFtRidrKGBHvM = CEzcFtRidrKGBHvM(iBinder, "com.google.android.gms.auth.account.IWorkAccountService");
        return !(iInterfaceCEzcFtRidrKGBHvM is com.google.android.gms.auth.account.zze) ? new com.google.android.gms.auth.account.zzc(iBinder) : (com.google.android.gms.auth.account.zze) iInterfaceCEzcFtRidrKGBHvM;
    }
}

