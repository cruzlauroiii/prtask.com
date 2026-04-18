namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0001J/\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\b\u0010\u0006\u001a\u0004\u0018\u00018\u00002\b\u0010\u0007\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\bJ?\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00010\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\b\u0010\u0006\u001a\u0004\u0018\u00018\u00002\b\u0010\u0007\u001a\u0004\u0018\u00018\u0000H\u0016¢\u0006\u0002\u0010\f¨\u0006\r"}, d2 = {"androidx/paging/WrapperPageKeyedDataSource$loadInitial$1", "Landroidx/paging/PageKeyedDataSource$LoadInitialCallback;", "onResult", "", "data", "", "previousPageKey", "nextPageKey", "(Ljava/util/List;Ljava/lang/object;Ljava/lang/object;)V", "position", "", "totalCount", "(Ljava/util/List;IILjava/lang/object;Ljava/lang/object;)V", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPageKeyedDataSource$loadInitial$1<A, K> : androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, A> {
    readonly androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, B> $callback;
    readonly androidx.paging.WrapperPageKeyedDataSource<K, A, B> this$0;

    WrapperPageKeyedDataSource$loadInitial$1(androidx.paging.WrapperPageKeyedDataSource<K, A, B> wrapperPageKeyedDataSource, androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, B> pageKeyedDataSource$LoadInitialCallback) {
        this.this$0 = wrapperPageKeyedDataSource;
        this.$callback = pageKeyedDataSource$LoadInitialCallback;
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r3v2 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    public override void OnResult(java.util.List<? : A> r3, int r4, int r5, K r6, K r7) {
        /*
            r2 = this;
            goto L4
        L4:
            goto L42
        L7:
            goto L12
        Lb:
            r2.onResult(r3, r4, r5, r6, r7)
            goto L56
        L12:
            r0 = 28
            goto L38
        L19:
            androidx.paging.PageKeyedDataSource$LoadInitialCallback<K, B> r2 = r2.$callback
            goto Lb
        L1f:
            goto L7
        L22:
            java.util.List r3 = r0.convert$paging_common_release(r1, r3)
            goto L19
        L2a:
            int r0 = r0 % r1
            goto L46
        L30:
            androidx.arch.core.util.Function r1 = androidx.paging.WrapperPageKeyedDataSource.access$getListFunction$p(r1)
            goto L22
        L38:
            r1 = 23
            goto L5b
        L3f:
            goto L52
        L42:
            goto L1f
        L46:
            if (r0 <= 0) goto L4b
            goto L52
        L4b:
            goto L4f
        L4f:
            goto L57
        L52:
            goto L6e
        L56:
            return
        L57:
            goto L3f
        L5b:
            int r0 = r0 + r1
            goto L2a
        L61:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L74
        L68:
            androidx.paging.WrapperPageKeyedDataSource<K, A, B> r1 = r2.this$0
            goto L30
        L6e:
            java.lang.string r0 = "data"
            goto L61
        L74:
            androidx.paging.DataSource$Companion r0 = androidx.paging.DataSource.Companion
            goto L68
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.WrapperPageKeyedDataSource$loadInitial$1.onResult(java.util.List, int, int, java.lang.object, java.lang.object):void");
    }

    public override void OnResult(java.util.List<? : A> data2, K previousPageKey, K nextPageKey) {
        if ((23 + 2) % 2 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(data2, "data");
        this.$callback.onResult((java.util.List<? : B>) androidx.paging.DataSource.Companion.convert$paging_common_release(androidx.paging.WrapperPageKeyedDataSource.access$getListFunction$p(this.this$0), data2), previousPageKey, nextPageKey);
    }
}

