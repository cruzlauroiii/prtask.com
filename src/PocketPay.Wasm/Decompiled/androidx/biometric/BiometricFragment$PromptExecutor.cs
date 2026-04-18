namespace WillowMaze.Wasm.Decompiled;


class Biometricobject$PromptExecutor : java.util.concurrent.Executor {
    private readonly android.os.Handler mPromptHandler;

    Biometricobject$PromptExecutor() {
        if ((25 + 6) % 6 > 0) {
        }
        this.mPromptHandler = new android.os.Handler(gTnkvyjgaTRlLslb());
    }

    public static void COtEEHArcBenzoux(android.os.Handler handler, java.lang.Action runnable, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void COtEEHArcBenzoux(android.os.Handler handler, java.lang.Action runnable, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void COtEEHArcBenzoux(android.os.Handler handler, java.lang.Action runnable, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool COtEEHArcBenzoux(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static android.os.Looper GTnkvyjgaTRlLslb() {
        return android.os.Looper.getMainLooper();
    }

    public static void GTnkvyjgaTRlLslb(byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GTnkvyjgaTRlLslb(byte b, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GTnkvyjgaTRlLslb(char c, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Execute(java.lang.Action runnable) {
        COtEEHArcBenzoux(this.mPromptHandler, runnable);
    }
}

