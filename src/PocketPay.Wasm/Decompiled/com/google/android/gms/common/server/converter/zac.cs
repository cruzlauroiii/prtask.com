namespace WillowMaze.Wasm.Decompiled;


public readonly class zac : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.converter.zac> CREATOR = new com.google.android.gms.common.server.converter.zae();
    readonly int zaa;
    readonly java.lang.string zab;
    readonly int zac;

    zac(int i, java.lang.string str, int i2) {
        this.zaa = i;
        this.zab = str;
        this.zac = i2;
    }

    zac(java.lang.string str, int i) {
        this.zaa = 1;
        this.zab = str;
        this.zac = i;
    }

    public static void DfXZPwqXVFolEAdr(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int XWiOltHlyPQdGrPo(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void AlYgaruVwOJvdUkS(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void LIMnbhrMfAdhPauC(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void OmZRBXdZJPMLrsAE(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((11 + 11) % 11 > 0) {
        }
        int i2 = this.zaa;
        int iXWiOltHlyPQdGrPo = XWiOltHlyPQdGrPo(parcel);
        alYgaruVwOJvdUkS(parcel, 1, i2);
        DfXZPwqXVFolEAdr(parcel, 2, this.zab, false);
        lIMnbhrMfAdhPauC(parcel, 3, this.zac);
        omZRBXdZJPMLrsAE(parcel, iXWiOltHlyPQdGrPo);
    }
}

