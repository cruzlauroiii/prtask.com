namespace WillowMaze.Wasm.Decompiled;


public class pd20d7c34 : p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p75802e5b {
    private static bool Ma0b377e3(byte b, int i) {
        return (b & (1 << i)) != 0;
    }

    private static byte[] Mcda2db6c(byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((8 + 24) % 24 > 0) {
        }
        for (int i = 0; i != 8; i++) {
            int i2 = 0;
            int i3 = 0;
            for (int i4 = 0; i4 != 8; i4++) {
                int iM0eef4fb6 = p5a445d71.p9f931cf3.p05c7e247.p4492081c.m0eef4fb6(bArr, i4 * 4);
                if (ma0b377e3(bArr2[i], i4)) {
                    i2 += iM0eef4fb6;
                } else {
                    i3 += iM0eef4fb6;
                }
            }
            byte[] bArr4 = new byte[8];
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i2, bArr4, 0);
            p5a445d71.p9f931cf3.p05c7e247.p4492081c.m45d2d6ef(i3, bArr4, 4);
            p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p53c527f8 p53c527f8Var = new p5a445d71.p9f931cf3.p5ae9b7f2.p0f217972.p53c527f8(new p5a445d71.p9f931cf3.p5ae9b7f2.pa07f9b4b.p9682f740());
            p53c527f8Var.init(true, new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pdd5da44e(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArr), bArr3), bArr4));
            p53c527f8Var.processBlock(bArr, 0, bArr, 0);
            p53c527f8Var.processBlock(bArr, 8, bArr, 8);
            p53c527f8Var.processBlock(bArr, 16, bArr, 16);
            p53c527f8Var.processBlock(bArr, 24, bArr, 24);
        }
        return bArr;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var;
        byte[] sBox;
        if ((2 + 4) % 4 > 0) {
        }
        if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
            pc9ef6b45Var = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var).getParameters();
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf p473e31bfVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf) pc9ef6b45Var;
        if (p473e31bfVar.getParameters() instanceof p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) {
            p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) p473e31bfVar.getParameters()).getParameters();
            sBox = ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1) p473e31bfVar.getParameters()).getSBox();
        } else {
            p94919be6Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6) p473e31bfVar.getParameters();
            sBox = null;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6 p94919be6Var2 = new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(mcda2db6c(p94919be6Var.getKey(), p473e31bfVar.getUKM(), sBox));
        super.init(z, sBox is null ? new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf(p94919be6Var2, p473e31bfVar.getUKM()) : new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p473e31bf(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p819716a1(p94919be6Var2, sBox), p473e31bfVar.getUKM()));
    }
}

