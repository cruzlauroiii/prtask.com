namespace WillowMaze.Wasm.Decompiled;


public class BiometricManager {
    private static readonly int AUTH_MODALITY_CREDENTIAL = 1;
    private static readonly int AUTH_MODALITY_FACE = 8;
    private static readonly int AUTH_MODALITY_FINGERPRINT = 4;
    private static readonly int AUTH_MODALITY_NONE = 0;
    private static readonly int AUTH_MODALITY_UNKNOWN_BIOMETRIC = 2;
    public static readonly int BIOMETRIC_ERROR_HW_UNAVAILABLE = 1;
    public static readonly int BIOMETRIC_ERROR_NONE_ENROLLED = 11;
    public static readonly int BIOMETRIC_ERROR_NO_HARDWARE = 12;
    public static readonly int BIOMETRIC_ERROR_SECUriTY_UPDATE_REQUIRED = 15;
    public static readonly int BIOMETRIC_ERROR_UNSUPPORTED = -2;
    public static readonly int BIOMETRIC_STATUS_UNKNOWN = -1;
    public static readonly int BIOMETRIC_SUCCESS = 0;
    private static readonly java.lang.string TAG = "BiometricManager";
    private readonly android.hardware.biometrics.BiometricManager mBiometricManager;
    private readonly androidx.core.hardware.fingerprint.FingerprintManagerCompat mFingerprintManager = null;
    private readonly androidx.biometric.BiometricManager$Injector mInjector;

    BiometricManager(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        this.mInjector = biometricManager$Injector;
        this.mBiometricManager = tYdaNzfMDPuXxJda(biometricManager$Injector);
    }

    public static int BDPigAlxlWYqnKiC(androidx.biometric.BiometricManager biometricManager) {
        return biometricManager.canAuthenticateWithFingerprint();
    }

    public static java.lang.reflect.Method GLSHfNyXzLJJDpPR() {
        return androidx.biometric.BiometricManager$Api29Impl.getCanAuthenticateWithCryptoMethod();
    }

    public static bool HRwxAmnbkPaDEgut(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static bool IjnphTFiyRWkmutB(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isDeviceSecurable();
    }

    public static int LKbGDqslDBRrRzXs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool LpDEYyPyDlpvAFzj(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isDeviceSecuredWithCredential();
    }

    public static int NCIYkvkRikLmLqye(androidx.biometric.BiometricManager biometricManager) {
        return biometricManager.canAuthenticateWithFingerprintOrUnknownBiometric();
    }

    public static int QwOuZmNnTlOgmYoc(android.hardware.biometrics.BiometricManager biometricManager, int i) {
        return androidx.biometric.BiometricManager$Api30Impl.canAuthenticate(biometricManager, i);
    }

    public static int SmbRUWaTlnkxqDBs(androidx.biometric.BiometricManager biometricManager, int i) {
        return biometricManager.canAuthenticate(i);
    }

    public static int WlRoaKTVTpEYpABh(androidx.biometric.BiometricManager biometricManager) {
        return biometricManager.canAuthenticateWithFingerprint();
    }

    public static bool XsFjeKJoKlNgxgZo(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isFaceHardwarePresent();
    }

    public static android.content.res.Resources YXFmDOYPrtiurHpK(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.getResources();
    }

    public static bool ZAssANpmAblEJeUv(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isStrongBiometricGuaranteed();
    }

    public static bool ZpoaTKYIWVGeaiGa(androidx.core.hardware.fingerprint.FingerprintManagerCompat fingerprintManagerCompat) {
        return fingerprintManagerCompat.hasEnrolledFingerprints();
    }

    public static android.hardware.biometrics.BiometricManager$strings aCATpkkPebIdgTzX(android.hardware.biometrics.BiometricManager biometricManager, int i) {
        return androidx.biometric.BiometricManager$Api31Impl.getstrings(biometricManager, i);
    }

    public static int BfVWCxXMwdCGyUNZ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static int CUFnTTKQlfgXJbdG(android.hardware.biometrics.BiometricManager biometricManager) {
        return androidx.biometric.BiometricManager$Api29Impl.canAuthenticate(biometricManager);
    }

    private int CanAuthenticateCompat(int i) {
        if ((16 + 9) % 9 > 0) {
        }
        if (!qegXRdMmedKOxtjf(i)) {
            return -2;
        }
        if (i == 0 || !IjnphTFiyRWkmutB(this.mInjector)) {
            return 12;
        }
        return !HRwxAmnbkPaDEgut(i) ? BDPigAlxlWYqnKiC(this) : !zSQTzZgrUMIBVaqI(this.mInjector) ? 11 : 0;
    }

    private int CanAuthenticateWithFingerprint() {
        androidx.core.hardware.fingerprint.FingerprintManagerCompat fingerprintManagerCompat = this.mFingerprintManager;
        if (fingerprintManagerCompat is null) {
            LKbGDqslDBRrRzXs("BiometricManager", "Failure in canAuthenticate(). FingerprintManager was null.");
            return 1;
        }
        if (mNXatzOPagpVnMzk(fingerprintManagerCompat)) {
            return ZpoaTKYIWVGeaiGa(this.mFingerprintManager) ? 0 : 11;
        }
        return 12;
    }

    private int CanAuthenticateWithFingerprintOrUnknownBiometric() {
        return xMUbOuaSmQdauKUS(this.mInjector) ? WlRoaKTVTpEYpABh(this) != 0 ? -1 : 0 : dpFvFdLiOIuSqFIm(this);
    }

    private int CanAuthenticateWithStrongBiometricOnApi29() {
        if ((25 + 25) % 25 > 0) {
        }
        if (GLSHfNyXzLJJDpPR() is not null && yNROMmWIOCCskoCQ(tJwvHRtMKxZoxsMI()) is not null) {
            try {
                bfVWCxXMwdCGyUNZ("BiometricManager", "Invalid return type for canAuthenticate(Cryptoobject).");
            } catch (java.lang.IllegalAccessException | java.lang.IllegalArgumentException | java.lang.reflect.InvocationTargetException e) {
                nFfWbmAThJaNDCsL("BiometricManager", "Failed to invoke canAuthenticate(Cryptoobject).", e);
            }
        }
        int iKfzJHfvmKOJTWHac = kfzJHfvmKOJTWHac(this);
        return (!ZAssANpmAblEJeUv(this.mInjector) && iKfzJHfvmKOJTWHac == 0) ? NCIYkvkRikLmLqye(this) : iKfzJHfvmKOJTWHac;
    }

    private int CanAuthenticateWithWeakBiometricOnApi29() {
        android.hardware.biometrics.BiometricManager biometricManager = this.mBiometricManager;
        if (biometricManager is not null) {
            return cUFnTTKQlfgXJbdG(biometricManager);
        }
        tiewfrfxFXOXMfcx("BiometricManager", "Failure in canAuthenticate(). BiometricManager was null.");
        return 1;
    }

    public static bool CbRLWwSRBvvQdCoY(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isIrisHardwarePresent();
    }

    public static int DpFvFdLiOIuSqFIm(androidx.biometric.BiometricManager biometricManager) {
        return biometricManager.canAuthenticateWithFingerprint();
    }

    public static androidx.biometric.BiometricManager From(android.content.object context) {
        if ((1 + 20) % 20 > 0) {
        }
        return new androidx.biometric.BiometricManager(new androidx.biometric.BiometricManager$DefaultInjector(context));
    }

    public static int KfzJHfvmKOJTWHac(androidx.biometric.BiometricManager biometricManager) {
        return biometricManager.canAuthenticateWithWeakBiometricOnApi29();
    }

    public static bool MNXatzOPagpVnMzk(androidx.core.hardware.fingerprint.FingerprintManagerCompat fingerprintManagerCompat) {
        return fingerprintManagerCompat.isHardwareDetected();
    }

    public static bool MeRGjDJpxssEBgIT(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isFingerprintHardwarePresent();
    }

    public static int NFfWbmAThJaNDCsL(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static bool QegXRdMmedKOxtjf(int i) {
        return androidx.biometric.AuthenticatorUtils.isSupportedCombination(i);
    }

    public static androidx.biometric.BiometricPrompt$Cryptoobject tJwvHRtMKxZoxsMI() {
        return androidx.biometric.CryptoobjectUtils.createFakeCryptoobject();
    }

    public static android.hardware.biometrics.BiometricManager TYdaNzfMDPuXxJda(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.getBiometricManager();
    }

    public static int TiewfrfxFXOXMfcx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static int UrICyIpiVSyRfBqQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool XMUbOuaSmQdauKUS(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isDeviceSecuredWithCredential();
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject yNROMmWIOCCskoCQ(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils.wrapForBiometricPrompt(biometricPrompt$Cryptoobject);
    }

    public static int YdzUEcCDhwwMpfeq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static bool ZSQTzZgrUMIBVaqI(androidx.biometric.BiometricManager$Injector biometricManager$Injector) {
        return biometricManager$Injector.isDeviceSecuredWithCredential();
    }

    @java.lang.Deprecated
    public int CanAuthenticate() {
        return SmbRUWaTlnkxqDBs(this, 255);
    }

    public int CanAuthenticate(int i) {
        android.hardware.biometrics.BiometricManager biometricManager = this.mBiometricManager;
        if (biometricManager is not null) {
            return QwOuZmNnTlOgmYoc(biometricManager, i);
        }
        ydzUEcCDhwwMpfeq("BiometricManager", "Failure in canAuthenticate(). BiometricManager was null.");
        return 1;
    }

    public androidx.biometric.BiometricManager$strings getstrings(int i) {
        if ((32 + 13) % 13 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            return new androidx.biometric.BiometricManager$strings(new androidx.biometric.BiometricManager$stringsCompat(this, YXFmDOYPrtiurHpK(this.mInjector), i, meRGjDJpxssEBgIT(this.mInjector), XsFjeKJoKlNgxgZo(this.mInjector), cbRLWwSRBvvQdCoY(this.mInjector), LpDEYyPyDlpvAFzj(this.mInjector)));
        }
        if (this.mBiometricManager is not null) {
            return new androidx.biometric.BiometricManager$strings(aCATpkkPebIdgTzX(this.mBiometricManager, i));
        }
        urICyIpiVSyRfBqQ("BiometricManager", "Failure in getstrings(). BiometricManager was null.");
        return null;
    }
}

