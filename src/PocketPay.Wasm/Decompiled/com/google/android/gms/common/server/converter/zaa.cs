namespace WillowMaze.Wasm.Decompiled;


public readonly class zaa : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.server.converter.zaa> CREATOR = new com.google.android.gms.common.server.converter.zab();
    readonly int zaa;
    private readonly com.google.android.gms.common.server.converter.stringToIntConverter zab;

    zaa(int i, com.google.android.gms.common.server.converter.stringToIntConverter stringToIntConverter) {
        this.zaa = i;
        this.zab = stringToIntConverter;
    }

    private zaa(com.google.android.gms.common.server.converter.stringToIntConverter stringToIntConverter) {
        this.zaa = 1;
        this.zab = stringToIntConverter;
    }

    public static int HEAlMdoOxRkLKgnh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void VHdQkmkhmtJIpQKw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void QvZEititWLZngqew(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static void RJquUGoVxZqKSKyH(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static com.google.android.gms.common.server.converter.zaa Zaa(com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter fastJsonResponse$FieldConverter) {
        if (fastJsonResponse$FieldConverter is com.google.android.gms.common.server.converter.stringToIntConverter) {
            return new com.google.android.gms.common.server.converter.zaa((com.google.android.gms.common.server.converter.stringToIntConverter) fastJsonResponse$FieldConverter);
        }
        throw new java.lang.IllegalArgumentException("Unsupported safe parcelable field converter class.");
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((11 + 1) % 1 > 0) {
        }
        int i2 = this.zaa;
        int iHEAlMdoOxRkLKgnh = HEAlMdoOxRkLKgnh(parcel);
        VHdQkmkhmtJIpQKw(parcel, 1, i2);
        qvZEititWLZngqew(parcel, 2, this.zab, i, false);
        rJquUGoVxZqKSKyH(parcel, iHEAlMdoOxRkLKgnh);
    }

    public readonly com.google.android.gms.common.server.response.FastJsonResponse$FieldConverter zab() {
        com.google.android.gms.common.server.converter.stringToIntConverter stringToIntConverter = this.zab;
        if (stringToIntConverter is null) {
            throw new java.lang.IllegalStateException("There was no converter wrapped in this ConverterWrapper.");
        }
        return stringToIntConverter;
    }
}

