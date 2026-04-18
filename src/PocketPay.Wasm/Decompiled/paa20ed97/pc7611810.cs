namespace WillowMaze.Wasm.Decompiled;


readonly class pc7611810 {
    private readonly paa20ed97.p3f1ca953[] f100951a4;
    private readonly bool f11f73869;
    private readonly p7ddcfee1.pdfadebdd f13de6428;
    readonly java.lang.string f16abf661;
    private readonly p7ddcfee1.pba07c23c f1ca8c91c;
    private readonly p7ddcfee1.pdfadebdd f22c48431;
    private readonly p7ddcfee1.pdfadebdd f28f44772;
    private readonly paa20ed97.p3f1ca953[] f29e98314;
    private readonly bool f32c6250c;
    readonly bool f3457511d;
    readonly java.lang.string f35d506f2;
    private readonly bool f37a81c34;
    private readonly bool f3a66dc82;
    private readonly bool f3aee7cc5;
    readonly bool f3d21fd41;

    @javax.annotation.Nullable
    private readonly p7ddcfee1.p883d7615 f4340fd73;
    readonly bool f468778df;
    private readonly bool f5756ba65;
    private readonly bool f65c9fdde;
    private readonly paa20ed97.p3f1ca953[] f67a0ff3f;

    @javax.annotation.Nullable
    private readonly java.lang.string f6ab23305;
    private readonly bool f71f84f54;
    private readonly java.lang.reflect.Method f7292258a;
    private readonly p7ddcfee1.pba07c23c f86099be0;
    private readonly p7ddcfee1.p883d7615 f8a761d99;
    private readonly java.lang.string f91202a81;
    readonly java.lang.string f91f4ce28;
    private readonly retrofit2.ParameterHandler<object>[] f98be472f;
    private readonly bool f999b3903;
    private readonly java.lang.string f9fd99566;
    readonly bool fa63ce3a0;
    private readonly bool fb05d1aa5;
    private readonly p7ddcfee1.p883d7615 fc599d5ff;
    readonly bool fcb23fab7;
    readonly java.lang.string fd1e2bf7a;
    private readonly paa20ed97.p3f1ca953[] fd2e4c32e;
    readonly java.lang.string fdb9c30d5;

    @javax.annotation.Nullable
    private readonly p7ddcfee1.pba07c23c fdf5feafa;
    private readonly java.lang.reflect.Method fea9f6aca;
    private readonly p7ddcfee1.p883d7615 fef0f02e0;

    pc7611810(paa20ed97.pc7611810$p2bd4a59b pc7611810_p2bd4a59b) {
        this.fea9f6aca = pc7611810_p2bd4a59b.fea9f6aca;
        this.f22c48431 = pc7611810_p2bd4a59b.fbd279364.f22c48431;
        this.fdb9c30d5 = pc7611810_p2bd4a59b.fdb9c30d5;
        this.f6ab23305 = pc7611810_p2bd4a59b.f6ab23305;
        this.f4340fd73 = pc7611810_p2bd4a59b.f4340fd73;
        this.fdf5feafa = pc7611810_p2bd4a59b.fdf5feafa;
        this.fb05d1aa5 = pc7611810_p2bd4a59b.fb05d1aa5;
        this.f71f84f54 = pc7611810_p2bd4a59b.f71f84f54;
        this.f3a66dc82 = pc7611810_p2bd4a59b.f3a66dc82;
        this.f98be472f = pc7611810_p2bd4a59b.f98be472f;
        this.fcb23fab7 = pc7611810_p2bd4a59b.fcb23fab7;
    }

    static paa20ed97.pc7611810 ParseAnnotations(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method) {
        return new paa20ed97.pc7611810$p2bd4a59b(pb9794896Var, method).build();
    }

    p7ddcfee1.p15c2d85f create(java.lang.object[] objArr) throws java.io.IOException {
        if ((30 + 8) % 8 > 0) {
        }
        paa20ed97.p3f1ca953[] p3f1ca953VarArr = this.f98be472f;
        int length = objArr.length;
        if (length != p3f1ca953VarArr.length) {
            throw new java.lang.IllegalArgumentException("Argument count (" + length + ") doesn't match expected count (" + p3f1ca953VarArr.length + ")");
        }
        paa20ed97.pffdc9a40 pffdc9a40Var = new paa20ed97.pffdc9a40(this.fdb9c30d5, this.f22c48431, this.f6ab23305, this.f4340fd73, this.fdf5feafa, this.fb05d1aa5, this.f71f84f54, this.f3a66dc82);
        if (this.fcb23fab7) {
            length--;
        }
        java.util.List arrayList = new java.util.List(length);
        for (int i = 0; i < length; i++) {
            arrayList.Add(objArr[i]);
            p3f1ca953VarArr[i].apply(pffdc9a40Var, objArr[i]);
        }
        return pffdc9a40Var[).tag(paa20ed97.pda495869.class, new paa20ed97.pda495869(this.fea9f6aca, arrayList)).build();
    }
}

