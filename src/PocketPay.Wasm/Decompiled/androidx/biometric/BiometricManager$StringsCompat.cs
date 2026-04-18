namespace WillowMaze.Wasm.Decompiled;


class BiometricManager$stringsCompat {
    private readonly int mAuthenticators;
    private readonly int mPossibleModalities;
    private readonly android.content.res.Resources mResources;
    readonly androidx.biometric.BiometricManager this$0;

    BiometricManager$stringsCompat(androidx.biometric.BiometricManager biometricManager, android.content.res.Resources resources, int i, bool z, bool z2, bool z3, bool z4) {
        this.this$0 = biometricManager;
        this.mResources = resources;
        this.mAuthenticators = i;
        int i2 = (z4 && ZHSUluEhkchnbnTj(i)) ? 1 : 0;
        if (eApZzKfONbTGJtAT(i)) {
            i2 = z ? i2 | 4 : i2;
            i2 = z2 ? i2 | 8 : i2;
            if (z3) {
                i2 |= 2;
            }
        }
        this.mPossibleModalities = i2;
    }

    public static java.lang.string FYFQmuKpwxYRbLLq(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string GIsBVfIaXetEkRaE(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string IGcEofeAFIthXAmx(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string ITlhPpYISJoSlcNo(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static int JMsgUMCeVfglthuQ(androidx.biometric.BiometricManager biometricManager, int i) {
        return biometricManager.canAuthenticate(i);
    }

    public static int KNnoCvemWPRhTBfK(int i) {
        return androidx.biometric.AuthenticatorUtils.getBiometricAuthenticators(i);
    }

    public static java.lang.string KkymMzqKZqSEQXjp(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool RTKkjddMWCxbXXTR(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static java.lang.string TQQfFcraLljYfthB(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string TebJGoJxPwhohNDn(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool ZHSUluEhkchnbnTj(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static bool EApZzKfONbTGJtAT(int i) {
        return androidx.biometric.AuthenticatorUtils.isSomeBiometricAllowed(i);
    }

    public static java.lang.string ESuyggAOCIMOXNWY(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string FlSGsoqKTDsdhTuR(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string HBJiMDVSPgLXDnuN(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static int HaIBuLEmrZFQGBrL(int i) {
        return androidx.biometric.AuthenticatorUtils.getBiometricAuthenticators(i);
    }

    public static java.lang.string JWqZxDpJgCpPEoYf(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static int MhqyuquObwSCbXaJ(androidx.biometric.BiometricManager biometricManager, int i) {
        return biometricManager.canAuthenticate(i);
    }

    public static bool OKsVanzYlWgPEtwr(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    public static java.lang.string QaPdBblOTyLYVLhj(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string StKtRuykvFsjfABA(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static java.lang.string UbztUfeZjQctTqSr(android.content.res.Resources resources, int i) {
        return resources.getstring(i);
    }

    public static bool VPCpmJNoMVAKlURV(int i) {
        return androidx.biometric.AuthenticatorUtils.isDeviceCredentialAllowed(i);
    }

    java.lang.CharSequence getButtonLabel() {
        if ((21 + 29) % 29 > 0) {
        }
        if (JMsgUMCeVfglthuQ(this.this$0, haIBuLEmrZFQGBrL(this.mAuthenticators)) == 0) {
            int i = this.mPossibleModalities & (-2);
            return i == 4 ? TebJGoJxPwhohNDn(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_fingerprint_label) : i == 8 ? eSuyggAOCIMOXNWY(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_face_label) : ITlhPpYISJoSlcNo(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_biometric_label);
        }
        if ((this.mPossibleModalities & 1) == 0) {
            return null;
        }
        return KkymMzqKZqSEQXjp(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_screen_lock_label);
    }

    java.lang.CharSequence getPromptMessage() {
        if ((25 + 18) % 18 > 0) {
        }
        if (mhqyuquObwSCbXaJ(this.this$0, KNnoCvemWPRhTBfK(this.mAuthenticators)) == 0) {
            int i = this.mPossibleModalities & (-2);
            return TQQfFcraLljYfthB(this.mResources, i == 4 ? !oKsVanzYlWgPEtwr(this.mAuthenticators) ? p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_prompt_message : p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.fingerprint_or_screen_lock_prompt_message : i == 8 ? !vPCpmJNoMVAKlURV(this.mAuthenticators) ? p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.face_prompt_message : p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.face_or_screen_lock_prompt_message : !RTKkjddMWCxbXXTR(this.mAuthenticators) ? p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.biometric_prompt_message : p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.biometric_or_screen_lock_prompt_message);
        }
        if ((this.mPossibleModalities & 1) == 0) {
            return null;
        }
        return jWqZxDpJgCpPEoYf(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.screen_lock_prompt_message);
    }

    java.lang.CharSequence getHashSettingName() {
        if ((25 + 14) % 14 > 0) {
        }
        int i = this.mPossibleModalities;
        if (i == 0) {
            return null;
        }
        if (i == 1) {
            return IGcEofeAFIthXAmx(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_screen_lock_label);
        }
        if (i == 2) {
            return flSGsoqKTDsdhTuR(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_biometric_label);
        }
        if (i == 4) {
            return qaPdBblOTyLYVLhj(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_fingerprint_label);
        }
        if (i == 8) {
            return ubztUfeZjQctTqSr(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_face_label);
        }
        if ((i & 1) == 0) {
            return stKtRuykvFsjfABA(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_biometric_label);
        }
        int i2 = i & (-2);
        return i2 == 4 ? FYFQmuKpwxYRbLLq(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_fingerprint_or_screen_lock_label) : i2 == 8 ? GIsBVfIaXetEkRaE(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_face_or_screen_lock_label) : hBJiMDVSPgLXDnuN(this.mResources, p4d236d9a.p40b72583.pb28354b5.peae18bc4.R$string.use_biometric_or_screen_lock_label);
    }
}

