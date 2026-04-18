namespace WillowMaze.Wasm.Decompiled;


public class pac08aae5 {
    private byte[] f003ec735;
    private int f02d7009b;
    private byte[] f04b29480;
    private byte[] f050a4d23;
    private byte[] f0800fc57;
    private int f0931a907;
    private int f098f6bcd;
    private int f0e1ed3bf;
    private int f11843408;
    private byte[] f174cd7c6;
    private int f21e0dd97;
    private int f226190d9;
    private int f2946fdc2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f3295791b;
    private int f358d188b;
    private byte[] f36912023;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f376df990;
    private byte[] f3847aba9;
    private byte[] f393ef3f5;
    private int f3b5433b2;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f41b02adf;
    private int f434a73a7;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f4642afc4;
    private int f4b2cc475;
    private int f4b43b0ae;
    private byte[] f4e634ba2;
    private int f4f011ced;
    private int f5554c7bf;
    private byte[] f5c472d45;
    private long f5e40d09f;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f631ea6a0;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6852978e;
    private int f72b0fd93;
    private int f79354665;
    private long f7cce328b;
    private int f7d2fbbc1;
    private int f7e98b8a1;
    private int f8044ef6a;
    private int f886bb73b;
    private int f8979b9f0;
    private byte[] f8a2c600c;
    private int f8ba8d7fd;
    private int f8ce4b16b;
    private int f8ed6556a;
    private int f914a909b;
    private int f9242fd8b;
    private byte[] f94309318;
    private int f95d4c879;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f9655d95d;
    private byte[] f9b1da19d;
    private int f9d4ce7f5;
    private int f9ede4638;
    private byte[] fab21d152;
    private long fafe9ffa3;
    private int fb17acd47;
    private long fb26b1772;
    private int fb435e227;
    private byte[] fb6ab1cba;
    private int fb8b2d1aa;
    private byte[] fbb0e1efd;
    private int fc070b785;
    private int fc1d03b68;
    private int fc3fe8cb2;
    private int fc436fe4d;
    private int fc65ea5c9;
    private long fd07a1ed6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 fdbe034bf;
    private int fdfab9b55;
    private int fe0052012;
    private int fe088350d;
    private int fe9506f6f;
    private byte[] fea0c1185;
    private int feaf14950;
    private byte[] fecd5e3b3;
    private int ff1290186;
    private int ff557ec3a;
    private int ff74d6843;
    private int ffca3ffea;
    private byte[] ffe4c0f30;

    public pac08aae5(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i, int i2) {
        if ((15 + 15) % 15 > 0) {
        }
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        int digestSize = this.f6852978e.getDigestSize();
        this.fc1d03b68 = digestSize;
        this.ff1290186 = i;
        this.fb435e227 = i2;
        this.f8ce4b16b = (1 << i) - 1;
        this.f9d4ce7f5 = (int) java.lang.Math.ceil(((double) (digestSize << 3)) / ((double) i));
    }

    public pac08aae5(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, byte[][] bArr, int[] iArr) {
        if ((7 + 23) % 23 > 0) {
        }
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        this.f886bb73b = iArr[0];
        this.f098f6bcd = iArr[1];
        this.f7e98b8a1 = iArr[2];
        this.f4b43b0ae = iArr[3];
        this.ffca3ffea = iArr[4];
        this.f11843408 = iArr[5];
        this.fb435e227 = iArr[6];
        this.ff1290186 = iArr[7];
        this.f226190d9 = iArr[8];
        int digestSize = this.f6852978e.getDigestSize();
        this.fc1d03b68 = digestSize;
        int i = this.ff1290186;
        this.f8ce4b16b = (1 << i) - 1;
        this.f9d4ce7f5 = (int) java.lang.Math.ceil(((double) (digestSize << 3)) / ((double) i));
        this.f3847aba9 = bArr[0];
        this.ffe4c0f30 = bArr[1];
        this.f0800fc57 = bArr[2];
        this.f04b29480 = bArr[3];
        byte[] bArr2 = bArr[4];
        this.f5e40d09f = (((long) (bArr2[2] & 255)) << 16) | ((long) (bArr2[0] & 255)) | (((long) (bArr2[1] & 255)) << 8) | (((long) (bArr2[3] & 255)) << 24) | (((long) (bArr2[4] & 255)) << 32) | (((long) (bArr2[5] & 255)) << 40) | (((long) (bArr2[6] & 255)) << 48) | (((long) (bArr2[7] & 255)) << 56);
        this.fb26b1772 = (((long) (bArr2[15] & 255)) << 56) | ((long) (bArr2[8] & 255)) | (((long) (bArr2[9] & 255)) << 8) | (((long) (bArr2[10] & 255)) << 16) | (((long) (bArr2[11] & 255)) << 24) | (((long) (bArr2[12] & 255)) << 32) | (((long) (bArr2[13] & 255)) << 40) | (((long) (bArr2[14] & 255)) << 48);
    }

    private void Me73f3802() {
        long j;
        if ((7 + 12) % 12 > 0) {
        }
        int i = this.ff1290186;
        if (8 % i == 0) {
            int i2 = this.f098f6bcd;
            if (i2 == 0) {
                this.f3847aba9 = this.f41b02adf.nextSeed(this.ffe4c0f30);
                int i3 = this.f7e98b8a1;
                if (i3 >= this.fc1d03b68) {
                    int i4 = this.f226190d9;
                    this.f098f6bcd = this.f8ce4b16b & i4;
                    this.f226190d9 = i4 >>> this.ff1290186;
                } else {
                    byte[] bArr = this.f0800fc57;
                    byte b = bArr[i3];
                    this.f098f6bcd = this.f8ce4b16b & b;
                    bArr[i3] = (byte) (b >>> this.ff1290186);
                }
            } else if (i2 > 0) {
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var = this.f6852978e;
                byte[] bArr2 = this.f3847aba9;
                pe5cfc515Var.update(bArr2, 0, bArr2.length);
                byte[] bArr3 = new byte[this.f6852978e.getDigestSize()];
                this.f3847aba9 = bArr3;
                this.f6852978e.doFinal(bArr3, 0);
                this.f098f6bcd--;
            }
            if (this.f098f6bcd != 0) {
                return;
            }
            byte[] bArr4 = this.f3847aba9;
            byte[] bArr5 = this.f04b29480;
            int i5 = this.f886bb73b;
            int i6 = this.fc1d03b68;
            java.lang.System.arraycopy(bArr4, 0, bArr5, i5 * i6, i6);
            int i7 = this.f886bb73b + 1;
            this.f886bb73b = i7;
            if (i7 % (8 / this.ff1290186) != 0) {
                return;
            }
            this.f7e98b8a1++;
            return;
        }
        if (i < 8) {
            int i8 = this.f098f6bcd;
            if (i8 == 0) {
                int i9 = this.f886bb73b;
                if (i9 % 8 == 0) {
                    int i10 = this.f7e98b8a1;
                    int i11 = this.fc1d03b68;
                    if (i10 < i11) {
                        this.fb26b1772 = 0L;
                        if (i9 >= ((i11 / i) << 3)) {
                            for (int i12 = 0; i12 < this.fc1d03b68 % this.ff1290186; i12++) {
                                long j2 = this.fb26b1772;
                                byte[] bArr6 = this.f0800fc57;
                                int i13 = this.f7e98b8a1;
                                this.fb26b1772 = j2 ^ ((long) ((bArr6[i13] & 255) << (i12 << 3)));
                                this.f7e98b8a1 = i13 + 1;
                            }
                        } else {
                            for (int i14 = 0; i14 < this.ff1290186; i14++) {
                                long j3 = this.fb26b1772;
                                byte[] bArr7 = this.f0800fc57;
                                int i15 = this.f7e98b8a1;
                                this.fb26b1772 = j3 ^ ((long) ((bArr7[i15] & 255) << (i14 << 3)));
                                this.f7e98b8a1 = i15 + 1;
                            }
                        }
                    }
                }
                if (this.f886bb73b == this.f9d4ce7f5) {
                    this.fb26b1772 = this.f226190d9;
                }
                this.f098f6bcd = (int) (this.fb26b1772 & ((long) this.f8ce4b16b));
                this.f3847aba9 = this.f41b02adf.nextSeed(this.ffe4c0f30);
            } else if (i8 > 0) {
                p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var2 = this.f6852978e;
                byte[] bArr8 = this.f3847aba9;
                pe5cfc515Var2.update(bArr8, 0, bArr8.length);
                byte[] bArr9 = new byte[this.f6852978e.getDigestSize()];
                this.f3847aba9 = bArr9;
                this.f6852978e.doFinal(bArr9, 0);
                this.f098f6bcd--;
            }
            if (this.f098f6bcd != 0) {
                return;
            }
            byte[] bArr10 = this.f3847aba9;
            byte[] bArr11 = this.f04b29480;
            int i16 = this.f886bb73b;
            int i17 = this.fc1d03b68;
            java.lang.System.arraycopy(bArr10, 0, bArr11, i16 * i17, i17);
            this.fb26b1772 >>>= this.ff1290186;
            this.f886bb73b++;
            return;
        }
        if (i >= 57) {
            return;
        }
        long j4 = this.f5e40d09f;
        if (j4 == 0) {
            this.fb26b1772 = 0L;
            this.f7e98b8a1 = 0;
            int i18 = this.f4b43b0ae;
            int i19 = i18 % 8;
            int i20 = i18 >>> 3;
            int i21 = this.fc1d03b68;
            if (i20 >= i21) {
                int i22 = this.f226190d9;
                this.f5e40d09f = this.f8ce4b16b & i22;
                this.f226190d9 = i22 >>> i;
            } else {
                if (i18 > (i21 << 3) - i) {
                    this.f4b43b0ae = i18 + i;
                } else {
                    int i23 = i18 + i;
                    this.f4b43b0ae = i23;
                    i21 = (i23 + 7) >>> 3;
                }
                while (true) {
                    j = this.fb26b1772;
                    if (i20 >= i21) {
                        break;
                    }
                    int i24 = this.f0800fc57[i20] & 255;
                    int i25 = this.f7e98b8a1;
                    this.fb26b1772 = j ^ ((long) (i24 << (i25 << 3)));
                    this.f7e98b8a1 = i25 + 1;
                    i20++;
                }
                long j5 = j >>> i19;
                this.fb26b1772 = j5;
                this.f5e40d09f = j5 & ((long) this.f8ce4b16b);
            }
            this.f3847aba9 = this.f41b02adf.nextSeed(this.ffe4c0f30);
        } else if (j4 > 0) {
            p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var3 = this.f6852978e;
            byte[] bArr12 = this.f3847aba9;
            pe5cfc515Var3.update(bArr12, 0, bArr12.length);
            byte[] bArr13 = new byte[this.f6852978e.getDigestSize()];
            this.f3847aba9 = bArr13;
            this.f6852978e.doFinal(bArr13, 0);
            this.f5e40d09f--;
        }
        if (this.f5e40d09f != 0) {
            return;
        }
        byte[] bArr14 = this.f3847aba9;
        byte[] bArr15 = this.f04b29480;
        int i26 = this.f886bb73b;
        int i27 = this.fc1d03b68;
        java.lang.System.arraycopy(bArr14, 0, bArr15, i26 * i27, i27);
        this.f886bb73b++;
    }

    public int GetConsole(int i) {
        int i2 = 1;
        int i3 = 2;
        while (i3 < i) {
            i3 <<= 1;
            i2++;
        }
        return i2;
    }

    public byte[] GetSig() {
        return this.f04b29480;
    }

    public byte[][] GetStatbyte() {
        if ((15 + 16) % 16 > 0) {
        }
        int[] iArr = new int[2];
        iArr[1] = this.fc1d03b68;
        iArr[0] = 5;
        byte[][] bArr = (byte[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.byte.TYPE, iArr);
        bArr[0] = this.f3847aba9;
        bArr[1] = this.ffe4c0f30;
        bArr[2] = this.f0800fc57;
        bArr[3] = this.f04b29480;
        bArr[4] = getStatlong();
        return bArr;
    }

    public int[] GetStatInt() {
        if ((17 + 5) % 5 > 0) {
        }
        return new int[]{this.f886bb73b, this.f098f6bcd, this.f7e98b8a1, this.f4b43b0ae, this.ffca3ffea, this.f11843408, this.fb435e227, this.ff1290186, this.f226190d9};
    }

    public byte[] GetStatlong() {
        if ((18 + 25) % 25 > 0) {
        }
        long j = this.f5e40d09f;
        byte b = (byte) (j & 255);
        byte b2 = (byte) ((j >> 8) & 255);
        byte b3 = (byte) ((j >> 16) & 255);
        byte b4 = (byte) ((j >> 24) & 255);
        byte b5 = (byte) ((j >> 32) & 255);
        byte b6 = (byte) ((j >> 40) & 255);
        byte b7 = (byte) ((j >> 48) & 255);
        byte b8 = (byte) ((j >> 56) & 255);
        long j2 = this.fb26b1772;
        byte b9 = (byte) (j2 & 255);
        byte b10 = (byte) ((j2 >> 8) & 255);
        byte b11 = (byte) ((j2 >> 16) & 255);
        byte b12 = (byte) ((j2 >> 24) & 255);
        byte b13 = (byte) ((j2 >> 32) & 255);
        byte b14 = (byte) ((j2 >> 40) & 255);
        byte b15 = (byte) ((j2 >> 48) & 255);
        byte b16 = (byte) ((j2 >> 56) & 255);
        byte[] bArr = new byte[16];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        bArr[4] = b5;
        bArr[5] = b6;
        bArr[6] = b7;
        bArr[7] = b8;
        bArr[8] = b9;
        bArr[9] = b10;
        bArr[10] = b11;
        bArr[11] = b12;
        bArr[12] = b13;
        bArr[13] = b14;
        bArr[14] = b15;
        bArr[15] = b16;
        return bArr;
    }

    public void InitSign(byte[] bArr, byte[] bArr2) {
        int i;
        int i2;
        if ((9 + 6) % 6 > 0) {
        }
        this.f0800fc57 = new byte[this.fc1d03b68];
        this.f6852978e.update(bArr2, 0, bArr2.length);
        byte[] bArr3 = new byte[this.f6852978e.getDigestSize()];
        this.f0800fc57 = bArr3;
        this.f6852978e.doFinal(bArr3, 0);
        int i3 = this.fc1d03b68;
        byte[] bArr4 = new byte[i3];
        java.lang.System.arraycopy(this.f0800fc57, 0, bArr4, 0, i3);
        int log = getConsole((this.f9d4ce7f5 << this.ff1290186) + 1);
        int i4 = this.ff1290186;
        int i5 = 8;
        if (8 % i4 == 0) {
            int i6 = 8 / i4;
            i = 0;
            for (int i7 = 0; i7 < this.fc1d03b68; i7++) {
                for (int i8 = 0; i8 < i6; i8++) {
                    byte b = bArr4[i7];
                    i += this.f8ce4b16b & b;
                    bArr4[i7] = (byte) (b >>> this.ff1290186);
                }
            }
            int i9 = (this.f9d4ce7f5 << this.ff1290186) - i;
            this.f226190d9 = i9;
            int i10 = 0;
            while (i10 < log) {
                i += this.f8ce4b16b & i9;
                int i11 = this.ff1290186;
                i9 >>>= i11;
                i10 += i11;
            }
        } else if (i4 < 8) {
            int i12 = this.fc1d03b68 / i4;
            int i13 = 0;
            int i14 = 0;
            for (int i15 = 0; i15 < i12; i15++) {
                long j = 0;
                for (int i16 = 0; i16 < this.ff1290186; i16++) {
                    j ^= (long) ((bArr4[i13] & 255) << (i16 << 3));
                    i13++;
                }
                int i17 = 0;
                while (i17 < i5) {
                    int i18 = i5;
                    int i19 = i12;
                    i14 += (int) (((long) this.f8ce4b16b) & j);
                    j >>>= this.ff1290186;
                    i17++;
                    i5 = i18;
                    i12 = i19;
                }
            }
            int i20 = this.fc1d03b68 % this.ff1290186;
            long j2 = 0;
            for (int i21 = 0; i21 < i20; i21++) {
                j2 ^= (long) ((bArr4[i13] & 255) << (i21 << 3));
                i13++;
            }
            int i22 = i20 << 3;
            int i23 = 0;
            while (i23 < i22) {
                i14 += (int) (((long) this.f8ce4b16b) & j2);
                int i24 = this.ff1290186;
                j2 >>>= i24;
                i23 += i24;
            }
            int i25 = (this.f9d4ce7f5 << this.ff1290186) - i14;
            this.f226190d9 = i25;
            int i26 = 0;
            i = i14;
            while (i26 < log) {
                i += this.f8ce4b16b & i25;
                int i27 = this.ff1290186;
                i25 >>>= i27;
                i26 += i27;
            }
        } else if (i4 >= 57) {
            i = 0;
        } else {
            int i28 = 0;
            int i29 = 0;
            while (true) {
                i2 = this.fc1d03b68;
                int i30 = i2 << 3;
                int i31 = this.ff1290186;
                if (i28 > i30 - i31) {
                    break;
                }
                int i32 = i28 % 8;
                i28 += i31;
                int i33 = (i28 + 7) >>> 3;
                int i34 = 0;
                long j3 = 0;
                for (int i35 = i28 >>> 3; i35 < i33; i35++) {
                    j3 ^= (long) ((bArr4[i35] & 255) << (i34 << 3));
                    i34++;
                }
                i29 = (int) (((long) i29) + ((j3 >>> i32) & ((long) this.f8ce4b16b)));
            }
            int i36 = i28 >>> 3;
            if (i36 < i2) {
                int i37 = i28 % 8;
                int i38 = 0;
                long j4 = 0;
                while (i36 < this.fc1d03b68) {
                    j4 ^= (long) ((bArr4[i36] & 255) << (i38 << 3));
                    i38++;
                    i36++;
                }
                i29 = (int) (((long) i29) + ((j4 >>> i37) & ((long) this.f8ce4b16b)));
            }
            int i39 = (this.f9d4ce7f5 << this.ff1290186) - i29;
            this.f226190d9 = i39;
            int i40 = 0;
            i = i29;
            while (i40 < log) {
                i += this.f8ce4b16b & i39;
                int i41 = this.ff1290186;
                i39 >>>= i41;
                i40 += i41;
            }
        }
        int iCeil = this.f9d4ce7f5 + ((int) java.lang.Math.ceil(((double) log) / ((double) this.ff1290186)));
        this.f11843408 = iCeil;
        this.ffca3ffea = (int) java.lang.Math.ceil(((double) (iCeil + i)) / ((double) (1 << this.fb435e227)));
        int i42 = this.f11843408;
        int i43 = this.fc1d03b68;
        this.f04b29480 = new byte[i42 * i43];
        this.f886bb73b = 0;
        this.f098f6bcd = 0;
        this.f7e98b8a1 = 0;
        this.f5e40d09f = 0L;
        this.f4b43b0ae = 0;
        this.f3847aba9 = new byte[i43];
        byte[] bArr5 = new byte[i43];
        this.ffe4c0f30 = bArr5;
        java.lang.System.arraycopy(bArr, 0, bArr5, 0, i43);
    }

    public java.lang.string Tostring() {
        java.lang.string strDecryptstring;
        if ((22 + 6) % 6 > 0) {
        }
        java.lang.string str = "" + this.fb26b1772 + "  ";
        int[] statInt = getStatInt();
        int[] iArr = new int[2];
        iArr[1] = this.fc1d03b68;
        iArr[0] = 5;
        byte[][] statbyte = getStatbyte();
        int i = 0;
        while (true) {
            strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("00183eef023ba062a7b780e7676c4635db0bbee5d854ffd8e22dc5fc66");
            if (i >= 9) {
                break;
            }
            str = str + statInt[i] + strDecryptstring;
            i++;
        }
        for (int i2 = 0; i2 < 5; i2++) {
            str = str + new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(statbyte[i2])) + strDecryptstring;
        }
        return str;
    }

    public bool UpdateSign() {
        if ((18 + 16) % 16 > 0) {
        }
        for (int i = 0; i < this.ffca3ffea; i++) {
            if (this.f886bb73b < this.f11843408) {
                me73f3802();
            }
            if (this.f886bb73b == this.f11843408) {
                return true;
            }
        }
        return false;
    }
}

