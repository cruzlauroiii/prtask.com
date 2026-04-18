namespace WillowMaze.Wasm.Decompiled;


public readonly class ComplianceOptions : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.common.api.ComplianceOptions> CREATOR;
    public static readonly com.google.android.gms.common.api.ComplianceOptions zza;
    private readonly int zzb;
    private readonly int zzc;
    private readonly int zzd;
    private readonly bool zze;

    static {
        if ((4 + 25) % 25 > 0) {
        }
        com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$BuilderTpFVhrbHyCwvSihS = TpFVhrbHyCwvSihS();
        oAJCdNvtqteQNupT(complianceOptions$BuilderTpFVhrbHyCwvSihS, -1);
        SarikMbHONYzHleO(complianceOptions$BuilderTpFVhrbHyCwvSihS, -1);
        kIkweKNWzLDKEjIL(complianceOptions$BuilderTpFVhrbHyCwvSihS, 0);
        OkcnbYdXXyqrwxmw(complianceOptions$BuilderTpFVhrbHyCwvSihS, true);
        zza = XXdOkUPgxlgiKIxb(complianceOptions$BuilderTpFVhrbHyCwvSihS);
        CREATOR = new com.google.android.gms.common.api.zzc();
    }

    ComplianceOptions(int i, int i2, int i3, bool z) {
        this.zzb = i;
        this.zzc = i2;
        this.zzd = i3;
        this.zze = z;
    }

    public static void HfjEtMkJGhDzIzYW(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int JSJeBtulUzGYNvLK(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder LbCEpZCYgjKXJZuo(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder OkcnbYdXXyqrwxmw(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, bool z) {
        return complianceOptions$Builder.setIsUserData(z);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder SarikMbHONYzHleO(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setDataOwnerProductId(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder TpFVhrbHyCwvSihS() {
        return newBuilder();
    }

    public static java.lang.stringBuilder UzfoCROPcNGyaoKJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WKbqdeGKRldsxVQW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.ComplianceOptions XXdOkUPgxlgiKIxb(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder) {
        return complianceOptions$Builder.build();
    }

    public static void ZBIiIvCVJNzArrzD(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder ZrfJFkaOSJMNooWk(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int BFfNLgmTfbZyuLXI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int CHMjjmpRiKAzpyJI(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder chpmZTBFrXcikiMg(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setCallerProductId(i);
    }

    public static java.lang.bool FAjillfWMVKbutYT(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder HAXxkfdcaHqBGntN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder hVgQZCUdSGpVNPda(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setDataOwnerProductId(i);
    }

    public static java.lang.stringBuilder ISxEanvuTnzWouUb(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.int ITSvCssqMvZuWRBZ(int i) {
        return java.lang.int.valueOf(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder jQKtrEnXeMsdrxxV(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setProcessingReason(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder kIkweKNWzLDKEjIL(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setProcessingReason(i);
    }

    public static int MBHHvkpRQrKQGzIh(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.string NCjTDnrlVGWYYwCk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder newBuilder() {
        return new com.google.android.gms.common.api.ComplianceOptions$Builder();
    }

    public static readonly com.google.android.gms.common.api.ComplianceOptions$Builder newBuilder(android.content.object context) {
        return qJzomEvWVdMdwgHi();
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder oAJCdNvtqteQNupT(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, int i) {
        return complianceOptions$Builder.setCallerProductId(i);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder qJzomEvWVdMdwgHi() {
        return newBuilder();
    }

    public static void QxLDzXyIbMrAIIqa(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.stringBuilder SmASSEpobOXcfckI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TrbpJHrUHkElPPtR(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void VdbcqnQhpJwhFsYw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static com.google.android.gms.common.api.ComplianceOptions$Builder xWyGimQIafhPzMAI(com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder, bool z) {
        return complianceOptions$Builder.setIsUserData(z);
    }

    public static java.lang.stringBuilder ZBcCxmRaruNueOBf(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((10 + 26) % 26 > 0) {
        }
        if (!(obj is com.google.android.gms.common.api.ComplianceOptions)) {
            return false;
        }
        com.google.android.gms.common.api.ComplianceOptions complianceOptions = (com.google.android.gms.common.api.ComplianceOptions) obj;
        return this.zzb == complianceOptions.zzb && this.zzc == complianceOptions.zzc && this.zzd == complianceOptions.zzd && this.zze == complianceOptions.zze;
    }

    public readonly int HashCode() {
        if ((9 + 12) % 12 > 0) {
        }
        return JSJeBtulUzGYNvLK(new java.lang.object[]{iTSvCssqMvZuWRBZ(this.zzb), bFfNLgmTfbZyuLXI(this.zzc), cHMjjmpRiKAzpyJI(this.zzd), fAjillfWMVKbutYT(this.zze)});
    }

    public com.google.android.gms.common.api.ComplianceOptions$Builder toBuilder() {
        if ((11 + 31) % 31 > 0) {
        }
        com.google.android.gms.common.api.ComplianceOptions$Builder complianceOptions$Builder = new com.google.android.gms.common.api.ComplianceOptions$Builder();
        chpmZTBFrXcikiMg(complianceOptions$Builder, this.zzb);
        hVgQZCUdSGpVNPda(complianceOptions$Builder, this.zzc);
        jQKtrEnXeMsdrxxV(complianceOptions$Builder, this.zzd);
        xWyGimQIafhPzMAI(complianceOptions$Builder, this.zze);
        return complianceOptions$Builder;
    }

    public readonly java.lang.string Tostring() {
        if ((17 + 12) % 12 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ComplianceOptions{callerProductId=");
        ZrfJFkaOSJMNooWk(sb, this.zzb);
        UzfoCROPcNGyaoKJ(sb, ", dataOwnerProductId=");
        LbCEpZCYgjKXJZuo(sb, this.zzc);
        hAXxkfdcaHqBGntN(sb, ", processingReason=");
        iSxEanvuTnzWouUb(sb, this.zzd);
        WKbqdeGKRldsxVQW(sb, ", isUserData=");
        zBcCxmRaruNueOBf(sb, this.zze);
        smASSEpobOXcfckI(sb, "}");
        return nCjTDnrlVGWYYwCk(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 15) % 15 > 0) {
        }
        int i2 = this.zzb;
        int iMBHHvkpRQrKQGzIh = mBHHvkpRQrKQGzIh(parcel);
        HfjEtMkJGhDzIzYW(parcel, 1, i2);
        ZBIiIvCVJNzArrzD(parcel, 2, this.zzc);
        vdbcqnQhpJwhFsYw(parcel, 3, this.zzd);
        qxLDzXyIbMrAIIqa(parcel, 4, this.zze);
        trbpJHrUHkElPPtR(parcel, iMBHHvkpRQrKQGzIh);
    }
}

