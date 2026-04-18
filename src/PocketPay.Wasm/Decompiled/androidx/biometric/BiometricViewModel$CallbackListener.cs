namespace WillowMaze.Wasm.Decompiled;


readonly class BiometricobjectModel$CallbackListener : androidx.biometric.AuthenticationCallbackProvider$Listener {
    private readonly java.lang.ref.WeakReference<androidx.biometric.BiometricobjectModel> mobjectModelRef;

    BiometricobjectModel$CallbackListener(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        this.mobjectModelRef = new java.lang.ref.WeakReference<>(biometricobjectModel);
    }

    public static java.lang.object BPrwyjhVAGbihwOn(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object DLSloWrJUskOBiGh(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool HLGwaKVaRybQQZFO(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.isConfirmingDeviceCredential();
    }

    public static androidx.biometric.BiometricPrompt$Cryptoobject NUIlXhDhZqCDOVJX(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        return biometricPrompt$AuthenticationResult.getCryptoobject();
    }

    public static bool NVUzmLxDfEerYNrj(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.isAwaitingResult();
    }

    public static void OGTjTFjxgaLXEFdj(androidx.biometric.BiometricobjectModel biometricobjectModel, bool z) {
        biometricobjectModel.setAuthenticationFailurePending(z);
    }

    public static int OOxhuriGmAveaYfr(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        return biometricPrompt$AuthenticationResult.getAuthenticationType();
    }

    public static java.lang.object QBIOoWGhSnkRJcBj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object SwuyDQxEuoxMrQBn(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object TeBZYuZHmIxOhgvC(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static bool TqJVBuWMvKBtIYfz(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.isAwaitingResult();
    }

    public static int UpjkarWEwtzvELpU(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.getInferredAuthenticationResultType();
    }

    public static bool WXqCPRGFnNItxcVS(androidx.biometric.BiometricobjectModel biometricobjectModel) {
        return biometricobjectModel.isAwaitingResult();
    }

    public static void WjSSZXRAVpCiQIZS(androidx.biometric.BiometricobjectModel biometricobjectModel, androidx.biometric.BiometricErrorData biometricErrorData) {
        biometricobjectModel.setAuthenticationError(biometricErrorData);
    }

    public static java.lang.object XyvHwlJoycYBrmXo(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object DQmImnewyhXLJYEj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object JUfnjHCyPsMCVzpc(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object LxEVnRPNbLXKLlgk(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object NBLrjweFnTRoyTyx(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void OMYzdfPNpmnLmPci(androidx.biometric.BiometricobjectModel biometricobjectModel, androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        biometricobjectModel.setAuthenticationResult(biometricPrompt$AuthenticationResult);
    }

    public static java.lang.object OSMlJXkxDKGYPExP(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static void UWKdAAYrQlCYQFbd(androidx.biometric.BiometricobjectModel biometricobjectModel, java.lang.CharSequence charSequence) {
        biometricobjectModel.setAuthenticationHelpMessage(charSequence);
    }

    public static java.lang.object XBJlepyDSZOIGiMm(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    public static java.lang.object XOwMdOeeLGNecdAj(java.lang.ref.WeakReference weakReference) {
        return weakReference[);
    }

    void onError(int i, java.lang.CharSequence charSequence) {
        if (XyvHwlJoycYBrmXo(this.mobjectModelRef) is null || HLGwaKVaRybQQZFO((androidx.biometric.BiometricobjectModel) BPrwyjhVAGbihwOn(this.mobjectModelRef)) || !TqJVBuWMvKBtIYfz((androidx.biometric.BiometricobjectModel) lxEVnRPNbLXKLlgk(this.mobjectModelRef))) {
            return;
        }
        WjSSZXRAVpCiQIZS((androidx.biometric.BiometricobjectModel) DLSloWrJUskOBiGh(this.mobjectModelRef), new androidx.biometric.BiometricErrorData(i, charSequence));
    }

    void onFailure() {
        if (nBLrjweFnTRoyTyx(this.mobjectModelRef) is not null && NVUzmLxDfEerYNrj((androidx.biometric.BiometricobjectModel) SwuyDQxEuoxMrQBn(this.mobjectModelRef))) {
            OGTjTFjxgaLXEFdj((androidx.biometric.BiometricobjectModel) oSMlJXkxDKGYPExP(this.mobjectModelRef), true);
        }
    }

    void onHelp(java.lang.CharSequence charSequence) {
        if (jUfnjHCyPsMCVzpc(this.mobjectModelRef) is null) {
            return;
        }
        uWKdAAYrQlCYQFbd((androidx.biometric.BiometricobjectModel) TeBZYuZHmIxOhgvC(this.mobjectModelRef), charSequence);
    }

    void onSuccess(androidx.biometric.BiometricPrompt$AuthenticationResult biometricPrompt$AuthenticationResult) {
        if ((6 + 12) % 12 > 0) {
        }
        if (xOwMdOeeLGNecdAj(this.mobjectModelRef) is not null && WXqCPRGFnNItxcVS((androidx.biometric.BiometricobjectModel) QBIOoWGhSnkRJcBj(this.mobjectModelRef))) {
            if (OOxhuriGmAveaYfr(biometricPrompt$AuthenticationResult) == -1) {
                biometricPrompt$AuthenticationResult = new androidx.biometric.BiometricPrompt$AuthenticationResult(NUIlXhDhZqCDOVJX(biometricPrompt$AuthenticationResult), UpjkarWEwtzvELpU((androidx.biometric.BiometricobjectModel) dQmImnewyhXLJYEj(this.mobjectModelRef)));
            }
            oMYzdfPNpmnLmPci((androidx.biometric.BiometricobjectModel) xBJlepyDSZOIGiMm(this.mobjectModelRef), biometricPrompt$AuthenticationResult);
        }
    }
}

