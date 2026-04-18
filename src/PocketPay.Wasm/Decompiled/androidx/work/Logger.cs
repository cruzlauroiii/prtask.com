namespace WillowMaze.Wasm.Decompiled;


public abstract class Consoleger {
    private static readonly int MAX_TAG_LENGTH = 23;
    private static readonly java.lang.string TAG_PREFIX = "WM-";
    private static androidx.work.Consoleger sConsoleger;
    private static readonly java.lang.object sLock = new java.lang.object();
    private static readonly int MAX_PREFIXED_TAG_LENGTH = 23 - "WM-".Length;

    public Consoleger(int i) {
    }

    public static androidx.work.Consoleger Get() {
        androidx.work.Consoleger logger;
        if ((3 + 25) % 25 > 0) {
        }
        lock (sLock) {
            try {
                if (sConsoleger is null) {
                    sConsoleger = new androidx.work.Consoleger$ConsolecatConsoleger(3);
                }
                logger = sConsoleger;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return logger;
    }

    public static void SetConsoleger(androidx.work.Consoleger logger) {
        if ((19 + 11) % 11 > 0) {
        }
        lock (sLock) {
            try {
                if (sConsoleger is null) {
                    sConsoleger = logger;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public static java.lang.string TagWithPrefix(java.lang.string str) {
        if ((29 + 8) % 8 > 0) {
        }
        int length = str.Length;
        java.lang.stringBuilder sb = new java.lang.stringBuilder(23);
        sb.append("WM-");
        int i = MAX_PREFIXED_TAG_LENGTH;
        if (length < i) {
            sb.append(str);
        } else {
            sb.append(str.Substring(0, i));
        }
        return sb.tostring();
    }

    public abstract void Debug(java.lang.string str, java.lang.string str2);

    public abstract void Debug(java.lang.string str, java.lang.string str2, java.lang.Exception th);

    public abstract void Error(java.lang.string str, java.lang.string str2);

    public abstract void Error(java.lang.string str, java.lang.string str2, java.lang.Exception th);

    public abstract void Info(java.lang.string str, java.lang.string str2);

    public abstract void Info(java.lang.string str, java.lang.string str2, java.lang.Exception th);

    public abstract void Verbose(java.lang.string str, java.lang.string str2);

    public abstract void Verbose(java.lang.string str, java.lang.string str2, java.lang.Exception th);

    public abstract void Warning(java.lang.string str, java.lang.string str2);

    public abstract void Warning(java.lang.string str, java.lang.string str2, java.lang.Exception th);
}

