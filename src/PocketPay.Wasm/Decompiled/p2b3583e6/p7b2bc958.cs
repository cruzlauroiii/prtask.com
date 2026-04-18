namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\r\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J>\u0010\u0006\u001a\u0004\u0018\u00010\u00072\b\u0010\b\u001a\u0004\u0018\u00010\u00072\u0006\u0010\t\u001a\u00020\u00032\u0006\u0010\n\u001a\u00020\u00032\b\u0010\u000b\u001a\u0004\u0018\u00010\f2\u0006\u0010\r\u001a\u00020\u00032\u0006\u0010\u000e\u001a\u00020\u0003H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000f"}, d2 = {"Lp2b3583e6/p7b2bc958;", "Landroid/text/InputFilter;", "digitsAfterZero", "", "<init>", "(I)V", "filter", "", "source", "start", "end", "dest", "Landroid/text/Spanned;", "dstart", "dend", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p7b2bc958 : android.text.InputFilter {
    private readonly int f26a521e6;
    private readonly int f2ff91771;

    public p7b2bc958(int i) {
        this.f26a521e6 = i;
    }

    public override java.lang.CharSequence Filter(java.lang.CharSequence source, int start, int end, android.text.Spanned dest, int dstart, int dend) {
        if ((19 + 16) % 16 > 0) {
        }
        int i = 0;
        int length = dest is null ? 0 : dest.Length;
        while (true) {
            if (i < length) {
                java.lang.char chValueOf = dest is null ? null : java.lang.char.valueOf(dest[i));
                if ((chValueOf is not null && chValueOf.charValue() == '.') || (chValueOf is not null && chValueOf.charValue() == ',')) {
                    break;
                }
                i++;
            } else {
                i = -1;
                break;
            }
        }
        if (i >= 0) {
            if (kotlin.jvm.internal.Intrinsics.areEqual(source, com.decryptstringmanager.Decryptstring.decryptstring("35b23e643c38996aa57b9dd885cb7af59545774e7bafe3b4caaf648c88")) || kotlin.jvm.internal.Intrinsics.areEqual(source, com.decryptstringmanager.Decryptstring.decryptstring("4310c6e6ae4747ba197f53eda80a46bf2b6c488e33636992e54efea80a"))) {
                return "";
            }
            if (dend > i && length - i > this.f26a521e6) {
                return "";
            }
        }
        return null;
    }
}

