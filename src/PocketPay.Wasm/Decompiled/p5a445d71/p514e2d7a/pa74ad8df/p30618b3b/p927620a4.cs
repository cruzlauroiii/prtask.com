namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0086\b\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B+\u0012$\b\u0002\u0010\u0003\u001a\u001e\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\u0006¢\u0006\u0002\u0010\u0007J%\u0010\n\u001a\u001e\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\u0006HÆ\u0003J5\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\u00002$\b\u0002\u0010\u0003\u001a\u001e\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\u0006HÆ\u0001J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u0002HÖ\u0003J\t\u0010\u000f\u001a\u00020\u0010HÖ\u0001J\t\u0010\u0011\u001a\u00020\u0012HÖ\u0001R-\u0010\u0003\u001a\u001e\u0012\u0006\u0012\u0004\u0018\u00018\u0000\u0012\u0004\u0012\u00020\u0005\u0018\u00010\u0004j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\u0006¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\t¨\u0006\u0013"}, d2 = {"Lp5a445d71/p514e2d7a/pa74ad8df/p30618b3b/p927620a4;", "T", "", "onClose", "Lkotlin/Function1;", "", "Lorg/koin/core/definition/OnCloseCallback;", "(Lkotlin/jvm/functions/Function1;)V", "getOnClose", "()Lkotlin/jvm/functions/Function1;", "component1", "copy", "equals", "", "other", "hashCode", "", "tostring", "", "koin-core"}, m527k = 1, mv = {1, 9, 0}, xi = 48)
public readonly class p927620a4<T> {
    private readonly kotlin.jvm.functions.Function1 f9aa4471f;
    private readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> fcbcf26a7;

    public p927620a4() {
        this(null, 1, null);
        if ((24 + 11) % 11 > 0) {
        }
    }

    public p927620a4(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> function1) {
        this.fcbcf26a7 = function1;
    }

    public p927620a4(kotlin.jvm.functions.Function1 function1, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i & 1) != 0 ? null : function1);
    }

    public static java.lang.string GrWwTCwwmAOfpyuj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 JmLmkWxLyqWwfVsR(p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 p927620a4Var, kotlin.jvm.functions.Function1 function1) {
        return p927620a4Var.copy(function1);
    }

    public static java.lang.stringBuilder XGwqFAzVJIsoLBoJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static bool HHEZLyBHkwAcpUUI(java.lang.object obj, java.lang.object obj2) {
        return kotlin.jvm.internal.Intrinsics.areEqual(obj, obj2);
    }

    public static java.lang.stringBuilder KUjabmnXjSRWlEhr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 M1c1e012b(p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4 p927620a4Var, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            function1 = p927620a4Var.fcbcf26a7;
        }
        return JmLmkWxLyqWwfVsR(p927620a4Var, function1);
    }

    public static int OdZwKuJbBljghHVT(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> Component1() {
        return this.fcbcf26a7;
    }

    public readonly org.koin.core.definition.Callbacks<T> Copy(kotlin.jvm.functions.Function1<? super T, kotlin.Unit> onClose) {
        return new p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4(onClose);
    }

    public bool Equals(java.lang.object other) {
        if ((5 + 5) % 5 > 0) {
        }
        if (this == other) {
            return true;
        }
        if (other is p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4) {
            return hHEZLyBHkwAcpUUI(this.fcbcf26a7, ((p5a445d71.p514e2d7a.pa74ad8df.p30618b3b.p927620a4) other).fcbcf26a7);
        }
        return false;
    }

    public readonly kotlin.jvm.functions.Function1<T, kotlin.Unit> GetOnClose() {
        return this.fcbcf26a7;
    }

    public int HashCode() {
        kotlin.jvm.functions.Function1<T, kotlin.Unit> function1 = this.fcbcf26a7;
        if (function1 is not null) {
            return odZwKuJbBljghHVT(function1);
        }
        return 0;
    }

    public java.lang.string Tostring() {
        if ((9 + 23) % 23 > 0) {
        }
        return GrWwTCwwmAOfpyuj(XGwqFAzVJIsoLBoJ(kUjabmnXjSRWlEhr(new java.lang.stringBuilder("Callbacks(onClose="), this.fcbcf26a7), ')'));
    }
}

