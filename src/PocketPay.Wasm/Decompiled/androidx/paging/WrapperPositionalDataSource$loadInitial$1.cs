namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001e\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J&\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016¨\u0006\t"}, d2 = {"androidx/paging/WrapperPositionalDataSource$loadInitial$1", "Landroidx/paging/PositionalDataSource$LoadInitialCallback;", "onResult", "", "data", "", "position", "", "totalCount", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WrapperPositionalDataSource$loadInitial$1<A> : androidx.paging.PositionalDataSource$LoadInitialCallback<A> {
    readonly androidx.paging.PositionalDataSource$LoadInitialCallback<B> $callback;
    readonly androidx.paging.WrapperPositionalDataSource<A, B> this$0;

    WrapperPositionalDataSource$loadInitial$1(androidx.paging.PositionalDataSource$LoadInitialCallback<B> positionalDataSource$LoadInitialCallback, androidx.paging.WrapperPositionalDataSource<A, B> wrapperPositionalDataSource) {
        this.$callback = positionalDataSource$LoadInitialCallback;
        this.this$0 = wrapperPositionalDataSource;
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r2v4 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    public override void OnResult(java.util.List<? : A> r3, int r4) {
        /*
            r2 = this;
            goto L4
        L4:
            goto L55
        L7:
            goto L11
        Lb:
            androidx.paging.DataSource$Companion r1 = androidx.paging.DataSource.Companion
            goto L1f
        L11:
            r0 = 10
            goto L3e
        L18:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto L38
        L1f:
            androidx.paging.WrapperPositionalDataSource<A, B> r2 = r2.this$0
            goto L45
        L25:
            java.lang.string r0 = "data"
            goto L18
        L2b:
            int r0 = r0 + r1
            goto L74
        L31:
            goto L4e
        L34:
            goto L25
        L38:
            androidx.paging.PositionalDataSource$LoadInitialCallback<B> r0 = r2.$callback
            goto Lb
        L3e:
            r1 = 4
            goto L2b
        L45:
            androidx.arch.core.util.Function r2 = r2.getListFunction()
            goto L62
        L4d:
            return
        L4e:
            goto L52
        L52:
            goto L34
        L55:
            goto L6a
        L59:
            if (r0 <= 0) goto L5e
            goto L34
        L5e:
            goto L31
        L62:
            java.util.List r2 = r1.convert$paging_common_release(r2, r3)
            goto L6d
        L6a:
            goto L7
        L6d:
            r0.onResult(r2, r4)
            goto L4d
        L74:
            int r0 = r0 % r1
            goto L59
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.WrapperPositionalDataSource$loadInitial$1.onResult(java.util.List, int):void");
    }

    /*  JADX ERROR: JadxException in pass: FinishTypeInference
        jadx.core.utils.exceptions.JadxException: Code variable not set in r2v4 bool
        	at jadx.core.dex.instructions.args.SSAVar.getCodeVar(SSAVar.java:236)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.lambda$visit$0(FinishTypeInference.java:27)
        	at java.base/java.util.List.forEach(List.java:1596)
        	at jadx.core.dex.visitors.typeinference.FinishTypeInference.visit(FinishTypeInference.java:22)
        */
    public override void OnResult(java.util.List<? : A> r3, int r4, int r5) {
        /*
            r2 = this;
            goto L10
        L4:
            java.lang.string r0 = "data"
            goto L17
        La:
            androidx.paging.PositionalDataSource$LoadInitialCallback<B> r0 = r2.$callback
            goto L3b
        L10:
            goto L60
        L13:
            goto L34
        L17:
            kotlin.jvm.internal.Intrinsics.checkNotNullParameter(r3, r0)
            goto La
        L1e:
            int r0 = r0 + r1
            goto L41
        L24:
            androidx.arch.core.util.Function r2 = r2.getListFunction()
            goto L55
        L2c:
            goto L13
        L2f:
            return
        L30:
            goto L5d
        L34:
            r0 = 30
            goto L73
        L3b:
            androidx.paging.DataSource$Companion r1 = androidx.paging.DataSource.Companion
            goto L64
        L41:
            int r0 = r0 % r1
            goto L6a
        L47:
            goto L30
        L4a:
            goto L4
        L4e:
            r0.onResult(r2, r4, r5)
            goto L2f
        L55:
            java.util.List r2 = r1.convert$paging_common_release(r2, r3)
            goto L4e
        L5d:
            goto L4a
        L60:
            goto L2c
        L64:
            androidx.paging.WrapperPositionalDataSource<A, B> r2 = r2.this$0
            goto L24
        L6a:
            if (r0 <= 0) goto L6f
            goto L4a
        L6f:
            goto L47
        L73:
            r1 = 11
            goto L1e
        */
        throw new UnsupportedOperationException("Method not decompiled: androidx.paging.WrapperPositionalDataSource$loadInitial$1.onResult(java.util.List, int, int):void");
    }
}

