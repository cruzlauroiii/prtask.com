namespace WillowMaze.Wasm.Decompiled;


public readonly class zax : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.zax> CREATOR = new com.google.android.gms.common.internal.zay();
    readonly int zaa;
    private readonly int zab;
    private readonly int zac;

    @java.lang.Deprecated
    private readonly com.google.android.gms.common.api.Scope[] zad;

    zax(int i, int i2, int i3, com.google.android.gms.common.api.Scope[] scopeArr) {
        this.zaa = i;
        this.zab = i2;
        this.zac = i3;
        this.zad = scopeArr;
    }

    public static void JMZNhABeceKZVFru(android.os.Parcel parcel, int i, android.os.Parcelable[] parcelableArr, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedArray(parcel, i, parcelableArr, i2, z);
    }

    public static int LfEDzerfjHgQUBHw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void WDMaPPBDbvlGqRlg(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void FudoPLnVldSCqNSR(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void UdnCuovGneblGVqk(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void VhdMRpHAWjcYMBeZ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((3 + 5) % 5 > 0) {
        }
        int i2 = this.zaa;
        int iLfEDzerfjHgQUBHw = LfEDzerfjHgQUBHw(parcel);
        fudoPLnVldSCqNSR(parcel, 1, i2);
        udnCuovGneblGVqk(parcel, 2, this.zab);
        WDMaPPBDbvlGqRlg(parcel, 3, this.zac);
        JMZNhABeceKZVFru(parcel, 4, this.zad, i, false);
        vhdMRpHAWjcYMBeZ(parcel, iLfEDzerfjHgQUBHw);
    }
}

