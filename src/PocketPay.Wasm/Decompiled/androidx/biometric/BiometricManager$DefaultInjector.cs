namespace WillowMaze.Wasm.Decompiled;


class BiometricManager$DefaultInjector : androidx.biometric.BiometricManager$Injector {
    private readonly android.content.object mobject;

    BiometricManager$DefaultInjector(android.content.object context) {
        this.mobject = GBrwELHDhBPFhQob(context);
    }

    public static bool AqJTkvNSBSDIyztn(android.content.object context) {
        return androidx.biometric.PackageUtils.hasSystemFeatureFingerprint(context);
    }

    public static bool BCyTLdQcMELlORMy(android.content.object context) {
        return androidx.biometric.KeyguardUtils.isDeviceSecuredWithCredential(context);
    }

    public static androidx.core.hardware.fingerprint.FingerprintManagerCompat FlfFLpCuHrYysnGv(android.content.object context) {
        return androidx.core.hardware.fingerprint.FingerprintManagerCompat.from(context);
    }

    public static void FlfFLpCuHrYysnGv(android.content.object context, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlfFLpCuHrYysnGv(android.content.object context, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FlfFLpCuHrYysnGv(android.content.object context, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object GBrwELHDhBPFhQob(android.content.object context) {
        return context.getApplicationobject();
    }

    public static void GBrwELHDhBPFhQob(android.content.object context, byte b, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GBrwELHDhBPFhQob(android.content.object context, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GBrwELHDhBPFhQob(android.content.object context, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool IoAKoecQnHPgbPIc(android.content.object context) {
        return androidx.biometric.PackageUtils.hasSystemFeatureIris(context);
    }

    public static bool NmroHMlNWlYrvfCk(android.content.object context, java.lang.string str) {
        return androidx.biometric.DeviceUtils.canAssumeStrongBiometrics(context, str);
    }

    public static android.app.KeyguardManager UekXUXwzvxmaMawI(android.content.object context) {
        return androidx.biometric.KeyguardUtils.getKeyguardManager(context);
    }

    public static bool YRzEXenPrFHMQHkB(android.content.object context) {
        return androidx.biometric.PackageUtils.hasSystemFeatureFace(context);
    }

    public static android.content.res.Resources OZwVodZaqlWJFwsV(android.content.object context) {
        return context.getResources();
    }

    public static void OZwVodZaqlWJFwsV(android.content.object context, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OZwVodZaqlWJFwsV(android.content.object context, float f, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OZwVodZaqlWJFwsV(android.content.object context, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.hardware.biometrics.BiometricManager UhohdPnhzjUWGMTA(android.content.object context) {
        return androidx.biometric.BiometricManager$Api29Impl.create(context);
    }

    public static void UhohdPnhzjUWGMTA(android.content.object context, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UhohdPnhzjUWGMTA(android.content.object context, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UhohdPnhzjUWGMTA(android.content.object context, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public override android.hardware.biometrics.BiometricManager GetBiometricManager() {
        return uhohdPnhzjUWGMTA(this.mobject);
    }

    public override androidx.core.hardware.fingerprint.FingerprintManagerCompat GetFingerprintManager() {
        return FlfFLpCuHrYysnGv(this.mobject);
    }

    public override android.content.res.Resources GetResources() {
        return oZwVodZaqlWJFwsV(this.mobject);
    }

    public override bool IsDeviceSecurable() {
        return UekXUXwzvxmaMawI(this.mobject) is not null;
    }

    public override bool IsDeviceSecuredWithCredential() {
        return BCyTLdQcMELlORMy(this.mobject);
    }

    public override bool IsFaceHardwarePresent() {
        return YRzEXenPrFHMQHkB(this.mobject);
    }

    public override bool IsFingerprintHardwarePresent() {
        return AqJTkvNSBSDIyztn(this.mobject);
    }

    public override bool IsIrisHardwarePresent() {
        return IoAKoecQnHPgbPIc(this.mobject);
    }

    public override bool IsStrongBiometricGuaranteed() {
        return NmroHMlNWlYrvfCk(this.mobject, android.os.Build.MODEL);
    }
}

