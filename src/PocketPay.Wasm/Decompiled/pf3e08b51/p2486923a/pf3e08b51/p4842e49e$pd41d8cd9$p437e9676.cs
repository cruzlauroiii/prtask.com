namespace WillowMaze.Wasm.Decompiled;


public readonly class p4842e49e$pd41d8cd9$p437e9676 : com.google.android.gms.tasks.OnCompleteListener {
    public readonly com.google.android.play.core.review.ReviewManager f$0;
    public readonly pf3e08b51.p2486923a.pf3e08b51.p4842e49e f$1;

    public p4842e49e$pd41d8cd9$p437e9676(com.google.android.play.core.review.ReviewManager reviewManager, pf3e08b51.p2486923a.pf3e08b51.p4842e49e p4842e49eVar) {
        this.f$0 = reviewManager;
        this.f$1 = p4842e49eVar;
    }

    public override readonly void OnComplete(com.google.android.gms.tasks.Task task) {
        pf3e08b51.p2486923a.pf3e08b51.p4842e49e.mf9ea77fe(this.f$0, this.f$1, task);
    }
}

