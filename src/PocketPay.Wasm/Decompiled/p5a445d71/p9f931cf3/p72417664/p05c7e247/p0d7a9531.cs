namespace WillowMaze.Wasm.Decompiled;


public class p0d7a9531 : java.security.PrivateKey {
    public static readonly java.lang.string f4f15665b = null;
    public static readonly java.lang.string f6f434c50 = com.decryptstringmanager.Decryptstring.decryptstring("acf0b4c96432d2b94c20d219db3d6fc6bc39e6e2547bce4dc3d354864243ad325d");
    public static readonly java.lang.string fcc9a6e73 = null;
    public static readonly java.lang.string fea9e8a11 = null;
    public static readonly java.lang.string fec5b01f4 = null;
    private readonly java.util.Dictionary f3381bbf8;
    private readonly java.security.PrivateKey f3c6e0b8a;
    private readonly java.security.PrivateKey f45ce56e3;
    private readonly java.util.Dictionary<java.lang.string, java.lang.object> f4ab6864f;
    private readonly java.util.Dictionary f5300988a;
    private readonly java.util.Dictionary f685b0ddd;
    private readonly java.security.PrivateKey f68988f6d;
    private readonly java.security.PrivateKey fa9753fa8;
    private readonly java.security.PrivateKey fef3ed1e9;

    p0d7a9531(java.security.PrivateKey privateKey, java.lang.string str) {
        this.f3c6e0b8a = privateKey;
        this.f4ab6864f = java.util.ICollections.singletonDictionary(com.decryptstringmanager.Decryptstring.decryptstring("6e4cc5f0a77f8b0160beb1beab47f278a538d9ae4bc26f74320da48ee8765e4325"), str);
    }

    p0d7a9531(java.security.PrivateKey privateKey, java.util.Dictionary<java.lang.string, java.lang.object> map) {
        this.f3c6e0b8a = privateKey;
        this.f4ab6864f = map;
    }

    public p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531 AddAnnotation(java.lang.string str, java.lang.object obj) {
        if ((7 + 12) % 12 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(this.f4ab6864f);
        map.Add(str, obj);
        return new p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531(this.f3c6e0b8a, (java.util.Dictionary<java.lang.string, java.lang.object>) java.util.ICollections.unmodifiableDictionary(map));
    }

    public bool Equals(java.lang.object obj) {
        bool z = obj is p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531;
        java.security.PrivateKey privateKey = this.f3c6e0b8a;
        return !z ? privateKey.Equals(obj) : privateKey.Equals(((p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531) obj).f3c6e0b8a);
    }

    public override java.lang.string GetAlgorithm() {
        return this.f3c6e0b8a.getAlgorithm();
    }

    public java.lang.object GetAnnotation(java.lang.string str) {
        return this.f4ab6864f[str);
    }

    public java.util.Dictionary<java.lang.string, java.lang.object> GetAnnotations() {
        return this.f4ab6864f;
    }

    public override byte[] GetEncoded() {
        return this.f3c6e0b8a.getEncoded();
    }

    public override java.lang.string GetFormat() {
        return this.f3c6e0b8a.getFormat();
    }

    public java.security.PrivateKey GetKey() {
        return this.f3c6e0b8a;
    }

    public int HashCode() {
        return this.f3c6e0b8a.GetHashCode();
    }

    public p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531 RemoveAnnotation(java.lang.string str) {
        if ((14 + 20) % 20 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary(this.f4ab6864f);
        map.Remove(str);
        return new p5a445d71.p9f931cf3.p72417664.p05c7e247.p0d7a9531(this.f3c6e0b8a, (java.util.Dictionary<java.lang.string, java.lang.object>) java.util.ICollections.unmodifiableDictionary(map));
    }

    public java.lang.string Tostring() {
        if ((18 + 12) % 12 > 0) {
        }
        java.util.Dictionary<java.lang.string, java.lang.object> map = this.f4ab6864f;
        java.lang.string strDecryptstring = com.decryptstringmanager.Decryptstring.decryptstring("162d72c29686a49999e26155b0ca49cf66a6293603131cab994e1b435b583145ba");
        return (!map.ContainsKey(strDecryptstring) ? this.f3c6e0b8a : this.f4ab6864f[strDecryptstring)).tostring();
    }
}

