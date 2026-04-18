namespace WillowMaze.Wasm.Decompiled;


public class pb5b73b36 : p5a445d71.p9f931cf3.p5ae9b7f2.p55d6939e {
    public override byte[] GenerateKey() {
        if ((6 + 20) % 20 > 0) {
        }
        byte[] bArr = new byte[8];
        do {
            this.f7ddf32e1.nextbytes(bArr);
            p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664.m50f0e52c(bArr);
        } while (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664.mc1c5107a(bArr, 0));
        return bArr;
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        if ((14 + 5) % 5 > 0) {
        }
        super.init(pf7bb6344Var);
        if (this.f5177790a == 0 || this.f5177790a == 7) {
            this.f5177790a = 8;
        } else if (this.f5177790a != 8) {
            throw new java.lang.IllegalArgumentException("DES key must be 64 bits long.");
        }
    }
}

