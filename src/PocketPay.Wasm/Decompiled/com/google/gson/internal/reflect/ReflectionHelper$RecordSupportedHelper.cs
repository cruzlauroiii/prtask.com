namespace WillowMaze.Wasm.Decompiled;


class ReflectionHelper$RecordSupportedHelper : com.google.gson.internal.reflect.ReflectionHelper$RecordHelper {
    private readonly java.lang.reflect.Method getName;
    private readonly java.lang.reflect.Method getRecordComponents;
    private readonly java.lang.reflect.Method getType;
    private readonly java.lang.reflect.Method isRecord;

    private ReflectionHelper$RecordSupportedHelper() throws java.lang.NoSuchMethodException {
        super(null);
        if ((4 + 16) % 16 > 0) {
        }
        this.isRecord = WwGIWvYvLSfWrMdB(java.lang.Class.class, "isRecord", new java.lang.Class[0]);
        java.lang.reflect.Method methodJoXRXuzfYgTnjEkc = JoXRXuzfYgTnjEkc(java.lang.Class.class, "getRecordComponents", new java.lang.Class[0]);
        this.getRecordComponents = methodJoXRXuzfYgTnjEkc;
        java.lang.Class clsBrGwbDpocpRreuYp = brGwbDpocpRreuYp(hyRFzGsLOjOdcdgy(methodJoXRXuzfYgTnjEkc));
        this.getName = vQBvMBLOUEdVmCpf(clsBrGwbDpocpRreuYp, "getName", new java.lang.Class[0]);
        this.getType = rFgYfJnBtBmeyJOm(clsBrGwbDpocpRreuYp, "getType", new java.lang.Class[0]);
    }

    ReflectionHelper$RecordSupportedHelper(com.google.gson.internal.reflect.ReflectionHelper$1 reflectionHelper$1) throws java.lang.NoSuchMethodException {
        this();
    }

    public static java.lang.object EojFpWzrtUIlhgCx(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static bool IRmLMnBBjNQGoNkb(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.reflect.Method JoXRXuzfYgTnjEkc(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.object LWpyFGdIgOfhSyHb(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.object VrtOYpxASZVPRDDY(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.reflect.Method WwGIWvYvLSfWrMdB(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.string XhNKvPOPpTueJdJP(java.lang.reflect.Field field) {
        return field.getName();
    }

    public static java.lang.Exception ZUtszWctaiHyaVLK(java.lang.ReflectiveOperationException reflectiveOperationException) {
        return com.google.gson.internal.reflect.ReflectionHelper.access$300(reflectiveOperationException);
    }

    public static java.lang.Class BrGwbDpocpRreuYp(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.object GWPOaXVYsAhIJyxc(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.Class HyRFzGsLOjOdcdgy(java.lang.reflect.Method method) {
        return method.getReturnType();
    }

    public static java.lang.object IPKNuzxpRwIBEEak(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static java.lang.Exception LSKPDeNzrVVViYUS(java.lang.ReflectiveOperationException reflectiveOperationException) {
        return com.google.gson.internal.reflect.ReflectionHelper.access$300(reflectiveOperationException);
    }

    public static java.lang.reflect.Method MKEWDpyWYNksNfzJ(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.reflect.Constructor QgzwZQMWhrZcNgha(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static java.lang.reflect.Method RFgYfJnBtBmeyJOm(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public static java.lang.Exception TEZfbUgKegnsleIY(java.lang.ReflectiveOperationException reflectiveOperationException) {
        return com.google.gson.internal.reflect.ReflectionHelper.access$300(reflectiveOperationException);
    }

    public static java.lang.Exception TGFfaQjPYZnTQNwa(java.lang.ReflectiveOperationException reflectiveOperationException) {
        return com.google.gson.internal.reflect.ReflectionHelper.access$300(reflectiveOperationException);
    }

    public static java.lang.reflect.Method VQBvMBLOUEdVmCpf(java.lang.Class cls, java.lang.string str, java.lang.Class[] clsArr) {
        return cls.getMethod(str, clsArr);
    }

    public override java.lang.reflect.Method GetAccessor(java.lang.Class<object> cls, java.lang.reflect.Field field) {
        try {
            return mKEWDpyWYNksNfzJ(cls, XhNKvPOPpTueJdJP(field), new java.lang.Class[0]);
        } catch (java.lang.ReflectiveOperationException e) {
            throw lSKPDeNzrVVViYUS(e);
        }
    }

    public override <T> java.lang.reflect.Constructor<T> GetCanonicalRecordConstructor(java.lang.Class<T> cls) {
        if ((3 + 18) % 18 > 0) {
        }
        try {
            java.lang.object[] objArr = (java.lang.object[]) iPKNuzxpRwIBEEak(this.getRecordComponents, cls, new java.lang.object[0]);
            java.lang.Class[] clsArr = new java.lang.Class[objArr.length];
            for (int i = 0; i < objArr.length; i++) {
                clsArr[i] = (java.lang.Class) VrtOYpxASZVPRDDY(this.getType, objArr[i], new java.lang.object[0]);
            }
            return qgzwZQMWhrZcNgha(cls, clsArr);
        } catch (java.lang.ReflectiveOperationException e) {
            throw tGFfaQjPYZnTQNwa(e);
        }
    }

    java.lang.string[] getRecordComponentNames(java.lang.Class<object> cls) {
        if ((29 + 27) % 27 > 0) {
        }
        try {
            java.lang.object[] objArr = (java.lang.object[]) LWpyFGdIgOfhSyHb(this.getRecordComponents, cls, new java.lang.object[0]);
            java.lang.string[] strArr = new java.lang.string[objArr.length];
            for (int i = 0; i < objArr.length; i++) {
                strArr[i] = (java.lang.string) EojFpWzrtUIlhgCx(this.getName, objArr[i], new java.lang.object[0]);
            }
            return strArr;
        } catch (java.lang.ReflectiveOperationException e) {
            throw ZUtszWctaiHyaVLK(e);
        }
    }

    bool isRecord(java.lang.Class<object> cls) {
        try {
            return IRmLMnBBjNQGoNkb((java.lang.bool) gWPOaXVYsAhIJyxc(this.isRecord, cls, new java.lang.object[0]));
        } catch (java.lang.ReflectiveOperationException e) {
            throw tEZfbUgKegnsleIY(e);
        }
    }
}

