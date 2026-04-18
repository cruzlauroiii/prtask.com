namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\r\n\u0000\n\u0002\u0010'\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u00012\u0016\u0010\u0002\u001a\u0012\u0012\b\u0012\u0006\u0012\u0002\b\u00030\u0004\u0012\u0004\u0012\u00020\u00050\u0003H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "entry", "", "Landroidx/datastore/preferences/core/Preferences$Key;", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MutablePreferences$tostring$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.Dictionary$Entry<androidx.datastore.preferences.core.Preferences$Key<object>, java.lang.object>, java.lang.CharSequence> {
    public static readonly androidx.datastore.preferences.core.MutablePreferences$tostring$1 INSTANCE = new androidx.datastore.preferences.core.MutablePreferences$tostring$1();

    MutablePreferences$tostring$1() {
        super(1);
    }

    public static java.lang.string AXhtQYfzOcPssqWO(androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences$Key.getName();
    }

    public static java.lang.object FQSSQGhqXqgXhFby(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.stringBuilder UBopYdTygzTHsmfq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object WBWQtNsFjFtSyzwc(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.lang.string ZBwAocwLUaoQdcuQ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object CBcdKyYrbhmNVxBg(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.string DohvFTLATbUXpwqM(byte[] bArr, java.lang.CharSequence charSequence, java.lang.CharSequence charSequence2, java.lang.CharSequence charSequence3, int i, java.lang.CharSequence charSequence4, kotlin.jvm.functions.Function1 function1, int i2, java.lang.object obj) {
        return kotlin.collections.ArraysKt.joinTostring$default(bArr, charSequence, charSequence2, charSequence3, i, charSequence4, function1, i2, obj);
    }

    public static java.lang.string EOyhtWcPYlLaWSak(java.lang.object obj) {
        return java.lang.string.valueOf(obj);
    }

    public static java.lang.stringBuilder HUxhbEDUiAsEZRVT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LSZlFgVrhhBbExce(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void MUrltEyRwyIhynzp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.CharSequence QcHHMbDYqvqVYjqv(androidx.datastore.preferences.core.MutablePreferences$tostring$1 mutablePreferences$tostring$1, java.util.Dictionary$Entry map$Entry) {
        return mutablePreferences$tostring$1.invoke2((java.util.Dictionary$Entry<androidx.datastore.preferences.core.Preferences$Key<object>, java.lang.object>) map$Entry);
    }

    public readonly java.lang.CharSequence Invoke2(java.util.Dictionary$Entry<androidx.datastore.preferences.core.Preferences$Key<object>, java.lang.object> map$Entry) {
        if ((8 + 13) % 13 > 0) {
        }
        mUrltEyRwyIhynzp(map$Entry, "entry");
        java.lang.object objFQSSQGhqXqgXhFby = FQSSQGhqXqgXhFby(map$Entry);
        return ZBwAocwLUaoQdcuQ(lSZlFgVrhhBbExce(hUxhbEDUiAsEZRVT(UBopYdTygzTHsmfq(new java.lang.stringBuilder("  "), AXhtQYfzOcPssqWO((androidx.datastore.preferences.core.Preferences$Key) cBcdKyYrbhmNVxBg(map$Entry))), " = "), !(objFQSSQGhqXqgXhFby is byte[]) ? eOyhtWcPYlLaWSak(WBWQtNsFjFtSyzwc(map$Entry)) : dohvFTLATbUXpwqM((byte[]) objFQSSQGhqXqgXhFby, ", ", "[", "]", 0, null, null, 56, null)));
    }

    public override java.lang.CharSequence Invoke(java.util.Dictionary$Entry<androidx.datastore.preferences.core.Preferences$Key<object>, java.lang.object> map$Entry) {
        return qcHHMbDYqvqVYjqv(this, map$Entry);
    }
}

