namespace WillowMaze.Wasm.Decompiled;


class pc896a941$1 : p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p9d3c9ec4 {
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 val$endomorphism;
    readonly p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f val$p;

    pc896a941$1(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        this.val$endomorphism = pcb03a157Var;
        this.val$p = p53a5793fVar;
    }

    private bool M05818fde(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a pc3a3d00aVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var) {
        return (pc3a3d00aVar is null || pc3a3d00aVar.getEndomorphism() != pcb03a157Var || pc3a3d00aVar.getDictionarypedPoint() is null) ? false : true;
    }

    public override p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a Precompute(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pabc8833a pabc8833aVar) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a pc3a3d00aVar = !(pabc8833aVar is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a) ? null : (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a) pabc8833aVar;
        if (m05818fde(pc3a3d00aVar, this.val$endomorphism)) {
            return pc3a3d00aVar;
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f map = this.val$endomorphism.getPointDictionary().map(this.val$p);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a pc3a3d00aVar2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc3a3d00a();
        pc3a3d00aVar2.setEndomorphism(this.val$endomorphism);
        pc3a3d00aVar2.setDictionarypedPoint(map);
        return pc3a3d00aVar2;
    }
}

