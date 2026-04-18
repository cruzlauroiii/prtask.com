namespace WillowMaze.Wasm.Decompiled;


public class p9ab1ad75 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f1ef489a0;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f35fce246;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f3b8911d8;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f64c46365;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 ffde5d67b;

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if (!(p0c3cd33eVar is p5a445d71.p9f931cf3.pdacfecb5.pe83f9232)) {
            return java.util.ICollections.EMPTY_SET;
        }
        p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var = (p5a445d71.p9f931cf3.pdacfecb5.pe83f9232) p0c3cd33eVar;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        hashHashSet.addAll(this.ffde5d67b.getCrossCertificateValueTuples(pe83f9232Var));
        return hashHashSet;
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37)) {
            throw new java.lang.IllegalArgumentException("Initialization parameters must be an instance of " + p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("0bbdfa80743c679e2b782ef070d16473d21cc96c5b983a68d43960d874"));
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851((p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37) pb2c690d6Var);
    }
}

