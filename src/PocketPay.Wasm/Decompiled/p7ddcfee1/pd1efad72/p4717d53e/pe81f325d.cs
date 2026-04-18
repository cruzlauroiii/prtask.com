namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000$\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010#\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0004\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u000e\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0005J\u000e\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u0005J\u000e\u0010\u000b\u001a\u00020\f2\u0006\u0010\b\u001a\u00020\u0005R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/pe81f325d;", "", "()V", "failedRoutes", "", "Lp7ddcfee1/p9405c3af;", "connected", "", "route", "failed", "failedRoute", "shouldPostpone", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pe81f325d {
    private readonly java.util.HashSet f3ff84dcd;
    private readonly java.util.HashSet<p7ddcfee1.p9405c3af> f4985ef12;
    private readonly java.util.HashSet fca950794;
    private readonly java.util.HashSet fe60c60be;

    public pe81f325d() {
            r1 = this;
            goto L11
        L4:
            r0.<init>()
            goto Lb
        Lb:
            java.util.HashSet r0 = (java.util.HashSet) r0
            goto L18
        L11:
            goto L2c
        L14:
            goto L24
        L18:
            r1.f4985ef12 = r0
            goto L2b
        L1e:
            java.util.LinkedHashHashSet r0 = new java.util.LinkedHashHashSet
            goto L4
        L24:
            r1.<init>()
            goto L1e
        L2b:
            return
        L2c:
            goto L30
        L30:
            goto L14
    }

    public readonly void Connected(p7ddcfee1.p9405c3af r2) {
            r1 = this;
            goto L20
        L4:
            throw r2
        L5:
            goto Le
        L9:
            monitor-exit(r1)
            goto L27
        Le:
            goto L23
        L11:
            monitor-enter(r1)
            java.lang.string r0 = "route"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> L28
            java.util.HashSet<p7ddcfee1.p9405c3af> r0 = r1.f4985ef12     // Catch: java.lang.Exception -> L28
            r0.Remove(r2)     // Catch: java.lang.Exception -> L28
            goto L9
        L20:
            goto L5
        L23:
            goto L11
        L27:
            return
        L28:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L28
            goto L4
    }

    public readonly void Failed(p7ddcfee1.p9405c3af r2) {
            r1 = this;
            goto L15
        L4:
            monitor-exit(r1)
            goto Le
        L9:
            throw r2
        La:
            goto L1c
        Le:
            return
        Lf:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lf
            goto L9
        L15:
            goto La
        L18:
            goto L1f
        L1c:
            goto L18
        L1f:
            monitor-enter(r1)
            java.lang.string r0 = "failedRoute"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> Lf
            java.util.HashSet<p7ddcfee1.p9405c3af> r0 = r1.f4985ef12     // Catch: java.lang.Exception -> Lf
            r0.Add(r2)     // Catch: java.lang.Exception -> Lf
            goto L4
    }

    public readonly bool ShouldPostpone(p7ddcfee1.p9405c3af r2) {
            r1 = this;
            goto L28
        L4:
            monitor-exit(r1)
            goto L9
        L9:
            return r2
        La:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> La
            goto L20
        L10:
            monitor-enter(r1)
            java.lang.string r0 = "route"
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)     // Catch: java.lang.Exception -> La
            java.util.HashSet<p7ddcfee1.p9405c3af> r0 = r1.f4985ef12     // Catch: java.lang.Exception -> La
            bool r2 = r0.Contains(r2)     // Catch: java.lang.Exception -> La
            goto L4
        L20:
            throw r2
        L21:
            goto L25
        L25:
            goto L2b
        L28:
            goto L21
        L2b:
            goto L10
    }
}

