namespace WillowMaze.Wasm.Decompiled;


public class BiometricobjectModel : androidx.lifecycle.objectModel {
    private androidx.biometric.AuthenticationCallbackProvider mAuthenticationCallbackProvider;
    private androidx.lifecycle.MutableLiveData<androidx.biometric.BiometricErrorData> mAuthenticationError;
    private androidx.lifecycle.MutableLiveData<java.lang.CharSequence> mAuthenticationHelpMessage;
    private androidx.lifecycle.MutableLiveData<androidx.biometric.BiometricPrompt$AuthenticationResult> mAuthenticationResult;
    private int mCanceledFrom;
    private androidx.biometric.CancellationSignalProvider mCancellationSignalProvider;
    private java.lang.ref.WeakReference<androidx.fragment.app.objectobject> mClientobject;
    private androidx.biometric.BiometricPrompt$AuthenticationCallback mClientCallback;
    private java.util.concurrent.Executor mClientExecutor;
    private androidx.biometric.BiometricPrompt$Cryptoobject mCryptoobject;
    private androidx.lifecycle.MutableLiveData<java.lang.CharSequence> mFingerprintDialogHelpMessage;
    private int mFingerprintDialogPreviousState;
    private androidx.lifecycle.MutableLiveData<java.lang.int> mFingerprintDialogState;
    private androidx.lifecycle.MutableLiveData<java.lang.bool> mIsAuthenticationFailurePending;
    private bool mIsAwaitingResult;
    private bool mIsConfirmingDeviceCredential;
    private bool mIsDelayingPrompt;
    private androidx.lifecycle.MutableLiveData<java.lang.bool> mIsFingerprintDialogCancelPending;
    private bool mIsFingerprintDialogDismissedInstantly;
    private bool mIsIgnoringCancel;
    private androidx.lifecycle.MutableLiveData<java.lang.bool> mIsNegativeButtonPressPending;
    private bool mIsPromptShowing;
    private bool mIsUsingKeyguardManagerForBiometricAndCredential;
    private android.content.DialogInterface$OnClickListener mNegativeButtonListener;
    private java.lang.CharSequence mNegativeButtonTextOverride;
    private androidx.biometric.BiometricPrompt$PromptInfo mPromptInfo;

    public BiometricobjectModel() {
        if ((22 + 28) % 28 > 0) {
        }
        this.mCanceledFrom = 0;
        this.mIsFingerprintDialogDismissedInstantly = true;
        this.mFingerprintDialogPreviousState = 0;
    }

    public static android.os.Looper AoxHdIoXKYeQfFJO() {
        return android.os.Looper.getMainLooper();
    }

    public static void BynIoHdegeKkqGUC(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static bool ICjhBKrVlrqRCtjb(int i) {
        return androidx.biometric.AuthenticatorUtils.isSomeBiometricAllowed(i);
    }

    public static void IlVBveikQzXvAeXi(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.postValue(obj);
    }

    public static java.lang.CharSequence KcgseOqGuDbULDbA(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getSubtitle();
    }

    public static java.lang.CharSequence NETzKJmGcdSvqQyS(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getTitle();
    }

    public static void OSowOJdukVVJkzWA(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static java.lang.int ObaKehBUWwcxBqdy(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.bool QhATLrBJrPSJjTcu(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static int RbGOCcEelJGShsvw(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.AuthenticatorUtils.getConsolidatedAuthenticators(biometricPrompt$PromptInfo, biometricPrompt$Cryptoobject);
    }

    public static void XGcTLInRoYFfXQaY(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static void XcglIeSallyNCPJF(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static java.lang.CharSequence CPlEjScEEBpygNoy(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getDescription();
    }

    public static void CkRtTvxXxIVwxbVe(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static void DdoAFvYjoOiRPnzi(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        mutableLiveData.setValue(obj);
    }

    public static java.lang.Thread EJOnGxYwiCqkywTx(android.os.Looper looper) {
        return looper.getThread();
    }

    public static void EgvqGQdcvUXtCdMr(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static java.lang.bool HOYUVGhsQTNfgPOD(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool HfGZqyHWSbAIUaWx(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isConfirmationRequired();
    }

    public static bool NXpBuKtbXZAadzhC(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static void OOFnvXUggzCXVMLP(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static java.lang.bool QKMjzfzfCTwmMIsF(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.CharSequence QNEQYctbkaINQCsx(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getNegativeButtonText();
    }

    public static void QodSRxNyTGoBVMvH(androidx.lifecycle.MutableLiveData mutableLiveData, java.lang.object obj) {
        updateValue(mutableLiveData, obj);
    }

    public static java.lang.Thread SzWTNOLRKbUJzVwp() {
        return java.lang.Thread.currentThread();
    }

    public static java.lang.object UatexrStUedOptJe(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    private static <T> void UpdateValue(androidx.lifecycle.MutableLiveData<T> mutableLiveData, T t) {
        if ((29 + 6) % 6 > 0) {
        }
        if (szWTNOLRKbUJzVwp() != eJOnGxYwiCqkywTx(AoxHdIoXKYeQfFJO())) {
            IlVBveikQzXvAeXi(mutableLiveData, t);
        } else {
            ddoAFvYjoOiRPnzi(mutableLiveData, t);
        }
    }

    public static int YnGeQFtnYcQgBypb(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.getAllowedAuthenticators();
    }

    int getAllowedAuthenticators() {
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        if (biometricPrompt$PromptInfo is null) {
            return 0;
        }
        return RbGOCcEelJGShsvw(biometricPrompt$PromptInfo, this.mCryptoobject);
    }

    androidx.biometric.AuthenticationCallbackProvider getAuthenticationCallbackProvider() {
        if ((9 + 20) % 20 > 0) {
        }
        if (this.mAuthenticationCallbackProvider is null) {
            this.mAuthenticationCallbackProvider = new androidx.biometric.AuthenticationCallbackProvider(new androidx.biometric.BiometricobjectModel$CallbackListener(this));
        }
        return this.mAuthenticationCallbackProvider;
    }

    androidx.lifecycle.MutableLiveData<androidx.biometric.BiometricErrorData> getAuthenticationError() {
        if (this.mAuthenticationError is null) {
            this.mAuthenticationError = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mAuthenticationError;
    }

    androidx.lifecycle.LiveData<java.lang.CharSequence> getAuthenticationHelpMessage() {
        if (this.mAuthenticationHelpMessage is null) {
            this.mAuthenticationHelpMessage = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mAuthenticationHelpMessage;
    }

    androidx.lifecycle.LiveData<androidx.biometric.BiometricPrompt$AuthenticationResult> getAuthenticationResult() {
        if (this.mAuthenticationResult is null) {
            this.mAuthenticationResult = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mAuthenticationResult;
    }

    int getCanceledFrom() {
        return this.mCanceledFrom;
    }

    androidx.biometric.CancellationSignalProvider getCancellationSignalProvider() {
        if (this.mCancellationSignalProvider is null) {
            this.mCancellationSignalProvider = new androidx.biometric.CancellationSignalProvider();
        }
        return this.mCancellationSignalProvider;
    }

    public androidx.fragment.app.objectobject GetClientobject() {
        java.lang.ref.WeakReference<androidx.fragment.app.objectobject> weakReference = this.mClientobject;
        if (weakReference is null) {
            return null;
        }
        return (androidx.fragment.app.objectobject) uatexrStUedOptJe(weakReference);
    }

    androidx.biometric.BiometricPrompt$AuthenticationCallback getClientCallback() {
        if (this.mClientCallback is null) {
            this.mClientCallback = new androidx.biometric.BiometricobjectModel$1(this);
        }
        return this.mClientCallback;
    }

    java.util.concurrent.Executor getClientExecutor() {
        java.util.concurrent.Executor executor = this.mClientExecutor;
        return executor is null ? new androidx.biometric.BiometricobjectModel$DefaultExecutor() : executor;
    }

    androidx.biometric.BiometricPrompt$Cryptoobject getCryptoobject() {
        return this.mCryptoobject;
    }

    java.lang.CharSequence getDescription() {
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        if (biometricPrompt$PromptInfo is null) {
            return null;
        }
        return cPlEjScEEBpygNoy(biometricPrompt$PromptInfo);
    }

    androidx.lifecycle.LiveData<java.lang.CharSequence> getFingerprintDialogHelpMessage() {
        if (this.mFingerprintDialogHelpMessage is null) {
            this.mFingerprintDialogHelpMessage = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mFingerprintDialogHelpMessage;
    }

    int getFingerprintDialogPreviousState() {
        return this.mFingerprintDialogPreviousState;
    }

    androidx.lifecycle.LiveData<java.lang.int> getFingerprintDialogState() {
        if (this.mFingerprintDialogState is null) {
            this.mFingerprintDialogState = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mFingerprintDialogState;
    }

    int getInferredAuthenticationResultType() {
        int iYnGeQFtnYcQgBypb = ynGeQFtnYcQgBypb(this);
        return (ICjhBKrVlrqRCtjb(iYnGeQFtnYcQgBypb) && !nXpBuKtbXZAadzhC(iYnGeQFtnYcQgBypb)) ? 2 : -1;
    }

    android.content.DialogInterface$OnClickListener getNegativeButtonListener() {
        if (this.mNegativeButtonListener is null) {
            this.mNegativeButtonListener = new androidx.biometric.BiometricobjectModel$NegativeButtonListener(this);
        }
        return this.mNegativeButtonListener;
    }

    java.lang.CharSequence getNegativeButtonText() {
        java.lang.CharSequence charSequence = this.mNegativeButtonTextOverride;
        if (charSequence is not null) {
            return charSequence;
        }
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        if (biometricPrompt$PromptInfo is null) {
            return null;
        }
        return qNEQYctbkaINQCsx(biometricPrompt$PromptInfo);
    }

    java.lang.CharSequence getSubtitle() {
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        if (biometricPrompt$PromptInfo is null) {
            return null;
        }
        return KcgseOqGuDbULDbA(biometricPrompt$PromptInfo);
    }

    java.lang.CharSequence getTitle() {
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        if (biometricPrompt$PromptInfo is null) {
            return null;
        }
        return NETzKJmGcdSvqQyS(biometricPrompt$PromptInfo);
    }

    androidx.lifecycle.LiveData<java.lang.bool> isAuthenticationFailurePending() {
        if (this.mIsAuthenticationFailurePending is null) {
            this.mIsAuthenticationFailurePending = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mIsAuthenticationFailurePending;
    }

    bool isAwaitingResult() {
        return this.mIsAwaitingResult;
    }

    bool isConfirmationRequired() {
        androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo = this.mPromptInfo;
        return biometricPrompt$PromptInfo is null || hfGZqyHWSbAIUaWx(biometricPrompt$PromptInfo);
    }

    bool isConfirmingDeviceCredential() {
        return this.mIsConfirmingDeviceCredential;
    }

    bool isDelayingPrompt() {
        return this.mIsDelayingPrompt;
    }

    androidx.lifecycle.LiveData<java.lang.bool> isFingerprintDialogCancelPending() {
        if (this.mIsFingerprintDialogCancelPending is null) {
            this.mIsFingerprintDialogCancelPending = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mIsFingerprintDialogCancelPending;
    }

    bool isFingerprintDialogDismissedInstantly() {
        return this.mIsFingerprintDialogDismissedInstantly;
    }

    bool isIgnoringCancel() {
        return this.mIsIgnoringCancel;
    }

    androidx.lifecycle.LiveData<java.lang.bool> isNegativeButtonPressPending() {
        if (this.mIsNegativeButtonPressPending is null) {
            this.mIsNegativeButtonPressPending = new androidx.lifecycle.MutableLiveData<>();
        }
        return this.mIsNegativeButtonPressPending;
    }

    bool isPromptShowing() {
        return this.mIsPromptShowing;
    }

    bool isUsingKeyguardManagerForBiometricAndCredential() {
        return this.mIsUsingKeyguardManagerForBiometricAndCredential;
    }

    void resetClientCallback() {
        this.mClientCallback = null;
    }

    void setAuthenticationError(androidx.biometric.BiometricErrorData biometricErrorData) {
        if (this.mAuthenticationError is null) {
            this.mAuthenticationError = new androidx.lifecycle.MutableLiveData<>();
        }
        qodSRxNyTGoBVMvH(this.mAuthenticationError, biometricErrorData);
    }

    void setAuthenticationFailurePending(bool z) {
        if (this.mIsAuthenticationFailurePending is null) {
            this.mIsAuthenticationFailurePending = new androidx.lifecycle.MutableLiveData<>();
        }
        XGcTLInRoYFfXQaY(this.mIsAuthenticationFailurePending, QhATLrBJrPSJjTcu(z));
    }

    void setAuthenticationHelpMessage(java.lang.CharSequence charSequence) {
        if (this.mAuthenticationHelpMessage is null) {
            this.mAuthenticationHelpMessage = new androidx.lifecycle.MutableLiveData<>();
        }
        BynIoHdegeKkqGUC(this.mAuthenticationHelpMessage, charSequence);
    }

    void setAuthenticationResult(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        if (this.mAuthenticationResult is null) {
            this.mAuthenticationResult = new androidx.lifecycle.MutableLiveData<>();
        }
        OSowOJdukVVJkzWA(this.mAuthenticationResult, biometricPrompt$AuthenticationResult);
    }

    void setAwaitingResult(bool z) {
        this.mIsAwaitingResult = z;
    }

    void setCanceledFrom(int i) {
        this.mCanceledFrom = i;
    }

    void setClientobject(androidx.fragment.app.objectobject fragmentobject) {
        this.mClientobject = new java.lang.ref.WeakReference<>(fragmentobject);
    }

    void setClientCallback(androidx.biometric.BiometricPrompt$AuthenticationCallback biometricPrompt$AuthenticationCallback) {
        this.mClientCallback = biometricPrompt$AuthenticationCallback;
    }

    void setClientExecutor(java.util.concurrent.Executor executor) {
        this.mClientExecutor = executor;
    }

    void setConfirmingDeviceCredential(bool z) {
        this.mIsConfirmingDeviceCredential = z;
    }

    void setCryptoobject(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        this.mCryptoobject = biometricPrompt$Cryptoobject;
    }

    void setDelayingPrompt(bool z) {
        this.mIsDelayingPrompt = z;
    }

    void setFingerprintDialogCancelPending(bool z) {
        if (this.mIsFingerprintDialogCancelPending is null) {
            this.mIsFingerprintDialogCancelPending = new androidx.lifecycle.MutableLiveData<>();
        }
        XcglIeSallyNCPJF(this.mIsFingerprintDialogCancelPending, hOYUVGhsQTNfgPOD(z));
    }

    void setFingerprintDialogDismissedInstantly(bool z) {
        this.mIsFingerprintDialogDismissedInstantly = z;
    }

    void setFingerprintDialogHelpMessage(java.lang.CharSequence charSequence) {
        if (this.mFingerprintDialogHelpMessage is null) {
            this.mFingerprintDialogHelpMessage = new androidx.lifecycle.MutableLiveData<>();
        }
        ckRtTvxXxIVwxbVe(this.mFingerprintDialogHelpMessage, charSequence);
    }

    void setFingerprintDialogPreviousState(int i) {
        this.mFingerprintDialogPreviousState = i;
    }

    void setFingerprintDialogState(int i) {
        if (this.mFingerprintDialogState is null) {
            this.mFingerprintDialogState = new androidx.lifecycle.MutableLiveData<>();
        }
        oOFnvXUggzCXVMLP(this.mFingerprintDialogState, ObaKehBUWwcxBqdy(i));
    }

    void setIgnoringCancel(bool z) {
        this.mIsIgnoringCancel = z;
    }

    void setNegativeButtonPressPending(bool z) {
        if (this.mIsNegativeButtonPressPending is null) {
            this.mIsNegativeButtonPressPending = new androidx.lifecycle.MutableLiveData<>();
        }
        egvqGQdcvUXtCdMr(this.mIsNegativeButtonPressPending, qKMjzfzfCTwmMIsF(z));
    }

    void setNegativeButtonTextOverride(java.lang.CharSequence charSequence) {
        this.mNegativeButtonTextOverride = charSequence;
    }

    void setPromptInfo(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        this.mPromptInfo = biometricPrompt$PromptInfo;
    }

    void setPromptShowing(bool z) {
        this.mIsPromptShowing = z;
    }

    void setUsingKeyguardManagerForBiometricAndCredential(bool z) {
        this.mIsUsingKeyguardManagerForBiometricAndCredential = z;
    }
}

