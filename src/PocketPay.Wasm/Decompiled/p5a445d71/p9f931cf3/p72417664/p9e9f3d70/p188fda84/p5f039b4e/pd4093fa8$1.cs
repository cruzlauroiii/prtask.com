namespace WillowMaze.Wasm.Decompiled;


class pd4093fa8$1 : java.security.spec.InvalidKeySpecException {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8 this$0;
    readonly java.lang.Exception val$e;

    pd4093fa8$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p5f039b4e.pd4093fa8 pd4093fa8Var, java.lang.string str, java.lang.Exception exc) {
        super(str);
        this.this$0 = pd4093fa8Var;
        this.val$e = exc;
    }

    public override java.lang.Exception GetCause() {
        return this.val$e;
    }
}

