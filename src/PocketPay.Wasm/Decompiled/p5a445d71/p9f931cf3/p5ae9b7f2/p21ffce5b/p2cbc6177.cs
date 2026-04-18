namespace WillowMaze.Wasm.Decompiled;


public class p2cbc6177 : p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 {
    private int f379b8a54;
    private int f47e16c68;
    private int f5e1d240b;
    private byte[] f5edaa4e4;
    private byte[] f7ddf0229;
    private byte[] f84bea1f0;
    private byte[] f97b80171;
    private byte[] fa11e9f67;
    private byte[] fb600b140;
    private byte[] fbfafbf54;
    private byte[] fddadb579;
    private int fec983a13;

    public p2cbc6177(byte[] bArr, byte[] bArr2, int i) {
        this.fb600b140 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr);
        this.f84bea1f0 = p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr2);
        this.fec983a13 = i;
    }

    public byte[] GetDerivationV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fb600b140);
    }

    public byte[] GetEncodingV() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.f84bea1f0);
    }

    public int GetMacKeySize() {
        return this.fec983a13;
    }
}

