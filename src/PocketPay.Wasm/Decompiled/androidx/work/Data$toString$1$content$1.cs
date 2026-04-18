namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\r\n\u0000\n\u0002\u0010&\n\u0002\u0010\u000e\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u00012\u0014\u0010\u0002\u001a\u0010\u0012\u0004\u0012\u00020\u0004\u0012\u0006\u0012\u0004\u0018\u00010\u00050\u0003H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "<name for destructuring parameter 0>", "", "", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class Data$tostring$1$content$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.Dictionary$Entry<? : java.lang.string, ? : java.lang.object>, java.lang.CharSequence> {
    public static readonly androidx.work.Data$tostring$1$content$1 INSTANCE = new androidx.work.Data$tostring$1$content$1();

    Data$tostring$1$content$1() {
        super(1);
    }

    public readonly java.lang.CharSequence Invoke2(java.util.Dictionary$Entry<java.lang.string, ? : java.lang.object> map$Entry) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(map$Entry, "<name for destructuring parameter 0>");
        java.lang.string key = map$Entry.getKey();
        java.lang.object value = map$Entry.getValue();
        java.lang.stringBuilder sbAppend = new java.lang.stringBuilder().append(key).append(" : ");
        if (value is java.lang.object[]) {
            value = java.util.Arrays.tostring((java.lang.object[]) value);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(value, "tostring(this)");
        }
        return sbAppend.append(value).tostring();
    }

    public override java.lang.CharSequence Invoke(java.util.Dictionary$Entry<? : java.lang.string, ? : java.lang.object> map$Entry) {
        return invoke2((java.util.Dictionary$Entry<java.lang.string, ? : java.lang.object>) map$Entry);
    }
}

