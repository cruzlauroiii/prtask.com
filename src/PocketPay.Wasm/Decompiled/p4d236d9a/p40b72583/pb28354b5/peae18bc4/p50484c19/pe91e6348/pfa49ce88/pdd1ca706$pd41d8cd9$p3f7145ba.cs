namespace WillowMaze.Wasm.Decompiled;


public readonly class pdd1ca706$pd41d8cd9$p3f7145ba : com.google.android.gms.tasks.OnFailureListener {
    public readonly io.reactivex.rxjava3.core.SingleEmitter f$0;

    public pdd1ca706$pd41d8cd9$p3f7145ba(io.reactivex.rxjava3.core.SingleEmitter singleEmitter) {
        this.f$0 = singleEmitter;
    }

    public static void LdRephdakmaICLom(io.reactivex.rxjava3.core.SingleEmitter singleEmitter, java.lang.Exception th) {
        p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.pe91e6348.pfa49ce88.pdd1ca706.ma9939c90(singleEmitter, th);
    }

    public override readonly void OnFailure(java.lang.Exception exc) {
        LdRephdakmaICLom(this.f$0, exc);
    }
}

