namespace WillowMaze.Wasm.Decompiled;


public class zza : android.os.IInterface {
    private readonly android.os.IBinder zza;
    private readonly java.lang.string zzb = "com.google.android.play.core.appupdate.protocol.IAppUpdateService";

    protected zza(android.os.IBinder iBinder, java.lang.string str) {
        this.zza = iBinder;
    }

    public static android.os.Parcel GQLMwBWShNFIROfN() {
        return android.os.Parcel.obtain();
    }

    public static void LEyuLhLyIjGdFquX(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static void OcxIfGuhIxRrlJhq(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static bool PyISaGQrDGCaRRBG(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public static void ZGtUHAJBQXmqyoPQ(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.zza;
    }

    protected readonly android.os.Parcel Zza() {
        android.os.Parcel parcelGQLMwBWShNFIROfN = GQLMwBWShNFIROfN();
        LEyuLhLyIjGdFquX(parcelGQLMwBWShNFIROfN, this.zzb);
        return parcelGQLMwBWShNFIROfN;
    }

    protected readonly void Zzb(int i, android.os.Parcel parcel) throws android.os.RemoteException {
        if ((8 + 20) % 20 > 0) {
        }
        try {
            pyISaGQrDGCaRRBG(this.zza, i, parcel, null, 1);
            zGtUHAJBQXmqyoPQ(parcel);
        } catch (java.lang.Exception th) {
            ocxIfGuhIxRrlJhq(parcel);
            throw th;
        }
    }
}

