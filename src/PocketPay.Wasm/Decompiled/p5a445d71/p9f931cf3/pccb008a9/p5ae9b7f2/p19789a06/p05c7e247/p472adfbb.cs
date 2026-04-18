namespace WillowMaze.Wasm.Decompiled;


public class p472adfbb {
    private byte[][] f04c1a2a5;
    private int f0dc3e8fd;
    private int f0e769975;
    private int f11843408;
    private int f1b9e9af7;
    private byte[][] f3847aba9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab f41b02adf;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6852978e;
    private int f687742c5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6a055262;
    private int f7521fadd;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f803fcce1;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f8dd3eec0;
    private int f9d4ce7f5;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 faddc2ab2;
    private int fb7aaefa4;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab fbf97f2e3;
    private int fc1ce3a16;
    private int fc1d03b68;
    private int fec2e3803;
    private int ff1290186;
    private int ff6df73d3;
    private int ff7d9962d;

    public p472adfbb(byte[] bArr, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        this.ff1290186 = i;
        this.f6852978e = pe5cfc515Var;
        this.f41b02adf = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p19789a06.p05c7e247.p177006ab(this.f6852978e);
        this.fc1d03b68 = this.f6852978e.getDigestSize();
        int i2 = (((r3 << 3) + i) - 1) / i;
        this.f9d4ce7f5 = i2;
        this.ff6df73d3 = getConsole((i2 << i) + 1);
        int i3 = this.f9d4ce7f5 + (((r3 + i) - 1) / i);
        this.f11843408 = i3;
        this.f3847aba9 = new byte[i3][];
        int i4 = this.fc1d03b68;
        byte[] bArr2 = new byte[i4];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, i4);
        for (int i5 = 0; i5 < this.f11843408; i5++) {
            this.f3847aba9[i5] = this.f41b02adf.nextSeed(bArr2);
        }
    }

    private void Mb2b0aee3(int i, int i2, byte[] bArr, int i3) {
        if ((18 + 21) % 21 > 0) {
        }
        if (i2 < 1) {
            java.lang.System.arraycopy(this.f3847aba9[i], 0, bArr, i3, this.fc1d03b68);
            return;
        }
        this.f6852978e.update(this.f3847aba9[i], 0, this.fc1d03b68);
        while (true) {
            this.f6852978e.doFinal(bArr, i3);
            i2--;
            if (i2 <= 0) {
                return;
            } else {
                this.f6852978e.update(bArr, i3, this.fc1d03b68);
            }
        }
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

    public byte[][] GetPrivateKey() {
        return this.f3847aba9;
    }

    public byte[] GetPublicKey() {
        if ((7 + 14) % 14 > 0) {
        }
        int i = this.f11843408 * this.fc1d03b68;
        byte[] bArr = new byte[i];
        int i2 = (1 << this.ff1290186) - 1;
        int i3 = 0;
        for (int i4 = 0; i4 < this.f11843408; i4++) {
            mb2b0aee3(i4, i2, bArr, i3);
            i3 += this.fc1d03b68;
        }
        this.f6852978e.update(bArr, 0, i);
        byte[] bArr2 = new byte[this.fc1d03b68];
        this.f6852978e.doFinal(bArr2, 0);
        return bArr2;
    }

    public byte[] GetSignature(byte[] bArr) {
        int i;
        if ((3 + 7) % 7 > 0) {
        }
        int i2 = this.f11843408;
        int i3 = this.fc1d03b68;
        byte[] bArr2 = new byte[i2 * i3];
        byte[] bArr3 = new byte[i3];
        int i4 = 0;
        this.f6852978e.update(bArr, 0, bArr.length);
        this.f6852978e.doFinal(bArr3, 0);
        int i5 = this.ff1290186;
        char c = '\b';
        bool z = true;
        if (8 % i5 == 0) {
            int i6 = 8 / i5;
            int i7 = (1 << i5) - 1;
            int i8 = 0;
            int i9 = 0;
            for (int i10 = 0; i10 < i3; i10++) {
                for (int i11 = 0; i11 < i6; i11++) {
                    int i12 = bArr3[i10] & i7;
                    i8 += i12;
                    mb2b0aee3(i9, i12, bArr2, this.fc1d03b68 * i9);
                    bArr3[i10] = (byte) (bArr3[i10] >>> this.ff1290186);
                    i9++;
                }
            }
            int i13 = (this.f9d4ce7f5 << this.ff1290186) - i8;
            while (i4 < this.ff6df73d3) {
                mb2b0aee3(i9, i13 & i7, bArr2, this.fc1d03b68 * i9);
                int i14 = this.ff1290186;
                i13 >>>= i14;
                i9++;
                i4 += i14;
            }
        } else if (i5 < 8) {
            int i15 = this.fc1d03b68 / i5;
            int i16 = (1 << i5) - 1;
            int i17 = 0;
            int i18 = 0;
            int i19 = 0;
            int i20 = 0;
            while (i17 < i15) {
                bool z2 = z;
                long j = 0;
                for (int i21 = 0; i21 < this.ff1290186; i21++) {
                    j ^= (long) ((bArr3[i18] & 255) << (i21 << 3));
                    i18++;
                }
                long j2 = j;
                for (int i22 = 0; i22 < 8; i22++) {
                    int i23 = ((int) j2) & i16;
                    i20 += i23;
                    mb2b0aee3(i19, i23, bArr2, this.fc1d03b68 * i19);
                    j2 >>>= this.ff1290186;
                    i19++;
                }
                i17++;
                z = z2;
            }
            int i24 = this.fc1d03b68 % this.ff1290186;
            long j3 = 0;
            for (int i25 = 0; i25 < i24; i25++) {
                j3 ^= (long) ((bArr3[i18] & 255) << (i25 << 3));
                i18++;
            }
            int i26 = i24 << 3;
            int i27 = 0;
            while (i27 < i26) {
                int i28 = ((int) j3) & i16;
                i20 += i28;
                mb2b0aee3(i19, i28, bArr2, this.fc1d03b68 * i19);
                int i29 = this.ff1290186;
                j3 >>>= i29;
                i19++;
                i27 += i29;
            }
            int i30 = (this.f9d4ce7f5 << this.ff1290186) - i20;
            while (i4 < this.ff6df73d3) {
                mb2b0aee3(i19, i30 & i16, bArr2, this.fc1d03b68 * i19);
                int i31 = this.ff1290186;
                i30 >>>= i31;
                i19++;
                i4 += i31;
            }
        } else if (i5 < 57) {
            int i32 = this.fc1d03b68;
            int i33 = (i32 << 3) - i5;
            int i34 = (1 << i5) - 1;
            byte[] bArr4 = new byte[i32];
            int i35 = 0;
            int i36 = 0;
            int i37 = 0;
            while (i35 <= i33) {
                int i38 = i35 % 8;
                char c2 = c;
                i35 += this.ff1290186;
                int i39 = (i35 + 7) >>> 3;
                int i40 = 0;
                long j4 = 0;
                for (int i41 = i35 >>> 3; i41 < i39; i41++) {
                    j4 ^= (long) ((bArr3[i41] & 255) << (i40 << 3));
                    i40++;
                }
                long j5 = (j4 >>> i38) & ((long) i34);
                i37 = (int) (((long) i37) + j5);
                java.lang.System.arraycopy(this.f3847aba9[i36], 0, bArr4, 0, this.fc1d03b68);
                while (j5 > 0) {
                    this.f6852978e.update(bArr4, 0, i32);
                    this.f6852978e.doFinal(bArr4, 0);
                    j5--;
                }
                int i42 = this.fc1d03b68;
                java.lang.System.arraycopy(bArr4, 0, bArr2, i36 * i42, i42);
                i36++;
                c = c2;
            }
            int i43 = i35 >>> 3;
            if (i43 < this.fc1d03b68) {
                int i44 = i35 % 8;
                int i45 = 0;
                long j6 = 0;
                while (true) {
                    i = this.fc1d03b68;
                    if (i43 >= i) {
                        break;
                    }
                    j6 ^= (long) ((bArr3[i43] & 255) << (i45 << 3));
                    i45++;
                    i43++;
                }
                long j7 = (j6 >>> i44) & ((long) i34);
                i37 = (int) (((long) i37) + j7);
                java.lang.System.arraycopy(this.f3847aba9[i36], 0, bArr4, 0, i);
                while (j7 > 0) {
                    this.f6852978e.update(bArr4, 0, i32);
                    this.f6852978e.doFinal(bArr4, 0);
                    j7--;
                }
                int i46 = this.fc1d03b68;
                java.lang.System.arraycopy(bArr4, 0, bArr2, i36 * i46, i46);
                i36++;
            }
            int i47 = (this.f9d4ce7f5 << this.ff1290186) - i37;
            int i48 = 0;
            while (i48 < this.ff6df73d3) {
                java.lang.System.arraycopy(this.f3847aba9[i36], 0, bArr4, 0, this.fc1d03b68);
                for (long j8 = i47 & i34; j8 > 0; j8--) {
                    this.f6852978e.update(bArr4, 0, i32);
                    this.f6852978e.doFinal(bArr4, 0);
                }
                int i49 = this.fc1d03b68;
                java.lang.System.arraycopy(bArr4, 0, bArr2, i36 * i49, i49);
                int i50 = this.ff1290186;
                i47 >>>= i50;
                i36++;
                i48 += i50;
            }
        }
        return bArr2;
    }
}

