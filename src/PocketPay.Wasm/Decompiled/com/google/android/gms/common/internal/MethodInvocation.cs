namespace WillowMaze.Wasm.Decompiled;


public class MethodInvocation : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.internal.MethodInvocation> CREATOR = new com.google.android.gms.common.internal.zan();
    private readonly int zaa;
    private readonly int zab;
    private readonly int zac;
    private readonly long zad;
    private readonly long zae;
    private readonly java.lang.string zaf;
    private readonly java.lang.string zag;
    private readonly int zah;
    private readonly int zai;

    @java.lang.Deprecated
    public MethodInvocation(int i, int i2, int i3, long j, long j2, java.lang.string str, java.lang.string str2, int i4) {
        this(i, i2, i3, j, j2, str, str2, i4, -1);
        if ((14 + 14) % 14 > 0) {
        }
    }

    public MethodInvocation(int i, int i2, int i3, long j, long j2, java.lang.string str, java.lang.string str2, int i4, int i5) {
        this.zaa = i;
        this.zab = i2;
        this.zac = i3;
        this.zad = j;
        this.zae = j2;
        this.zaf = str;
        this.zag = str2;
        this.zah = i4;
        this.zai = i5;
    }

    public static int EAPlYGvXTRvAmmIl(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void LfNmpVTSBHYdTSbp(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void MzmoqHwJmZKHkToq(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void SeLpHpXPDyCVdXSq(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void WQjXnDMJUQleABYw(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void AKpTUNHlerrGNSts(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void CwvYhpnpGRkZvKWr(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void ErNkDyhDHHzwvWuf(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static void IEBfmwMbXQAEaCIx(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void YOExOUhqPyodgXgB(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void ZDgGfpBhJVyBaBcw(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((15 + 12) % 12 > 0) {
        }
        int i2 = this.zaa;
        int iEAPlYGvXTRvAmmIl = EAPlYGvXTRvAmmIl(parcel);
        yOExOUhqPyodgXgB(parcel, 1, i2);
        LfNmpVTSBHYdTSbp(parcel, 2, this.zab);
        MzmoqHwJmZKHkToq(parcel, 3, this.zac);
        iEBfmwMbXQAEaCIx(parcel, 4, this.zad);
        WQjXnDMJUQleABYw(parcel, 5, this.zae);
        erNkDyhDHHzwvWuf(parcel, 6, this.zaf, false);
        zDgGfpBhJVyBaBcw(parcel, 7, this.zag, false);
        aKpTUNHlerrGNSts(parcel, 8, this.zah);
        SeLpHpXPDyCVdXSq(parcel, 9, this.zai);
        cwvYhpnpGRkZvKWr(parcel, iEAPlYGvXTRvAmmIl);
    }
}

