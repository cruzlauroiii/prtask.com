namespace WillowMaze.Wasm.Decompiled;


readonly class p7830c270$p683cfa51$p927ea1ef : java.util.concurrent.atomic.object<pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252> : io.reactivex.rxjava3.core.CompletableObserver {
    private static readonly long f309222f7 = -8003404460084760287L;
    private static readonly long f5231b017 = -8003404460084760287L;
    private static readonly long f52ee0bcb = -8003404460084760287L;
    private static readonly long fc6e1e520 = -8003404460084760287L;
    private static readonly long fd73b2ee5 = -8003404460084760287L;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 f5d9e8995;
    readonly io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver<object> fd0e45878;
    readonly pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 ffeb97291;

    p7830c270$p683cfa51$p927ea1ef(io.reactivex.rxjava3.internal.operators.mixed.FlowableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver<object> flowableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver) {
        this.fd0e45878 = flowableSwitchDictionaryCompletable$SwitchDictionaryCompletableObserver;
    }

    public static bool JVgsaKXlJusWBRRT(java.util.concurrent.atomic.object atomicReference) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.dispose(atomicReference);
    }

    public static void WbAYTDXrXWxClMyO(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef) {
        p7830c270_p683cfa51.innerComplete(p7830c270_p683cfa51_p927ea1ef);
    }

    public static void CapAoWDYKDAeBhdD(pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51 p7830c270_p683cfa51, pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p0997fb35.p1d770934.p7830c270$p683cfa51$p927ea1ef p7830c270_p683cfa51_p927ea1ef, java.lang.Exception th) {
        p7830c270_p683cfa51.innerError(p7830c270_p683cfa51_p927ea1ef, th);
    }

    public static bool FENLExgMQDUkMLGO(java.util.concurrent.atomic.object atomicReference, pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        return pf98ed07a.pa30d0e7f.p90676d7c.pd1efad72.p52905679.p6ded446e.setOnce(atomicReference, p7beea252Var);
    }

    void dispose() {
        JVgsaKXlJusWBRRT(this);
    }

    public override void OnComplete() {
        WbAYTDXrXWxClMyO(this.fd0e45878, this);
    }

    public override void OnError(java.lang.Exception th) {
        capAoWDYKDAeBhdD(this.fd0e45878, this, th);
    }

    public override void OnSubscribe(pf98ed07a.pa30d0e7f.p90676d7c.p52905679.p7beea252 p7beea252Var) {
        fENLExgMQDUkMLGO(this, p7beea252Var);
    }
}

