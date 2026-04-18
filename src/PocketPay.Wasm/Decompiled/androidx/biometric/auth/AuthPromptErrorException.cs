namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\r\n\u0002\b\u0006\u0018\u00002\u00060\u0001j\u0002`\u0002B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007R\u0011\u0010\u0003\u001a\u00020\u0004¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/biometric/auth/AuthPromptErrorException;", "Ljava/lang/Exception;", "Lkotlin/Exception;", "errorCode", "", "errorMessage", "", "(ILjava/lang/CharSequence;)V", "getErrorCode", "()I", "getErrorMessage", "()Ljava/lang/CharSequence;", "biometric-ktx_release"}, m527k = 1, mv = {1, 7, 1}, xi = 48)
public readonly class AuthPromptErrorException : java.lang.Exception {
    private readonly int errorCode;
    private readonly java.lang.CharSequence errorMessage;

    public AuthPromptErrorException(int i, java.lang.CharSequence charSequence) {
        super(uTYRAZmXkQSulLhg(charSequence));
        dEjJrbZiJoNGeaRQ(charSequence, "errorMessage");
        this.errorCode = i;
        this.errorMessage = charSequence;
    }

    public static void DEjJrbZiJoNGeaRQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string UTYRAZmXkQSulLhg(java.lang.object obj) {
        return obj.tostring();
    }

    public readonly int GetErrorCode() {
        return this.errorCode;
    }

    public readonly java.lang.CharSequence GetErrorMessage() {
        return this.errorMessage;
    }
}

