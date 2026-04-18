namespace WillowMaze.Wasm.Decompiled;


readonly class p28540cdc$p1af3c638 : java.lang.Action, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly android.os.Handler f158ddfd0;
    private readonly android.os.Handler f17cb2ac7;
    private readonly android.os.Handler f398e2a81;
    private bool f56f69fec;
    private bool f7a4a298f;
    private readonly java.lang.Action f7bc9f243;
    private readonly java.lang.Action f7f662005;
    private readonly java.lang.Action facdea0d5;
    private readonly android.os.Handler fc1cbfe27;
    private readonly android.os.Handler ff4b16fb0;
    private bool ff8b2648d;

    p28540cdc$p1af3c638(android.os.Handler handler, java.lang.Action runnable) {
        this.fc1cbfe27 = handler;
        this.f7f662005 = runnable;
    }

    public static void NLBoGnbmVzrctGdM(android.os.Handler handler, java.lang.Action runnable) {
        handler.removeCallbacks(runnable);
    }

    public static void NLBoGnbmVzrctGdM(android.os.Handler handler, java.lang.Action runnable, java.lang.string str, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NLBoGnbmVzrctGdM(android.os.Handler handler, java.lang.Action runnable, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NLBoGnbmVzrctGdM(android.os.Handler handler, java.lang.Action runnable, bool z, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NlmvQibgtFJtUmWd(java.lang.Action runnable) {
        runnable.run();
    }

    public static void NlmvQibgtFJtUmWd(java.lang.Action runnable, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NlmvQibgtFJtUmWd(java.lang.Action runnable, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NlmvQibgtFJtUmWd(java.lang.Action runnable, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YcQeNgAXKWRPEZLP(java.lang.Exception th) {
        pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mdcce2ff2(th);
    }

    public static void YcQeNgAXKWRPEZLP(java.lang.Exception th, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YcQeNgAXKWRPEZLP(java.lang.Exception th, java.lang.string str, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YcQeNgAXKWRPEZLP(java.lang.Exception th, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override void Dispose() {
        NLBoGnbmVzrctGdM(this.fc1cbfe27, this);
        this.ff8b2648d = true;
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }

    public override void Run() {
        try {
            nlmvQibgtFJtUmWd(this.f7f662005);
        } catch (java.lang.Exception th) {
            ycQeNgAXKWRPEZLP(th);
        }
    }
}

