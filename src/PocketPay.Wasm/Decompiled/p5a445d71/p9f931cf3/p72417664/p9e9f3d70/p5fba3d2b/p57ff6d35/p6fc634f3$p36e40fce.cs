namespace WillowMaze.Wasm.Decompiled;


class p6fc634f3$p36e40fce {
    byte[] f058cabc3;
    byte[] fb80bb774;
    byte[] fca2f24bd;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3 this$0;

    p6fc634f3$p36e40fce(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3 p6fc634f3Var, java.security.PublicKey publicKey) {
        this.this$0 = p6fc634f3Var;
        this.fb80bb774 = p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3.mf8f67da7(p6fc634f3Var, publicKey).getKeyIdentifier();
    }

    p6fc634f3$p36e40fce(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3 p6fc634f3Var, byte[] bArr) {
        this.this$0 = p6fc634f3Var;
        this.fb80bb774 = bArr;
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3$p36e40fce)) {
            return false;
        }
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(this.fb80bb774, ((p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p57ff6d35.p6fc634f3$p36e40fce) obj).fb80bb774);
    }

    public int HashCode() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(this.fb80bb774);
    }
}

