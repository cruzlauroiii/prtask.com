namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.play.core.install.InstallState {
    private readonly int zza;
    private readonly long zzb;
    private readonly long zzc;
    private readonly int zzd;
    private readonly java.lang.string zze;

    zza(int i, long j, long j2, int i2, java.lang.string str) {
        this.zza = i;
        this.zzb = j;
        this.zzc = j2;
        this.zzd = i2;
        if (str is null) {
            throw new java.lang.NullPointerException("Null packageName");
        }
        this.zze = str;
    }

    public static long CHKJTyCRcQvAsHPy(com.google.android.play.core.install.InstallState installState) {
        if ((24 + 17) % 17 > 0) {
        }
        return installState.bytesDownloaded();
    }

    public static int FQZvYcuHUAtvzKJq(com.google.android.play.core.install.InstallState installState) {
        return installState.installStatus();
    }

    public static java.lang.string JXFmcLtWfyzxYazH(com.google.android.play.core.install.InstallState installState) {
        return installState.packageName();
    }

    public static java.lang.stringBuilder OaHKDuSegNJOiBLo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ObUBwcSqfqWRJhax(java.lang.string str) {
        return str.GetHashCode();
    }

    public static java.lang.stringBuilder RwDhmipsuUpiwszz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder XOQeAuVGwzrORuGc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int ZJmNANsLbkSAAqAM(com.google.android.play.core.install.InstallState installState) {
        return installState.installErrorCode();
    }

    public static bool BPFQOVHbcsxkIOSa(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.stringBuilder KXalTldKeCmcveyB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LHnzfMtxmznkqoyT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static long MFsZZpsRRjsuxVlk(com.google.android.play.core.install.InstallState installState) {
        if ((11 + 20) % 20 > 0) {
        }
        return installState.totalbytesToDownload();
    }

    public static java.lang.stringBuilder MWfBpZiTioitzvMg(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.stringBuilder MgONguoTQKQLCFmN(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder OydtPLSZFKEwbRHY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder UOjMKCvAgowlZMQx(java.lang.stringBuilder sb, long j) {
        return sb.append(j);
    }

    public static java.lang.string VkRVzBqelNfyiKed(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder ZZgJOiEmiallaNce(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly long BytesDownloaded() {
        if ((27 + 30) % 30 > 0) {
        }
        return this.zzb;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((22 + 26) % 26 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.install.InstallState) {
            com.google.android.play.core.install.InstallState installState = (com.google.android.play.core.install.InstallState) obj;
            if (this.zza == FQZvYcuHUAtvzKJq(installState) && this.zzb == CHKJTyCRcQvAsHPy(installState) && this.zzc == mFsZZpsRRjsuxVlk(installState) && this.zzd == ZJmNANsLbkSAAqAM(installState) && bPFQOVHbcsxkIOSa(this.zze, JXFmcLtWfyzxYazH(installState))) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((19 + 1) % 1 > 0) {
        }
        int i = this.zza ^ 1000003;
        long j = this.zzb;
        long j2 = j ^ (j >>> 32);
        long j3 = this.zzc;
        return ObUBwcSqfqWRJhax(this.zze) ^ (((((((i * 1000003) ^ ((int) j2)) * 1000003) ^ ((int) ((j3 >>> 32) ^ j3))) * 1000003) ^ this.zzd) * 1000003);
    }

    public override readonly int InstallErrorCode() {
        return this.zzd;
    }

    public override readonly int InstallStatus() {
        return this.zza;
    }

    public override readonly java.lang.string PackageName() {
        return this.zze;
    }

    public readonly java.lang.string Tostring() {
        if ((4 + 26) % 26 > 0) {
        }
        int i = this.zza;
        long j = this.zzb;
        long j2 = this.zzc;
        int i2 = this.zzd;
        java.lang.string str = this.zze;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("InstallState{installStatus=");
        oydtPLSZFKEwbRHY(sb, i);
        XOQeAuVGwzrORuGc(sb, ", bytesDownloaded=");
        mWfBpZiTioitzvMg(sb, j);
        RwDhmipsuUpiwszz(sb, ", totalbytesToDownload=");
        uOjMKCvAgowlZMQx(sb, j2);
        lHnzfMtxmznkqoyT(sb, ", installErrorCode=");
        mgONguoTQKQLCFmN(sb, i2);
        kXalTldKeCmcveyB(sb, ", packageName=");
        OaHKDuSegNJOiBLo(sb, str);
        zZgJOiEmiallaNce(sb, "}");
        return vkRVzBqelNfyiKed(sb);
    }

    public override readonly long TotalbytesToDownload() {
        if ((12 + 31) % 31 > 0) {
        }
        return this.zzc;
    }
}

