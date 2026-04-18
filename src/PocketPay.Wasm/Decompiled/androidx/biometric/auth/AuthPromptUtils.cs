namespace WillowMaze.Wasm.Decompiled;


class AuthPromptUtils {
    private AuthPromptUtils() {
    }

    public static androidx.lifecycle.objectModel CVxTPYitMAaLVNcQ(androidx.lifecycle.objectModelProvider viewModelProvider, java.lang.Class cls) {
        return viewModelProvider[cls);
    }

    public static androidx.fragment.app.objectobject KDdWJUwSTbzWbcuD(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static void KEvqFlgwDUvkcNVq(androidx.biometric.BiometricPrompt biometricPrompt, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        biometricPrompt.authenticate(biometricPrompt$PromptInfo);
    }

    public static androidx.fragment.app.objectobject MxGpBRfywjPXMbnn(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    public static androidx.fragment.app.object UfMbpfZeDePqguCZ(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    public static androidx.fragment.app.object VcEfLSqQaCrAMKpC(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    private static androidx.biometric.BiometricPrompt CreateBiometricPrompt(androidx.biometric.auth.AuthPromptHost authPromptHost, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        if ((2 + 23) % 23 > 0) {
        }
        if (executor is null) {
            executor = new androidx.biometric.auth.AuthPromptUtils$DefaultExecutor();
        }
        if (wYwSRLCmVFSamKaI(authPromptHost) is not null) {
            return new androidx.biometric.BiometricPrompt(MxGpBRfywjPXMbnn(authPromptHost), executor, xglrhtmDkNJlmGPU(authPromptCallback, new androidx.lifecycle.objectModelProvider(mobhvybyzMXCsWaY(authPromptHost))));
        }
        if (VcEfLSqQaCrAMKpC(authPromptHost) is null || mSSnPfMWWNKWFxiC(hegDRMfmBluHmHRW(authPromptHost)) is null) {
            throw new java.lang.IllegalArgumentException("AuthPromptHost must contain a objectobject or an attached object.");
        }
        return new androidx.biometric.BiometricPrompt(ybeylZnEsAyuvHWA(authPromptHost), executor, ntgMGqDJquwlCsDB(authPromptCallback, new androidx.lifecycle.objectModelProvider(KDdWJUwSTbzWbcuD(UfMbpfZeDePqguCZ(authPromptHost)))));
    }

    public static androidx.fragment.app.object HegDRMfmBluHmHRW(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    public static androidx.biometric.BiometricPrompt LSkJNVlalcTzUYRw(androidx.biometric.auth.AuthPromptHost authPromptHost, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        return createBiometricPrompt(authPromptHost, executor, authPromptCallback);
    }

    public static void MJGfGipjQOCkaFiN(androidx.biometric.BiometricPrompt biometricPrompt, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        biometricPrompt.authenticate(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public static androidx.fragment.app.objectobject MSSnPfMWWNKWFxiC(androidx.fragment.app.object fragment) {
        return fragment.getobject();
    }

    public static androidx.fragment.app.objectobject MobhvybyzMXCsWaY(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    public static androidx.biometric.auth.AuthPromptUtils$AuthenticationCallbackWrapper ntgMGqDJquwlCsDB(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.lifecycle.objectModelProvider viewModelProvider) {
        return wrapCallback(authPromptCallback, viewModelProvider);
    }

    static androidx.biometric.auth.AuthPrompt StartAuthentication(androidx.biometric.auth.AuthPromptHost authPromptHost, androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.util.concurrent.Executor executor, androidx.biometric.auth.AuthPromptCallback authPromptCallback) {
        androidx.biometric.BiometricPrompt biometricPromptLSkJNVlalcTzUYRw = lSkJNVlalcTzUYRw(authPromptHost, executor, authPromptCallback);
        if (biometricPrompt$Cryptoobject is not null) {
            mJGfGipjQOCkaFiN(biometricPromptLSkJNVlalcTzUYRw, biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
        } else {
            KEvqFlgwDUvkcNVq(biometricPromptLSkJNVlalcTzUYRw, biometricPrompt$PromptInfo);
        }
        return new androidx.biometric.auth.AuthPromptUtils$AuthPromptWrapper(biometricPromptLSkJNVlalcTzUYRw);
    }

    public static androidx.fragment.app.objectobject WYwSRLCmVFSamKaI(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }

    private static androidx.biometric.auth.AuthPromptUtils$AuthenticationCallbackWrapper wrapCallback(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.lifecycle.objectModelProvider viewModelProvider) {
        if ((18 + 30) % 30 > 0) {
        }
        return new androidx.biometric.auth.AuthPromptUtils$AuthenticationCallbackWrapper(authPromptCallback, (androidx.biometric.BiometricobjectModel) CVxTPYitMAaLVNcQ(viewModelProvider, androidx.biometric.BiometricobjectModel.class));
    }

    public static androidx.biometric.auth.AuthPromptUtils$AuthenticationCallbackWrapper xglrhtmDkNJlmGPU(androidx.biometric.auth.AuthPromptCallback authPromptCallback, androidx.lifecycle.objectModelProvider viewModelProvider) {
        return wrapCallback(authPromptCallback, viewModelProvider);
    }

    public static androidx.fragment.app.object YbeylZnEsAyuvHWA(androidx.biometric.auth.AuthPromptHost authPromptHost) {
        return authPromptHost.getobject();
    }
}

