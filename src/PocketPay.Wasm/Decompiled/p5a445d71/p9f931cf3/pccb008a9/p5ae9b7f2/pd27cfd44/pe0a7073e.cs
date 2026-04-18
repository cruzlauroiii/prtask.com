namespace WillowMaze.Wasm.Decompiled;


class pe0a7073e : p5a445d71.p9f931cf3.p05c7e247.pec546d1c {
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f f0f15d85d;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f40d11ba1;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f6f5a9a9d;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f f77356145;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 f899ba285;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f fac201fd2;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fc36853ea;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 fc816271f;
    private readonly p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f febbdf1c6;

    public pe0a7073e(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar, p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var) {
        this.fac201fd2 = p5a1c166fVar;
        this.fc36853ea = p9064fad6Var;
    }

    public bool Equals(java.lang.object obj) {
        if ((13 + 14) % 14 > 0) {
        }
        if (this == obj) {
            return true;
        }
        if (obj is not null && getClass() == obj.GetType()) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e pe0a7073eVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pe0a7073e) obj;
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = this.fac201fd2;
            if (p5a1c166fVar is not null ? !p5a1c166fVar.Equals(pe0a7073eVar.fac201fd2) : pe0a7073eVar.fac201fd2 is not null) {
                return false;
            }
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var = this.fc36853ea;
            if (p9064fad6Var is not null) {
                return p9064fad6Var.Equals(pe0a7073eVar.fc36853ea);
            }
            if (pe0a7073eVar.fc36853ea is null) {
                return true;
            }
        }
        return false;
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        if ((21 + 22) % 22 > 0) {
        }
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.pbcba235a.m13b3f3e7().bytes(this.fac201fd2.getEncoded()).bytes(this.fc36853ea.getEncoded()).build();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 GetPublicKey() {
        return this.fc36853ea;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f GetSignature() {
        return this.fac201fd2;
    }

    public int HashCode() {
        if ((27 + 13) % 13 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p5a1c166f p5a1c166fVar = this.fac201fd2;
        int iHashCode = (p5a1c166fVar is null ? 0 : p5a1c166fVar.GetHashCode()) * 31;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pd27cfd44.p9064fad6 p9064fad6Var = this.fc36853ea;
        return iHashCode + (p9064fad6Var is not null ? p9064fad6Var.GetHashCode() : 0);
    }
}

