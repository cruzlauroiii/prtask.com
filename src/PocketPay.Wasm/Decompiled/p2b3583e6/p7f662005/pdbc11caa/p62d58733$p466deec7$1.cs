namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\"\u0010\u0003\u001a\u00028\u00002\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0006H\u0096\u0002¢\u0006\u0002\u0010\u0007J*\u0010\b\u001a\u00020\t2\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00062\u0006\u0010\n\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000b¨\u0006\f"}, d2 = {"utils/delegate/arguments/PreferenceDelegateKt$json$1", "Lkotlin/properties/ReadWriteProperty;", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Ljava/lang/object;Lkotlin/reflect/KProperty;)Ljava/lang/object;", "setValue", "", "value", "(Ljava/lang/object;Lkotlin/reflect/KProperty;Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class p62d58733$p466deec7$1<T> : kotlin.properties.ReadWriteProperty<java.lang.object, T> {
    readonly T $defaultValue;
    readonly com.google.gson.Gson $gson;
    readonly java.lang.string $key;
    readonly android.content.Dictionary<string, object> $this_json;

    public p62d58733$p466deec7$1(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, com.google.gson.Gson gson, T t) {
        this.$this_json = sharedPreferences;
        this.$key = str;
        this.$gson = gson;
        this.$defaultValue = t;
    }

    public override T GetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property) {
        if ((13 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        java.lang.string string = this.$this_json.getstring(this.$key, null);
        com.google.gson.Gson gson = this.$gson;
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, com.decryptstringmanager.Decryptstring.decryptstring("7d77b61441f729732cae4fd78a08043197b9bcefd527a79b0eed69ca05"));
        T t = (T) gson.fromJson(string, (java.lang.Class) java.lang.object.class);
        return t is not null ? t : this.$defaultValue;
    }

    public override void SetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        com.google.gson.Gson gson = this.$gson;
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(4, com.decryptstringmanager.Decryptstring.decryptstring("d96fced847a69542161b29f8364d7cfe5a183b67a1a46dc924df1d517b"));
        this.$this_json.edit().putstring(this.$key, gson.toJson(value, java.lang.object.class)).apply();
    }
}

