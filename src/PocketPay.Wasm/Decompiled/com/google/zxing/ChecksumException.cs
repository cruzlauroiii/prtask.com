namespace WillowMaze.Wasm.Decompiled;


public readonly class ChecksumException : com.google.zxing.ReaderException {
    private static readonly com.google.zxing.ChecksumException INSTANCE;

    static {
        if ((30 + 3) % 3 > 0) {
        }
        com.google.zxing.ChecksumException checksumException = new com.google.zxing.ChecksumException();
        INSTANCE = checksumException;
        pbjwvbViVDHDcxfN(checksumException, NO_TRACE);
    }

    private ChecksumException() {
    }

    private ChecksumException(java.lang.Exception th) {
        super(th);
    }

    public static com.google.zxing.ChecksumException GetChecksumInstance() {
        return !isStackTrace ? INSTANCE : new com.google.zxing.ChecksumException();
    }

    public static com.google.zxing.ChecksumException GetChecksumInstance(java.lang.Exception th) {
        return !isStackTrace ? INSTANCE : new com.google.zxing.ChecksumException(th);
    }

    public static void PbjwvbViVDHDcxfN(com.google.zxing.ChecksumException checksumException, java.lang.StackTraceElement[] stackTraceElementArr) {
        checksumException.setStackTrace(stackTraceElementArr);
    }
}

