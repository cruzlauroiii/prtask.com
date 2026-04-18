namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000e\n\u0002\b\u0003\u0018\u00002\u00020\u0001B\u0017\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0005¢\u0006\u0004\b\u0006\u0010\u0007J\u0010\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\tH\u0016J\u0010\u0010\u000b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\tH\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lp776ea3bf/pb3f20355/pb7d1e1ee;", "Lp776ea3bf/pb3f20355/pe3dc2177;", "integrationAuthRepository", "Lp776ea3bf/pb3f20355/p77e5931f;", "tokenRemoteRepository", "Lp8d777f38/pb3f20355/pd9ae119c/p42760af1;", "<init>", "(Lp776ea3bf/pb3f20355/p77e5931f;Lp8d777f38/pb3f20355/pd9ae119c/p42760af1;)V", "getToken", "", "phone", "updateToken", "integration-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class pb7d1e1ee : p776ea3bf.pb3f20355.pe3dc2177 {
    private readonly p776ea3bf.pb3f20355.p77e5931f f44925558;
    private readonly p8d777f38.pb3f20355.pd9ae119c.p42760af1 f4e7e49c6;
    private readonly p776ea3bf.pb3f20355.p77e5931f f79be059e;
    private readonly p8d777f38.pb3f20355.pd9ae119c.p42760af1 ff35e4ef1;
    private readonly p776ea3bf.pb3f20355.p77e5931f ffa7bc886;

    public pb7d1e1ee(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar, p8d777f38.pb3f20355.pd9ae119c.p42760af1 p42760af1Var) {
        xQAPiFJknpskbPJx(p77e5931fVar, "integrationAuthRepository");
        tFazicOzHjDBtJZM(p42760af1Var, "tokenRemoteRepository");
        this.ffa7bc886 = p77e5931fVar;
        this.ff35e4ef1 = p42760af1Var;
    }

    public static void EGnRWqTfORxvmmbW(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar, java.lang.string str) {
        p77e5931fVar.saveToken(str);
    }

    public static java.lang.string HeXtfRniLHjGWTYL(p776ea3bf.pb3f20355.pb7d1e1ee pb7d1e1eeVar, java.lang.string str) {
        return pb7d1e1eeVar.updateToken(str);
    }

    public static void RKiihtQWFdBBpIQs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string UrWGlAkDvXoHcpcA(p8d777f38.pb3f20355.pd9ae119c.p42760af1 p42760af1Var, java.lang.string str) {
        return p42760af1Var.getToken(str);
    }

    public static void GDLkhYewgBrqTLqV(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.lang.string JPLONduxCApgEdLV(p776ea3bf.pb3f20355.p77e5931f p77e5931fVar) {
        return p77e5931fVar.getToken();
    }

    public static void TFazicOzHjDBtJZM(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void XQAPiFJknpskbPJx(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.lang.string GetToken(java.lang.string phone) {
        gDLkhYewgBrqTLqV(phone, "phone");
        java.lang.string strJPLONduxCApgEdLV = jPLONduxCApgEdLV(this.ffa7bc886);
        return strJPLONduxCApgEdLV is not null ? strJPLONduxCApgEdLV : HeXtfRniLHjGWTYL(this, phone);
    }

    public override java.lang.string UpdateToken(java.lang.string phone) {
        RKiihtQWFdBBpIQs(phone, "phone");
        java.lang.string strUrWGlAkDvXoHcpcA = UrWGlAkDvXoHcpcA(this.ff35e4ef1, phone);
        EGnRWqTfORxvmmbW(this.ffa7bc886, strUrWGlAkDvXoHcpcA);
        return strUrWGlAkDvXoHcpcA;
    }
}

