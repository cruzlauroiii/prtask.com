namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Lpa617908b/p52d9906b/p79b05231;", "Lpa617908b/p52d9906b/p1d0d18f1;", "<init>", "()V", "validate", "", "value", "", "common-validation-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p79b05231 : pa617908b.p52d9906b.p1d0d18f1 {
    public override void Validate(java.lang.string value) throws pa617908b.p52d9906b.p7fac32ad {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        if (!android.util.Regexs.EMAIL_ADDRESS.matcher(value).matches()) {
            throw new pa617908b.p52d9906b.p7fac32ad();
        }
    }
}

