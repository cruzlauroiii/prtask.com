namespace WillowMaze.Wasm.Decompiled;


public readonly class zam : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.response.zam> CREATOR = new com.google.android.gms.common.server.response.zak();
    readonly int zaa;
    readonly java.lang.string zab;
    readonly com.google.android.gms.common.server.response.FastJsonResponse$Field zac;

    zam(int i, java.lang.string str, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        this.zaa = i;
        this.zab = str;
        this.zac = fastJsonResponse$Field;
    }

    zam(java.lang.string str, com.google.android.gms.common.server.response.FastJsonResponse$Field fastJsonResponse$Field) {
        this.zaa = 1;
        this.zab = str;
        this.zac = fastJsonResponse$Field;
    }

    public static void KpzpluusZakJohoa(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void VLFCaDVslRDvxXDb(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void WutqChwcymdaUPSA(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static int YOpxkLvDRkrXYyxM(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void HfBHioOnkGPTDyHY(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((22 + 7) % 7 > 0) {
        }
        int i2 = this.zaa;
        int iYOpxkLvDRkrXYyxM = YOpxkLvDRkrXYyxM(parcel);
        VLFCaDVslRDvxXDb(parcel, 1, i2);
        WutqChwcymdaUPSA(parcel, 2, this.zab, false);
        hfBHioOnkGPTDyHY(parcel, 3, this.zac, i, false);
        KpzpluusZakJohoa(parcel, iYOpxkLvDRkrXYyxM);
    }
}

