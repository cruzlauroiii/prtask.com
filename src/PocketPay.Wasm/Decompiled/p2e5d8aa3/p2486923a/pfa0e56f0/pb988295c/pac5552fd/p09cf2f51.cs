namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\u0018\u00002\u00020\u0001B\u001d\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bR\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000b\u0010\f¨\u0006\r"}, d2 = {"Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p09cf2f51;", "", "paymentHashSettings", "", "Lpad5f82e8/p07214c67/pb3329411;", "priorityEditState", "Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p7478e321;", "<init>", "(Ljava/util/List;Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p7478e321;)V", "getPaymentHashSettings", "()Ljava/util/List;", "getPriorityEditState", "()Lp2e5d8aa3/p2486923a/pfa0e56f0/pb988295c/pac5552fd/p7478e321;", "feature-settings-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p09cf2f51 {
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p7478e321 f1dec6591;
    private readonly java.util.List f30c43380;
    private readonly java.util.List f8e5b168c;
    private readonly java.util.List f9c8fa233;
    private readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p7478e321 fb67e76bf;
    private readonly java.util.List<pad5f82e8.p07214c67.pb3329411> fb8fd6d59;

    public p09cf2f51(java.util.List<pad5f82e8.p07214c67.pb3329411> paymentHashSettings, p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p7478e321 priorityEditState) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(paymentHashSettings, "paymentHashSettings");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(priorityEditState, "priorityEditState");
        this.fb8fd6d59 = paymentHashSettings;
        this.f1dec6591 = priorityEditState;
    }

    public readonly java.util.List<pad5f82e8.p07214c67.pb3329411> GetPaymentHashSettings() {
        return this.fb8fd6d59;
    }

    public readonly p2e5d8aa3.p2486923a.pfa0e56f0.pb988295c.pac5552fd.p7478e321 GetPriorityEditState() {
        return this.f1dec6591;
    }
}

