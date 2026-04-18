namespace WillowMaze.Wasm.Decompiled;


readonly class pe55c687b$p4f599cd0<ResponseT> : retrofit2.HttpServiceMethod<ResponseT, java.lang.object> {
    private readonly paa20ed97.pdb8ce672 f19dbf171;
    private readonly bool f27570670;
    private readonly bool f7a5ff991;
    private readonly bool f875cfed6;
    private readonly bool f8b8d1b56;
    private readonly paa20ed97.pdb8ce672 f992ef698;
    private readonly retrofit2.CallAdapter<ResponseT, retrofit2.Call<ResponseT>> fc46fb5a2;
    private readonly bool fdbd43bca;

    pe55c687b$p4f599cd0(paa20ed97.pc7611810 pc7611810Var, p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e, retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> converter, retrofit2.CallAdapter<ResponseT, retrofit2.Call<ResponseT>> callAdapter, bool z) {
        super(pc7611810Var, pc3755e61_p1c6e980e, converter);
        this.fc46fb5a2 = callAdapter;
        this.f27570670 = z;
    }

    protected java.lang.object Adapt(retrofit2.Call<ResponseT> call, java.lang.object[] objArr) {
        paa20ed97.pc3755e61 pc3755e61Var = (paa20ed97.pc3755e61) this.fc46fb5a2.adapt(call);
        kotlin.coroutines.Continuation continuation = (kotlin.coroutines.Continuation) objArr[objArr.length - 1];
        try {
            return this.f27570670 ? paa20ed97.pa14dcc1a.awaitNullable(pc3755e61Var, continuation) : paa20ed97.pa14dcc1a.await(pc3755e61Var, continuation);
        } catch (java.lang.Exception e) {
            return paa20ed97.pa14dcc1a.suspendAndThrow(e, continuation);
        }
    }
}

