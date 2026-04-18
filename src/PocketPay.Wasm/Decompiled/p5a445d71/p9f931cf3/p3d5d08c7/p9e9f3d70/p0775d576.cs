namespace WillowMaze.Wasm.Decompiled;


public class p0775d576 : p5a445d71.p9f931cf3.pdacfecb5.p41a5626c {
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 f45009040;
    private p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851 ffde5d67b;

    public override java.util.ICollection EngineGetMatches(p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e p0c3cd33eVar) throws p5a445d71.p9f931cf3.p05c7e247.p5255d1dc {
        java.util.ICollection deltaCertificateRevocationLists;
        if ((18 + 22) % 22 > 0) {
        }
        if (!(p0c3cd33eVar is p5a445d71.p9f931cf3.pdacfecb5.p69a537ea)) {
            return java.util.ICollections.EMPTY_SET;
        }
        p5a445d71.p9f931cf3.pdacfecb5.p69a537ea p69a537eaVar = (p5a445d71.p9f931cf3.pdacfecb5.p69a537ea) p0c3cd33eVar;
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        if (p69a537eaVar.isDeltaCRLIndicatorEnabled()) {
            deltaCertificateRevocationLists = this.ffde5d67b.getDeltaCertificateRevocationLists(p69a537eaVar);
        } else {
            hashHashSet.addAll(this.ffde5d67b.getDeltaCertificateRevocationLists(p69a537eaVar));
            hashHashSet.addAll(this.ffde5d67b.getAttributeAuthorityRevocationLists(p69a537eaVar));
            hashHashSet.addAll(this.ffde5d67b.getAttributeCertificateRevocationLists(p69a537eaVar));
            hashHashSet.addAll(this.ffde5d67b.getAuthorityRevocationLists(p69a537eaVar));
            deltaCertificateRevocationLists = this.ffde5d67b.getCertificateRevocationLists(p69a537eaVar);
        }
        hashHashSet.addAll(deltaCertificateRevocationLists);
        return hashHashSet;
    }

    public override void EngineInit(p5a445d71.p9f931cf3.pdacfecb5.pb2c690d6 pb2c690d6Var) {
        if (!(pb2c690d6Var is p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37)) {
            throw new java.lang.IllegalArgumentException("Initialization parameters must be an instance of " + p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37.class.getName() + com.decryptstringmanager.Decryptstring.decryptstring("4a670f656831ea78f92e149ba59e784363ad51155ff5f6d33620bff81f"));
        }
        this.ffde5d67b = new p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851((p5a445d71.p9f931cf3.p3d5d08c7.pc716ce37) pb2c690d6Var);
    }
}

