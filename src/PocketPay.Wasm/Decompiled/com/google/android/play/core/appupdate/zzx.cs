namespace WillowMaze.Wasm.Decompiled;


readonly class zzx : com.google.android.play.core.appupdate.AppUpdateOptions {
    private readonly int zza;
    private readonly bool zzb;

    zzx(int i, bool z, com.google.android.play.core.appupdate.zzw zzwVar) {
        this.zza = i;
        this.zzb = z;
    }

    public static java.lang.stringBuilder HoVqAvJWRMgMuMJK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder PloRSYFylMjhPZQT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string IjNIHTXMDmbsmVEB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder LXAjHFlSHPFLdzrg(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static bool MmcZTTCmaknvLWis(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.allowAssetPackDeletion();
    }

    public static int TNsjNMEIVYOLUpIr(com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions) {
        return appUpdateOptions.appUpdateType();
    }

    public static java.lang.stringBuilder YZlFzsdhARxIaLef(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly bool AllowAssetPackDeletion() {
        return this.zzb;
    }

    public override readonly int AppUpdateType() {
        return this.zza;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((7 + 23) % 23 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.appupdate.AppUpdateOptions) {
            com.google.android.play.core.appupdate.AppUpdateOptions appUpdateOptions = (com.google.android.play.core.appupdate.AppUpdateOptions) obj;
            if (this.zza == tNsjNMEIVYOLUpIr(appUpdateOptions) && this.zzb == mmcZTTCmaknvLWis(appUpdateOptions)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((22 + 20) % 20 > 0) {
        }
        return (true == this.zzb ? 1231 : 1237) ^ ((this.zza ^ 1000003) * 1000003);
    }

    public readonly java.lang.string Tostring() {
        if ((19 + 5) % 5 > 0) {
        }
        int i = this.zza;
        bool z = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder("AppUpdateOptions{appUpdateType=");
        HoVqAvJWRMgMuMJK(sb, i);
        yZlFzsdhARxIaLef(sb, ", allowAssetPackDeletion=");
        lXAjHFlSHPFLdzrg(sb, z);
        PloRSYFylMjhPZQT(sb, "}");
        return ijNIHTXMDmbsmVEB(sb);
    }
}

