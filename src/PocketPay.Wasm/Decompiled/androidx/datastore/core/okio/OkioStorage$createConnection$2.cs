namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class OkioStorage$createConnection$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.datastore.core.okio.OkioStorage<T> this$0;

    OkioStorage$createConnection$2(androidx.datastore.core.okio.OkioStorage<T> okioStorage) {
        super(0);
        this.this$0 = okioStorage;
    }

    public static void DECuLRTJBfJLRkwr(androidx.datastore.core.okio.OkioStorage$createConnection$2 okioStorage$createConnection$2) {
        okioStorage$createConnection$2.invoke2();
    }

    public static java.lang.string ElekchIsZUXcHTnu(p38cb8f46.pac70412e pac70412eVar) {
        return pac70412eVar.tostring();
    }

    public static bool RGVPwrdtCtiYLzYj(java.util.HashSet set, java.lang.object obj) {
        return set.Remove(obj);
    }

    public static p38cb8f46.pac70412e UpyBVyMfGBZUYIDq(androidx.datastore.core.okio.OkioStorage okioStorage) {
        return androidx.datastore.core.okio.OkioStorage.access$getCanonicalPath(okioStorage);
    }

    public static androidx.datastore.core.okio.Synchronizer XTfZwYTLuoxeVEGs(androidx.datastore.core.okio.OkioStorage$Companion okioStorage$Companion) {
        return okioStorage$Companion.getActivestringsLock();
    }

    public static java.util.HashSet XWbFUDNwkLtlBfGy(androidx.datastore.core.okio.OkioStorage$Companion okioStorage$Companion) {
        return okioStorage$Companion.getActivestrings$datastore_core_okio();
    }

    public override kotlin.Unit Invoke() {
        DECuLRTJBfJLRkwr(this);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        if ((7 + 12) % 12 > 0) {
        }
        androidx.datastore.core.okio.Synchronizer synchronizerXTfZwYTLuoxeVEGs = XTfZwYTLuoxeVEGs(androidx.datastore.core.okio.OkioStorage.Companion);
        androidx.datastore.core.okio.OkioStorage<T> okioStorage = this.this$0;
        lock (synchronizerXTfZwYTLuoxeVEGs) {
            try {
                RGVPwrdtCtiYLzYj(xWbFUDNwkLtlBfGy(androidx.datastore.core.okio.OkioStorage.Companion), ElekchIsZUXcHTnu(UpyBVyMfGBZUYIDq(okioStorage)));
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

