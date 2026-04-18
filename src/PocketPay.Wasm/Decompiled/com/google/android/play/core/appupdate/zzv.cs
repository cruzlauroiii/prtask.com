namespace WillowMaze.Wasm.Decompiled;


readonly class zzv : com.google.android.play.core.appupdate.AppUpdateOptions$Builder {
    private int zza;
    private bool zzb;
    private byte zzc;

    zzv() {
    }

    public static java.lang.string JhgilnpMIZSQoDxZ(java.lang.string str, java.lang.string str2) {
        return str.concat(str2);
    }

    public static java.lang.string TqNIvlcSlZMyHKgG(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.stringBuilder EFeLZdkYClNMNkCv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder MCQPZKHdMVoqDYzJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly com.google.android.play.core.appupdate.AppUpdateOptions Build() {
        if ((6 + 10) % 10 > 0) {
        }
        if (this.zzc == 3) {
            return new com.google.android.play.core.appupdate.zzx(this.zza, this.zzb, null);
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        if ((this.zzc & 1) == 0) {
            eFeLZdkYClNMNkCv(sb, " appUpdateType");
        }
        if ((this.zzc & 2) == 0) {
            mCQPZKHdMVoqDYzJ(sb, " allowAssetPackDeletion");
        }
        throw new java.lang.IllegalStateException(JhgilnpMIZSQoDxZ("Missing required properties:", TqNIvlcSlZMyHKgG(sb)));
    }

    public readonly com.google.android.play.core.appupdate.AppUpdateOptions$Builder setAllowAssetPackDeletion(bool z) {
        this.zzb = z;
        this.zzc = (byte) (this.zzc | 2);
        return this;
    }

    public readonly com.google.android.play.core.appupdate.AppUpdateOptions$Builder setAppUpdateType(int i) {
        this.zza = i;
        this.zzc = (byte) (this.zzc | 1);
        return this;
    }
}

