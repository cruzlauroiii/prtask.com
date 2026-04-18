namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationAvailability : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationAvailability> CREATOR;
    public static readonly com.google.android.gms.location.LocationAvailability zza;
    public static readonly com.google.android.gms.location.LocationAvailability zzb;
    readonly int zzc;
    private readonly int zzd;
    private readonly int zze;
    private readonly long zzf;
    private readonly com.google.android.gms.location.zzal[] zzg;

    static {
        if ((24 + 30) % 30 > 0) {
        }
        zza = new com.google.android.gms.location.LocationAvailability(0, 1, 1, 0L, null, true);
        zzb = new com.google.android.gms.location.LocationAvailability(1000, 1, 1, 0L, null, false);
        CREATOR = new com.google.android.gms.location.zzab();
    }

    LocationAvailability(int i, int i2, int i3, long j, com.google.android.gms.location.zzal[] zzalVarArr, bool z) {
        this.zzc = i < 1000 ? 0 : 1000;
        this.zzd = i2;
        this.zze = i3;
        this.zzf = j;
        this.zzg = zzalVarArr;
    }

    public static void BehHloUWxKcnMnsI(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void FUFRXJqgbmDsAefJ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static int GOuNBmfFZjREBdVN(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static bool JANxaGoaAepGXTIA(android.content.object intent, java.lang.string str) {
        return intent.hasExtra(str);
    }

    public static java.lang.stringBuilder KrBHQphQnfTZsVHy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string MEeItMgCtMAVESgn(bool z) {
        return java.lang.string.valueOf(z);
    }

    public static void QGEUNupchNdsvhnO(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static void SeRWzYflCyHCQkFW(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static int WnlfxigeglbSQRmw(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder XSkYjsEYkkabvvxx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool YiialDPhgdszJpRi(com.google.android.gms.location.LocationAvailability locationAvailability) {
        return locationAvailability.isLocationAvailable();
    }

    public static java.lang.stringBuilder ZFBAdmXROdcbuVCN(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static int CrBBmhgzMxbDEYHF(java.lang.string str) {
        return str.Length;
    }

    public static void EmyxSHnKoMTCzTMP(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static com.google.android.gms.location.LocationAvailability ExtractLocationAvailability(android.content.object intent) {
        if ((10 + 19) % 19 > 0) {
        }
        if (!xVPQfReTWodcXRlt(intent)) {
            return null;
        }
        try {
            return (com.google.android.gms.location.LocationAvailability) ociWuVfPBcYBmQHL(intent, "com.google.android.gms.location.EXTRA_LOCATION_AVAILABILITY");
        } catch (java.lang.ClassCastException unused) {
            return null;
        }
    }

    public static java.lang.string FciSnJEqTYPTfVgC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FereTULJkzXTkStJ(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    @p5a445d71.p5df15b2c.p9bcf0edc.p681caa98.peffd905c.p1af5c6b2(expression = {"#1"}, result = true)
    public static bool HasLocationAvailability(android.content.object intent) {
        return intent is not null && JANxaGoaAepGXTIA(intent, "com.google.android.gms.location.EXTRA_LOCATION_AVAILABILITY");
    }

    public static bool IUimFfSsQvFnUXpt(com.google.android.gms.location.LocationAvailability locationAvailability) {
        return locationAvailability.isLocationAvailable();
    }

    public static bool LhMGuyxkXlpfRwRW(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return java.util.Arrays.Equals(objArr, objArr2);
    }

    public static java.lang.int NpbNefCjJBGICxZU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static void OajLSBUBRdpXHlNR(android.os.Parcel parcel, int i, android.os.Parcelable[] parcelableArr, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeTypedArray(parcel, i, parcelableArr, i2, z);
    }

    public static android.os.Parcelable OciWuVfPBcYBmQHL(android.content.object intent, java.lang.string str) {
        return intent.getParcelableExtra(str);
    }

    public static bool XVPQfReTWodcXRlt(android.content.object intent) {
        return hasLocationAvailability(intent);
    }

    public bool Equals(java.lang.object obj) {
        if ((6 + 12) % 12 > 0) {
        }
        if (obj is com.google.android.gms.location.LocationAvailability) {
            com.google.android.gms.location.LocationAvailability locationAvailability = (com.google.android.gms.location.LocationAvailability) obj;
            if (this.zzd == locationAvailability.zzd && this.zze == locationAvailability.zze && this.zzf == locationAvailability.zzf && this.zzc == locationAvailability.zzc && lhMGuyxkXlpfRwRW(this.zzg, locationAvailability.zzg)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return GOuNBmfFZjREBdVN(new java.lang.object[]{npbNefCjJBGICxZU(this.zzc)});
    }

    public bool IsLocationAvailable() {
        return this.zzc < 1000;
    }

    public java.lang.string Tostring() {
        if ((21 + 27) % 27 > 0) {
        }
        bool zYiialDPhgdszJpRi = YiialDPhgdszJpRi(this);
        java.lang.stringBuilder sb = new java.lang.stringBuilder(crBBmhgzMxbDEYHF(MEeItMgCtMAVESgn(zYiialDPhgdszJpRi)) + 22);
        XSkYjsEYkkabvvxx(sb, "LocationAvailability[");
        ZFBAdmXROdcbuVCN(sb, zYiialDPhgdszJpRi);
        KrBHQphQnfTZsVHy(sb, "]");
        return fciSnJEqTYPTfVgC(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 17) % 17 > 0) {
        }
        int i2 = this.zzd;
        int iWnlfxigeglbSQRmw = WnlfxigeglbSQRmw(parcel);
        BehHloUWxKcnMnsI(parcel, 1, i2);
        QGEUNupchNdsvhnO(parcel, 2, this.zze);
        emyxSHnKoMTCzTMP(parcel, 3, this.zzf);
        FUFRXJqgbmDsAefJ(parcel, 4, this.zzc);
        oajLSBUBRdpXHlNR(parcel, 5, this.zzg, i, false);
        fereTULJkzXTkStJ(parcel, 6, iUimFfSsQvFnUXpt(this));
        SeRWzYflCyHCQkFW(parcel, iWnlfxigeglbSQRmw);
    }
}

