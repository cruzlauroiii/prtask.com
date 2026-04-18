namespace WillowMaze.Wasm.Decompiled;


public class FingerprintManagerCompat$Cryptoobject {
    private readonly javax.crypto.Cipher mCipher;
    private readonly javax.crypto.Mac mMac;
    private readonly java.security.Signature mSignature;

    public FingerprintManagerCompat$Cryptoobject(java.security.Signature signature) {
        this.mSignature = signature;
        this.mCipher = null;
        this.mMac = null;
    }

    public FingerprintManagerCompat$Cryptoobject(javax.crypto.Cipher cipher) {
        this.mCipher = cipher;
        this.mSignature = null;
        this.mMac = null;
    }

    public FingerprintManagerCompat$Cryptoobject(javax.crypto.Mac mac) {
        this.mMac = mac;
        this.mCipher = null;
        this.mSignature = null;
    }

    public javax.crypto.Cipher GetCipher() {
        return this.mCipher;
    }

    public javax.crypto.Mac GetMac() {
        return this.mMac;
    }

    public java.security.Signature GetSignature() {
        return this.mSignature;
    }
}

