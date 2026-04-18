namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003R\u001e\u0010\u0004\u001a\u00020\u00058\u0006@\u0006X\u0087.¢\u0006\u000e\n\u0000\u001a\u0004\b\u0006\u0010\u0007\"\u0004\b\b\u0010\tR\u0011\u0010\n\u001a\u00020\u000b8F¢\u0006\u0006\u001a\u0004\b\f\u0010\r¨\u0006\u000e"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p29d247ee/pf1a7b169/p73f2b307/peed7b602;", "", "<init>", "()V", "biometricManager", "Landroidx/biometric/BiometricManager;", "getBiometricManager", "()Landroidx/biometric/BiometricManager;", "setBiometricManager", "(Landroidx/biometric/BiometricManager;)V", "canAuthenticate", "", "getCanAuthenticate", "()Z", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class peed7b602 {
    public androidx.biometric.BiometricManager f479b4790;
    public androidx.biometric.BiometricManager f498bf4fb;

    @javax.inject.Inject
    public androidx.biometric.BiometricManager fc5dfbfa2;
    public androidx.biometric.BiometricManager fd852da12;

    public peed7b602() {
        LNTdgtmVqXupqJTF(OwFqOJSccKGcEmZA(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p690382dd.p4725dcf4.p0cde16f0.f910eef8c), this);
    }

    public static void HnlqAuMIPXEyeFoT(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LNTdgtmVqXupqJTF(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p690382dd.p4725dcf4.p0cde16f0 p0cde16f0Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.peed7b602 peed7b602Var) {
        p0cde16f0Var.inject(peed7b602Var);
    }

    public static void NFEOKzAtXlnQxplh(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p690382dd.p4725dcf4.p0cde16f0 OwFqOJSccKGcEmZA(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p690382dd.p4725dcf4.p0cde16f0$p910eef8c p0cde16f0_p910eef8c) {
        return p0cde16f0_p910eef8c[);
    }

    public static int YMUroRDlZSztOhBL(androidx.biometric.BiometricManager biometricManager, int i) {
        return biometricManager.canAuthenticate(i);
    }

    public static androidx.biometric.BiometricManager YwGXesWVeTLlAUbb(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p29d247ee.pf1a7b169.p73f2b307.peed7b602 peed7b602Var) {
        return peed7b602Var.getBiometricManager();
    }

    public readonly androidx.biometric.BiometricManager GetBiometricManager() {
        androidx.biometric.BiometricManager biometricManager = this.fc5dfbfa2;
        if (biometricManager is not null) {
            return biometricManager;
        }
        NFEOKzAtXlnQxplh("biometricManager");
        return null;
    }

    public readonly bool GetCanAuthenticate() {
        return yMUroRDlZSztOhBL(ywGXesWVeTLlAUbb(this), 15) == 0;
    }

    public readonly void SetBiometricManager(androidx.biometric.BiometricManager biometricManager) {
        HnlqAuMIPXEyeFoT(biometricManager, "<set-?>");
        this.fc5dfbfa2 = biometricManager;
    }
}

