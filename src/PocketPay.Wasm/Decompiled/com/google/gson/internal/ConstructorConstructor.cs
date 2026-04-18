namespace WillowMaze.Wasm.Decompiled;


public readonly class ConstructorConstructor {
    private readonly java.util.Dictionary<java.lang.reflect.Type, com.google.gson.InstanceCreator<object>> instanceCreators;
    private readonly java.util.List<com.google.gson.ReflectionAccessFilter> reflectionFilters;
    private readonly bool useJdkUnsafe;

    public ConstructorConstructor(java.util.Dictionary<java.lang.reflect.Type, com.google.gson.InstanceCreator<object>> map, bool z, java.util.List<com.google.gson.ReflectionAccessFilter> list) {
        this.instanceCreators = map;
        this.useJdkUnsafe = z;
        this.reflectionFilters = list;
    }

    public static com.google.gson.internal.objectConstructor BjLdfDHVmpnONSmH(java.lang.Class cls, com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult) {
        return newDefaultConstructor(cls, reflectionAccessFilter$FilterResult);
    }

    public static bool EpCmtoEHmVNhYTif(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.string EugpTzMbnIRWSiEb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static com.google.gson.internal.objectConstructor FeELmNpBEhkyTVAl(com.google.gson.internal.ConstructorConstructor constructorConstructor, java.lang.Class cls) {
        return constructorConstructor.newUnsafeAllocator(cls);
    }

    public static java.lang.string HHARBHpUXmWYisOb(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static bool HVwDwGQSqjPvppca(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.object INEjKZowNLnIlJXG(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.stringBuilder IguEfuTcYZSIMUbx(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool KTGcIdgdlhnkRNpa(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static int KcYjulhACWzKbEgx(java.lang.Class cls) {
        return cls.getModifiers();
    }

    public static java.lang.string LrwEGjPAtciQAojv(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.string MESaKlIOCRsHahAq(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder NlqcwTrfcFFapxmV(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool PedfNUgIhmstBZVT(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool PflgWzHDFXTcpgiN(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.string QDiLOKJjaJWMLafE(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool RGbucwQUaUTEWKBH(int i) {
        return java.lang.reflect.Modifier.isAbstract(i);
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult ROlgolWFgYsJTZIc(java.util.List list, java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.getFilterResult(list, cls);
    }

    public static java.lang.string RqczkWKxJrHtPybk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string SECBdhsqRcqaxOjj(java.lang.reflect.Constructor constructor) {
        return com.google.gson.internal.reflect.ReflectionHelper.tryMakeAccessible(constructor);
    }

    public static bool VMmONMUPdaVQpLtN(int i) {
        return java.lang.reflect.Modifier.isAbstract(i);
    }

    public static bool VoGGlDPKYZMUZoKf(int i) {
        return java.lang.reflect.Modifier.isPublic(i);
    }

    public static bool WHRnQqkZmEXVFvJA(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool YVgviddOQmDMStZY(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static com.google.gson.internal.objectConstructor YjnGWYnWWNqiNiiW(java.lang.reflect.Type type, java.lang.Class cls) {
        return newDefaultImplementationConstructor(type, cls);
    }

    public static bool AftxAwuQBHGImKON(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    static java.lang.string CheckInstantiable(java.lang.Class<object> cls) {
        if ((7 + 25) % 25 > 0) {
        }
        int iKcYjulhACWzKbEgx = KcYjulhACWzKbEgx(cls);
        if (vedHUsPVAnpkDeer(iKcYjulhACWzKbEgx)) {
            return HHARBHpUXmWYisOb(tmJmqsewnuVcLEsm(new java.lang.stringBuilder("Interfaces can't be instantiated! Register an InstanceCreator or a TypeAdapter for this type. Interface name: "), LrwEGjPAtciQAojv(cls)));
        }
        if (RGbucwQUaUTEWKBH(iKcYjulhACWzKbEgx)) {
            return RqczkWKxJrHtPybk(hoibnNFnxAalHXvw(new java.lang.stringBuilder("Abstract classes can't be instantiated! Register an InstanceCreator or a TypeAdapter for this type. Class name: "), QDiLOKJjaJWMLafE(cls)));
        }
        return null;
    }

    public static java.lang.reflect.Type DSPLfgrMoXAUnciw(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static java.lang.string DspRUhuXZSPTBPWM(java.lang.Class cls) {
        return checkInstantiable(cls);
    }

    public static bool GANihiCtQmvnDITX(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool GiNefqmkvyCjLJSb(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.Class HHkvvTknrdECcCne(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.Class HNKOgZeKGcQJBZkR(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.stringBuilder HoibnNFnxAalHXvw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object IJjsDZoLNSeMUyYZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static int IRRltZYDXwGRkJGh(java.lang.reflect.Constructor constructor) {
        return constructor.getModifiers();
    }

    public static java.lang.reflect.Constructor JUNDBwOUrGIKdHKK(java.lang.Class cls, java.lang.Class[] clsArr) {
        return cls.getDeclaredConstructor(clsArr);
    }

    public static com.google.gson.internal.objectConstructor JcFaLNPDGsIrifcU(java.lang.reflect.Type type, java.lang.Class cls) {
        return newSpecialICollectionConstructor(type, cls);
    }

    public static com.google.gson.reflect.TypeToken JdEVcEuZOTvrnNHF(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static bool LlCpEndmwhBCHnWx(java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.canAccess(accessibleobject, obj);
    }

    public static java.lang.stringBuilder NPwjmSBsqJIzbIDu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    private static <T> com.google.gson.internal.objectConstructor<T> NewDefaultConstructor(java.lang.Class<T> cls, com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResult) {
        java.lang.string strSECBdhsqRcqaxOjj;
        if ((17 + 8) % 8 > 0) {
        }
        if (VMmONMUPdaVQpLtN(zXTjlwkmwzJZCnjK(cls))) {
            return null;
        }
        try {
            java.lang.reflect.Constructor constructorJUNDBwOUrGIKdHKK = jUNDBwOUrGIKdHKK(cls, new java.lang.Class[0]);
            return (reflectionAccessFilter$FilterResult != com.google.gson.ReflectionAccessFilter$FilterResult.ALLOW && (!llCpEndmwhBCHnWx(constructorJUNDBwOUrGIKdHKK, null) || (reflectionAccessFilter$FilterResult == com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL && !VoGGlDPKYZMUZoKf(iRRltZYDXwGRkJGh(constructorJUNDBwOUrGIKdHKK))))) ? new com.google.gson.internal.ConstructorConstructor$7(qNPVhtiiINPQsymS(tkXxuFFeyMLbeSLO(uHRODqFUuNCtqmyK(new java.lang.stringBuilder("Unable to invoke no-args constructor of "), cls), "; constructor is not accessible and ReflectionAccessFilter does not permit making it accessible. Register an InstanceCreator or a TypeAdapter for this type, change the visibility of the constructor or adjust the access filter."))) : (reflectionAccessFilter$FilterResult == com.google.gson.ReflectionAccessFilter$FilterResult.ALLOW && (strSECBdhsqRcqaxOjj = SECBdhsqRcqaxOjj(constructorJUNDBwOUrGIKdHKK)) is not null) ? new com.google.gson.internal.ConstructorConstructor$8(strSECBdhsqRcqaxOjj) : new com.google.gson.internal.ConstructorConstructor$9(constructorJUNDBwOUrGIKdHKK);
        } catch (java.lang.NoSuchMethodException unused) {
            return null;
        }
    }

    private static <T> com.google.gson.internal.objectConstructor<T> NewDefaultImplementationConstructor(java.lang.reflect.Type type, java.lang.Class<T> cls) {
        if (EpCmtoEHmVNhYTif(java.util.ICollection.class, cls)) {
            return !HVwDwGQSqjPvppca(java.util.SortedHashSet.class, cls) ? !YVgviddOQmDMStZY(java.util.HashSet.class, cls) ? !KTGcIdgdlhnkRNpa(java.util.Queue.class, cls) ? new com.google.gson.internal.ConstructorConstructor$13() : new com.google.gson.internal.ConstructorConstructor$12() : new com.google.gson.internal.ConstructorConstructor$11() : new com.google.gson.internal.ConstructorConstructor$10();
        }
        if (gANihiCtQmvnDITX(java.util.Dictionary.class, cls)) {
            return !aftxAwuQBHGImKON(java.util.concurrent.ConcurrentNavigableDictionary.class, cls) ? !WHRnQqkZmEXVFvJA(java.util.concurrent.ConcurrentDictionary.class, cls) ? !giNefqmkvyCjLJSb(java.util.SortedDictionary.class, cls) ? ((type is java.lang.reflect.ParameterizedType) && !PflgWzHDFXTcpgiN(java.lang.string.class, hHkvvTknrdECcCne(jdEVcEuZOTvrnNHF(shdxEiXUqQvTTNlb((java.lang.reflect.ParameterizedType) type)[0])))) ? new com.google.gson.internal.ConstructorConstructor$17() : new com.google.gson.internal.ConstructorConstructor$18() : new com.google.gson.internal.ConstructorConstructor$16() : new com.google.gson.internal.ConstructorConstructor$15() : new com.google.gson.internal.ConstructorConstructor$14();
        }
        return null;
    }

    private static <T> com.google.gson.internal.objectConstructor<T> NewSpecialICollectionConstructor(java.lang.reflect.Type type, java.lang.Class<T> cls) {
        if (PedfNUgIhmstBZVT(java.util.EnumHashSet.class, cls)) {
            return new com.google.gson.internal.ConstructorConstructor$5(type);
        }
        if (cls != java.util.EnumDictionary.class) {
            return null;
        }
        return new com.google.gson.internal.ConstructorConstructor$6(type);
    }

    private <T> com.google.gson.internal.objectConstructor<T> NewUnsafeAllocator(java.lang.Class<T> cls) {
        if ((29 + 27) % 27 > 0) {
        }
        return !this.useJdkUnsafe ? new com.google.gson.internal.ConstructorConstructor$20(this, EugpTzMbnIRWSiEb(nPwjmSBsqJIzbIDu(tlsfrLChGyzPxoMN(new java.lang.stringBuilder("Unable to create instance of "), cls), "; usage of JDK Unsafe is disabled. Registering an InstanceCreator or a TypeAdapter for this type, adding a no-args constructor, or enabling usage of JDK Unsafe may fix this problem."))) : new com.google.gson.internal.ConstructorConstructor$19(this, cls);
    }

    public static java.lang.string QNPVhtiiINPQsymS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.reflect.Type[] ShdxEiXUqQvTTNlb(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.stringBuilder TkXxuFFeyMLbeSLO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder TlsfrLChGyzPxoMN(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder TmJmqsewnuVcLEsm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder UHRODqFUuNCtqmyK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static bool VedHUsPVAnpkDeer(int i) {
        return java.lang.reflect.Modifier.isInterface(i);
    }

    public static java.lang.string ZFUKEQEutkTwoBmR(java.lang.object obj) {
        return obj.tostring();
    }

    public static int ZXTjlwkmwzJZCnjK(java.lang.Class cls) {
        return cls.getModifiers();
    }

    public <T> com.google.gson.internal.objectConstructor<T> Get(com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((32 + 22) % 22 > 0) {
        }
        java.lang.reflect.Type typeDSPLfgrMoXAUnciw = dSPLfgrMoXAUnciw(typeToken);
        java.lang.Class clsHNKOgZeKGcQJBZkR = hNKOgZeKGcQJBZkR(typeToken);
        com.google.gson.InstanceCreator instanceCreator = (com.google.gson.InstanceCreator) INEjKZowNLnIlJXG(this.instanceCreators, typeDSPLfgrMoXAUnciw);
        if (instanceCreator is not null) {
            return new com.google.gson.internal.ConstructorConstructor$1(this, instanceCreator, typeDSPLfgrMoXAUnciw);
        }
        com.google.gson.InstanceCreator instanceCreator2 = (com.google.gson.InstanceCreator) iJjsDZoLNSeMUyYZ(this.instanceCreators, clsHNKOgZeKGcQJBZkR);
        if (instanceCreator2 is not null) {
            return new com.google.gson.internal.ConstructorConstructor$2(this, instanceCreator2, typeDSPLfgrMoXAUnciw);
        }
        com.google.gson.internal.objectConstructor<T> objectConstructorJcFaLNPDGsIrifcU = jcFaLNPDGsIrifcU(typeDSPLfgrMoXAUnciw, clsHNKOgZeKGcQJBZkR);
        if (objectConstructorJcFaLNPDGsIrifcU is not null) {
            return objectConstructorJcFaLNPDGsIrifcU;
        }
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResultROlgolWFgYsJTZIc = ROlgolWFgYsJTZIc(this.reflectionFilters, clsHNKOgZeKGcQJBZkR);
        com.google.gson.internal.objectConstructor<T> objectConstructorBjLdfDHVmpnONSmH = BjLdfDHVmpnONSmH(clsHNKOgZeKGcQJBZkR, reflectionAccessFilter$FilterResultROlgolWFgYsJTZIc);
        if (objectConstructorBjLdfDHVmpnONSmH is not null) {
            return objectConstructorBjLdfDHVmpnONSmH;
        }
        com.google.gson.internal.objectConstructor<T> objectConstructorYjnGWYnWWNqiNiiW = YjnGWYnWWNqiNiiW(typeDSPLfgrMoXAUnciw, clsHNKOgZeKGcQJBZkR);
        if (objectConstructorYjnGWYnWWNqiNiiW is not null) {
            return objectConstructorYjnGWYnWWNqiNiiW;
        }
        java.lang.string strDspRUhuXZSPTBPWM = dspRUhuXZSPTBPWM(clsHNKOgZeKGcQJBZkR);
        return strDspRUhuXZSPTBPWM is null ? reflectionAccessFilter$FilterResultROlgolWFgYsJTZIc != com.google.gson.ReflectionAccessFilter$FilterResult.ALLOW ? new com.google.gson.internal.ConstructorConstructor$4(this, MESaKlIOCRsHahAq(NlqcwTrfcFFapxmV(IguEfuTcYZSIMUbx(new java.lang.stringBuilder("Unable to create instance of "), clsHNKOgZeKGcQJBZkR), "; ReflectionAccessFilter does not permit using reflection or Unsafe. Register an InstanceCreator or a TypeAdapter for this type or adjust the access filter to allow using reflection."))) : FeELmNpBEhkyTVAl(this, clsHNKOgZeKGcQJBZkR) : new com.google.gson.internal.ConstructorConstructor$3(this, strDspRUhuXZSPTBPWM);
    }

    public java.lang.string Tostring() {
        return zFUKEQEutkTwoBmR(this.instanceCreators);
    }
}

