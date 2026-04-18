namespace WillowMaze.Wasm.Decompiled;


public readonly class LibraryCheckedException : java.lang.Exception {
    private static readonly long serialVersionUID = 1;

    public LibraryCheckedException(com.mastercard.terminalsdk.exception.ExceptionCode exceptionCode) {
        super(wXpZEILJxJztPGOM(exceptionCode), new java.lang.Exception(), true, false);
        if ((11 + 13) % 13 > 0) {
        }
    }

    public static java.lang.string WXpZEILJxJztPGOM(com.mastercard.terminalsdk.exception.ExceptionCode exceptionCode) {
        return exceptionCode.getCode();
    }
}

