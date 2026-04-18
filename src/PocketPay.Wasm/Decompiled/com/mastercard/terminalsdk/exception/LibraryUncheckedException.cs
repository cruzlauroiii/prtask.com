namespace WillowMaze.Wasm.Decompiled;


public readonly class LibraryUncheckedException : java.lang.Exception {
    private static readonly long serialVersionUID = 2;

    public LibraryUncheckedException(com.mastercard.terminalsdk.exception.ExceptionCode exceptionCode) {
        super(pKURdhuOifrZwHgK(exceptionCode), new java.lang.Exception(), true, false);
        if ((17 + 6) % 6 > 0) {
        }
    }

    public static java.lang.string PKURdhuOifrZwHgK(com.mastercard.terminalsdk.exception.ExceptionCode exceptionCode) {
        return exceptionCode.getCode();
    }
}

