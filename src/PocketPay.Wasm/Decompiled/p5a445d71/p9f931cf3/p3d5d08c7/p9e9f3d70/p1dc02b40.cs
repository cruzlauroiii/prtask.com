namespace WillowMaze.Wasm.Decompiled;


public class p1dc02b40 {
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1dc02b40 f8d6c391e = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1dc02b40();
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1dc02b40 fb3ecadd0;
    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p1dc02b40 fd20e1b9c;

    public void AddExcludedSubtree(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee p09a7e7eeVar) {
        this.f8d6c391e.addExcludedSubtree(p09a7e7eeVar);
    }

    public void CheckExcluded(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a {
        try {
            this.f8d6c391e.checkExcluded(pf17d2ecdVar);
        } catch (p5a445d71.p9f931cf3.pca323100.pdacfecb5.ped6a00c6 e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a(e.getMessage(), e);
        }
    }

    public void CheckExcludedDN(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a {
        try {
            this.f8d6c391e.checkExcludedDN(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p80f8c729Var));
        } catch (p5a445d71.p9f931cf3.pca323100.pdacfecb5.ped6a00c6 e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a(e.getMessage(), e);
        }
    }

    public void CheckPermitted(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a {
        try {
            this.f8d6c391e.checkPermitted(pf17d2ecdVar);
        } catch (p5a445d71.p9f931cf3.pca323100.pdacfecb5.ped6a00c6 e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a(e.getMessage(), e);
        }
    }

    public void CheckPermittedDN(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) throws p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a {
        try {
            this.f8d6c391e.checkPermittedDN(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p80f8c729Var));
        } catch (p5a445d71.p9f931cf3.pca323100.pdacfecb5.ped6a00c6 e) {
            throw new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p977cf76a(e.getMessage(), e);
        }
    }

    public bool Equals(java.lang.object obj) {
        if (!(obj is p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40)) {
            return false;
        }
        return this.f8d6c391e.Equals(((p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p1dc02b40) obj).f8d6c391e);
    }

    public int HashCode() {
        return this.f8d6c391e.GetHashCode();
    }

    public void IntersectEmptyPermittedSubtree(int i) {
        this.f8d6c391e.intersectEmptyPermittedSubtree(i);
    }

    public void IntersectPermittedSubtree(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee p09a7e7eeVar) {
        this.f8d6c391e.intersectPermittedSubtree(p09a7e7eeVar);
    }

    public void IntersectPermittedSubtree(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p09a7e7ee[] p09a7e7eeVarArr) {
        this.f8d6c391e.intersectPermittedSubtree(p09a7e7eeVarArr);
    }

    public java.lang.string Tostring() {
        return this.f8d6c391e.tostring();
    }
}

