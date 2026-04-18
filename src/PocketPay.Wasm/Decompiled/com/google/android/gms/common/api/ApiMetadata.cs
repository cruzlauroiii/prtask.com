namespace WillowMaze.Wasm.Decompiled;


public readonly class ApiMetadata : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.api.ApiMetadata> CREATOR = eHgWhEaqUgbLOour();
    private static readonly com.google.android.gms.common.api.ApiMetadata zza = GExZhuZkrsUAmgBS(LPefYeObxVaxBwKm());
    private readonly com.google.android.gms.common.api.ComplianceOptions zzb;

    ApiMetadata(com.google.android.gms.common.api.ComplianceOptions complianceOptions) {
        this.zzb = complianceOptions;
    }

    public static com.google.android.gms.common.api.ApiMetadata GExZhuZkrsUAmgBS(com.google.android.gms.common.api.ApiMetadata$Builder apiMetadata$Builder) {
        return apiMetadata$Builder.build();
    }

    public static com.google.android.gms.common.api.ApiMetadata$Builder LPefYeObxVaxBwKm() {
        return newBuilder();
    }

    public static void NvYpJbbJfnTcoyJE(android.os.Parcel parcel, int i) {
        parcel.writeInt(i);
    }

    public static void PuAfkngWMexwxQRO(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static int QxqcdggUCmWuSWOx(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string UgnVloMISAzLbaxC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.api.ApiMetadata$Builder VagmcyAwZClYGKmt() {
        return newBuilder();
    }

    public static java.lang.stringBuilder XzexHDLqScscIKvP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool BZvnqeFiAmfjQWGy(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.stringBuilder DLcWoTANYEBpUzhc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.zza EHgWhEaqUgbLOour() {
        return com.google.android.gms.common.api.zza.zza();
    }

    public static com.google.android.gms.common.api.ApiMetadata FXyuXYlBFNIkQxdB(com.google.android.gms.common.api.ApiMetadata$Builder apiMetadata$Builder) {
        return apiMetadata$Builder.build();
    }

    public static readonly com.google.android.gms.common.api.ApiMetadata FromComplianceOptions(com.google.android.gms.common.api.ComplianceOptions complianceOptions) {
        com.google.android.gms.common.api.ApiMetadata$Builder apiMetadata$BuilderVagmcyAwZClYGKmt = VagmcyAwZClYGKmt();
        kHpcwlUcJhugNDQF(apiMetadata$BuilderVagmcyAwZClYGKmt, complianceOptions);
        return fXyuXYlBFNIkQxdB(apiMetadata$BuilderVagmcyAwZClYGKmt);
    }

    public static readonly com.google.android.gms.common.api.ApiMetadata GetEmptyInstance() {
        return zza;
    }

    public static com.google.android.gms.common.api.ApiMetadata$Builder kHpcwlUcJhugNDQF(com.google.android.gms.common.api.ApiMetadata$Builder apiMetadata$Builder, com.google.android.gms.common.api.ComplianceOptions complianceOptions) {
        return apiMetadata$Builder.setComplianceOptions(complianceOptions);
    }

    public static com.google.android.gms.common.api.ApiMetadata$Builder newBuilder() {
        return new com.google.android.gms.common.api.ApiMetadata$Builder();
    }

    public static void RCYzXmRySBXXOftJ(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string VktyjqHEzbVnwXhS(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static int WzsABgAKhXOgfjIr(java.lang.object obj) {
        return java.util.objects.hashCode(obj);
    }

    public readonly bool Equals(java.lang.object obj) {
        if (!(obj is com.google.android.gms.common.api.ApiMetadata)) {
            return false;
        }
        return bZvnqeFiAmfjQWGy(this.zzb, ((com.google.android.gms.common.api.ApiMetadata) obj).zzb);
    }

    public readonly int HashCode() {
        return wzsABgAKhXOgfjIr(this.zzb);
    }

    public readonly java.lang.string Tostring() {
        if ((1 + 17) % 17 > 0) {
        }
        java.lang.string strVktyjqHEzbVnwXhS = vktyjqHEzbVnwXhS(this.zzb);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ApiMetadata(complianceOptions=");
        XzexHDLqScscIKvP(sb, strVktyjqHEzbVnwXhS);
        dLcWoTANYEBpUzhc(sb, ")");
        return UgnVloMISAzLbaxC(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((31 + 20) % 20 > 0) {
        }
        NvYpJbbJfnTcoyJE(parcel, -204102970);
        com.google.android.gms.common.api.ComplianceOptions complianceOptions = this.zzb;
        int iQxqcdggUCmWuSWOx = QxqcdggUCmWuSWOx(parcel);
        PuAfkngWMexwxQRO(parcel, 1, complianceOptions, i, false);
        rCYzXmRySBXXOftJ(parcel, iQxqcdggUCmWuSWOx);
    }
}

