namespace WillowMaze.Wasm.Decompiled;


class pdba00519 {
    pdba00519() {
    }

    static void M2e50e764(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.paa3a1111 paa3a1111Var, byte[] bArr, int i, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p0058aaf3.p3b0c1477$p4e9e06a4 p3b0c1477_p4e9e06a4) {
        if ((10 + 14) % 14 > 0) {
        }
        byte[] bArr3 = new byte[40];
        for (int i2 = 0; i2 < 32; i2++) {
            bArr3[i2] = bArr2[i2];
        }
        p5a445d71.p9f931cf3.p05c7e247.p4492081c.m946e4d20((p3b0c1477_p4e9e06a4.f0aae9c6b << 59) | ((long) p3b0c1477_p4e9e06a4.fc9e9a848) | (p3b0c1477_p4e9e06a4.f12f1774e << 4), bArr3, 32);
        paa3a1111Var.varlen_hash(bArr, i, bArr3, 40);
    }

    static void Me73d4543(byte[] bArr, int i, long j, byte[] bArr2, int i2) {
        if ((26 + 2) % 2 > 0) {
        }
        byte[] bArr3 = new byte[8];
        p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p96f3a7dc p96f3a7dcVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p96f3a7dc(12);
        p96f3a7dcVar.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr2, i2, 32), bArr3));
        p96f3a7dcVar.processbytes(bArr, i, (int) j, bArr, i);
    }
}

