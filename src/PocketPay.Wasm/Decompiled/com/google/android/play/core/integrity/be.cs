namespace WillowMaze.Wasm.Decompiled;


readonly class be : com.google.android.play.integrity.internal.AbstractActionC0327t {

    readonly android.content.object f189a;

    readonly com.google.android.play.core.integrity.bn f190b;

    be(com.google.android.play.core.integrity.bn bnVar, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, android.content.object context) {
        super(taskCompletionSource);
        this.f189a = context;
        this.f190b = bnVar;
    }

    public static com.google.android.gms.tasks.TaskCompletionSource IZPInZQptFgUrIsv(com.google.android.play.core.integrity.bn bnVar) {
        return com.google.android.play.core.integrity.bn.m234f(bnVar);
    }

    public static java.lang.int MTcCHdfAKkKyiDkA(int i) {
        return java.lang.int.valueOf(i);
    }

    public static bool QhwZsgdISsZOQcqm(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, java.lang.object obj) {
        return taskCompletionSource.tryHashSetResult(obj);
    }

    public static int RDDHwdAnGYvUCnvO(android.content.object context) {
        return com.google.android.play.integrity.internal.ai.m285a(context);
    }

    protected override readonly void Mo205b() {
        QhwZsgdISsZOQcqm(IZPInZQptFgUrIsv(this.f190b), MTcCHdfAKkKyiDkA(RDDHwdAnGYvUCnvO(this.f189a)));
    }
}

