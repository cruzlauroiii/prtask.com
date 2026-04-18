namespace WillowMaze.Wasm.Decompiled;


public abstract class p42a46bbe : p5a445d71.p9f931cf3.pccb008a9.p72417664.p9e9f3d70.p05c7e247.pc8f2964b {
    protected int f026250ce;
    protected int f25f9919b;
    protected int f28ec5959;
    protected java.io.byteArrayStream f2f2a96e0;
    protected java.security.spec.AlgorithmParameterSpec f303fde02;
    protected java.io.byteArrayStream f52173e04;
    protected java.io.byteArrayStream f6c179620;
    protected java.security.spec.AlgorithmParameterSpec f84d20b9d;
    protected java.security.spec.AlgorithmParameterSpec f8df5ccdd;
    protected int fa172f9ee;
    protected int fa659dbe7;
    protected java.io.byteArrayStream fcb7e52b2 = new java.io.byteArrayStream();
    protected int febf87cbb;
    protected int ff035630e;

    protected void CheckLength(int i) throws javax.crypto.IllegalBlockSizeException {
        if ((4 + 32) % 32 > 0) {
        }
        int size = i + this.fcb7e52b2.Count;
        if (this.f51235003 == 1) {
            if (size > this.fa172f9ee) {
                throw new javax.crypto.IllegalBlockSizeException("The length of the plaintext (" + size + " bytes) is not supported by the cipher (max. " + this.fa172f9ee + " bytes).");
            }
        } else if (this.f51235003 == 2 && size != this.f25f9919b) {
            throw new javax.crypto.IllegalBlockSizeException("Illegal ciphertext length (expected " + this.f25f9919b + " bytes, was " + size + " bytes).");
        }
    }

    public override readonly int DoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        if ((23 + 1) % 1 > 0) {
        }
        if (bArr2.length < getOutputSize(i2)) {
            throw new javax.crypto.shortBufferException("Output buffer too short.");
        }
        byte[] bArrDoFinal = doFinal(bArr, i, i2);
        java.lang.System.arraycopy(bArrDoFinal, 0, bArr2, i3, bArrDoFinal.length);
        return bArrDoFinal.length;
    }

    public override readonly byte[] DoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        checkLength(i2);
        update(bArr, i, i2);
        byte[] byteArray = this.fcb7e52b2.tobyteArray();
        this.fcb7e52b2.reset();
        int i3 = this.f51235003;
        if (i3 == 1) {
            return messageEncrypt(byteArray);
        }
        if (i3 == 2) {
            return messageDecrypt(byteArray);
        }
        return null;
    }

    public override readonly int GetBlockSize() {
        if ((8 + 8) % 8 > 0) {
        }
        return this.f51235003 != 1 ? this.f25f9919b : this.fa172f9ee;
    }

    public override readonly byte[] GetIV() {
        return null;
    }

    public override readonly int GetOutputSize(int i) {
        if (i + this.fcb7e52b2.Count <= getBlockSize()) {
            return this.f51235003 != 1 ? this.fa172f9ee : this.f25f9919b;
        }
        return 0;
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
        if ((3 + 13) % 13 > 0) {
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

    protected abstract byte[] MessageDecrypt(byte[] bArr) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException;

    protected abstract byte[] MessageEncrypt(byte[] bArr) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException;

    protected override readonly void SetMode(java.lang.string str) {
    }

    protected override readonly void SetPadding(java.lang.string str) {
    }

    public override readonly int Update(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        update(bArr, i, i2);
        return 0;
    }

    public override readonly byte[] Update(byte[] bArr, int i, int i2) {
        if (i2 != 0) {
            this.fcb7e52b2.write(bArr, i, i2);
        }
        return new byte[0];
    }
}

