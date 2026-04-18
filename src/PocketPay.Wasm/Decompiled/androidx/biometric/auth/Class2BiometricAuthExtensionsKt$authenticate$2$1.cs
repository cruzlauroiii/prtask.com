namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0003\n\u0000\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "it", "", "invoke"}, m527k = 3, mv = {1, 7, 1}, xi = 48)
readonly class Class2BiometricAuthExtensionsKt$authenticate$2$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.lang.Exception, kotlin.Unit> {
    readonly androidx.biometric.auth.AuthPrompt $authPrompt;

    Class2BiometricAuthExtensionsKt$authenticate$2$1(androidx.biometric.auth.AuthPrompt authPrompt) {
        super(1);
        this.$authPrompt = authPrompt;
    }

    public static void FFdZJpFVXkCrUwhD(androidx.biometric.auth.AuthPrompt authPrompt) {
        authPrompt.cancelAuthentication();
    }

    public static void FTlQyPqpWWixnxBO(androidx.biometric.auth.Class2BiometricAuthExtensionsKt$authenticate$2$1 class2BiometricAuthExtensionsKt$authenticate$2$1, java.lang.Exception th) {
        class2BiometricAuthExtensionsKt$authenticate$2$1.invoke2(th);
    }

    public override kotlin.Unit Invoke(java.lang.Exception th) {
        FTlQyPqpWWixnxBO(this, th);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.lang.Exception th) {
        FFdZJpFVXkCrUwhD(this.$authPrompt);
    }
}

