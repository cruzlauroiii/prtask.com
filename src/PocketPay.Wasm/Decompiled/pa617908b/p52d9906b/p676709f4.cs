namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\u0010\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0018\u0010\b\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\u0007H\u0016¨\u0006\n"}, d2 = {"Lpa617908b/p52d9906b/p676709f4;", "Lpa617908b/p52d9906b/p3cfc9edc;", "<init>", "()V", "validateRegex", "", "password", "", "validateRepeat", "repeatedPassword", "common-validation-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p676709f4 : pa617908b.p52d9906b.p3cfc9edc {
    public override void ValidateRegex(java.lang.string password) throws pa617908b.p52d9906b.pf2b9c58e {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(password, "password");
        if (!java.util.regex.Regex.compile("(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=\\S+$).{8,}").matcher(password).matches()) {
            throw new pa617908b.p52d9906b.pf2b9c58e();
        }
    }

    public override void ValidateRepeat(java.lang.string password, java.lang.string repeatedPassword) throws pa617908b.p52d9906b.pe596bc9b {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(password, "password");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(repeatedPassword, "repeatedPassword");
        if (!kotlin.jvm.internal.Intrinsics.areEqual(repeatedPassword, password)) {
            throw new pa617908b.p52d9906b.pe596bc9b();
        }
    }
}

