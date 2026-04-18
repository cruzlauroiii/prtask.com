namespace WillowMaze.Wasm.Decompiled;


public class pb4e47103 : p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe {
    public static readonly java.lang.string f0e448f1d = null;
    public static readonly java.lang.string f113bcd7d = null;
    public static readonly java.lang.string f78212729 = null;
    public static readonly java.lang.string f9abf22e6 = null;
    public static readonly java.lang.string fc7662efb = null;
    private static readonly int fcfdca198 = 10;
    private static readonly int ff03d3540 = 10;
    public static readonly java.lang.string ffa66f70c = null;
    private int f23db6d15;
    private bool f38fbdbe0;
    private byte[] f4ccb1142;
    private bool f4fc86bbc;
    private java.security.SecureRandom f5526994f;
    private byte[] f590389df;
    private bool f5ff72bef;
    private bool f60571fa9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe f6a9998d9;
    private bool f6ab47a2c;
    private int f6dc1b3a5;
    private java.security.SecureRandom f6fc10558;
    private java.security.SecureRandom f7ddf32e1;
    private java.security.SecureRandom f822986d8;
    private bool f838c67c7;
    private bool f9301aa9b;
    private byte[] f97d7a4b2;
    private int f98a22795;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe fad1943a9;
    private byte[] faf4c448b;
    private byte[] fc092f367;
    private bool fce94319e;
    private bool fd73b9286;
    private bool fd9871fbe;
    private int febfa548b;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe ff790bdcc;
    private bool ffe4c6cae;
    public static readonly java.lang.string f28e55e14 = com.decryptstringmanager.Decryptstring.decryptstring("6cccb51e981d798ae3f9b721f6f016c00ab9e9c257282d6944627bb16c3f166797a98039c05fdd1a07347cbf745f79b9c2cb5740a0c88a2631ccef583d");
    public static readonly java.lang.string fe57dbe97 = com.decryptstringmanager.Decryptstring.decryptstring("11955f17e014a7a6821964ef55c7fd190547eb8a902014183389cbaf9c851558e2ec1e37468edfc449a50b2a9a578dc32ff325843e896ec47b");

    public pb4e47103(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar) {
        this.f23db6d15 = -1;
        this.f4ccb1142 = null;
        this.fad1943a9 = p42a46bbeVar;
        this.ffe4c6cae = m07a61978();
    }

    public pb4e47103(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, int i) {
        this.f23db6d15 = -1;
        this.f4ccb1142 = null;
        this.fad1943a9 = p42a46bbeVar;
        this.ffe4c6cae = m07a61978();
        this.f23db6d15 = i;
    }

    public pb4e47103(p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe p42a46bbeVar, byte[] bArr) {
        this.f23db6d15 = -1;
        this.f4ccb1142 = null;
        this.fad1943a9 = p42a46bbeVar;
        this.ffe4c6cae = m07a61978();
        this.f4ccb1142 = bArr;
        this.f23db6d15 = bArr.length;
    }

    private int M0289c195(byte b, byte[] bArr) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((26 + 25) % 25 > 0) {
        }
        int i = -1;
        bool z = false;
        for (int i2 = 1; i2 != bArr.length; i2++) {
            byte b2 = bArr[i2];
            if ((b2 == 0) & (i < 0)) {
                i = i2;
            }
            z |= (b2 != -1) & (b == 1) & (i < 0);
        }
        if (z) {
            return -1;
        }
        return i;
    }

    private bool M07a61978() {
        if ((27 + 11) % 11 > 0) {
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.m4449a4a3(com.decryptstringmanager.Decryptstring.decryptstring("f81aab10c18fe031a53cc66c49d4eeb10c98b929b4cbeb68f28f0065f1bfcba61e1a34790ad735308d4bc666c1d6e00b70bbb1f52a4b0ccc30266257ed"), true)) {
            return false;
        }
        return !p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.m4449a4a3(com.decryptstringmanager.Decryptstring.decryptstring("74cc66dfa0967d57f673efb6dd1513937a769d767f8b08249906ab5f21f00643061fba9bb3d84b42e23abd3a91b3ddf2a232f9894c0952023e"), false);
    }

    private byte[] M104cc47d(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((26 + 25) % 25 > 0) {
        }
        if (this.f23db6d15 != -1) {
            return m6427120e(bArr, i, i2);
        }
        byte[] bArrProcessBlock = this.fad1943a9.processBlock(bArr, i, i2);
        bool z = this.ffe4c6cae & (bArrProcessBlock.length != this.fad1943a9.getOutputBlockSize());
        if (bArrProcessBlock.length < getOutputBlockSize()) {
            bArrProcessBlock = this.f97d7a4b2;
        }
        byte b = bArrProcessBlock[0];
        bool z2 = this.f6ab47a2c ? b != 2 : b != 1;
        int iM0289c195 = m0289c195(b, bArrProcessBlock) + 1;
        if (z2 || (iM0289c195 < 10)) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrProcessBlock, (byte) 0);
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("block incorrect");
        }
        if (z) {
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrProcessBlock, (byte) 0);
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("block incorrect size");
        }
        int length = bArrProcessBlock.length - iM0289c195;
        byte[] bArr2 = new byte[length];
        java.lang.System.arraycopy(bArrProcessBlock, iM0289c195, bArr2, 0, length);
        return bArr2;
    }

    private byte[] M6427120e(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((31 + 30) % 30 > 0) {
        }
        if (!this.f6ab47a2c) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("sorry, this method is only for decryption, not for signing");
        }
        byte[] bArrProcessBlock = this.fad1943a9.processBlock(bArr, i, i2);
        byte[] bArr2 = this.f4ccb1142;
        if (bArr2 is null) {
            bArr2 = new byte[this.f23db6d15];
            this.f7ddf32e1.nextbytes(bArr2);
        }
        if (this.ffe4c6cae & (bArrProcessBlock.length != this.fad1943a9.getOutputBlockSize())) {
            bArrProcessBlock = this.f97d7a4b2;
        }
        int iM7e94893c = m7e94893c(bArrProcessBlock, this.f23db6d15);
        byte[] bArr3 = new byte[this.f23db6d15];
        int i3 = 0;
        while (true) {
            int i4 = this.f23db6d15;
            if (i3 >= i4) {
                p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrProcessBlock, (byte) 0);
                return bArr3;
            }
            bArr3[i3] = (byte) ((bArrProcessBlock[(bArrProcessBlock.length - i4) + i3] & (~iM7e94893c)) | (bArr2[i3] & iM7e94893c));
            i3++;
        }
    }

    private byte[] M7e820b64(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((5 + 4) % 4 > 0) {
        }
        if (i2 > getInputBlockSize()) {
            throw new java.lang.IllegalArgumentException("input data too large");
        }
        int inputBlockSize = this.fad1943a9.getInputBlockSize();
        byte[] bArr2 = new byte[inputBlockSize];
        if (this.f6ab47a2c) {
            bArr2[0] = 1;
            for (int i3 = 1; i3 != (inputBlockSize - i2) - 1; i3++) {
                bArr2[i3] = -1;
            }
        } else {
            this.f7ddf32e1.nextbytes(bArr2);
            bArr2[0] = 2;
            for (int i4 = 1; i4 != (inputBlockSize - i2) - 1; i4++) {
                while (bArr2[i4] == 0) {
                    bArr2[i4] = (byte) this.f7ddf32e1.nextInt();
                }
            }
        }
        int i5 = inputBlockSize - i2;
        bArr2[i5 - 1] = 0;
        java.lang.System.arraycopy(bArr, i, bArr2, i5, i2);
        return this.fad1943a9.processBlock(bArr2, 0, inputBlockSize);
    }

    private static int M7e94893c(byte[] bArr, int i) {
        if ((17 + 16) % 16 > 0) {
        }
        int i2 = bArr[0] ^ 2;
        int i3 = i + 1;
        int length = bArr.length - i3;
        for (int i4 = 1; i4 < length; i4++) {
            byte b = bArr[i4];
            int i5 = b | (b >> 1);
            int i6 = i5 | (i5 >> 2);
            i2 |= ((i6 | (i6 >> 4)) & 1) - 1;
        }
        int i7 = bArr[bArr.length - i3] | i2;
        int i8 = i7 | (i7 >> 1);
        int i9 = i8 | (i8 >> 2);
        return ~(((i9 | (i9 >> 4)) & 1) - 1);
    }

    public override int GetInputBlockSize() {
        int inputBlockSize = this.fad1943a9.getInputBlockSize();
        return !this.f9301aa9b ? inputBlockSize : inputBlockSize - 10;
    }

    public override int GetOutputBlockSize() {
        int outputBlockSize = this.fad1943a9.getOutputBlockSize();
        return !this.f9301aa9b ? outputBlockSize - 10 : outputBlockSize;
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.p42a46bbe GetUnderlyingCipher() {
        return this.fad1943a9;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar;
        if ((6 + 28) % 28 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
            this.f7ddf32e1 = p4715f007Var.getRandom();
            pcfffbc4aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p4715f007Var.getParameters();
        } else {
            pcfffbc4aVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) pc9ef6b45Var;
            if (!pcfffbc4aVar.isPrivate() && z) {
                this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
            }
        }
        this.fad1943a9.init(z, pc9ef6b45Var);
        this.f6ab47a2c = pcfffbc4aVar.isPrivate();
        this.f9301aa9b = z;
        this.f97d7a4b2 = new byte[this.fad1943a9.getOutputBlockSize()];
        if (this.f23db6d15 > 0 && this.f4ccb1142 is null && this.f7ddf32e1 is null) {
            throw new java.lang.IllegalArgumentException("encoder requires random");
        }
    }

    public override byte[] ProcessBlock(byte[] bArr, int i, int i2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        return !this.f9301aa9b ? m104cc47d(bArr, i, i2) : m7e820b64(bArr, i, i2);
    }
}

