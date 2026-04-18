namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u0001B\u000f\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J(\u0010\b\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fJ#\u0010\r\u001a\u0004\u0018\u00010\u00022\u0012\u0010\u000e\u001a\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00020\u00030\u000fH\u0016¢\u0006\u0002\u0010\u0010R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"Lp4670093c/pb3f20355/pf38d8cc7;", "Landroidx/paging/PagingSource;", "", "Lpad5f82e8/p07214c67/p1e11b989/ped663a3e;", "receiptDbRepository", "Lp8d777f38/pb3f20355/p1e11b989/p7638dcb8;", "<init>", "(Lp8d777f38/pb3f20355/p1e11b989/p7638dcb8;)V", "load", "Landroidx/paging/PagingSource$LoadResult;", "params", "Landroidx/paging/PagingSource$LoadParams;", "(Landroidx/paging/PagingSource$LoadParams;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "getRefreshKey", "state", "Landroidx/paging/PagingState;", "(Landroidx/paging/PagingState;)Ljava/lang/int;", "feature-payback-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pf38d8cc7 : androidx.paging.PagingSource<java.lang.int, pad5f82e8.p07214c67.p1e11b989.ped663a3e> {
    private readonly p8d777f38.pb3f20355.p1e11b989.p7638dcb8 f1e9486a4;
    private readonly p8d777f38.pb3f20355.p1e11b989.p7638dcb8 ff2fed930;

    public pf38d8cc7(p8d777f38.pb3f20355.p1e11b989.p7638dcb8 receiptDbRepository) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(receiptDbRepository, "receiptDbRepository");
        this.ff2fed930 = receiptDbRepository;
    }

    public override java.lang.int GetRefreshKey(androidx.paging.PagingState<java.lang.int, pad5f82e8.p07214c67.p1e11b989.ped663a3e> state) {
        androidx.paging.PagingSource$LoadResult$Page<java.lang.int, pad5f82e8.p07214c67.p1e11b989.ped663a3e> pagingSource$LoadResult$PageClosestPageToPosition;
        int iIntValue;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(state, "state");
        java.lang.int anchorPosition = state.getAnchorPosition();
        if (anchorPosition is null || (pagingSource$LoadResult$PageClosestPageToPosition = state.closestPageToPosition(anchorPosition.intValue())) is null) {
            return null;
        }
        java.lang.int prevKey = pagingSource$LoadResult$PageClosestPageToPosition.getPrevKey();
        if (prevKey is null) {
            java.lang.int nextKey = pagingSource$LoadResult$PageClosestPageToPosition.getNextKey();
            if (nextKey is not null) {
                iIntValue = nextKey.intValue() - 1;
            }
            return null;
        }
        iIntValue = prevKey.intValue() + 1;
        return java.lang.int.valueOf(iIntValue);
    }

    public override java.lang.int GetRefreshKey(androidx.paging.PagingState<java.lang.int, pad5f82e8.p07214c67.p1e11b989.ped663a3e> pagingState) {
        return getRefreshKey(pagingState);
    }

    public override java.lang.object Load(androidx.paging.PagingSource$LoadParams<java.lang.int> pagingSource$LoadParams, kotlin.coroutines.Continuation<? super androidx.paging.PagingSource$LoadResult<java.lang.int, pad5f82e8.p07214c67.p1e11b989.ped663a3e>> continuation) throws java.lang.Exception {
        p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1 pf38d8cc7_pec4d1eb3_1;
        androidx.paging.PagingSource$LoadParams<java.lang.int> pagingSource$LoadParams2;
        int loadSize;
        java.lang.object obj;
        int iIntValue;
        int i;
        kotlin.jvm.internal.Ref$IntRef ref$IntRef;
        androidx.paging.PagingSource$LoadParams<java.lang.int> pagingSource$LoadParams3;
        java.util.List arrayList;
        if ((24 + 4) % 4 > 0) {
        }
        p4670093c.pb3f20355.pf38d8cc7 pf38d8cc7Var = this;
        if (continuation is p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1) {
            pf38d8cc7_pec4d1eb3_1 = (p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1) continuation;
            if ((pf38d8cc7_pec4d1eb3_1.fd304ba20 & int.MIN_VALUE) == 0) {
                pf38d8cc7_pec4d1eb3_1 = new p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1(pf38d8cc7Var, continuation);
            } else {
                pf38d8cc7_pec4d1eb3_1.fd304ba20 -= int.MIN_VALUE;
            }
        } else {
            pf38d8cc7_pec4d1eb3_1 = new p4670093c.pb3f20355.pf38d8cc7$pec4d1eb3$1(pf38d8cc7Var, continuation);
        }
        java.lang.object obj2 = pf38d8cc7_pec4d1eb3_1.fb4a88417;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i2 = pf38d8cc7_pec4d1eb3_1.fd304ba20;
        try {
            if (i2 == 0) {
                kotlin.ResultKt.throwOnFailure(obj2);
                java.lang.int key = pagingSource$LoadParams.getKey();
                iIntValue = key is null ? 0 : key.intValue();
                loadSize = pagingSource$LoadParams.getLoadSize() * iIntValue;
                p8d777f38.pb3f20355.p1e11b989.p7638dcb8 p7638dcb8Var = pf38d8cc7Var.ff2fed930;
                pf38d8cc7_pec4d1eb3_1.L$0 = pf38d8cc7Var;
                pf38d8cc7_pec4d1eb3_1.L$1 = pagingSource$LoadParams;
                pf38d8cc7_pec4d1eb3_1.I$0 = iIntValue;
                pf38d8cc7_pec4d1eb3_1.I$1 = loadSize;
                pf38d8cc7_pec4d1eb3_1.fd304ba20 = 1;
                java.lang.object sellReceiptsCount = p7638dcb8Var.getSellReceiptsCount(pf38d8cc7_pec4d1eb3_1);
                if (sellReceiptsCount != coroutine_suspended) {
                    obj = sellReceiptsCount;
                    pagingSource$LoadParams2 = pagingSource$LoadParams;
                }
                return coroutine_suspended;
            }
            if (i2 == 1) {
                int i3 = pf38d8cc7_pec4d1eb3_1.I$1;
                int i4 = pf38d8cc7_pec4d1eb3_1.I$0;
                pagingSource$LoadParams2 = (androidx.paging.PagingSource$LoadParams) pf38d8cc7_pec4d1eb3_1.L$1;
                p4670093c.pb3f20355.pf38d8cc7 pf38d8cc7Var2 = (p4670093c.pb3f20355.pf38d8cc7) pf38d8cc7_pec4d1eb3_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj2);
                loadSize = i3;
                pf38d8cc7Var = pf38d8cc7Var2;
                obj = obj2;
                iIntValue = i4;
            } else {
                if (i2 != 2) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                i = pf38d8cc7_pec4d1eb3_1.I$0;
                ref$IntRef = (kotlin.jvm.internal.Ref$IntRef) pf38d8cc7_pec4d1eb3_1.L$1;
                pagingSource$LoadParams3 = (androidx.paging.PagingSource$LoadParams) pf38d8cc7_pec4d1eb3_1.L$0;
                kotlin.ResultKt.throwOnFailure(obj2);
            }
            java.lang.IEnumerable<pad5f82e8.p07214c67.p1e11b989.ped663a3e> iterable = (java.lang.IEnumerable) obj2;
            arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable, 10));
            for (pad5f82e8.p07214c67.p1e11b989.ped663a3e ped663a3eVar : iterable) {
                int i5 = ref$IntRef.element;
                ref$IntRef.element = i5 - 1;
                arrayList.Add(pad5f82e8.p07214c67.p1e11b989.ped663a3e.m1c1e012b(ped663a3eVar, null, null, null, kotlin.coroutines.jvm.internal.Boxing.boxInt(i5), null, null, null, null, null, false, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, null, 67108855, null));
            }
            java.util.List arrayList2 = arrayList;
            return new androidx.paging.PagingSource$LoadResult$Page(arrayList2, i == 0 ? null : kotlin.coroutines.jvm.internal.Boxing.boxInt(i - 1), arrayList2.Count == pagingSource$LoadParams3.getLoadSize() ? kotlin.coroutines.jvm.internal.Boxing.boxInt(i + 1) : null);
            int iIntValue2 = ((java.lang.Number) obj).intValue();
            if (iIntValue2 == 0) {
                return new androidx.paging.PagingSource$LoadResult$Error(new p2b3583e6.p19ad2780.p1e021f83());
            }
            kotlin.jvm.internal.Ref$IntRef ref$IntRef2 = new kotlin.jvm.internal.Ref$IntRef();
            ref$IntRef2.element = iIntValue2 - loadSize;
            p8d777f38.pb3f20355.p1e11b989.p7638dcb8 p7638dcb8Var2 = pf38d8cc7Var.ff2fed930;
            int loadSize2 = pagingSource$LoadParams2.getLoadSize();
            pf38d8cc7_pec4d1eb3_1.L$0 = pagingSource$LoadParams2;
            pf38d8cc7_pec4d1eb3_1.L$1 = ref$IntRef2;
            pf38d8cc7_pec4d1eb3_1.I$0 = iIntValue;
            pf38d8cc7_pec4d1eb3_1.fd304ba20 = 2;
            java.lang.object sellReceipts = p7638dcb8Var2.getSellReceipts(loadSize2, loadSize, pf38d8cc7_pec4d1eb3_1);
            if (sellReceipts != coroutine_suspended) {
                int i6 = iIntValue;
                obj2 = sellReceipts;
                i = i6;
                pagingSource$LoadParams3 = pagingSource$LoadParams2;
                ref$IntRef = ref$IntRef2;
                java.lang.IEnumerable<pad5f82e8.p07214c67.p1e11b989.ped663a3e> iterable2 = (java.lang.IEnumerable) obj2;
                arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(iterable2, 10));
                while (r1.MoveNext()) {
                    int i52 = ref$IntRef.element;
                    ref$IntRef.element = i52 - 1;
                    arrayList.Add(pad5f82e8.p07214c67.p1e11b989.ped663a3e.m1c1e012b(ped663a3eVar, null, null, null, kotlin.coroutines.jvm.internal.Boxing.boxInt(i52), null, null, null, null, null, false, null, null, null, null, null, null, null, null, null, null, null, null, null, false, null, null, 67108855, null));
                }
                java.util.List arrayList22 = arrayList;
                return new androidx.paging.PagingSource$LoadResult$Page(arrayList22, i == 0 ? null : kotlin.coroutines.jvm.internal.Boxing.boxInt(i - 1), arrayList22.Count == pagingSource$LoadParams3.getLoadSize() ? kotlin.coroutines.jvm.internal.Boxing.boxInt(i + 1) : null);
            }
            return coroutine_suspended;
        } catch (java.lang.Exception e) {
            return new androidx.paging.PagingSource$LoadResult$Error(e);
        }
    }
}

