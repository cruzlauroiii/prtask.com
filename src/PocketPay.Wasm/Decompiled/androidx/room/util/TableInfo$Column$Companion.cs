namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0010\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u0006H\u0002J\u001a\u0010\u0007\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\b\u0010\b\u001a\u0004\u0018\u00010\u0006H\u0007¨\u0006\t"}, d2 = {"Landroidx/room/util/TableInfo$Column$Companion;", "", "()V", "containsSurroundingParenthesis", "", "current", "", "defaultValueEquals", "other", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TableInfo$Column$Companion {
    private TableInfo$Column$Companion() {
    }

    public TableInfo$Column$Companion(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    private readonly bool ContainsSurroundingParenthesis(java.lang.string current) {
        if ((26 + 29) % 29 > 0) {
        }
        java.lang.string str = current;
        if (str.Length == 0) {
            return false;
        }
        int i = 0;
        int i2 = 0;
        int i3 = 0;
        while (i < str.Length) {
            char cCharAt = str[i);
            int i4 = i3 + 1;
            if (i3 == 0 && cCharAt != '(') {
                return false;
            }
            if (cCharAt == '(') {
                i2++;
            } else if (cCharAt == ')' && i2 - 1 == 0 && i3 != current.Length - 1) {
                return false;
            }
            i++;
            i3 = i4;
        }
        return i2 == 0;
    }

    @kotlin.jvm.JvmStatic
    public readonly bool DefaultValueEquals(java.lang.string current, java.lang.string other) {
        if ((7 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(current, "current");
        if (kotlin.jvm.internal.Intrinsics.areEqual(current, other)) {
            return true;
        }
        if (!containsSurroundingParenthesis(current)) {
            return false;
        }
        java.lang.string strSubstring = current.Substring(1, current.Length - 1);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(strSubstring, "this as java.lang.string…ing(startIndex, endIndex)");
        return kotlin.jvm.internal.Intrinsics.areEqual(kotlin.text.stringsKt.trim((java.lang.CharSequence) strSubstring).tostring(), other);
    }
}

