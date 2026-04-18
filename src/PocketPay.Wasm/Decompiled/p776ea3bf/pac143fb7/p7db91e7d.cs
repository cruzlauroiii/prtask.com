namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lp776ea3bf/pac143fb7/p7db91e7d;", "Lp776ea3bf/pac143fb7/pe647e01f;", "integrationReceiptRepository", "Lp776ea3bf/pb3f20355/p593c3d43;", "<init>", "(Lp776ea3bf/pb3f20355/p593c3d43;)V", "saveCurrentReceipt", "", "receipt", "Lpad5f82e8/p07214c67/p1e11b989/p9ded6185;", "getCurrentReceipt", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7db91e7d : p776ea3bf.pac143fb7.pe647e01f {
    private readonly p776ea3bf.pb3f20355.p593c3d43 f130b27ce;
    private readonly p776ea3bf.pb3f20355.p593c3d43 f80f12ba3;
    private readonly p776ea3bf.pb3f20355.p593c3d43 fea1bcda2;

    public p7db91e7d(p776ea3bf.pb3f20355.p593c3d43 p593c3d43Var) {
        giMGJPDuwmzsyxzd(p593c3d43Var, "integrationReceiptRepository");
        this.f80f12ba3 = p593c3d43Var;
    }

    public static pad5f82e8.p07214c67.p1e11b989.p9ded6185 ORHGxduGRfDoWzFU(p776ea3bf.pb3f20355.p593c3d43 p593c3d43Var) {
        return p593c3d43Var.getCurrentReceipt();
    }

    public static void BhHdrLyaJkIjkdmW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CfwPjtBmJnFNrGqI(p776ea3bf.pb3f20355.p593c3d43 p593c3d43Var, pad5f82e8.p07214c67.p1e11b989.p9ded6185 p9ded6185Var) {
        p593c3d43Var.saveCurrentReceipt(p9ded6185Var);
    }

    public static void GiMGJPDuwmzsyxzd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override pad5f82e8.p07214c67.p1e11b989.p9ded6185 GetCurrentReceipt() {
        return ORHGxduGRfDoWzFU(this.f80f12ba3);
    }

    public override void SaveCurrentReceipt(pad5f82e8.p07214c67.p1e11b989.p9ded6185 receipt) {
        bhHdrLyaJkIjkdmW(receipt, "receipt");
        cfwPjtBmJnFNrGqI(this.f80f12ba3, receipt);
    }
}

