namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J \u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u0007H\u0016¨\u0006\t"}, d2 = {"utils/phone/PhoneMaskedTextChangedListener$Companion$installOn$phoneValueListener$1", "Lp4d236d9a/pa80b3f43/p4406f274/peb44ef7a$pafc44394;", "onTextChanged", "", "maskFilled", "", "extractedValue", "", "formattedValue", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1c05a448$p910eef8c$p1fbf0b91$p0f3aeba1$1 : p4d236d9a.pa80b3f43.p4406f274.peb44ef7a$pafc44394 {
    readonly p2b3583e6.pf7a42fe7.p1c05a448$p33e59707 $phoneResultListener;

    p1c05a448$p910eef8c$p1fbf0b91$p0f3aeba1$1(p2b3583e6.pf7a42fe7.p1c05a448$p33e59707 p1c05a448_p33e59707) {
        this.$phoneResultListener = p1c05a448_p33e59707;
    }

    public override void OnTextChanged(bool maskFilled, java.lang.string extractedValue, java.lang.string formattedValue) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(extractedValue, "extractedValue");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(formattedValue, "formattedValue");
        this.$phoneResultListener.onPhoneChanged(formattedValue);
    }
}

