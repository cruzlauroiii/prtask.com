namespace WillowMaze.Wasm.Decompiled;


readonly class ReflectiveTypeAdapterFactory$RecordAdapter<T> : com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$Adapter<T, java.lang.object[]> {
    static readonly java.util.Dictionary<java.lang.Class<object>, java.lang.object> PRIMITIVE_DEFAULTS = KxPBksfefRzxxrgw();
    private readonly java.util.Dictionary<java.lang.string, java.lang.int> componentIndices;
    private readonly java.lang.reflect.Constructor<T> constructor;
    private readonly java.lang.object[] constructorArgsDefaults;

    ReflectiveTypeAdapterFactory$RecordAdapter(java.lang.Class<T> cls, java.util.Dictionary<java.lang.string, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField> map, bool z) {
        super(map);
        if ((16 + 29) % 29 > 0) {
        }
        this.componentIndices = new java.util.HashDictionary();
        java.lang.reflect.Constructor<T> constructorEkYkbPRjJkRMabEL = EkYkbPRjJkRMabEL(cls);
        this.constructor = constructorEkYkbPRjJkRMabEL;
        if (z) {
            WOhkDfTCkzfTquBq(null, constructorEkYkbPRjJkRMabEL);
        } else {
            lqfjbtUGZRaZQYIl(constructorEkYkbPRjJkRMabEL);
        }
        java.lang.string[] strArrTVApQiMLzKfclKge = TVApQiMLzKfclKge(cls);
        for (int i = 0; i < strArrTVApQiMLzKfclKge.length; i++) {
            qLAjEjKVqhyhZYCn(this.componentIndices, strArrTVApQiMLzKfclKge[i], vUcuINQJUMouCuhm(i));
        }
        java.lang.Class[] clsArrJucVIvnFGOQfeqTk = jucVIvnFGOQfeqTk(this.constructor);
        this.constructorArgsDefaults = new java.lang.object[clsArrJucVIvnFGOQfeqTk.length];
        for (int i2 = 0; i2 < clsArrJucVIvnFGOQfeqTk.length; i2++) {
            this.constructorArgsDefaults[i2] = kBIiIQfGhmkPRrSS(PRIMITIVE_DEFAULTS, clsArrJucVIvnFGOQfeqTk[i2]);
        }
    }

    public static java.lang.object CtdUFdvKAIsDpdAk(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object CzTFgacsVHpylfcP(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.stringBuilder EVccKOCiUVoxgnee(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Constructor EkYkbPRjJkRMabEL(java.lang.Class cls) {
        return com.google.gson.internal.reflect.ReflectionHelper.getCanonicalRecordConstructor(cls);
    }

    public static java.lang.byte FCrJeBolMnndzXQi(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static void KeEHpCgusiiOVpEM(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField, com.google.gson.stream.JsonReader jsonReader, int i, java.lang.object[] objArr) throws java.io.IOException {
        reflectiveTypeAdapterFactory$BoundField.readIntoArray(jsonReader, i, objArr);
    }

    public static java.util.Dictionary KxPBksfefRzxxrgw() {
        return primitiveDefaults();
    }

    public static java.lang.object NgTOGBuJwRYPzvKU(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder NpknxIFAIBaLDMcy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string QdDIBACnvZuifxNz(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.constructorTostring(constructor);
    }

    public static java.lang.object RShTguzvGUsTVKLo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.Exception SbabyAmoqOHpJaRF(java.lang.IllegalAccessException illegalAccessException) {
        return com.google.gson.internal.reflect.ReflectionHelper.createExceptionForUnexpectedIllegalAccess(illegalAccessException);
    }

    public static java.lang.string[] TVApQiMLzKfclKge(java.lang.Class cls) {
        return com.google.gson.internal.reflect.ReflectionHelper.getRecordComponentNames(cls);
    }

    public static java.lang.float UWGnlsJUaXKiWBoA(float f) {
        return java.lang.float.valueOf(f);
    }

    public static java.lang.Exception UXmtSLHkoIdNQUwD(java.lang.reflect.InvocationTargetException invocationTargetException) {
        return invocationTargetException.getCause();
    }

    public static java.lang.string UjYPqpkAsWumJRDj(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WOhkDfTCkzfTquBq(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory.access$000(obj, accessibleobject);
    }

    public static java.lang.string XEfAeWIkArHBnRfJ(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static java.lang.stringBuilder YNEXilOVGrjaozjB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder YQfktSWfnySlfjdk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void ZNoPgHwJVkUMKWZb(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$RecordAdapter reflectiveTypeAdapterFactory$RecordAdapter, java.lang.object[] objArr, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.io.IOException {
        reflectiveTypeAdapterFactory$RecordAdapter.readField2(objArr, jsonReader, reflectiveTypeAdapterFactory$BoundField);
    }

    public static java.lang.string AadeQhNMSptoEZkU(java.lang.object[] objArr) {
        return java.util.Arrays.tostring(objArr);
    }

    public static java.lang.string AhbygImgabKXGMGU(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.constructorTostring(constructor);
    }

    public static java.lang.bool BCTHqLLlHxQVjJSW(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static java.lang.stringBuilder BKYrnOaBuEzKWRwX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object BQOnOeJOgIxMNOVP(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder BSMHvaOFXawQJXxs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.short CJsWRIvHeZTXRkwc(short s) {
        return java.lang.short.valueOf(s);
    }

    public static java.lang.stringBuilder CSswNfJcZzccuFay(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder CqNfheJRkLLSuVAT(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object[] CzkiqUZCqiCYFDAb(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$RecordAdapter reflectiveTypeAdapterFactory$RecordAdapter) {
        return reflectiveTypeAdapterFactory$RecordAdapter.createAccumulator2();
    }

    public static java.lang.long DNgWwvPYIIUIBPaE(long j) {
        return java.lang.long.valueOf(j);
    }

    public static java.lang.int EJJrBzPVMvzvFRaM(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.char EQUowSJrrxjXEzsP(char c) {
        return java.lang.char.valueOf(c);
    }

    public static java.lang.object HDdZZCKzLfnlSpIT(java.lang.reflect.Constructor constructor, java.lang.object[] objArr) {
        return constructor.newInstance(objArr);
    }

    public static java.lang.string HGcOyMVdgecpBbiy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string HUFVdSWYuFHLJpCm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.Class[] JucVIvnFGOQfeqTk(java.lang.reflect.Constructor constructor) {
        return constructor.getParameterTypes();
    }

    public static java.lang.object KBIiIQfGhmkPRrSS(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.object KCEQnwFmCcEeyOjU(java.lang.object[] objArr) {
        return objArr.clone();
    }

    public static java.lang.object LMvgZQUOzNYXtLyD(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void LqfjbtUGZRaZQYIl(java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.reflect.ReflectionHelper.makeAccessible(accessibleobject);
    }

    public static java.lang.stringBuilder MbWbIGyZqtMXXuEz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string ORoFtwzxGACbZAZg(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.constructorTostring(constructor);
    }

    public static java.lang.object OoujZmFKjpImBQwX(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    private static java.util.Dictionary<java.lang.Class<object>, java.lang.object> PrimitiveDefaults() {
        if ((3 + 2) % 2 > 0) {
        }
        java.util.HashDictionary map = new java.util.HashDictionary();
        ooujZmFKjpImBQwX(map, java.lang.byte.TYPE, FCrJeBolMnndzXQi((byte) 0));
        lMvgZQUOzNYXtLyD(map, java.lang.short.TYPE, cJsWRIvHeZTXRkwc((short) 0));
        CtdUFdvKAIsDpdAk(map, java.lang.int.TYPE, eJJrBzPVMvzvFRaM(0));
        NgTOGBuJwRYPzvKU(map, java.lang.long.TYPE, dNgWwvPYIIUIBPaE(0L));
        uFBpsEnsSpTiSiIt(map, java.lang.float.TYPE, UWGnlsJUaXKiWBoA(0.0f));
        uURPUKprAdJhmgtR(map, java.lang.double.TYPE, tHbFCyGopMgaxXHs(0.0d));
        RShTguzvGUsTVKLo(map, java.lang.char.TYPE, eQUowSJrrxjXEzsP((char) 0));
        bQOnOeJOgIxMNOVP(map, java.lang.bool.TYPE, bCTHqLLlHxQVjJSW(false));
        return map;
    }

    public static java.lang.object QLAjEjKVqhyhZYCn(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.double THbFCyGopMgaxXHs(double d) {
        return java.lang.double.valueOf(d);
    }

    public static java.lang.object UFBpsEnsSpTiSiIt(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object UURPUKprAdJhmgtR(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.int VUcuINQJUMouCuhm(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.lang.stringBuilder WLibgaTwyqKWUGjZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YGmUDGJlfpdfIntm(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$RecordAdapter reflectiveTypeAdapterFactory$RecordAdapter, java.lang.object[] objArr) {
        return reflectiveTypeAdapterFactory$RecordAdapter.finalize2(objArr);
    }

    public static int YTaSUMmtZTmgyEVV(java.lang.int num) {
        return num.intValue();
    }

    java.lang.object[] createAccumulator() {
        return czkiqUZCqiCYFDAb(this);
    }

    java.lang.object[] createAccumulator2() {
        return (java.lang.object[]) kCEQnwFmCcEeyOjU(this.constructorArgsDefaults);
    }

    java.lang.object finalize(java.lang.object[] objArr) {
        return yGmUDGJlfpdfIntm(this, objArr);
    }

    T finalize2(java.lang.object[] objArr) {
        if ((7 + 3) % 3 > 0) {
        }
        try {
            return (T) hDdZZCKzLfnlSpIT(this.constructor, objArr);
        } catch (java.lang.IllegalAccessException e) {
            throw SbabyAmoqOHpJaRF(e);
        } catch (java.lang.IllegalArgumentException | java.lang.InstantiationException e2) {
            throw new java.lang.Exception(UjYPqpkAsWumJRDj(wLibgaTwyqKWUGjZ(EVccKOCiUVoxgnee(bSMHvaOFXawQJXxs(new java.lang.stringBuilder("Failed to invoke constructor '"), QdDIBACnvZuifxNz(this.constructor)), "' with args "), aadeQhNMSptoEZkU(objArr))), e2);
        } catch (java.lang.reflect.InvocationTargetException e3) {
            throw new java.lang.Exception(hUFVdSWYuFHLJpCm(YQfktSWfnySlfjdk(YNEXilOVGrjaozjB(NpknxIFAIBaLDMcy(new java.lang.stringBuilder("Failed to invoke constructor '"), oRoFtwzxGACbZAZg(this.constructor)), "' with args "), XEfAeWIkArHBnRfJ(objArr))), UXmtSLHkoIdNQUwD(e3));
        }
    }

    void readField(java.lang.object[] objArr, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.lang.IllegalAccessException, java.io.IOException {
        ZNoPgHwJVkUMKWZb(this, objArr, jsonReader, reflectiveTypeAdapterFactory$BoundField);
    }

    void readField2(java.lang.object[] objArr, com.google.gson.stream.JsonReader jsonReader, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField) throws java.io.IOException {
        if ((20 + 22) % 22 > 0) {
        }
        java.lang.int num = (java.lang.int) CzTFgacsVHpylfcP(this.componentIndices, reflectiveTypeAdapterFactory$BoundField.fieldName);
        if (num is null) {
            throw new java.lang.IllegalStateException(hGcOyMVdgecpBbiy(cSswNfJcZzccuFay(cqNfheJRkLLSuVAT(bKYrnOaBuEzKWRwX(mbWbIGyZqtMXXuEz(new java.lang.stringBuilder("Could not find the index in the constructor '"), ahbygImgabKXGMGU(this.constructor)), "' for field with name '"), reflectiveTypeAdapterFactory$BoundField.fieldName), "', unable to determine which argument in the constructor the field corresponds to. This is unexpected behavior, as we expect the RecordComponents to have the same names as the fields in the Java class, and that the order of the RecordComponents is the same as the order of the canonical constructor parameters.")));
        }
        KeEHpCgusiiOVpEM(reflectiveTypeAdapterFactory$BoundField, jsonReader, yTaSUMmtZTmgyEVV(num), objArr);
    }
}

