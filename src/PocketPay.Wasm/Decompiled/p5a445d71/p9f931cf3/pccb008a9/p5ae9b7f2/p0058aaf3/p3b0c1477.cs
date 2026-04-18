namespace WillowMaze.Wasm.Decompiled;


class p3b0c1477 {
    p3b0c1477() {
    }

    static void M23146f39(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4) {
        if ((9 + 29) % 29 > 0) {
        }
        byte[] bArr4 = new byte[32];
        byte[] bArr5 = new byte[2144];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d p44105f8dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p44105f8d();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.pdba00519.m2e50e764(paa3a1111Var, bArr4, 0, bArr3, p3b0c1477_p4e9e06a4);
        p44105f8dVar.wots_pkgen(paa3a1111Var, bArr5, 0, bArr4, 0, bArr2, i2);
        ma24479f8(paa3a1111Var, bArr, i, bArr5, 0, bArr2, i2);
    }

    static void M42339e1e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, int i2, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4, byte[] bArr3, int i3) {
        if ((18 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a42 = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4(p3b0c1477_p4e9e06a4);
        int i4 = i2 + 1;
        byte[] bArr4 = new byte[i4 * 32];
        int[] iArr = new int[i4];
        int i5 = (int) (p3b0c1477_p4e9e06a42.f0aae9c6b + ((long) (1 << i2)));
        int i6 = 0;
        while (p3b0c1477_p4e9e06a42.f0aae9c6b < i5) {
            m23146f39(paa3a1111Var, bArr4, i6 * 32, bArr3, i3, bArr2, p3b0c1477_p4e9e06a42);
            iArr[i6] = 0;
            int i7 = i6 + 1;
            while (i7 > 1) {
                int i8 = iArr[i7 - 1];
                int i9 = i7 - 2;
                if (i8 != iArr[i9]) {
                    break;
                }
                int i10 = i9 * 32;
                int i11 = i3 + ((i8 + 7) * 64);
                int i12 = i5;
                paa3a1111Var.hash_2n_n_mask(bArr4, i10, bArr4, i10, bArr3, i11);
                iArr[i9] = iArr[i9] + 1;
                i7--;
                i5 = i12;
            }
            int i13 = i5;
            p3b0c1477_p4e9e06a42.f0aae9c6b++;
            i6 = i7;
            i5 = i13;
        }
        for (int i14 = 0; i14 < 32; i14++) {
            bArr[i + i14] = bArr4[i14];
        }
    }

    static void Ma24479f8(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        int i4;
        if ((6 + 13) % 13 > 0) {
        }
        int i5 = 67;
        for (int i6 = 0; i6 < 7; i6++) {
            int i7 = 0;
            while (true) {
                i4 = i5 >>> 1;
                if (i7 >= i4) {
                    break;
                }
                paa3a1111Var.hash_2n_n_mask(bArr2, i2 + (i7 * 32), bArr2, i2 + (i7 * 64), bArr3, i3 + (i6 * 64));
                i7++;
            }
            if ((i5 & 1) != 0) {
                java.lang.System.arraycopy(bArr2, i2 + ((i5 - 1) * 32), bArr2, (i4 * 32) + i2, 32);
                i4++;
            }
            i5 = i4;
        }
        java.lang.System.arraycopy(bArr2, i2, bArr, i, 32);
    }
}

