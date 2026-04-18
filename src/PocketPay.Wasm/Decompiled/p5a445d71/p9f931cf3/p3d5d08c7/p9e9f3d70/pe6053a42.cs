namespace WillowMaze.Wasm.Decompiled;


public class pe6053a42 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f64083955;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 fa314bebe;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 fa9be08b1;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 ffde5d67b;

    private java.util.ICollection M1e4e3431(p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        if ((2 + 27) % 27 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        p5a445d71.p9f931cf3.pdacfecb5.pe83f9232 pe83f9232Var = new p5a445d71.p9f931cf3.pdacfecb5.pe83f9232();
        pe83f9232Var.setForwardSelector(p27cbb5a8Var);
        pe83f9232Var.setReverseSelector(new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8());
        java.util.HashHashSet<p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4> hashHashSet2 = new java.util.HashHashSet(this.ffde5d67b.getCrossCertificateValueTuples(pe83f9232Var));
        java.util.HashHashSet hashHashSet3 = new java.util.HashHashSet();
        java.util.HashHashSet hashHashSet4 = new java.util.HashHashSet();
        for (p5a445d71.p9f931cf3.pdacfecb5.p0b7269c4 p0b7269c4Var : hashHashSet2) {
            if (p0b7269c4Var.getForward() is not null) {
                hashHashSet3.Add(p0b7269c4Var.getForward());
            }
            if (p0b7269c4Var.getReverse() is not null) {
                hashHashSet4.Add(p0b7269c4Var.getReverse());
            }
        }
        hashHashSet.addAll(hashHashSet3);
        hashHashSet.addAll(hashHashSet4);
        return hashHashSet;
    }

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        java.util.ICollection collectionM1e4e3431;
        if ((26 + 29) % 29 > 0) {
        }
        if (!(p0c3cd33eVar is p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8)) {
            return java.util.ICollections.EMPTY_SET;
        }
        p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = (p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8) p0c3cd33eVar;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (p27cbb5a8Var.getBasicConstraints() > 0) {
            hashHashSet.addAll(this.ffde5d67b.getCACertificates(p27cbb5a8Var));
            collectionM1e4e3431 = m1e4e3431(p27cbb5a8Var);
        } else if (p27cbb5a8Var.getBasicConstraints() != -2) {
            hashHashSet.addAll(this.ffde5d67b.getUserCertificates(p27cbb5a8Var));
            hashHashSet.addAll(this.ffde5d67b.getCACertificates(p27cbb5a8Var));
            collectionM1e4e3431 = m1e4e3431(p27cbb5a8Var);
        } else {
            collectionM1e4e3431 = this.ffde5d67b.getUserCertificates(p27cbb5a8Var);
        }
        hashHashSet.addAll(collectionM1e4e3431);
        return hashHashSet;
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37)) {
            throw new java.lang.IllegalArgumentException("Initialization parameters must be an instance of " + p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("4340be6d56fbe9f51b9c120f57c6d0f3072049684c0a6ec9d314ce2b44"));
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851((p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37) pb2c690d6Var);
    }
}

