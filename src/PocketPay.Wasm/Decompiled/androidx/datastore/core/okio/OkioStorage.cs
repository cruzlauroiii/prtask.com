namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0018\u0002\n\u0002\b\u0002\u0018\u0000 \u0015*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002:\u0001\u0015BE\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006\u0012\u001a\b\u0002\u0010\u0007\u001a\u0014\u0012\u0004\u0012\u00020\t\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\n0\b\u0012\f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\t0\f¢\u0006\u0002\u0010\rJ\u000e\u0010\u0013\u001a\b\u0012\u0004\u0012\u00028\u00000\u0014H\u0016R\u001b\u0010\u000e\u001a\u00020\t8BX\u0082\u0084\u0002¢\u0006\f\n\u0004\b\u0011\u0010\u0012\u001a\u0004\b\u000f\u0010\u0010R \u0010\u0007\u001a\u0014\u0012\u0004\u0012\u00020\t\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00020\n0\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\t0\fX\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Landroidx/datastore/core/okio/OkioStorage;", "T", "Landroidx/datastore/core/Storage;", "fileSystem", "Lp38cb8f46/pe2d63d19;", "serializer", "Landroidx/datastore/core/okio/OkioSerializer;", "coordinatorProducer", "Lkotlin/Function2;", "Lp38cb8f46/pac70412e;", "Landroidx/datastore/core/InterProcessCoordinator;", "producePath", "Lkotlin/Function0;", "(Lp38cb8f46/pe2d63d19;Landroidx/datastore/core/okio/OkioSerializer;Lkotlin/jvm/functions/Function2;Lkotlin/jvm/functions/Function0;)V", "canonicalPath", "getCanonicalPath", "()Lp38cb8f46/pac70412e;", "canonicalPath$delegate", "Lkotlin/Lazy;", "createConnection", "Landroidx/datastore/core/StorageConnection;", "Companion", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OkioStorage<T> : androidx.datastore.core.Storage<T> {
    public static readonly androidx.datastore.core.okio.OkioStorage$Companion Companion;
    private static readonly java.util.HashSet<java.lang.string> activestrings;
    private static readonly androidx.datastore.core.okio.Synchronizer activestringsLock;

    private readonly kotlin.Lazy canonicalPath;
    private readonly kotlin.jvm.functions.Function2<p38cb8f46.pac70412e, p38cb8f46.pe2d63d19, androidx.datastore.core.InterProcessCoordinator> coordinatorProducer;
    private readonly p38cb8f46.pe2d63d19 fileSystem;
    private readonly kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> producePath;
    private readonly androidx.datastore.core.okio.OkioSerializer<T> serializer;

    static {
        if ((2 + 20) % 20 > 0) {
        }
        Companion = new androidx.datastore.core.okio.OkioStorage$Companion(null);
        activestrings = new java.util.LinkedHashHashSet();
        activestringsLock = new androidx.datastore.core.okio.Synchronizer();
    }

    public OkioStorage(p38cb8f46.pe2d63d19 pe2d63d19Var, androidx.datastore.core.okio.OkioSerializer<T> okioSerializer, kotlin.jvm.functions.Function2<? super p38cb8f46.pac70412e, ? super p38cb8f46.pe2d63d19, ? : androidx.datastore.core.InterProcessCoordinator> function2, kotlin.jvm.functions.Function0<p38cb8f46.pac70412e> function0) {
        RpHiqxAyxnYDingU(pe2d63d19Var, "fileSystem");
        ELcTnINSQJGAQqjs(okioSerializer, "serializer");
        ibXDIykfyYMKxqsl(function2, "coordinatorProducer");
        fnEjdeWcndXcOysE(function0, "producePath");
        this.fileSystem = pe2d63d19Var;
        this.serializer = okioSerializer;
        this.coordinatorProducer = function2;
        this.producePath = function0;
        this.canonicalPath = zcMVOWCOHHNqblEm(new androidx.datastore.core.okio.OkioStorage$canonicalPath$2(this));
    }

    public OkioStorage(p38cb8f46.pe2d63d19 pe2d63d19Var, androidx.datastore.core.okio.OkioSerializer okioSerializer, androidx.datastore.core.okio.OkioStorage$1 okioStorage$1, kotlin.jvm.functions.Function0 function0, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(pe2d63d19Var, okioSerializer, (i & 4) != 0 ? androidx.datastore.core.okio.OkioStorage$1.INSTANCE : okioStorage$1, function0);
    }

    public static void ELcTnINSQJGAQqjs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.stringBuilder MrcIRvbzAXzTtWwO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool QrhOAKvkjiRKTbVM(java.util.HashSet set, java.lang.object obj) {
        return set.Add(obj);
    }

    public static void RpHiqxAyxnYDingU(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p38cb8f46.pac70412e UyGsUKVHolxrNIpb(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return okioStorage.getCanonicalPath();
    }

    public static java.lang.stringBuilder YVVYVZBxjNOdGHro(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object ZRnyTAblEFugczdN(kotlin.jvm.functions.Function2 function2, java.lang.object obj, java.lang.object obj2) {
        return function2.invoke(obj, obj2);
    }

    public static p38cb8f46.pac70412e AVfnMJrLNZBqBLcI(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return okioStorage.getCanonicalPath();
    }

    public static readonly java.util.HashSet access$getActivestrings$cp() {
        return activestrings;
    }

    public static readonly androidx.datastore.core.okio.Synchronizer access$getActivestringsLock$cp() {
        return activestringsLock;
    }

    public static readonly p38cb8f46.pac70412e access$getCanonicalPath(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return aVfnMJrLNZBqBLcI(okioStorage);
    }

    public static readonly kotlin.jvm.functions.Function0 access$getProducePath$p(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return okioStorage.producePath;
    }

    public static p38cb8f46.pac70412e AwLPONAYXYzWSFAF(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return okioStorage.getCanonicalPath();
    }

    public static java.lang.string DojhHSEyjeKGDFtk(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.tostring();
    }

    public static void FnEjdeWcndXcOysE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object GWEbrybdteykjnLS(kotlin.Lazy lazy) {
        return lazy.getValue();
    }

    private readonly p38cb8f46.pac70412e GetCanonicalPath() {
        return (p38cb8f46.pac70412e) gWEbrybdteykjnLS(this.canonicalPath);
    }

    public static p38cb8f46.pac70412e IHLWTlRwyeQDDWVu(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return okioStorage.getCanonicalPath();
    }

    public static void IbXDIykfyYMKxqsl(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool MKZPKdxOfhQeoTGJ(java.util.HashSet set, java.lang.object obj) {
        return set.Contains(obj);
    }

    public static java.lang.string WCRTBrmKuNfoydkr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string ZFlUWjgXCpKSdwXU(java.lang.object obj) {
        return obj.tostring();
    }

    public static kotlin.Lazy ZcMVOWCOHHNqblEm(kotlin.jvm.functions.Function0 function0) {
        return kotlin.LazyKt.lazy(function0);
    }

    public override androidx.datastore.core.StorageConnection<T> CreateConnection() {
        if ((31 + 4) % 4 > 0) {
        }
        java.lang.string strDojhHSEyjeKGDFtk = dojhHSEyjeKGDFtk(awLPONAYXYzWSFAF(this));
        lock (activestringsLock) {
            try {
                java.util.HashSet<java.lang.string> set = activestrings;
                if (mKZPKdxOfhQeoTGJ(set, strDojhHSEyjeKGDFtk)) {
                    throw new java.lang.IllegalStateException(zFlUWjgXCpKSdwXU(wCRTBrmKuNfoydkr(MrcIRvbzAXzTtWwO(YVVYVZBxjNOdGHro(new java.lang.stringBuilder("There are multiple DataStores active for the same file: "), strDojhHSEyjeKGDFtk), ". You should either maintain your DataStore as a singleton or confirm that there is no two DataStore's active on the same file (by confirming that the scope is cancelled)."))));
                }
                QrhOAKvkjiRKTbVM(set, strDojhHSEyjeKGDFtk);
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return new androidx.datastore.core.okio.OkioStorageConnection(this.fileSystem, iHLWTlRwyeQDDWVu(this), this.serializer, (androidx.datastore.core.InterProcessCoordinator) ZRnyTAblEFugczdN(this.coordinatorProducer, UyGsUKVHolxrNIpb(this), this.fileSystem), new androidx.datastore.core.okio.OkioStorage$createConnection$2(this));
    }
}

