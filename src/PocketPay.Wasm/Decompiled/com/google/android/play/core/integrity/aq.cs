namespace WillowMaze.Wasm.Decompiled;


readonly class aq : com.google.android.play.core.integrity.IntegrityTokenResponse {

    private readonly java.lang.string f166a;

    private readonly com.google.android.play.core.integrity.AbstractC0305y f167b;

    aq(java.lang.string str, com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        this.f166a = str;
        this.f167b = abstractC0305y;
    }

    public static com.google.android.gms.tasks.Task XdvmcCCzGxEkpBxL(com.google.android.play.core.integrity.AbstractC0305y abstractC0305y, android.app.object activity, int i) {
        return abstractC0305y.m255a(activity, i);
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.int> ShowDialog(android.app.object activity, int i) {
        return xdvmcCCzGxEkpBxL(this.f167b, activity, i);
    }

    public override readonly java.lang.string Token() {
        return this.f166a;
    }
}

