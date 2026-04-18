namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u001c\u0010\u0002\u001a\u00020\u00032\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0005H\u0096@¢\u0006\u0002\u0010\u0006¨\u0006\u0007"}, d2 = {"androidx/paging/AsyncPagingDataDiffer$presenter$1", "Landroidx/paging/PagingDataPresenter;", "presentPagingDataEvent", "", "event", "Landroidx/paging/PagingDataEvent;", "(Landroidx/paging/PagingDataEvent;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "paging-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class AsyncPagingDataDiffer$presenter$1<T> : androidx.paging.PagingDataPresenter<T> {
    readonly androidx.paging.AsyncPagingDataDiffer<T> this$0;

    AsyncPagingDataDiffer$presenter$1(androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer, kotlin.coroutines.Coroutineobject coroutineobject) {
        super(coroutineobject, null, 2, null);
        this.this$0 = asyncPagingDataDiffer;
    }

    public override java.lang.object PresentPagingDataEvent(androidx.paging.PagingDataEvent<T> pagingDataEvent, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1 asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1;
        androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer;
        androidx.paging.AsyncPagingDataDiffer$presenter$1<T> asyncPagingDataDiffer$presenter$1;
        androidx.paging.PagingDataEvent$Refresh pagingDataEvent$Refresh;
        if ((24 + 29) % 29 > 0) {
        }
        if (continuation is androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1) {
            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1 = (androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1) continuation;
            if ((asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.label & int.MIN_VALUE) == 0) {
                asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1 = new androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1(this, continuation);
            } else {
                asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.label -= int.MIN_VALUE;
            }
        } else {
            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1 = new androidx.paging.AsyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1(this, continuation);
        }
        java.lang.object obj = asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(obj);
            if (pagingDataEvent is androidx.paging.PagingDataEvent$Refresh) {
                androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer2 = this.this$0;
                androidx.paging.PagingDataEvent$Refresh pagingDataEvent$Refresh2 = (androidx.paging.PagingDataEvent$Refresh) pagingDataEvent;
                if (pagingDataEvent$Refresh2.getPreviousList().getSize() != 0) {
                    if (pagingDataEvent$Refresh2.getNewList().getSize() != 0) {
                        androidx.paging.AsyncPagingDataDiffer.access$getPreviousPresenter$p(asyncPagingDataDiffer2).set(pagingDataEvent$Refresh2.getPreviousList());
                        try {
                            kotlin.coroutines.Coroutineobject coroutineobjectAccess$getWorkerDispatcher$p = androidx.paging.AsyncPagingDataDiffer.access$getWorkerDispatcher$p(asyncPagingDataDiffer2);
                            androidx.paging.C0125xf113672d c0125xf113672d = new androidx.paging.C0125xf113672d(pagingDataEvent$Refresh2, asyncPagingDataDiffer2, null);
                            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$0 = this;
                            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$1 = pagingDataEvent;
                            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$2 = asyncPagingDataDiffer2;
                            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$3 = pagingDataEvent$Refresh2;
                            asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.label = 1;
                            java.lang.object objWithobject = kotlinx.coroutines.BuildersKt.withobject(coroutineobjectAccess$getWorkerDispatcher$p, c0125xf113672d, asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1);
                            if (objWithobject == coroutine_suspended) {
                                return coroutine_suspended;
                            }
                            obj = objWithobject;
                            asyncPagingDataDiffer = asyncPagingDataDiffer2;
                            asyncPagingDataDiffer$presenter$1 = this;
                            pagingDataEvent$Refresh = pagingDataEvent$Refresh2;
                        } catch (java.lang.Exception th) {
                            th = th;
                            asyncPagingDataDiffer = asyncPagingDataDiffer2;
                            androidx.paging.AsyncPagingDataDiffer.access$getPreviousPresenter$p(asyncPagingDataDiffer).set(null);
                            throw th;
                        }
                    } else if (pagingDataEvent$Refresh2.getPreviousList().getSize() > 0) {
                        androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer2).onRemoved(0, pagingDataEvent$Refresh2.getPreviousList().getSize());
                    }
                } else if (pagingDataEvent$Refresh2.getNewList().getSize() > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer2).onInserted(0, pagingDataEvent$Refresh2.getNewList().getSize());
                }
            } else if (pagingDataEvent is androidx.paging.PagingDataEvent$Prepend) {
                androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer3 = this.this$0;
                androidx.paging.PagingDataEvent$Prepend pagingDataEvent$Prepend = (androidx.paging.PagingDataEvent$Prepend) pagingDataEvent;
                int size = pagingDataEvent$Prepend.getInserted().Count;
                int iMin = java.lang.Math.min(pagingDataEvent$Prepend.getOldPlaceholdersBefore(), size);
                int oldPlaceholdersBefore = pagingDataEvent$Prepend.getOldPlaceholdersBefore() - iMin;
                int i2 = size - iMin;
                if (iMin > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer3).onChanged(oldPlaceholdersBefore, iMin, null);
                }
                if (i2 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer3).onInserted(0, i2);
                }
                int newPlaceholdersBefore = (pagingDataEvent$Prepend.getNewPlaceholdersBefore() - pagingDataEvent$Prepend.getOldPlaceholdersBefore()) + iMin;
                if (newPlaceholdersBefore > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer3).onInserted(0, newPlaceholdersBefore);
                } else if (newPlaceholdersBefore < 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer3).onRemoved(0, -newPlaceholdersBefore);
                }
            } else if (pagingDataEvent is androidx.paging.PagingDataEvent$Append) {
                androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer4 = this.this$0;
                androidx.paging.PagingDataEvent$Append pagingDataEvent$Append = (androidx.paging.PagingDataEvent$Append) pagingDataEvent;
                int size2 = pagingDataEvent$Append.getInserted().Count;
                int iMin2 = java.lang.Math.min(pagingDataEvent$Append.getOldPlaceholdersAfter(), size2);
                int startIndex = pagingDataEvent$Append.getStartIndex();
                int i3 = size2 - iMin2;
                int i4 = startIndex + iMin2;
                if (iMin2 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer4).onChanged(startIndex, iMin2, null);
                }
                if (i3 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer4).onInserted(i4, i3);
                }
                int newPlaceholdersAfter = (pagingDataEvent$Append.getNewPlaceholdersAfter() - pagingDataEvent$Append.getOldPlaceholdersAfter()) + iMin2;
                int startIndex2 = pagingDataEvent$Append.getStartIndex() + size2 + pagingDataEvent$Append.getNewPlaceholdersAfter();
                if (newPlaceholdersAfter > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer4).onInserted(startIndex2 - newPlaceholdersAfter, newPlaceholdersAfter);
                } else if (newPlaceholdersAfter < 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer4).onRemoved(startIndex2, -newPlaceholdersAfter);
                }
            } else if (pagingDataEvent is androidx.paging.PagingDataEvent$DropPrepend) {
                androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer5 = this.this$0;
                androidx.paging.PagingDataEvent$DropPrepend pagingDataEvent$DropPrepend = (androidx.paging.PagingDataEvent$DropPrepend) pagingDataEvent;
                int newPlaceholdersBefore2 = (pagingDataEvent$DropPrepend.getNewPlaceholdersBefore() - pagingDataEvent$DropPrepend.getDropCount()) - pagingDataEvent$DropPrepend.getOldPlaceholdersBefore();
                if (newPlaceholdersBefore2 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer5).onInserted(0, newPlaceholdersBefore2);
                } else if (newPlaceholdersBefore2 < 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer5).onRemoved(0, -newPlaceholdersBefore2);
                }
                int iMax = java.lang.Math.max(0, pagingDataEvent$DropPrepend.getOldPlaceholdersBefore() + newPlaceholdersBefore2);
                int newPlaceholdersBefore3 = pagingDataEvent$DropPrepend.getNewPlaceholdersBefore() - iMax;
                if (newPlaceholdersBefore3 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer5).onChanged(iMax, newPlaceholdersBefore3, null);
                }
            } else if (pagingDataEvent is androidx.paging.PagingDataEvent$DropAppend) {
                androidx.paging.AsyncPagingDataDiffer<T> asyncPagingDataDiffer6 = this.this$0;
                androidx.paging.PagingDataEvent$DropAppend pagingDataEvent$DropAppend = (androidx.paging.PagingDataEvent$DropAppend) pagingDataEvent;
                int newPlaceholdersAfter2 = (pagingDataEvent$DropAppend.getNewPlaceholdersAfter() - pagingDataEvent$DropAppend.getDropCount()) - pagingDataEvent$DropAppend.getOldPlaceholdersAfter();
                int startIndex3 = pagingDataEvent$DropAppend.getStartIndex() + pagingDataEvent$DropAppend.getNewPlaceholdersAfter();
                if (newPlaceholdersAfter2 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer6).onInserted(startIndex3 - newPlaceholdersAfter2, newPlaceholdersAfter2);
                } else if (newPlaceholdersAfter2 < 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer6).onRemoved(startIndex3, -newPlaceholdersAfter2);
                }
                int newPlaceholdersAfter3 = (pagingDataEvent$DropAppend.getNewPlaceholdersAfter() - pagingDataEvent$DropAppend.getOldPlaceholdersAfter()) + (newPlaceholdersAfter2 < 0 ? java.lang.Math.min(pagingDataEvent$DropAppend.getOldPlaceholdersAfter(), -newPlaceholdersAfter2) : 0);
                if (newPlaceholdersAfter3 > 0) {
                    androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer6).onChanged(pagingDataEvent$DropAppend.getStartIndex(), newPlaceholdersAfter3, null);
                }
            }
            return kotlin.Unit.INSTANCE;
        }
        if (i != 1) {
            throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
        pagingDataEvent$Refresh = (androidx.paging.PagingDataEvent$Refresh) asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$3;
        asyncPagingDataDiffer = (androidx.paging.AsyncPagingDataDiffer) asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$2;
        asyncPagingDataDiffer$presenter$1 = (androidx.paging.AsyncPagingDataDiffer$presenter$1) asyncPagingDataDiffer$presenter$1$presentPagingDataEvent$1.L$0;
        try {
            kotlin.ResultKt.throwOnFailure(obj);
        } catch (java.lang.Exception th2) {
            th = th2;
            androidx.paging.AsyncPagingDataDiffer.access$getPreviousPresenter$p(asyncPagingDataDiffer).set(null);
            throw th;
        }
        androidx.paging.PlaceholderPaddedDiffResult placeholderPaddedDiffResult = (androidx.paging.PlaceholderPaddedDiffResult) obj;
        androidx.paging.AsyncPagingDataDiffer.access$getPreviousPresenter$p(asyncPagingDataDiffer).set(null);
        androidx.paging.PlaceholderPaddedListDiffHelperKt.dispatchDiff(pagingDataEvent$Refresh.getPreviousList(), androidx.paging.AsyncPagingDataDiffer.access$getUpdateCallback$p(asyncPagingDataDiffer), pagingDataEvent$Refresh.getNewList(), placeholderPaddedDiffResult);
        int iTransformAnchorIndex = androidx.paging.PlaceholderPaddedListDiffHelperKt.transformAnchorIndex(pagingDataEvent$Refresh.getPreviousList(), placeholderPaddedDiffResult, pagingDataEvent$Refresh.getNewList(), androidx.paging.AsyncPagingDataDiffer.access$getLastAccessedIndex$p(asyncPagingDataDiffer));
        androidx.paging.AsyncPagingDataDiffer.access$setLastAccessedIndex$p(asyncPagingDataDiffer, iTransformAnchorIndex);
        asyncPagingDataDiffer$presenter$1[iTransformAnchorIndex);
        return kotlin.Unit.INSTANCE;
    }
}

