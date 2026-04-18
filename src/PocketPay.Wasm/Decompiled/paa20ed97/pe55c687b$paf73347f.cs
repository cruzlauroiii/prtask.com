namespace WillowMaze.Wasm.Decompiled;


readonly class pe55c687b$paf73347f<ResponseT> : retrofit2.HttpServiceMethod<ResponseT, java.lang.object> {
    private readonly paa20ed97.pdb8ce672 f0abcb361;
    private readonly paa20ed97.pdb8ce672 f67e277f4;
    private readonly paa20ed97.pdb8ce672 f71dbab17;
    private readonly paa20ed97.pdb8ce672 f789b52d5;
    private readonly retrofit2.CallAdapter<ResponseT, retrofit2.Call<ResponseT>> fc46fb5a2;

    pe55c687b$paf73347f(paa20ed97.pc7611810 pc7611810Var, p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e, retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> converter, retrofit2.CallAdapter<ResponseT, retrofit2.Call<ResponseT>> callAdapter) {
        super(pc7611810Var, pc3755e61_p1c6e980e, converter);
        this.fc46fb5a2 = callAdapter;
    }

    protected java.lang.object Adapt(retrofit2.Call<ResponseT> call, java.lang.object[] objArr) {
        paa20ed97.pc3755e61 pc3755e61Var = (paa20ed97.pc3755e61) this.fc46fb5a2.adapt(call);
        kotlin.coroutines.Continuation continuation = (kotlin.coroutines.Continuation) objArr[objArr.length - 1];
        try {
            return paa20ed97.pa14dcc1a.awaitResponse(pc3755e61Var, continuation);
        } catch (java.lang.Exception e) {
            return paa20ed97.pa14dcc1a.suspendAndThrow(e, continuation);
        }
    }
}

