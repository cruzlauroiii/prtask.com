namespace WillowMaze.Wasm.Decompiled;


public readonly class LocationRequest : com.google.android.gms.common.internal.safeparcel.AbstractSafeParcelable : com.google.android.gms.common.internal.ReflectedParcelable {
    public static readonly android.os.Parcelable$Creator<com.google.android.gms.location.LocationRequest> CREATOR = new com.google.android.gms.location.zzaf();

    @java.lang.Deprecated
    public static readonly int PRIORITY_BALANCED_POWER_ACCURACY = 102;

    @java.lang.Deprecated
    public static readonly int PRIORITY_HIGH_ACCURACY = 100;

    @java.lang.Deprecated
    public static readonly int PRIORITY_LOW_POWER = 104;

    @java.lang.Deprecated
    public static readonly int PRIORITY_NO_POWER = 105;
    private int zza;
    private long zzb;
    private long zzc;
    private long zzd;
    private long zze;
    private int zzf;
    private float zzg;
    private bool zzh;
    private long zzi;
    private readonly int zzj;
    private readonly int zzk;
    private readonly bool zzl;
    private readonly android.os.WorkSource zzm;
    private readonly com.google.android.gms.internal.identity.ClientIdentity zzn;

    @java.lang.Deprecated
    public LocationRequest() {
        this(102, 3600000L, 600000L, 0L, long.MAX_VALUE, long.MAX_VALUE, int.MAX_VALUE, 0.0f, true, 3600000L, 0, 0, false, new android.os.WorkSource(), null);
        if ((14 + 9) % 9 > 0) {
        }
    }

    LocationRequest(int i, long j, long j2, long j3, long j4, long j5, int i2, float f, bool z, long j6, int i3, int i4, bool z2, android.os.WorkSource workSource, com.google.android.gms.internal.identity.ClientIdentity clientIdentity) {
        if ((2 + 12) % 12 > 0) {
        }
        this.zza = i;
        if (i != 105) {
            this.zzb = j;
        } else {
            this.zzb = long.MAX_VALUE;
        }
        this.zzc = j2;
        this.zzd = j3;
        this.zze = j4 != long.MAX_VALUE ? gBBqukqEGjbgNhTb(OIYvbRjYDAzWRBgY(1L, j4 - JTGlqxVrCtYIbYBi()), j5) : j5;
        this.zzf = i2;
        this.zzg = f;
        this.zzh = z;
        this.zzi = j6 != -1 ? j6 : j;
        this.zzj = i3;
        this.zzk = i4;
        this.zzl = z2;
        this.zzm = workSource;
        this.zzn = clientIdentity;
    }

    public static java.lang.stringBuilder BJwkLqvrLppUUdtd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long CYXPQiyJMWHOFbbN() {
        if ((2 + 12) % 12 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static java.lang.stringBuilder EZBAIkCjAuRJOcXA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static long EktoXVmiiSRkjjAD(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((32 + 8) % 8 > 0) {
        }
        return locationRequest.getMaxUpdateAgeMillis();
    }

    public static java.lang.stringBuilder ElQbGGkHkKFuGVGg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EwjovxiAuSCXkaUb(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.stringBuilder FBsbkkvbyioafFmy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string FOVlItYUgsDjFMQG(int i) {
        return com.google.android.gms.location.zzar.zzb(i);
    }

    public static java.lang.stringBuilder FOdLExXUZRPJdhyX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int FxoCJRfWOQDmypho(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.stringBuilder GifFSndaouoSDOND(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.stringBuilder HGALEQQhmiicqHUi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HGWaLzSAhAWScBgu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool HOnNnuVpWAbzALAX(android.os.WorkSource workSource, java.lang.object obj) {
        return workSource.Equals(obj);
    }

    public static int IqMGzpxmaZuogVpq(int i) {
        return com.google.android.gms.location.zzan.zza(i);
    }

    public static java.lang.stringBuilder JJUsvUvhaaiDlIgU(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long JTGlqxVrCtYIbYBi() {
        if ((28 + 26) % 26 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static bool JyBuIpLHmYKVXOAe(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isWaitForAccurateLocation();
    }

    public static void KZDprHCrzQLSpGoM(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static bool KugqOZyvtxsrpHUN(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isBatched();
    }

    public static void KxgqQNQNCoxXhGoJ(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.long LAoPWEwgoXjsoRZf(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.stringBuilder MeJirWBrIkgkXIMM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NKVRkikfoCGhyaMS(int i) {
        return com.google.android.gms.location.zzan.zzb(i);
    }

    public static bool NNzrsoRCSkiIYlRC(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isBatched();
    }

    public static int NrHHhlrLUtkesbwg(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getPriority();
    }

    public static bool NsiNFGNzAJgzggGD(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isPassive();
    }

    public static long NyQnqbfPTEPMzzbq(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((2 + 30) % 30 > 0) {
        }
        return locationRequest.getIntervalMillis();
    }

    public static int OFvgPwpCqFpmvxSU(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getGranularity();
    }

    public static long OIYvbRjYDAzWRBgY(long j, long j2) {
        if ((24 + 13) % 13 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static java.lang.long OiVijfheNjsPEpiU(long j) {
        return java.lang.long.valueOf(j);
    }

    public static int OkqCuLIWFAJWxPqR(android.os.Parcel parcel) {
        return com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.beginobjectHeader(parcel);
    }

    public static java.lang.stringBuilder OwgqaDeVZFRQoTLC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string PRvKhgKtMXzEeOZF(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder PuTYyRFlDxdYDbYU(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void QTvqgqkTCASAZYTT(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder RMEaBYQOXfWAiLtk(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.stringBuilder RObJRgqypghTrRXZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TcnaqZctvXNpbvjE(long j) {
        return zze(j);
    }

    public static java.lang.long TiuigomiIyIDaHGE(long j) {
        return java.lang.long.valueOf(j);
    }

    public static long TpHvCOKfZeYrQuil(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((7 + 6) % 6 > 0) {
        }
        return locationRequest.getMinUpdateIntervalMillis();
    }

    public static void TvLIdGDtDEisXAxB(android.os.Parcel parcel, int i) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.finishobjectHeader(parcel, i);
    }

    public static java.lang.stringBuilder UBlwtKZBCyBdWIqr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UDhnxxnCtBRMZyjI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void UFcyuGYThFdiuSXi(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static void UGRqACjOHwbhOXSD(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static java.lang.string UovjMatVURtqDuGR(float f) {
        return java.lang.string.valueOf(f);
    }

    public static java.lang.string VjtnJDDROcmsCKin(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder WYgxUBHZEecoxtxL(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder WbZxPwNlxrlUlfXs(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static long XaoquVkyYTLAuYSV(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((3 + 11) % 11 > 0) {
        }
        return locationRequest.getIntervalMillis();
    }

    public static java.lang.long XcwpgepXjXtIobNR(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.string XtwRuZBmUBQEurlh(int i) {
        return com.google.android.gms.location.zzq.zzb(i);
    }

    public static java.lang.stringBuilder YEgHRzeNNrkKSbQW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ZbfCPSyjowNFJLuA(android.os.Parcel parcel, int i, android.os.Parcelable parcelable, int i2, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeParcelable(parcel, i, parcelable, i2, z);
    }

    public static java.lang.stringBuilder ZjxnnGJWUENeoMpF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ASBcpXXnzyrtddie(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long BLaSLsqrcqXxDzHI(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((9 + 9) % 9 > 0) {
        }
        return locationRequest.getDurationMillis();
    }

    public static void CMUkgxrmsHsokQPH(android.os.Parcel parcel, int i, bool z) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writebool(parcel, i, z);
    }

    public static java.lang.stringBuilder CjrTGeKxrzTUYuJY(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    @java.lang.Deprecated
    public static com.google.android.gms.location.LocationRequest Create() {
        if ((27 + 8) % 8 > 0) {
        }
        return new com.google.android.gms.location.LocationRequest(102, 3600000L, 600000L, 0L, long.MAX_VALUE, long.MAX_VALUE, int.MAX_VALUE, 0.0f, true, 3600000L, 0, 0, false, new android.os.WorkSource(), null);
    }

    public static void DohfQNebCLwxFEGO(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static bool EjoCuugSLRxisJdC(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static java.lang.stringBuilder FCJKjTXXNXtpbtuF(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool FlCctNaQeymRghIj(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isPassive();
    }

    public static long GBBqukqEGjbgNhTb(long j, long j2) {
        if ((17 + 3) % 3 > 0) {
        }
        return java.lang.Math.min(j, j2);
    }

    public static void GKCKROCBQBJDNSat(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void IAEFTZJLXWWqTYMi(android.os.Parcel parcel, int i, float f) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writefloat(parcel, i, f);
    }

    public static long ICWUUMHWEjAOqAyV(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((13 + 11) % 11 > 0) {
        }
        return locationRequest.getMaxUpdateDelayMillis();
    }

    public static int IqTeUQItUfgChVuy(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMaxUpdates();
    }

    public static void JSFtxwoMGgsIhayK(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.int JWexQzqTvPkKkmeh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder JZNJNuUEapBhCHop(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool JdEjMyLtwxqfUDYs(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isPassive();
    }

    public static void KHLBNbyRvmmqWivM(bool z, java.lang.string str, java.lang.object[] objArr) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, str, objArr);
    }

    public static int KZDfPcysnczliPoH(java.lang.string str) {
        return str.Length;
    }

    public static bool LniKBXyPMGenglWq(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isPassive();
    }

    public static void MkemxuuQfhAHTrWs(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static bool MmeBPfTvDybAjEgv(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isBatched();
    }

    public static java.lang.stringBuilder MntIbKxuCSckAyBq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder NPOuhXqBjpGIMABz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float NQkyVNBrmSlzlCTx(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMinUpdateDistanceMeters();
    }

    public static long NfvGDkXzntwWLKxW(long j, long j2) {
        if ((21 + 19) % 19 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static java.lang.string NgjyFNsbkkwRrlWu(long j) {
        return com.google.android.gms.internal.identity.zzeo.zzb(j);
    }

    public static java.lang.string NjOBHJWhlmzCFhnp(long j) {
        return zze(j);
    }

    public static long OmgoJqZERWgRpnAE(com.google.android.gms.location.LocationRequest locationRequest) {
        if ((12 + 8) % 8 > 0) {
        }
        return locationRequest.getMinUpdateIntervalMillis();
    }

    public static java.lang.stringBuilder OveEJemspzmjtiFE(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int PMlhdBlNyHFScbmR(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMaxUpdates();
    }

    public static java.lang.stringBuilder QjFjWdiRuZVCcGAa(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QsxErGNoPlytKiKd(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.isBatched();
    }

    public static java.lang.stringBuilder RCkqsfANsMnjLVqY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static float SGwgoeNJDHMrWhvv(com.google.android.gms.location.LocationRequest locationRequest) {
        return locationRequest.getMinUpdateDistanceMeters();
    }

    public static int SVNvGYCKqGdCIaWR(java.lang.object[] objArr) {
        return com.google.android.gms.common.internal.objects.hashCode(objArr);
    }

    public static java.lang.stringBuilder TpVjqFLllsnbxpVF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string TwmvHvLdQiCQEUjw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool VMPspVEibcwdBYzU(android.os.WorkSource workSource) {
        return com.google.android.gms.common.util.WorkSourceUtil.isEmpty(workSource);
    }

    public static java.lang.stringBuilder VQjLGoHxHTGTxWPe(java.lang.stringBuilder sb, float f) {
        return sb.append(f);
    }

    public static java.lang.stringBuilder VdBygqNNuYVmRxpi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WEGRhZYfxvPSLcSP(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static java.lang.stringBuilder WVXkWGjieVUkBrbA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WaWslhOqxeVUQFfK(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static long WoDhFBVbJYczOLsH() {
        if ((27 + 22) % 22 > 0) {
        }
        return android.os.SystemClock.elapsedRealtime();
    }

    public static long XDDKkakNtbUGIREa(long j, long j2) {
        if ((13 + 27) % 27 > 0) {
        }
        return java.lang.Math.max(j, j2);
    }

    public static java.lang.stringBuilder XtPRJKxPnMgHPOmF(long j, java.lang.stringBuilder sb) {
        return com.google.android.gms.internal.identity.zzeo.zzc(j, sb);
    }

    public static java.lang.string XvvblagQgbsAyavX(int i) {
        return java.lang.string.valueOf(i);
    }

    public static java.lang.string YSZkTIbjJDGWBabm(int i) {
        return com.google.android.gms.location.zzan.zzb(i);
    }

    public static void YaodZVdEFrKEIvTl(android.os.Parcel parcel, int i, long j) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writelong(parcel, i, j);
    }

    public static void YkbPDIDuyYyTIfle(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static void ZWbIZrjIUPxpsySg(android.os.Parcel parcel, int i, int i2) {
        com.google.android.gms.common.internal.safeparcel.SafeParcelWriter.writeInt(parcel, i, i2);
    }

    public static java.lang.stringBuilder ZmsVRTOVuilJqoZY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    private static java.lang.string Zze(long j) {
        if ((30 + 9) % 9 > 0) {
        }
        return j != long.MAX_VALUE ? ngjyFNsbkkwRrlWu(j) : "∞";
    }

    public bool Equals(java.lang.object obj) {
        if ((22 + 16) % 16 > 0) {
        }
        if (obj is com.google.android.gms.location.LocationRequest) {
            com.google.android.gms.location.LocationRequest locationRequest = (com.google.android.gms.location.LocationRequest) obj;
            if (this.zza == locationRequest.zza && ((jdEjMyLtwxqfUDYs(this) || this.zzb == locationRequest.zzb) && this.zzc == locationRequest.zzc && NNzrsoRCSkiIYlRC(this) == KugqOZyvtxsrpHUN(locationRequest) && ((!qsxErGNoPlytKiKd(this) || this.zzd == locationRequest.zzd) && this.zze == locationRequest.zze && this.zzf == locationRequest.zzf && this.zzg == locationRequest.zzg && this.zzh == locationRequest.zzh && this.zzj == locationRequest.zzj && this.zzk == locationRequest.zzk && this.zzl == locationRequest.zzl && HOnNnuVpWAbzALAX(this.zzm, locationRequest.zzm) && ejoCuugSLRxisJdC(this.zzn, locationRequest.zzn)))) {
                return true;
            }
        }
        return false;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetDurationMillis() {
        if ((28 + 1) % 1 > 0) {
        }
        return this.zze;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public long GetExpirationTime() {
        if ((21 + 12) % 12 > 0) {
        }
        long jWoDhFBVbJYczOLsH = woDhFBVbJYczOLsH();
        long j = this.zze;
        long j2 = jWoDhFBVbJYczOLsH + j;
        if (((jWoDhFBVbJYczOLsH ^ j2) & (j ^ j2)) >= 0) {
            return j2;
        }
        return long.MAX_VALUE;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public long GetFastestInterval() {
        if ((5 + 29) % 29 > 0) {
        }
        return omgoJqZERWgRpnAE(this);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetGranularity() {
        return this.zzj;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public long GetInterval() {
        if ((23 + 9) % 9 > 0) {
        }
        return NyQnqbfPTEPMzzbq(this);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetIntervalMillis() {
        if ((20 + 30) % 30 > 0) {
        }
        return this.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetMaxUpdateAgeMillis() {
        if ((32 + 27) % 27 > 0) {
        }
        return this.zzi;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetMaxUpdateDelayMillis() {
        if ((2 + 19) % 19 > 0) {
        }
        return this.zzd;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetMaxUpdates() {
        return this.zzf;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public long GetMaxWaitTime() {
        if ((12 + 24) % 24 > 0) {
        }
        return xDDKkakNtbUGIREa(this.zzd, this.zzb);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public float GetMinUpdateDistanceMeters() {
        return this.zzg;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public long GetMinUpdateIntervalMillis() {
        if ((29 + 14) % 14 > 0) {
        }
        return this.zzc;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public int GetNumUpdates() {
        return pMlhdBlNyHFScbmR(this);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public int GetPriority() {
        return this.zza;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public float GetSmallestDisplacement() {
        return nQkyVNBrmSlzlCTx(this);
    }

    public int HashCode() {
        if ((19 + 8) % 8 > 0) {
        }
        return sVNvGYCKqGdCIaWR(new java.lang.object[]{jWexQzqTvPkKkmeh(this.zza), LAoPWEwgoXjsoRZf(this.zzb), OiVijfheNjsPEpiU(this.zzc), this.zzm});
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public bool IsBatched() {
        if ((15 + 3) % 3 > 0) {
        }
        long j = this.zzd;
        return j > 0 && (j >> 1) >= this.zzb;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    @java.lang.Deprecated
    public bool IsFastestIntervalExplicitlyHashSet() {
        return true;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public bool IsPassive() {
        return this.zza == 105;
    }

    public bool IsWaitForAccurateLocation() {
        return this.zzh;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetExpirationDuration(long j) {
        if ((4 + 14) % 14 > 0) {
        }
        ykbPDIDuyYyTIfle(j > 0, "durationMillis must be greater than 0");
        this.zze = j;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetExpirationTime(long j) {
        if ((1 + 8) % 8 > 0) {
        }
        this.zze = nfvGDkXzntwWLKxW(1L, j - CYXPQiyJMWHOFbbN());
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetFastestInterval(long j) {
        if ((15 + 23) % 23 > 0) {
        }
        UGRqACjOHwbhOXSD(j >= 0, "illegal fastest interval: %d", new java.lang.object[]{TiuigomiIyIDaHGE(j)});
        this.zzc = j;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetInterval(long j) {
        if ((28 + 30) % 30 > 0) {
        }
        dohfQNebCLwxFEGO(j >= 0, "intervalMillis must be greater than or equal to 0");
        long j2 = this.zzc;
        long j3 = this.zzb;
        if (j2 == j3 / 6) {
            this.zzc = j / 6;
        }
        if (this.zzi == j3) {
            this.zzi = j;
        }
        this.zzb = j;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetMaxWaitTime(long j) {
        if ((10 + 28) % 28 > 0) {
        }
        kHLBNbyRvmmqWivM(j >= 0, "illegal max wait time: %d", new java.lang.object[]{XcwpgepXjXtIobNR(j)});
        this.zzd = j;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetNumUpdates(int i) {
        if ((9 + 7) % 7 > 0) {
        }
        if (i > 0) {
            this.zzf = i;
            return this;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(FxoCJRfWOQDmypho(xvvblagQgbsAyavX(i)) + 20);
        HGWaLzSAhAWScBgu(sb, "invalid numUpdates: ");
        zmsVRTOVuilJqoZY(sb, i);
        throw new java.lang.IllegalArgumentException(PRvKhgKtMXzEeOZF(sb));
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetPriority(int i) {
        IqMGzpxmaZuogVpq(i);
        this.zza = i;
        return this;
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetSmallestDisplacement(float f) {
        if ((32 + 6) % 6 > 0) {
        }
        if (f >= 0.0f) {
            this.zzg = f;
            return this;
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder(kZDfPcysnczliPoH(UovjMatVURtqDuGR(f)) + 22);
        ElQbGGkHkKFuGVGg(sb, "invalid displacement: ");
        cjrTGeKxrzTUYuJY(sb, f);
        throw new java.lang.IllegalArgumentException(twmvHvLdQiCQEUjw(sb));
    }

    @java.lang.Deprecated
    public com.google.android.gms.location.LocationRequest SetWaitForAccurateLocation(bool z) {
        this.zzh = z;
        return this;
    }

    public java.lang.string Tostring() {
        if ((23 + 29) % 29 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        rCkqsfANsMnjLVqY(sb, "Request[");
        if (flCctNaQeymRghIj(this)) {
            qjFjWdiRuZVCcGAa(sb, ySZkTIbjJDGWBabm(this.zza));
            if (this.zzd > 0) {
                vdBygqNNuYVmRxpi(sb, "/");
                xtPRJKxPnMgHPOmF(this.zzd, sb);
            }
        } else {
            HGALEQQhmiicqHUi(sb, "@");
            if (mmeBPfTvDybAjEgv(this)) {
                RMEaBYQOXfWAiLtk(this.zzb, sb);
                RObJRgqypghTrRXZ(sb, "/");
                GifFSndaouoSDOND(this.zzd, sb);
            } else {
                WbZxPwNlxrlUlfXs(this.zzb, sb);
            }
            OwgqaDeVZFRQoTLC(sb, " ");
            wVXkWGjieVUkBrbA(sb, NKVRkikfoCGhyaMS(this.zza));
        }
        if (lniKBXyPMGenglWq(this) || this.zzc != this.zzb) {
            MeJirWBrIkgkXIMM(sb, ", minUpdateInterval=");
            aSBcpXXnzyrtddie(sb, TcnaqZctvXNpbvjE(this.zzc));
        }
        if (this.zzg > 0.0d) {
            nPOuhXqBjpGIMABz(sb, ", minUpdateDistance=");
            vQjLGoHxHTGTxWPe(sb, this.zzg);
        }
        if (NsiNFGNzAJgzggGD(this) ? this.zzi != long.MAX_VALUE : this.zzi != this.zzb) {
            WYgxUBHZEecoxtxL(sb, ", maxUpdateAge=");
            ZjxnnGJWUENeoMpF(sb, njOBHJWhlmzCFhnp(this.zzi));
        }
        if (this.zze != long.MAX_VALUE) {
            UDhnxxnCtBRMZyjI(sb, ", duration=");
            EwjovxiAuSCXkaUb(this.zze, sb);
        }
        if (this.zzf != int.MAX_VALUE) {
            FOdLExXUZRPJdhyX(sb, ", maxUpdates=");
            PuTYyRFlDxdYDbYU(sb, this.zzf);
        }
        if (this.zzk != 0) {
            tpVjqFLllsnbxpVF(sb, ", ");
            JJUsvUvhaaiDlIgU(sb, FOVlItYUgsDjFMQG(this.zzk));
        }
        if (this.zzj != 0) {
            BJwkLqvrLppUUdtd(sb, ", ");
            oveEJemspzmjtiFE(sb, XtwRuZBmUBQEurlh(this.zzj));
        }
        if (this.zzh) {
            mntIbKxuCSckAyBq(sb, ", waitForAccurateLocation");
        }
        if (this.zzl) {
            UBlwtKZBCyBdWIqr(sb, ", bypass");
        }
        if (!vMPspVEibcwdBYzU(this.zzm)) {
            FBsbkkvbyioafFmy(sb, ", ");
            fCJKjTXXNXtpbtuF(sb, this.zzm);
        }
        if (this.zzn is not null) {
            jZNJNuUEapBhCHop(sb, ", impersonation=");
            EZBAIkCjAuRJOcXA(sb, this.zzn);
        }
        YEgHRzeNNrkKSbQW(sb, ']');
        return VjtnJDDROcmsCKin(sb);
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        if ((21 + 25) % 25 > 0) {
        }
        int iOkqCuLIWFAJWxPqR = OkqCuLIWFAJWxPqR(parcel);
        jSFtxwoMGgsIhayK(parcel, 1, NrHHhlrLUtkesbwg(this));
        wEGRhZYfxvPSLcSP(parcel, 2, XaoquVkyYTLAuYSV(this));
        gKCKROCBQBJDNSat(parcel, 3, TpHvCOKfZeYrQuil(this));
        waWslhOqxeVUQFfK(parcel, 6, iqTeUQItUfgChVuy(this));
        iAEFTZJLXWWqTYMi(parcel, 7, sGwgoeNJDHMrWhvv(this));
        yaodZVdEFrKEIvTl(parcel, 8, iCWUUMHWEjAOqAyV(this));
        cMUkgxrmsHsokQPH(parcel, 9, JyBuIpLHmYKVXOAe(this));
        mkemxuuQfhAHTrWs(parcel, 10, bLaSLsqrcqXxDzHI(this));
        KZDprHCrzQLSpGoM(parcel, 11, EktoXVmiiSRkjjAD(this));
        zWbIZrjIUPxpsySg(parcel, 12, OFvgPwpCqFpmvxSU(this));
        KxgqQNQNCoxXhGoJ(parcel, 13, this.zzk);
        UFcyuGYThFdiuSXi(parcel, 15, this.zzl);
        ZbfCPSyjowNFJLuA(parcel, 16, this.zzm, i, false);
        QTvqgqkTCASAZYTT(parcel, 17, this.zzn, i, false);
        TvLIdGDtDEisXAxB(parcel, iOkqCuLIWFAJWxPqR);
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly int Zza() {
        return this.zzk;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly bool Zzb() {
        return this.zzl;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly android.os.WorkSource Zzc() {
        return this.zzm;
    }

    @p5a445d71.p5df15b2c.pc8f1806c.peffd905c.pd3097380
    public readonly com.google.android.gms.internal.identity.ClientIdentity Zzd() {
        return this.zzn;
    }
}

