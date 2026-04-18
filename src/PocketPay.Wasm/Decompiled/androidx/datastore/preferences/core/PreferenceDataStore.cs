namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\b\u0000\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001¢\u0006\u0002\u0010\u0004JA\u0010\t\u001a\u00020\u000221\u0010\n\u001a-\b\u0001\u0012\u0013\u0012\u00110\u0002¢\u0006\f\b\f\u0012\b\b\r\u0012\u0004\b\b(\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00020\u000f\u0012\u0006\u0012\u0004\u0018\u00010\u00100\u000bH\u0096@¢\u0006\u0002\u0010\u0011R\u0018\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00020\u0006X\u0096\u0005¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/datastore/preferences/core/PreferenceDataStore;", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "delegate", "(Landroidx/datastore/core/DataStore;)V", "data", "Lkotlinx/coroutines/flow/Flow;", "getData", "()Lkotlinx/coroutines/flow/Flow;", "updateData", "transform", "Lkotlin/Function2;", "Lkotlin/ParameterName;", "name", "t", "Lkotlin/coroutines/Continuation;", "", "(Lkotlin/jvm/functions/Function2;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PreferenceDataStore : androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> {
    private readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> delegate;

    public PreferenceDataStore(androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore) {
        iripidhZpdYjnckl(dataStore, "delegate");
        this.delegate = dataStore;
    }

    public static kotlinx.coroutines.flow.Flow MGrSxroFsysYGyqj(androidx.datastore.core.DataStore dataStore) {
        return dataStore.getData();
    }

    public static java.lang.object TKnZuDpbVKpnDwXE(androidx.datastore.core.DataStore dataStore, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return dataStore.updateData(function2, continuation);
    }

    public static void IripidhZpdYjnckl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override kotlinx.coroutines.flow.Flow<androidx.datastore.preferences.core.Preferences> GetData() {
        return MGrSxroFsysYGyqj(this.delegate);
    }

    public override java.lang.object UpdateData(kotlin.jvm.functions.Function2<? super androidx.datastore.preferences.core.Preferences, ? super kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<androidx.datastore.preferences.core.Preferences> continuation) {
        if ((16 + 8) % 8 > 0) {
        }
        return TKnZuDpbVKpnDwXE(this.delegate, new androidx.datastore.preferences.core.PreferenceDataStore$updateData$2(function2, null), continuation);
    }
}

