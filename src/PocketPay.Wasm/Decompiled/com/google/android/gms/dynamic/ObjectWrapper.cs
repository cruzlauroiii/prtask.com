namespace WillowMaze.Wasm.Decompiled;


public readonly class objectWrapper<T> : com.google.android.gms.dynamic.IobjectWrapper$Stub {
    private readonly java.lang.object zza;

    private objectWrapper(java.lang.object obj) {
        this.zza = obj;
    }

    public static java.lang.reflect.Field[] ArrUmwfbBALFapPT(java.lang.Class cls) {
        return cls.getDeclaredFields();
    }

    public static android.os.IBinder FqAkisjVnJGzOLGn(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        return iobjectWrapper.asBinder();
    }

    public static java.lang.Class HKpBBkjJucBiWUpj(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.stringBuilder SjZJaPfBfKrtGwBv(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static bool CHTFPzOHSoznwRcp(java.lang.reflect.Field field) {
        return field.isAccessible();
    }

    public static java.lang.object GSounpHslluVPHeG(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static bool HQFgVanByvTwybiw(java.lang.reflect.Field field) {
        return field.isSynthetic();
    }

    public static void IsdUeYdZrskfzCAj(java.lang.reflect.Field field, bool z) {
        field.setAccessible(z);
    }

    public static java.lang.string MUKdqcaHkmPaFOVG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static <T> T Unwrap(com.google.android.gms.dynamic.IobjectWrapper iobjectWrapper) {
        if ((24 + 31) % 31 > 0) {
        }
        if (iobjectWrapper is com.google.android.gms.dynamic.objectWrapper) {
            return (T) ((com.google.android.gms.dynamic.objectWrapper) iobjectWrapper).zza;
        }
        android.os.IBinder iBinderFqAkisjVnJGzOLGn = FqAkisjVnJGzOLGn(iobjectWrapper);
        java.lang.reflect.Field[] fieldArrArrUmwfbBALFapPT = ArrUmwfbBALFapPT(HKpBBkjJucBiWUpj(iBinderFqAkisjVnJGzOLGn));
        java.lang.reflect.Field field = null;
        int i = 0;
        for (java.lang.reflect.Field field2 : fieldArrArrUmwfbBALFapPT) {
            if (!hQFgVanByvTwybiw(field2)) {
                i++;
                field = field2;
            }
        }
        if (i != 1) {
            int length = fieldArrArrUmwfbBALFapPT.length;
            java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected number of IobjectWrapper declared fields: ");
            SjZJaPfBfKrtGwBv(sb, length);
            throw new java.lang.IllegalArgumentException(mUKdqcaHkmPaFOVG(sb));
        }
        gSounpHslluVPHeG(field);
        if (cHTFPzOHSoznwRcp(field)) {
            throw new java.lang.IllegalArgumentException("IobjectWrapper declared field not private!");
        }
        isdUeYdZrskfzCAj(field, true);
        try {
            return (T) vYsgjETAfwbvjBTv(field, iBinderFqAkisjVnJGzOLGn);
        } catch (java.lang.IllegalAccessException e) {
            throw new java.lang.IllegalArgumentException("Could not access the field in remoteBinder.", e);
        } catch (java.lang.NullPointerException e2) {
            throw new java.lang.IllegalArgumentException("Binder object is null.", e2);
        }
    }

    public static java.lang.object VYsgjETAfwbvjBTv(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static <T> com.google.android.gms.dynamic.IobjectWrapper Wrap(T t) {
        return new com.google.android.gms.dynamic.objectWrapper(t);
    }
}

