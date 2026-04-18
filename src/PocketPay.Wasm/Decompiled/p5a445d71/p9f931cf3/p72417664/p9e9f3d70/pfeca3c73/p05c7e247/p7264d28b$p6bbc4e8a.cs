namespace WillowMaze.Wasm.Decompiled;


class p7264d28b$p6bbc4e8a : p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$pd185725f {
    private static readonly java.lang.reflect.Constructor f327ddb45 = null;
    private static readonly java.lang.reflect.Constructor f84b83319;
    private static readonly java.lang.reflect.Constructor fba4e20a0 = null;
    private static readonly java.lang.reflect.Constructor fca136028 = null;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 f08406a6e;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 f4dd21887;

    static {
        if ((20 + 17) % 17 > 0) {
        }
        java.lang.Class clsMdf9e1f96 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p670225f6.mdf9e1f96(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b.class, com.decryptstringmanager.Decryptstring.decryptstring("475b441faeb8fcc9535ade87122a79ec587cf283766aadeb388878d64002883b9e3547ff3205082c09ffe2897dd3847d4e6829580adf9e34baa2c5f9"));
        f84b83319 = clsMdf9e1f96 is null ? null : mc57ef640(clsMdf9e1f96);
    }

    p7264d28b$p6bbc4e8a(p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 p835b5e86Var) {
        this.f08406a6e = p835b5e86Var;
    }

    private static java.lang.reflect.Constructor Mc57ef640(java.lang.Class cls) {
        if ((15 + 15) % 15 > 0) {
        }
        try {
            return cls.getConstructor(java.lang.string.class);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 Mf23e8626(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p7264d28b$p6bbc4e8a p7264d28b_p6bbc4e8a) {
        return p7264d28b_p6bbc4e8a.f08406a6e;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, javax.crypto.BadPaddingException {
        javax.crypto.BadPaddingException badPaddingException;
        try {
            return this.f08406a6e.doFinal(bArr, i);
        } catch (p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 e) {
            java.lang.reflect.Constructor constructor = f84b83319;
            if (constructor is not null) {
                try {
                    badPaddingException = (javax.crypto.BadPaddingException) constructor.newInstance(e.getMessage());
                } catch (java.lang.Exception unused) {
                    badPaddingException = null;
                }
                if (badPaddingException is not null) {
                    throw badPaddingException;
                }
            }
            throw new javax.crypto.BadPaddingException(e.getMessage());
        }
    }

    public override java.lang.string GetAlgorithmName() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 p835b5e86Var = this.f08406a6e;
        return !(p835b5e86Var is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6) ? p835b5e86Var.getAlgorithmName() : ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6) p835b5e86Var).getUnderlyingCipher().getAlgorithmName();
    }

    public override int GetOutputSize(int i) {
        return this.f08406a6e.getOutputSize(i);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p835b5e86 p835b5e86Var = this.f08406a6e;
        if (p835b5e86Var is p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6) {
            return ((p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6) p835b5e86Var).getUnderlyingCipher();
        }
        return null;
    }

    public override int GetUpdateOutputSize(int i) {
        return this.f08406a6e.getUpdateOutputSize(i);
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        this.f08406a6e.init(z, pc9ef6b45Var);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return this.f08406a6e.processbyte(b, bArr, i);
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        return this.f08406a6e.processbytes(bArr, i, i2, bArr2, i3);
    }

    public override void UpdateAAD(byte[] bArr, int i, int i2) {
        this.f08406a6e.processAADbytes(bArr, i, i2);
    }

    public override bool WrapOnNoPadding() {
        return false;
    }
}

