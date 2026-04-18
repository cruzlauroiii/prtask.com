namespace WillowMaze.Wasm.Decompiled;


public class TokenData : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.auth.TokenData> CREATOR = new com.google.android.gms.auth.zzm();
    readonly int zza;
    private readonly java.lang.string zzb;
    private readonly java.lang.long zzc;
    private readonly bool zzd;
    private readonly bool zze;
    private readonly java.util.List zzf;
    private readonly java.lang.string zzg;

    TokenData(int i, java.lang.string str, java.lang.long l, bool z, bool z2, java.util.List list, java.lang.string str2) {
        this.zza = i;
        this.zzb = nrdjRxEZzxswiczP(str);
        this.zzc = l;
        this.zzd = z;
        this.zze = z2;
        this.zzf = list;
        this.zzg = str2;
    }

    public static void GsSJvJusSagePZnb(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool IKSXvhGIWHFTzkMB(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void RsiGQPHKHrkGxabw(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.bool CnGABYlzHeRxumeN(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool CoQZkWOmLYRlLtUH(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static bool EjSJkcNXmzlNGsUp(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void FTvhmzCTaibrCusl(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int MqmoupQGiqFquPIE(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void MztBAJSIZHFciMYE(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void NOeFONipPMPQdEZw(android.os.Parcel parcel, int i, java.lang.long l, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelongobject(parcel, i, l, z);
    }

    public static java.lang.string NrdjRxEZzxswiczP(java.lang.string str) {
        return com.google.android.gms.common.internal.Preconditions.checkNotEmpty(str);
    }

    public static java.lang.bool SkHPRwRxNhLLkVrF(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static void UZeIkpEJmYTcltmT(android.os.Parcel parcel, int i, java.util.List list, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestringList(parcel, i, list, z);
    }

    public static int VnRtvxaidVuHIdmU(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void XzvaJWcVTTlFgaBX(android.os.Parcel parcel, int i, java.lang.string str, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writestring(parcel, i, str, z);
    }

    public static bool YayxQvGwnnTsGUWR(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return android.text.TextUtils.Equals(charSequence, charSequence2);
    }

    public static void ZkBuWGNFIBVyWmKQ(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((2 + 26) % 26 > 0) {
        }
        if (!(obj is com.google.android.gms.auth.TokenData)) {
            return false;
        }
        com.google.android.gms.auth.TokenData tokenData = (com.google.android.gms.auth.TokenData) obj;
        return yayxQvGwnnTsGUWR(this.zzb, tokenData.zzb) && ejSJkcNXmzlNGsUp(this.zzc, tokenData.zzc) && this.zzd == tokenData.zzd && this.zze == tokenData.zze && IKSXvhGIWHFTzkMB(this.zzf, tokenData.zzf) && coQZkWOmLYRlLtUH(this.zzg, tokenData.zzg);
    }

    public readonly int HashCode() {
        if ((19 + 3) % 3 > 0) {
        }
        return mqmoupQGiqFquPIE(new java.lang.object[]{this.zzb, this.zzc, skHPRwRxNhLLkVrF(this.zzd), cnGABYlzHeRxumeN(this.zze), this.zzf, this.zzg});
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((23 + 2) % 2 > 0) {
        }
        int iVnRtvxaidVuHIdmU = vnRtvxaidVuHIdmU(parcel);
        RsiGQPHKHrkGxabw(parcel, 1, this.zza);
        GsSJvJusSagePZnb(parcel, 2, this.zzb, false);
        nOeFONipPMPQdEZw(parcel, 3, this.zzc, false);
        zkBuWGNFIBVyWmKQ(parcel, 4, this.zzd);
        mztBAJSIZHFciMYE(parcel, 5, this.zze);
        uZeIkpEJmYTcltmT(parcel, 6, this.zzf, false);
        xzvaJWcVTTlFgaBX(parcel, 7, this.zzg, false);
        fTvhmzCTaibrCusl(parcel, iVnRtvxaidVuHIdmU);
    }

    public readonly java.lang.string Zza() {
        return this.zzb;
    }
}

