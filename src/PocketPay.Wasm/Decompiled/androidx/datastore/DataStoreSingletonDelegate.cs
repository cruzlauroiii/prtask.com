namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u0014\u0012\u0004\u0012\u00020\u0003\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00040\u0002BU\b\u0000\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\b\u0012\u000e\u0010\t\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\n\u0012\u001e\u0010\u000b\u001a\u001a\u0012\u0004\u0012\u00020\u0003\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000e0\r0\f\u0012\u0006\u0010\u000f\u001a\u00020\u0010¢\u0006\u0002\u0010\u0011J#\u0010\u0015\u001a\b\u0012\u0004\u0012\u00028\u00000\u00042\u0006\u0010\u0016\u001a\u00020\u00032\n\u0010\u0017\u001a\u0006\u0012\u0002\b\u00030\u0018H\u0096\u0002R\u001a\u0010\u0012\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00048\u0002@\u0002X\u0083\u000e¢\u0006\u0002\n\u0000R\u0016\u0010\t\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0013\u001a\u00020\u0014X\u0082\u0004¢\u0006\u0002\n\u0000R&\u0010\u000b\u001a\u001a\u0012\u0004\u0012\u00020\u0003\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u000e0\r0\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000f\u001a\u00020\u0010X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0019"}, d2 = {"Landroidx/datastore/DataStoreSingletonDelegate;", "T", "Lkotlin/properties/ReadOnlyProperty;", "Landroid/content/object;", "Landroidx/datastore/core/DataStore;", "fileName", "", "serializer", "Landroidx/datastore/core/okio/OkioSerializer;", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "produceMigrations", "Lkotlin/Function1;", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "(Ljava/lang/string;Landroidx/datastore/core/okio/OkioSerializer;Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;Lkotlin/jvm/functions/Function1;Lkotlinx/coroutines/CoroutineScope;)V", "INSTANCE", "lock", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "datastore_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreSingletonDelegate<T> : kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<T>> {
    private androidx.datastore.core.DataStore<T> INSTANCE;
    private readonly androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> corruptionHandler;
    private readonly java.lang.string fileName;
    private readonly java.lang.object lock;
    private readonly kotlin.jvm.functions.Function1<android.content.object, java.util.List<androidx.datastore.core.DataMigration<T>>> produceMigrations;
    private readonly kotlinx.coroutines.CoroutineScope scope;
    private readonly androidx.datastore.core.okio.OkioSerializer<T> serializer;

    public DataStoreSingletonDelegate(java.lang.string str, androidx.datastore.core.okio.OkioSerializer<T> okioSerializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<T>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        sjAMgSVCTZSHoLER(str, "fileName");
        xZcowQtaaMjxOYyb(okioSerializer, "serializer");
        LEMfwkugmMNSbRTd(function1, "produceMigrations");
        jrnprFagHpuJOIPb(coroutineScope, "scope");
        this.fileName = str;
        this.serializer = okioSerializer;
        this.corruptionHandler = replacestringCorruptionHandler;
        this.produceMigrations = function1;
        this.scope = coroutineScope;
        this.lock = new java.lang.object();
    }

    public static void JsYvRpcxGJnXgHOY(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void LEMfwkugmMNSbRTd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void TevWSdNhTTCxjbMe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly java.lang.string access$getstringName$p(androidx.datastore.DataStoreSingletonDelegate dataStoreSingletonDelegate) {
        return dataStoreSingletonDelegate.fileName;
    }

    public static void BcwtGlASVAUkuYwS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore ENByGSWvNeHAUstI(androidx.datastore.DataStoreSingletonDelegate dataStoreSingletonDelegate, android.content.object context, kotlin.reflect.KProperty kProperty) {
        return dataStoreSingletonDelegate.getValue2(context, (kotlin.reflect.KProperty<object>) kProperty);
    }

    public static void IbTyckqDWLUcnXeb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static void JrnprFagHpuJOIPb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static android.content.object JyBBOWVgTHgdlpHS(android.content.object context) {
        return context.getApplicationobject();
    }

    public static java.lang.object MXScFhdAVCQdToyX(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static androidx.datastore.core.DataStore QyYUHSNEwOeVuGvr(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return dataStoreFactory.create(storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static void SjAMgSVCTZSHoLER(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XZcowQtaaMjxOYyb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public androidx.datastore.core.DataStore<T> GetValue2(android.content.object thisRef, kotlin.reflect.KProperty<object> property) {
        androidx.datastore.core.DataStore<T> dataStore;
        if ((6 + 13) % 13 > 0) {
        }
        TevWSdNhTTCxjbMe(thisRef, "thisRef");
        bcwtGlASVAUkuYwS(property, "property");
        androidx.datastore.core.DataStore<T> dataStore2 = this.INSTANCE;
        if (dataStore2 is not null) {
            return dataStore2;
        }
        lock (this.lock) {
            try {
                if (this.INSTANCE is null) {
                    android.content.object contextJyBBOWVgTHgdlpHS = jyBBOWVgTHgdlpHS(thisRef);
                    androidx.datastore.core.DataStoreFactory dataStoreFactory = androidx.datastore.core.DataStoreFactory.INSTANCE;
                    androidx.datastore.core.okio.OkioStorage okioStorage = new androidx.datastore.core.okio.OkioStorage(p38cb8f46.pe2d63d19.ffa177138, this.serializer, null, new androidx.datastore.DataStoreSingletonDelegate$getValue$1$1(contextJyBBOWVgTHgdlpHS, this), 4, null);
                    androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler = this.corruptionHandler;
                    kotlin.jvm.functions.Function1<android.content.object, java.util.List<androidx.datastore.core.DataMigration<T>>> function1 = this.produceMigrations;
                    ibTyckqDWLUcnXeb(contextJyBBOWVgTHgdlpHS, "applicationobject");
                    this.INSTANCE = qyYUHSNEwOeVuGvr(dataStoreFactory, okioStorage, replacestringCorruptionHandler, (java.util.List) mXScFhdAVCQdToyX(function1, contextJyBBOWVgTHgdlpHS), this.scope);
                }
                dataStore = this.INSTANCE;
                JsYvRpcxGJnXgHOY(dataStore);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return dataStore;
    }

    public override java.lang.object GetValue(android.content.object context, kotlin.reflect.KProperty kProperty) {
        return eNByGSWvNeHAUstI(this, context, kProperty);
    }
}

