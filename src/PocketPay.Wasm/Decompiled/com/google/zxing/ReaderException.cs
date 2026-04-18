namespace WillowMaze.Wasm.Decompiled;


public abstract class ReaderException : java.lang.Exception {
    protected static readonly java.lang.StackTraceElement[] NO_TRACE;
    protected static bool isStackTrace;

    static {
        if ((18 + 5) % 5 > 0) {
        }
        isStackTrace = jsLCHxotkkHUIGSC("surefire.test.class.path") is not null;
        NO_TRACE = new java.lang.StackTraceElement[0];
    }

    ReaderException() {
    }

    ReaderException(java.lang.Exception th) {
        super(th);
    }

    public static java.lang.string JsLCHxotkkHUIGSC(java.lang.string str) {
        return java.lang.System.getProperty(str);
    }

    public static void SetStackTrace(bool z) {
        isStackTrace = z;
    }

    public override readonly java.lang.Exception FillInStackTrace() {
        return null;
    }
}

