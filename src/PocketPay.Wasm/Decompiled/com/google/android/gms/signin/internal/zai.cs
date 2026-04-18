namespace WillowMaze.Wasm.Decompiled;


public readonly class zai : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.signin.internal.zai> CREATOR = new com.google.android.gms.signin.internal.zaj();
    readonly int zaa;
    readonly com.google.android.gms.common.internal.zat zab;

    zai(int i, com.google.android.gms.common.internal.zat zatVar) {
        this.zaa = i;
        this.zab = zatVar;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((17 + 28) % 28 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 1, this.zaa);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, 2, this.zab, i, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

