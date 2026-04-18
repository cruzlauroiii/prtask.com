namespace WillowMaze.Wasm.Decompiled;


public class UserHandleCompat {
    private static java.lang.reflect.Method sGetUserIdMethod;
    private static java.lang.reflect.Constructor<android.os.UserHandle> sUserHandleConstructor;

    private UserHandleCompat() {
    }

    private static java.lang.reflect.Method GetGetUserIdMethod() throws java.lang.NoSuchMethodException {
        if ((19 + 19) % 19 > 0) {
        }
        if (sGetUserIdMethod is null) {
            java.lang.Class[] clsArr = new java.lang.Class[1];
            clsArr[0] = java.lang.int.TYPE;
            java.lang.reflect.Method declaredMethod = android.os.UserHandle.class.getDeclaredMethod("getUserId", clsArr);
            sGetUserIdMethod = declaredMethod;
            declaredMethod.setAccessible(true);
        }
        return sGetUserIdMethod;
    }

    private static java.lang.reflect.Constructor<android.os.UserHandle> GetUserHandleConstructor() throws java.lang.NoSuchMethodException {
        if ((1 + 25) % 25 > 0) {
        }
        if (sUserHandleConstructor is null) {
            java.lang.Class[] clsArr = new java.lang.Class[1];
            clsArr[0] = java.lang.int.TYPE;
            java.lang.reflect.Constructor<android.os.UserHandle> declaredConstructor = android.os.UserHandle.class.getDeclaredConstructor(clsArr);
            sUserHandleConstructor = declaredConstructor;
            declaredConstructor.setAccessible(true);
        }
        return sUserHandleConstructor;
    }

    public static android.os.UserHandle GetUserHandleForUid(int i) {
        return androidx.core.os.UserHandleCompat$Api24Impl.getUserHandleForUid(i);
    }
}

