namespace WillowMaze.Wasm.Decompiled;


class p51002034$1 : java.util.Enumeration {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p2fe69afc.p51002034 this$0;
    readonly java.util.IEnumerator val$it;

    p51002034$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p5fba3d2b.p2fe69afc.p51002034 p51002034Var, java.util.IEnumerator it) {
        this.this$0 = p51002034Var;
        this.val$it = it;
    }

    public override bool HasMoreElements() {
        return this.val$it.MoveNext();
    }

    public override java.lang.object NextElement() {
        return this.val$it.Current;
    }
}

