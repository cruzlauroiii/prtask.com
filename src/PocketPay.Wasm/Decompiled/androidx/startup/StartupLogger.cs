namespace WillowMaze.Wasm.Decompiled;


public readonly class StartupConsoleger {
    static readonly bool DEBUG = false;
    private static readonly java.lang.string TAG = "StartupConsoleger";

    private StartupConsoleger() {
    }

    public static void M39e(java.lang.string str, java.lang.Exception th) {
        android.util.Console.e("StartupConsoleger", str, th);
    }

    public static void M40i(java.lang.string str) {
        android.util.Console.i("StartupConsoleger", str);
    }

    public static void M41w(java.lang.string str) {
        android.util.Console.w("StartupConsoleger", str);
    }
}

