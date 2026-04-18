namespace WillowMaze.Wasm.Decompiled;


public class zzb : android.os.Binder : android.os.IInterface {
    protected zzb(java.lang.string str) {
        zLiHktTugTsNTBLf(this, this, "com.google.android.gms.safetynet.internal.ISafetyNetCallbacks");
    }

    public static bool CTajYAFJSeoiShKP(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static java.lang.string HnJgPTnxWiFYdMmp(com.google.android.gms.internal.safetynet.zzb zzbVar) {
        return zzbVar.getInterfaceDescriptor();
    }

    public static void KRttbnDftlkiRkYk(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public static bool TqjZUSXYhiNtXREk(com.google.android.gms.internal.safetynet.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zzbVar.zza(i, parcel, parcel2, i2);
    }

    public static void ZLiHktTugTsNTBLf(com.google.android.gms.internal.safetynet.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str) {
        zzbVar.attachInterface(iInterface, str);
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            KRttbnDftlkiRkYk(parcel, HnJgPTnxWiFYdMmp(this));
        } else if (CTajYAFJSeoiShKP(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return tqjZUSXYhiNtXREk(this, i, parcel, parcel2, i2);
    }

    protected bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }
}

