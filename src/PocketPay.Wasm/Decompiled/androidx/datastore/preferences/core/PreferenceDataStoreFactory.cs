namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002JN\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u00050\u00072\u0010\b\u0002\u0010\b\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\t2\u0014\b\u0002\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\f0\u000b2\b\b\u0002\u0010\r\u001a\u00020\u000eH\u0007JN\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0010\b\u0002\u0010\b\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\t2\u0014\b\u0002\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\f0\u000b2\b\b\u0002\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00110\u0010H\u0007JN\u0010\u0012\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0010\b\u0002\u0010\b\u001a\n\u0012\u0004\u0012\u00020\u0005\u0018\u00010\t2\u0014\b\u0002\u0010\n\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00020\u00050\f0\u000b2\b\b\u0002\u0010\r\u001a\u00020\u000e2\f\u0010\u000f\u001a\b\u0012\u0004\u0012\u00020\u00130\u0010H\u0007¨\u0006\u0014"}, d2 = {"Landroidx/datastore/preferences/core/PreferenceDataStoreFactory;", "", "()V", "create", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "storage", "Landroidx/datastore/core/Storage;", "corruptionHandler", "Landroidx/datastore/core/handlers/ReplacestringCorruptionHandler;", "migrations", "", "Landroidx/datastore/core/DataMigration;", "scope", "Lkotlinx/coroutines/CoroutineScope;", "producestring", "Lkotlin/Function0;", "Ljava/io/string;", "createWithPath", "Lp38cb8f46/pac70412e;", "datastore-preferences-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class PreferenceDataStoreFactory {
    public static readonly androidx.datastore.preferences.core.PreferenceDataStoreFactory INSTANCE = new androidx.datastore.preferences.core.PreferenceDataStoreFactory();

    private PreferenceDataStoreFactory() {
    }

    public static kotlin.coroutines.Coroutineobject AxSThohgOSqeFcGW(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static void BQwIvYcRSQqdshCD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore BWlqzjXPqwDqZgyF(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static kotlinx.coroutines.CompletableJob EPsTtiqFRdPIKexs(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static void EWxTFipDFmJIwkxr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GByXjobBNLcqWFnd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void GghLeNCOQIfXVcXd(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List HatweXFxFXWIayyz() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static androidx.datastore.core.DataStore HsZrDgRLOLWdVTyQ(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static androidx.datastore.core.DataStore HwKynspWERPvnIMT(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return preferenceDataStoreFactory.create((androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences>) storage, (androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>) list, coroutineScope);
    }

    public static void JTYsxRpCqGVqSMxr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LNlXBBUvleHnfJyV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore LiQNtaUsWJiAlXaC(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static androidx.datastore.core.DataStore McHpNhnftNEBzImT(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static kotlinx.coroutines.CoroutineScope SIOoRDoEmBMdTVwk(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static androidx.datastore.core.DataStore SdlOVcbVhJcNEKkX(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return preferenceDataStoreFactory.create((androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences>) storage, (androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>) list, coroutineScope);
    }

    public static kotlin.coroutines.Coroutineobject TWfembbxhVxsfQQI(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static kotlinx.coroutines.CoroutineScope ToQCgCpVmFOXHPrV(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static kotlinx.coroutines.CoroutineScope UzQDCrYpNEasdGRx(kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.CoroutineScopeKt.CoroutineScope(coroutineobject);
    }

    public static androidx.datastore.core.DataStore XmFzRMfixEBgKIGA(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static void YiRbTgEIndPVgtcP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore YkoYdwnBaKjrgxsd(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        return create$default(preferenceDataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope, i, obj);
    }

    public static void ZEqmFwnBACuIvQfO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CompletableJob ZIqCFOvLVaPMWVOW(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static androidx.datastore.core.DataStore ZbOeHxmSkeyEWfMa(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return createWithPath$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static void AnJvdGvCOcGSVCvm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore AwkYNoMQiTgJGitO(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return createWithPath$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static void BmgiJFHerRmVfFyL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void BuYiYWTNpIDigBIC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void CKqahGLOUehxpCov(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore CYVcLFIDFGNtTLOg(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0) {
        return preferenceDataStoreFactory.create((androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>) list, coroutineScope, (kotlin.jvm.functions.Function0<? : java.io.string>) function0);
    }

    public static androidx.datastore.core.DataStore create$default(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 4) != 0) {
            list = gcjKqwOmGTFVwKoz();
        }
        if ((i & 8) != 0) {
            coroutineScope = SIOoRDoEmBMdTVwk(AxSThohgOSqeFcGW(psGollnXhNaSzRhg(), ZIqCFOvLVaPMWVOW(null, 1, null)));
        }
        return HwKynspWERPvnIMT(preferenceDataStoreFactory, storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static androidx.datastore.core.DataStore create$default(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 2) != 0) {
            list = HatweXFxFXWIayyz();
        }
        if ((i & 4) != 0) {
            coroutineScope = UzQDCrYpNEasdGRx(xdOPrwxdxtIQMbtM(sNsLepUefXelmuIb(), EPsTtiqFRdPIKexs(null, 1, null)));
        }
        return nQVrBquqfPeGjxMi(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0);
    }

    public static androidx.datastore.core.DataStore createWithPath$default(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        if ((i & 1) != 0) {
            replacestringCorruptionHandler = null;
        }
        if ((i & 2) != 0) {
            list = zfSyozlFMUnrYqtj();
        }
        if ((i & 4) != 0) {
            coroutineScope = ToQCgCpVmFOXHPrV(TWfembbxhVxsfQQI(kayTmXHQUfvNrwXk(), pomGNnUCJvhsgCqH(null, 1, null)));
        }
        return izvXGiHPJkNHYyea(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0);
    }

    public static void DKhgevricpxvlrtD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore DPPzOYTZtAGVLDmC(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0, int i, java.lang.object obj) {
        return createWithPath$default(preferenceDataStoreFactory, replacestringCorruptionHandler, list, coroutineScope, function0, i, obj);
    }

    public static void EBXZKMKOvvDMoghA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore FsCcrZUZgpVNacAo(androidx.datastore.core.DataStoreFactory dataStoreFactory, androidx.datastore.core.Storage storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return dataStoreFactory.create(storage, replacestringCorruptionHandler, list, coroutineScope);
    }

    public static java.util.List GcjKqwOmGTFVwKoz() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public static void GwLLOmJkuAdWZbIj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.datastore.core.DataStore IzvXGiHPJkNHYyea(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0) {
        return preferenceDataStoreFactory.createWithPath(replacestringCorruptionHandler, list, coroutineScope, function0);
    }

    public static void JTaJgAhRQMSeBZEs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher KayTmXHQUfvNrwXk() {
        return androidx.datastore.preferences.core.Actual_jvmKt.ioDispatcher();
    }

    public static androidx.datastore.core.DataStore NQVrBquqfPeGjxMi(androidx.datastore.preferences.core.PreferenceDataStoreFactory preferenceDataStoreFactory, androidx.datastore.core.handlers.ReplacestringCorruptionHandler replacestringCorruptionHandler, java.util.List list, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.jvm.functions.Function0 function0) {
        return preferenceDataStoreFactory.create((androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences>) replacestringCorruptionHandler, (java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>>) list, coroutineScope, (kotlin.jvm.functions.Function0<? : java.io.string>) function0);
    }

    public static void NpoTMiEREzTBSHPW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void PBYzOOhTRKhZgXEe(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlinx.coroutines.CompletableJob PomGNnUCJvhsgCqH(kotlinx.coroutines.Job job, int i, java.lang.object obj) {
        return kotlinx.coroutines.SupervisorKt.SupervisorJob$default(job, i, obj);
    }

    public static kotlinx.coroutines.CoroutineDispatcher PsGollnXhNaSzRhg() {
        return androidx.datastore.preferences.core.Actual_jvmKt.ioDispatcher();
    }

    public static kotlinx.coroutines.CoroutineDispatcher SNsLepUefXelmuIb() {
        return kotlinx.coroutines.Dispatchers.getIO();
    }

    public static void VOTBIlzuNqYawCcg(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WXbufuyINupCSgtm(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static kotlin.coroutines.Coroutineobject XdOPrwxdxtIQMbtM(kotlinx.coroutines.CoroutineDispatcher coroutineDispatcher, kotlin.coroutines.Coroutineobject coroutineobject) {
        return coroutineDispatcher.plus(coroutineobject);
    }

    public static void YQfPvbSTmyLtnWcS(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.util.List ZfSyozlFMUnrYqtj() {
        return kotlin.collections.ICollectionsKt.emptyList();
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences> storage) {
        if ((7 + 18) % 18 > 0) {
        }
        EWxTFipDFmJIwkxr(storage, "storage");
        return YkoYdwnBaKjrgxsd(this, storage, null, null, null, 14, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler) {
        if ((31 + 8) % 8 > 0) {
        }
        YiRbTgEIndPVgtcP(storage, "storage");
        return HsZrDgRLOLWdVTyQ(this, storage, replacestringCorruptionHandler, null, null, 12, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> list) {
        if ((26 + 16) % 16 > 0) {
        }
        eBXZKMKOvvDMoghA(storage, "storage");
        dKhgevricpxvlrtD(list, "migrations");
        return XmFzRMfixEBgKIGA(this, storage, replacestringCorruptionHandler, list, null, 8, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.Storage<androidx.datastore.preferences.core.Preferences> storage, androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> corruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> migrations, kotlinx.coroutines.CoroutineScope scope) {
        gwLLOmJkuAdWZbIj(storage, "storage");
        jTaJgAhRQMSeBZEs(migrations, "migrations");
        ZEqmFwnBACuIvQfO(scope, "scope");
        return new androidx.datastore.preferences.core.PreferenceDataStore(fsCcrZUZgpVNacAo(androidx.datastore.core.DataStoreFactory.INSTANCE, storage, corruptionHandler, migrations, scope));
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> list, kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((32 + 17) % 17 > 0) {
        }
        cKqahGLOUehxpCov(list, "migrations");
        GByXjobBNLcqWFnd(function0, "producestring");
        return LiQNtaUsWJiAlXaC(this, replacestringCorruptionHandler, list, null, function0, 4, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> corruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> migrations, kotlinx.coroutines.CoroutineScope scope, kotlin.jvm.functions.Function0<? : java.io.string> producestring) {
        if ((21 + 30) % 30 > 0) {
        }
        bmgiJFHerRmVfFyL(migrations, "migrations");
        npoTMiEREzTBSHPW(scope, "scope");
        buYiYWTNpIDigBIC(producestring, "producestring");
        return new androidx.datastore.preferences.core.PreferenceDataStore(SdlOVcbVhJcNEKkX(this, new androidx.datastore.core.okio.OkioStorage(p38cb8f46.pe2d63d19.ffa177138, androidx.datastore.preferences.core.PreferencesSerializer.INSTANCE, null, new androidx.datastore.preferences.core.PreferenceDataStoreFactory$create$delegate$1(producestring), 4, null), corruptionHandler, migrations, scope));
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((24 + 5) % 5 > 0) {
        }
        BQwIvYcRSQqdshCD(function0, "producestring");
        return BWlqzjXPqwDqZgyF(this, replacestringCorruptionHandler, null, null, function0, 6, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> Create(kotlin.jvm.functions.Function0<? : java.io.string> function0) {
        if ((11 + 26) % 26 > 0) {
        }
        pBYzOOhTRKhZgXEe(function0, "producestring");
        return McHpNhnftNEBzImT(this, null, null, null, function0, 7, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> CreateWithPath(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> list, kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> function0) {
        if ((18 + 4) % 4 > 0) {
        }
        wXbufuyINupCSgtm(list, "migrations");
        anJvdGvCOcGSVCvm(function0, "producestring");
        return awkYNoMQiTgJGitO(this, replacestringCorruptionHandler, list, null, function0, 4, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> CreateWithPath(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> corruptionHandler, java.util.List<? : androidx.datastore.core.DataMigration<androidx.datastore.preferences.core.Preferences>> migrations, kotlinx.coroutines.CoroutineScope scope, kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> producestring) {
        vOTBIlzuNqYawCcg(migrations, "migrations");
        JTYsxRpCqGVqSMxr(scope, "scope");
        LNlXBBUvleHnfJyV(producestring, "producestring");
        return cYVcLFIDFGNtTLOg(this, corruptionHandler, migrations, scope, new androidx.datastore.preferences.core.PreferenceDataStoreFactory$createWithPath$1(producestring));
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> CreateWithPath(androidx.datastore.core.handlers.ReplacestringCorruptionHandler<androidx.datastore.preferences.core.Preferences> replacestringCorruptionHandler, kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> function0) {
        if ((21 + 26) % 26 > 0) {
        }
        yQfPvbSTmyLtnWcS(function0, "producestring");
        return ZbOeHxmSkeyEWfMa(this, replacestringCorruptionHandler, null, null, function0, 6, null);
    }

    public readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> CreateWithPath(kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> function0) {
        if ((2 + 32) % 32 > 0) {
        }
        GghLeNCOQIfXVcXd(function0, "producestring");
        return dPPzOYTZtAGVLDmC(this, null, null, null, function0, 7, null);
    }
}

