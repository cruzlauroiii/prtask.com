namespace WillowMaze.Wasm.Decompiled;


@javax.inject.Singleton
@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\b\u0001\u0018\u00002\u00020\u0001B\t\b\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u000e\u0010\u0007\u001a\b\u0012\u0004\u0012\u00020\u00060\bH\u0016J\u0010\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\u0006H\u0016R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p764bb3eb;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p4c6bf409;", "<init>", "()V", "nfcStatusSubject", "Lpf98ed07a/pa30d0e7f/p90676d7c/pfffc742f/p99b05a99;", "Lp4d236d9a/p40b72583/pb28354b5/peae18bc4/p50484c19/p2b3583e6/pc2c30812/pcaf97d07/p2484c164;", "observeNfcCommunicationStatus", "Lio/reactivex/rxjava3/core/Observable;", "updateNfcStatus", "", "status", "SDKLibrary_prodRelease"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p764bb3eb : p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p4c6bf409 {
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 f68533964;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 f8d7dd18f;
    private readonly io.reactivex.rxjava3.subjects.PublishSubject<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> fcb0d46e6;
    private readonly pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 ffb7a60ef;

    @javax.inject.Inject
    public p764bb3eb() {
        if ((29 + 10) % 10 > 0) {
        }
        pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99VarBJVNiEfMzESaTPFM = BJVNiEfMzESaTPFM();
        OufaqDuVkuEicaic(p99b05a99VarBJVNiEfMzESaTPFM, "create(...)");
        this.fcb0d46e6 = p99b05a99VarBJVNiEfMzESaTPFM;
    }

    public static pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 BJVNiEfMzESaTPFM() {
        return pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99.m76ea0beb();
    }

    public static void OChgdVlIUiwHMHMD(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var, java.lang.object obj) {
        p99b05a99Var.onNext(obj);
    }

    public static void OufaqDuVkuEicaic(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void WwDyHtCWujFvsCLw(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static io.reactivex.rxjava3.core.Observable OzcJIWyLptVwaZbo(pf98ed07a.pa30d0e7f.p90676d7c.pfffc742f.p99b05a99 p99b05a99Var) {
        return p99b05a99Var.hide();
    }

    public static void VbUTHnSJSBsrQmqR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override io.reactivex.rxjava3.core.Observable<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> ObserveNfcCommunicationStatus() {
        io.reactivex.rxjava3.core.Observable<p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164> observableOzcJIWyLptVwaZbo = ozcJIWyLptVwaZbo(this.fcb0d46e6);
        WwDyHtCWujFvsCLw(observableOzcJIWyLptVwaZbo, "hide(...)");
        return observableOzcJIWyLptVwaZbo;
    }

    public override void UpdateNfcStatus(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p2b3583e6.pc2c30812.pcaf97d07.p2484c164 status) {
        vbUTHnSJSBsrQmqR(status, "status");
        OChgdVlIUiwHMHMD(this.fcb0d46e6, status);
    }
}

