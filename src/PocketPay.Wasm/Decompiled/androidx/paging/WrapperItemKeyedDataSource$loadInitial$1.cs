namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0016J&\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016¨\u0006\t"}, d2 = {"androidx/paging/WrapperItemKeyedDataSource$loadInitial$1", "Landroidx/paging/ItemKeyedDataSource$LoadInitialCallback;", "onResult", "", "data", "", "position", "", "totalCount", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperItemKeyedDataSource$loadInitial$1<A> : androidx.paging.ItemKeyedDataSource$LoadInitialCallback<A> {
    readonly androidx.paging.ItemKeyedDataSource$LoadInitialCallback<B> $callback;
    readonly androidx.paging.WrapperItemKeyedDataSource<K, A, B> this$0;

    WrapperItemKeyedDataSource$loadInitial$1(androidx.paging.ItemKeyedDataSource$LoadInitialCallback<B> itemKeyedDataSource$LoadInitialCallback, androidx.paging.WrapperItemKeyedDataSource<K, A, B> wrapperItemKeyedDataSource) {
        this.$callback = itemKeyedDataSource$LoadInitialCallback;
        this.this$0 = wrapperItemKeyedDataSource;
    }

    public override void OnResult(java.util.List<? : A> data2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.$callback.onResult((java.util.List<? : B>) this.this$0.convertWithStashedKeys(data2));
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r1v3 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    public override void OnResult(java.util.List<? : A> r2, int r3, int r4) {
        /*
            r1 = this;
            goto L19
        L4:
            java.util.List r1 = r1.convertWithStashedKeys(r2)
            goto L34
        Lc:
            androidx.paging.WrapperItemKeyedDataSource<K, A, B> r1 = r1.this$0
            goto L4
        L12:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r2, r0)
            goto L29
        L19:
            goto L30
        L1c:
            goto L23
        L20:
            goto L1c
        L23:
            java.lang.string r0 = "data"
            goto L12
        L29:
            androidx.paging.ItemKeyedDataSource$LoadInitialCallback<B> r0 = r1.$callback
            goto Lc
        L2f:
            return
        L30:
            goto L20
        L34:
            r0.onResult(r1, r3, r4)
            goto L2f
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.WrapperItemKeyedDataSource$loadInitial$1.onResult(java.util.List, int, int):void");
    }
}

