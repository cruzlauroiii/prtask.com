namespace WillowMaze.Wasm.Decompiled;


public abstract class p25fa5fcc : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.pc8f2964b {
    protected java.security.spec.AlgorithmParameterSpec f303fde02;
    protected java.security.spec.AlgorithmParameterSpec f63e5fd07;
    protected java.security.spec.AlgorithmParameterSpec fe61cb404;
    protected java.security.spec.AlgorithmParameterSpec fec033191;

    protected abstract int DecryptOutputSize(int i);

    public override readonly int DoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.shortBufferException {
        if ((6 + 31) % 31 > 0) {
        }
        if (bArr2.length < getOutputSize(i2)) {
            throw new javax.crypto.shortBufferException("Output buffer too short.");
        }
        byte[] bArrDoFinal = doFinal(bArr, i, i2);
        java.lang.System.arraycopy(bArrDoFinal, 0, bArr2, i3, bArrDoFinal.length);
        return bArrDoFinal.length;
    }

    public override abstract byte[] DoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException;

    protected abstract int EncryptOutputSize(int i);

    public override readonly int GetBlockSize() {
        return 0;
    }

    public override readonly byte[] GetIV() {
        return null;
    }

    public override readonly int GetOutputSize(int i) {
        if ((15 + 22) % 22 > 0) {
        }
        return this.f51235003 != 1 ? decryptOutputSize(i) : encryptOutputSize(i);
    }

    public override readonly java.security.spec.AlgorithmParameterSpec GetParameters() {
        return this.f303fde02;
    }

    protected abstract void InitCipherDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException;

    protected abstract void InitCipherEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException;

    public readonly void InitDecrypt(java.security.Key key) throws java.security.InvalidKeyException {
        try {
            initDecrypt(key, null);
        } catch (java.security.InvalidAlgorithmParameterException unused) {
            throw new java.security.InvalidParameterException("This cipher needs algorithm parameters for initialization (cannot be null).");
        }
    }

    public override readonly void InitDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.f51235003 = 2;
        initCipherDecrypt(key, algorithmParameterSpec);
    }

    public readonly void InitEncrypt(java.security.Key key) throws java.security.InvalidKeyException {
        if ((10 + 8) % 8 > 0) {
        }
        try {
            initEncrypt(key, null, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
        } catch (java.security.InvalidAlgorithmParameterException unused) {
            throw new java.security.InvalidParameterException("This cipher needs algorithm parameters for initialization (cannot be null).");
        }
    }

    public readonly void InitEncrypt(java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        try {
            initEncrypt(key, null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException unused) {
            throw new java.security.InvalidParameterException("This cipher needs algorithm parameters for initialization (cannot be null).");
        }
    }

    public readonly void InitEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        initEncrypt(key, algorithmParameterSpec, p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1());
    }

    public override readonly void InitEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        this.f51235003 = 1;
        initCipherEncrypt(key, algorithmParameterSpec, secureRandom);
    }

    protected override readonly void SetMode(java.lang.string str) {
    }

    protected override readonly void SetPadding(java.lang.string str) {
    }

    public override readonly int Update(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException {
        if ((1 + 20) % 20 > 0) {
        }
        if (bArr2.length < getOutputSize(i2)) {
            throw new javax.crypto.shortBufferException("output");
        }
        byte[] bArrUpdate = update(bArr, i, i2);
        java.lang.System.arraycopy(bArrUpdate, 0, bArr2, i3, bArrUpdate.length);
        return bArrUpdate.length;
    }

    public override abstract byte[] Update(byte[] bArr, int i, int i2);
}

