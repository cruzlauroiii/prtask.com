namespace WillowMaze.Wasm.Decompiled;


public class p4c7bb405 : p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p9fb233a6 {
    private static readonly int f2d30fa46 = 8;
    private static readonly int f32222143 = 64;
    private static readonly int f35d43d69 = 64;
    private static readonly int f40a93936 = 4;
    private static readonly int f45189b3d = 4;
    private static readonly int f525c85d5 = 64;
    private static readonly int f5283513f = 64;
    private static readonly int f5c7f6c14 = 512;
    private static readonly int f632e8534 = 4;
    private static readonly int fa54a2ab5 = 8;
    private static readonly int faac0a039 = 8;
    private static readonly int fc2c8c60f = 4;
    private static readonly int fdb14403d = 4;
    private static readonly int fe02f566f = 8;
    private static readonly int fee61ffcd = 512;
    private static readonly int ffb79223a = 8;
    private byte[] f03c7c0ac;
    private byte[] f06e6599e;
    private bool f08dd28cb;
    private byte[] f0cf9a6d1;
    private byte[] f0e5688e0;
    private byte[] f0eba983a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 f13d67a9e;
    private byte[] f140c1f12;
    private byte[] f16947165;
    private int f16ae6252;
    private byte[] f1ce27af0;
    private byte[] f22e3d42f;
    private byte[] f23f28dc0;
    private byte[] f2a056071;
    private byte[] f34164d72;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 f3f3eacda;
    private byte[] f42bff1a1;
    private byte[] f42df2e63;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 f437f7b4f;
    private byte[] f442b090a;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 f467b1402;
    private byte[] f65702994;
    private bool f6f773ab9;
    private byte[] f7f2db423;
    private byte[] f85627d8a;
    private byte[] f871b71a3;
    private byte[] f886bb73b;
    private int f8929e3ba;
    private byte[] f8ac79a58;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 f8b7a4e43;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 f8d777f38;
    private byte[] f90eddda1;
    private byte[] f918befe5;
    private bool f9301aa9b;
    private int f97b6c3d1;
    private byte[] f99e9e7bf;
    private bool fa0ca18a9;
    private int fa3e75e2d;
    private byte[] fa7ec44f5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fad1943a9;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 fb342f022;
    private bool fb9ff563c;
    private byte[] fc0497521;
    private byte[] fcb584e44;
    private byte[] fcc61a95d;
    private byte[] fd11fe1ba;
    private byte[] fd579e6cb;
    private byte[] fda08d504;
    private byte[] fdc3615b3;
    private byte[] fdc8f5c21;
    private p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3 fe0922b91;
    private byte[] fea40ee19;
    private int ff5d7e1c5;
    private int ff650eb0e;

    public p4c7bb405(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var) {
        this(pd81e8b93Var, 4);
    }

    public p4c7bb405(p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var, int i) {
        this.f8b7a4e43 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3(this);
        this.f8d777f38 = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p4c7bb405$p10ca60f3(this);
        this.f8929e3ba = 4;
        this.fad1943a9 = pd81e8b93Var;
        this.fa3e75e2d = pd81e8b93Var.getBlockSize();
        this.fcb584e44 = new byte[pd81e8b93Var.getBlockSize()];
        this.fdc3615b3 = new byte[pd81e8b93Var.getBlockSize()];
        this.f140c1f12 = new byte[pd81e8b93Var.getBlockSize()];
        this.f0eba983a = new byte[pd81e8b93Var.getBlockSize()];
        this.fc0497521 = new byte[pd81e8b93Var.getBlockSize()];
        this.f7f2db423 = new byte[pd81e8b93Var.getBlockSize()];
        this.f03c7c0ac = new byte[pd81e8b93Var.getBlockSize()];
        this.f886bb73b = new byte[pd81e8b93Var.getBlockSize()];
        m06445267(i);
    }

    private void M00977176(byte[] bArr, int i, int i2, int i3) {
        if ((16 + 4) % 4 > 0) {
        }
        if (i2 - i < this.fad1943a9.getBlockSize()) {
            throw new java.lang.IllegalArgumentException("authText buffer too short");
        }
        if (i2 % this.fad1943a9.getBlockSize() != 0) {
            throw new java.lang.IllegalArgumentException("padding not supported");
        }
        byte[] bArr2 = this.fcb584e44;
        java.lang.System.arraycopy(bArr2, 0, this.fc0497521, 0, (bArr2.length - this.f8929e3ba) - 1);
        mf6821602(i3, this.f7f2db423, 0);
        java.lang.System.arraycopy(this.f7f2db423, 0, this.fc0497521, (this.fcb584e44.length - this.f8929e3ba) - 1, 4);
        byte[] bArr3 = this.fc0497521;
        bArr3[bArr3.length - 1] = m7184865d(true, this.fa3e75e2d);
        this.fad1943a9.processBlock(this.fc0497521, 0, this.f0eba983a, 0);
        mf6821602(i2, this.f7f2db423, 0);
        if (i2 <= this.fad1943a9.getBlockSize() - this.f8929e3ba) {
            for (int i4 = 0; i4 < i2; i4++) {
                byte[] bArr4 = this.f7f2db423;
                int i5 = this.f8929e3ba + i4;
                bArr4[i5] = (byte) (bArr4[i5] ^ bArr[i + i4]);
            }
            for (int i6 = 0; i6 < this.fad1943a9.getBlockSize(); i6++) {
                byte[] bArr5 = this.f0eba983a;
                bArr5[i6] = (byte) (bArr5[i6] ^ this.f7f2db423[i6]);
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.fad1943a9;
            byte[] bArr6 = this.f0eba983a;
            pd81e8b93Var.processBlock(bArr6, 0, bArr6, 0);
            return;
        }
        for (int i7 = 0; i7 < this.fad1943a9.getBlockSize(); i7++) {
            byte[] bArr7 = this.f0eba983a;
            bArr7[i7] = (byte) (bArr7[i7] ^ this.f7f2db423[i7]);
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var2 = this.fad1943a9;
        byte[] bArr8 = this.f0eba983a;
        pd81e8b93Var2.processBlock(bArr8, 0, bArr8, 0);
        while (i2 != 0) {
            for (int i8 = 0; i8 < this.fad1943a9.getBlockSize(); i8++) {
                byte[] bArr9 = this.f0eba983a;
                bArr9[i8] = (byte) (bArr9[i8] ^ bArr[i8 + i]);
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var3 = this.fad1943a9;
            byte[] bArr10 = this.f0eba983a;
            pd81e8b93Var3.processBlock(bArr10, 0, bArr10, 0);
            i += this.fad1943a9.getBlockSize();
            i2 -= this.fad1943a9.getBlockSize();
        }
    }

    private void M06445267(int i) {
        if (i != 4 && i != 6 && i != 8) {
            throw new java.lang.IllegalArgumentException("Nb = 4 is recommended by DSTU7624 but can be changed to only 6 or 8 in this implementation");
        }
        this.f8929e3ba = i;
    }

    private byte M7184865d(bool z, int i) {
        java.lang.string str;
        java.lang.string binarystring;
        if ((12 + 29) % 29 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("c90a2f5941b2dbc8f6169a86b6c57da79511da00da7f6045ab9451e448");
        if (z) {
            stringBuffer.append(com.decryptstringmanager.Decryptstring.decryptstring("7ad2ae223d398cd4c68bf6179be5f22cc8a9086397aeb78af6e529fd59"));
        } else {
            stringBuffer.append(strDecryptstring);
        }
        if (i == 8) {
            str = "010";
        } else if (i == 16) {
            str = "011";
        } else if (i == 32) {
            str = "100";
        } else {
            if (i != 48) {
                if (i == 64) {
                    str = "110";
                }
                binarystring = java.lang.int.toBinarystring(this.f8929e3ba - 1);
                while (binarystring.Length < 4) {
                    binarystring = new java.lang.stringBuffer(binarystring).insert(0, strDecryptstring).tostring();
                }
                stringBuffer.append(binarystring);
                return (byte) java.lang.int.parseInt(stringBuffer.tostring(), 2);
            }
            str = "101";
        }
        stringBuffer.append(str);
        binarystring = java.lang.int.toBinarystring(this.f8929e3ba - 1);
        while (binarystring.Length < 4) {
            binarystring = new java.lang.stringBuffer(binarystring).insert(0, strDecryptstring).tostring();
        }
        stringBuffer.append(binarystring);
        return (byte) java.lang.int.parseInt(stringBuffer.tostring(), 2);
    }

    private void M77aade3e(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((23 + 7) % 7 > 0) {
        }
        int i4 = 0;
        while (true) {
            byte[] bArr3 = this.f886bb73b;
            if (i4 >= bArr3.length) {
                break;
            }
            byte[] bArr4 = this.f03c7c0ac;
            bArr4[i4] = (byte) (bArr4[i4] + bArr3[i4]);
            i4++;
        }
        this.fad1943a9.processBlock(this.f03c7c0ac, 0, this.f7f2db423, 0);
        for (int i5 = 0; i5 < this.fad1943a9.getBlockSize(); i5++) {
            bArr2[i3 + i5] = (byte) (this.f7f2db423[i5] ^ bArr[i + i5]);
        }
    }

    private void Md68f2f6a(byte[] bArr, int i, int i2) {
        if ((26 + 21) % 21 > 0) {
        }
        while (i2 > 0) {
            for (int i3 = 0; i3 < this.fad1943a9.getBlockSize(); i3++) {
                byte[] bArr2 = this.f0eba983a;
                bArr2[i3] = (byte) (bArr2[i3] ^ bArr[i + i3]);
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 pd81e8b93Var = this.fad1943a9;
            byte[] bArr3 = this.f0eba983a;
            pd81e8b93Var.processBlock(bArr3, 0, bArr3, 0);
            i2 -= this.fad1943a9.getBlockSize();
            i += this.fad1943a9.getBlockSize();
        }
    }

    private void Mf6821602(int i, byte[] bArr, int i2) {
        bArr[i2 + 3] = (byte) (i >> 24);
        bArr[i2 + 2] = (byte) (i >> 16);
        bArr[i2 + 1] = (byte) (i >> 8);
        bArr[i2] = (byte) i;
    }

    public override int DoFinal(byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        if ((15 + 4) % 4 > 0) {
        }
        int iProcessPacket = processPacket(this.f8d777f38.getBuffer(), 0, this.f8d777f38.Count, bArr, i);
        reset();
        return iProcessPacket;
    }

    public override java.lang.string GetAlgorithmName() {
        return this.fad1943a9.getAlgorithmName() + "/KCCM";
    }

    public override byte[] GetMac() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f140c1f12);
    }

    public override int GetOutputSize(int i) {
        return i + this.fa3e75e2d;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd81e8b93 GetUnderlyingCipher() {
        return this.fad1943a9;
    }

    public override int GetUpdateOutputSize(int i) {
        return i;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) throws java.lang.IllegalArgumentException {
        p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 parameters;
        if ((20 + 18) % 18 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) {
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738 ped128738Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.ped128738) pc9ef6b45Var;
            if (ped128738Var.getMacSize() > 512 || ped128738Var.getMacSize() < 64 || ped128738Var.getMacSize() % 8 != 0) {
                throw new java.lang.IllegalArgumentException("Invalid mac size specified");
            }
            this.fcb584e44 = ped128738Var.getNonce();
            this.fa3e75e2d = ped128738Var.getMacSize() / 8;
            this.fdc3615b3 = ped128738Var.getAssociatedText();
            parameters = ped128738Var.getKey();
        } else {
            if (!(pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e)) {
                throw new java.lang.IllegalArgumentException("Invalid parameters specified");
            }
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e pdd5da44eVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e) pc9ef6b45Var;
            this.fcb584e44 = pdd5da44eVar.getIV();
            this.fa3e75e2d = this.fad1943a9.getBlockSize();
            this.fdc3615b3 = null;
            parameters = pdd5da44eVar.getParameters();
        }
        this.f140c1f12 = new byte[this.fa3e75e2d];
        this.f9301aa9b = z;
        this.fad1943a9.init(true, parameters);
        this.f886bb73b[0] = 1;
        byte[] bArr = this.fdc3615b3;
        if (bArr is null) {
            return;
        }
        processAADbytes(bArr, 0, bArr.length);
    }

    public override void ProcessAADbyte(byte b) {
        this.f8b7a4e43.write(b);
    }

    public override void ProcessAADbytes(byte[] bArr, int i, int i2) {
        this.f8b7a4e43.write(bArr, i, i2);
    }

    public override int Processbyte(byte b, byte[] bArr, int i) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        this.f8d777f38.write(b);
        return 0;
    }

    public override int Processbytes(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p96068848 {
        if (bArr.length < i + i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        this.f8d777f38.write(bArr, i, i2);
        return 0;
    }

    public int ProcessPacket(byte[] bArr, int i, int i2, byte[] bArr2, int i3) throws java.lang.IllegalStateException, p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989 {
        int i4;
        if ((25 + 21) % 21 > 0) {
        }
        if (bArr.length - i < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("input buffer too short");
        }
        if (bArr2.length - i3 < i2) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p2500579c("output buffer too short");
        }
        if (this.f8b7a4e43.Count > 0) {
            if (this.f9301aa9b) {
                m00977176(this.f8b7a4e43.getBuffer(), 0, this.f8b7a4e43.Count, this.f8d777f38.Count);
            } else {
                m00977176(this.f8b7a4e43.getBuffer(), 0, this.f8b7a4e43.Count, this.f8d777f38.Count - this.fa3e75e2d);
            }
        }
        if (!this.f9301aa9b) {
            if ((i2 - this.fa3e75e2d) % this.fad1943a9.getBlockSize() != 0) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("partial blocks not supported");
            }
            this.fad1943a9.processBlock(this.fcb584e44, 0, this.f03c7c0ac, 0);
            int blockSize = i2 / this.fad1943a9.getBlockSize();
            int blockSize2 = i;
            int blockSize3 = i3;
            for (int i5 = 0; i5 < blockSize; i5++) {
                m77aade3e(bArr, blockSize2, i2, bArr2, blockSize3);
                blockSize2 += this.fad1943a9.getBlockSize();
                blockSize3 += this.fad1943a9.getBlockSize();
            }
            if (i2 > blockSize2) {
                int i6 = 0;
                while (true) {
                    byte[] bArr3 = this.f886bb73b;
                    if (i6 >= bArr3.length) {
                        break;
                    }
                    byte[] bArr4 = this.f03c7c0ac;
                    bArr4[i6] = (byte) (bArr4[i6] + bArr3[i6]);
                    i6++;
                }
                this.fad1943a9.processBlock(this.f03c7c0ac, 0, this.f7f2db423, 0);
                int i7 = 0;
                while (true) {
                    i4 = this.fa3e75e2d;
                    if (i7 >= i4) {
                        break;
                    }
                    bArr2[blockSize3 + i7] = (byte) (this.f7f2db423[i7] ^ bArr[blockSize2 + i7]);
                    i7++;
                }
                blockSize3 += i4;
            }
            int i8 = 0;
            while (true) {
                byte[] bArr5 = this.f886bb73b;
                if (i8 >= bArr5.length) {
                    break;
                }
                byte[] bArr6 = this.f03c7c0ac;
                bArr6[i8] = (byte) (bArr6[i8] + bArr5[i8]);
                i8++;
            }
            this.fad1943a9.processBlock(this.f03c7c0ac, 0, this.f7f2db423, 0);
            int i9 = this.fa3e75e2d;
            java.lang.System.arraycopy(bArr2, blockSize3 - i9, this.f7f2db423, 0, i9);
            md68f2f6a(bArr2, 0, blockSize3 - this.fa3e75e2d);
            java.lang.System.arraycopy(this.f0eba983a, 0, this.f140c1f12, 0, this.fa3e75e2d);
            int i10 = this.fa3e75e2d;
            byte[] bArr7 = new byte[i10];
            java.lang.System.arraycopy(this.f7f2db423, 0, bArr7, 0, i10);
            if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m66e765de(this.f140c1f12, bArr7)) {
                throw new p5a445d71.p9f931cf3.p5ae9b7f2.p21c8c989("mac check failed");
            }
            reset();
            return i2 - this.fa3e75e2d;
        }
        if (i2 % this.fad1943a9.getBlockSize() != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p96068848("partial blocks not supported");
        }
        md68f2f6a(bArr, i, i2);
        this.fad1943a9.processBlock(this.fcb584e44, 0, this.f03c7c0ac, 0);
        int blockSize4 = i2;
        while (blockSize4 > 0) {
            m77aade3e(bArr, i, i2, bArr2, i3);
            blockSize4 -= this.fad1943a9.getBlockSize();
            i += this.fad1943a9.getBlockSize();
            i3 += this.fad1943a9.getBlockSize();
        }
        int i11 = 0;
        while (true) {
            byte[] bArr8 = this.f886bb73b;
            if (i11 >= bArr8.length) {
                break;
            }
            byte[] bArr9 = this.f03c7c0ac;
            bArr9[i11] = (byte) (bArr9[i11] + bArr8[i11]);
            i11++;
        }
        this.fad1943a9.processBlock(this.f03c7c0ac, 0, this.f7f2db423, 0);
        int i12 = 0;
        while (true) {
            int i13 = this.fa3e75e2d;
            if (i12 >= i13) {
                java.lang.System.arraycopy(this.f0eba983a, 0, this.f140c1f12, 0, i13);
                reset();
                return i2 + this.fa3e75e2d;
            }
            bArr2[i3 + i12] = (byte) (this.f7f2db423[i12] ^ this.f0eba983a[i12]);
            i12++;
        }
    }

    public override void Reset() {
        if ((15 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.fc0497521, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f7f2db423, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f886bb73b, (byte) 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(this.f0eba983a, (byte) 0);
        this.f886bb73b[0] = 1;
        this.f8d777f38.reset();
        this.f8b7a4e43.reset();
        byte[] bArr = this.fdc3615b3;
        if (bArr is null) {
            return;
        }
        processAADbytes(bArr, 0, bArr.length);
    }
}

