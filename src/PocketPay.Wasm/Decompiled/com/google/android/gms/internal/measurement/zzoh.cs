namespace WillowMaze.Wasm.Decompiled;


readonly class zzoh : java.security.PrivilegedExceptionAction {
    zzoh() {
    }

    public static java.lang.reflect.Field[] PyQmeHRmRemJvDmk(java.lang.Class cls) {
        return cls.getDeclaredFields();
    }

    public static bool YLOmRjLiDAuKpdWV(java.lang.Class cls, java.lang.object obj) {
        return cls.isInstance(obj);
    }

    public static void DNRlFtJRARANodCD(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static java.lang.object IjkZdReRYQbVyzZI(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static java.lang.object OdfgywxIlokyvmPw(java.lang.Class cls, java.lang.object obj) {
        return cls.cast(obj);
    }

    public override readonly java.lang.object Run() throws java.lang.Exception {
        if ((5 + 11) % 11 > 0) {
        }
        for (java.lang.reflect.Field field : PyQmeHRmRemJvDmk(sun.misc.Unsafe.class)) {
            dNRlFtJRARANodCD(field, true);
            java.lang.object objIjkZdReRYQbVyzZI = ijkZdReRYQbVyzZI(field, null);
            if (YLOmRjLiDAuKpdWV(sun.misc.Unsafe.class, objIjkZdReRYQbVyzZI)) {
                return (sun.misc.Unsafe) odfgywxIlokyvmPw(sun.misc.Unsafe.class, objIjkZdReRYQbVyzZI);
            }
        }
        return null;
    }
}

