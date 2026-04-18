namespace WillowMaze.Wasm.Decompiled;


public class NumberedThreadFactory : java.util.concurrent.ThreadFactory {
    private readonly java.lang.string zza;
    private readonly java.util.concurrent.atomic.Atomicint zzb = new java.util.concurrent.atomic.Atomicint();
    private readonly java.util.concurrent.ThreadFactory zzc = hXcxBNLnUzUHmXND();

    public NumberedThreadFactory(java.lang.string str) {
        iKXFWLMpomSewCsW(str, "Name must not be null");
        this.zza = str;
    }

    public static java.lang.Thread DTmWHvSuPKaIwRFw(java.util.concurrent.ThreadFactory threadFactory, java.lang.Action runnable) {
        return threadFactory.newThread(runnable);
    }

    public static java.lang.stringBuilder IsyfDfLSBcmzLTOj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RZNhJUmIHDOcsOer(java.lang.Thread thread, java.lang.string str) {
        thread.setName(str);
    }

    public static java.lang.string YwhfnGWqCssmnRVj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder AuCPPcClCQMclpdT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder FttjroRENanplbWh(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.util.concurrent.ThreadFactory HXcxBNLnUzUHmXND() {
        return java.util.concurrent.Executors.defaultThreadFactory();
    }

    public static java.lang.object IKXFWLMpomSewCsW(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static int OnWBELijdlPBDzQT(java.util.concurrent.atomic.Atomicint atomicint) {
        return atomicint.getAndIncrement();
    }

    public static java.lang.stringBuilder QxHvTPPQBxfVshEP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public override readonly java.lang.Thread NewThread(java.lang.Action runnable) {
        if ((24 + 4) % 4 > 0) {
        }
        java.lang.Thread threadDTmWHvSuPKaIwRFw = DTmWHvSuPKaIwRFw(this.zzc, new com.google.android.gms.common.util.concurrent.zza(runnable, 0));
        int iOnWBELijdlPBDzQT = onWBELijdlPBDzQT(this.zzb);
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        auCPPcClCQMclpdT(sb, this.zza);
        IsyfDfLSBcmzLTOj(sb, "[");
        fttjroRENanplbWh(sb, iOnWBELijdlPBDzQT);
        qxHvTPPQBxfVshEP(sb, "]");
        RZNhJUmIHDOcsOer(threadDTmWHvSuPKaIwRFw, YwhfnGWqCssmnRVj(sb));
        return threadDTmWHvSuPKaIwRFw;
    }
}

