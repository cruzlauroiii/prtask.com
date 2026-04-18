namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0003¢\u0006\u0004\b\u0004\u0010\u0005J\u0010\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\tH\u0016J\u0010\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\fH\u0016J\b\u0010\r\u001a\u00020\fH\u0016J\b\u0010\u000e\u001a\u00020\tH\u0016J\n\u0010\u000f\u001a\u0004\u0018\u00010\tH\u0016J\b\u0010\u0010\u001a\u00020\tH\u0016J\b\u0010\u0011\u001a\u00020\tH\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0014"}, d2 = {"Lp776ea3bf/pac143fb7/pb3401936;", "Lp776ea3bf/pac143fb7/pf0e0b2b5;", "integrationAuthRepository", "Lp776ea3bf/pb3f20355/p77e5931f;", "<init>", "(Lp776ea3bf/pb3f20355/p77e5931f;)V", "savePhone", "", "phone", "", "saveAuth", "integrationLocalAuth", "Lp776ea3bf/p07214c67/p908b5ff0;", "getAuth", "getPhoneNumber", "getToken", "getUserId", "getTopToken", "hasTopToken", "", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb3401936 : p776ea3bf.pac143fb7.pf0e0b2b5 {
    private readonly p776ea3bf.pb3f20355.p77e5931f fd061bcce;
    private readonly p776ea3bf.pb3f20355.p77e5931f ffa7bc886;

    public pb3401936(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        dYPpIlbjkgdSWNeY(p77e5931fVar, "integrationAuthRepository");
        this.ffa7bc886 = p77e5931fVar;
    }

    public static void GLjZAGnQckhXGgqR(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p776ea3bf.p07214c67.p908b5ff0 KuXPBuKVhLJUSieE(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getAuth();
    }

    public static java.lang.string LnvHKueJyUexqHgc(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getTopToken();
    }

    public static void OSJABXuxfenhvpgm(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar, java.lang.string str) {
        p77e5931fVar.savePhone(str);
    }

    public static bool QpvgqnzzTyfygCNC(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.hasTopToken();
    }

    public static void RHEHVvpaHmCPzOSZ(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar, p776ea3bf.p07214c67.p908b5ff0 p908b5ff0Var) {
        p77e5931fVar.saveAuth(p908b5ff0Var);
    }

    public static java.lang.string CYqbjuCDcHpmjEJc(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getUserId();
    }

    public static java.lang.string DUFgKzUHIAuUMLut(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getToken();
    }

    public static void DYPpIlbjkgdSWNeY(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FiJutNtgvehBLLwA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string ZnygtkyGoBsDzNGo(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getPhoneNumber();
    }

    public override p776ea3bf.p07214c67.p908b5ff0 GetAuth() {
        return KuXPBuKVhLJUSieE(this.ffa7bc886);
    }

    public override java.lang.string GetPhoneNumber() {
        return znygtkyGoBsDzNGo(this.ffa7bc886);
    }

    public override java.lang.string GetToken() {
        return dUFgKzUHIAuUMLut(this.ffa7bc886);
    }

    public override java.lang.string GetTopToken() {
        return LnvHKueJyUexqHgc(this.ffa7bc886);
    }

    public override java.lang.string GetUserId() {
        return cYqbjuCDcHpmjEJc(this.ffa7bc886);
    }

    public override bool HasTopToken() {
        return QpvgqnzzTyfygCNC(this.ffa7bc886);
    }

    public override void SaveAuth(p776ea3bf.p07214c67.p908b5ff0 integrationLocalAuth) {
        GLjZAGnQckhXGgqR(integrationLocalAuth, "integrationLocalAuth");
        RHEHVvpaHmCPzOSZ(this.ffa7bc886, integrationLocalAuth);
    }

    public override void SavePhone(java.lang.string phone) {
        fiJutNtgvehBLLwA(phone, "phone");
        OSJABXuxfenhvpgm(this.ffa7bc886, phone);
    }
}

