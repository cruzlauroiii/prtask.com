namespace WillowMaze.Wasm.Decompiled;


class p51f14de8$1 : java.security.InvalidKeyException {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8 this$0;
    readonly java.lang.Exception val$e;

    p51f14de8$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pc6909b05.p51f14de8 p51f14de8Var, java.lang.string str, java.lang.Exception exc) {
        super(str);
        this.this$0 = p51f14de8Var;
        this.val$e = exc;
    }

    public override java.lang.Exception GetCause() {
        return this.val$e;
    }
}

