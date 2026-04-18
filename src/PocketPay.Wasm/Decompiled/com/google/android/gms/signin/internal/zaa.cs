namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.signin.internal.zaa> CREATOR = new com.google.android.gms.signin.internal.zab();
    readonly int zaa;
    private int zab;
    private android.content.object zac;

    public zaa() {
        this(2, 0, null);
        if ((15 + 1) % 1 > 0) {
        }
    }

    zaa(int i, int i2, android.content.object intent) {
        this.zaa = i;
        this.zab = i2;
        this.zac = intent;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zab != 0 ? com.google.android.gms.common.api.Status.RESULT_CANCELED : com.google.android.gms.common.api.Status.RESULT_SUCCESS;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 1) % 1 > 0) {
        }
        int i2 = this.zaa;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 1, i2);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, 2, this.zab);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, 3, this.zac, i, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

