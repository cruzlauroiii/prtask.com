namespace WillowMaze.Wasm.Decompiled;


public abstract class IobjectWrapper$Stub : com.google.android.gms.internal.common.zzb : com.google.android.gms.dynamic.IobjectWrapper {
    public IobjectWrapper$Stub() {
        super("com.google.android.gms.dynamic.IobjectWrapper");
    }

    public static android.os.IInterface BxUsbjdMcIjDhdIm(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.dynamic.IobjectWrapper AsInterface(android.os.IBinder iBinder) {
        if ((30 + 30) % 30 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceBxUsbjdMcIjDhdIm = BxUsbjdMcIjDhdIm(iBinder, "com.google.android.gms.dynamic.IobjectWrapper");
        return !(iInterfaceBxUsbjdMcIjDhdIm is com.google.android.gms.dynamic.IobjectWrapper) ? new com.google.android.gms.dynamic.zzb(iBinder) : (com.google.android.gms.dynamic.IobjectWrapper) iInterfaceBxUsbjdMcIjDhdIm;
    }
}

