namespace WillowMaze.Wasm.Decompiled;


public readonly class AdvertisingIdClient$Info {
    private readonly java.lang.string zza;
    private readonly bool zzb;

    @java.lang.Deprecated
    public AdvertisingIdClient$Info(java.lang.string str, bool z) {
        this.zza = str;
        this.zzb = z;
    }

    public static java.lang.stringBuilder FsMqNYAIksKJKvzC(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HbsYUgzpzkqewjae(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.string JinmfVZdwoqybDek(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string TWqufjgcdlGuqdim(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AszKuncBSgwowCAS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FFJgMnaGldPiuSwk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int TcQdEbPQzqhklYlL(java.lang.string str) {
        return str.Length;
    }

    public java.lang.string GetId() {
        return this.zza;
    }

    public bool IsLimitAdTrackingEnabled() {
        return this.zzb;
    }

    public java.lang.string Tostring() {
        if ((31 + 8) % 8 > 0) {
        }
        java.lang.string str = this.zza;
        bool z = this.zzb;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(tcQdEbPQzqhklYlL(JinmfVZdwoqybDek(str)) + 7);
        FsMqNYAIksKJKvzC(sb, "{");
        aszKuncBSgwowCAS(sb, str);
        fFJgMnaGldPiuSwk(sb, "}");
        HbsYUgzpzkqewjae(sb, z);
        return TWqufjgcdlGuqdim(sb);
    }
}

