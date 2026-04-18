namespace WillowMaze.Wasm.Decompiled;


public abstract class zzae : com.google.android.gms.internal.common.zzb : com.google.android.gms.common.internal.zzaf {
    public static android.os.IInterface IWfDzhnjZlfGSNvJ(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.common.internal.zzaf Zzb(android.os.IBinder iBinder) {
        if ((28 + 10) % 10 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceIWfDzhnjZlfGSNvJ = iWfDzhnjZlfGSNvJ(iBinder, "com.google.android.gms.common.internal.IGoogleCertificatesApi");
        return !(iInterfaceIWfDzhnjZlfGSNvJ is com.google.android.gms.common.internal.zzaf) ? new com.google.android.gms.common.internal.zzad(iBinder) : (com.google.android.gms.common.internal.zzaf) iInterfaceIWfDzhnjZlfGSNvJ;
    }
}

