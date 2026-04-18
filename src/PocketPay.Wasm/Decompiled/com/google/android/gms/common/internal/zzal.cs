namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
public readonly class zzal : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.zzal> CREATOR = new com.google.android.gms.common.internal.zzam();
    readonly int zza;

    zzal(int i) {
        this.zza = i;
    }

    public static void VXXEpMtFStwyFHfP(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void BZFcaZKonjSanURO(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int IdbwJtLtSFSKMvEH(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        int i2 = this.zza;
        int iIdbwJtLtSFSKMvEH = idbwJtLtSFSKMvEH(parcel);
        bZFcaZKonjSanURO(parcel, 1, i2);
        VXXEpMtFStwyFHfP(parcel, iIdbwJtLtSFSKMvEH);
    }
}

