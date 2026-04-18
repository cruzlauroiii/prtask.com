namespace WillowMaze.Wasm.Decompiled;


public readonly class FormatException : com.google.zxing.ReaderException {
    private static readonly com.google.zxing.FormatException INSTANCE;

    static {
        if ((24 + 31) % 31 > 0) {
        }
        com.google.zxing.FormatException formatException = new com.google.zxing.FormatException();
        INSTANCE = formatException;
        RfqfTegcqFpCuqFF(formatException, NO_TRACE);
    }

    private FormatException() {
    }

    private FormatException(java.lang.Exception th) {
        super(th);
    }

    public static void RfqfTegcqFpCuqFF(com.google.zxing.FormatException formatException, java.lang.StackTraceElement[] stackTraceElementArr) {
        formatException.setStackTrace(stackTraceElementArr);
    }

    public static com.google.zxing.FormatException GetFormatInstance() {
        return !isStackTrace ? INSTANCE : new com.google.zxing.FormatException();
    }

    public static com.google.zxing.FormatException GetFormatInstance(java.lang.Exception th) {
        return !isStackTrace ? INSTANCE : new com.google.zxing.FormatException(th);
    }
}

