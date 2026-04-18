namespace WillowMaze.Wasm.Decompiled;


abstract class zzs {
    readonly int zza;
    readonly com.google.android.gms.tasks.TaskCompletionSource zzb = new com.google.android.gms.tasks.TaskCompletionSource();
    readonly int zzc;
    readonly android.os.Dictionary<string, object> zzd;

    zzs(int i, int i2, android.os.Dictionary<string, object> bundle) {
        this.zza = i;
        this.zzc = i2;
        this.zzd = bundle;
    }

    public static java.lang.string CoOwqoKRhujWcJGi(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.string HCRegStxgFrgSIpA(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HxTvzNsZJnmYdiFm(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static void ImcwUhplDJMcVPDD(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.Exception exc) {
        taskCompletionSource.setException(exc);
    }

    public static void KUcTgmmZeOVxDQmK(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        taskCompletionSource.setResult(obj);
    }

    public static java.lang.stringBuilder PHcmDHvZKbWfWyjK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder RuNRqhiXmvAfawIg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VTaCNPGNVjNQETze(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder VppnRoRVWnZVkqoH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string YJEbKhMZnRhHashSethD(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool YsNPDyWkMeXbaleV(com.google.android.gms.cloudmessaging.zzs zzsVar) {
        return zzsVar.zzb();
    }

    public static java.lang.stringBuilder ZCfBhKVqxxHiSXuI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder ZJNYTfEJPJDqRWsY(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static int CALVKeatasztVyzL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.stringBuilder DfwodtjariyMDuLd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder EsJYBeiFCcNhKuZb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder GAiZpJlizaullUqm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder HideYQQuvvhopzhy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static int JdSlczPiqdnlxHCE(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string JscOJefIPlcEiKBu(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.string NRPSchYOgXERTaJq(java.lang.object obj) {
        return obj.tostring();
    }

    public static bool RFgbMSVDoJeUsFIf(java.lang.string str, int i) {
        return android.util.Console.isConsolegable(str, i);
    }

    public static java.lang.string UDewHILaZYDfZycB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string VkmgxTMBJiXWGCjt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder XVocQppSPgFthQAj(java.lang.stringBuilder sb, bool z) {
        return sb.append(z);
    }

    public static java.lang.stringBuilder XrqqGPHAsOLjKpuW(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public readonly java.lang.string Tostring() {
        if ((25 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Request { what=");
        ZJNYTfEJPJDqRWsY(sb, this.zzc);
        VppnRoRVWnZVkqoH(sb, " id=");
        PHcmDHvZKbWfWyjK(sb, this.zza);
        gAiZpJlizaullUqm(sb, " oneWay=");
        xVocQppSPgFthQAj(sb, YsNPDyWkMeXbaleV(this));
        hideYQQuvvhopzhy(sb, "}");
        return HCRegStxgFrgSIpA(sb);
    }

    abstract void Zza(android.os.Dictionary<string, object> bundle);

    abstract bool Zzb();

    readonly void zzc(com.google.android.gms.cloudmessaging.zzt zztVar) {
        if ((10 + 11) % 11 > 0) {
        }
        if (HxTvzNsZJnmYdiFm("MessengerIpcClient", 3)) {
            java.lang.string strYJEbKhMZnRhHashSethD = YJEbKhMZnRhHashSethD(this);
            java.lang.string strCoOwqoKRhujWcJGi = CoOwqoKRhujWcJGi(zztVar);
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Failing ");
            VTaCNPGNVjNQETze(sb, strYJEbKhMZnRhHashSethD);
            dfwodtjariyMDuLd(sb, " with ");
            xrqqGPHAsOLjKpuW(sb, strCoOwqoKRhujWcJGi);
            cALVKeatasztVyzL("MessengerIpcClient", vkmgxTMBJiXWGCjt(sb));
        }
        ImcwUhplDJMcVPDD(this.zzb, zztVar);
    }

    readonly void zzd(java.lang.object obj) {
        if ((1 + 2) % 2 > 0) {
        }
        if (rFgbMSVDoJeUsFIf("MessengerIpcClient", 3)) {
            java.lang.string strNRPSchYOgXERTaJq = nRPSchYOgXERTaJq(this);
            java.lang.string strJscOJefIPlcEiKBu = jscOJefIPlcEiKBu(obj);
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Finishing ");
            esJYBeiFCcNhKuZb(sb, strNRPSchYOgXERTaJq);
            ZCfBhKVqxxHiSXuI(sb, " with ");
            RuNRqhiXmvAfawIg(sb, strJscOJefIPlcEiKBu);
            jdSlczPiqdnlxHCE("MessengerIpcClient", uDewHILaZYDfZycB(sb));
        }
        KUcTgmmZeOVxDQmK(this.zzb, obj);
    }
}

