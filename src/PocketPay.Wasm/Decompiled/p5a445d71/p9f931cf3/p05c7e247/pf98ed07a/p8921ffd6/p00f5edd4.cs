namespace WillowMaze.Wasm.Decompiled;


public class p00f5edd4 : p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p7356ea8d {
    private static readonly java.util.List f0121cac6 = null;
    private static readonly java.util.List f2c84c2e8 = null;
    private static readonly java.util.List f6d104947 = null;
    private static readonly java.util.List fd603b239 = java.util.ICollections.unmodifiableList(new java.util.List());
    private static readonly java.util.List ffafe6031 = null;
    private java.util.List f4340fd73;
    private java.util.List f4690dccf;
    private java.lang.string f474c1edd;
    private java.util.List f4be1dd3b;
    private java.lang.string f599dcce2;
    private byte[] f72831804;
    private byte[] f9a0364b9;
    private java.util.List f9d9f365b;
    private java.util.List fa826dfad;
    private byte[] fc802612c;
    private java.lang.string fed5c44c3;
    private byte[] ff97fc167;

    public p00f5edd4(java.lang.string str, java.util.List list, byte[] bArr) {
        this.f599dcce2 = str;
        this.f4340fd73 = java.util.ICollections.unmodifiableList(list);
        this.f9a0364b9 = bArr;
    }

    public p00f5edd4(java.lang.string str, byte[] bArr) {
        this(str, fd603b239, bArr);
    }

    public override p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.p00f5edd4 Generate() throws p5a445d71.p9f931cf3.p05c7e247.pf98ed07a.p8921ffd6.pcf729cf1 {
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

