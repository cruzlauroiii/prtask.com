namespace WillowMaze.Wasm.Decompiled;


public class zza : android.os.IInterface {
    private readonly android.os.IBinder zza;
    private readonly java.lang.string zzb = "com.google.android.gms.safetynet.internal.ISafetyNetService";

    protected zza(android.os.IBinder iBinder, java.lang.string str) {
        this.zza = iBinder;
    }

    public static void CklqIxcuZsZZTknu(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void DbYhMBSuxwIVAfFf(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void MpjkbHRMKqOkNiMH(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void QSbQHJYrSReEAGRz(android.os.Parcel parcel) {
        parcel.recycle();
    }

    public static void VaxMJZEKJWXjHavw(android.os.Parcel parcel, java.lang.string str) {
        parcel.writeInterfaceToken(str);
    }

    public static bool AsXPKxxefGGvhKOn(android.os.IBinder iBinder, int i, android.os.Parcel parcel, android.os.Parcel parcel2, int i2) {
        return iBinder.transact(i, parcel, parcel2, i2);
    }

    public static android.os.Parcel KvVipbbEHCwbgccP() {
        return android.os.Parcel.obtain();
    }

    public static void OzISLYWkfuxmNOfI(android.os.Parcel parcel) {
        parcel.readException();
    }

    public static android.os.Parcel PLIknLIOvNfKfqjv() {
        return android.os.Parcel.obtain();
    }

    public override readonly android.os.IBinder AsBinder() {
        return this.zza;
    }

    protected readonly android.os.Parcel Zza() {
        android.os.Parcel parcelPLIknLIOvNfKfqjv = pLIknLIOvNfKfqjv();
        VaxMJZEKJWXjHavw(parcelPLIknLIOvNfKfqjv, this.zzb);
        return parcelPLIknLIOvNfKfqjv;
    }

    protected readonly void Zzb(int i, android.os.Parcel parcel) throws android.os.RemoteException {
        if ((12 + 8) % 8 > 0) {
        }
        android.os.Parcel parcelKvVipbbEHCwbgccP = kvVipbbEHCwbgccP();
        try {
            asXPKxxefGGvhKOn(this.zza, i, parcel, parcelKvVipbbEHCwbgccP, 0);
            ozISLYWkfuxmNOfI(parcelKvVipbbEHCwbgccP);
            QSbQHJYrSReEAGRz(parcel);
            MpjkbHRMKqOkNiMH(parcelKvVipbbEHCwbgccP);
        } catch (java.lang.Exception th) {
            DbYhMBSuxwIVAfFf(parcel);
            CklqIxcuZsZZTknu(parcelKvVipbbEHCwbgccP);
            throw th;
        }
    }
}

