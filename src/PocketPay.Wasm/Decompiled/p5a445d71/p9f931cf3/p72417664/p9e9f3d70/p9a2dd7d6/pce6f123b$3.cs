namespace WillowMaze.Wasm.Decompiled;


class pce6f123b$3 : java.security.PrivilegedAction<p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2> {
    readonly java.lang.string val$sourceClass;

    pce6f123b$3(java.lang.string str) {
        this.val$sourceClass = str;
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 Run() {
        return run2();
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2 Run2() {
        if ((31 + 1) % 1 > 0) {
        }
        try {
            return (p5a445d71.p9f931cf3.p5ae9b7f2.pc43fb241.p75fb81d2) p5a445d71.p9f931cf3.p72417664.p9e9f3d70.pfeca3c73.p05c7e247.p670225f6.mdf9e1f96(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p9a2dd7d6.pce6f123b.class, this.val$sourceClass).newInstance();
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalStateException("entropy source " + this.val$sourceClass + " not created: " + e.getMessage(), e);
        }
    }
}

