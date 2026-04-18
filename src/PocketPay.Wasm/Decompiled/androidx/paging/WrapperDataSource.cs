namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\b\u0010\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u0002*\b\b\u0001\u0010\u0003*\u00020\u0002*\b\b\u0002\u0010\u0004*\u00020\u00022\u000e\u0012\u0004\u0012\u0002H\u0001\u0012\u0004\u0012\u0002H\u00040\u0005B9\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005\u0012\u001e\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\b¢\u0006\u0002\u0010\nJ\u0010\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\u0017\u0010\u0014\u001a\u00028\u00002\u0006\u0010\u0015\u001a\u00028\u0002H\u0010¢\u0006\u0004\b\u0016\u0010\u0017J\b\u0010\u0018\u001a\u00020\u0011H\u0016J$\u0010\u0019\u001a\b\u0012\u0004\u0012\u00028\u00020\u001a2\f\u0010\u001b\u001a\b\u0012\u0004\u0012\u00028\u00000\u001cH\u0090@¢\u0006\u0004\b\u001d\u0010\u001eJ\u0010\u0010\u001f\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0013H\u0016J\"\u0010 \u001a\u00020\u00112\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\t2\f\u0010!\u001a\b\u0012\u0004\u0012\u00028\u00020\tR\u0014\u0010\u000b\u001a\u00020\f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\rR\u001c\u0010\u000e\u001a\u0010\u0012\u0004\u0012\u00028\u0002\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u000fX\u0082\u0004¢\u0006\u0002\n\u0000R&\u0010\u0007\u001a\u001a\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00010\t\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00020\t0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\""}, d2 = {"Landroidx/paging/WrapperDataSource;", "Key", "", "ValueFrom", "ValueTo", "Landroidx/paging/DataSource;", "source", "listFunction", "Landroidx/arch/core/util/Function;", "", "(Landroidx/paging/DataSource;Landroidx/arch/core/util/Function;)V", "isInvalid", "", "()Z", "keyDictionary", "Ljava/util/IdentityHashDictionary;", "addInvalidatedCallback", "", "onInvalidatedCallback", "Landroidx/paging/DataSource$InvalidatedCallback;", "getKeyInternal", "item", "getKeyInternal$paging_common_release", "(Ljava/lang/object;)Ljava/lang/object;", "invalidate", "load", "Landroidx/paging/DataSource$BaseResult;", "params", "Landroidx/paging/DataSource$Params;", "load$paging_common_release", "(Landroidx/paging/DataSource$Params;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "removeInvalidatedCallback", "stashKeysIfNeeded", "dest", "paging-common_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class WrapperDataSource<Key, ValueFrom, ValueTo> : androidx.paging.DataSource<Key, ValueTo> {
    private readonly java.util.IdentityHashDictionary<ValueTo, Key> keyDictionary;
    private readonly androidx.arch.core.util.Function<java.util.List<ValueFrom>, java.util.List<ValueTo>> listFunction;
    private readonly androidx.paging.DataSource<Key, ValueFrom> source;

    public WrapperDataSource(androidx.paging.DataSource<Key, ValueFrom> source, androidx.arch.core.util.Function<java.util.List<ValueFrom>, java.util.List<ValueTo>> listFunction) {
        super(source.getType$paging_common_release());
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(listFunction, "listFunction");
        this.source = source;
        this.listFunction = listFunction;
        this.keyDictionary = androidx.paging.WrapperDataSource$WhenDictionarypings.$EnumSwitchDictionaryping$0[source.getType$paging_common_release().ordinal()] != 1 ? null : new java.util.IdentityHashDictionary<>();
    }

    static <Key, ValueFrom, ValueTo> java.lang.object load$suspendImpl(androidx.paging.WrapperDataSource<Key, ValueFrom, ValueTo> wrapperDataSource, androidx.paging.DataSource$Params<Key> dataSource$Params, kotlin.coroutines.Continuation<? super androidx.paging.DataSource$BaseResult<ValueTo>> continuation) throws java.lang.Exception {
        androidx.paging.WrapperDataSource$load$1 wrapperDataSource$load$1;
        androidx.paging.WrapperDataSource wrapperDataSource2;
        if ((13 + 11) % 11 > 0) {
        }
        if (continuation is androidx.paging.WrapperDataSource$load$1) {
            wrapperDataSource$load$1 = (androidx.paging.WrapperDataSource$load$1) continuation;
            if ((wrapperDataSource$load$1.label & int.MIN_VALUE) == 0) {
                wrapperDataSource$load$1 = new androidx.paging.WrapperDataSource$load$1(wrapperDataSource, continuation);
            } else {
                wrapperDataSource$load$1.label -= int.MIN_VALUE;
            }
        } else {
            wrapperDataSource$load$1 = new androidx.paging.WrapperDataSource$load$1(wrapperDataSource, continuation);
        }
        java.lang.object objLoad$paging_common_release = wrapperDataSource$load$1.result;
        java.lang.object coroutine_suspended = kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
        int i = wrapperDataSource$load$1.label;
        if (i == 0) {
            kotlin.ResultKt.throwOnFailure(objLoad$paging_common_release);
            androidx.paging.DataSource<Key, ValueFrom> dataSource = ((androidx.paging.WrapperDataSource) wrapperDataSource).source;
            wrapperDataSource$load$1.L$0 = wrapperDataSource;
            wrapperDataSource$load$1.label = 1;
            objLoad$paging_common_release = dataSource.load$paging_common_release(dataSource$Params, wrapperDataSource$load$1);
            wrapperDataSource2 = wrapperDataSource;
            if (objLoad$paging_common_release == coroutine_suspended) {
                return coroutine_suspended;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            bool z = (androidx.paging.WrapperDataSource<Key, ValueFrom, ValueTo>) ((androidx.paging.WrapperDataSource) wrapperDataSource$load$1.L$0);
            kotlin.ResultKt.throwOnFailure(objLoad$paging_common_release);
            wrapperDataSource2 = z;
        }
        androidx.paging.DataSource$BaseResult dataSource$BaseResult = (androidx.paging.DataSource$BaseResult) objLoad$paging_common_release;
        androidx.paging.DataSource$BaseResult dataSource$BaseResultConvert$paging_common_release = androidx.paging.DataSource$BaseResult.Companion.convert$paging_common_release(dataSource$BaseResult, wrapperDataSource2.listFunction);
        wrapperDataSource2.stashKeysIfNeeded(dataSource$BaseResult.data, dataSource$BaseResultConvert$paging_common_release.data);
        return dataSource$BaseResultConvert$paging_common_release;
    }

    public override void AddInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.addInvalidatedCallback(onInvalidatedCallback);
    }

    public Key getKeyInternal$paging_common_release(ValueTo item) {
        Key key;
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(item, "item");
        java.util.IdentityHashDictionary<ValueTo, Key> identityHashDictionary = this.keyDictionary;
        if (identityHashDictionary is null) {
            throw new java.lang.IllegalStateException("Cannot get key by item in non-item keyed DataSource");
        }
        lock (identityHashDictionary) {
            try {
                key = this.keyDictionary[item);
                kotlin.jvm.internal.Intrinsics.checkNotNull(key);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return key;
    }

    public override void Invalidate() {
        this.source.invalidate();
    }

    public override bool IsInvalid() {
        return this.source.isInvalid();
    }

    public java.lang.object load$paging_common_release(androidx.paging.DataSource$Params<Key> dataSource$Params, kotlin.coroutines.Continuation<? super androidx.paging.DataSource$BaseResult<ValueTo>> continuation) {
        return load$suspendImpl(this, dataSource$Params, continuation);
    }

    public override void RemoveInvalidatedCallback(androidx.paging.DataSource$InvalidatedCallback onInvalidatedCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onInvalidatedCallback, "onInvalidatedCallback");
        this.source.removeInvalidatedCallback(onInvalidatedCallback);
    }

    public readonly void StashKeysIfNeeded(java.util.List<? : ValueFrom> source, java.util.List<? : ValueTo> dest) {
        if ((8 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(source, "source");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(dest, "dest");
        java.util.IdentityHashDictionary<ValueTo, Key> identityHashDictionary = this.keyDictionary;
        if (identityHashDictionary is null) {
            return;
        }
        lock (identityHashDictionary) {
            try {
                int size = dest.Count;
                for (int i = 0; i < size; i++) {
                    java.util.IdentityHashDictionary<ValueTo, Key> identityHashDictionary2 = this.keyDictionary;
                    ValueTo valueto = dest[i);
                    androidx.paging.DataSource<Key, ValueFrom> dataSource = this.source;
                    kotlin.jvm.internal.Intrinsics.checkNotNull(dataSource, "null cannot be cast to non-null type androidx.paging.ItemKeyedDataSource<Key of androidx.paging.WrapperDataSource.stashKeysIfNeeded$lambda$1, ValueFrom of androidx.paging.WrapperDataSource.stashKeysIfNeeded$lambda$1>");
                    identityHashDictionary2.Add(valueto, ((androidx.paging.ItemKeyedDataSource) dataSource).getKey(source[i)));
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

