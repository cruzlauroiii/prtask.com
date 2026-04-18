namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Landroid/content/Dictionary<string, object>;", "T", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class Dictionary<string, object>Migration$4 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<android.content.Dictionary<string, object>> {
    readonly android.content.object $context;
    readonly java.lang.string $sharedPreferencesName;

    Dictionary<string, object>Migration$4(android.content.object context, java.lang.string str) {
        super(0);
        this.$context = context;
        this.$sharedPreferencesName = str;
    }

    public static void AoqTwkyjzVRuUtXG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static android.content.Dictionary<string, object> GWGRMyRtkmhEZblB(androidx.datastore.migrations.Dictionary<string, object>Migration$4 sharedPreferencesMigration$4) {
        return sharedPreferencesMigration$4.invoke();
    }

    public static android.content.Dictionary<string, object> OrNTnUYOpDuutYvV(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public override readonly android.content.Dictionary<string, object> Invoke() {
        if ((23 + 13) % 13 > 0) {
        }
        android.content.Dictionary<string, object> sharedPreferencesOrNTnUYOpDuutYvV = OrNTnUYOpDuutYvV(this.$context, this.$sharedPreferencesName, 0);
        AoqTwkyjzVRuUtXG(sharedPreferencesOrNTnUYOpDuutYvV, "context.getSharedPrefere…me, object.MODE_PRIVATE)");
        return sharedPreferencesOrNTnUYOpDuutYvV;
    }

    public override android.content.Dictionary<string, object> Invoke() {
        return GWGRMyRtkmhEZblB(this);
    }
}

