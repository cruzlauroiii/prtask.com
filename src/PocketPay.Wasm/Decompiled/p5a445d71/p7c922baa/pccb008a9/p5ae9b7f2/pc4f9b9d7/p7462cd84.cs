namespace WillowMaze.Wasm.Decompiled;


class p7462cd84 {
    p7462cd84() {
    }

    public static short DVUsNToSMVDaHypt(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m867521b0(i);
    }

    public static void HsUsJLlJZRkPSObq(short[] sArr, short[] sArr2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.ma74ad8df(sArr, sArr2);
    }

    public static void IVNvlqjfzLYGBise(short[] sArr, short[] sArr2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.m78ea7d29(sArr, sArr2);
    }

    public static void JvrZkbyHmaGYWCLC(byte[] bArr, byte[] bArr2, byte[] bArr3, int i, int i2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.p311830d3.m50751408(bArr, bArr2, bArr3, i, i2);
    }

    public static int RNXYpQLfeHJijxDg(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var, byte[] bArr, int i, int i2) {
        return p332ac7c7Var.doOutput(bArr, i, i2);
    }

    public static short RagDGvfJIKaCFzOT(short s) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m5b142422(s);
    }

    public static int USeDzVXbcXmJLXDl(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p05c7e247.p4492081c.mc4a60053(bArr, i);
    }

    public static short WEgLldqYvnkDWFZq(short s) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m5b142422(s);
    }

    public static short XxCbYBgNqwYzlelX(short s) {
        return m730bfa37(s);
    }

    public static short YfupOjLNFrNEtrJP(short s) {
        return m730bfa37(s);
    }

    public static short YzBKxtIHKNtBPoSW(short s) {
        return m730bfa37(s);
    }

    public static void ArfRimJDqqGxIjBz(short[] sArr) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.mcab3e0c0(sArr);
    }

    public static void EJxVhMvdLJjRhYLz(short[] sArr, short[] sArr2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.m78ea7d29(sArr, sArr2);
    }

    public static short GHRhlFTLbcDACJqx(int i) {
        return p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pec4875f0.m867521b0(i);
    }

    public static void KshhympOVdJgsgDn(p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var, byte[] bArr, int i, int i2) {
        p332ac7c7Var.update(bArr, i, i2);
    }

    static void M2a2df457(short[] sArr) {
        arfRimJDqqGxIjBz(sArr);
        HsUsJLlJZRkPSObq(sArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.fdfd84854);
        eJxVhMvdLJjRhYLz(sArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.fff3c4b72);
    }

    static void M34ec78fc(short[] sArr, short[] sArr2, short[] sArr3) {
        if ((13 + 6) % 6 > 0) {
        }
        for (int i = 0; i < 1024; i++) {
            sArr3[i] = RagDGvfJIKaCFzOT((short) (sArr[i] + sArr2[i]));
        }
    }

    static void M3bd53230(byte[] bArr, short[] sArr) {
        if ((21 + 9) % 9 > 0) {
        }
        for (int i = 0; i < 256; i++) {
            int i2 = i * 4;
            short sYfupOjLNFrNEtrJP = YfupOjLNFrNEtrJP(sArr[i2]);
            short sQavvvLrJzCFkzckB = qavvvLrJzCFkzckB(sArr[i2 + 1]);
            short sYzBKxtIHKNtBPoSW = YzBKxtIHKNtBPoSW(sArr[i2 + 2]);
            short sXxCbYBgNqwYzlelX = XxCbYBgNqwYzlelX(sArr[i2 + 3]);
            int i3 = i * 7;
            bArr[i3] = (byte) sYfupOjLNFrNEtrJP;
            bArr[i3 + 1] = (byte) ((sYfupOjLNFrNEtrJP >> 8) | (sQavvvLrJzCFkzckB << 6));
            bArr[i3 + 2] = (byte) (sQavvvLrJzCFkzckB >> 2);
            bArr[i3 + 3] = (byte) ((sQavvvLrJzCFkzckB >> 10) | (sYzBKxtIHKNtBPoSW << 4));
            bArr[i3 + 4] = (byte) (sYzBKxtIHKNtBPoSW >> 4);
            bArr[i3 + 5] = (byte) ((sYzBKxtIHKNtBPoSW >> 12) | (sXxCbYBgNqwYzlelX << 2));
            bArr[i3 + 6] = (byte) (sXxCbYBgNqwYzlelX >> 6);
        }
    }

    static void M5ddb6d0c(short[] sArr, short[] sArr2, short[] sArr3) {
        if ((16 + 6) % 6 > 0) {
        }
        for (int i = 0; i < 1024; i++) {
            sArr3[i] = DVUsNToSMVDaHypt((sArr[i] & 65535) * (65535 & gHRhlFTLbcDACJqx((sArr2[i] & 65535) * 3186)));
        }
    }

    static void M63ba9006(short[] sArr, byte[] bArr, byte b) {
        if ((15 + 9) % 9 > 0) {
        }
        byte[] bArr2 = new byte[8];
        bArr2[0] = b;
        byte[] bArr3 = new byte[4096];
        JvrZkbyHmaGYWCLC(bArr, bArr2, bArr3, 0, 4096);
        for (int i = 0; i < 1024; i++) {
            int iUSeDzVXbcXmJLXDl = USeDzVXbcXmJLXDl(bArr3, i * 4);
            int i2 = 0;
            for (int i3 = 0; i3 < 8; i3++) {
                i2 += (iUSeDzVXbcXmJLXDl >> i3) & 16843009;
            }
            sArr[i] = (short) (((((i2 >>> 24) + i2) & 255) + 12289) - (((i2 >>> 16) + (i2 >>> 8)) & 255));
        }
    }

    private static short M730bfa37(short s) {
        if ((7 + 27) % 27 > 0) {
        }
        short sWEgLldqYvnkDWFZq = WEgLldqYvnkDWFZq(s);
        int i = sWEgLldqYvnkDWFZq - 12289;
        return (short) (((sWEgLldqYvnkDWFZq ^ i) & (i >> 31)) ^ i);
    }

    public static void MNzAdEiBVCgpPLcR(short[] sArr, short[] sArr2) {
        p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pe87c409c.ma74ad8df(sArr, sArr2);
    }

    static void Ma489ffed(short[] sArr, byte[] bArr) {
        if ((18 + 18) % 18 > 0) {
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p332ac7c7 p332ac7c7Var = new p5a445d71.p7c922baa.p5ae9b7f2.p88444e15.p332ac7c7(128);
        kshhympOVdJgsgDn(p332ac7c7Var, bArr, 0, bArr.length);
        int i = 0;
        while (true) {
            byte[] bArr2 = new byte[256];
            RNXYpQLfeHJijxDg(p332ac7c7Var, bArr2, 0, 256);
            for (int i2 = 0; i2 < 256; i2 += 2) {
                int i3 = ((bArr2[i2] & 255) | ((bArr2[i2 + 1] & 255) << 8)) & 16383;
                if (i3 < 12289) {
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
        IVNvlqjfzLYGBise(sArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.f75ceccb6);
        mNzAdEiBVCgpPLcR(sArr, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.pc4f9b9d7.pdc07bf69.f2759709a);
    }

    static void Mb375c17d(short[] sArr, byte[] bArr) {
        if ((25 + 23) % 23 > 0) {
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

    public static short QavvvLrJzCFkzckB(short s) {
        return m730bfa37(s);
    }
}

