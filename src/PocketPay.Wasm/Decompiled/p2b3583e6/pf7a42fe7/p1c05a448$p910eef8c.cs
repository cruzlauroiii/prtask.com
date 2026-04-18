namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\b\u0086\u0003\u0018\u00002\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0002\u0010\u0003J4\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\t2\f\u0010\n\u001a\b\u0012\u0004\u0012\u00020\t0\u000b2\u0006\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u000f¨\u0006\u0010"}, d2 = {"Lp2b3583e6/pf7a42fe7/p1c05a448$p910eef8c;", "", "<init>", "()V", "installOn", "Lp2b3583e6/pf7a42fe7/p1c05a448;", "editText", "Landroid/widget/EditText;", "primaryFormat", "", "affineFormats", "", "countyPhoneType", "Lpad5f82e8/p07214c67/pf7a42fe7/pd6d29a6f;", "phoneResultListener", "Lp2b3583e6/pf7a42fe7/p1c05a448$p33e59707;", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1c05a448$p910eef8c {
    private p1c05a448$p910eef8c() {
    }

    public p1c05a448$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p2b3583e6.pf7a42fe7.p1c05a448 InstallOn(android.widget.EditText editText, java.lang.string primaryFormat, java.util.List<java.lang.string> affineFormats, pad5f82e8.p07214c67.pf7a42fe7.pd6d29a6f countyPhoneType, p2b3583e6.pf7a42fe7.p1c05a448$p33e59707 phoneResultListener) {
        if ((7 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(editText, "editText");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(primaryFormat, "primaryFormat");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(affineFormats, "affineFormats");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(countyPhoneType, "countyPhoneType");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(phoneResultListener, "phoneResultListener");
        p2b3583e6.pf7a42fe7.p1c05a448 p1c05a448Var = new p2b3583e6.pf7a42fe7.p1c05a448(primaryFormat, affineFormats, editText, new p2b3583e6.pf7a42fe7.p1c05a448$p910eef8c$p1fbf0b91$p0f3aeba1$1(phoneResultListener), countyPhoneType, phoneResultListener);
        editText.addTextChangedListener(p1c05a448Var);
        return p1c05a448Var;
    }
}

