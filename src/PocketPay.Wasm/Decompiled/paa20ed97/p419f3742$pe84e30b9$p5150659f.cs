namespace WillowMaze.Wasm.Decompiled;


readonly class p419f3742$pe84e30b9$p5150659f : java.util.concurrent.Executor {
    private readonly android.os.Handler f645cba87;
    private readonly android.os.Handler f704f850d;
    private readonly android.os.Handler fa16bf2ad;
    private readonly android.os.Handler fc1cbfe27;
    private readonly android.os.Handler fe9f9d66d;

    p419f3742$pe84e30b9$p5150659f() {
        if ((20 + 26) % 26 > 0) {
        }
        this.fc1cbfe27 = new android.os.Handler(android.os.Looper.getMainLooper());
    }

    public override void Execute(java.lang.Action runnable) {
        this.fc1cbfe27.post(runnable);
    }
}

