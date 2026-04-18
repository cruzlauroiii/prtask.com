namespace WillowMaze.Wasm.Decompiled;


class p96729ad9$p6e1677fc : java.lang.Action {
    readonly io.reactivex.rxjava3.core.CompletableObserver f30229d78;
    readonly java.lang.Action f418c5509;
    readonly io.reactivex.rxjava3.core.CompletableObserver f643efa65;
    readonly io.reactivex.rxjava3.core.CompletableObserver f72d8a961;
    readonly io.reactivex.rxjava3.core.CompletableObserver f77f21fa0;
    readonly io.reactivex.rxjava3.core.CompletableObserver fabea94a7;
    readonly java.lang.Action fcc18259a;

    p96729ad9$p6e1677fc(java.lang.Action runnable, io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        this.f418c5509 = runnable;
        this.fabea94a7 = completableObserver;
    }

    public static void HGUXfUVwKVuMwrzZ(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static void NbJOZyRySxhywIpS(io.reactivex.rxjava3.core.CompletableObserver completableObserver) {
        completableObserver.onComplete();
    }

    public static void UJPcLBoWbxuKwofu(java.lang.Action runnable) {
        runnable.run();
    }

    public override void Run() {
        try {
            uJPcLBoWbxuKwofu(this.f418c5509);
            NbJOZyRySxhywIpS(this.fabea94a7);
        } catch (java.lang.Exception th) {
            HGUXfUVwKVuMwrzZ(this.fabea94a7);
            throw th;
        }
    }
}

