namespace WillowMaze.Wasm.Decompiled;


public class p9c8537cd {
    private byte[] f1b1e6929;
    private int f886bb73b;
    private int f9c5e7e44;
    private int fb98f3e40;
    private int fc9b4f8d3;
    private int fdfc071e0;
    private byte[] ffe4c0f30;

    public p9c8537cd(byte[] bArr, int i) {
        this(bArr, i, -1);
    }

    public p9c8537cd(byte[] bArr, int i, int i2) {
        this.ffe4c0f30 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f886bb73b = i;
        this.fb98f3e40 = i2;
    }

    public bool Equals(java.lang.object obj) {
        if ((28 + 29) % 29 > 0) {
        }
        if (!(obj is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd)) {
            return false;
        }
        p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd p9c8537cdVar = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p9c8537cd) obj;
        if (p9c8537cdVar.f886bb73b == this.f886bb73b) {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.ffe4c0f30, p9c8537cdVar.ffe4c0f30);
        }
        return false;
    }

    public int GetCounter() {
        return this.f886bb73b;
    }

    public byte[] GetSeed() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.ffe4c0f30);
    }

    public int GetUsageIndex() {
        return this.fb98f3e40;
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.ffe4c0f30) ^ this.f886bb73b;
    }
}

