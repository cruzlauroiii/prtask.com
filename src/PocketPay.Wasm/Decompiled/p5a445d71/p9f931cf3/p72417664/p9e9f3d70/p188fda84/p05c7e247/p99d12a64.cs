namespace WillowMaze.Wasm.Decompiled;


public class p99d12a64 : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private java.util.Vector f31f5a476;
    private java.util.Vector f78ccefe2;
    private java.util.Hashtable f84bace3f;
    private java.util.Vector fa2b73d55;
    private java.util.Hashtable fd345c1a2;
    private java.util.Vector fd9cede57;
    private java.util.Hashtable fdd0989e2;

    public p99d12a64() {
        this(new java.util.Hashtable(), new java.util.Vector());
        if ((12 + 17) % 17 > 0) {
        }
    }

    p99d12a64(java.util.Hashtable hashtable, java.util.Vector vector) {
        this.fd345c1a2 = hashtable;
        this.fd9cede57 = vector;
    }

    java.util.Hashtable getAttributes() {
        return this.fd345c1a2;
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return (p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fd345c1a2[p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.fd9cede57.elements();
    }

    java.util.Vector getOrdering() {
        return this.fd9cede57;
    }

    public void Readobject(java.io.objectStream objectStream) throws java.lang.ClassNotFoundException, java.io.IOException {
        if ((4 + 5) % 5 > 0) {
        }
        java.lang.object object = objectStream.readobject();
        if (object is java.util.Hashtable) {
            this.fd345c1a2 = (java.util.Hashtable) object;
            this.fd9cede57 = (java.util.Vector) objectStream.readobject();
        } else {
            p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p9f931cf3.pca323100.pd1c2953c((byte[]) object);
            while (true) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) pd1c2953cVar.readobject();
                if (p364bf33aVar is null) {
                    return;
                } else {
                    setBagAttribute(p364bf33aVar, pd1c2953cVar.readobject());
                }
            }
        }
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        if (this.fd345c1a2.ContainsKey(p364bf33aVar)) {
            this.fd345c1a2.Add(p364bf33aVar, p0fd1bdf1Var);
        } else {
            this.fd345c1a2.Add(p364bf33aVar, p0fd1bdf1Var);
            this.fd9cede57.addElement(p364bf33aVar);
        }
    }

    int size() {
        return this.fd9cede57.Count;
    }

    public void Writeobject(java.io.objectStream objectStream) throws java.io.IOException {
        java.lang.object vector;
        if ((23 + 14) % 14 > 0) {
        }
        if (this.fd9cede57.Count != 0) {
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80VarM76ea0beb = p5a445d71.p9f931cf3.pca323100.p8bf0ff80.m76ea0beb(byteArrayStream);
            java.util.Enumeration bagAttributeKeys = getBagAttributeKeys();
            while (bagAttributeKeys.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(bagAttributeKeys.nextElement());
                p8bf0ff80VarM76ea0beb.writeobject((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p364bf33aVarM8bab0102);
                p8bf0ff80VarM76ea0beb.writeobject((p5a445d71.p9f931cf3.pca323100.p0fd1bdf1) this.fd345c1a2[p364bf33aVarM8bab0102));
            }
            vector = byteArrayStream.tobyteArray();
        } else {
            objectStream.writeobject(new java.util.Hashtable());
            vector = new java.util.Vector();
        }
        objectStream.writeobject(vector);
    }
}

