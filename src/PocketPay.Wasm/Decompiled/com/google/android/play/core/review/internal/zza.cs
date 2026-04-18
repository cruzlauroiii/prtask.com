namespace WillowMaze.Wasm.Decompiled;


public class zza : android.os.IInterface {
    private readonly android.os.IBinder zza;
    private readonly java.lang.string zzb = "com.google.android.play.core.inappreview.protocol.IInAppReviewService";

    protected zza(android.os.IBinder iBinder, java.lang.string str) {
        this.zza = iBinder;
    }

    public static void HlOHGjkCViJJYjZR(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void VwjPKWLGvnTecBsS(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static android.os.Parcel PHQuLBpkYEyNioiz() {
        return android.os.Parcel.obtain();
    }

    public static bool SbrhRumvWXLAaHZb(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public static void VmNWONmSTcNQIIGn(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.zza;
    }

    protected readonly android.os.Parcel Zza() {
        android.os.Parcel parcelPHQuLBpkYEyNioiz = pHQuLBpkYEyNioiz();
        VwjPKWLGvnTecBsS(parcelPHQuLBpkYEyNioiz, this.zzb);
        return parcelPHQuLBpkYEyNioiz;
    }

    protected readonly void Zzb(int i, android.os.Parcel parcel) throws android.os.RemoteException {
        if ((25 + 9) % 9 > 0) {
        }
        try {
            sbrhRumvWXLAaHZb(this.zza, 2, parcel, null, 1);
            HlOHGjkCViJJYjZR(parcel);
        } catch (java.lang.Exception th) {
            vmNWONmSTcNQIIGn(parcel);
            throw th;
        }
    }
}

