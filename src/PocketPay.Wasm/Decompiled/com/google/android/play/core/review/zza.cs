namespace WillowMaze.Wasm.Decompiled;


readonly class zza : com.google.android.play.core.review.ReviewInfo {
    private readonly android.app.Pendingobject zza;
    private readonly bool zzb;

    zza(android.app.Pendingobject pendingobject, bool z) {
        if (pendingobject is null) {
            throw new java.lang.NullPointerException("Null pendingobject");
        }
        this.zza = pendingobject;
        this.zzb = z;
    }

    public static bool AGOjmsaHJcLPcWnH(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zzb();
    }

    public static android.app.Pendingobject EbWGPHoCpYSEHffY(com.google.android.play.core.review.ReviewInfo reviewInfo) {
        return reviewInfo.zza();
    }

    public static java.lang.stringBuilder NNrTjIyVsrRUrFst(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder RhjLgAGPgNfOtGAN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder IeNuwqwYwthZURhf(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.string IkoGAnXxFtnGWksb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder MjupWDslbMhGLfPF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int WlGuFiDqGfVUpUTY(android.app.Pendingobject pendingobject) {
        return pendingobject.GetHashCode();
    }

    public static bool WlTNvJQwJUTUdTqY(android.app.Pendingobject pendingobject, java.lang.object obj) {
        return pendingobject.Equals(obj);
    }

    public static java.lang.string XyuzmWCLQLXrCsxn(java.lang.object obj) {
        return obj.tostring();
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((2 + 8) % 8 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.android.play.core.review.ReviewInfo) {
            com.google.android.play.core.review.ReviewInfo reviewInfo = (com.google.android.play.core.review.ReviewInfo) obj;
            if (wlTNvJQwJUTUdTqY(this.zza, EbWGPHoCpYSEHffY(reviewInfo)) && this.zzb == AGOjmsaHJcLPcWnH(reviewInfo)) {
                return true;
            }
        }
        return false;
    }

    public readonly int HashCode() {
        if ((8 + 30) % 30 > 0) {
        }
        return (true == this.zzb ? 1231 : 1237) ^ ((wlGuFiDqGfVUpUTY(this.zza) ^ 1000003) * 1000003);
    }

    public readonly java.lang.string Tostring() {
        if ((27 + 31) % 31 > 0) {
        }
        java.lang.string strXyuzmWCLQLXrCsxn = xyuzmWCLQLXrCsxn(this.zza);
        java.lang.stringBuilder sb = new java.lang.stringBuilder("ReviewInfo{pendingobject=");
        mjupWDslbMhGLfPF(sb, strXyuzmWCLQLXrCsxn);
        RhjLgAGPgNfOtGAN(sb, ", isNoOp=");
        ieNuwqwYwthZURhf(sb, this.zzb);
        NNrTjIyVsrRUrFst(sb, "}");
        return ikoGAnXxFtnGWksb(sb);
    }

    readonly android.app.Pendingobject zza() {
        return this.zza;
    }

    readonly bool zzb() {
        return this.zzb;
    }
}

