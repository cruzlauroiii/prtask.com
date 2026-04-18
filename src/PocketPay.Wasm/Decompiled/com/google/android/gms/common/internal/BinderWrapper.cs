namespace WillowMaze.Wasm.Decompiled;


public readonly class BinderWrapper : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.BinderWrapper> CREATOR = new com.google.android.gms.common.internal.zzh();
    private readonly android.os.IBinder zza;

    public BinderWrapper(android.os.IBinder iBinder) {
        this.zza = iBinder;
    }

    BinderWrapper(android.os.Parcel parcel, com.google.android.gms.common.internal.zzi zziVar) {
        this.zza = SScMKUiQfQsygoaB(parcel);
    }

    public static android.os.IBinder SScMKUiQfQsygoaB(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public static void WmgBFbpeiTWeIiEj(android.os.Parcel parcel, android.os.IBinder iBinder) {
        parcel.writeStrongBinder(iBinder);
    }

    public override readonly int DescribeContents() {
        return 0;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        wmgBFbpeiTWeIiEj(parcel, this.zza);
    }
}

