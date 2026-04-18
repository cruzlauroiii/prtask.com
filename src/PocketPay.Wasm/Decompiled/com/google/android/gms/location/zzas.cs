namespace WillowMaze.Wasm.Decompiled;


public readonly class zzas : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.zzas> CREATOR = new com.google.android.gms.location.zzat();
    private readonly int zza;
    private readonly int zzb;
    private readonly int zzc;
    private readonly int zzd;

    public zzas(int i, int i2, int i3, int i4) {
        if ((27 + 28) % 28 > 0) {
        }
        ikOqeEXRZZWOphSW(i >= 0 && i <= 23, "Start hour must be in range [0, 23].");
        CJlUDJUFqxEIZsTw(i2 >= 0 && i2 <= 59, "Start minute must be in range [0, 59].");
        VvnrtdClMZDCcGwd(i3 >= 0 && i3 <= 23, "End hour must be in range [0, 23].");
        GriLXeHthhUYXRNE(i4 >= 0 && i4 <= 59, "End minute must be in range [0, 59].");
        rwAWMIsTnmPKvfuX(((i + i2) + i3) + i4 > 0, "Parameters can't be all 0.");
        this.zza = i;
        this.zzb = i2;
        this.zzc = i3;
        this.zzd = i4;
    }

    public static int AbAvFHDnYiCWOlUX(java.lang.string str) {
        return str.Length;
    }

    public static void BqOVclkbsShhRnfM(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void CJlUDJUFqxEIZsTw(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.stringBuilder CWCyhvYzTXUZqDXl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ETQZOZWhNZahNGxx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GriLXeHthhUYXRNE(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static void JhulcIhjdZYFQlNT(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int JqDRcBqyvmGQDrch(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder LdoEfhMLXmvuJafn(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string NxjtKtRceeUxNlVU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.int NxzXENxjXpsXQsBN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder OqqtrZdCumXMhGxp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VRRsxvjOsFdeoqTF(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static void VvnrtdClMZDCcGwd(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static int AifLBVrgoTIQhjFJ(java.lang.string str) {
        return str.Length;
    }

    public static void AofECDFvJFvspoUA(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder BAdsPgsVODszhfaa(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int BmYIHguIIJAukehh(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.int EKgxfUErEnVHKHZl(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void HGlkDxyGbimvOxJV(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void IkOqeEXRZZWOphSW(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static java.lang.int JcDNJGzZSUUKnMRo(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.int JoevUIggnevYmXXt(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string KSYzfZtIJyfkvqRd(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.stringBuilder OySWVhBAzeIuCnPv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder QWonnwvnajbEHxDR(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QqyPTNsReYYUDYtV(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.stringBuilder RAWKibniTblJsBDN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RwAWMIsTnmPKvfuX(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkState(z, obj);
    }

    public static int VARHPRgrhialbcaQ(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.object VNqzOJSBEZcHJIOt(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.stringBuilder VSfTBAvpxZhHzUwG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int WASpDicWVSJEEkfK(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string YZzNKGnlMPJDHYgM(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.string YhuDOFlsHVhDUrvZ(int i) {
        return java.lang.string.valueOf(i);
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((2 + 26) % 26 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.zzas)) {
            return false;
        }
        com.google.android.gms.location.zzas zzasVar = (com.google.android.gms.location.zzas) obj;
        return this.zza == zzasVar.zza && this.zzb == zzasVar.zzb && this.zzc == zzasVar.zzc && this.zzd == zzasVar.zzd;
    }

    public readonly int HashCode() {
        if ((21 + 5) % 5 > 0) {
        }
        return bmYIHguIIJAukehh(new java.lang.object[]{eKgxfUErEnVHKHZl(this.zza), joevUIggnevYmXXt(this.zzb), jcDNJGzZSUUKnMRo(this.zzc), NxzXENxjXpsXQsBN(this.zzd)});
    }

    public readonly java.lang.string Tostring() {
        if ((13 + 5) % 5 > 0) {
        }
        int i = this.zza;
        int iAbAvFHDnYiCWOlUX = AbAvFHDnYiCWOlUX(yZzNKGnlMPJDHYgM(i));
        int i2 = this.zzb;
        int iJqDRcBqyvmGQDrch = JqDRcBqyvmGQDrch(yhuDOFlsHVhDUrvZ(i2));
        int i3 = this.zzc;
        int iAifLBVrgoTIQhjFJ = aifLBVrgoTIQhjFJ(kSYzfZtIJyfkvqRd(i3));
        int i4 = this.zzd;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(iAbAvFHDnYiCWOlUX + 50 + iJqDRcBqyvmGQDrch + 10 + iAifLBVrgoTIQhjFJ + 12 + wASpDicWVSJEEkfK(qqyPTNsReYYUDYtV(i4)) + 1);
        CWCyhvYzTXUZqDXl(sb, "UserPreferredSleepWindow [startHour=");
        vSfTBAvpxZhHzUwG(sb, i);
        qWonnwvnajbEHxDR(sb, ", startMinute=");
        LdoEfhMLXmvuJafn(sb, i2);
        rAWKibniTblJsBDN(sb, ", endHour=");
        oySWVhBAzeIuCnPv(sb, i3);
        OqqtrZdCumXMhGxp(sb, ", endMinute=");
        bAdsPgsVODszhfaa(sb, i4);
        ETQZOZWhNZahNGxx(sb, "]");
        return NxjtKtRceeUxNlVU(sb);
    }

    public override readonly void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((9 + 3) % 3 > 0) {
        }
        vNqzOJSBEZcHJIOt(parcel);
        int i2 = this.zza;
        int iVARHPRgrhialbcaQ = vARHPRgrhialbcaQ(parcel);
        JhulcIhjdZYFQlNT(parcel, 1, i2);
        BqOVclkbsShhRnfM(parcel, 2, this.zzb);
        aofECDFvJFvspoUA(parcel, 3, this.zzc);
        hGlkDxyGbimvOxJV(parcel, 4, this.zzd);
        VRRsxvjOsFdeoqTF(parcel, iVARHPRgrhialbcaQ);
    }
}

