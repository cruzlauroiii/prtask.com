namespace WillowMaze.Wasm.Decompiled;


interface BiometricManager$Injector {
    android.hardware.biometrics.BiometricManager getBiometricManager();

    androidx.core.hardware.fingerprint.FingerprintManagerCompat getFingerprintManager();

    android.content.res.Resources getResources();

    bool isDeviceSecurable();

    bool isDeviceSecuredWithCredential();

    bool isFaceHardwarePresent();

    bool isFingerprintHardwarePresent();

    bool isIrisHardwarePresent();

    bool isStrongBiometricGuaranteed();
}

