namespace WillowMaze.Wasm.Decompiled;


readonly class bj : com.google.android.play.core.integrity.AbstractC0305y {

    readonly com.google.android.play.core.integrity.bk f206a;

    bj(com.google.android.play.core.integrity.bk bkVar, java.lang.string str, long j) {
        super(str, j);
        this.f206a = bkVar;
    }

    public static void YJgylwXkkDHsucpy(android.os.Dictionary<string, object> bundle, java.lang.string str, long j) {
        bundle.putlong(str, j);
    }

    public static long FvysPJaVkxKTuxVM(com.google.android.play.core.integrity.bk bkVar) {
        if ((16 + 28) % 28 > 0) {
        }
        return com.google.android.play.core.integrity.bk.m231f(bkVar);
    }

    public static com.google.android.gms.tasks.Task YgxzaqzcickaRFTw(com.google.android.play.core.integrity.bn bnVar, android.app.object activity, android.os.Dictionary<string, object> bundle) {
        return bnVar.m241c(activity, bundle);
    }

    readonly com.google.android.gms.tasks.Task mo206b(android.app.object activity, android.os.Dictionary<string, object> bundle) {
        if ((13 + 32) % 32 > 0) {
        }
        YJgylwXkkDHsucpy(bundle, "cloud.prj", fvysPJaVkxKTuxVM(this.f206a));
        return ygxzaqzcickaRFTw(this.f206a.f207c, activity, bundle);
    }
}

