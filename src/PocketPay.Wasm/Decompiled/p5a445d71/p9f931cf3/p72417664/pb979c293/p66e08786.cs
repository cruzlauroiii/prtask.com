namespace WillowMaze.Wasm.Decompiled;


public class p66e08786 : java.security.spec.AlgorithmParameterSpec {
    private byte[] f0c456985;
    private byte[] fb80bb774;

    public p66e08786(byte[] bArr) {
        if (bArr is null) {
            throw new java.lang.NullPointerException("id string cannot be null");
        }
        this.fb80bb774 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
    }

    public byte[] GetID() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb80bb774);
    }
}

