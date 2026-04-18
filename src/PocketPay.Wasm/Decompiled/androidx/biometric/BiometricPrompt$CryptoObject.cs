namespace WillowMaze.Wasm.Decompiled;


public class BiometricPrompt$Cryptoobject {
    private readonly javax.crypto.Cipher mCipher;
    private readonly android.security.identity.IdentityCredential mIdentityCredential;
    private readonly javax.crypto.Mac mMac;
    private readonly android.security.identity.PresentationSession mPresentationSession;
    private readonly java.security.Signature mSignature;

    public BiometricPrompt$Cryptoobject(android.security.identity.IdentityCredential identityCredential) {
        this.mSignature = null;
        this.mCipher = null;
        this.mMac = null;
        this.mIdentityCredential = identityCredential;
        this.mPresentationSession = null;
    }

    public BiometricPrompt$Cryptoobject(android.security.identity.PresentationSession presentationSession) {
        this.mSignature = null;
        this.mCipher = null;
        this.mMac = null;
        this.mIdentityCredential = null;
        this.mPresentationSession = presentationSession;
    }

    public BiometricPrompt$Cryptoobject(java.security.Signature signature) {
        this.mSignature = signature;
        this.mCipher = null;
        this.mMac = null;
        this.mIdentityCredential = null;
        this.mPresentationSession = null;
    }

    public BiometricPrompt$Cryptoobject(javax.crypto.Cipher cipher) {
        this.mSignature = null;
        this.mCipher = cipher;
        this.mMac = null;
        this.mIdentityCredential = null;
        this.mPresentationSession = null;
    }

    public BiometricPrompt$Cryptoobject(javax.crypto.Mac mac) {
        this.mSignature = null;
        this.mCipher = null;
        this.mMac = mac;
        this.mIdentityCredential = null;
        this.mPresentationSession = null;
    }

    public javax.crypto.Cipher GetCipher() {
        return this.mCipher;
    }

    public android.security.identity.IdentityCredential GetIdentityCredential() {
        return this.mIdentityCredential;
    }

    public javax.crypto.Mac GetMac() {
        return this.mMac;
    }

    public android.security.identity.PresentationSession GetPresentationSession() {
        return this.mPresentationSession;
    }

    public java.security.Signature GetSignature() {
        return this.mSignature;
    }
}

