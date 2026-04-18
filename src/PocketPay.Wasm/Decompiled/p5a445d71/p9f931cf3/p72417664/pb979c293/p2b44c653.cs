namespace WillowMaze.Wasm.Decompiled;


public class p2b44c653 : java.security.spec.AlgorithmParameterSpec {
    private readonly byte[] f000dcdb3;
    private readonly byte[] f828fcb2e;
    private readonly byte[] f85f22680;
    private readonly byte[] f9c19cc0e;
    private readonly byte[] fae3b548d;

    public p2b44c653(byte[] bArr) {
        this.f85f22680 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetUserKeyingMaterial() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f85f22680);
    }
}

