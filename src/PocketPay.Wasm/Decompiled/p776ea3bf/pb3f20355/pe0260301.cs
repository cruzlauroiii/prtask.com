namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u000e\u0010\u0006\u001a\u00020\u0007H\u0096@¢\u0006\u0002\u0010\bR\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lp776ea3bf/pb3f20355/pe0260301;", "Lp776ea3bf/pb3f20355/paa2cfd5d;", "integrationReceiptRepository", "Lp776ea3bf/pb3f20355/p593c3d43;", "<init>", "(Lp776ea3bf/pb3f20355/p593c3d43;)V", "getCurrentPaybackReceipt", "Lpad5f82e8/p07214c67/p1e11b989/p18cf5223;", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pe0260301 : p776ea3bf.pb3f20355.paa2cfd5d {
    private readonly p776ea3bf.pb3f20355.p593c3d43 f05aabccd;
    private readonly p776ea3bf.pb3f20355.p593c3d43 f80f12ba3;

    public pe0260301(p776ea3bf.pb3f20355.p593c3d43 p593c3d43Var) {
        PbpwCOclARCRazOj(p593c3d43Var, "integrationReceiptRepository");
        this.f80f12ba3 = p593c3d43Var;
    }

    public static pad5f82e8.p07214c67.p1e11b989.p9ded6185 CYJgAkHYjPWCbKKD(p776ea3bf.pb3f20355.p593c3d43 p593c3d43Var) {
        return p593c3d43Var.getCurrentReceipt();
    }

    public static void PbpwCOclARCRazOj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void VPnQNPCThrpdGqNE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj, str);
    }

    public override java.lang.object GetCurrentPaybackReceipt(kotlin.coroutines.Continuation<pad5f82e8.p07214c67.p1e11b989.p18cf5223> continuation) {
        pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185VarCYJgAkHYjPWCbKKD = CYJgAkHYjPWCbKKD(this.f80f12ba3);
        vPnQNPCThrpdGqNE(p9ded6185VarCYJgAkHYjPWCbKKD, "null cannot be cast to non-null type domain.entities.receipt.PaybackReceiptModel");
        return (pad5f82e8.p07214c67.p1e11b989.p18cf5223) p9ded6185VarCYJgAkHYjPWCbKKD;
    }
}

