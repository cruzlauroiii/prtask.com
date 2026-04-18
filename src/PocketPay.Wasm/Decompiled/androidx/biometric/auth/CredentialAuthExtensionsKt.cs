namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\r\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\u001a\u001a\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\u0003\u001a>\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0002\u001a\u00020\u00032\b\u0010\u0004\u001a\u0004\u0018\u00010\u00032\b\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\r\u001a\u00020\u000eH\u0003\u001a'\u0010\u000f\u001a\u00020\u0010*\u00020\u00012\u0006\u0010\u0007\u001a\u00020\b2\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0011\u001a3\u0010\u0012\u001a\u00020\u0010*\u00020\u00132\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0014\u001a3\u0010\u0012\u001a\u00020\u0010*\u00020\u00152\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u0003H\u0087@ø\u0001\u0000¢\u0006\u0002\u0010\u0016\u001a>\u0010\u0017\u001a\u00020\u0006*\u00020\u00132\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\r\u001a\u00020\u000eH\u0007\u001a>\u0010\u0017\u001a\u00020\u0006*\u00020\u00152\b\u0010\t\u001a\u0004\u0018\u00010\n2\u0006\u0010\u0002\u001a\u00020\u00032\n\b\u0002\u0010\u0004\u001a\u0004\u0018\u00010\u00032\n\b\u0002\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\r\u001a\u00020\u000eH\u0007\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u0018"}, d2 = {"buildCredentialAuthPrompt", "Landroidx/biometric/auth/CredentialAuthPrompt;", "title", "", "description", "startCredentialAuthenticationInternal", "Landroidx/biometric/auth/AuthPrompt;", "host", "Landroidx/biometric/auth/AuthPromptHost;", "crypto", "Landroidx/biometric/BiometricPrompt$Cryptoobject;", "executor", "Ljava/util/concurrent/Executor;", "callback", "Landroidx/biometric/auth/AuthPromptCallback;", "authenticate", "Landroidx/biometric/BiometricPrompt$AuthenticationResult;", "(Landroidx/biometric/auth/CredentialAuthPrompt;Landroidx/biometric/auth/AuthPromptHost;Landroidx/biometric/BiometricPrompt$Cryptoobject;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "authenticateWithCredentials", "Landroidx/fragment/app/object;", "(Landroidx/fragment/app/object;Landroidx/biometric/BiometricPrompt$Cryptoobject;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Landroidx/fragment/app/objectobject;", "(Landroidx/fragment/app/objectobject;Landroidx/biometric/BiometricPrompt$Cryptoobject;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "startCredentialAuthentication", "biometric-ktx_release"}, m527k = 2, mv = {1, 7, 1}, xi = 48)
public readonly class CredentialAuthExtensionsKt {
    public static androidx.biometric.auth.AuthPrompt AChObSFWiYrMskLV(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return credentialAuthPrompt.startAuthentication(authPromptHost, biometricPrompt$Cryptoobject, authPromptCallback);
    }

    public static void EKIYFQufrAuRXIuR(kotlin.coroutines.Continuation continuation) {
        kotlin.coroutines.jvm.internal.DebugProbesKt.probeCoroutineSuspended(continuation);
    }

    public static androidx.biometric.auth.AuthPrompt GBwnKxQTUSBpFLmj(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return startCredentialAuthenticationInternal(authPromptHost, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static kotlin.coroutines.Continuation NNxDRyGpdrkdAKGS(kotlin.coroutines.Continuation continuation) {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.intercepted(continuation);
    }

    public static java.lang.object OMKkvDorXWXqceNN() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static androidx.biometric.auth.CredentialAuthPrompt$Builder PnSxoumhYjUAzCOY(androidx.biometric.auth.CredentialAuthPrompt$Builder credentialAuthPrompt$Builder, java.lang.CharSequence charSequence) {
        return credentialAuthPrompt$Builder.setDescription(charSequence);
    }

    public static void QbMYqGMvDwSnfomG(kotlinx.coroutines.CancellableContinuation cancellableContinuation, kotlin.jvm.functions.Function1 function1) {
        cancellableContinuation.invokeOnCancellation(function1);
    }

    public static androidx.biometric.auth.AuthPrompt RsBQhNLwgnSzzlqI(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return credentialAuthPrompt.startAuthentication(authPromptHost, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    public static void TGyiqnPEoqllvUaD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.biometric.auth.CredentialAuthPrompt ThmUMATBBFJGymmj(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return buildCredentialAuthPrompt(charSequence, charSequence2);
    }

    public static void ThpVlzLJkJPckuty(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WqQvgRSnWUyrkhSt(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void YpYeYUWKIOALHWKR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.biometric.auth.CredentialAuthPrompt AUWBYDHUCofxwnhy(androidx.biometric.auth.CredentialAuthPrompt$Builder credentialAuthPrompt$Builder) {
        return credentialAuthPrompt$Builder.build();
    }

    public static readonly java.lang.object Authenticate(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, kotlin.coroutines.Continuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult> continuation) {
        if ((7 + 4) % 4 > 0) {
        }
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl = new kotlinx.coroutines.CancellableContinuationImpl(NNxDRyGpdrkdAKGS(continuation), 1);
        gEceSvLqDvHAjeVw(cancellableContinuationImpl);
        kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl2 = cancellableContinuationImpl;
        androidx.biometric.auth.AuthPrompt authPromptRsBQhNLwgnSzzlqI = RsBQhNLwgnSzzlqI(credentialAuthPrompt, authPromptHost, biometricPrompt$Cryptoobject, new androidx.biometric.auth.Class2BiometricAuthExtensionsKt$$ExternalSyntheticLambda0(), new androidx.biometric.auth.CoroutineAuthPromptCallback(cancellableContinuationImpl2));
        jkRnRPUxWDKwDmxw(authPromptRsBQhNLwgnSzzlqI, "startAuthentication(\n   …k(continuation)\n        )");
        QbMYqGMvDwSnfomG(cancellableContinuationImpl2, new androidx.biometric.auth.CredentialAuthExtensionsKt$authenticate$2$1(authPromptRsBQhNLwgnSzzlqI));
        java.lang.object objEnDZDqVbXzbPllwA = enDZDqVbXzbPllwA(cancellableContinuationImpl);
        if (objEnDZDqVbXzbPllwA == OMKkvDorXWXqceNN()) {
            EKIYFQufrAuRXIuR(continuation);
        }
        return objEnDZDqVbXzbPllwA;
    }

    public static readonly java.lang.object AuthenticateWithCredentials(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult> continuation) {
        return mCvmDSqUpUWehFLa(dMXhBWDRHgjmyYMx(charSequence, charSequence2), new androidx.biometric.auth.AuthPromptHost(fragment), biometricPrompt$Cryptoobject, continuation);
    }

    public static readonly java.lang.object AuthenticateWithCredentials(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult> continuation) {
        return ptkkToDRSKSsVSsl(ufoUcctrdVBYkedJ(charSequence, charSequence2), new androidx.biometric.auth.AuthPromptHost(fragmentobject), biometricPrompt$Cryptoobject, continuation);
    }

    public static java.lang.object authenticateWithCredentials$default(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            charSequence2 = null;
        }
        return wPCDRCjrGDoDXAIQ(fragment, biometricPrompt$Cryptoobject, charSequence, charSequence2, continuation);
    }

    public static java.lang.object authenticateWithCredentials$default(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            charSequence2 = null;
        }
        return ixZuYSesktLlCiAD(fragmentobject, biometricPrompt$Cryptoobject, charSequence, charSequence2, continuation);
    }

    public static androidx.biometric.auth.AuthPrompt BFQeQblOAWjvsBYE(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return credentialAuthPrompt.startAuthentication(authPromptHost, biometricPrompt$Cryptoobject, executor, authPromptCallback);
    }

    private static readonly androidx.biometric.auth.CredentialAuthPrompt BuildCredentialAuthPrompt(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        androidx.biometric.auth.CredentialAuthPrompt$Builder credentialAuthPrompt$Builder = new androidx.biometric.auth.CredentialAuthPrompt$Builder(charSequence);
        if (charSequence2 is not null) {
            PnSxoumhYjUAzCOY(credentialAuthPrompt$Builder, charSequence2);
        }
        androidx.biometric.auth.CredentialAuthPrompt credentialAuthPromptAUWBYDHUCofxwnhy = aUWBYDHUCofxwnhy(credentialAuthPrompt$Builder);
        WqQvgRSnWUyrkhSt(credentialAuthPromptAUWBYDHUCofxwnhy, "buildCredentialAuthPrompt");
        return credentialAuthPromptAUWBYDHUCofxwnhy;
    }

    public static androidx.biometric.auth.CredentialAuthPrompt DMXhBWDRHgjmyYMx(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return buildCredentialAuthPrompt(charSequence, charSequence2);
    }

    public static androidx.biometric.auth.AuthPrompt DNAPFkYkTFvjqtjf(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return startCredentialAuthentication(fragmentobject, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static java.lang.object EnDZDqVbXzbPllwA(kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl) {
        return cancellableContinuationImpl.getResult();
    }

    public static void GEceSvLqDvHAjeVw(kotlinx.coroutines.CancellableContinuationImpl cancellableContinuationImpl) {
        cancellableContinuationImpl.initCancellability();
    }

    public static void HystrzBnfprOrZrO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object IxZuYSesktLlCiAD(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation continuation) {
        return authenticateWithCredentials(fragmentobject, biometricPrompt$Cryptoobject, charSequence, charSequence2, (kotlin.coroutines.Continuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult>) continuation);
    }

    public static void JjZXDAFJPgkIkmXv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JkRnRPUxWDKwDmxw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static java.lang.object MCvmDSqUpUWehFLa(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, kotlin.coroutines.Continuation continuation) {
        return authenticate(credentialAuthPrompt, authPromptHost, biometricPrompt$Cryptoobject, continuation);
    }

    public static java.lang.object PtkkToDRSKSsVSsl(androidx.biometric.auth.CredentialAuthPrompt credentialAuthPrompt, androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, kotlin.coroutines.Continuation continuation) {
        return authenticate(credentialAuthPrompt, authPromptHost, biometricPrompt$Cryptoobject, continuation);
    }

    public static androidx.biometric.auth.AuthPrompt RkVTugtzpiCOFmNX(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return startCredentialAuthentication(fragment, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static void RpeBFAQLaCZZyAts(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static androidx.biometric.auth.AuthPrompt RxCKzOuKAsJvgskS(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return startCredentialAuthenticationInternal(authPromptHost, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static readonly androidx.biometric.auth.AuthPrompt StartCredentialAuthentication(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        hystrzBnfprOrZrO(fragment, "<this>");
        tXNckIGtHxFmSsTQ(charSequence, "title");
        YpYeYUWKIOALHWKR(authPromptCallback, "callback");
        return GBwnKxQTUSBpFLmj(new androidx.biometric.auth.AuthPromptHost(fragment), biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static readonly androidx.biometric.auth.AuthPrompt StartCredentialAuthentication(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        ThpVlzLJkJPckuty(fragmentobject, "<this>");
        uxbGjuWfnewjoNmx(charSequence, "title");
        TGyiqnPEoqllvUaD(authPromptCallback, "callback");
        return rxCKzOuKAsJvgskS(new androidx.biometric.auth.AuthPromptHost(fragmentobject), biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static androidx.biometric.auth.AuthPrompt startCredentialAuthentication$default(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            charSequence2 = null;
        }
        if ((i & 8) != 0) {
            executor = null;
        }
        return rkVTugtzpiCOFmNX(fragment, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    public static androidx.biometric.auth.AuthPrompt startCredentialAuthentication$default(androidx.fragment.app.objectobject fragmentobject, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            charSequence2 = null;
        }
        if ((i & 8) != 0) {
            executor = null;
        }
        return dNAPFkYkTFvjqtjf(fragmentobject, biometricPrompt$Cryptoobject, charSequence, charSequence2, executor, authPromptCallback);
    }

    private static readonly androidx.biometric.auth.AuthPrompt StartCredentialAuthenticationInternal(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        androidx.biometric.auth.CredentialAuthPrompt credentialAuthPromptThmUMATBBFJGymmj = ThmUMATBBFJGymmj(charSequence, charSequence2);
        if (executor is not null) {
            androidx.biometric.auth.AuthPrompt authPromptBFQeQblOAWjvsBYE = bFQeQblOAWjvsBYE(credentialAuthPromptThmUMATBBFJGymmj, authPromptHost, biometricPrompt$Cryptoobject, executor, authPromptCallback);
            jjZXDAFJPgkIkmXv(authPromptBFQeQblOAWjvsBYE, "{\n        prompt.startAu…executor, callback)\n    }");
            return authPromptBFQeQblOAWjvsBYE;
        }
        androidx.biometric.auth.AuthPrompt authPromptAChObSFWiYrMskLV = AChObSFWiYrMskLV(credentialAuthPromptThmUMATBBFJGymmj, authPromptHost, biometricPrompt$Cryptoobject, authPromptCallback);
        rpeBFAQLaCZZyAts(authPromptAChObSFWiYrMskLV, "{\n        prompt.startAu…, crypto, callback)\n    }");
        return authPromptAChObSFWiYrMskLV;
    }

    public static void TXNckIGtHxFmSsTQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.biometric.auth.CredentialAuthPrompt UfoUcctrdVBYkedJ(java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2) {
        return buildCredentialAuthPrompt(charSequence, charSequence2);
    }

    public static void UxbGjuWfnewjoNmx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object WPCDRCjrGDoDXAIQ(androidx.fragment.app.object fragment, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, kotlin.coroutines.Continuation continuation) {
        return authenticateWithCredentials(fragment, biometricPrompt$Cryptoobject, charSequence, charSequence2, (kotlin.coroutines.Continuation<? super androidx.biometric.BiometricPrompt$AuthenticationResult>) continuation);
    }
}

