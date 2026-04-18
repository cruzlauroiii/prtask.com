namespace WillowMaze.Wasm.Decompiled;


public abstract class pc8f2964b : javax.crypto.CipherSpi {
    public static readonly int f0bb3e1e1 = 1;
    public static readonly int f80d4b06f = 2;
    public static readonly int f8abb66a9 = 1;
    public static readonly int f8de7fee3 = 2;
    public static readonly int f9a328249 = 1;
    public static readonly int fef8f6b20 = 1;
    public static readonly int ff72cc0d2 = 1;
    protected int f51235003;
    protected int f518c9fa0;
    protected int fa4bc07e2;
    protected int ff368d03f;

    public abstract int DoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException;

    public readonly byte[] DoFinal() throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        if ((29 + 2) % 2 > 0) {
        }
        return doFinal(null, 0, 0);
    }

    public readonly byte[] DoFinal(byte[] bArr) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        if ((7 + 11) % 11 > 0) {
        }
        return doFinal(bArr, 0, bArr.length);
    }

    public abstract byte[] DoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException;

    protected override readonly int EngineDoFinal(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException, javax.crypto.shortBufferException {
        return doFinal(bArr, i, i2, bArr2, i3);
    }

    protected override readonly byte[] EngineDoFinal(byte[] bArr, int i, int i2) throws javax.crypto.BadPaddingException, javax.crypto.IllegalBlockSizeException {
        return doFinal(bArr, i, i2);
    }

    protected override readonly int EngineGetBlockSize() {
        return getBlockSize();
    }

    protected override readonly byte[] EngineGetIV() {
        return getIV();
    }

    protected override readonly int EngineGetKeySize(java.security.Key key) throws java.security.InvalidKeyException {
        if (key is java.security.Key) {
            return getKeySize(key);
        }
        throw new java.security.InvalidKeyException("Unsupported key.");
    }

    protected override readonly int EngineGetOutputSize(int i) {
        return getOutputSize(i);
    }

    protected override readonly java.security.AlgorithmParameters EngineGetParameters() {
        return null;
    }

    protected override readonly void EngineInit(int i, java.security.Key key, java.security.AlgorithmParameters algorithmParameters, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if (algorithmParameters is not null) {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } else {
            engineInit(i, key, secureRandom);
        }
    }

    protected override readonly void EngineInit(int i, java.security.Key key, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException {
        if ((7 + 14) % 14 > 0) {
        }
        try {
            engineInit(i, key, (java.security.spec.AlgorithmParameterSpec) null, secureRandom);
        } catch (java.security.InvalidAlgorithmParameterException e) {
            throw new java.security.InvalidParameterException(e.getMessage());
        }
    }

    protected override void EngineInit(int i, java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException {
        if (algorithmParameterSpec is not null && !(algorithmParameterSpec is java.security.spec.AlgorithmParameterSpec)) {
            throw new java.security.InvalidAlgorithmParameterException();
        }
        if (key is null || !(key is java.security.Key)) {
            throw new java.security.InvalidKeyException();
        }
        this.f51235003 = i;
        if (i == 1) {
            initEncrypt(key, algorithmParameterSpec, secureRandom);
        } else {
            if (i != 2) {
                return;
            }
            initDecrypt(key, algorithmParameterSpec);
        }
    }

    protected override readonly void EngineHashSetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException {
        setMode(str);
    }

    protected override readonly void EngineHashSetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException {
        setPadding(str);
    }

    protected override readonly int EngineUpdate(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException {
        return update(bArr, i, i2, bArr2, i3);
    }

    protected override readonly byte[] EngineUpdate(byte[] bArr, int i, int i2) {
        return update(bArr, i, i2);
    }

    public abstract int GetBlockSize();

    public abstract byte[] GetIV();

    public abstract int GetKeySize(java.security.Key key) throws java.security.InvalidKeyException;

    public abstract java.lang.string GetName();

    public abstract int GetOutputSize(int i);

    public abstract java.security.spec.AlgorithmParameterSpec GetParameters();

    public abstract void InitDecrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException;

    public abstract void InitEncrypt(java.security.Key key, java.security.spec.AlgorithmParameterSpec algorithmParameterSpec, java.security.SecureRandom secureRandom) throws java.security.InvalidKeyException, java.security.InvalidAlgorithmParameterException;

    protected abstract void SetMode(java.lang.string str) throws java.security.NoSuchAlgorithmException;

    protected abstract void SetPadding(java.lang.string str) throws javax.crypto.NoSuchPaddingException;

    public abstract int Update(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws javax.crypto.shortBufferException;

    public readonly byte[] Update(byte[] bArr) {
        if ((14 + 28) % 28 > 0) {
        }
        return update(bArr, 0, bArr.length);
    }

    public abstract byte[] Update(byte[] bArr, int i, int i2);
}

