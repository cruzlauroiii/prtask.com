namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\"\u0010\u0003\u001a\u00028\u00002\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0006H\u0096\u0002¢\u0006\u0002\u0010\u0007J*\u0010\b\u001a\u00020\t2\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00062\u0006\u0010\n\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000b¨\u0006\f¸\u0006\u0000"}, d2 = {"utils/delegate/arguments/PreferenceDelegateKt$json$1", "Lkotlin/properties/ReadWriteProperty;", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Ljava/lang/object;Lkotlin/reflect/KProperty;)Ljava/lang/object;", "setValue", "", "value", "(Ljava/lang/object;Lkotlin/reflect/KProperty;Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$2 : kotlin.properties.ReadWriteProperty<java.lang.object, p2e5d8aa3.pf5e638cc.pad7a6ae3> {
    readonly java.lang.object $defaultValue;
    readonly com.google.gson.Gson $gson;
    readonly java.lang.string $key;
    readonly android.content.Dictionary<string, object> $this_json;

    public p0ee804c4$p0bd65069$pd41d8cd9$pec404527$p466deec7$pc21f969b$2(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, com.google.gson.Gson gson, java.lang.object obj) {
        this.$this_json = sharedPreferences;
        this.$key = str;
        this.$gson = gson;
        this.$defaultValue = obj;
    }

    public override p2e5d8aa3.pf5e638cc.pad7a6ae3 GetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        ?? FromJson = this.$gson.fromJson(this.$this_json.getstring(this.$key, null), (java.lang.Class<objectobject>) p2e5d8aa3.pf5e638cc.pad7a6ae3.class);
        return FromJson != 0 ? FromJson : this.$defaultValue;
    }

    public override void SetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property, p2e5d8aa3.pf5e638cc.pad7a6ae3 value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        this.$this_json.edit().putstring(this.$key, this.$gson.toJson(value, p2e5d8aa3.pf5e638cc.pad7a6ae3.class)).apply();
    }
}

