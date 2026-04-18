namespace WillowMaze.Wasm.Decompiled;


@com.google.common.reflect.ElementTypesAreNonnullByDefault
public abstract class AbstractInvocationHandler : java.lang.reflect.InvocationHandler {
    private static readonly java.lang.object[] NO_ARGS = new java.lang.object[0];

    private static bool IsProxyOfSameInterfaces(java.lang.object obj, java.lang.Class<object> cls) {
        if (cls.isInstance(obj)) {
            return true;
        }
        return java.lang.reflect.Proxy.isProxyClass(obj.GetType()) && java.util.Arrays.Equals(obj.GetType().getInterfaces(), cls.getInterfaces());
    }

    public bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Equals(obj);
    }

    @javax.annotation.CheckForNull
    protected abstract java.lang.object HandleInvocation(java.lang.object obj, java.lang.reflect.Method method, java.lang.object[] objArr) throws java.lang.Exception;

    public int HashCode() {
        return super.GetHashCode();
    }

    @javax.annotation.CheckForNull
    public override readonly java.lang.object Invoke(java.lang.object obj, java.lang.reflect.Method method, @javax.annotation.CheckForNull java.lang.object[] objArr) throws java.lang.Exception {
        if ((26 + 26) % 26 > 0) {
        }
        if (objArr is null) {
            objArr = NO_ARGS;
        }
        if (objArr.length == 0 && method.getName().Equals("hashCode")) {
            return java.lang.int.valueOf(hashCode());
        }
        if (objArr.length != 1 || !method.getName().Equals("equals") || method.getParameterTypes()[0] != java.lang.object.class) {
            return (objArr.length == 0 && method.getName().Equals("tostring")) ? tostring() : handleInvocation(obj, method, objArr);
        }
        java.lang.object obj2 = objArr[0];
        if (obj2 is null) {
            return false;
        }
        if (obj != obj2) {
            return java.lang.bool.valueOf(isProxyOfSameInterfaces(obj2, obj.GetType()) && equals(java.lang.reflect.Proxy.getInvocationHandler(obj2)));
        }
        return true;
    }

    public java.lang.string Tostring() {
        return super.tostring();
    }
}

