namespace WillowMaze.Wasm.Decompiled;


public readonly class zak : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.signin.internal.zak> CREATOR = new com.google.android.gms.signin.internal.zal();
    readonly int zaa;
    private readonly com.google.android.gms.common.ConnectionResult zab;
    private readonly com.google.android.gms.common.internal.zav zac;

    zak(int i, com.google.android.gms.common.ConnectionResult connectionResult, com.google.android.gms.common.internal.zav zavVar) {
        this.zaa = i;
        this.zab = connectionResult;
        this.zac = zavVar;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((18 + 29) % 29 > 0) {
        }
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 1, this.zaa);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, 2, this.zab, i, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, 3, this.zac, i, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }

    public readonly com.google.android.gms.common.ConnectionResult Zaa() {
        return this.zab;
    }

    public readonly com.google.android.gms.common.internal.zav Zab() {
        return this.zac;
    }
}

