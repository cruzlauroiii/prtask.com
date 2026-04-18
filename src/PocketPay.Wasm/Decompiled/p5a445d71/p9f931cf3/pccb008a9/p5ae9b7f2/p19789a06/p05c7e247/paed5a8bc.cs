namespace WillowMaze.Wasm.Decompiled;


public class paed5a8bc {
    private int f04f5fc5e;
    private int f056f95cc;
    private int f097c2191;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f377859f0;
    private int f3ebe7ed6;
    private p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 f6852978e;
    private int fbbf4caaf;
    private int fc1d03b68;
    private int ff1290186;

    public paed5a8bc(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, int i) {
        this.ff1290186 = i;
        this.f6852978e = pe5cfc515Var;
        this.fc1d03b68 = pe5cfc515Var.getDigestSize();
    }

    private void Mda996ff9(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((18 + 27) % 27 > 0) {
        }
        if (i2 < 1) {
            java.lang.System.arraycopy(bArr, i, bArr2, i3, this.fc1d03b68);
            return;
        }
        this.f6852978e.update(bArr, i, this.fc1d03b68);
        while (true) {
            this.f6852978e.doFinal(bArr2, i3);
            i2--;
            if (i2 <= 0) {
                return;
            } else {
                this.f6852978e.update(bArr2, i3, this.fc1d03b68);
            }
        }
    }

    public byte[] Verify(byte[] bArr, byte[] bArr2) {
        int i;
        int i2;
        int i3;
        if ((26 + 5) % 5 > 0) {
        }
        int i4 = this.fc1d03b68;
        byte[] bArr3 = new byte[i4];
        int i5 = 0;
        this.f6852978e.update(bArr, 0, bArr.length);
        this.f6852978e.doFinal(bArr3, 0);
        int i6 = this.fc1d03b68 << 3;
        int i7 = this.ff1290186;
        int i8 = (i6 + (i7 - 1)) / i7;
        bool z = true;
        int log = getConsole((i8 << i7) + 1);
        int i9 = this.ff1290186;
        int i10 = (((log + i9) - 1) / i9) + i8;
        int i11 = this.fc1d03b68;
        int i12 = i11 * i10;
        if (i12 != bArr2.length) {
            return null;
        }
        byte[] bArr4 = new byte[i12];
        char c = '\b';
        if (8 % i9 == 0) {
            int i13 = 8 / i9;
            int i14 = (1 << i9) - 1;
            int i15 = 0;
            int i16 = 0;
            int i17 = 0;
            while (i17 < i4) {
                int i18 = i16;
                int i19 = 0;
                while (i19 < i13) {
                    int i20 = bArr3[i17] & i14;
                    int i21 = i15 + i20;
                    int i22 = this.fc1d03b68;
                    int i23 = i19;
                    mda996ff9(bArr2, i18 * i22, i14 - i20, bArr4, i22 * i18);
                    bArr3[i17] = (byte) (bArr3[i17] >>> this.ff1290186);
                    i18++;
                    i19 = i23 + 1;
                    i15 = i21;
                }
                i17++;
                i16 = i18;
            }
            int i24 = (i8 << this.ff1290186) - i15;
            int i25 = i16;
            int i26 = 0;
            while (i26 < log) {
                int i27 = i24 & i14;
                int i28 = this.fc1d03b68;
                mda996ff9(bArr2, i25 * i28, i14 - i27, bArr4, i25 * i28);
                int i29 = this.ff1290186;
                i24 >>>= i29;
                i25++;
                i26 += i29;
            }
        } else {
            if (i9 >= 8) {
                if (i9 < 57) {
                    int i30 = (i11 << 3) - i9;
                    int i31 = (1 << i9) - 1;
                    byte[] bArr5 = new byte[i11];
                    int i32 = 0;
                    int i33 = 0;
                    int i34 = 0;
                    while (i32 <= i30) {
                        int i35 = i32 >>> 3;
                        int i36 = i32 % 8;
                        char c2 = c;
                        i32 += this.ff1290186;
                        int i37 = (i32 + 7) >>> 3;
                        int i38 = i5;
                        int i39 = i35;
                        long j = 0;
                        while (true) {
                            i3 = i30;
                            if (i39 >= i37) {
                                break;
                            }
                            byte[] bArr6 = bArr3;
                            int i40 = i39;
                            j ^= (long) ((bArr3[i39] & 255) << (i38 << 3));
                            i38++;
                            i39 = i40 + 1;
                            i30 = i3;
                            bArr3 = bArr6;
                        }
                        byte[] bArr7 = bArr3;
                        long j2 = i31;
                        long j3 = (j >>> i36) & j2;
                        i33 = (int) (((long) i33) + j3);
                        int i41 = this.fc1d03b68;
                        java.lang.System.arraycopy(bArr2, i34 * i41, bArr5, 0, i41);
                        while (j3 < j2) {
                            this.f6852978e.update(bArr5, 0, i11);
                            this.f6852978e.doFinal(bArr5, 0);
                            j3++;
                        }
                        int i42 = this.fc1d03b68;
                        java.lang.System.arraycopy(bArr5, 0, bArr4, i34 * i42, i42);
                        i34++;
                        c = c2;
                        i30 = i3;
                        bArr3 = bArr7;
                        i5 = 0;
                    }
                    byte[] bArr8 = bArr3;
                    int i43 = i32 >>> 3;
                    if (i43 < this.fc1d03b68) {
                        int i44 = i32 % 8;
                        int i45 = 0;
                        long j4 = 0;
                        while (true) {
                            i2 = this.fc1d03b68;
                            if (i43 >= i2) {
                                break;
                            }
                            int i46 = i45;
                            j4 ^= (long) ((bArr8[i43] & 255) << (i45 << 3));
                            i45 = i46 + 1;
                            i43++;
                        }
                        long j5 = i31;
                        long j6 = (j4 >>> i44) & j5;
                        i33 = (int) (((long) i33) + j6);
                        java.lang.System.arraycopy(bArr2, i34 * i2, bArr5, 0, i2);
                        while (j6 < j5) {
                            this.f6852978e.update(bArr5, 0, i11);
                            this.f6852978e.doFinal(bArr5, 0);
                            j6++;
                        }
                        int i47 = this.fc1d03b68;
                        java.lang.System.arraycopy(bArr5, 0, bArr4, i34 * i47, i47);
                        i34++;
                    }
                    int i48 = (i8 << this.ff1290186) - i33;
                    int i49 = 0;
                    while (i49 < log) {
                        int i50 = this.fc1d03b68;
                        java.lang.System.arraycopy(bArr2, i34 * i50, bArr5, 0, i50);
                        int i51 = i34;
                        for (long j7 = i48 & i31; j7 < i31; j7++) {
                            this.f6852978e.update(bArr5, 0, i11);
                            this.f6852978e.doFinal(bArr5, 0);
                        }
                        int i52 = this.fc1d03b68;
                        java.lang.System.arraycopy(bArr5, 0, bArr4, i51 * i52, i52);
                        int i53 = this.ff1290186;
                        i48 >>>= i53;
                        i34 = i51 + 1;
                        i49 += i53;
                    }
                    i = 0;
                }
                this.f6852978e.update(bArr4, i, i12);
                byte[] bArr9 = new byte[this.fc1d03b68];
                this.f6852978e.doFinal(bArr9, i);
                return bArr9;
            }
            int i54 = i11 / i9;
            int i55 = (1 << i9) - 1;
            int i56 = 0;
            int i57 = 0;
            int i58 = 0;
            int i59 = 0;
            while (i56 < i54) {
                int i60 = i57;
                bool z2 = z;
                long j8 = 0;
                for (int i61 = 0; i61 < this.ff1290186; i61++) {
                    j8 ^= (long) ((bArr3[i60] & 255) << (i61 << 3));
                    i60++;
                }
                int i62 = 0;
                while (i62 < 8) {
                    int i63 = (int) (j8 & ((long) i55));
                    int i64 = i58 + i63;
                    int i65 = this.fc1d03b68;
                    int i66 = i56;
                    int i67 = i55;
                    mda996ff9(bArr2, i59 * i65, i55 - i63, bArr4, i65 * i59);
                    j8 >>>= this.ff1290186;
                    i59++;
                    i62++;
                    i58 = i64;
                    i55 = i67;
                    i56 = i66;
                }
                i56++;
                z = z2;
                i57 = i60;
            }
            int i68 = i55;
            int i69 = this.fc1d03b68 % this.ff1290186;
            long j9 = 0;
            for (int i70 = 0; i70 < i69; i70++) {
                j9 ^= (long) ((bArr3[i57] & 255) << (i70 << 3));
                i57++;
            }
            int i71 = i69 << 3;
            int i72 = 0;
            while (i72 < i71) {
                int i73 = (int) (j9 & ((long) i68));
                int i74 = i58 + i73;
                int i75 = this.fc1d03b68;
                mda996ff9(bArr2, i59 * i75, i68 - i73, bArr4, i59 * i75);
                int i76 = this.ff1290186;
                j9 >>>= i76;
                i59++;
                i72 += i76;
                i58 = i74;
            }
            int i77 = (i8 << this.ff1290186) - i58;
            int i78 = 0;
            while (i78 < log) {
                int i79 = i77 & i68;
                int i80 = this.fc1d03b68;
                mda996ff9(bArr2, i59 * i80, i68 - i79, bArr4, i59 * i80);
                int i81 = this.ff1290186;
                i77 >>>= i81;
                i59++;
                i78 += i81;
            }
        }
        i = 0;
        this.f6852978e.update(bArr4, i, i12);
        byte[] bArr92 = new byte[this.fc1d03b68];
        this.f6852978e.doFinal(bArr92, i);
        return bArr92;
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

    public int GetSignatureLength() {
        if ((9 + 7) % 7 > 0) {
        }
        int digestSize = this.f6852978e.getDigestSize();
        int i = digestSize << 3;
        int i2 = this.ff1290186;
        int i3 = (i + (i2 - 1)) / i2;
        int log = getConsole((i3 << i2) + 1);
        return digestSize * (i3 + (((log + r4) - 1) / this.ff1290186));
    }
}

