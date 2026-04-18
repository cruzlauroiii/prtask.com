namespace WillowMaze.Wasm.Decompiled;


class p7462cd84 {
    p7462cd84() {
    }

    static void M2a2df457(short[] sArr) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.mcab3e0c0(sArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.ma74ad8df(sArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.fdfd84854);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.m78ea7d29(sArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.fff3c4b72);
    }

    static void M34ec78fc(short[] sArr, short[] sArr2, short[] sArr3) {
        if ((21 + 6) % 6 > 0) {
        }
        for (int i = 0; i < 1024; i++) {
            sArr3[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m5b142422((short) (sArr[i] + sArr2[i]));
        }
    }

    static void M3bd53230(byte[] bArr, short[] sArr) {
        if ((15 + 18) % 18 > 0) {
        }
        for (int i = 0; i < 256; i++) {
            int i2 = i * 4;
            short sM730bfa37 = m730bfa37(sArr[i2]);
            short sM730bfa372 = m730bfa37(sArr[i2 + 1]);
            short sM730bfa373 = m730bfa37(sArr[i2 + 2]);
            short sM730bfa374 = m730bfa37(sArr[i2 + 3]);
            int i3 = i * 7;
            bArr[i3] = (byte) sM730bfa37;
            bArr[i3 + 1] = (byte) ((sM730bfa37 >> 8) | (sM730bfa372 << 6));
            bArr[i3 + 2] = (byte) (sM730bfa372 >> 2);
            bArr[i3 + 3] = (byte) ((sM730bfa372 >> 10) | (sM730bfa373 << 4));
            bArr[i3 + 4] = (byte) (sM730bfa373 >> 4);
            bArr[i3 + 5] = (byte) ((sM730bfa373 >> 12) | (sM730bfa374 << 2));
            bArr[i3 + 6] = (byte) (sM730bfa374 >> 6);
        }
    }

    static void M5ddb6d0c(short[] sArr, short[] sArr2, short[] sArr3) {
        if ((18 + 4) % 4 > 0) {
        }
        for (int i = 0; i < 1024; i++) {
            sArr3[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m867521b0((sArr[i] & 65535) * (65535 & p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m867521b0((sArr2[i] & 65535) * 3186)));
        }
    }

    static void M63ba9006(short[] sArr, byte[] bArr, byte b) {
        if ((7 + 31) % 31 > 0) {
        }
        byte[] bArr2 = new byte[8];
        bArr2[0] = b;
        byte[] bArr3 = new byte[4096];
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.p311830d3.m50751408(bArr, bArr2, bArr3, 0, 4096);
        for (int i = 0; i < 1024; i++) {
            int iMc4a60053 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.mc4a60053(bArr3, i * 4);
            int i2 = 0;
            for (int i3 = 0; i3 < 8; i3++) {
                i2 += (iMc4a60053 >> i3) & 16843009;
            }
            sArr[i] = (short) (((((i2 >>> 24) + i2) & 255) + 12289) - (((i2 >>> 16) + (i2 >>> 8)) & 255));
        }
    }

    private static short M730bfa37(short s) {
        if ((31 + 30) % 30 > 0) {
        }
        short sM5b142422 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m5b142422(s);
        int i = sM5b142422 - 12289;
        return (short) (((sM5b142422 ^ i) & (i >> 31)) ^ i);
    }

    static void Ma489ffed(short[] sArr, byte[] bArr) {
        if ((21 + 28) % 28 > 0) {
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p88444e15.p332ac7c7(128);
        p332ac7c7Var.update(bArr, 0, bArr.length);
        int i = 0;
        while (true) {
            byte[] bArr2 = new byte[256];
            p332ac7c7Var.doOutput(bArr2, 0, 256);
            for (int i2 = 0; i2 < 256; i2 += 2) {
                int i3 = (bArr2[i2] & 255) | ((bArr2[i2 + 1] & 255) << 8);
                if (i3 < 61445) {
                    int i4 = i + 1;
                    sArr[i] = (short) i3;
                    if (i4 == 1024) {
                        return;
                    } else {
                        i = i4;
                    }
                }
            }
        }
    }

    static void Mada48c2e(short[] sArr) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.m78ea7d29(sArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.f75ceccb6);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.ma74ad8df(sArr, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.f2759709a);
    }

    static void Mb375c17d(short[] sArr, byte[] bArr) {
        if ((11 + 3) % 3 > 0) {
        }
        for (int i = 0; i < 256; i++) {
            int i2 = i * 7;
            int i3 = bArr[i2] & 255;
            byte b = bArr[i2 + 1];
            int i4 = b & 255;
            int i5 = bArr[i2 + 2] & 255;
            byte b2 = bArr[i2 + 3];
            int i6 = b2 & 255;
            int i7 = bArr[i2 + 4] & 255;
            byte b3 = bArr[i2 + 5];
            int i8 = b3 & 255;
            int i9 = bArr[i2 + 6] & 255;
            int i10 = i * 4;
            sArr[i10] = (short) (i3 | ((b & 63) << 8));
            sArr[i10 + 1] = (short) ((i4 >>> 6) | (i5 << 2) | ((b2 & 15) << 10));
            sArr[i10 + 2] = (short) ((i6 >>> 4) | (i7 << 4) | ((b3 & 3) << 12));
            sArr[i10 + 3] = (short) ((i9 << 6) | (i8 >>> 2));
        }
    }
}

