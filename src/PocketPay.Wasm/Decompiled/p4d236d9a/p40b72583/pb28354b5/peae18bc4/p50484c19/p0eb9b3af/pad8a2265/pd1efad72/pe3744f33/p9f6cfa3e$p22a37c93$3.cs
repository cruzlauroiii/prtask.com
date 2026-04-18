namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
readonly class p9f6cfa3e$p22a37c93$3<T, R> : pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.p86408593 {
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.pad63a35e.p61e1e820 $remoteConsoleListener;
    readonly p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.pad8a2265.pd1efad72.pe3744f33.p9f6cfa3e this$0;

    p9f6cfa3e$p22a37c93$3(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.pad63a35e.p61e1e820 p61e1e820Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.pad8a2265.pd1efad72.pe3744f33.p9f6cfa3e p9f6cfa3eVar) {
        this.$remoteConsoleListener = p61e1e820Var;
        this.this$0 = p9f6cfa3eVar;
    }

    public static void QUuPEiqoiFLhUUtj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static io.reactivex.rxjava3.core.Completable CctYqzrBRxHvjMij(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p3a21cd73.p50484c19.p0eb9b3af.pad8a2265.pad63a35e.p61e1e820 p61e1e820Var, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var) {
        return p61e1e820Var.onRemoteConsoleSendToBackend(pec2d4f28Var);
    }

    public static io.reactivex.rxjava3.core.Completable VWGEovLvgmVpvQqF(io.reactivex.rxjava3.core.Completable completable, pf98ed07a.pa30d0e7f.p90676d7c.p0eaa46c1.pf8afcf86 pf8afcf86Var) {
        return completable.doOnError(pf8afcf86Var);
    }

    public static io.reactivex.rxjava3.core.CompletableSource WaEGqBDowgHxGQlh(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.pad8a2265.pd1efad72.pe3744f33.p9f6cfa3e$p22a37c93$3 p9f6cfa3e_p22a37c93_3, p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var) {
        return p9f6cfa3e_p22a37c93_3.apply(pec2d4f28Var);
    }

    public static io.reactivex.rxjava3.core.Completable YtkHpZYuvlFQYGVT(io.reactivex.rxjava3.core.Completable completable) {
        return completable.retry();
    }

    public readonly io.reactivex.rxjava3.core.CompletableSource Apply(p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28 pec2d4f28Var) {
        QUuPEiqoiFLhUUtj(pec2d4f28Var, "packet");
        return ytkHpZYuvlFQYGVT(vWGEovLvgmVpvQqF(cctYqzrBRxHvjMij(this.$remoteConsoleListener, pec2d4f28Var), new p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.pad8a2265.pd1efad72.pe3744f33.p9f6cfa3e$p22a37c93$3$1(this.this$0)));
    }

    public override java.lang.object Apply(java.lang.object obj) {
        return waEGqBDowgHxGQlh(this, (p4d236d9a.p40b72583.pb28354b5.peae18bc4.p50484c19.p0eb9b3af.p9efab239.p07214c67.pad8a2265.pec2d4f28) obj);
    }
}

