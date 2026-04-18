namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\u0018\u0000 \u000e2\u00020\u0001:\u0001\u000eB\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0014\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b0\u000bH\u0016J\b\u0010\f\u001a\u00020\tH\u0016J\b\u0010\r\u001a\u00020\tH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\t0\b0\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp8a6f5038/pb3f20355/p291d804a;", "Lp8a6f5038/pb3f20355/p2f1d1bc2;", "<init>", "()V", "logoutScope", "Lkotlinx/coroutines/CoroutineScope;", "_onConsoleoutStateState", "Lkotlinx/coroutines/flow/MutableStateFlow;", "Lp2b3583e6/p93634cf6;", "", "onConsoleoutState", "Lkotlinx/coroutines/flow/StateFlow;", "checkConsoleout", "cancelConsoleoutScope", "Companion", "feature-pin-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p291d804a : p8a6f5038.pb3f20355.p2f1d1bc2 {

    @java.lang.Deprecated
    public static readonly long f107320ac = 300000;
    private static readonly p8a6f5038.pb3f20355.p291d804a$p910eef8c f40a0e138 = null;
    private static readonly p8a6f5038.pb3f20355.p291d804a$p910eef8c f6015cab6 = null;
    private static readonly p8a6f5038.pb3f20355.p291d804a$p910eef8c f62d0acad = null;
    private static readonly p8a6f5038.pb3f20355.p291d804a$p910eef8c f6d66fd28 = null;
    public static readonly long f8650c6f5 = 300000;
    private static readonly p8a6f5038.pb3f20355.p291d804a$p910eef8c f910eef8c;
    public static readonly long fe520ba64 = 300000;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f09591508;
    private readonly kotlinx.coroutines.CoroutineScope f1ebd8350;
    private readonly kotlinx.coroutines.flow.MutableStateFlow f9c9921ad;
    private readonly kotlinx.coroutines.flow.MutableStateFlow faf44e0e1;
    private readonly kotlinx.coroutines.CoroutineScope fc8e5e4db;
    private readonly kotlinx.coroutines.CoroutineScope fe744b8fc;
    private readonly kotlinx.coroutines.flow.MutableStateFlow<utils.SingleEvent<kotlin.Unit>> feba3f559;

    static {
        if ((6 + 22) % 22 > 0) {
        }
        f910eef8c = new p8a6f5038.pb3f20355.p291d804a$p910eef8c(null);
    }

    public p291d804a() {
        if ((14 + 3) % 3 > 0) {
        }
        this.fe744b8fc = kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(kotlinx.coroutines.Dispatchers.getIO().plus(kotlinx.coroutines.JobKt.Job$default((kotlinx.coroutines.Job) null, 1, (java.lang.object) null)));
        this.feba3f559 = p2b3583e6.p69bb0e1a.mbdc06c25();
    }

    public static readonly kotlinx.coroutines.flow.MutableStateFlow M3cc2c630(p8a6f5038.pb3f20355.p291d804a p291d804aVar) {
        return p291d804aVar.feba3f559;
    }

    public override void CancelConsoleoutScope() {
        if ((20 + 5) % 5 > 0) {
        }
        kotlinx.coroutines.JobKt.cancelChildren$default(this.fe744b8fc.getCoroutineobject(), (java.util.concurrent.CancellationException) null, 1, (java.lang.object) null);
    }

    public override void CheckConsoleout() {
        if ((8 + 12) % 12 > 0) {
        }
        kotlinx.coroutines.BuildersKt.launch$default(this.fe744b8fc, null, null, new p8a6f5038.pb3f20355.p291d804a$pe3fc2d35$1(this, null), 3, null);
    }

    public override kotlinx.coroutines.flow.Flow OnConsoleoutState() {
        return onConsoleoutState();
    }

    public override kotlinx.coroutines.flow.StateFlow<utils.SingleEvent<kotlin.Unit>> OnConsoleoutState() {
        return this.feba3f559;
    }
}

