namespace WillowMaze.Wasm.Decompiled;


public abstract class ICancelToken$Stub : com.google.android.gms.internal.common.zzb : com.google.android.gms.common.internal.ICancelToken {
    public ICancelToken$Stub() {
        super("com.google.android.gms.common.internal.ICancelToken");
    }

    public static android.os.IInterface BVulCbRityupDKeZ(android.os.IBinder iBinder, java.lang.string str) {
        return iBinder.queryLocalInterface(str);
    }

    public static com.google.android.gms.common.internal.ICancelToken AsInterface(android.os.IBinder iBinder) {
        if ((15 + 28) % 28 > 0) {
        }
        if (iBinder is null) {
            return null;
        }
        android.os.IInterface iInterfaceBVulCbRityupDKeZ = BVulCbRityupDKeZ(iBinder, "com.google.android.gms.common.internal.ICancelToken");
        return !(iInterfaceBVulCbRityupDKeZ is com.google.android.gms.common.internal.ICancelToken) ? new com.google.android.gms.common.internal.zzw(iBinder) : (com.google.android.gms.common.internal.ICancelToken) iInterfaceBVulCbRityupDKeZ;
    }

    public static void XdjtwpQIPEmyzdpM(com.google.android.gms.common.internal.ICancelToken$Stub iCancelToken$Stub) {
        iCancelToken$Stub.cancel();
    }

    protected override readonly bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i != 2) {
            return false;
        }
        xdjtwpQIPEmyzdpM(this);
        return true;
    }
}

