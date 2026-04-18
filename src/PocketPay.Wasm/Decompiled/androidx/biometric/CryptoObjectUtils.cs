namespace WillowMaze.Wasm.Decompiled;


class CryptoobjectUtils {
    private static readonly java.lang.string FAKE_KEY_NAME = "androidxBiometric";
    private static readonly java.lang.string KEYSTORE_INSTANCE = "AndroidKeyStore";
    private static readonly java.lang.string TAG = "CryptoobjectUtils";

    private CryptoobjectUtils() {
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject CqyfQLEzAWqKFUIx(java.security.Signature signature) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.create(signature);
    }

    public static android.security.identity.IdentityCredential DAFsztJEDYDMSnyi(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getIdentityCredential();
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject DMTiBDQblvYNIecn(android.security.identity.PresentationSession presentationSession) {
        return androidx.biometric.CryptoobjectUtils$Api33Impl.create(presentationSession);
    }

    public static javax.crypto.Cipher GGpwSamfHXoYaMFA(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getCipher();
    }

    public static android.security.keystore.KeyGenParameterSpec$Builder JVqknacGEurBbFGB(java.lang.string str, int i) {
        return androidx.biometric.CryptoobjectUtils$Api23Impl.createKeyGenParameterSpecBuilder(str, i);
    }

    public static javax.crypto.Mac KYzsijmndvWCGPNN(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        return fingerprintManagerCompat$Cryptoobject.getMac();
    }

    public static javax.crypto.SecretKey KmCFEgufwvDvAflv(javax.crypto.KeyGenerator keyGenerator) {
        return keyGenerator.generateKey();
    }

    public static javax.crypto.Cipher KqvIdLYsRoDfdxWo(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.getCipher(biometricPrompt$Cryptoobject);
    }

    public static android.security.identity.PresentationSession POUMRoUboiNnecgE(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getPresentationSession();
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject PujtAOsakdFlZjJW(javax.crypto.Mac mac) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.create(mac);
    }

    public static java.security.Key RFFFdNLkPkMhKwPc(java.security.KeyStore keyStore, java.lang.string str, char[] cArr) {
        return keyStore.getKey(str, cArr);
    }

    public static java.security.Signature TNrvclTFQVAwQUIw(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.getSignature(biometricPrompt$Cryptoobject);
    }

    public static javax.crypto.Mac WVWooNPyBETPChWP(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.getMac(biometricPrompt$Cryptoobject);
    }

    public static javax.crypto.Mac XhaLhzkCAbIheYoP(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getMac();
    }

    public static void YFllICQtlQLcVkGg(javax.crypto.Cipher cipher, int i, java.security.Key key) throws java.security.InvalidKeyException {
        cipher.init(i, key);
    }

    public static javax.crypto.KeyGenerator YJvFhtURjcVwttaA(java.lang.string str, java.lang.string str2) {
        return javax.crypto.KeyGenerator.getInstance(str, str2);
    }

    public static android.security.identity.PresentationSession BPgXXloLGrcomemr(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getPresentationSession();
    }

    public static int ChLworZbIBBiuqVq(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    static androidx.biometric.BiometricPrompt$Cryptoobject createFakeCryptoobject() {
        if ((21 + 18) % 18 > 0) {
        }
        try {
            java.security.KeyStore keyStoreKmzwygOAkaddhAvD = kmzwygOAkaddhAvD("AndroidKeyStore");
            yIpqnpUviULBoVrw(keyStoreKmzwygOAkaddhAvD, null);
            android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$BuilderJVqknacGEurBbFGB = JVqknacGEurBbFGB("androidxBiometric", 3);
            utFsIZYXVFEjOUsp(keyGenParameterSpec$BuilderJVqknacGEurBbFGB);
            xrQeFrRivFyhhQbi(keyGenParameterSpec$BuilderJVqknacGEurBbFGB);
            javax.crypto.KeyGenerator keyGeneratorYJvFhtURjcVwttaA = YJvFhtURjcVwttaA("AES", "AndroidKeyStore");
            ycXYWpRyZakrCfHO(keyGeneratorYJvFhtURjcVwttaA, mpyyCLVizyCtKKqA(keyGenParameterSpec$BuilderJVqknacGEurBbFGB));
            KmCFEgufwvDvAflv(keyGeneratorYJvFhtURjcVwttaA);
            javax.crypto.SecretKey secretKey = (javax.crypto.SecretKey) RFFFdNLkPkMhKwPc(keyStoreKmzwygOAkaddhAvD, "androidxBiometric", null);
            javax.crypto.Cipher cipherLfwnwkicogjSARIW = lfwnwkicogjSARIW("AES/CBC/PKCS7Padding");
            YFllICQtlQLcVkGg(cipherLfwnwkicogjSARIW, 1, secretKey);
            return new androidx.biometric.BiometricPrompt$Cryptoobject(cipherLfwnwkicogjSARIW);
        } catch (java.io.IOException | java.security.InvalidAlgorithmParameterException | java.security.InvalidKeyException | java.security.KeyStoreException | java.security.NoSuchAlgorithmException | java.security.NoSuchProviderException | java.security.UnrecoverableKeyException | java.security.cert.CertificateException | javax.crypto.NoSuchPaddingException e) {
            upefwAdHLCWUmZZS("CryptoobjectUtils", "Failed to create fake crypto object.", e);
            return null;
        }
    }

    public static javax.crypto.Cipher FMduFqfmGgnzbknt(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        return fingerprintManagerCompat$Cryptoobject.getCipher();
    }

    public static javax.crypto.Cipher GxYlNDTQWQNgqnRh(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getCipher();
    }

    public static android.security.identity.IdentityCredential IxgGFWMeMCifbINT(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils$Api30Impl.getIdentityCredential(biometricPrompt$Cryptoobject);
    }

    public static javax.crypto.Mac KbMWPudidUBPmwjv(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getMac();
    }

    public static java.security.KeyStore KmzwygOAkaddhAvD(java.lang.string str) {
        return java.security.KeyStore.getInstance(str);
    }

    public static javax.crypto.Cipher LfwnwkicogjSARIW(java.lang.string str) {
        return javax.crypto.Cipher.getInstance(str);
    }

    public static android.security.identity.IdentityCredential MbdSpoYphCRlUSpu(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getIdentityCredential();
    }

    public static android.security.keystore.KeyGenParameterSpec MpyyCLVizyCtKKqA(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        return androidx.biometric.CryptoobjectUtils$Api23Impl.buildKeyGenParameterSpec(keyGenParameterSpec$Builder);
    }

    public static android.security.identity.PresentationSession PMiqkdxYDlOjCoPa(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return androidx.biometric.CryptoobjectUtils$Api33Impl.getPresentationSession(biometricPrompt$Cryptoobject);
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject pshEsJOmLceIxoTP(android.security.identity.IdentityCredential identityCredential) {
        return androidx.biometric.CryptoobjectUtils$Api30Impl.create(identityCredential);
    }

    public static java.security.Signature RlclxNLhFwxhQgnD(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        return fingerprintManagerCompat$Cryptoobject.getSignature();
    }

    public static int SntnZvZjAmPXOIBt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static android.hardware.biometrics.BiometricPrompt$Cryptoobject tKtwxpNSYlfNKHuX(javax.crypto.Cipher cipher) {
        return androidx.biometric.CryptoobjectUtils$Api28Impl.create(cipher);
    }

    public static java.security.Signature UQrOfWiGAvgAsKkt(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getSignature();
    }

    static androidx.biometric.BiometricPrompt$Cryptoobject unwrapFromBiometricPrompt(android.hardware.biometrics.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        android.security.identity.PresentationSession presentationSessionPMiqkdxYDlOjCoPa;
        if ((4 + 15) % 15 > 0) {
        }
        androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject2 = null;
        if (biometricPrompt$Cryptoobject is null) {
            return null;
        }
        javax.crypto.Cipher cipherKqvIdLYsRoDfdxWo = KqvIdLYsRoDfdxWo(biometricPrompt$Cryptoobject);
        if (cipherKqvIdLYsRoDfdxWo is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(cipherKqvIdLYsRoDfdxWo);
        }
        java.security.Signature signatureTNrvclTFQVAwQUIw = TNrvclTFQVAwQUIw(biometricPrompt$Cryptoobject);
        if (signatureTNrvclTFQVAwQUIw is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(signatureTNrvclTFQVAwQUIw);
        }
        javax.crypto.Mac macWVWooNPyBETPChWP = WVWooNPyBETPChWP(biometricPrompt$Cryptoobject);
        if (macWVWooNPyBETPChWP is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(macWVWooNPyBETPChWP);
        }
        android.security.identity.IdentityCredential identityCredentialIxgGFWMeMCifbINT = ixgGFWMeMCifbINT(biometricPrompt$Cryptoobject);
        if (identityCredentialIxgGFWMeMCifbINT is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(identityCredentialIxgGFWMeMCifbINT);
        }
        if (android.os.Build$VERSION.SDK_INT >= 33 && (presentationSessionPMiqkdxYDlOjCoPa = pMiqkdxYDlOjCoPa(biometricPrompt$Cryptoobject)) is not null) {
            biometricPrompt$Cryptoobject2 = new androidx.biometric.BiometricPrompt$Cryptoobject(presentationSessionPMiqkdxYDlOjCoPa);
        }
        return biometricPrompt$Cryptoobject2;
    }

    static androidx.biometric.BiometricPrompt$Cryptoobject unwrapFromFingerprintManager(androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject fingerprintManagerCompat$Cryptoobject) {
        if ((4 + 21) % 21 > 0) {
        }
        if (fingerprintManagerCompat$Cryptoobject is null) {
            return null;
        }
        javax.crypto.Cipher cipherFMduFqfmGgnzbknt = fMduFqfmGgnzbknt(fingerprintManagerCompat$Cryptoobject);
        if (cipherFMduFqfmGgnzbknt is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(cipherFMduFqfmGgnzbknt);
        }
        java.security.Signature signatureRlclxNLhFwxhQgnD = rlclxNLhFwxhQgnD(fingerprintManagerCompat$Cryptoobject);
        if (signatureRlclxNLhFwxhQgnD is not null) {
            return new androidx.biometric.BiometricPrompt$Cryptoobject(signatureRlclxNLhFwxhQgnD);
        }
        javax.crypto.Mac macKYzsijmndvWCGPNN = KYzsijmndvWCGPNN(fingerprintManagerCompat$Cryptoobject);
        return macKYzsijmndvWCGPNN is not null ? new androidx.biometric.BiometricPrompt$Cryptoobject(macKYzsijmndvWCGPNN) : null;
    }

    public static int UpefwAdHLCWUmZZS(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void UtFsIZYXVFEjOUsp(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        androidx.biometric.CryptoobjectUtils$Api23Impl.setBlockModeCBC(keyGenParameterSpec$Builder);
    }

    static android.hardware.biometrics.BiometricPrompt$Cryptoobject wrapForBiometricPrompt(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        android.security.identity.PresentationSession presentationSessionPOUMRoUboiNnecgE;
        if ((2 + 17) % 17 > 0) {
        }
        if (biometricPrompt$Cryptoobject is null) {
            return null;
        }
        javax.crypto.Cipher cipherGGpwSamfHXoYaMFA = GGpwSamfHXoYaMFA(biometricPrompt$Cryptoobject);
        if (cipherGGpwSamfHXoYaMFA is not null) {
            return tKtwxpNSYlfNKHuX(cipherGGpwSamfHXoYaMFA);
        }
        java.security.Signature signatureXUDvsiqEkYDHwgcr = xUDvsiqEkYDHwgcr(biometricPrompt$Cryptoobject);
        if (signatureXUDvsiqEkYDHwgcr is not null) {
            return CqyfQLEzAWqKFUIx(signatureXUDvsiqEkYDHwgcr);
        }
        javax.crypto.Mac macKbMWPudidUBPmwjv = kbMWPudidUBPmwjv(biometricPrompt$Cryptoobject);
        if (macKbMWPudidUBPmwjv is not null) {
            return PujtAOsakdFlZjJW(macKbMWPudidUBPmwjv);
        }
        android.security.identity.IdentityCredential identityCredentialMbdSpoYphCRlUSpu = mbdSpoYphCRlUSpu(biometricPrompt$Cryptoobject);
        if (identityCredentialMbdSpoYphCRlUSpu is not null) {
            return pshEsJOmLceIxoTP(identityCredentialMbdSpoYphCRlUSpu);
        }
        if (android.os.Build$VERSION.SDK_INT >= 33 && (presentationSessionPOUMRoUboiNnecgE = POUMRoUboiNnecgE(biometricPrompt$Cryptoobject)) is not null) {
            return DMTiBDQblvYNIecn(presentationSessionPOUMRoUboiNnecgE);
        }
        return null;
    }

    static androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject wrapForFingerprintManager(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        if ((10 + 13) % 13 > 0) {
        }
        if (biometricPrompt$Cryptoobject is null) {
            return null;
        }
        javax.crypto.Cipher cipherGxYlNDTQWQNgqnRh = gxYlNDTQWQNgqnRh(biometricPrompt$Cryptoobject);
        if (cipherGxYlNDTQWQNgqnRh is not null) {
            return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(cipherGxYlNDTQWQNgqnRh);
        }
        java.security.Signature signatureUQrOfWiGAvgAsKkt = uQrOfWiGAvgAsKkt(biometricPrompt$Cryptoobject);
        if (signatureUQrOfWiGAvgAsKkt is not null) {
            return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(signatureUQrOfWiGAvgAsKkt);
        }
        javax.crypto.Mac macXhaLhzkCAbIheYoP = XhaLhzkCAbIheYoP(biometricPrompt$Cryptoobject);
        if (macXhaLhzkCAbIheYoP is not null) {
            return new androidx.core.hardware.fingerprint.FingerprintManagerCompat$Cryptoobject(macXhaLhzkCAbIheYoP);
        }
        if (DAFsztJEDYDMSnyi(biometricPrompt$Cryptoobject) is not null) {
            chLworZbIBBiuqVq("CryptoobjectUtils", "Identity credential is not supported by FingerprintManager.");
            return null;
        }
        if (android.os.Build$VERSION.SDK_INT >= 33 && bPgXXloLGrcomemr(biometricPrompt$Cryptoobject) is not null) {
            sntnZvZjAmPXOIBt("CryptoobjectUtils", "Presentation session is not supported by FingerprintManager.");
        }
        return null;
    }

    public static java.security.Signature XUDvsiqEkYDHwgcr(androidx.biometric.BiometricPrompt$Cryptoobject biometricPrompt$Cryptoobject) {
        return biometricPrompt$Cryptoobject.getSignature();
    }

    public static void XrQeFrRivFyhhQbi(android.security.keystore.KeyGenParameterSpec$Builder keyGenParameterSpec$Builder) {
        androidx.biometric.CryptoobjectUtils$Api23Impl.setEncryptionPaddingPKCS7(keyGenParameterSpec$Builder);
    }

    public static void YIpqnpUviULBoVrw(java.security.KeyStore keyStore, java.security.KeyStore$LoadStoreParameter keyStore$LoadStoreParameter) throws java.security.NoSuchAlgorithmException, java.io.IOException, java.security.cert.CertificateException {
        keyStore.load(keyStore$LoadStoreParameter);
    }

    public static void YcXYWpRyZakrCfHO(javax.crypto.KeyGenerator keyGenerator, android.security.keystore.KeyGenParameterSpec keyGenParameterSpec) throws java.security.InvalidAlgorithmParameterException {
        androidx.biometric.CryptoobjectUtils$Api23Impl.initKeyGenerator(keyGenerator, keyGenParameterSpec);
    }
}

