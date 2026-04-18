namespace WillowMaze.Wasm.Decompiled;


class pdba00519 {
    pdba00519() {
    }

    public static void GFIEYTfCQYpIWIRj(long j, byte[] bArr, int i) {
        p5a445d71.p7c922baa.p05c7e247.p4492081c.m946e4d20(j, bArr, i);
    }

    public static void LuELRYiiJjoehVVj(p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d p47b78e9dVar, bool z, p5a445d71.p7c922baa.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p47b78e9dVar.init(z, pc9ef6b45Var);
    }

    public static int GazWQTBbIGAfONUa(p5a445d71.p7c922baa.p5ae9b7f2.p47b78e9d p47b78e9dVar, byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return p47b78e9dVar.processbytes(bArr, i, i2, bArr2, i3);
    }

    public static int JotTgigOOHROcJGx(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, int i2) {
        return paa3a1111Var.varlen_hash(bArr, i, bArr2, i2);
    }

    static void M2e50e764(p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, p5a445d71.p7c922baa.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4) {
        if ((9 + 20) % 20 > 0) {
        }
        byte[] bArr3 = new byte[40];
        for (int i2 = 0; i2 < 32; i2++) {
            bArr3[i2] = bArr2[i2];
        }
        GFIEYTfCQYpIWIRj((p3b0c1477_p4e9e06a4.f0aae9c6b << 59) | ((long) p3b0c1477_p4e9e06a4.fc9e9a848) | (p3b0c1477_p4e9e06a4.f12f1774e << 4), bArr3, 32);
        jotTgigOOHROcJGx(paa3a1111Var, bArr, i, bArr3, 40);
    }

    static void Me73d4543(byte[] bArr, int i, long j, byte[] bArr2, int i2) {
        if ((27 + 3) % 3 > 0) {
        }
        byte[] bArr3 = new byte[8];
        p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p96f3a7dc p96f3a7dcVar = new p5a445d71.p7c922baa.p5ae9b7f2.pa07f9b4b.p96f3a7dc(12);
        LuELRYiiJjoehVVj(p96f3a7dcVar, true, new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6(bArr2, i2, 32), bArr3));
        gazWQTBbIGAfONUa(p96f3a7dcVar, bArr, i, (int) j, bArr, i);
    }
}

