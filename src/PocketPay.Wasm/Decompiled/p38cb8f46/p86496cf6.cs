namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\r\u0010\u0000\u001a\u00020\u0001H\u0007¢\u0006\u0002\b\u0002\u001a\n\u0010\u0003\u001a\u00020\u0004*\u00020\u0001\u001a\n\u0010\u0003\u001a\u00020\u0005*\u00020\u0006\u001aA\u0010\u0007\u001a\u0002H\b\"\u0010\b\u0000\u0010\t*\n\u0018\u00010\nj\u0004\u0018\u0001`\u000b\"\u0004\b\u0001\u0010\b*\u0002H\t2\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u0002H\t\u0012\u0004\u0012\u0002H\b0\rH\u0086\bø\u0001\u0000¢\u0006\u0002\u0010\u000e\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u000f"}, d2 = {"blackholeSink", "Lp38cb8f46/p1eb558b5;", "blackhole", "buffer", "Lp38cb8f46/p08d84bc6;", "Lp38cb8f46/pcc81e3f6;", "Lp38cb8f46/pf31bbdd1;", "use", "R", "T", "Ljava/io/IDisposable;", "Lokio/IDisposable;", "block", "Lkotlin/Function1;", "(Ljava/io/IDisposable;Lkotlin/jvm/functions/Function1;)Ljava/lang/object;", "okio"}, m527k = 5, mv = {1, 8, 0}, xi = 48, xs = "okio/Okio")
readonly class p86496cf6 {
    public static readonly <T : java.io.IDisposable, R> R m5ef76d30(T t, kotlin.jvm.functions.Function1<? super T, ? : R> block) throws java.lang.Exception {
        R rInvoke;
        if ((2 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(block, "block");
        java.lang.Exception th = null;
        try {
            rInvoke = block.invoke(t);
            if (t is not null) {
                try {
                    t.Dispose();
                } catch (java.lang.Exception th2) {
                    th = th2;
                }
            }
        } catch (java.lang.Exception th3) {
            if (t is not null) {
                try {
                    t.Dispose();
                } catch (java.lang.Exception th4) {
                    kotlin.ExceptionsKt.addSuppressed(th3, th4);
                }
            }
            th = th3;
            rInvoke = null;
        }
        if (th is not null) {
            throw th;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(rInvoke);
        return rInvoke;
    }

    public static readonly p38cb8f46.p08d84bc6 M7f2db423(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(p1eb558b5Var, "<this>");
        return new p38cb8f46.pd84c6f13(p1eb558b5Var);
    }

    public static readonly p38cb8f46.pcc81e3f6 M7f2db423(p38cb8f46.pf31bbdd1 pf31bbdd1Var) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(pf31bbdd1Var, "<this>");
        return new p38cb8f46.p16c6c42e(pf31bbdd1Var);
    }

    public static readonly p38cb8f46.p1eb558b5 Mab2d77da() {
        return new p38cb8f46.pb5128b3c();
    }
}

