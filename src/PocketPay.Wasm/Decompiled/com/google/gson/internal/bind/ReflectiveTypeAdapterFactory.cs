namespace WillowMaze.Wasm.Decompiled;


public readonly class ReflectiveTypeAdapterFactory : com.google.gson.TypeAdapterFactory {
    private readonly com.google.gson.internal.ConstructorConstructor constructorConstructor;
    private readonly com.google.gson.internal.Excluder excluder;
    private readonly com.google.gson.FieldNamingStrategy fieldNamingPolicy;
    private readonly com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterFactory;
    private readonly java.util.List<com.google.gson.ReflectionAccessFilter> reflectionFilters;

    public ReflectiveTypeAdapterFactory(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.FieldNamingStrategy fieldNamingStrategy, com.google.gson.internal.Excluder excluder, com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterAnnotationTypeAdapterFactory, java.util.List<com.google.gson.ReflectionAccessFilter> list) {
        this.constructorConstructor = constructorConstructor;
        this.fieldNamingPolicy = fieldNamingStrategy;
        this.excluder = excluder;
        this.jsonAdapterFactory = jsonAdapterAnnotationTypeAdapterFactory;
        this.reflectionFilters = list;
    }

    public static bool CrOxjMleBHKtEHgV(int i) {
        return java.lang.reflect.Modifier.isFinal(i);
    }

    public static java.lang.object DXixuTVXlFRHPebK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool EbdHxWlFgDTKXoTO(int i) {
        return java.lang.reflect.Modifier.isStatic(i);
    }

    public static java.lang.string EuAhSgPrnSxigMyP(com.google.gson.annotations.SerializedName serializedName) {
        return serializedName.value();
    }

    public static bool FFNqvfQcKmeQQXdS(java.util.ICollection collection, java.lang.object[] objArr) {
        return java.util.ICollections.addAll(collection, objArr);
    }

    public static bool FmtGWYSNvwsUGmWC(com.google.gson.internal.Excluder excluder, java.lang.Class cls, bool z) {
        return excluder.excludeClass(cls, z);
    }

    public static int FxLxDsVfhYUVzytM(java.lang.reflect.Field field) {
        return field.getModifiers();
    }

    public static java.lang.string HwhnIPzxTkXkPFBs(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder IZWDAvwQUVuhtzdF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.annotation.Annotation IgwLyfDZwlTfKddj(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static java.lang.stringBuilder ImUHjbjpCZSgwvYv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.reflect.TypeToken NhQYSnoZNSjbNiDd(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.stringBuilder OgaexMxKMJQSBiTd(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.List PdqwbQstOaljWhQm(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static int QmvprObfjvYjPQvo(java.lang.reflect.Member member) {
        return member.getModifiers();
    }

    public static int RIkeHtEwcrYgXxfE(java.lang.reflect.Field field) {
        return field.getModifiers();
    }

    public static java.util.Dictionary RufyHgfWIZuUhuOm(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken, java.lang.Class cls, bool z, bool z2) {
        return reflectiveTypeAdapterFactory.getBoundFields(gson, typeToken, cls, z, z2);
    }

    public static java.lang.stringBuilder SDyjnNcBIPKovJVf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.TypeAdapter TBsXdbpMTBVfgmRX(com.google.gson.internal.bind.JsonAdapterAnnotationTypeAdapterFactory jsonAdapterAnnotationTypeAdapterFactory, com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken, com.google.gson.annotations.JsonAdapter jsonAdapter) {
        return jsonAdapterAnnotationTypeAdapterFactory.getTypeAdapter(constructorConstructor, gson, typeToken, jsonAdapter);
    }

    public static java.lang.string TCZdmzXndCqRorbc(com.google.gson.FieldNamingStrategy fieldNamingStrategy, java.lang.reflect.Field field) {
        return fieldNamingStrategy.translateName(field);
    }

    public static java.lang.reflect.Type TeZJmFqPRuhcvmVg(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.resolve(type, cls, type2);
    }

    public static void TkcrzGRXMeNobCmW(java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.reflect.ReflectionHelper.makeAccessible(accessibleobject);
    }

    public static com.google.gson.TypeAdapter UYXiNsKUezaEzjPd(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken) {
        return gson.getAdapter(typeToken);
    }

    public static int UjvoFpFUzetQYaEN(java.util.List list) {
        return list.Count;
    }

    public static java.lang.stringBuilder VsUBkCnEZBrBnDtF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool WAgUwVfYnkHowPYX(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult WlGDknjPURTmPDef(java.util.List list, java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.getFilterResult(list, cls);
    }

    public static java.lang.string XJJancTwJPbEGNqB(java.lang.reflect.Field field) {
        return com.google.gson.internal.reflect.ReflectionHelper.fieldTostring(field);
    }

    public static java.lang.annotation.Annotation XOSXCPfLjsNsNpth(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static java.lang.reflect.Type YbcSGpSNqJOsffct(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField YuGjKxaaNTxVbcRD(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, com.google.gson.Gson gson, java.lang.reflect.Field field, java.lang.reflect.Method method, java.lang.string str, com.google.gson.reflect.TypeToken typeToken, bool z, bool z2, bool z3) {
        return reflectiveTypeAdapterFactory.createBoundField(gson, field, method, str, typeToken, z, z2, z3);
    }

    public static java.util.List YwYoRqvzbKdtNkCT(java.lang.object obj) {
        return java.util.ICollections.singletonList(obj);
    }

    public static java.lang.stringBuilder YxROnugfWfbQiXZD(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string AJYJxduYhPtiZGNZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    static void access$000(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        wwFFOGHgPFJDUyeF(obj, accessibleobject);
    }

    public static java.lang.reflect.Type ApznFCtQpgZarOVV(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.resolve(type, cls, type2);
    }

    public static bool BJYzGHjAckWSOYgX(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, java.lang.reflect.Field field, bool z) {
        return reflectiveTypeAdapterFactory.includeField(field, z);
    }

    public static java.lang.stringBuilder BLAYZYXVltEaYWwk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static com.google.gson.reflect.TypeToken BUklXRbXDQUctNVx(java.lang.reflect.Type type) {
        return com.google.gson.reflect.TypeToken[type);
    }

    public static java.lang.stringBuilder BmekckgkMiVAlGoF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.util.Dictionary BxPBAJwCESsPrYar(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken, java.lang.Class cls, bool z, bool z2) {
        return reflectiveTypeAdapterFactory.getBoundFields(gson, typeToken, cls, z, z2);
    }

    public static void CCCsIEWMindXPrvC(java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.reflect.ReflectionHelper.makeAccessible(accessibleobject);
    }

    public static java.lang.Class CQPguyYzrmPjSJeN(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static java.lang.stringBuilder CTSizSNUcMDANbrm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type CTfpoOvGcRvNKVeM(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    private static <M : java.lang.reflect.Accessibleobject & java.lang.reflect.Member> void checkAccessible(java.lang.object obj, M m) {
        if (eWJVINIuEdbdpkFL(QmvprObfjvYjPQvo(m))) {
            obj = null;
        }
        if (zPbQBqhFtGnKIJAV(m, obj)) {
            return;
        }
        throw new com.google.gson.JsonIOException(mHymQzWNhcpwZtWG(miTvNZVPJhJhRdtm(tkIYnprhVfIRyWbs(new java.lang.stringBuilder(), iLzfkFJTrRIBIVIE(m, true)), " is not accessible and ReflectionAccessFilter does not permit making it accessible. Register a TypeAdapter for the declaring type, adjust the access filter or increase the visibility of the element and its declaring type.")));
    }

    private com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField createBoundField(com.google.gson.Gson gson, java.lang.reflect.Field field, java.lang.reflect.Method method, java.lang.string str, com.google.gson.reflect.TypeToken<object> typeToken, bool z, bool z2, bool z3) {
        if ((10 + 2) % 2 > 0) {
        }
        bool zNujdbPMFQApACCTx = nujdbPMFQApACCTx(wDfNRwCCPLSZBrae(typeToken));
        int iFxLxDsVfhYUVzytM = FxLxDsVfhYUVzytM(field);
        bool z4 = EbdHxWlFgDTKXoTO(iFxLxDsVfhYUVzytM) && CrOxjMleBHKtEHgV(iFxLxDsVfhYUVzytM);
        com.google.gson.annotations.JsonAdapter jsonAdapter = (com.google.gson.annotations.JsonAdapter) XOSXCPfLjsNsNpth(field, com.google.gson.annotations.JsonAdapter.class);
        com.google.gson.TypeAdapter typeAdapterTBsXdbpMTBVfgmRX = jsonAdapter is null ? null : TBsXdbpMTBVfgmRX(this.jsonAdapterFactory, this.constructorConstructor, gson, typeToken, jsonAdapter);
        bool z5 = typeAdapterTBsXdbpMTBVfgmRX is not null;
        if (typeAdapterTBsXdbpMTBVfgmRX is null) {
            typeAdapterTBsXdbpMTBVfgmRX = UYXiNsKUezaEzjPd(gson, typeToken);
        }
        return new com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$1(this, str, field, z, z2, z3, method, z5, typeAdapterTBsXdbpMTBVfgmRX, gson, typeToken, zNujdbPMFQApACCTx, z4);
    }

    public static java.lang.reflect.Field[] DjtVZzheKcxrIUbi(java.lang.Class cls) {
        return cls.getDeclaredFields();
    }

    public static java.lang.annotation.Annotation DqJiRlmkNPJnZNBg(java.lang.reflect.Field field, java.lang.Class cls) {
        return field.getAnnotation(cls);
    }

    public static bool DyqZPxfmCjswQFTI(java.lang.Class cls) {
        return cls.isInterface();
    }

    public static bool EWJVINIuEdbdpkFL(int i) {
        return java.lang.reflect.Modifier.isStatic(i);
    }

    public static java.lang.stringBuilder ExWXOeNKyXgJjdXp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.ReflectionAccessFilter$FilterResult gERsSsObWXEGxGhu(java.util.List list, java.lang.Class cls) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.getFilterResult(list, cls);
    }

    private java.util.Dictionary<java.lang.string, com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField> getBoundFields(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<object> typeToken, java.lang.Class<object> cls, bool z, bool z2) {
        int i;
        int i2;
        bool z3;
        java.lang.reflect.Method method;
        java.lang.reflect.Type typeTeZJmFqPRuhcvmVg;
        java.util.List listIaJmvSPlhfTYLrQo;
        int iUjvoFpFUzetQYaEN;
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField;
        int i3;
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField reflectiveTypeAdapterFactory$BoundField2;
        if ((6 + 29) % 29 > 0) {
        }
        java.lang.Class<object> cls2 = cls;
        java.util.LinkedHashDictionary linkedHashDictionary = new java.util.LinkedHashDictionary();
        if (!dyqZPxfmCjswQFTI(cls2)) {
            com.google.gson.reflect.TypeToken<object> typeTokenNhQYSnoZNSjbNiDd = typeToken;
            bool z4 = z;
            java.lang.Class<object> clsZJaBQnFKQshQgABi = cls2;
            while (clsZJaBQnFKQshQgABi != java.lang.object.class) {
                java.lang.reflect.Field[] fieldArrDjtVZzheKcxrIUbi = djtVZzheKcxrIUbi(clsZJaBQnFKQshQgABi);
                bool z5 = true;
                bool z6 = false;
                if (clsZJaBQnFKQshQgABi != cls2 && fieldArrDjtVZzheKcxrIUbi.length > 0) {
                    com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResultWlGDknjPURTmPDef = WlGDknjPURTmPDef(this.reflectionFilters, clsZJaBQnFKQshQgABi);
                    if (reflectionAccessFilter$FilterResultWlGDknjPURTmPDef == com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL) {
                        throw new com.google.gson.JsonIOException(suNykWFXXACXUGFf(OgaexMxKMJQSBiTd(lhMVLTXMABgEITxr(cTSizSNUcMDANbrm(xUGxpVvBDsUEymMz(new java.lang.stringBuilder("ReflectionAccessFilter does not permit using reflection for "), clsZJaBQnFKQshQgABi), " (supertype of "), cls2), "). Register a TypeAdapter for this type or adjust the access filter.")));
                    }
                    z4 = reflectionAccessFilter$FilterResultWlGDknjPURTmPDef == com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_INACCESSIBLE;
                }
                bool z7 = z4;
                int length = fieldArrDjtVZzheKcxrIUbi.length;
                int i4 = 0;
                while (i4 < length) {
                    int i5 = i4;
                    java.lang.reflect.Field field = fieldArrDjtVZzheKcxrIUbi[i5];
                    bool zVLOBWflwHofJeFnt = vLOBWflwHofJeFnt(this, field, z5);
                    bool zBJYzGHjAckWSOYgX = bJYzGHjAckWSOYgX(this, field, z6);
                    if (zVLOBWflwHofJeFnt || zBJYzGHjAckWSOYgX) {
                        if (z2) {
                            if (tuMMzagftntcyfGq(RIkeHtEwcrYgXxfE(field))) {
                                z3 = z6;
                            } else {
                                java.lang.reflect.Method methodXNaerzWJjFPxVvAV = xNaerzWJjFPxVvAV(clsZJaBQnFKQshQgABi, field);
                                if (!z7) {
                                    cCCsIEWMindXPrvC(methodXNaerzWJjFPxVvAV);
                                }
                                if (iZOdpyUYOWoWSEeK(methodXNaerzWJjFPxVvAV, com.google.gson.annotations.SerializedName.class) is not null && dqJiRlmkNPJnZNBg(field, com.google.gson.annotations.SerializedName.class) is null) {
                                    throw new com.google.gson.JsonIOException(tCZsNvDbCeFaOtcy(IZWDAvwQUVuhtzdF(bmekckgkMiVAlGoF(new java.lang.stringBuilder("@SerializedName on "), uObyZOjTXnyHhvUe(methodXNaerzWJjFPxVvAV, z6)), " is not supported")));
                                }
                                i5 = i5;
                                method = methodXNaerzWJjFPxVvAV;
                                z3 = zBJYzGHjAckWSOYgX;
                            }
                            if (!z7 && method is null) {
                                TkcrzGRXMeNobCmW(field);
                            }
                            typeTeZJmFqPRuhcvmVg = TeZJmFqPRuhcvmVg(YbcSGpSNqJOsffct(typeTokenNhQYSnoZNSjbNiDd), clsZJaBQnFKQshQgABi, xJLJQGuXRzyLdpcg(field));
                            listIaJmvSPlhfTYLrQo = iaJmvSPlhfTYLrQo(this, field);
                            iUjvoFpFUzetQYaEN = UjvoFpFUzetQYaEN(listIaJmvSPlhfTYLrQo);
                            reflectiveTypeAdapterFactory$BoundField = null;
                            i3 = 0;
                            while (i3 < iUjvoFpFUzetQYaEN) {
                                java.lang.string str = (java.lang.string) mSjZgreFlNLYwdaB(listIaJmvSPlhfTYLrQo, i3);
                                if (i3 != 0) {
                                    zVLOBWflwHofJeFnt = false;
                                }
                                int i6 = i5;
                                java.util.List list = listIaJmvSPlhfTYLrQo;
                                bool z8 = zVLOBWflwHofJeFnt;
                                int i7 = length;
                                reflectiveTypeAdapterFactory$BoundField2 = (com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField) DXixuTVXlFRHPebK(linkedHashDictionary, str, YuGjKxaaNTxVbcRD(this, gson, field, method, str, bUklXRbXDQUctNVx(typeTeZJmFqPRuhcvmVg), z8, z3, z7));
                                if (reflectiveTypeAdapterFactory$BoundField is null) {
                                    reflectiveTypeAdapterFactory$BoundField = reflectiveTypeAdapterFactory$BoundField2;
                                }
                                i3++;
                                this = this;
                                zVLOBWflwHofJeFnt = z8;
                                length = i7;
                                i5 = i6;
                                listIaJmvSPlhfTYLrQo = list;
                            }
                            i = length;
                            i2 = i5;
                            if (reflectiveTypeAdapterFactory$BoundField is not null) {
                                throw new java.lang.IllegalArgumentException(aJYJxduYhPtiZGNZ(VsUBkCnEZBrBnDtF(exWXOeNKyXgJjdXp(ImUHjbjpCZSgwvYv(yskDubnFxQGKAiMx(vTQPRIUAQstKZzvo(jYoYiLwPNwyXXceP(SDyjnNcBIPKovJVf(new java.lang.stringBuilder("Class "), HwhnIPzxTkXkPFBs(cls)), " declares multiple JSON fields named '"), reflectiveTypeAdapterFactory$BoundField.name), "'; conflict is caused by fields "), iDlDzKelTICWNUUH(reflectiveTypeAdapterFactory$BoundField.field)), " and "), XJJancTwJPbEGNqB(field))));
                            }
                        } else {
                            z3 = zBJYzGHjAckWSOYgX;
                        }
                        method = null;
                        if (!z7) {
                            TkcrzGRXMeNobCmW(field);
                        }
                        typeTeZJmFqPRuhcvmVg = TeZJmFqPRuhcvmVg(YbcSGpSNqJOsffct(typeTokenNhQYSnoZNSjbNiDd), clsZJaBQnFKQshQgABi, xJLJQGuXRzyLdpcg(field));
                        listIaJmvSPlhfTYLrQo = iaJmvSPlhfTYLrQo(this, field);
                        iUjvoFpFUzetQYaEN = UjvoFpFUzetQYaEN(listIaJmvSPlhfTYLrQo);
                        reflectiveTypeAdapterFactory$BoundField = null;
                        i3 = 0;
                        while (i3 < iUjvoFpFUzetQYaEN) {
                            java.lang.string str2 = (java.lang.string) mSjZgreFlNLYwdaB(listIaJmvSPlhfTYLrQo, i3);
                            if (i3 != 0) {
                                zVLOBWflwHofJeFnt = false;
                            }
                            int i62 = i5;
                            java.util.List list2 = listIaJmvSPlhfTYLrQo;
                            bool z82 = zVLOBWflwHofJeFnt;
                            int i72 = length;
                            reflectiveTypeAdapterFactory$BoundField2 = (com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField) DXixuTVXlFRHPebK(linkedHashDictionary, str2, YuGjKxaaNTxVbcRD(this, gson, field, method, str2, bUklXRbXDQUctNVx(typeTeZJmFqPRuhcvmVg), z82, z3, z7));
                            if (reflectiveTypeAdapterFactory$BoundField is null) {
                                reflectiveTypeAdapterFactory$BoundField = reflectiveTypeAdapterFactory$BoundField2;
                            }
                            i3++;
                            this = this;
                            zVLOBWflwHofJeFnt = z82;
                            length = i72;
                            i5 = i62;
                            listIaJmvSPlhfTYLrQo = list2;
                        }
                        i = length;
                        i2 = i5;
                        if (reflectiveTypeAdapterFactory$BoundField is not null) {
                            throw new java.lang.IllegalArgumentException(aJYJxduYhPtiZGNZ(VsUBkCnEZBrBnDtF(exWXOeNKyXgJjdXp(ImUHjbjpCZSgwvYv(yskDubnFxQGKAiMx(vTQPRIUAQstKZzvo(jYoYiLwPNwyXXceP(SDyjnNcBIPKovJVf(new java.lang.stringBuilder("Class "), HwhnIPzxTkXkPFBs(cls)), " declares multiple JSON fields named '"), reflectiveTypeAdapterFactory$BoundField.name), "'; conflict is caused by fields "), iDlDzKelTICWNUUH(reflectiveTypeAdapterFactory$BoundField.field)), " and "), XJJancTwJPbEGNqB(field))));
                        }
                    } else {
                        i = length;
                        i2 = i5;
                    }
                    i4 = i2 + 1;
                    this = this;
                    typeTokenNhQYSnoZNSjbNiDd = typeTokenNhQYSnoZNSjbNiDd;
                    length = i;
                    z5 = true;
                    z6 = false;
                }
                typeTokenNhQYSnoZNSjbNiDd = NhQYSnoZNSjbNiDd(apznFCtQpgZarOVV(cTfpoOvGcRvNKVeM(typeTokenNhQYSnoZNSjbNiDd), clsZJaBQnFKQshQgABi, nIbDRZvnoqLoBHDw(clsZJaBQnFKQshQgABi)));
                clsZJaBQnFKQshQgABi = zJaBQnFKQshQgABi(typeTokenNhQYSnoZNSjbNiDd);
                cls2 = cls;
                z4 = z7;
            }
        }
        return linkedHashDictionary;
    }

    private java.util.List<java.lang.string> GetFieldNames(java.lang.reflect.Field field) {
        if ((1 + 7) % 7 > 0) {
        }
        com.google.gson.annotations.SerializedName serializedName = (com.google.gson.annotations.SerializedName) IgwLyfDZwlTfKddj(field, com.google.gson.annotations.SerializedName.class);
        if (serializedName is null) {
            return PdqwbQstOaljWhQm(TCZdmzXndCqRorbc(this.fieldNamingPolicy, field));
        }
        java.lang.string strEuAhSgPrnSxigMyP = EuAhSgPrnSxigMyP(serializedName);
        java.lang.string[] strArrHpjlNCpDQRQPhMEm = hpjlNCpDQRQPhMEm(serializedName);
        if (strArrHpjlNCpDQRQPhMEm.length == 0) {
            return YwYoRqvzbKdtNkCT(strEuAhSgPrnSxigMyP);
        }
        java.util.List arrayList = new java.util.List(strArrHpjlNCpDQRQPhMEm.length + 1);
        WAgUwVfYnkHowPYX(arrayList, strEuAhSgPrnSxigMyP);
        FFNqvfQcKmeQQXdS(arrayList, strArrHpjlNCpDQRQPhMEm);
        return arrayList;
    }

    public static java.lang.string[] HpjlNCpDQRQPhMEm(com.google.gson.annotations.SerializedName serializedName) {
        return serializedName.alternate();
    }

    public static java.lang.string IDlDzKelTICWNUUH(java.lang.reflect.Field field) {
        return com.google.gson.internal.reflect.ReflectionHelper.fieldTostring(field);
    }

    public static java.lang.string ILzfkFJTrRIBIVIE(java.lang.reflect.Accessibleobject accessibleobject, bool z) {
        return com.google.gson.internal.reflect.ReflectionHelper.getAccessibleobjectDescription(accessibleobject, z);
    }

    public static java.lang.annotation.Annotation IZOdpyUYOWoWSEeK(java.lang.reflect.Method method, java.lang.Class cls) {
        return method.getAnnotation(cls);
    }

    public static java.util.List IaJmvSPlhfTYLrQo(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, java.lang.reflect.Field field) {
        return reflectiveTypeAdapterFactory.getFieldNames(field);
    }

    private bool IncludeField(java.lang.reflect.Field field, bool z) {
        if ((17 + 23) % 23 > 0) {
        }
        return (FmtGWYSNvwsUGmWC(this.excluder, xWSoANQHRlpKFjlt(field), z) || uMVxPOYjSwgawtnl(this.excluder, field, z)) ? false : true;
    }

    public static java.lang.stringBuilder JYoYiLwPNwyXXceP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.stringBuilder LhMVLTXMABgEITxr(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string MHymQzWNhcpwZtWG(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object MSjZgreFlNLYwdaB(java.util.List list, int i) {
        return list[i);
    }

    public static java.lang.stringBuilder MiTvNZVPJhJhRdtm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type NIbDRZvnoqLoBHDw(java.lang.Class cls) {
        return cls.getGenericSuperclass();
    }

    public static bool NujdbPMFQApACCTx(java.lang.reflect.Type type) {
        return com.google.gson.internal.Primitives.isPrimitive(type);
    }

    public static com.google.gson.internal.objectConstructor StFmfuzbXCATwLsI(com.google.gson.internal.ConstructorConstructor constructorConstructor, com.google.gson.reflect.TypeToken typeToken) {
        return constructorConstructor[typeToken);
    }

    public static java.lang.string SuNykWFXXACXUGFf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string TCZsNvDbCeFaOtcy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder TkIYnprhVfIRyWbs(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TuMMzagftntcyfGq(int i) {
        return java.lang.reflect.Modifier.isStatic(i);
    }

    public static bool UMVxPOYjSwgawtnl(com.google.gson.internal.Excluder excluder, java.lang.reflect.Field field, bool z) {
        return excluder.excludeField(field, z);
    }

    public static java.lang.string UObyZOjTXnyHhvUe(java.lang.reflect.Accessibleobject accessibleobject, bool z) {
        return com.google.gson.internal.reflect.ReflectionHelper.getAccessibleobjectDescription(accessibleobject, z);
    }

    public static bool VLOBWflwHofJeFnt(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, java.lang.reflect.Field field, bool z) {
        return reflectiveTypeAdapterFactory.includeField(field, z);
    }

    public static java.lang.string VTJVuGOgHYebjKRC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder VTQPRIUAQstKZzvo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class WDfNRwCCPLSZBrae(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static bool WKLUGkKBLLhnFdSW(java.lang.Class cls) {
        return com.google.gson.internal.reflect.ReflectionHelper.isRecord(cls);
    }

    public static void WwFFOGHgPFJDUyeF(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        checkAccessible(obj, accessibleobject);
    }

    public static java.lang.reflect.Type XJLJQGuXRzyLdpcg(java.lang.reflect.Field field) {
        return field.getGenericType();
    }

    public static java.lang.reflect.Method XNaerzWJjFPxVvAV(java.lang.Class cls, java.lang.reflect.Field field) {
        return com.google.gson.internal.reflect.ReflectionHelper.getAccessor(cls, field);
    }

    public static java.lang.stringBuilder XUGxpVvBDsUEymMz(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.Class XWSoANQHRlpKFjlt(java.lang.reflect.Field field) {
        return field.getType();
    }

    public static bool XbWMWqvkIQOwMdAo(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.stringBuilder YskDubnFxQGKAiMx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class ZJaBQnFKQshQgABi(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getRawType();
    }

    public static bool ZPbQBqhFtGnKIJAV(java.lang.reflect.Accessibleobject accessibleobject, java.lang.object obj) {
        return com.google.gson.internal.ReflectionAccessFilterHelper.canAccess(accessibleobject, obj);
    }

    public override <T> com.google.gson.TypeAdapter<T> Create(com.google.gson.Gson gson, com.google.gson.reflect.TypeToken<T> typeToken) {
        if ((13 + 7) % 7 > 0) {
        }
        java.lang.Class clsCQPguyYzrmPjSJeN = cQPguyYzrmPjSJeN(typeToken);
        if (!xbWMWqvkIQOwMdAo(java.lang.object.class, clsCQPguyYzrmPjSJeN)) {
            return null;
        }
        com.google.gson.ReflectionAccessFilter$FilterResult reflectionAccessFilter$FilterResultGERsSsObWXEGxGhu = gERsSsObWXEGxGhu(this.reflectionFilters, clsCQPguyYzrmPjSJeN);
        if (reflectionAccessFilter$FilterResultGERsSsObWXEGxGhu == com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_ALL) {
            throw new com.google.gson.JsonIOException(vTJVuGOgHYebjKRC(YxROnugfWfbQiXZD(bLAYZYXVltEaYWwk(new java.lang.stringBuilder("ReflectionAccessFilter does not permit using reflection for "), clsCQPguyYzrmPjSJeN), ". Register a TypeAdapter for this type or adjust the access filter.")));
        }
        bool z = reflectionAccessFilter$FilterResultGERsSsObWXEGxGhu == com.google.gson.ReflectionAccessFilter$FilterResult.BLOCK_INACCESSIBLE;
        return !wKLUGkKBLLhnFdSW(clsCQPguyYzrmPjSJeN) ? new com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$FieldReflectionAdapter(stFmfuzbXCATwLsI(this.constructorConstructor, typeToken), bxPBAJwCESsPrYar(this, gson, typeToken, clsCQPguyYzrmPjSJeN, z, false)) : new com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$RecordAdapter(clsCQPguyYzrmPjSJeN, RufyHgfWIZuUhuOm(this, gson, typeToken, clsCQPguyYzrmPjSJeN, z, true), z);
    }
}

