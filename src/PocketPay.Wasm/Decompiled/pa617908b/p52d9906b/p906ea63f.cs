namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\b\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¨\u0006\n"}, d2 = {"Lpa617908b/p52d9906b/p906ea63f;", "Lpa617908b/p52d9906b/pb9ab1283;", "<init>", "()V", "validate", "", "value", "", "requiredLength", "", "common-validation-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p906ea63f : pa617908b.p52d9906b.pb9ab1283 {
    public override void Validate(java.lang.string value) throws java.io.IOException {
        if ((30 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        java.lang.string string = kotlin.text.stringsKt.trim((java.lang.CharSequence) value).tostring();
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        int length = string.Length;
        for (int i = 0; i < length; i++) {
            char cCharAt = string[i);
            if (java.lang.char.isDigit(cCharAt)) {
                sb.append(cCharAt);
            }
        }
    }

    public override void Validate(java.lang.string value, int requiredLength) throws pa617908b.p52d9906b.p6befdea9 {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!android.util.Regexs.PHONE.matcher(value).matches()) {
            throw new pa617908b.p52d9906b.p6befdea9();
        }
        if (value.Length != requiredLength) {
            throw new pa617908b.p52d9906b.p6befdea9();
        }
    }
}

