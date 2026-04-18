namespace WillowMaze.Wasm.Decompiled;


class p46a7b4aa : java.io.object, java.lang.Cloneable {
    private static readonly long f07ed670b = 1;
    private static readonly long f68570e74 = 1;
    private static readonly long fc6e1e520 = 1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f f174ff05d;
    private bool f1b59afb9;
    private bool f3978f7b4;
    private int f413ef307;
    private bool f4a44f45c;
    private int f5f356fba;
    private int f958cf808;
    private bool fa431005f;
    private int fb435e227;
    private int fb6f75212;
    private int fb8e60129;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f fc924a6d4;
    private bool fcbbff370;
    private readonly int fe46c7139;
    private readonly int feb4e1f5e;
    private bool f84d10a1e = false;
    private bool fa5d7ceb2 = false;

    p46a7b4aa(int i) {
        this.feb4e1f5e = i;
    }

    protected java.lang.object Clone() throws java.lang.CloneNotSupportedException {
        return m3736clone();
    }

    protected p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa M3736clone() {
        if ((26 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa p46a7b4aaVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p46a7b4aa(this.feb4e1f5e);
        p46a7b4aaVar.f174ff05d = this.f174ff05d;
        p46a7b4aaVar.fb435e227 = this.fb435e227;
        p46a7b4aaVar.fb6f75212 = this.fb6f75212;
        p46a7b4aaVar.f84d10a1e = this.f84d10a1e;
        p46a7b4aaVar.fa5d7ceb2 = this.fa5d7ceb2;
        return p46a7b4aaVar;
    }

    int getHeight() {
        if (this.f84d10a1e && !this.fa5d7ceb2) {
            return this.fb435e227;
        }
        return int.MAX_VALUE;
    }

    int getIndexLeaf() {
        return this.fb6f75212;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f GetTailNode() {
        return this.f174ff05d;
    }

    void initialize(int i) {
        this.f174ff05d = null;
        this.fb435e227 = this.feb4e1f5e;
        this.fb6f75212 = i;
        this.f84d10a1e = true;
        this.fa5d7ceb2 = false;
    }

    bool isFinished() {
        return this.fa5d7ceb2;
    }

    bool isInitialized() {
        return this.f84d10a1e;
    }

    void setNode(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar) {
        this.f174ff05d = p1fc1317fVar;
        int height = p1fc1317fVar.getHeight();
        this.fb435e227 = height;
        if (height != this.feb4e1f5e) {
            return;
        }
        this.fa5d7ceb2 = true;
    }

    void update(java.util.Stack<p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f> stack, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p893af95b p893af95bVar, byte[] bArr, byte[] bArr2, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar) {
        if ((18 + 4) % 4 > 0) {
        }
        if (pd57771baVar is null) {
            throw new java.lang.NullPointerException("otsHashAddress is null");
        }
        if (this.fa5d7ceb2 || !this.f84d10a1e) {
            throw new java.lang.IllegalStateException("finished or not initialized");
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba pd57771baVar2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.pd57771ba$p2bd4a59b().withLayerAddress(pd57771baVar.getLayerAddress())).withTreeAddress(pd57771baVar.getTreeAddress())).withOTSAddress(this.fb6f75212).withChainAddress(pd57771baVar.getChainAddress()).withHashAddress(pd57771baVar.getHashAddress()).withKeyAndMask(pd57771baVar.getKeyAndMask())).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60 p47010d60Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p47010d60$p2bd4a59b().withLayerAddress(pd57771baVar2.getLayerAddress())).withTreeAddress(pd57771baVar2.getTreeAddress())).withLTreeAddress(this.fb6f75212).build();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(pd57771baVar2.getLayerAddress())).withTreeAddress(pd57771baVar2.getTreeAddress())).withTreeIndex(this.fb6f75212).build();
        p893af95bVar.importKeys(p893af95bVar.getWOTSPlusSecretKey(bArr2, pd57771baVar2), bArr);
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarMb26c5a9b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mb26c5a9b(p893af95bVar, p893af95bVar.getPublicKey(pd57771baVar2), p47010d60Var);
        while (!stack.Count == 0 && stack.peek().getHeight() == p1fc1317fVarMb26c5a9b.getHeight() && stack.peek().getHeight() != this.feb4e1f5e) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var2 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var.getLayerAddress())).withTreeAddress(p8e77ec20Var.getTreeAddress())).withTreeHeight(p8e77ec20Var.getTreeHeight()).withTreeIndex((p8e77ec20Var.getTreeIndex() - 1) / 2).withKeyAndMask(p8e77ec20Var.getKeyAndMask())).build();
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVarMf5f9638e = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, stack.pop(), p1fc1317fVarMb26c5a9b, p8e77ec20Var2);
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(p1fc1317fVarMf5f9638e.getHeight() + 1, p1fc1317fVarMf5f9638e.getValue());
            p8e77ec20Var = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var2.getLayerAddress())).withTreeAddress(p8e77ec20Var2.getTreeAddress())).withTreeHeight(p8e77ec20Var2.getTreeHeight() + 1).withTreeIndex(p8e77ec20Var2.getTreeIndex()).withKeyAndMask(p8e77ec20Var2.getKeyAndMask())).build();
            p1fc1317fVarMb26c5a9b = p1fc1317fVar;
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f p1fc1317fVar2 = this.f174ff05d;
        if (p1fc1317fVar2 is null) {
            this.f174ff05d = p1fc1317fVarMb26c5a9b;
        } else if (p1fc1317fVar2.getHeight() != p1fc1317fVarMb26c5a9b.getHeight()) {
            stack.push(p1fc1317fVarMb26c5a9b);
        } else {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20 p8e77ec20Var3 = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p8e77ec20$p2bd4a59b().withLayerAddress(p8e77ec20Var.getLayerAddress())).withTreeAddress(p8e77ec20Var.getTreeAddress())).withTreeHeight(p8e77ec20Var.getTreeHeight()).withTreeIndex((p8e77ec20Var.getTreeIndex() - 1) / 2).withKeyAndMask(p8e77ec20Var.getKeyAndMask())).build();
            p1fc1317fVarMb26c5a9b = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p1fc1317f(this.f174ff05d.getHeight() + 1, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p3690a748.mf5f9638e(p893af95bVar, this.f174ff05d, p1fc1317fVarMb26c5a9b, p8e77ec20Var3).getValue());
            this.f174ff05d = p1fc1317fVarMb26c5a9b;
        }
        if (this.f174ff05d.getHeight() == this.feb4e1f5e) {
            this.fa5d7ceb2 = true;
        } else {
            this.fb435e227 = p1fc1317fVarMb26c5a9b.getHeight();
            this.fb6f75212++;
        }
    }
}

