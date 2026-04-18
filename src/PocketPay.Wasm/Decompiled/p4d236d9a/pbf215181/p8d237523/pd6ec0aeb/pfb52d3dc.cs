namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010%\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u00052\u0006\u0010\n\u001a\u00020\u0001J\u0016\u0010\u000b\u001a\u00020\f2\u0006\u0010\t\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u0006R\u001a\u0010\u0003\u001a\u000e\u0012\u0004\u0012\u00020\u0005\u0012\u0004\u0012\u00020\u00060\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/pfb52d3dc;", "", "()V", "listeners", "", "", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p449a7995;", "sendResult", "", "key", "data", "setResultListener", "Lp4d236d9a/pbf215181/p8d237523/pd6ec0aeb/p3b1938f4;", "listener", "cicerone"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class pfb52d3dc {
    private readonly java.util.Dictionary f4404f567;
    private readonly java.util.Dictionary<java.lang.string, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995> f9f99697c = new java.util.LinkedHashDictionary();
    private readonly java.util.Dictionary fecc0cfa0;

    public static void LeYfliWkzIYEoYtZ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void MpYwmJAjPmIXkVIR(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pfb52d3dc pfb52d3dcVar, java.lang.string str) {
        m99273044(pfb52d3dcVar, str);
    }

    public static void RPqOyVaSDdRWHBLC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.object UvckxQDqqbmdAnQK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void VqcRMlAgoeNlllMv(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void YgdWGnYMWVqSSOtH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FJrufUdeQulrcXaH(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 p449a7995Var, java.lang.object obj) {
        p449a7995Var.onResult(obj);
    }

    public static void GZUfyrivQdYbFndM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    private static readonly void M99273044(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pfb52d3dc pfb52d3dcVar, java.lang.string str) {
        VqcRMlAgoeNlllMv(pfb52d3dcVar, "this$0");
        gZUfyrivQdYbFndM(str, "$key");
        zqlNbqmrIecEkLgK(pfb52d3dcVar.f9f99697c, str);
    }

    public static void MVVZNGBTOUQpaLLr(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void Ma49e69b4(p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pfb52d3dc pfb52d3dcVar, java.lang.string str) {
        MpYwmJAjPmIXkVIR(pfb52d3dcVar, str);
    }

    public static java.lang.object PtHgqJloCzPYOqmP(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.lang.object ZqlNbqmrIecEkLgK(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public readonly void SendResult(java.lang.string key, java.lang.object data2) {
        RPqOyVaSDdRWHBLC(key, "key");
        mVVZNGBTOUQpaLLr(data2, "data");
        p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 p449a7995Var = (p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995) ptHgqJloCzPYOqmP(this.f9f99697c, key);
        if (p449a7995Var is not null) {
            fJrufUdeQulrcXaH(p449a7995Var, data2);
        }
    }

    public readonly p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p3b1938f4 SetResultListener(java.lang.string key, p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.p449a7995 listener) {
        YgdWGnYMWVqSSOtH(key, "key");
        LeYfliWkzIYEoYtZ(listener, "listener");
        UvckxQDqqbmdAnQK(this.f9f99697c, key, listener);
        return new p4d236d9a.pbf215181.p8d237523.pd6ec0aeb.pfb52d3dc$pd41d8cd9$p95263d50(this, key);
    }
}

