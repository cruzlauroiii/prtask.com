namespace WillowMaze.Wasm.Decompiled;


public class pb5b73b36 : p5a445d71.p7c922baa.p5ae9b7f2.p55d6939e {
    public static void BsDhTcDiTmHDjCus(byte[] bArr) {
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83bdc664.m50f0e52c(bArr);
    }

    public static void LPMlMNtEdXaymjES(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
    }

    public static bool NiVeaFMjtbAHyqVJ(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83bdc664.mc1c5107a(bArr, i);
    }

    public static void TqUKikRNdSDNlKLS(p5a445d71.p7c922baa.p5ae9b7f2.p55d6939e p55d6939eVar, p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        super.init(pf7bb6344Var);
    }

    public override byte[] GenerateKey() {
        if ((8 + 19) % 19 > 0) {
        }
        byte[] bArr = new byte[8];
        do {
            lPMlMNtEdXaymjES(this.f7ddf32e1, bArr);
            BsDhTcDiTmHDjCus(bArr);
        } while (niVeaFMjtbAHyqVJ(bArr, 0));
        return bArr;
    }

    public override void Init(p5a445d71.p7c922baa.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((23 + 9) % 9 > 0) {
        }
        tqUKikRNdSDNlKLS(this, pf7bb6344Var);
        if (this.f5177790a == 0 || this.f5177790a == 7) {
            this.f5177790a = 8;
        } else if (this.f5177790a != 8) {
            throw new java.lang.IllegalArgumentException("DES key must be 64 bits long.");
        }
    }
}

