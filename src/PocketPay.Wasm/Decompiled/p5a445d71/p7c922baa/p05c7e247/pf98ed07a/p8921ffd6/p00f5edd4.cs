namespace WillowMaze.Wasm.Decompiled;


public class p00f5edd4 : p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p7356ea8d {
    private static readonly java.util.List f600c882f = null;
    private static readonly java.util.List f7786eece = null;
    private static readonly java.util.List f82233d41 = null;
    private static readonly java.util.List f9bdffb71 = null;
    private static readonly java.util.List fd603b239 = java.util.ICollections.unmodifiableList(new java.util.List());
    private java.lang.string f0f3ea938;
    private java.util.List f4340fd73;
    private java.lang.string f599dcce2;
    private java.util.List f936ecb2d;
    private byte[] f9a0364b9;
    private java.util.List fa00ffe81;
    private java.util.List fa849a77f;
    private java.util.List fb47b6445;
    private byte[] fc936a907;

    public p00f5edd4(java.lang.string str, java.util.List list, byte[] bArr) {
        this.f599dcce2 = str;
        this.f4340fd73 = java.util.ICollections.unmodifiableList(list);
        this.f9a0364b9 = bArr;
    }

    public p00f5edd4(java.lang.string str, byte[] bArr) {
        this(str, fd603b239, bArr);
    }

    public override p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 Generate() throws p5a445d71.p7c922baa.p05c7e247.pf98ed07a.p8921ffd6.pcf729cf1 {
        return this;
    }

    public byte[] GetContent() {
        return this.f9a0364b9;
    }

    public java.util.List GetHeaders() {
        return this.f4340fd73;
    }

    public java.lang.string GetType() {
        return this.f599dcce2;
    }
}

