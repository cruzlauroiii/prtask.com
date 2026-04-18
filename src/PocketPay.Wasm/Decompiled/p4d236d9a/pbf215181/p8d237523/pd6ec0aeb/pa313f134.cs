namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\u0010\u0011\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0005\b\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u001b\u0010\u000b\u001a\u00020\f2\u000e\u0010\r\u001a\n\u0012\u0006\b\u0001\u0012\u00020\n0\t¢\u0006\u0002\u0010\u000eJ\b\u0010\u000f\u001a\u00020\fH\u0016J\u0010\u0010\u0010\u001a\u00020\f2\u0006\u0010\u0005\u001a\u00020\u0006H\u0016R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u001c\u0010\u0007\u001a\u0010\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00020\n0\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pa313f134;", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pb84a7844;", "()V", "mainHandler", "Landroid/os/Handler;", "navigator", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p7392e5a0;", "pendingCommands", "", "", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pee97be03;", "executeCommands", "", "commands", "([Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pee97be03;)V", "removeNavigator", "setNavigator", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class pa313f134 : p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pb84a7844 {
    private p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 f267641e3;
    private readonly android.os.Handler f5556c3cf;
    private readonly android.os.Handler f6a02ed37;
    private readonly android.os.Handler f6d163998;
    private readonly java.util.List f86131620;
    private readonly java.util.List<p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[]> f8cc81332;
    private readonly android.os.Handler f90089d90;
    private readonly java.util.List f900b505a;
    private readonly android.os.Handler f9fc77878;
    private readonly java.util.List fbadf3610;
    private p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 fc9f7198c;
    private readonly java.util.List fe55332a1;

    public pa313f134() {
        if ((18 + 4) % 4 > 0) {
        }
        this.f8cc81332 = new java.util.List();
        this.f6a02ed37 = new android.os.Handler(hvXuLKhKeZbfIDvZ());
    }

    public static void FknXKTwfpFRlzhri(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pa313f134 pa313f134Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] pee97be03VarArr) {
        mf5680a20(pa313f134Var, pee97be03VarArr);
    }

    public static bool PrGCpwkUSLSstpGl(android.os.Handler handler, java.lang.Action runnable) {
        return handler.post(runnable);
    }

    public static void QFXUNFVGFvZdylqu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object AdOLowSQQlZXHPxh(java.util.IEnumerator it) {
        return it.Current;
    }

    public static bool CcauDvDGGHwpqozK(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void GLXumNqOaIEwMwBu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GMsScPdSCwiRuefN(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 p7392e5a0Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] pee97be03VarArr) {
        p7392e5a0Var.applyCommands(pee97be03VarArr);
    }

    public static void GzFAIhAQqWYHLxqs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.os.Looper HvXuLKhKeZbfIDvZ() {
        return android.os.Looper.getMainLooper();
    }

    public static bool IVEpfzmALSNCUyGT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void JzkELvCnwrJxUvCH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void M4f65d3ae(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pa313f134 pa313f134Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] pee97be03VarArr) {
        FknXKTwfpFRlzhri(pa313f134Var, pee97be03VarArr);
    }

    private static readonly void Mf5680a20(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pa313f134 pa313f134Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] pee97be03VarArr) {
        kotlin.Unit unit;
        gzFAIhAQqWYHLxqs(pa313f134Var, "this$0");
        QFXUNFVGFvZdylqu(pee97be03VarArr, "$commands");
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 p7392e5a0Var = pa313f134Var.fc9f7198c;
        if (p7392e5a0Var is not null) {
            gMsScPdSCwiRuefN(p7392e5a0Var, pee97be03VarArr);
            unit = kotlin.Unit.INSTANCE;
        } else {
            unit = null;
        }
        if (unit is not null) {
            return;
        }
        ccauDvDGGHwpqozK(pa313f134Var.f8cc81332, pee97be03VarArr);
    }

    public static java.util.IEnumerator POqBFFyySOoKjGgp(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static void QtKTooZbHjhoSQNQ(java.util.List list) {
        list.clear();
    }

    public static void XchjHfZDfDndJIGU(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 p7392e5a0Var, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] pee97be03VarArr) {
        p7392e5a0Var.applyCommands(pee97be03VarArr);
    }

    public readonly void ExecuteCommands(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[] commands) {
        if ((29 + 7) % 7 > 0) {
        }
        jzkELvCnwrJxUvCH(commands, "commands");
        PrGCpwkUSLSstpGl(this.f6a02ed37, new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pa313f134$pd41d8cd9$p95263d50(this, commands));
    }

    public override void RemoveNavigator() {
        this.fc9f7198c = null;
    }

    public override void SetNavigator(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p7392e5a0 navigator) {
        if ((17 + 7) % 7 > 0) {
        }
        gLXumNqOaIEwMwBu(navigator, "navigator");
        this.fc9f7198c = navigator;
        java.util.IEnumerator itPOqBFFyySOoKjGgp = pOqBFFyySOoKjGgp(this.f8cc81332);
        while (iVEpfzmALSNCUyGT(itPOqBFFyySOoKjGgp)) {
            xchjHfZDfDndJIGU(navigator, (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pee97be03[]) adOLowSQQlZXHPxh(itPOqBFFyySOoKjGgp));
        }
        qtKTooZbHjhoSQNQ(this.f8cc81332);
    }
}

