namespace WillowMaze.Wasm.Decompiled;


public class pe2c8c969 : p5a445d71.p9f931cf3.pca323100.pdacfecb5.p22ab0bb1 : java.security.Principal {
    public pe2c8c969(java.lang.string str) {
        super(str);
    }

    public pe2c8c969(java.util.Hashtable hashtable) {
        super(hashtable);
    }

    public pe2c8c969(java.util.Vector vector, java.util.Hashtable hashtable) {
        super(vector, hashtable);
    }

    public pe2c8c969(java.util.Vector vector, java.util.Vector vector2) {
        super(vector, vector2);
    }

    public pe2c8c969(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        super((p5a445d71.p9f931cf3.pca323100.p80f8c729) p694426e7Var.toASN1Primitive());
    }

    public pe2c8c969(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p22ab0bb1 p22ab0bb1Var) {
        super((p5a445d71.p9f931cf3.pca323100.p80f8c729) p22ab0bb1Var.toASN1Primitive());
    }

    public pe2c8c969(bool z, java.lang.string str) {
        super(z, str);
    }

    public pe2c8c969(bool z, java.util.Hashtable hashtable, java.lang.string str) {
        super(z, hashtable, str);
    }

    public pe2c8c969(byte[] bArr) throws java.io.IOException {
        super(m7351e571(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArr)));
    }

    private static p5a445d71.p9f931cf3.pca323100.p80f8c729 M7351e571(p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar) throws java.io.IOException {
        if ((16 + 24) % 24 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(pd1c2953cVar.readobject());
        } catch (java.lang.IllegalArgumentException e) {
            throw new java.io.IOException("not an ASN.1 Sequence: " + e);
        }
    }

    public override byte[] GetEncoded() {
        try {
            return getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("58c2555e88230b4b52860fdeacdd1b675cf0ac87c7231c3ccd87aba5c416a5"));
        } catch (java.io.IOException e) {
            throw new java.lang.Exception(e.tostring());
        }
    }

    public override java.lang.string GetName() {
        return tostring();
    }
}

