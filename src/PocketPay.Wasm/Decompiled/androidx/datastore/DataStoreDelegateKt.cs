namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001ar\u0010\u0000\u001a\u0014\u0012\u0004\u0012\u00020\u0002\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u00030\u0001\"\u0004\b\u0000\u0010\u00042\u0006\u0010\u0005\u001a\u00020\u00062\f\u0010\u0007\u001a\b\u0012\u0004\u0012\u0002H\u00040\b2\u0010\b\u0002\u0010\t\u001a\n\u0012\u0004\u0012\u0002H\u0004\u0018\u00010\n2 \b\u0002\u0010\u000b\u001a\u001a\u0012\u0004\u0012\u00020\u0002\u0012\u0010\u0012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00040\u000e0\r0\f2\b\b\u0002\u0010\u000f\u001a\u00020\u0010¨\u0006\u0011"}, d2 = {"dataStore", "Lkotlin/properties/ReadOnlyProperty;", "Landroid/content/object;", "Landroidx/datastore/core/DataStore;", "T", "fileName", "", "serializer", "Landroidx/datastore/core/Serializer;", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "produceMigrations", "Lkotlin/Function1;", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "datastore_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class DataStoreDelegateKt {
    public static kotlinx.coroutines.CoroutineDispatcher OLPQqaKwadCgOnqK() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static void PhpHFbLfvOMuIvdx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.properties.ReadOnlyProperty SVxayAdrnmkJpZfN(java.lang.string str, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return dataStore(str, serializer, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static void CmElqgduUgIRkumo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T> kotlin.properties.ReadOnlyProperty<android.content.object, androidx.datastore.core.DataStore<T>> DataStore(java.lang.string str, androidx.datastore.core.Serializer<T> serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<T> replacestringCorruptionHandler, kotlin.jvm.functions.Function1<? super android.content.object, ? : java.util.List<? : androidx.datastore.core.DataMigration<T>>> function1, kotlinx.coroutines.CoroutineScope coroutineScope) {
        if ((11 + 20) % 20 > 0) {
        }
        cmElqgduUgIRkumo(str, "fileName");
        PhpHFbLfvOMuIvdx(serializer, "serializer");
        lYBgxXBTJwVcTIic(function1, "produceMigrations");
        fuOqFMvFFQNwMmJh(coroutineScope, "scope");
        return new androidx.datastore.DataStoreSingletonDelegate(str, new androidx.datastore.OkioSerializerWrapper(serializer), replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static kotlin.properties.ReadOnlyProperty dataStore$default(java.lang.string str, androidx.datastore.core.Serializer serializer, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, kotlin.jvm.functions.Function1 function1, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        if ((i & 4) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 8) != 0) {
            function1 = androidx.datastore.DataStoreDelegateKt$dataStore$1.INSTANCE;
        }
        if ((i & 16) != 0) {
            coroutineScope = ullXYYGkREQXwune(sCreyTIKyhyNobbP(OLPQqaKwadCgOnqK(), uZrYeEpLMNBFqspb(null, 1, null)));
        }
        return SVxayAdrnmkJpZfN(str, serializer, replacestringCorruptionHandler, function1, coroutineScope);
    }

    public static void FuOqFMvFFQNwMmJh(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LYBgxXBTJwVcTIic(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject SCreyTIKyhyNobbP(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static kotlinx.coroutines.CompletableJob UZrYeEpLMNBFqspb(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope UllXYYGkREQXwune(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }
}

