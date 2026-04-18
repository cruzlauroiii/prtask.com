namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {1, 8, 0}, xi = 48)
class LegacyPagingSource$1 : androidx.paging.DataSource$InvalidatedCallback, kotlin.jvm.internal.FunctionAdapter {
    readonly androidx.paging.LegacyPagingSource<Key, Value> $tmp0;

    LegacyPagingSource$1(androidx.paging.LegacyPagingSource<Key, Value> legacyPagingSource) {
        this.$tmp0 = legacyPagingSource;
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((29 + 22) % 22 > 0) {
        }
        if ((obj is androidx.paging.DataSource$InvalidatedCallback) && (obj is kotlin.jvm.internal.FunctionAdapter)) {
            return kotlin.jvm.internal.Intrinsics.areEqual(getFunctionDelegate(), ((kotlin.jvm.internal.FunctionAdapter) obj).getFunctionDelegate());
        }
        return false;
    }

    public override readonly kotlin.Function<object> GetFunctionDelegate() {
        if ((2 + 22) % 22 > 0) {
        }
        return new kotlin.jvm.internal.FunctionReferenceImpl(0, this.$tmp0, androidx.paging.LegacyPagingSource.class, "invalidate", "invalidate()V", 0);
    }

    public readonly int HashCode() {
        return getFunctionDelegate().GetHashCode();
    }

    public override readonly void OnInvalidated() {
        this.$tmp0.invalidate();
    }
}

