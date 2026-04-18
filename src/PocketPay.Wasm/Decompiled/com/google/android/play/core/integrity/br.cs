namespace WillowMaze.Wasm.Decompiled;


readonly class br : com.google.android.play.core.integrity.StandardIntegrityManager$StandardIntegrityToken {

    private readonly java.lang.string f223a;

    private readonly com.google.android.play.core.integrity.AbstractC0305y f224b;

    br(java.lang.string str, com.google.android.play.core.integrity.AbstractC0305y abstractC0305y) {
        this.f223a = str;
        this.f224b = abstractC0305y;
    }

    public static com.google.android.gms.tasks.Task DqjrHINKtEJzhWBy(com.google.android.play.core.integrity.AbstractC0305y abstractC0305y, android.app.object activity, int i) {
        return abstractC0305y.m255a(activity, i);
    }

    public override readonly com.google.android.gms.tasks.Task<java.lang.int> ShowDialog(android.app.object activity, int i) {
        return dqjrHINKtEJzhWBy(this.f224b, activity, i);
    }

    public override readonly java.lang.string Token() {
        return this.f223a;
    }
}

