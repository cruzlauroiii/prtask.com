namespace WillowMaze.Wasm.Decompiled;


readonly class p976246c8$p342b5f71 : pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 {
    private readonly paa20ed97.pc3755e61 f341a62d2;
    private bool f3ae3c9b2;
    private readonly retrofit2.Call<object> f53b9e967;
    private bool fedb36638;
    private bool fef7f54ab;
    private bool ff8b2648d;

    p976246c8$p342b5f71(retrofit2.Call<object> call) {
        this.f53b9e967 = call;
    }

    public override void Dispose() {
        this.ff8b2648d = true;
        this.f53b9e967.cancel();
    }

    public override bool IsDisposed() {
        return this.ff8b2648d;
    }
}

