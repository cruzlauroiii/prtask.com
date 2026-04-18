namespace WillowMaze.Wasm.Decompiled;


readonly class zzb : android.os.Parcelable$Creator {
    zzb() {
    }

    public static android.os.IBinder AVDoSsigvwGNIyWm(android.os.Parcel parcel) {
        return parcel.readStrongBinder();
    }

    public override readonly java.lang.object CreateFromParcel(android.os.Parcel parcel) {
        return new com.google.android.gms.cloudmessaging.zzd(aVDoSsigvwGNIyWm(parcel));
    }

    public override readonly java.lang.object[] NewArray(int i) {
        return new com.google.android.gms.cloudmessaging.zzd[i];
    }
}

