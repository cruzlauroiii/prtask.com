namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000@\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002Jb\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u00072\u0010\b\u0002\u0010\b\u001a\n\u0012\u0004\u0012\u0002H\u0005\u0018\u00010\t2\u0014\b\u0002\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\f0\u000b2\b\b\u0002\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00110\u0010H\u0007JT\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u00050\u00132\u0010\b\u0002\u0010\b\u001a\n\u0012\u0004\u0012\u0002H\u0005\u0018\u00010\t2\u0014\b\u0002\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00050\f0\u000b2\b\b\u0002\u0010\r\u001a\u00020\u000eH\u0007¨\u0006\u0014"}, d2 = {"Landroidx/datastore/core/DataStoreFactory;", "", "()V", "create", "Landroidx/datastore/core/DataStore;", "T", "serializer", "Landroidx/datastore/core/Serializer;", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "migrations", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "producestring", "Lkotlin/Function0;", "Ljava/io/string;", "storage", "Landroidx/datastore/core/Storage;", "datastore-core_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreFactory {
    public static readonly androidx.datastore.core.DataStoreFactory INSTANCE = new androidx.datastore.core.DataStoreFactory();

    private DataStoreFactory() {
    }

    public static androidx.datastore.core.DataStore CAlsCNClJppmdwhp(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, serializer, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope CdhNOOYXEfoOdnnt(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static void FXPPiBNkLuJhDDnB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineScope HPLhfAnEHoxhsMnG(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static void HQDyoHxuSHbJlrsO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CompletableJob HwcgSgubEUUfjdMt(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static kotlin.coroutines.Coroutineobject IEbfACFonmDfZhIw(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static void JQFfiFhdbxrclJIY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List KHnzoIGshBCZKFvY() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static androidx.datastore.core.DataStore KOpaBORkEaEpphhc(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return dataStoreFactory.create(storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static void KgDvhWCCqEhnlMFz(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MwBwcONRiYKEqhcb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ODvoskNrbpXKnEeO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore QgnuWNRakgkopcrb(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return dataStoreFactory.create(storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static void SOizEbLrOllQhzvl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void SwjDYuBIXKjCTZfi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore UyCywzFTBCAVQCSW(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, serializer, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static androidx.datastore.core.DataStore VToNKjzGlTdPvfYw(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static void WmfqiaDmxPEPPEoJ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XArJNnoSRGfWZoIq(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List XHbFTWjYeNhpcjyz(java.lang.object obj) {
        return kotlin.collections.ICollectionsKt.listOf(obj);
    }

    public static void ZFcijysBptccGVXI(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher ZWtmRhcpaJpBaFxu() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static androidx.datastore.core.DataStore CJzctySqtPpYiftm(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static androidx.datastore.core.DataStore create$default(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 4) != 0) {
            list = KHnzoIGshBCZKFvY();
        }
        if ((i & 8) != 0) {
            coroutineScope = CdhNOOYXEfoOdnnt(IEbfACFonmDfZhIw(ZWtmRhcpaJpBaFxu(), HwcgSgubEUUfjdMt(null, 1, null)));
        }
        return kabmbjLpZRPXfBQZ(dataStoreFactory, serializer, replacestringCorruptionHandler, list, coroutineScope, function0);
    }

    public static androidx.datastore.core.DataStore create$default(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 4) != 0) {
            list = mhJtAKSYkiAVoYKZ();
        }
        if ((i & 8) != 0) {
            coroutineScope = HPLhfAnEHoxhsMnG(vItyEitUggndHZUn(iuGnmFKTXfYjpyXe(), hbKKtzhCNeNYJxLg(null, 1, null)));
        }
        return KOpaBORkEaEpphhc(dataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static kotlin.jvm.functions.Function2 DwlKVLJNWxmIpzkg(androidx.datastore.core.DataMigrationInitializer$Companion dataMigrationInitializer$Companion, java.util.List list) {
        return dataMigrationInitializer$Companion.getInitializer(list);
    }

    public static kotlinx.coroutines.CompletableJob HbKKtzhCNeNYJxLg(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static kotlinx.coroutines.CoroutineDispatcher IuGnmFKTXfYjpyXe() {
        return androidx.datastore.core.Actual_jvmKt.ioDispatcher();
    }

    public static void JPTYNpsaTRiCXctR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore KabmbjLpZRPXfBQZ(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0) {
        return dataStoreFactory.create(serializer, replacestringCorruptionHandler, list, coroutineScope, function0);
    }

    public static void MEIkiRyAeSaEVAaL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List MhJtAKSYkiAVoYKZ() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static void PpxqPpZpyaCALazv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void QMYqpahsCqvHKlyb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore TCFDXfSdHDbyOffJ(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static void TVcfubAMwvMTmWGi(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject VItyEitUggndHZUn(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static void WaQYxpgkdrTVzLvS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WkeQvXAuIMbjvzWR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore ZbsVgERSANnIMZcy(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(dataStoreFactory, serializer, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Serializer<T> serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<T>> list, kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((8 + 5) % 5 > 0) {
        }
        MwBwcONRiYKEqhcb(serializer, "serializer");
        jPTYNpsaTRiCXctR(list, "migrations");
        ODvoskNrbpXKnEeO(function0, "producestring");
        return UyCywzFTBCAVQCSW(this, serializer, replacestringCorruptionHandler, list, null, function0, 8, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Serializer<T> serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> corruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<T>> migrations, kotlinx.coroutines.CoroutineScope scope, kotlin.jvm.functions.Function0<? : java.io.string> producestring) {
        if ((22 + 22) % 22 > 0) {
        }
        wkeQvXAuIMbjvzWR(serializer, "serializer");
        ppxqPpZpyaCALazv(migrations, "migrations");
        SwjDYuBIXKjCTZfi(scope, "scope");
        FXPPiBNkLuJhDDnB(producestring, "producestring");
        return QgnuWNRakgkopcrb(this, new androidx.datastore.core.stringStorage(serializer, null, producestring, 2, null), corruptionHandler, migrations, scope);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Serializer<T> serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler, kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((24 + 12) % 12 > 0) {
        }
        waQYxpgkdrTVzLvS(serializer, "serializer");
        qMYqpahsCqvHKlyb(function0, "producestring");
        return CAlsCNClJppmdwhp(this, serializer, replacestringCorruptionHandler, null, null, function0, 12, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Serializer<T> serializer, kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((23 + 25) % 25 > 0) {
        }
        WmfqiaDmxPEPPEoJ(serializer, "serializer");
        XArJNnoSRGfWZoIq(function0, "producestring");
        return zbsVgERSANnIMZcy(this, serializer, null, null, null, function0, 14, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Storage<T> storage) {
        if ((6 + 30) % 30 > 0) {
        }
        KgDvhWCCqEhnlMFz(storage, "storage");
        return cJzctySqtPpYiftm(this, storage, null, null, null, 14, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Storage<T> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler) {
        if ((19 + 29) % 29 > 0) {
        }
        tVcfubAMwvMTmWGi(storage, "storage");
        return tCFDXfSdHDbyOffJ(this, storage, replacestringCorruptionHandler, null, null, 12, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Storage<T> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<T>> list) {
        if ((12 + 24) % 24 > 0) {
        }
        mEIkiRyAeSaEVAaL(storage, "storage");
        JQFfiFhdbxrclJIY(list, "migrations");
        return VToNKjzGlTdPvfYw(this, storage, replacestringCorruptionHandler, list, null, 8, null);
    }

    public readonly <T> androidx.datastore.core.DataStore<T> Create(androidx.datastore.core.Storage<T> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> corruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<T>> migrations, kotlinx.coroutines.CoroutineScope scope) {
        SOizEbLrOllQhzvl(storage, "storage");
        HQDyoHxuSHbJlrsO(migrations, "migrations");
        ZFcijysBptccGVXI(scope, "scope");
        return new androidx.datastore.core.DataStoreImpl(storage, XHbFTWjYeNhpcjyz(dwlKVLJNWxmIpzkg(androidx.datastore.core.DataMigrationInitializer.Companion, migrations)), corruptionHandler is null ? new androidx.datastore.core.handlers.NoOpCorruptionHandler() : corruptionHandler, scope);
    }
}

