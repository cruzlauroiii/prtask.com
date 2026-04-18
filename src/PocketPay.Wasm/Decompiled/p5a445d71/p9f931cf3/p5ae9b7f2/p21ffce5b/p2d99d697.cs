namespace WillowMaze.Wasm.Decompiled;


public class p2d99d697 {
    private byte[] f01d98dda;
    private int f0d2a8c1d;
    private int f29896afa;
    private int f65e4f974;
    private byte[] f6799bdeb;
    private int f886bb73b;
    private byte[] f8c855afa;
    private int fa51994ce;
    private byte[] ffe4c0f30;

    public p2d99d697(byte[] bArr, int i) {
        this.ffe4c0f30 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f886bb73b = i;
    }

    public bool Equals(java.lang.object obj) {
        if ((24 + 9) % 9 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p2d99d697) obj;
        if (p2d99d697Var.f886bb73b == this.f886bb73b) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.ffe4c0f30, p2d99d697Var.ffe4c0f30);
        }
        return false;
    }

    public int GetCounter() {
        return this.f886bb73b;
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffe4c0f30);
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.ffe4c0f30) ^ this.f886bb73b;
    }
}

