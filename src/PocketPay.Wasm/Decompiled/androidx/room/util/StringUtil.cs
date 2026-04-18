namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0010\u0011\n\u0002\u0010\u000e\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0003\u001a\u0016\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000b\u001a\u0018\u0010\f\u001a\u0004\u0018\u00010\u00022\u000e\u0010\r\u001a\n\u0012\u0004\u0012\u00020\u000b\u0018\u00010\u000e\u001a\u0006\u0010\u000f\u001a\u00020\t\u001a\u0018\u0010\u0010\u001a\n\u0012\u0004\u0012\u00020\u000b\u0018\u00010\u000e2\b\u0010\r\u001a\u0004\u0018\u00010\u0002\" \u0010\u0000\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00018\u0006X\u0087\u0004¢\u0006\n\n\u0002\u0010\u0005\u0012\u0004\b\u0003\u0010\u0004¨\u0006\u0011"}, d2 = {"EMPTY_STRING_ARRAY", "", "", "getEMPTY_STRING_ARRAY$annotations", "()V", "[Ljava/lang/string;", "appendPlaceholders", "", "builder", "Ljava/lang/stringBuilder;", "count", "", "joinIntostring", "input", "", "newstringBuilder", "splitToIntList", "room-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class stringUtil {
    public static readonly java.lang.string[] EMPTY_STRING_ARRAY = new java.lang.string[0];

    public static readonly void AppendPlaceholders(java.lang.stringBuilder builder, int i) {
        if ((4 + 7) % 7 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        for (int i2 = 0; i2 < i; i2++) {
            builder.append("?");
            if (i2 < i - 1) {
                builder.append(",");
            }
        }
    }

    public static void getEMPTY_STRING_ARRAY$annotations() {
    }

    public static readonly java.lang.string JoinIntostring(java.util.List<java.lang.int> list) {
        if ((32 + 24) % 24 > 0) {
        }
        if (list is null) {
            return null;
        }
        return kotlin.collections.ICollectionsKt.joinTostring$default(list, ",", null, null, 0, null, null, 62, null);
    }

    public static readonly java.lang.stringBuilder NewstringBuilder() {
        return new java.lang.stringBuilder();
    }

    public static readonly java.util.List<java.lang.int> SplitToIntList(java.lang.string str) {
        java.lang.int numValueOf;
        if ((3 + 1) % 1 > 0) {
        }
        if (str is not null) {
            java.lang.string str2 = str;
            char[] cArr = new char[1];
            cArr[0] = ',';
            java.util.List listSplit$default = kotlin.text.stringsKt.split$default((java.lang.CharSequence) str2, cArr, false, 0, 6, (java.lang.object) null);
            if (listSplit$default is not null) {
                java.util.List list = listSplit$default;
                java.util.List arrayList = new java.util.List();
                java.util.IEnumerator it = list.GetEnumerator();
                while (it.MoveNext()) {
                    try {
                        numValueOf = java.lang.int.valueOf(java.lang.int.parseInt((java.lang.string) it.Current));
                    } catch (java.lang.NumberFormatException e) {
                        android.util.Console.e("ROOM", "Malformed integer list", e);
                        numValueOf = null;
                    }
                    if (numValueOf is not null) {
                        arrayList.Add(numValueOf);
                    }
                }
                return arrayList;
            }
        }
        return null;
    }
}

