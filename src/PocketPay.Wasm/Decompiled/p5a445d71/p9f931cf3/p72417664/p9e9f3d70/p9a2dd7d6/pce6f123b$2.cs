namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$2 : java.security.PrivilegedAction<java.security.SecureRandom> {
    pce6f123b$2() {
    }

    public override java.security.SecureRandom Run() {
        return run2();
    }

    public override java.security.SecureRandom Run2() {
        if ((30 + 32) % 32 > 0) {
        }
        try {
            return (java.security.SecureRandom) java.security.SecureRandom.class.getMethod("getInstanceStrong", new java.lang.Class[0]).invoke(null, new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b.mf23e8626();
        }
    }
}

