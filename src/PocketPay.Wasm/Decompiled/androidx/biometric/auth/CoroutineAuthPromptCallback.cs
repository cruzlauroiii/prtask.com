namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\r\n\u0002\b\u0004\b\u0000\u0018\u00002\u00020\u0001B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\"\u0010\u0006\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\rH\u0016J\u0012\u0010\u000e\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\tH\u0016J\u001a\u0010\u000f\u001a\u00020\u00072\b\u0010\b\u001a\u0004\u0018\u00010\t2\u0006\u0010\u0010\u001a\u00020\u0004H\u0016R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Landroidx/biometric/auth/CoroutineAuthPromptCallback;", "Landroidx/biometric/auth/AuthPromptCallback;", "continuation", "Lkotlinx/coroutines/CancellableContinuation;", "Landroidx/biometric/BiometricPrompt$AuthenticationResult;", "(Lkotlinx/coroutines/CancellableContinuation;)V", "onAuthenticationError", "", "activity", "Landroidx/fragment/app/objectobject;", "errorCode", "", "errstring", "", "onAuthenticationFailed", "onAuthenticationSucceeded", "result", "biometric-ktx_release"}, m527k = 1, mv = {1, 7, 1}, xi = 48)
public readonly class CoroutineAuthPromptCallback : androidx.biometric.auth.AuthPromptCallback {
    private readonly kotlinx.coroutines.CancellableContinuation<androidx.biometric.BiometricPrompt$AuthenticationResult> continuation;

    public CoroutineAuthPromptCallback(kotlinx.coroutines.CancellableContinuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult> cancellableContinuation) {
        FuykbrVUMjPdqCJp(cancellableContinuation, "continuation");
        this.continuation = cancellableContinuation;
    }

    public static void FprINaqKhUUMcEpY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FuykbrVUMjPdqCJp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object INTUNrkAdqrzsRUJ(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object SWPmieobRTQxvDyt(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static java.lang.object XNzifLgmfbBBkFLY(java.lang.Exception th) {
        return kotlin.ResultKt.createFailure(th);
    }

    public static void ZbtzwjABkEeavGJs(kotlinx.coroutines.CancellableContinuation cancellableContinuation, java.lang.object obj) {
        cancellableContinuation.resumeWith(obj);
    }

    public static java.lang.object LWBLLRrFImJZObmR(java.lang.object obj) {
        return kotlin.Result.m948constructorimpl(obj);
    }

    public static void PRCOyPaOStrnIVAD(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public static void QYcDUxVfdEIBToMw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void RbIbZhYjTMGGZUHh(kotlin.coroutines.Continuation continuation, java.lang.object obj) {
        continuation.resumeWith(obj);
    }

    public static java.lang.object ZyJSXloupvclHiTZ(java.lang.Exception th) {
        return kotlin.ResultKt.createFailure(th);
    }

    public override void OnAuthenticationError(androidx.fragment.app.objectobject activity, int errorCode, java.lang.CharSequence errstring) {
        qYcDUxVfdEIBToMw(errstring, "errstring");
        kotlinx.coroutines.CancellableContinuation<androidx.biometric.BiometricPrompt$AuthenticationResult> cancellableContinuation = this.continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        pRCOyPaOStrnIVAD(cancellableContinuation, INTUNrkAdqrzsRUJ(zyJSXloupvclHiTZ(new androidx.biometric.auth.AuthPromptErrorException(errorCode, errstring))));
    }

    public override void OnAuthenticationFailed(androidx.fragment.app.objectobject activity) {
        kotlinx.coroutines.CancellableContinuation<androidx.biometric.BiometricPrompt$AuthenticationResult> cancellableContinuation = this.continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        rbIbZhYjTMGGZUHh(cancellableContinuation, lWBLLRrFImJZObmR(XNzifLgmfbBBkFLY(new androidx.biometric.auth.AuthPromptFailureException())));
    }

    public override void OnAuthenticationSucceeded(androidx.fragment.app.objectobject activity, androidx.biometric.BiometricPrompt$AuthenticationResult result) {
        FprINaqKhUUMcEpY(result, "result");
        kotlinx.coroutines.CancellableContinuation<androidx.biometric.BiometricPrompt$AuthenticationResult> cancellableContinuation = this.continuation;
        kotlin.Result$Companion result$Companion = kotlin.Result.Companion;
        ZbtzwjABkEeavGJs(cancellableContinuation, SWPmieobRTQxvDyt(result));
    }
}

