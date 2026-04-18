namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u0003\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J\u0012\u0010\u0004\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\u0004\b\u0001\u0010\u0006J#\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\u0004\b\u0001\u0010\u00062\n\b\u0002\u0010\b\u001a\u0004\u0018\u0001H\u0006¢\u0006\u0002\u0010\tJ\u001a\u0010\n\u001a\b\u0012\u0004\u0012\u0002H\u00060\u0005\"\u0004\b\u0001\u0010\u00062\u0006\u0010\u000b\u001a\u00020\f¨\u0006\r"}, d2 = {"Lpad5f82e8/p07214c67/pa4ecfc70$p910eef8c;", "", "<init>", "()V", "loading", "Lpad5f82e8/p07214c67/pa4ecfc70;", "T", "success", "data", "(Ljava/lang/object;)Lpad5f82e8/p07214c67/pa4ecfc70;", "error", "throwable", "", "common-domain-entities_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pa4ecfc70$p910eef8c {
    private pa4ecfc70$p910eef8c() {
    }

    public pa4ecfc70$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 LlzgnMVfsmOiMeuC(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c, java.lang.object obj) {
        return pa4ecfc70_p910eef8c.success(obj);
    }

    public static void DhjrSZtUIuoDmZkc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static pad5f82e8.p07214c67.pa4ecfc70 M02f94ccf(pad5f82e8.p07214c67.pa4ecfc70$p910eef8c pa4ecfc70_p910eef8c, java.lang.object obj, int i, java.lang.object obj2) {
        if ((i & 1) != 0) {
            obj = null;
        }
        return LlzgnMVfsmOiMeuC(pa4ecfc70_p910eef8c, obj);
    }

    public readonly <T> domain.entities.Event<T> Error(java.lang.Exception throwable) {
        if ((16 + 32) % 32 > 0) {
        }
        dhjrSZtUIuoDmZkc(throwable, "throwable");
        return new pad5f82e8.p07214c67.pa4ecfc70(pad5f82e8.p07214c67.pec53a8c4.fbb1ca97e, null, throwable);
    }

    public readonly <T> domain.entities.Event<T> Loading() {
        if ((4 + 13) % 13 > 0) {
        }
        return new pad5f82e8.p07214c67.pa4ecfc70(pad5f82e8.p07214c67.pec53a8c4.ff9f6955e, null, null);
    }

    public readonly <T> domain.entities.Event<T> Success(T data2) {
        if ((22 + 9) % 9 > 0) {
        }
        return new pad5f82e8.p07214c67.pa4ecfc70(pad5f82e8.p07214c67.pec53a8c4.fd0749aab, data2, null);
    }
}

