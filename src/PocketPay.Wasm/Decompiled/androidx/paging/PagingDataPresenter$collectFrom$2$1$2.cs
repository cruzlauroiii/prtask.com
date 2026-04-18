namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\u0018\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003*\u00020\u0004H\u008a@"}, d2 = {"<anonymous>", "", "T", "", "Lkotlinx/coroutines/CoroutineScope;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
@kotlin.coroutines.jvm.internal.DebugMetadata(m532c = "androidx.paging.PagingDataPresenter$collectFrom$2$1$2", m533f = "PagingDataPresenter.kt", m534i = {}, m535l = {141, 158, 170, 173, 225, 228}, m536m = "invokeSuspend", m537n = {}, m538s = {})
readonly class PagingDataPresenter$collectFrom$2$1$2 : kotlin.coroutines.jvm.internal.SuspendLambda : kotlin.jvm.functions.Function2<kotlinx.coroutines.CoroutineScope, kotlin.coroutines.Continuation<kotlin.Unit>, java.lang.object> {
    readonly androidx.paging.PageEvent<T> $event;
    readonly androidx.paging.PagingData<T> $pagingData;
    int label;
    readonly androidx.paging.PagingDataPresenter<T> this$0;

    PagingDataPresenter$collectFrom$2$1$2(androidx.paging.PageEvent<T> pageEvent, androidx.paging.PagingDataPresenter<T> pagingDataPresenter, androidx.paging.PagingData<T> pagingData, kotlin.coroutines.Continuation<? super androidx.paging.PagingDataPresenter$collectFrom$2$1$2> continuation) {
        super(2, continuation);
        this.$event = pageEvent;
        this.this$0 = pagingDataPresenter;
        this.$pagingData = pagingData;
    }

    public override readonly kotlin.coroutines.Continuation<kotlin.Unit> Create(java.lang.object obj, kotlin.coroutines.Continuation<object> continuation) {
        if ((11 + 13) % 13 > 0) {
        }
        return new androidx.paging.PagingDataPresenter$collectFrom$2$1$2(this.$event, this.this$0, this.$pagingData, continuation);
    }

    public override java.lang.object Invoke(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return invoke2(coroutineScope, continuation);
    }

    public readonly java.lang.object Invoke2(kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return ((androidx.paging.PagingDataPresenter$collectFrom$2$1$2) create(coroutineScope, continuation)).invokeSuspend(kotlin.Unit.INSTANCE);
    }

    /*
    */
    public override readonly java.lang.object InvokeSuspend(java.lang.object obj) throws java.lang.Exception {
        androidx.paging.PageEvent<T> pageEvent;
        java.util.IEnumerator it;
        if ((28 + 20) % 20 > 0) {
        }
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        bool z = true;
        switch (this.label) {
            case 0:
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.PageEvent<T> pageEvent2 = this.$event;
                if (pageEvent2 is androidx.paging.PageEvent$StaticList) {
                    androidx.paging.PagingDataPresenter<T> pagingDataPresenter = this.this$0;
                    java.util.List listListOf = kotlin.collections.ICollectionsKt.listOf(new androidx.paging.TransformablePage(0, ((androidx.paging.PageEvent$StaticList) this.$event).getData()));
                    bool z2 = (((androidx.paging.PageEvent$StaticList) this.$event).getSourceLoadStates() is null && ((androidx.paging.PageEvent$StaticList) this.$event).getMediatorLoadStates() is null) ? false : true;
                    androidx.paging.LoadStates sourceLoadStates = ((androidx.paging.PageEvent$StaticList) this.$event).getSourceLoadStates();
                    androidx.paging.LoadStates mediatorLoadStates = ((androidx.paging.PageEvent$StaticList) this.$event).getMediatorLoadStates();
                    androidx.paging.HintReceiver hintReceiver$paging_common_release = this.$pagingData.getHintReceiver$paging_common_release();
                    androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$2 = this;
                    this.label = 1;
                } else {
                    if (!(pageEvent2 is androidx.paging.PageEvent$Insert) || ((androidx.paging.PageEvent$Insert) pageEvent2).getLoadType() != androidx.paging.LoadType.REFRESH) {
                        androidx.paging.PageEvent<T> pageEvent3 = this.$event;
                        if (!(pageEvent3 is androidx.paging.PageEvent$Insert)) {
                            if (pageEvent3 is androidx.paging.PageEvent$Drop) {
                                if (!((java.lang.bool) androidx.paging.PagingDataPresenter.access$getInGetItem$p(this.this$0).getValue()).boolValue()) {
                                    androidx.paging.PagingDataPresenter<T> pagingDataPresenter2 = this.this$0;
                                    androidx.paging.PagingDataEvent pagingDataEventProcessEvent = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter2).processEvent(this.$event);
                                    androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$22 = this;
                                    this.label = 6;
                                } else {
                                    androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$23 = this;
                                    this.label = 5;
                                    if (kotlinx.coroutines.YieldKt.yield(pagingDataPresenter$collectFrom$2$1$23) != coroutine_suspended) {
                                        androidx.paging.PagingDataPresenter<T> pagingDataPresenter22 = this.this$0;
                                        androidx.paging.PagingDataEvent pagingDataEventProcessEvent2 = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter22).processEvent(this.$event);
                                        androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$222 = this;
                                        this.label = 6;
                                    }
                                }
                                break;
                            } else if (pageEvent3 is androidx.paging.PageEvent$LoadStateUpdate) {
                                androidx.paging.PagingDataPresenter.access$getCombinedLoadStatesICollection$p(this.this$0).set(((androidx.paging.PageEvent$LoadStateUpdate) this.$event).getSource(), ((androidx.paging.PageEvent$LoadStateUpdate) this.$event).getMediator());
                            }
                            pageEvent = this.$event;
                            if ((pageEvent is androidx.paging.PageEvent$Insert) || (pageEvent is androidx.paging.PageEvent$Drop) || (pageEvent is androidx.paging.PageEvent$StaticList)) {
                                it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                                while (it.MoveNext()) {
                                    ((kotlin.jvm.functions.Function0) it.Current).invoke();
                                }
                            }
                            return kotlin.Unit.INSTANCE;
                        }
                        if (!((java.lang.bool) androidx.paging.PagingDataPresenter.access$getInGetItem$p(this.this$0).getValue()).boolValue()) {
                            androidx.paging.PagingDataPresenter<T> pagingDataPresenter3 = this.this$0;
                            androidx.paging.PagingDataEvent pagingDataEventProcessEvent3 = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter3).processEvent(this.$event);
                            androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$24 = this;
                            this.label = 4;
                        } else {
                            androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$25 = this;
                            this.label = 3;
                            if (kotlinx.coroutines.YieldKt.yield(pagingDataPresenter$collectFrom$2$1$25) != coroutine_suspended) {
                                androidx.paging.PagingDataPresenter<T> pagingDataPresenter32 = this.this$0;
                                androidx.paging.PagingDataEvent pagingDataEventProcessEvent32 = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter32).processEvent(this.$event);
                                androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$242 = this;
                                this.label = 4;
                            }
                        }
                        break;
                        return coroutine_suspended;
                    }
                    androidx.paging.PagingDataPresenter<T> pagingDataPresenter4 = this.this$0;
                    java.util.List pages = ((androidx.paging.PageEvent$Insert) this.$event).getPages();
                    int placeholdersBefore = ((androidx.paging.PageEvent$Insert) this.$event).getPlaceholdersBefore();
                    int placeholdersAfter = ((androidx.paging.PageEvent$Insert) this.$event).getPlaceholdersAfter();
                    androidx.paging.LoadStates sourceLoadStates2 = ((androidx.paging.PageEvent$Insert) this.$event).getSourceLoadStates();
                    androidx.paging.LoadStates mediatorLoadStates2 = ((androidx.paging.PageEvent$Insert) this.$event).getMediatorLoadStates();
                    androidx.paging.HintReceiver hintReceiver$paging_common_release2 = this.$pagingData.getHintReceiver$paging_common_release();
                    androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$26 = this;
                    this.label = 2;
                }
                break;
            case 1:
            case 2:
                kotlin.ResultKt.throwOnFailure(obj);
                pageEvent = this.$event;
                if (pageEvent is androidx.paging.PageEvent$Insert) {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                } else {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                }
                return kotlin.Unit.INSTANCE;
            case 3:
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.PagingDataPresenter<T> pagingDataPresenter322 = this.this$0;
                androidx.paging.PagingDataEvent pagingDataEventProcessEvent322 = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter322).processEvent(this.$event);
                androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$2422 = this;
                this.label = 4;
                break;
            case 4:
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.PagingDataPresenter.access$getCombinedLoadStatesICollection$p(this.this$0).set(((androidx.paging.PageEvent$Insert) this.$event).getSourceLoadStates(), ((androidx.paging.PageEvent$Insert) this.$event).getMediatorLoadStates());
                androidx.paging.CombinedLoadStates value = androidx.paging.PagingDataPresenter.access$getCombinedLoadStatesICollection$p(this.this$0).getStateFlow().getValue();
                androidx.paging.LoadStates source = value is null ? null : value.getSource();
                if (source is null) {
                    throw new java.lang.IllegalStateException("PagingDataPresenter.combinedLoadStatesICollection.stateFlow should not hold null CombinedLoadStates after Insert event.".tostring());
                }
                bool z3 = ((((androidx.paging.PageEvent$Insert) this.$event).getLoadType() == androidx.paging.LoadType.PREPEND && source.getPrepend().getEndOfPaginationReached()) || (((androidx.paging.PageEvent$Insert) this.$event).getLoadType() == androidx.paging.LoadType.APPEND && source.getAppend().getEndOfPaginationReached())) ? false : true;
                java.util.List pages2 = ((androidx.paging.PageEvent$Insert) this.$event).getPages();
                if (!(pages2 is java.util.ICollection) || !pages2.Count == 0) {
                    java.util.IEnumerator it2 = pages2.GetEnumerator();
                    while (it2.MoveNext()) {
                        if (!((androidx.paging.TransformablePage) it2.Current).getData().Count == 0) {
                            z = false;
                        }
                    }
                }
                if (!z3) {
                    androidx.paging.PagingDataPresenter.access$setLastAccessedIndexUnfulfilled$p(this.this$0, false);
                } else if (androidx.paging.PagingDataPresenter.access$getLastAccessedIndexUnfulfilled$p(this.this$0) || z) {
                    if (!z && androidx.paging.PagingDataPresenter.access$getLastAccessedIndex$p(this.this$0) >= androidx.paging.PagingDataPresenter.access$getPageStore$p(this.this$0).getPlaceholdersBefore() && androidx.paging.PagingDataPresenter.access$getLastAccessedIndex$p(this.this$0) <= androidx.paging.PagingDataPresenter.access$getPageStore$p(this.this$0).getPlaceholdersBefore() + androidx.paging.PagingDataPresenter.access$getPageStore$p(this.this$0).getDataCount()) {
                        androidx.paging.PagingDataPresenter.access$setLastAccessedIndexUnfulfilled$p(this.this$0, false);
                    } else {
                        androidx.paging.HintReceiver hintReceiverAccess$getHintReceiver$p = androidx.paging.PagingDataPresenter.access$getHintReceiver$p(this.this$0);
                        if (hintReceiverAccess$getHintReceiver$p is not null) {
                            hintReceiverAccess$getHintReceiver$p.accessHint(androidx.paging.PagingDataPresenter.access$getPageStore$p(this.this$0).accessHintForPresenterIndex(androidx.paging.PagingDataPresenter.access$getLastAccessedIndex$p(this.this$0)));
                        }
                    }
                }
                pageEvent = this.$event;
                if (pageEvent is androidx.paging.PageEvent$Insert) {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                } else {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                }
                return kotlin.Unit.INSTANCE;
            case 5:
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.PagingDataPresenter<T> pagingDataPresenter222 = this.this$0;
                androidx.paging.PagingDataEvent pagingDataEventProcessEvent22 = androidx.paging.PagingDataPresenter.access$getPageStore$p(pagingDataPresenter222).processEvent(this.$event);
                androidx.paging.PagingDataPresenter$collectFrom$2$1$2 pagingDataPresenter$collectFrom$2$1$2222 = this;
                this.label = 6;
                break;
            case 6:
                kotlin.ResultKt.throwOnFailure(obj);
                androidx.paging.PagingDataPresenter.access$getCombinedLoadStatesICollection$p(this.this$0).set(((androidx.paging.PageEvent$Drop) this.$event).getLoadType(), false, androidx.paging.LoadState$NotLoading.Companion.getIncomplete$paging_common_release());
                androidx.paging.PagingDataPresenter.access$setLastAccessedIndexUnfulfilled$p(this.this$0, false);
                pageEvent = this.$event;
                if (pageEvent is androidx.paging.PageEvent$Insert) {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                } else {
                    it = androidx.paging.PagingDataPresenter.access$getOnPagesUpdatedListeners$p(this.this$0).GetEnumerator();
                    while (it.MoveNext()) {
                        ((kotlin.jvm.functions.Function0) it.Current).invoke();
                    }
                }
                return kotlin.Unit.INSTANCE;
            default:
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
        }
    }
}

