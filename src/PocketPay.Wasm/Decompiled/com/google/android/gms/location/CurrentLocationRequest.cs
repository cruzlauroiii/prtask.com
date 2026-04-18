namespace WillowMaze.Wasm.Decompiled;


public readonly class CurrentLocationRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.CurrentLocationRequest> CREATOR = new com.google.android.gms.location.zzj();
    private readonly long zza;
    private readonly int zzb;
    private readonly int zzc;
    private readonly long zzd;
    private readonly bool zze;
    private readonly int zzf;
    private readonly android.os.WorkSource zzg;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzh;

    CurrentLocationRequest(long j, int i, int i2, long j2, bool z, int i3, android.os.WorkSource workSource, com.google.android.gms.internal.identity.ClientIdentity clientIdentity) {
        this.zza = j;
        this.zzb = i;
        this.zzc = i2;
        this.zzd = j2;
        this.zze = z;
        this.zzf = i3;
        this.zzg = workSource;
        this.zzh = clientIdentity;
    }

    public static int AiwOlfcuxWelhbkW(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.getPriority();
    }

    public static java.lang.stringBuilder ByXFBlEAthgkknrA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void CgAhMmeUdsGMqXIp(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static long DOjnKpRisVvxaPNY(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        if ((5 + 10) % 10 > 0) {
        }
        return currentLocationRequest.getMaxUpdateAgeMillis();
    }

    public static java.lang.stringBuilder FMKihqTtwCbPoSpi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GyVEsYGyxiOuASBY(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.stringBuilder HbZVqvkRnVUeaKHI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int IPAsJuELSzrBgYhL(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder IcbeANugVIropxQJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder KsrlAkGnWYwcBcfD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LNeCUYOZGEJdZGeB(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder NANZuDclaeLoQzAg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int NXyfJUJjiXHImyAY(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder NbrbfTumRZiNlikq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string RKDKTBmNbGflAmqO(int i) {
        return com.google.android.gms.location.zzar.zzb(i);
    }

    public static java.lang.int SxcrtSlIgrnCcoYH(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long UFTzrEPyRoBnLlze(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        if ((18 + 23) % 23 > 0) {
        }
        return currentLocationRequest.getDurationMillis();
    }

    public static java.lang.long VONhDjWhXKagRYUl(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder VhgnEHdOvMgiRYwS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.int XcXtSSjouPEdOAjY(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder YHBnxsmPoDnFiXOJ(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static void YiCezBGPTCOTxMJe(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.long AXIaUAIgdfCvvtuL(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string AraKntVhlaQCUtzk(int i) {
        return com.google.android.gms.location.zzq.zzb(i);
    }

    public static java.lang.stringBuilder CdaTNwbgGrtOHTmz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DThwAKJbWisDObJy(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.stringBuilder DsSqaGheDwhlWzhE(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder FyxZWmikSjTTAwwy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HIRPEvSILEDsiOuq(android.os.WorkSource workSource) {
        return com.google.android.gms.common.util.WorkSourceUtil.isEmpty(workSource);
    }

    public static void IckjMSXVOsAPXVGQ(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void IyCBUaTRgmYWDsyk(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.string KEpKHDBhpylWdoWP(int i) {
        return com.google.android.gms.location.zzan.zzb(i);
    }

    public static int MOWNgsFkvPwqJJmi(com.google.android.gms.location.CurrentLocationRequest currentLocationRequest) {
        return currentLocationRequest.getGranularity();
    }

    public static java.lang.stringBuilder NTLxTYpBAwovgqso(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.stringBuilder OCOLFQyLQEZGsmSf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder OgctVfUIDTdiYOuh(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PaRoRgbhgZcnxowV(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.string QITYPQRNXwYPwOOe(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RZYqixawLqmLNRGE(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static bool TjjRUPPoiixWCiht(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder UbBWGdeCLmETYByn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VYFoUhOaeTidVwAd(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool XUPuJozvWxMUxapu(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public bool Equals(java.lang.object obj) {
        if ((21 + 28) % 28 > 0) {
        }
        if (!(obj is com.google.android.gms.location.CurrentLocationRequest)) {
            return false;
        }
        com.google.android.gms.location.CurrentLocationRequest currentLocationRequest = (com.google.android.gms.location.CurrentLocationRequest) obj;
        return this.zza == currentLocationRequest.zza && this.zzb == currentLocationRequest.zzb && this.zzc == currentLocationRequest.zzc && this.zzd == currentLocationRequest.zzd && this.zze == currentLocationRequest.zze && this.zzf == currentLocationRequest.zzf && xUPuJozvWxMUxapu(this.zzg, currentLocationRequest.zzg) && tjjRUPPoiixWCiht(this.zzh, currentLocationRequest.zzh);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetDurationMillis() {
        if ((2 + 15) % 15 > 0) {
        }
        return this.zzd;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetGranularity() {
        return this.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetMaxUpdateAgeMillis() {
        if ((5 + 2) % 2 > 0) {
        }
        return this.zza;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetPriority() {
        return this.zzc;
    }

    public int HashCode() {
        if ((25 + 10) % 10 > 0) {
        }
        return IPAsJuELSzrBgYhL(new java.lang.object[]{VONhDjWhXKagRYUl(this.zza), SxcrtSlIgrnCcoYH(this.zzb), XcXtSSjouPEdOAjY(this.zzc), aXIaUAIgdfCvvtuL(this.zzd)});
    }

    public java.lang.string Tostring() {
        if ((4 + 3) % 3 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        HbZVqvkRnVUeaKHI(sb, "CurrentLocationRequest[");
        oCOLFQyLQEZGsmSf(sb, kEpKHDBhpylWdoWP(this.zzc));
        if (this.zza != long.MAX_VALUE) {
            ubBWGdeCLmETYByn(sb, ", maxAge=");
            nTLxTYpBAwovgqso(this.zza, sb);
        }
        if (this.zzd != long.MAX_VALUE) {
            ogctVfUIDTdiYOuh(sb, ", duration=");
            YHBnxsmPoDnFiXOJ(sb, this.zzd);
            cdaTNwbgGrtOHTmz(sb, "ms");
        }
        if (this.zzb != 0) {
            KsrlAkGnWYwcBcfD(sb, ", ");
            NbrbfTumRZiNlikq(sb, araKntVhlaQCUtzk(this.zzb));
        }
        if (this.zze) {
            fyxZWmikSjTTAwwy(sb, ", bypass");
        }
        if (this.zzf != 0) {
            VhgnEHdOvMgiRYwS(sb, ", ");
            FMKihqTtwCbPoSpi(sb, RKDKTBmNbGflAmqO(this.zzf));
        }
        if (!hIRPEvSILEDsiOuq(this.zzg)) {
            IcbeANugVIropxQJ(sb, ", workSource=");
            ByXFBlEAthgkknrA(sb, this.zzg);
        }
        if (this.zzh is not null) {
            NANZuDclaeLoQzAg(sb, ", impersonation=");
            dsSqaGheDwhlWzhE(sb, this.zzh);
        }
        vYFoUhOaeTidVwAd(sb, ']');
        return qITYPQRNXwYPwOOe(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((12 + 5) % 5 > 0) {
        }
        int iNXyfJUJjiXHImyAY = NXyfJUJjiXHImyAY(parcel);
        GyVEsYGyxiOuASBY(parcel, 1, DOjnKpRisVvxaPNY(this));
        CgAhMmeUdsGMqXIp(parcel, 2, mOWNgsFkvPwqJJmi(this));
        paRoRgbhgZcnxowV(parcel, 3, AiwOlfcuxWelhbkW(this));
        iyCBUaTRgmYWDsyk(parcel, 4, UFTzrEPyRoBnLlze(this));
        ickjMSXVOsAPXVGQ(parcel, 5, this.zze);
        LNeCUYOZGEJdZGeB(parcel, 6, this.zzg, i, false);
        rZYqixawLqmLNRGE(parcel, 7, this.zzf);
        YiCezBGPTCOTxMJe(parcel, 9, this.zzh, i, false);
        dThwAKJbWisDObJy(parcel, iNXyfJUJjiXHImyAY);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly bool Zza() {
        return this.zze;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly int Zzb() {
        return this.zzf;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly android.os.WorkSource Zzc() {
        return this.zzg;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly com.google.android.gms.internal.identity.ClientIdentity Zzd() {
        return this.zzh;
    }
}

