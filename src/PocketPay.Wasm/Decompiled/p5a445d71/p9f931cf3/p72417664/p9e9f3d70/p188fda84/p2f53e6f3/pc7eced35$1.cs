namespace WillowMaze.Wasm.Decompiled;


class pc7eced35$1 : p5a445d71.p9f931cf3.p5ae9b7f2.p60156ac2 {
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35 this$0;
    readonly bool val$usePointCompression;

    pc7eced35$1(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p2f53e6f3.pc7eced35 pc7eced35Var, bool z) {
        this.this$0 = pc7eced35Var;
        this.val$usePointCompression = z;
    }

    public override byte[] GetEncoded(p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a pcfffbc4aVar) {
        return ((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pd16c2d8e) pcfffbc4aVar).getQ().getEncoded(this.val$usePointCompression);
    }
}

