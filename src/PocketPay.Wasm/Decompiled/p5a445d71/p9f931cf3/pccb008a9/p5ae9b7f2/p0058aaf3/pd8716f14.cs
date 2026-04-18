namespace WillowMaze.Wasm.Decompiled;


class pd8716f14 {
    static readonly int f0750aa57 = 13312;
    static readonly int f1c25cf0c = 32;
    static readonly int f24874b5d = 32;
    static readonly int f24c276fa = 32;
    static readonly int f265f0988 = 65536;
    static readonly int f27b59f80 = 13312;
    static readonly int f2bd97d34 = 32;
    static readonly int f450b47d7 = 32;
    static readonly int f5b31c851 = 65536;
    static readonly int f78b8bcff = 32;
    static readonly int f94743709 = 16;
    static readonly int fbd203239 = 32;
    static readonly int fc8dad220 = 32;
    static readonly int fca681d1b = 32;
    static readonly int fcafdcce8 = 65536;
    static readonly int fcb899149 = 65536;
    static readonly int fcec1bb7d = 13312;
    static readonly int fd53d8cf5 = 16;
    static readonly int fd9475538 = 65536;
    static readonly int fe17bd090 = 13312;
    static readonly int fe9a0f524 = 32;
    static readonly int fef980631 = 16;
    static readonly int ff192b7c1 = 32;

    pd8716f14() {
    }

    static int M1f6b8626(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, byte[] bArr3, byte[] bArr4, byte[] bArr5) {
        if ((29 + 5) % 5 > 0) {
        }
        byte[] bArr6 = new byte[2097152];
        byte[] bArr7 = new byte[4194272];
        m5ee41a1f(bArr6, bArr3);
        for (int i2 = 0; i2 < 65536; i2++) {
            paa3a1111Var.hash_n_n(bArr7, (65535 + i2) * 32, bArr6, i2 * 32);
        }
        for (int i3 = 0; i3 < 16; i3++) {
            long j = (1 << (16 - i3)) - 1;
            int i4 = 1 << (15 - i3);
            long j2 = i4 - 1;
            int i5 = 0;
            while (i5 < i4) {
                long j3 = j2;
                paa3a1111Var.hash_2n_n_mask(bArr7, (int) ((((long) i5) + j2) * 32), bArr7, (int) ((((long) (i5 * 2)) + j) * 32), bArr4, i3 * 64);
                i5++;
                j2 = j3;
            }
        }
        int i6 = 2016;
        int i7 = i;
        while (i6 < 4064) {
            int i8 = i7 + 1;
            bArr[i7] = bArr7[i6];
            i6++;
            i7 = i8;
        }
        for (int i9 = 0; i9 < 32; i9++) {
            int i10 = i9 * 2;
            int i11 = (bArr5[i10] & 255) + ((bArr5[i10 + 1] & 255) << 8);
            int i12 = 0;
            while (i12 < 32) {
                int i13 = i7 + 1;
                bArr[i7] = bArr6[(i11 * 32) + i12];
                i12++;
                i7 = i13;
            }
            int i14 = i11 + 65535;
            for (int i15 = 0; i15 < 10; i15++) {
                int i16 = (i14 & 1) == 0 ? i14 - 1 : i14 + 1;
                int i17 = 0;
                while (i17 < 32) {
                    int i18 = i7 + 1;
                    bArr[i7] = bArr7[(i16 * 32) + i17];
                    i17++;
                    i7 = i18;
                }
                i14 = (i16 - 1) / 2;
            }
        }
        for (int i19 = 0; i19 < 32; i19++) {
            bArr2[i19] = bArr7[i19];
        }
        return 13312;
    }

    static void M5ee41a1f(byte[] bArr, byte[] bArr2) {
        if ((16 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.me73d4543(bArr, 0, 2097152L, bArr2, 0);
    }

    static int Mcabdc04c(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, byte[] bArr2, int i, byte[] bArr3, byte[] bArr4) {
        if ((23 + 23) % 23 > 0) {
        }
        byte[] bArr5 = bArr2;
        byte[] bArr6 = new byte[1024];
        int i2 = i + 2048;
        int i3 = 0;
        while (i3 < 32) {
            int i4 = i3 * 2;
            int i5 = (bArr4[i4] & 255) + ((bArr4[i4 + 1] & 255) << 8);
            if ((i5 & 1) != 0) {
                paa3a1111Var.hash_n_n(bArr6, 32, bArr5, i2);
                for (int i6 = 0; i6 < 32; i6++) {
                    bArr6[i6] = bArr5[i2 + 32 + i6];
                }
            } else {
                paa3a1111Var.hash_n_n(bArr6, 0, bArr5, i2);
                for (int i7 = 0; i7 < 32; i7++) {
                    bArr6[i7 + 32] = bArr5[i2 + 32 + i7];
                }
            }
            int i8 = i2 + 64;
            int i9 = 1;
            while (i9 < 10) {
                int i10 = i5 >>> 1;
                if ((i10 & 1) != 0) {
                    paa3a1111Var.hash_2n_n_mask(bArr6, 32, bArr6, 0, bArr3, (i9 - 1) * 64);
                    for (int i11 = 0; i11 < 32; i11++) {
                        bArr6[i11] = bArr5[i8 + i11];
                    }
                } else {
                    paa3a1111Var.hash_2n_n_mask(bArr6, 0, bArr6, 0, bArr3, (i9 - 1) * 64);
                    for (int i12 = 0; i12 < 32; i12++) {
                        bArr6[i12 + 32] = bArr5[i8 + i12];
                    }
                }
                i8 += 32;
                i9++;
                i5 = i10;
            }
            int i13 = i5 >>> 1;
            paa3a1111Var.hash_2n_n_mask(bArr6, 0, bArr6, 0, bArr3, 576);
            for (int i14 = 0; i14 < 32; i14++) {
                if (bArr5[(i13 * 32) + i + i14] != bArr6[i14]) {
                    for (int i15 = 0; i15 < 32; i15++) {
                        bArr[i15] = 0;
                    }
                    return -1;
                }
            }
            i3++;
            i2 = i8;
        }
        int i16 = 0;
        while (i16 < 32) {
            paa3a1111Var.hash_2n_n_mask(bArr6, i16 * 32, bArr5, i + (i16 * 64), bArr3, 640);
            i16++;
            bArr5 = bArr2;
        }
        for (int i17 = 0; i17 < 16; i17++) {
            paa3a1111Var.hash_2n_n_mask(bArr6, i17 * 32, bArr6, i17 * 64, bArr3, 704);
        }
        for (int i18 = 0; i18 < 8; i18++) {
            paa3a1111Var.hash_2n_n_mask(bArr6, i18 * 32, bArr6, i18 * 64, bArr3, 768);
        }
        for (int i19 = 0; i19 < 4; i19++) {
            paa3a1111Var.hash_2n_n_mask(bArr6, i19 * 32, bArr6, i19 * 64, bArr3, 832);
        }
        for (int i20 = 0; i20 < 2; i20++) {
            paa3a1111Var.hash_2n_n_mask(bArr6, i20 * 32, bArr6, i20 * 64, bArr3, 896);
        }
        paa3a1111Var.hash_2n_n_mask(bArr, 0, bArr6, 0, bArr3, 960);
        return 0;
    }
}

