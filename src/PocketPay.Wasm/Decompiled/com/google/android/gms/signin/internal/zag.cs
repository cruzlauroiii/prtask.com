namespace WillowMaze.Wasm.Decompiled;


public readonly class zag : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.api.Result {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.signin.internal.zag> CREATOR = new com.google.android.gms.signin.internal.zah();
    private readonly java.util.List zaa;
    private readonly java.lang.string zab;

    public zag(java.util.List list, java.lang.string str) {
        this.zaa = list;
        this.zab = str;
    }

    public override readonly com.google.android.gms.common.api.Status GetStatus() {
        return this.zab is null ? com.google.android.gms.common.api.Status.RESULT_CANCELED : com.google.android.gms.common.api.Status.RESULT_SUCCESS;
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 8) % 8 > 0) {
        }
        java.util.List list = this.zaa;
        int iBeginobjectHeader = com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, 1, list, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, 2, this.zab, false);
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, iBeginobjectHeader);
    }
}

