namespace WillowMaze.Wasm.Decompiled;


abstract class bm : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly com.google.android.play.core.integrity.bn f212f;

    bm(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        super(taskCompletionSource);
        this.f212f = bnVar;
    }

    public static void ERupFYYEgKbjTajb(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static bool SRZMNsWSSmfwNNFp(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m240l(bnVar);
    }

    public static void YVGJKbUiPTerNdxN(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public static void CEwiwXzdmqehSZif(com.google.android.play.integrity.internal.AbstractActionC0327t abstractActionC0327t, java.lang.Exception exc) {
        super.mo204a(exc);
    }

    public override readonly void Mo204a(java.lang.Exception exc) {
        if ((11 + 12) % 12 > 0) {
        }
        if (!(exc is com.google.android.play.integrity.internal.af)) {
            cEwiwXzdmqehSZif(this, exc);
        } else if (SRZMNsWSSmfwNNFp(this.f212f)) {
            ERupFYYEgKbjTajb(this, new com.google.android.play.core.integrity.StandardIntegrityException(-2, exc));
        } else {
            YVGJKbUiPTerNdxN(this, new com.google.android.play.core.integrity.StandardIntegrityException(-9, exc));
        }
    }
}

