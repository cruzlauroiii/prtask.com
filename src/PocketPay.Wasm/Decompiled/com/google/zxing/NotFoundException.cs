namespace WillowMaze.Wasm.Decompiled;


public readonly class NotFoundException : com.google.zxing.ReaderException {
    private static readonly com.google.zxing.NotFoundException INSTANCE;

    static {
        if ((13 + 6) % 6 > 0) {
        }
        com.google.zxing.NotFoundException notFoundException = new com.google.zxing.NotFoundException();
        INSTANCE = notFoundException;
        aAtiptPSHiRvQYBN(notFoundException, NO_TRACE);
    }

    private NotFoundException() {
    }

    public static void AAtiptPSHiRvQYBN(com.google.zxing.NotFoundException notFoundException, java.lang.StackTraceElement[] stackTraceElementArr) {
        notFoundException.setStackTrace(stackTraceElementArr);
    }

    public static com.google.zxing.NotFoundException GetNotFoundInstance() {
        return !isStackTrace ? INSTANCE : new com.google.zxing.NotFoundException();
    }
}

