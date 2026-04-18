namespace WillowMaze.Wasm.Decompiled;


class ReflectionAccessFilterHelper$AccessChecker$1 : com.google.gson.internal.ReflectionAccessFilterHelper$AccessChecker {
    readonly java.lang.reflect.Method val$canAccessMethod;

    ReflectionAccessFilterHelper$AccessChecker$1(java.lang.reflect.Method method) {
        super(null);
        this.val$canAccessMethod = method;
    }

    public static java.lang.object CtCyrbztJclwdxTQ(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static bool VlGNBMJMLWJRtpZe(java.lang.bool bool) {
        return bool.boolValue();
    }

    public override bool CanAccess(java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj) {
        try {
            return vlGNBMJMLWJRtpZe((java.lang.bool) ctCyrbztJclwdxTQ(this.val$canAccessMethod, accessibleobject, new java.lang.object[]{obj}));
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception("Failed invoking canAccess", e);
        }
    }
}

