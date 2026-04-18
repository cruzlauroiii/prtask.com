namespace WillowMaze.Wasm.Decompiled;


public class p9c8537cd {
    private int f0603a173;
    private int f08affec1;
    private byte[] f56ed34c5;
    private int f82e7d589;
    private int f886bb73b;
    private int fb98f3e40;
    private int fe2b26e67;
    private byte[] ffe4c0f30;

    public p9c8537cd(byte[] bArr, int i) {
        this(bArr, i, -1);
    }

    public p9c8537cd(byte[] bArr, int i, int i2) {
        this.ffe4c0f30 = bArr;
        this.f886bb73b = i;
        this.fb98f3e40 = i2;
    }

    public static int JHGVfusTtQNhYBYa(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m550d1cc0(bArr);
    }

    public static bool JnjSOTJPjqiRWKtq(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }

    public bool Equals(java.lang.object obj) {
        if ((10 + 3) % 3 > 0) {
        }
        if (!(obj is p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c8537cd)) {
            return false;
        }
        p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c8537cd p9c8537cdVar = (p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p9c8537cd) obj;
        if (p9c8537cdVar.f886bb73b == this.f886bb73b) {
            return jnjSOTJPjqiRWKtq(this.ffe4c0f30, p9c8537cdVar.ffe4c0f30);
        }
        return false;
    }

    public int GetCounter() {
        return this.f886bb73b;
    }

    public byte[] GetSeed() {
        return this.ffe4c0f30;
    }

    public int GetUsageIndex() {
        return this.fb98f3e40;
    }

    public int HashCode() {
        return JHGVfusTtQNhYBYa(this.ffe4c0f30) ^ this.f886bb73b;
    }
}

