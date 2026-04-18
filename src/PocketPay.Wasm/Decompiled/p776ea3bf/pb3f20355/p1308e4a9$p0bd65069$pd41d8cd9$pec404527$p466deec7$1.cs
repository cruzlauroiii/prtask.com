namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\"\u0010\u0003\u001a\u00028\u00002\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0006H\u0096\u0002¢\u0006\u0002\u0010\u0007J*\u0010\b\u001a\u00020\t2\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00062\u0006\u0010\n\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000b¨\u0006\f¸\u0006\u0000"}, d2 = {"utils/delegate/arguments/PreferenceDelegateKt$json$1", "Lkotlin/properties/ReadWriteProperty;", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Ljava/lang/object;Lkotlin/reflect/KProperty;)Ljava/lang/object;", "setValue", "", "value", "(Ljava/lang/object;Lkotlin/reflect/KProperty;Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1308e4a9$p0bd65069$pd41d8cd9$pec404527$p466deec7$1 : kotlin.properties.ReadWriteProperty<java.lang.object, pad5f82e8.p07214c67.p1e11b989.p9ded6185> {
    readonly java.lang.object $defaultValue;
    readonly com.google.gson.Gson $gson;
    readonly java.lang.string $key;
    readonly android.content.Dictionary<string, object> $this_json;

    public p1308e4a9$p0bd65069$pd41d8cd9$pec404527$p466deec7$1(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, com.google.gson.Gson gson, java.lang.object obj) {
        this.$this_json = sharedPreferences;
        this.$key = str;
        this.$gson = gson;
        this.$defaultValue = obj;
    }

    public static void EwmzwCLqCGjtgEhU(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void NddNGnUVaxmANddB(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void OAyvHftzgQXeFrYV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string PhIqjLBUlRTKGJEk(com.google.gson.Gson gson, java.lang.object obj, java.lang.reflect.Type type) {
        return gson.toJson(obj, type);
    }

    public static android.content.Dictionary<string, object>$Editor aIoPCpCwjQDevNNd(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor aMotMfjiqVrUJVfY(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static java.lang.object CWwiriPzgAWmyogf(com.google.gson.Gson gson, java.lang.string str, java.lang.Class cls) {
        return gson.fromJson(str, cls);
    }

    public static void IXYcRmCYLGdSBJRQ(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void LJEkPNViswiwgZjE(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string TvmnAjOPaNNYZvuB(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public override pad5f82e8.p07214c67.p1e11b989.p9ded6185 GetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property) {
        OAyvHftzgQXeFrYV(thisRef, "thisRef");
        iXYcRmCYLGdSBJRQ(property, "property");
        ?? CWwiriPzgAWmyogf = cWwiriPzgAWmyogf(this.$gson, tvmnAjOPaNNYZvuB(this.$this_json, this.$key, null), pad5f82e8.p07214c67.p1e11b989.p9ded6185.class);
        return CWwiriPzgAWmyogf != 0 ? CWwiriPzgAWmyogf : this.$defaultValue;
    }

    public override void SetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property, pad5f82e8.p07214c67.p1e11b989.p9ded6185 value) {
        NddNGnUVaxmANddB(thisRef, "thisRef");
        lJEkPNViswiwgZjE(property, "property");
        EwmzwCLqCGjtgEhU(aMotMfjiqVrUJVfY(aIoPCpCwjQDevNNd(this.$this_json), this.$key, PhIqjLBUlRTKGJEk(this.$gson, value, pad5f82e8.p07214c67.p1e11b989.p9ded6185.class)));
    }
}

