namespace WillowMaze.Wasm.Decompiled;


public class p9b30b946 : p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 {
    private java.util.ICollection f21e8a056;
    private java.util.ICollection fa247d57e;
    private java.util.ICollection fdb6d9b45;

    public p9b30b946(java.util.ICollection collection) {
        if (collection is null) {
            throw new java.lang.NullPointerException("collection cannot be null");
        }
        this.fdb6d9b45 = collection;
    }

    public java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pdacfecb5.p9b30b946(this.fdb6d9b45);
    }

    public java.util.ICollection GetICollection() {
        return new java.util.List(this.fdb6d9b45);
    }

    public java.lang.string Tostring() {
        if ((9 + 26) % 26 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("X509ICollectionStoreParameters: [\n");
        stringBuffer.append("  collection: " + this.fdb6d9b45 + "\n");
        stringBuffer.append("]");
        return stringBuffer.tostring();
    }
}

