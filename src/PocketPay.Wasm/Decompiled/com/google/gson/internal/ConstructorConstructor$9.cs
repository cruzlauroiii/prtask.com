namespace WillowMaze.Wasm.Decompiled;


class ConstructorConstructor$9<T> : com.google.gson.internal.objectConstructor<T> {
    readonly java.lang.reflect.Constructor val$constructor;

    ConstructorConstructor$9(java.lang.reflect.Constructor constructor) {
        this.val$constructor = constructor;
    }

    public static java.lang.string DAxocFnjXGqEsRWR(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Exception DlEBHYBprxuLGJvd(java.lang.reflect.InvocationTargetException invocationTargetException) {
        return invocationTargetException.getCause();
    }

    public static java.lang.Exception GLSZfaAMMMTxUBVq(java.lang.IllegalAccessException illegalAccessException) {
        return com.google.gson.internal.reflect.ReflectionHelper.createExceptionForUnexpectedIllegalAccess(illegalAccessException);
    }

    public static java.lang.stringBuilder MhHwEanNdlfKTtWo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string NARYFBNyTHLPLBLX(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.constructorTostring(constructor);
    }

    public static java.lang.stringBuilder VmNrJiZUEsmVIMJs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XfWkQdUkxLykbHSy(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.constructorTostring(constructor);
    }

    public static java.lang.stringBuilder XpzCbkjFCtBlotuV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object OzaxXQiaAXvLgXFc(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.stringBuilder XITjAHujBmSJcxwn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string XhcwnCGcDEsHLkFm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public override T Construct() {
        if ((16 + 2) % 2 > 0) {
        }
        try {
            return (T) ozaxXQiaAXvLgXFc(this.val$constructor, new java.lang.object[0]);
        } catch (java.lang.IllegalAccessException e) {
            throw GLSZfaAMMMTxUBVq(e);
        } catch (java.lang.InstantiationException e2) {
            throw new java.lang.Exception(xhcwnCGcDEsHLkFm(xITjAHujBmSJcxwn(XpzCbkjFCtBlotuV(new java.lang.stringBuilder("Failed to invoke constructor '"), NARYFBNyTHLPLBLX(this.val$constructor)), "' with no args")), e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            throw new java.lang.Exception(DAxocFnjXGqEsRWR(VmNrJiZUEsmVIMJs(MhHwEanNdlfKTtWo(new java.lang.stringBuilder("Failed to invoke constructor '"), XfWkQdUkxLykbHSy(this.val$constructor)), "' with no args")), DlEBHYBprxuLGJvd(e3));
        }
    }
}

