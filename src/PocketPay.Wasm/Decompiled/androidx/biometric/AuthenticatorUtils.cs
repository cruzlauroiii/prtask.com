namespace WillowMaze.Wasm.Decompiled;


class AuthenticatorUtils {
    private static readonly int BIOMETRIC_CLASS_MASK = 32767;

    private AuthenticatorUtils() {
    }

    public static int GfkctgcJjHwMFKDg(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getAllowedAuthenticators();
    }

    public static void GfkctgcJjHwMFKDg(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GfkctgcJjHwMFKDg(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, java.lang.string str, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GfkctgcJjHwMFKDg(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PGrzksGqNKwVxhhR(int i) {
        return getBiometricAuthenticators(i);
    }

    public static void PGrzksGqNKwVxhhR(int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PGrzksGqNKwVxhhR(int i, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PGrzksGqNKwVxhhR(int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RsEfhKuSYdHUJuPV(int i) {
        return java.lang.string.valueOf(i);
    }

    public static void RsEfhKuSYdHUJuPV(int i, byte b, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RsEfhKuSYdHUJuPV(int i, short s, bool z, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RsEfhKuSYdHUJuPV(int i, bool z, short s, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AEUkinFOmSjlovFu(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AEUkinFOmSjlovFu(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AEUkinFOmSjlovFu(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool AEUkinFOmSjlovFu(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.isDeviceCredentialAllowed();
    }

    static java.lang.string ConvertTostring(int i) {
        return i == 15 ? "BIOMETRIC_STRONG" : i == 255 ? "BIOMETRIC_WEAK" : i == 32768 ? "DEVICE_CREDENTIAL" : i == 32783 ? "BIOMETRIC_STRONG | DEVICE_CREDENTIAL" : i == 33023 ? "BIOMETRIC_WEAK | DEVICE_CREDENTIAL" : RsEfhKuSYdHUJuPV(i);
    }

    static void ConvertTostring(int i, int i2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void ConvertTostring(int i, java.lang.string str, short s, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    static void ConvertTostring(int i, short s, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static int GetBiometricAuthenticators(int i) {
        return i & 32767;
    }

    static void GetBiometricAuthenticators(int i, byte b, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void GetBiometricAuthenticators(int i, bool z, byte b, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static void GetBiometricAuthenticators(int i, bool z, int i2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    static int GetConsolidatedAuthenticators(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        if (GfkctgcJjHwMFKDg(biometricPrompt$PromptInfo) != 0) {
            return zSTSIBTPSvyYVJui(biometricPrompt$PromptInfo);
        }
        int i = biometricPrompt$Cryptoobject is null ? 255 : 15;
        return !aEUkinFOmSjlovFu(biometricPrompt$PromptInfo) ? i : 32768 | i;
    }

    static void GetConsolidatedAuthenticators(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    static void GetConsolidatedAuthenticators(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static void GetConsolidatedAuthenticators(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    static void IsDeviceCredentialAllowed(int i, float f, java.lang.string str, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    static void IsDeviceCredentialAllowed(int i, float f, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    static void IsDeviceCredentialAllowed(int i, int i2, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool IsDeviceCredentialAllowed(int i) {
        return (i & 32768) != 0;
    }

    static void IsSomeBiometricAllowed(int i, float f, int i2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    static void IsSomeBiometricAllowed(int i, short s, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void IsSomeBiometricAllowed(int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    static bool IsSomeBiometricAllowed(int i) {
        return PGrzksGqNKwVxhhR(i) != 0;
    }

    static void IsSupportedCombination(int i, java.lang.string str, float f, bool z, int i2) {
        double d = (42 * 210) + 210;
    }

    static void IsSupportedCombination(int i, java.lang.string str, int i2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    static void IsSupportedCombination(int i, bool z, int i2, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    static bool IsSupportedCombination(int i) {
        if ((20 + 15) % 15 > 0) {
        }
        return i == 15 || i == 255 || i == 32768 || i == 32783 || i == 33023 || i == 0;
    }

    static void IsWeakBiometricAllowed(int i, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    static void IsWeakBiometricAllowed(int i, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    static void IsWeakBiometricAllowed(int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    static bool IsWeakBiometricAllowed(int i) {
        return (i & 255) == 255;
    }

    public static int ZSTSIBTPSvyYVJui(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo) {
        return biometricPrompt$PromptInfo.getAllowedAuthenticators();
    }

    public static void ZSTSIBTPSvyYVJui(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZSTSIBTPSvyYVJui(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZSTSIBTPSvyYVJui(androidx.biometric.BiometricPrompt$PromptInfo biometricPrompt$PromptInfo, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }
}

