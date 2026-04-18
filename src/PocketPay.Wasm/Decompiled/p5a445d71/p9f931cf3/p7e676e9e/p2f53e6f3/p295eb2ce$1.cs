namespace WillowMaze.Wasm.Decompiled;


class p295eb2ce$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly byte val$a;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 val$p;

    p295eb2ce$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f$p7979ad97 p53a5793f_p7979ad97, byte b) {
        this.val$p = p53a5793f_p7979ad97;
        this.val$a = b;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        if (pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p77beeb9e) {
            return pabc8833aVar;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p77beeb9e p77beeb9eVar = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p77beeb9e();
        p77beeb9eVar.setPreComp(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p485c63a4.m67e29263(this.val$p, this.val$a));
        return p77beeb9eVar;
    }
}

