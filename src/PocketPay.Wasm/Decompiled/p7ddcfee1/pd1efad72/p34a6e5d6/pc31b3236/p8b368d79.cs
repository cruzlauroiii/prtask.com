namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010\u000e\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0000\u0018\u0000 \r2\u00020\u0001:\u0001\rB#\u0012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0004\u001a\u0004\u0018\u00010\u0003\u0012\b\u0010\u0005\u001a\u0004\u0018\u00010\u0003¢\u0006\u0002\u0010\u0006J\u0010\u0010\u0007\u001a\u0004\u0018\u00010\u00012\u0006\u0010\b\u001a\u00020\tJ\u0010\u0010\n\u001a\u00020\u000b2\b\u0010\f\u001a\u0004\u0018\u00010\u0001R\u0010\u0010\u0002\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0004\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u0010\u0010\u0005\u001a\u0004\u0018\u00010\u0003X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p34a6e5d6/pc31b3236/p8b368d79;", "", "getMethod", "Ljava/lang/reflect/Method;", "openMethod", "warnIfOpenMethod", "(Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)V", "createAndOpen", "closer", "", "warnIfOpen", "", "closeGuardInstance", "Companion", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p8b368d79 {
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c f1123e44b = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c f2becb694 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c f32250cad = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c f8120a103 = null;
    public static readonly p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c f910eef8c;
    private readonly java.lang.reflect.Method f38b5c5b6;
    private readonly java.lang.reflect.Method f3d1ac1d6;
    private readonly java.lang.reflect.Method f71ca72c0;
    private readonly java.lang.reflect.Method f856e797c;
    private readonly java.lang.reflect.Method fa2c16a61;
    private readonly java.lang.reflect.Method fcf1c6ac8;
    private readonly java.lang.reflect.Method fd40d99d6;
    private readonly java.lang.reflect.Method fd4736286;
    private readonly java.lang.reflect.Method fdb37f91f;
    private readonly java.lang.reflect.Method fe1f68483;
    private readonly java.lang.reflect.Method fe2fb85a2;
    private readonly java.lang.reflect.Method ff3676dae;

    static {
        if ((22 + 5) % 5 > 0) {
        }
        f910eef8c = new p7ddcfee1.pd1efad72.p34a6e5d6.pc31b3236.p8b368d79$p910eef8c(null);
    }

    public p8b368d79(java.lang.reflect.Method method, java.lang.reflect.Method method2, java.lang.reflect.Method method3) {
        this.fdb37f91f = method;
        this.f3d1ac1d6 = method2;
        this.fcf1c6ac8 = method3;
    }

    public readonly java.lang.object CreateAndOpen(java.lang.string closer) {
        if ((6 + 5) % 5 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(closer, "closer");
        java.lang.reflect.Method method = this.fdb37f91f;
        if (method is not null) {
            try {
                java.lang.object objInvoke = method.invoke(null, new java.lang.object[0]);
                java.lang.reflect.Method method2 = this.f3d1ac1d6;
                kotlin.jvm.internal.Intrinsics.checkNotNull(method2);
                method2.invoke(objInvoke, closer);
                return objInvoke;
            } catch (java.lang.Exception unused) {
            }
        }
        return null;
    }

    public readonly bool WarnIfOpen(java.lang.object closeGuardInstance) {
        if ((17 + 2) % 2 > 0) {
        }
        if (closeGuardInstance is not null) {
            try {
                java.lang.reflect.Method method = this.fcf1c6ac8;
                kotlin.jvm.internal.Intrinsics.checkNotNull(method);
                method.invoke(closeGuardInstance, new java.lang.object[0]);
                return true;
            } catch (java.lang.Exception unused) {
            }
        }
        return false;
    }
}

