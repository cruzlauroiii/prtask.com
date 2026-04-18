namespace WillowMaze.Wasm.Decompiled;


public class p69dff166 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f5fb2b350;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 ffde5d67b;

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((16 + 27) % 27 > 0) {
        }
        if (!(p0c3cd33eVar is p5a445d71.p9f931cf3.pdacfecb5.p4329c72d)) {
            return java.util.ICollections.EMPTY_SET;
        }
        p5a445d71.p9f931cf3.pdacfecb5.p4329c72d p4329c72dVar = (p5a445d71.p9f931cf3.pdacfecb5.p4329c72d) p0c3cd33eVar;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        hashHashSet.addAll(this.ffde5d67b.getAACertificates(p4329c72dVar));
        hashHashSet.addAll(this.ffde5d67b.getAttributeCertificateAttributes(p4329c72dVar));
        hashHashSet.addAll(this.ffde5d67b.getAttributeDescriptorCertificates(p4329c72dVar));
        return hashHashSet;
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37)) {
            throw new java.lang.IllegalArgumentException("Initialization parameters must be an instance of " + p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("efffed792771b278f30511a7f1029de3ba1964dfce672010493005d3e3"));
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851((p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37) pb2c690d6Var);
    }
}

