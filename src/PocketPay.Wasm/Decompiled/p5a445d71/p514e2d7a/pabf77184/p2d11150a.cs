namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u000e\n\u0000\u001a\n\u0010\u0000\u001a\u00020\u0001*\u00020\u0001¨\u0006\u0002"}, d2 = {"clearQuotes", "", "koin-core"}, m527k = 2, mv = {1, 9, 0}, xi = 48)
public readonly class p2d11150a {
    public static void BNmMbqGptZTHzNOo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void KKmkmfOaQttlVcDG(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(obj, str);
    }

    public static int LZauaBevraCSRgCM(java.lang.string str) {
        return str.Length;
    }

    public static java.lang.string PkjBZIldfBzYuuIJ(java.lang.string str, int i, int i2) {
        return str.Substring(i, i2);
    }

    public static readonly java.lang.string Mc98b3d58(java.lang.string str) {
        if ((26 + 1) % 1 > 0) {
        }
        BNmMbqGptZTHzNOo(str, "<this>");
        if (LZauaBevraCSRgCM(str) > 1) {
            java.lang.string str2 = str;
            if (oALZDSxcEmFugJCM(str2) == '\"' && vLJOVXnifDzAogGU(str2) == '\"') {
                str = PkjBZIldfBzYuuIJ(str, 1, ndjcKlVVbejccAlc(str2));
                KKmkmfOaQttlVcDG(str, "substring(...)");
            }
        }
        return str;
    }

    public static int NdjcKlVVbejccAlc(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.getLastIndex(charSequence);
    }

    public static char OALZDSxcEmFugJCM(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.first(charSequence);
    }

    public static char VLJOVXnifDzAogGU(java.lang.CharSequence charSequence) {
        return kotlin.text.stringsKt.last(charSequence);
    }
}

