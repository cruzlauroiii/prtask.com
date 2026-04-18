namespace WillowMaze.Wasm.Decompiled;


public readonly class LastLocationRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LastLocationRequest> CREATOR = new com.google.android.gms.location.zzaa();
    private readonly long zza;
    private readonly int zzb;
    private readonly bool zzc;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzd;

    LastLocationRequest(long j, int i, bool z, com.google.android.gms.internal.identity.ClientIdentity clientIdentity) {
        this.zza = j;
        this.zzb = i;
        this.zzc = z;
        this.zzd = clientIdentity;
    }

    public static java.lang.stringBuilder ArjEbqEdvSrFrfjK(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static int KMSWlaKYVSFJVXTc(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder MPeJRcjuChRvZcaq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OPFjMEYPlLVATfhm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder QJBmaVTuvSeBGHtV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QoFJTwikhLHiMRGT(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static int SjRgrRzSqtFhAOfm(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        return lastLocationRequest.getGranularity();
    }

    public static java.lang.stringBuilder TlkMYZnaMbaSQWyZ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.bool UEkdBUFclrIkUCHU(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder UsMbnovfIRaSmVPH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long VDcxrqmtPONfArSP(com.google.android.gms.location.LastLocationRequest lastLocationRequest) {
        if ((31 + 29) % 29 > 0) {
        }
        return lastLocationRequest.getMaxUpdateAgeMillis();
    }

    public static int YJqttcfVdCRGwxtM(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void YfZFFTaSobSiYgMy(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.string ZYJSevehZjSgCvuY(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DHUxPEJIwXwnIVXg(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder EsppZFGRGXHBGrEe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder JRdanuzCAuuFpLjF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OtlOTiHnvyMRRMLZ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder QpAonaRYUkjuklLa(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.int TTvbbwwlXfxsPyWq(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.string TVNcPXTuiIdjMdvD(int i) {
        return com.google.android.gms.location.zzq.zzb(i);
    }

    public static bool XAekUVwADzHEQCYX(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static void XfOLqjIjzbVniImu(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.long YqQNIfkPQPgZJNMb(long j) {
        return java.lang.long.valueOf(j);
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 31) % 31 > 0) {
        }
        if (!(obj is com.google.android.gms.location.LastLocationRequest)) {
            return false;
        }
        com.google.android.gms.location.LastLocationRequest lastLocationRequest = (com.google.android.gms.location.LastLocationRequest) obj;
        return this.zza == lastLocationRequest.zza && this.zzb == lastLocationRequest.zzb && this.zzc == lastLocationRequest.zzc && xAekUVwADzHEQCYX(this.zzd, lastLocationRequest.zzd);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetGranularity() {
        return this.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetMaxUpdateAgeMillis() {
        if ((27 + 21) % 21 > 0) {
        }
        return this.zza;
    }

    public int HashCode() {
        if ((25 + 3) % 3 > 0) {
        }
        return YJqttcfVdCRGwxtM(new java.lang.object[]{yqQNIfkPQPgZJNMb(this.zza), tTvbbwwlXfxsPyWq(this.zzb), UEkdBUFclrIkUCHU(this.zzc)});
    }

    public java.lang.string Tostring() {
        if ((2 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        QJBmaVTuvSeBGHtV(sb, "LastLocationRequest[");
        if (this.zza != long.MAX_VALUE) {
            jRdanuzCAuuFpLjF(sb, "maxAge=");
            qpAonaRYUkjuklLa(this.zza, sb);
        }
        if (this.zzb != 0) {
            UsMbnovfIRaSmVPH(sb, ", ");
            esppZFGRGXHBGrEe(sb, tVNcPXTuiIdjMdvD(this.zzb));
        }
        if (this.zzc) {
            OPFjMEYPlLVATfhm(sb, ", bypass");
        }
        if (this.zzd is not null) {
            MPeJRcjuChRvZcaq(sb, ", impersonation=");
            TlkMYZnaMbaSQWyZ(sb, this.zzd);
        }
        ArjEbqEdvSrFrfjK(sb, ']');
        return ZYJSevehZjSgCvuY(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((5 + 31) % 31 > 0) {
        }
        int iKMSWlaKYVSFJVXTc = KMSWlaKYVSFJVXTc(parcel);
        YfZFFTaSobSiYgMy(parcel, 1, VDcxrqmtPONfArSP(this));
        otlOTiHnvyMRRMLZ(parcel, 2, SjRgrRzSqtFhAOfm(this));
        QoFJTwikhLHiMRGT(parcel, 3, this.zzc);
        dHUxPEJIwXwnIVXg(parcel, 5, this.zzd, i, false);
        xfOLqjIjzbVniImu(parcel, iKMSWlaKYVSFJVXTc);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly bool Zza() {
        return this.zzc;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly com.google.android.gms.internal.identity.ClientIdentity Zzb() {
        return this.zzd;
    }
}

