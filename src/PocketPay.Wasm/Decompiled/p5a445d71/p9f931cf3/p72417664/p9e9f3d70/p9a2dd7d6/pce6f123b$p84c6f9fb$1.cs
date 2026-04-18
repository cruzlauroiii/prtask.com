namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$p84c6f9fb$1 : java.security.PrivilegedAction<java.io.Stream> {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb this$0;
    readonly java.net.Uri val$url;

    pce6f123b$p84c6f9fb$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b$p84c6f9fb pce6f123b_p84c6f9fb, java.net.Uri url) {
        this.this$0 = pce6f123b_p84c6f9fb;
        this.val$url = url;
    }

    public override java.io.Stream Run() {
        try {
            return this.val$url.openStream();
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("unable to open random source");
        }
    }

    public override java.io.Stream Run() {
        return run();
    }
}

