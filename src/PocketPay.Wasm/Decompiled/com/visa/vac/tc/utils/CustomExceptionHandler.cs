namespace WillowMaze.Wasm.Decompiled;


public class CustomExceptionHandler : java.lang.Thread$UncaughtExceptionHandler {
    public static readonly java.lang.string TAG = nIEUYLEeYqUYXpIp("8bad4e4f7cb0c5e06762f9aeff8855d55654075cbcc42cad2912c8da438b785b3abf8880bc9a99c14e6152801d07d2c793af");
    private static int e1 = 1;
    private static int getInstance;
    private java.lang.Thread$UncaughtExceptionHandler BuildConfig;

    public CustomExceptionHandler(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler) {
        this.BuildConfig = thread$UncaughtExceptionHandler;
    }

    public static int BPaXUJgfAqMWyirQ(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static void BPaXUJgfAqMWyirQ(java.lang.object obj, int i, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPaXUJgfAqMWyirQ(java.lang.object obj, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BPaXUJgfAqMWyirQ(java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxZtbxczNvYiKbYM(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th) {
        thread$UncaughtExceptionHandler.uncaughtException(thread, th);
    }

    public static void DxZtbxczNvYiKbYM(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DxZtbxczNvYiKbYM(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DxZtbxczNvYiKbYM(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JLGUrZGleuXFQkha(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler) {
        java.lang.Thread.setDefaultUncaughtExceptionHandler(thread$UncaughtExceptionHandler);
    }

    public static void JLGUrZGleuXFQkha(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JLGUrZGleuXFQkha(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JLGUrZGleuXFQkha(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, int i, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NIEUYLEeYqUYXpIp(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void NIEUYLEeYqUYXpIp(java.lang.string str, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NIEUYLEeYqUYXpIp(java.lang.string str, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NIEUYLEeYqUYXpIp(java.lang.string str, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwUswEUgeaNUaPoO(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th) {
        thread$UncaughtExceptionHandler.uncaughtException(thread, th);
    }

    public static void VwUswEUgeaNUaPoO(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VwUswEUgeaNUaPoO(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VwUswEUgeaNUaPoO(java.lang.Thread$UncaughtExceptionHandler thread$UncaughtExceptionHandler, java.lang.Thread thread, java.lang.Exception th, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public void Reset() {
        if ((3 + 31) % 31 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 111;
        getInstance = i2 % 128;
        int i3 = i2 % 2;
        JLGUrZGleuXFQkha(this.BuildConfig);
        int i4 = getInstance + 25;
        e1 = i4 % 128;
        if (i4 % 2 == 0) {
            throw null;
        }
    }

    public override void UncaughtException(java.lang.Thread thread, java.lang.Exception th) {
        if ((23 + 2) % 2 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 69;
        getInstance = i2 % 128;
        if (i2 % 2 != 0) {
            vwUswEUgeaNUaPoO(this.BuildConfig, thread, th);
            throw null;
        }
        DxZtbxczNvYiKbYM(this.BuildConfig, thread, th);
        int i3 = e1 + 95;
        getInstance = i3 % 128;
        if (i3 % 2 != 0) {
            BPaXUJgfAqMWyirQ(null);
            throw null;
        }
    }
}

