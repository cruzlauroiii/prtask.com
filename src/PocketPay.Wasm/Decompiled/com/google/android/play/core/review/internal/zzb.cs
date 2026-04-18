namespace WillowMaze.Wasm.Decompiled;


public class zzb : android.os.Binder : android.os.IInterface {
    protected zzb(java.lang.string str) {
        VznOWIpXEpSeANxf(this, this, "com.google.android.play.core.inappreview.protocol.IInAppReviewServiceCallback");
    }

    public static bool SlEvoaMcoQuRrhsx(android.os.Binder binder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return super.onTransact(i, parcel, parcel2, i2);
    }

    public static void VznOWIpXEpSeANxf(com.google.android.play.core.review.internal.zzb zzbVar, android.os.IInterface iInterface, java.lang.string str) {
        zzbVar.attachInterface(iInterface, str);
    }

    public static java.lang.string BmPBuovhdvUBvPuV(com.google.android.play.core.review.internal.zzb zzbVar) {
        return zzbVar.getInterfaceDescriptor();
    }

    public static bool EDhQfIBlHMDZVRcX(com.google.android.play.core.review.internal.zzb zzbVar, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return zzbVar.zza(i, parcel, parcel2, i2);
    }

    public static void EcpGiMGIBkXOmTmn(android.os.Parcel parcel, java.lang.string str) {
        parcel.enforceInterface(str);
    }

    public override readonly android.os.IBinder AsBinder() {
        return this;
    }

    public override readonly bool OnTransact(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        if (i <= 16777215) {
            ecpGiMGIBkXOmTmn(parcel, bmPBuovhdvUBvPuV(this));
        } else if (SlEvoaMcoQuRrhsx(this, i, parcel, parcel2, i2)) {
            return true;
        }
        return eDhQfIBlHMDZVRcX(this, i, parcel, parcel2, i2);
    }

    protected bool Zza(int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) throws android.os.RemoteException {
        throw null;
    }
}

