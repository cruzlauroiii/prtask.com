namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\u0004\u0012\u00020\u0002\u0012\u0004\u0012\u00028\u00000\u0001J\"\u0010\u0003\u001a\u00028\u00002\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u0006H\u0096\u0002¢\u0006\u0002\u0010\u0007J*\u0010\b\u001a\u00020\t2\u0006\u0010\u0004\u001a\u00020\u00022\n\u0010\u0005\u001a\u0006\u0012\u0002\b\u00030\u00062\u0006\u0010\n\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000b¨\u0006\f¸\u0006\u0000"}, d2 = {"utils/delegate/arguments/PreferenceDelegateKt$delegate$1", "Lkotlin/properties/ReadWriteProperty;", "", "getValue", "thisRef", "property", "Lkotlin/reflect/KProperty;", "(Ljava/lang/object;Lkotlin/reflect/KProperty;)Ljava/lang/object;", "setValue", "", "value", "(Ljava/lang/object;Lkotlin/reflect/KProperty;Ljava/lang/object;)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p62d58733$pa8a8458b$pd41d8cd9$pec404527$p7f662005$1 : kotlin.properties.ReadWriteProperty<java.lang.object, java.util.HashSet<java.lang.string>> {
    readonly java.lang.object $defaultValue;
    readonly java.lang.string $key;
    readonly android.content.Dictionary<string, object> $this_delegate;

    public p62d58733$pa8a8458b$pd41d8cd9$pec404527$p7f662005$1(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.object obj) {
        this.$this_delegate = sharedPreferences;
        this.$key = str;
        this.$defaultValue = obj;
    }

    public override java.util.HashSet<java.lang.string> GetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        return p2b3583e6.p7f662005.pdbc11caa.p62d58733.m81680097(this.$this_delegate, this.$key, (java.util.HashSet) this.$defaultValue);
    }

    public override void SetValue(java.lang.object thisRef, kotlin.reflect.KProperty<object> property, java.util.HashSet<java.lang.string> value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(thisRef, "thisRef");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(property, "property");
        android.content.Dictionary<string, object>$Editor sharedPreferences$EditorEdit = this.$this_delegate.edit();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(sharedPreferences$EditorEdit, "edit(...)");
        sharedPreferences$EditorEdit.putstringHashSet(this.$key, value).apply();
    }
}

