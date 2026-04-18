namespace WillowMaze.Wasm.Decompiled;


public class p2644f0e1 : p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.pd058f65d {
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f6833602b;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f7694f4a6;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f f7aaa6ecb;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fb9693eed;
    private p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f fe62be1c0;

    public p2644f0e1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, p5a445d71.p9f931cf3.p3d5d08c7.pb979c293.p835df581 p835df581Var) {
        super(p835df581Var);
        if (p53a5793fVar.getCurve() is null) {
            this.f7694f4a6 = p53a5793fVar;
        } else {
            this.f7694f4a6 = p53a5793fVar.normalize();
        }
    }

    public p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f GetQ() {
        return this.f7694f4a6;
    }
}

