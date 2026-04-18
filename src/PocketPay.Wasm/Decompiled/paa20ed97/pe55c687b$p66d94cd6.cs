namespace WillowMaze.Wasm.Decompiled;


readonly class pe55c687b$p66d94cd6<ResponseT, ReturnT> : retrofit2.HttpServiceMethod<ResponseT, ReturnT> {
    private readonly paa20ed97.pdb8ce672 f3e73596d;
    private readonly paa20ed97.pdb8ce672 f8ee803d4;
    private readonly retrofit2.CallAdapter<ResponseT, ReturnT> fc46fb5a2;

    pe55c687b$p66d94cd6(paa20ed97.pc7611810 pc7611810Var, p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e, retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> converter, retrofit2.CallAdapter<ResponseT, ReturnT> callAdapter) {
        super(pc7611810Var, pc3755e61_p1c6e980e, converter);
        this.fc46fb5a2 = callAdapter;
    }

    protected ReturnT Adapt(retrofit2.Call<ResponseT> call, java.lang.object[] objArr) {
        return (ReturnT) this.fc46fb5a2.adapt(call);
    }
}

