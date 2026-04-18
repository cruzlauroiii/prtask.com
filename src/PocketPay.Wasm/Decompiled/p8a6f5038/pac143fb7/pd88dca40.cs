namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0018\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0016J\u0014\u0010\f\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00070\u000e0\rH\u0016J\b\u0010\u000f\u001a\u00020\u0007H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0010"}, d2 = {"Lp8a6f5038/pac143fb7/pd88dca40;", "Lp8a6f5038/pac143fb7/p168abf2d;", "pinRepository", "Lp8a6f5038/pb3f20355/p2f1d1bc2;", "<init>", "(Lp8a6f5038/pb3f20355/p2f1d1bc2;)V", "validatePin", "", "pin", "", "employee", "Lpad5f82e8/p07214c67/pfa547353/pf8c8b903;", "onConsoleoutState", "Lkotlinx/coroutines/flow/Flow;", "Lp2b3583e6/p93634cf6;", "cancelConsoleoutScope", "feature-pin-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pd88dca40 : p8a6f5038.pac143fb7.p168abf2d {
    private readonly p8a6f5038.pb3f20355.p2f1d1bc2 f0b0a5ccc;
    private readonly p8a6f5038.pb3f20355.p2f1d1bc2 f653e5367;
    private readonly p8a6f5038.pb3f20355.p2f1d1bc2 fea0d6b34;

    public pd88dca40(p8a6f5038.pb3f20355.p2f1d1bc2 pinRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pinRepository, "pinRepository");
        this.f653e5367 = pinRepository;
    }

    public override void CancelConsoleoutScope() {
        this.f653e5367.cancelConsoleoutScope();
    }

    public override kotlinx.coroutines.flow.Flow<utils.SingleEvent<kotlin.Unit>> OnConsoleoutState() {
        return this.f653e5367.onConsoleoutState();
    }

    public override void ValidatePin(java.lang.string pin, pad5f82e8.p07214c67.pfa547353.pf8c8b903 employee) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pin, "pin");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(employee, "employee");
        if (!kotlin.jvm.internal.Intrinsics.areEqual(pin, employee.getPin())) {
            throw new java.lang.Exception("Pin is not valid");
        }
    }
}

