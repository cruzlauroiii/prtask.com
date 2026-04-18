namespace WillowMaze.Wasm.Decompiled;


public class pc1b76273 : java.security.spec.AlgorithmParameterSpec {
    private readonly bool f0c6f6a60;
    private readonly int f124ee817;
    private readonly bool f245cd5a0;
    private readonly byte[] f3aa13f14;
    private readonly bool f4477df4e;
    private readonly byte[] f6c322698;
    private readonly int f7d1435aa;
    private readonly bool fac64a08f;
    private readonly int fbe4ecdb8;
    private readonly bool fd8bd57ad;
    private readonly int fd8bffa22;
    private readonly int fdaa12fa5;
    private readonly byte[] ff73dee66;

    public pc1b76273(int i, byte[] bArr) {
        this(i, bArr, false);
    }

    public pc1b76273(int i, byte[] bArr, bool z) {
        this.fbe4ecdb8 = i;
        this.f6c322698 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.fac64a08f = z;
    }

    public int GetRadix() {
        return this.fbe4ecdb8;
    }

    public byte[] GetTweak() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f6c322698);
    }

    public bool IsUsingInverseFunction() {
        return this.fac64a08f;
    }
}

