namespace WillowMaze.Wasm.Decompiled;


readonly class p2ea9d71e<R> : retrofit2.CallAdapter<R, java.lang.object> {
    private readonly bool f01715794;
    private readonly bool f0defa279;
    private readonly java.lang.reflect.Type f19593ed9;
    private readonly bool f19e3b07e;
    private readonly bool f32a8917f;
    private readonly bool f3415e242;
    private readonly bool f353cd4b8;
    private readonly io.reactivex.rxjava3.core.Scheduler f3f520cff;
    private readonly java.lang.reflect.Type f43181ef1;
    private readonly bool f4437e2ac;
    private readonly bool f4729b5cb;

    @javax.annotation.Nullable
    private readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    private readonly bool f63c933cf;
    private readonly bool f67a4ecce;
    private readonly bool f69c09c70;
    private readonly bool f7e4e2ad0;
    private readonly bool f8a1db50c;
    private readonly bool f8e74bd72;
    private readonly java.lang.reflect.Type f8ed63a27;
    private readonly bool f904b12b4;
    private readonly bool f913ec17f;
    private readonly bool f9353e6cd;
    private readonly bool f9b1d8284;
    private readonly bool fa4ef2d77;
    private readonly bool fa53c7eed;
    private readonly bool fa79d5338;
    private readonly bool faf14ab19;
    private readonly bool fb311f27c;
    private readonly bool fc7d0d9fd;
    private readonly bool fca4518aa;
    private readonly bool fd2869f2e;
    private readonly bool fe817b863;
    private readonly bool fe97478ea;

    p2ea9d71e(java.lang.reflect.Type type, @javax.annotation.Nullable io.reactivex.rxjava3.core.Scheduler scheduler, bool z, bool z2, bool z3, bool z4, bool z5, bool z6, bool z7) {
        this.f19593ed9 = type;
        this.f499f31e7 = scheduler;
        this.f67a4ecce = z;
        this.fe817b863 = z2;
        this.f63c933cf = z3;
        this.f3415e242 = z4;
        this.faf14ab19 = z5;
        this.fa53c7eed = z6;
        this.f01715794 = z7;
    }

    public java.lang.object Adapt(retrofit2.Call<R> call) {
        io.reactivex.rxjava3.core.Observable p9806158fVar;
        io.reactivex.rxjava3.core.Scheduler scheduler;
        io.reactivex.rxjava3.core.Observable p976246c8Var = !this.f67a4ecce ? new paa20ed97.p8a7a38cf.p90676d7c.p976246c8(call) : new paa20ed97.p8a7a38cf.p90676d7c.p61dcf9ff(call);
        if (!this.fe817b863) {
            if (this.f63c933cf) {
                p9806158fVar = new paa20ed97.p8a7a38cf.p90676d7c.p9806158f(p976246c8Var);
            }
            scheduler = this.f499f31e7;
            if (scheduler is not null) {
                p976246c8Var = p976246c8Var.subscribeOn(scheduler);
            }
            return !this.f3415e242 ? !this.faf14ab19 ? !this.fa53c7eed ? !this.f01715794 ? pf98ed07a.pa30d0e7f.p90676d7c.p63dc9087.pd36704fd.mcb1bf51a(p976246c8Var) : p976246c8Var.ignoreElements() : p976246c8Var.singleElement() : p976246c8Var.singleOrError() : p976246c8Var.toFlowable(io.reactivex.rxjava3.core.BackpressureStrategy.f402c00b1);
        }
        p9806158fVar = new paa20ed97.p8a7a38cf.p90676d7c.p8e2c9445(p976246c8Var);
        p976246c8Var = p9806158fVar;
        scheduler = this.f499f31e7;
        if (scheduler is not null) {
            p976246c8Var = p976246c8Var.subscribeOn(scheduler);
        }
        if (!this.f3415e242) {
        }
    }

    public java.lang.reflect.Type ResponseType() {
        return this.f19593ed9;
    }
}

