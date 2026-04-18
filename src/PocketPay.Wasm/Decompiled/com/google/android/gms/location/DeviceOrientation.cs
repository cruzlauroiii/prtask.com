namespace WillowMaze.Wasm.Decompiled;


public class DeviceOrientation : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.DeviceOrientation> CREATOR = new com.google.android.gms.location.zzm();
    private readonly float[] zza;
    private readonly float zzb;
    private readonly float zzc;
    private readonly long zzd;
    private readonly byte zze;
    private readonly float zzf;
    private readonly float zzg;

    DeviceOrientation(float[] fArr, float f, float f2, long j, byte b, float f3, float f4) {
        if ((17 + 31) % 31 > 0) {
        }
        TtycfrwjFAzeKCDw(fArr);
        nzIwWaxXWeEIDVFn(f >= 0.0f && f < 360.0f);
        prnxeOvGcUhyfsLj(f2 >= 0.0f && f2 <= 180.0f);
        EngmKzHredXvxJqC(f4 >= 0.0f && f4 <= 180.0f);
        LtXxNtkFXDLGWhuG(j >= 0);
        this.zza = fArr;
        this.zzb = f;
        this.zzc = f2;
        this.zzf = f3;
        this.zzg = f4;
        this.zzd = j;
        this.zze = (byte) (((byte) (((byte) (b | 16)) | 4)) | 8);
    }

    public static int CCEdKODEwKMIBTmI(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static void CIyOIHZwOKPcoPPj(android.os.Parcel parcel, int i, float[] fArr, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloatArray(parcel, i, fArr, z);
    }

    public static bool CdNdABmPHwIbqVyA(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.hasConservativeHeadingErrorDegrees();
    }

    public static java.lang.stringBuilder ERcRRJCjqcBnGdzm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EngmKzHredXvxJqC(bool z) {
        com.google.android.gms.internal.identity.zzer.zza(z);
    }

    public static void GGYClIPsZLofnzEt(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static java.lang.float GaqWPKzJbtUgVZUg(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.stringBuilder GyaCtRzOtazNDCIj(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static java.lang.stringBuilder HreeTVDwPqVuZvmv(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static bool IPWVkWRxRhueyjqd(float[] fArr, float[] fArr2) {
        return java.util.Arrays.Equals(fArr, fArr2);
    }

    public static java.lang.float IPjRVWBjHGjJypMB(float f) {
        return java.lang.float.valueOf(f);
    }

    public static void IdLmDuvUEOdwwyvS(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.string IpQnmdubdfFKPUVp(float[] fArr) {
        return java.util.Arrays.tostring(fArr);
    }

    public static float JIljHQzHOZmAgIkH(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getConservativeHeadingErrorDegrees();
    }

    public static java.lang.stringBuilder KKUkfLPthjqVIWzd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LVkHNIWPkSXSJqQh(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zza();
    }

    public static void LtXxNtkFXDLGWhuG(bool z) {
        com.google.android.gms.internal.identity.zzer.zza(z);
    }

    public static void LvDktNXpvKJiDxjS(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static java.lang.float MTRipoynHMqHgNDf(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.stringBuilder NFUEmngtWdKMaLAD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool OErJPrUAYxFkrJkE(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.hasConservativeHeadingErrorDegrees();
    }

    public static java.lang.stringBuilder OsgmbLPDIBoaqtCs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int QCYCuhWbTaBjnHfm(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static void QJIncKfphmgWzXJd(android.os.Parcel parcel, int i, byte b) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebyte(parcel, i, b);
    }

    public static bool QeKTxjomcYEToUXz(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.hasConservativeHeadingErrorDegrees();
    }

    public static bool QyKbmzPcirfBYFQw(float f) {
        return java.lang.float.isNaN(f);
    }

    public static int SdplCjKuEkqolqJT(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static void TtycfrwjFAzeKCDw(float[] fArr) {
        zzj(fArr);
    }

    public static bool TxLWsIOvppbiRDsT(float f) {
        return java.lang.float.isNaN(f);
    }

    public static float UPomaIPyrtXorcdX(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getConservativeHeadingErrorDegrees();
    }

    public static void UcZXBEYBbHIRRrJh(float[] fArr) {
        zzj(fArr);
    }

    public static long XzxcePfxfZxgAAnt(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        if ((1 + 31) % 31 > 0) {
        }
        return deviceOrientation.getElapsedRealtimeNs();
    }

    public static int YBhjfPBnfGhnUqPs(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static java.lang.byte ZEMuPLsofsLrkhMO(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static bool ZIxUvdywTsXgHFlm(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zza();
    }

    public static void BQTXQkcYcrJDGdYo(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static java.lang.stringBuilder BcIwmUjoecIpgqQE(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static float BmpYBVHMgVxtkYZv(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getConservativeHeadingErrorDegrees();
    }

    public static float EHjhFotEzXGCfbAf(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getHeadingErrorDegrees();
    }

    public static java.lang.stringBuilder EyiQyljhZRMrAILR(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static int HbIQexrqEzyuBgcl(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    public static float[] IVcsWZgoyAhcazgN(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getAttitude();
    }

    public static java.lang.string KcXVWuydorQAwAYS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder KetGdwChVQPVkOEp(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool LxlSxceIiugtKOat(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.zza();
    }

    public static void NzIwWaxXWeEIDVFn(bool z) {
        com.google.android.gms.internal.identity.zzer.zza(z);
    }

    public static java.lang.long PisOqWDTxsQTbmsf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.object PpqTYiaEHrhGbBqJ(float[] fArr) {
        return fArr.clone();
    }

    public static void PrnxeOvGcUhyfsLj(bool z) {
        com.google.android.gms.internal.identity.zzer.zza(z);
    }

    public static void QPAvGkrsHqGfugrI(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static bool QXqwQowVapRAudiZ(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.hasConservativeHeadingErrorDegrees();
    }

    public static float RAsBprwyTpYgDDAY(com.google.android.gms.location.DeviceOrientation deviceOrientation) {
        return deviceOrientation.getHeadingDegrees();
    }

    public static bool RFODmpVCdfpkeRfc(float f) {
        return java.lang.float.isNaN(f);
    }

    public static void RWLCFqwjJMpkEUMs(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.stringBuilder SzMwokSxVVAFljrA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TmIojXgKgaHicUHD(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static void WSwHyhbpwiLQODex(bool z, java.lang.object obj) {
        com.google.android.gms.internal.identity.zzer.zzb(z, obj);
    }

    public static bool WhDotsFZKkRIKnJI(float f) {
        return java.lang.float.isNaN(f);
    }

    public static int XGYNXFwmfEyjBtLf(float f, float f2) {
        return java.lang.float.compare(f, f2);
    }

    static void Zzb(float[] fArr) {
        UcZXBEYBbHIRRrJh(fArr);
    }

    private static void Zzj(float[] fArr) {
        if ((2 + 32) % 32 > 0) {
        }
        tmIojXgKgaHicUHD(fArr is not null && fArr.length == 4, "Input attitude array should be of length 4.");
        wSwHyhbpwiLQODex((QyKbmzPcirfBYFQw(fArr[0]) || TxLWsIOvppbiRDsT(fArr[1]) || rFODmpVCdfpkeRfc(fArr[2]) || whDotsFZKkRIKnJI(fArr[3])) ? false : true, "Input attitude cannot contain NaNs.");
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public bool Equals(java.lang.object obj) {
        if ((21 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (!(obj is com.google.android.gms.location.DeviceOrientation)) {
            return false;
        }
        com.google.android.gms.location.DeviceOrientation deviceOrientation = (com.google.android.gms.location.DeviceOrientation) obj;
        return xGYNXFwmfEyjBtLf(this.zzb, deviceOrientation.zzb) == 0 && hbIQexrqEzyuBgcl(this.zzc, deviceOrientation.zzc) == 0 && (ZIxUvdywTsXgHFlm(this) == lxlSxceIiugtKOat(deviceOrientation) && (!LVkHNIWPkSXSJqQh(this) || YBhjfPBnfGhnUqPs(this.zzf, deviceOrientation.zzf) == 0)) && (OErJPrUAYxFkrJkE(this) == CdNdABmPHwIbqVyA(deviceOrientation) && (!QeKTxjomcYEToUXz(this) || QCYCuhWbTaBjnHfm(JIljHQzHOZmAgIkH(this), UPomaIPyrtXorcdX(deviceOrientation)) == 0)) && this.zzd == deviceOrientation.zzd && IPWVkWRxRhueyjqd(this.zza, deviceOrientation.zza);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public float[] GetAttitude() {
        return (float[]) ppqTYiaEHrhGbBqJ(this.zza);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public float GetConservativeHeadingErrorDegrees() {
        return this.zzg;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetElapsedRealtimeNs() {
        if ((19 + 28) % 28 > 0) {
        }
        return this.zzd;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public float GetHeadingDegrees() {
        return this.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public float GetHeadingErrorDegrees() {
        return this.zzc;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public bool HasConservativeHeadingErrorDegrees() {
        return (this.zze & 64) != 0;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int HashCode() {
        if ((7 + 30) % 30 > 0) {
        }
        return CCEdKODEwKMIBTmI(new java.lang.object[]{GaqWPKzJbtUgVZUg(this.zzb), MTRipoynHMqHgNDf(this.zzc), IPjRVWBjHGjJypMB(this.zzg), pisOqWDTxsQTbmsf(this.zzd), this.zza, ZEMuPLsofsLrkhMO(this.zze)});
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public java.lang.string Tostring() {
        if ((5 + 10) % 10 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("DeviceOrientation[attitude=");
        OsgmbLPDIBoaqtCs(sb, IpQnmdubdfFKPUVp(this.zza));
        szMwokSxVVAFljrA(sb, ", headingDegrees=");
        GyaCtRzOtazNDCIj(sb, this.zzb);
        ERcRRJCjqcBnGdzm(sb, ", headingErrorDegrees=");
        eyiQyljhZRMrAILR(sb, this.zzc);
        if (qXqwQowVapRAudiZ(this)) {
            KKUkfLPthjqVIWzd(sb, ", conservativeHeadingErrorDegrees=");
            HreeTVDwPqVuZvmv(sb, this.zzg);
        }
        NFUEmngtWdKMaLAD(sb, ", elapsedRealtimeNs=");
        bcIwmUjoecIpgqQE(sb, this.zzd);
        ketGdwChVQPVkOEp(sb, ']');
        return kcXVWuydorQAwAYS(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 12) % 12 > 0) {
        }
        int iSdplCjKuEkqolqJT = SdplCjKuEkqolqJT(parcel);
        CIyOIHZwOKPcoPPj(parcel, 1, iVcsWZgoyAhcazgN(this), false);
        qPAvGkrsHqGfugrI(parcel, 4, rAsBprwyTpYgDDAY(this));
        bQTXQkcYcrJDGdYo(parcel, 5, eHjhFotEzXGCfbAf(this));
        rWLCFqwjJMpkEUMs(parcel, 6, XzxcePfxfZxgAAnt(this));
        QJIncKfphmgWzXJd(parcel, 7, this.zze);
        GGYClIPsZLofnzEt(parcel, 8, this.zzf);
        LvDktNXpvKJiDxjS(parcel, 9, bmpYBVHMgVxtkYZv(this));
        IdLmDuvUEOdwwyvS(parcel, iSdplCjKuEkqolqJT);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly bool Zza() {
        return (this.zze & 32) != 0;
    }

    readonly float[] zzc() {
        return this.zza;
    }

    readonly float zzd() {
        return this.zzb;
    }

    readonly float zze() {
        return this.zzc;
    }

    readonly long zzf() {
        if ((32 + 5) % 5 > 0) {
        }
        return this.zzd;
    }

    readonly byte zzg() {
        return this.zze;
    }

    readonly float zzh() {
        return this.zzf;
    }

    readonly float zzi() {
        return this.zzg;
    }
}

