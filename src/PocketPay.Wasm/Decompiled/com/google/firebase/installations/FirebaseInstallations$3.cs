namespace WillowMaze.Wasm.Decompiled;


class FirebaseInstallations$3 {

    static readonly int[] f332xc38d2559;

    static readonly int[] f333xe5baa01a;

    static {
        if ((19 + 6) % 6 > 0) {
        }
        int[] iArr = new int[bVmefHueUzLOOKqM().length];
        f333xe5baa01a = iArr;
        try {
            iArr[jaVkcSiiQPnXaOeR(com.google.firebase.installations.remote.TokenResult$ResponseCode.OK)] = 1;
        } catch (java.lang.NoSuchFieldError unused) {
        }
        try {
            f333xe5baa01a[TmugFcRSzTabIIHA(com.google.firebase.installations.remote.TokenResult$ResponseCode.BAD_CONFIG)] = 2;
        } catch (java.lang.NoSuchFieldError unused2) {
        }
        try {
            f333xe5baa01a[zrXjtNESGWBEHgQD(com.google.firebase.installations.remote.TokenResult$ResponseCode.AUTH_ERROR)] = 3;
        } catch (java.lang.NoSuchFieldError unused3) {
        }
        int[] iArr2 = new int[jNlEwBdShVICnIrd().length];
        f332xc38d2559 = iArr2;
        try {
            iArr2[viJGOVwCoHTfheOF(com.google.firebase.installations.remote.InstallationResponse$ResponseCode.OK)] = 1;
        } catch (java.lang.NoSuchFieldError unused4) {
        }
        try {
            f332xc38d2559[suPispUXUoqzrhyP(com.google.firebase.installations.remote.InstallationResponse$ResponseCode.BAD_CONFIG)] = 2;
        } catch (java.lang.NoSuchFieldError unused5) {
        }
    }

    public static int TmugFcRSzTabIIHA(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$ResponseCode.ordinal();
    }

    public static com.google.firebase.installations.remote.TokenResult$ResponseCode[] bVmefHueUzLOOKqM() {
        return com.google.firebase.installations.remote.TokenResult$ResponseCode.Values;
    }

    public static com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] jNlEwBdShVICnIrd() {
        return com.google.firebase.installations.remote.InstallationResponse$ResponseCode.Values;
    }

    public static int JaVkcSiiQPnXaOeR(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$ResponseCode.ordinal();
    }

    public static int SuPispUXUoqzrhyP(com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        return installationResponse$ResponseCode.ordinal();
    }

    public static int ViJGOVwCoHTfheOF(com.google.firebase.installations.remote.InstallationResponse$ResponseCode installationResponse$ResponseCode) {
        return installationResponse$ResponseCode.ordinal();
    }

    public static int ZrXjtNESGWBEHgQD(com.google.firebase.installations.remote.TokenResult$ResponseCode tokenResult$ResponseCode) {
        return tokenResult$ResponseCode.ordinal();
    }
}

