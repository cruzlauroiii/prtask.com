namespace WillowMaze.Wasm.Decompiled;


public class p2d99d697 {
    private byte[] f7cb0df18;
    private int f886bb73b;
    private int f974b7cba;
    private int fc9f3cffd;
    private int ff944f89d;
    private byte[] ff9c11dd8;
    private byte[] ffe4c0f30;

    public p2d99d697(byte[] bArr, int i) {
        this.ffe4c0f30 = bArr;
        this.f886bb73b = i;
    }

    public static bool WiOdFqhpKHUzfrhO(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public static int OqzvbxIqQsTVSkaO(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public bool Equals(java.lang.object obj) {
        if ((19 + 20) % 20 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697 p2d99d697Var = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p2d99d697) obj;
        if (p2d99d697Var.f886bb73b == this.f886bb73b) {
            return WiOdFqhpKHUzfrhO(this.ffe4c0f30, p2d99d697Var.ffe4c0f30);
        }
        return false;
    }

    public int GetCounter() {
        return this.f886bb73b;
    }

    public byte[] GetSeed() {
        return this.ffe4c0f30;
    }

    public int HashCode() {
        return oqzvbxIqQsTVSkaO(this.ffe4c0f30) ^ this.f886bb73b;
    }
}

