namespace WillowMaze.Wasm.Decompiled;


class pb67d5081$1 : java.security.PrivilegedAction<java.io.Stream> {
    readonly p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081 this$0;
    readonly java.lang.string val$path;

    pb67d5081$1(p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081 pb67d5081Var, java.lang.string str) {
        this.this$0 = pb67d5081Var;
        this.val$path = str;
    }

    public override java.io.Stream Run() {
        return p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.mf23e8626(this.this$0) is null ? java.lang.ClassLoader.getSystemResourceAsStream(this.val$path) : p5a445d71.p228c1b3d.p07cc694b.p73bb4387.pb67d5081.mf23e8626(this.this$0).getResourceAsStream(this.val$path);
    }

    public override java.io.Stream Run() {
        return run();
    }
}

