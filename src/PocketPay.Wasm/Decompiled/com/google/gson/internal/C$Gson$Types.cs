namespace WillowMaze.Wasm.Decompiled;


public readonly class C$Gson$Types {
    static readonly bool $assertionsDisabled = false;
    static readonly java.lang.reflect.Type[] EMPTY_TYPE_ARRAY = new java.lang.reflect.Type[0];

    private C$Gson$Types() {
        throw new java.lang.UnsupportedOperationException();
    }

    public static bool BKkDHpdThcxmRlat(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.reflect.Type[] BLcZcbANbiIRvTqX(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static bool BRbkFyOcsyXcyTXb(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.reflect.Type[] BZVAerMGoJQLorfY(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static bool BbhOUCOlMwnpxiSJ(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.reflect.WildcardType BcgrsBwULEovQStw(java.lang.reflect.Type type) {
        return subtypeOf(type);
    }

    public static java.lang.string ByISlnKnYtPMBAbz(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.reflect.Type CCdzEZQebNrUChbD(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getSupertype(type, cls, cls2);
    }

    public static java.lang.Class[] CToCZChNgjbkGXHV(java.lang.Class cls) {
        return cls.getInterfaces();
    }

    public static java.lang.reflect.Type DAWqulAaxYuZmJZX(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static java.lang.reflect.Type DDImOLPsXSBuYvPC(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getGenericSupertype(type, cls, cls2);
    }

    public static java.lang.string DdWvpOEqmiiwnDgU(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.Class ETNrsUlymTemyidg(java.lang.Class cls) {
        return cls.getSuperclass();
    }

    public static java.lang.reflect.Type EfvNPMXkzgzwHvak(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static java.lang.stringBuilder FTDquJJNjNlrETiW(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.reflect.Type GZShnVMkbcThlAQW(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.GenericDeclaration GgZbYzArTjQKvKCn(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getGenericDeclaration();
    }

    public static java.lang.reflect.Type[] GuNIKYwvqMxRfGFR(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.Class HIKunCHWSvTteyNW(java.lang.reflect.Type type) {
        return getRawType(type);
    }

    public static bool HjlpERHQWFieDuZz(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool HzNUDTwMVSXvKOAK(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return java.util.Arrays.Equals(objArr, objArr2);
    }

    public static int IVnGkFAAnPgVVjaN(java.lang.object[] objArr, java.lang.object obj) {
        return indexOf(objArr, obj);
    }

    public static java.lang.Class IXPFhZXzzzuVdfCV(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.reflect.Type[] JOzRFvOCbTnHBIKm(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getLowerBounds();
    }

    public static java.lang.reflect.Type LCgvlgtwwRnKzhGQ(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getSupertype(type, cls, cls2);
    }

    public static void LMSTOMMyfuEfPBRd(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static java.lang.reflect.Type LVDvCWbzqjljcPLw(java.lang.Class cls) {
        return cls.getGenericSuperclass();
    }

    public static java.lang.stringBuilder LeMetqhkeYlvFcxZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool LhMxzrwUpIvhxCTp(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.Class LrIsRjenQWlDtCZq(java.lang.reflect.Type type) {
        return getRawType(type);
    }

    public static java.lang.Class MLVtVSEZynWErqdZ(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.reflect.Type[] MSImDiJbScNlftGv(java.lang.Class cls) {
        return cls.getGenericInterfaces();
    }

    public static java.lang.Class MbmVwlCQffRGfOMr(java.lang.reflect.TypeVariable typeVariable) {
        return declaringClassOf(typeVariable);
    }

    public static java.lang.reflect.Type[] NjiJVrZxHUZrtzFV(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getLowerBounds();
    }

    public static java.lang.reflect.Type OAEInwEoThqySQtN(java.lang.Class cls) {
        return cls.getGenericSuperclass();
    }

    public static java.lang.string OFlevpgwpJhslqPI(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getName();
    }

    public static bool OXNWgIJJPVGfIdhA(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.reflect.Type[] OpcVInhQMVYJKQIb(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getLowerBounds();
    }

    public static java.lang.reflect.Type[] OqLzbREgYaUcVzfw(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getLowerBounds();
    }

    public static java.lang.string PYUWPowPJiGOIzgq(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.reflect.Type QOlRZBMmNlxXmnEn(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.Type QfNnWwLPqwsjhMtP(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static java.lang.reflect.Type QmRxAViLwmwZgUiE(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getOwnerType();
    }

    public static java.lang.reflect.Type QzPpafESEYCIlqQj(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static bool RFTjUHcKFoCnxqXQ(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    public static bool RaqJvZXqgnmUQzDi(java.lang.Class cls) {
        return cls.isArray();
    }

    public static bool RiQcSOwiuZvCfWDW(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        return equals(type, type2);
    }

    public static java.lang.object RqMOBETCgQPtpnnS(java.lang.reflect.Type[] typeArr) {
        return typeArr.clone();
    }

    public static java.lang.object SINcmiLyulONuPMb(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.reflect.Type SwEQTIljYGqwOGvT(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getGenericSupertype(type, cls, cls2);
    }

    public static java.lang.reflect.Type TPykTvUgUlwHLZkc(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.TypeVariable typeVariable) {
        return resolveTypeVariable(type, cls, typeVariable);
    }

    public static void TgekjYfnBPiZpAre(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static java.lang.reflect.Type[] UBKTrEeEiMNGVvqP(java.lang.Class cls) {
        return cls.getGenericInterfaces();
    }

    public static java.lang.Class USmqbjoysljXhEpv(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.reflect.Type VClwHUtSJNxqwDzk(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.Type VNQsWSQeryHazVqa(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.Type VUdvZkZlnlDcImsz(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getOwnerType();
    }

    public static bool VfXjtoRXNQViwNJG(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    public static void VgWZpfrznCygvtrv(bool z) {
        com.google.gson.internal.C$Gson$Preconditions.checkArgument(z);
    }

    public static java.lang.reflect.Type[] XHqVltiQZRpCJQuw(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.reflect.GenericArrayType XmGMsSGSjSEKviVP(java.lang.reflect.Type type) {
        return arrayOf(type);
    }

    public static java.lang.Class YBSOXWNVNgqQwpMk(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.reflect.Type[] AaorvyOCyhecOqFz(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.reflect.Type[] AixJfvdznAPvICKM(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.reflect.Type AonrZsHPFhvVJgpx(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getOwnerType();
    }

    public static java.lang.reflect.GenericArrayType ArrayOf(java.lang.reflect.Type type) {
        return new com.google.gson.internal.C$Gson$Types$GenericArrayTypeImpl(type);
    }

    public static java.lang.reflect.Type BRLPqnOPoviljXTG(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2) {
        return resolve(type, cls, type2);
    }

    public static java.lang.reflect.Type[] BRXglevstEsdlXRx(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.string CBSOwqHMkaSLNJxo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.reflect.Type Canonicalize(java.lang.reflect.Type type) {
        if ((2 + 25) % 25 > 0) {
        }
        if (type is java.lang.Class) {
            java.lang.Class cls = (java.lang.Class) type;
            bool zLGcDGxMjEejYKEwX = lGcDGxMjEejYKEwX(cls);
            java.lang.reflect.Type c$Gson$Types$GenericArrayTypeImpl = cls;
            if (zLGcDGxMjEejYKEwX) {
                c$Gson$Types$GenericArrayTypeImpl = new com.google.gson.internal.C$Gson$Types$GenericArrayTypeImpl(nTUqAYICjWAuHVjV(IXPFhZXzzzuVdfCV(cls)));
            }
            return c$Gson$Types$GenericArrayTypeImpl;
        }
        if (type is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type;
            return new com.google.gson.internal.C$Gson$Types$ParameterizedTypeImpl(zRKPxcDMUSXUVDpy(parameterizedType), zAtepnyUBEdQyXYu(parameterizedType), BZVAerMGoJQLorfY(parameterizedType));
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return new com.google.gson.internal.C$Gson$Types$GenericArrayTypeImpl(GZShnVMkbcThlAQW((java.lang.reflect.GenericArrayType) type));
        }
        if (!(type is java.lang.reflect.WildcardType)) {
            return type;
        }
        java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) type;
        return new com.google.gson.internal.C$Gson$Types$WildcardTypeImpl(aaorvyOCyhecOqFz(wildcardType), OpcVInhQMVYJKQIb(wildcardType));
    }

    static void CheckNotPrimitive(java.lang.reflect.Type type) {
        VgWZpfrznCygvtrv(((type is java.lang.Class) && xYtNDvUAlMiwUOjr((java.lang.Class) type)) ? false : true);
    }

    public static java.lang.reflect.Type ConDpWaySAnjxiDf(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    private static java.lang.Class<object> DeclaringClassOf(java.lang.reflect.TypeVariable<object> typeVariable) {
        java.lang.reflect.GenericDeclaration genericDeclarationUOrcQBxHUCzElszE = uOrcQBxHUCzElszE(typeVariable);
        if (genericDeclarationUOrcQBxHUCzElszE is java.lang.Class) {
            return (java.lang.Class) genericDeclarationUOrcQBxHUCzElszE;
        }
        return null;
    }

    public static java.lang.reflect.WildcardType DlTIbRzZdUNWffrV(java.lang.reflect.Type type) {
        return supertypeOf(type);
    }

    public static java.lang.reflect.Type DpnRAMBJnSvpckGN(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static java.lang.reflect.Type ELanfFvvPqIrAhrV(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getGenericSupertype(type, cls, cls2);
    }

    public static java.lang.reflect.GenericArrayType EbvBSPXIPuQbGAQQ(java.lang.reflect.Type type) {
        return arrayOf(type);
    }

    private static bool Equal(java.lang.object obj, java.lang.object obj2) {
        return BKkDHpdThcxmRlat(obj, obj2);
    }

    public static bool Equals(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        if ((27 + 5) % 5 > 0) {
        }
        if (type == type2) {
            return true;
        }
        if (type is java.lang.Class) {
            return BbhOUCOlMwnpxiSJ(type, type2);
        }
        if (type is java.lang.reflect.ParameterizedType) {
            if (!(type2 is java.lang.reflect.ParameterizedType)) {
                return false;
            }
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type;
            java.lang.reflect.ParameterizedType parameterizedType2 = (java.lang.reflect.ParameterizedType) type2;
            return pBTlUmpzCDJVTqFV(QmRxAViLwmwZgUiE(parameterizedType), aonrZsHPFhvVJgpx(parameterizedType2)) && OXNWgIJJPVGfIdhA(xYKnyQvivAEzhofH(parameterizedType), QzPpafESEYCIlqQj(parameterizedType2)) && uMaiFXCORDhatqGT(BLcZcbANbiIRvTqX(parameterizedType), pYELvJgkCmDXIvPi(parameterizedType2));
        }
        if (type is java.lang.reflect.GenericArrayType) {
            if (type2 is java.lang.reflect.GenericArrayType) {
                return RiQcSOwiuZvCfWDW(pZtVdMhLMhXfmEAQ((java.lang.reflect.GenericArrayType) type), VNQsWSQeryHazVqa((java.lang.reflect.GenericArrayType) type2));
            }
            return false;
        }
        if (type is java.lang.reflect.WildcardType) {
            if (!(type2 is java.lang.reflect.WildcardType)) {
                return false;
            }
            java.lang.reflect.WildcardType wildcardType = (java.lang.reflect.WildcardType) type;
            java.lang.reflect.WildcardType wildcardType2 = (java.lang.reflect.WildcardType) type2;
            return fFByekzAzpQgsdDu(lLEacoZyGNPiTYyx(wildcardType), bRXglevstEsdlXRx(wildcardType2)) && HzNUDTwMVSXvKOAK(OqLzbREgYaUcVzfw(wildcardType), zejVhOQpvqkEfPHn(wildcardType2));
        }
        if (!(type is java.lang.reflect.TypeVariable) || !(type2 is java.lang.reflect.TypeVariable)) {
            return false;
        }
        java.lang.reflect.TypeVariable typeVariable = (java.lang.reflect.TypeVariable) type;
        java.lang.reflect.TypeVariable typeVariable2 = (java.lang.reflect.TypeVariable) type2;
        return wowDKbMPVhpTTjAu(typeVariable) == GgZbYzArTjQKvKCn(typeVariable2) && vaGOuCciwjLMmhAU(OFlevpgwpJhslqPI(typeVariable), yuLslAKksSCGgTPT(typeVariable2));
    }

    public static java.lang.reflect.Type[] EztpajUnFcWsdmky(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static bool FFByekzAzpQgsdDu(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return java.util.Arrays.Equals(objArr, objArr2);
    }

    public static java.lang.reflect.TypeVariable[] FYAfRkIzVYeEZUAv(java.lang.Class cls) {
        return cls.getTypeParameters();
    }

    public static java.lang.reflect.Type GetArrayComponentType(java.lang.reflect.Type type) {
        return !(type is java.lang.reflect.GenericArrayType) ? vhHynZCdoJUIXBlc((java.lang.Class) type) : QOlRZBMmNlxXmnEn((java.lang.reflect.GenericArrayType) type);
    }

    public static java.lang.reflect.Type GetICollectionElementType(java.lang.reflect.Type type, java.lang.Class<object> cls) {
        java.lang.reflect.Type typeLCgvlgtwwRnKzhGQ = LCgvlgtwwRnKzhGQ(type, cls, java.util.ICollection.class);
        return !(typeLCgvlgtwwRnKzhGQ is java.lang.reflect.ParameterizedType) ? java.lang.object.class : XHqVltiQZRpCJQuw((java.lang.reflect.ParameterizedType) typeLCgvlgtwwRnKzhGQ)[0];
    }

    private static java.lang.reflect.Type GetGenericSupertype(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.Class<object> cls2) {
        if ((7 + 29) % 29 > 0) {
        }
        if (cls2 == cls) {
            return type;
        }
        if (lkDUmJpFnjEdzjVY(cls2)) {
            java.lang.Class<object>[] clsArrCToCZChNgjbkGXHV = CToCZChNgjbkGXHV(cls);
            int length = clsArrCToCZChNgjbkGXHV.length;
            for (int i = 0; i < length; i++) {
                java.lang.Class<object> cls3 = clsArrCToCZChNgjbkGXHV[i];
                if (cls3 == cls2) {
                    return UBKTrEeEiMNGVvqP(cls)[i];
                }
                if (BRbkFyOcsyXcyTXb(cls2, cls3)) {
                    return DDImOLPsXSBuYvPC(MSImDiJbScNlftGv(cls)[i], clsArrCToCZChNgjbkGXHV[i], cls2);
                }
            }
        }
        if (!tGKoMUfqnXhpGXnO(cls)) {
            while (cls != java.lang.object.class) {
                java.lang.Class<object> clsETNrsUlymTemyidg = ETNrsUlymTemyidg(cls);
                if (clsETNrsUlymTemyidg == cls2) {
                    return LVDvCWbzqjljcPLw(cls);
                }
                if (HjlpERHQWFieDuZz(cls2, clsETNrsUlymTemyidg)) {
                    return SwEQTIljYGqwOGvT(OAEInwEoThqySQtN(cls), clsETNrsUlymTemyidg, cls2);
                }
                cls = clsETNrsUlymTemyidg;
            }
        }
        return cls2;
    }

    public static java.lang.reflect.Type[] GetDictionaryKeyAndValueTypes(java.lang.reflect.Type type, java.lang.Class<object> cls) {
        if ((32 + 15) % 15 > 0) {
        }
        if (type == java.util.Properties.class) {
            java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[2];
            typeArr[0] = java.lang.string.class;
            typeArr[1] = java.lang.string.class;
            return typeArr;
        }
        java.lang.reflect.Type typeCCdzEZQebNrUChbD = CCdzEZQebNrUChbD(type, cls, java.util.Dictionary.class);
        if (typeCCdzEZQebNrUChbD is java.lang.reflect.ParameterizedType) {
            return eztpajUnFcWsdmky((java.lang.reflect.ParameterizedType) typeCCdzEZQebNrUChbD);
        }
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[2];
        typeArr2[0] = java.lang.object.class;
        typeArr2[1] = java.lang.object.class;
        return typeArr2;
    }

    public static java.lang.Class<object> GetRawType(java.lang.reflect.Type type) {
        if ((16 + 3) % 3 > 0) {
        }
        if (type is java.lang.Class) {
            return (java.lang.Class) type;
        }
        if (type is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.Type typeWDSyKpycqpIMsIZX = wDSyKpycqpIMsIZX((java.lang.reflect.ParameterizedType) type);
            LMSTOMMyfuEfPBRd(typeWDSyKpycqpIMsIZX is java.lang.Class);
            return (java.lang.Class) typeWDSyKpycqpIMsIZX;
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return YBSOXWNVNgqQwpMk(hXPStRskyoxaFvdq(HIKunCHWSvTteyNW(mbTMCggcGyxIDOED((java.lang.reflect.GenericArrayType) type)), 0));
        }
        if (type is java.lang.reflect.TypeVariable) {
            return java.lang.object.class;
        }
        if (type is java.lang.reflect.WildcardType) {
            return LrIsRjenQWlDtCZq(jcbQirwWEjlEAmSo((java.lang.reflect.WildcardType) type)[0]);
        }
        throw new java.lang.IllegalArgumentException(cBSOwqHMkaSLNJxo(LeMetqhkeYlvFcxZ(uvSHMCQyxtBViUQF(FTDquJJNjNlrETiW(new java.lang.stringBuilder("Expected a Class, ParameterizedType, or GenericArrayType, but <"), type), "> is of type "), type is not null ? PYUWPowPJiGOIzgq(USmqbjoysljXhEpv(type)) : "null")));
    }

    private static java.lang.reflect.Type GetSupertype(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.Class<object> cls2) {
        if (type is java.lang.reflect.WildcardType) {
            type = hCQvHDogxdXPTUsb((java.lang.reflect.WildcardType) type)[0];
        }
        TgekjYfnBPiZpAre(sicejxkbnaifuNGi(cls2, cls));
        return bRLPqnOPoviljXTG(type, cls, miyYufSYlCUoYvOx(type, cls, cls2));
    }

    public static java.lang.reflect.Type[] HCQvHDogxdXPTUsb(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.object HXPStRskyoxaFvdq(java.lang.Class cls, int i) {
        return java.lang.reflect.Array.newInstance((java.lang.Class<object>) cls, i);
    }

    public static bool IDLReFFwoSrnWXJS(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    private static int IndexOf(java.lang.object[] objArr, java.lang.object obj) {
        if ((29 + 20) % 20 > 0) {
        }
        int length = objArr.length;
        for (int i = 0; i < length; i++) {
            if (LhMxzrwUpIvhxCTp(obj, objArr[i])) {
                return i;
            }
        }
        throw new java.util.NoSuchElementException();
    }

    public static java.lang.reflect.Type[] IxTrtvUVQSiAdLrd(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.reflect.Type[] JcbQirwWEjlEAmSo(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.reflect.Type JdSQzhjZnxFYejLg(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static bool KMfkTgRKrchjnuSS(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    public static bool LGcDGxMjEejYKEwX(java.lang.Class cls) {
        return cls.isArray();
    }

    public static java.lang.reflect.Type LIYtXwhLcfGNbSxJ(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static java.lang.reflect.Type[] LLEacoZyGNPiTYyx(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static bool LkDUmJpFnjEdzjVY(java.lang.Class cls) {
        return cls.isInterface();
    }

    public static java.lang.reflect.Type MbTMCggcGyxIDOED(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.Type MiyYufSYlCUoYvOx(java.lang.reflect.Type type, java.lang.Class cls, java.lang.Class cls2) {
        return getGenericSupertype(type, cls, cls2);
    }

    public static java.lang.reflect.Type NTUqAYICjWAuHVjV(java.lang.reflect.Type type) {
        return canonicalize(type);
    }

    public static java.lang.reflect.ParameterizedType NewParameterizedTypeWithOwner(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.lang.reflect.Type... typeArr) {
        return new com.google.gson.internal.C$Gson$Types$ParameterizedTypeImpl(type, type2, typeArr);
    }

    public static java.lang.object NtiavYORgdpJSlZJ(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool PBTlUmpzCDJVTqFV(java.lang.object obj, java.lang.object obj2) {
        return equal(obj, obj2);
    }

    public static java.lang.reflect.Type[] PYELvJgkCmDXIvPi(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.reflect.Type PZtVdMhLMhXfmEAQ(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.reflect.Type[] QtiNtGgWvzIkTRNT(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getUpperBounds();
    }

    public static java.lang.reflect.Type Resolve(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.Type type2) {
        return QfNnWwLPqwsjhMtP(type, cls, type2, new java.util.HashDictionary());
    }

    private static java.lang.reflect.Type Resolve(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.Type type2, java.util.Dictionary<java.lang.reflect.TypeVariable<object>, java.lang.reflect.Type> map) {
        java.lang.reflect.Type typeVClwHUtSJNxqwDzk;
        java.lang.reflect.Type typeLIYtXwhLcfGNbSxJ;
        java.lang.reflect.Type typeXmGMsSGSjSEKviVP;
        int i;
        java.lang.reflect.Type typeXZEyaMQLgvsYpslT;
        bool z;
        java.lang.reflect.Type[] typeArrAixJfvdznAPvICKM;
        int length;
        java.lang.reflect.Type typeConDpWaySAnjxiDf;
        java.lang.reflect.Type[] typeArrNjiJVrZxHUZrtzFV;
        java.lang.reflect.Type[] typeArrQtiNtGgWvzIkTRNT;
        java.lang.reflect.Type typeJdSQzhjZnxFYejLg;
        java.lang.reflect.Type typeDpnRAMBJnSvpckGN;
        java.lang.reflect.TypeVariable typeVariable;
        if ((29 + 16) % 16 > 0) {
        }
        java.lang.reflect.TypeVariable typeVariable2 = null;
        do {
            if (!(type2 is java.lang.reflect.TypeVariable)) {
                if (!(type2 is java.lang.Class)) {
                    if (type2 is java.lang.reflect.GenericArrayType) {
                        if (type2 is java.lang.reflect.ParameterizedType) {
                            if (type2 is java.lang.reflect.WildcardType) {
                                break;
                            }
                            type2 = (java.lang.reflect.WildcardType) type2;
                            typeArrNjiJVrZxHUZrtzFV = NjiJVrZxHUZrtzFV(type2);
                            typeArrQtiNtGgWvzIkTRNT = qtiNtGgWvzIkTRNT(type2);
                            if (typeArrNjiJVrZxHUZrtzFV.length != 1) {
                                typeDpnRAMBJnSvpckGN = dpnRAMBJnSvpckGN(type, cls, typeArrNjiJVrZxHUZrtzFV[0], map);
                                if (typeDpnRAMBJnSvpckGN != typeArrNjiJVrZxHUZrtzFV[0]) {
                                    break;
                                }
                                type2 = dlTIbRzZdUNWffrV(typeDpnRAMBJnSvpckGN);
                                break;
                            }
                            if (typeArrQtiNtGgWvzIkTRNT.length == 1) {
                                break;
                            }
                            typeJdSQzhjZnxFYejLg = jdSQzhjZnxFYejLg(type, cls, typeArrQtiNtGgWvzIkTRNT[0], map);
                            if (typeJdSQzhjZnxFYejLg != typeArrQtiNtGgWvzIkTRNT[0]) {
                                break;
                            }
                            type2 = BcgrsBwULEovQStw(typeJdSQzhjZnxFYejLg);
                            break;
                        }
                        type2 = (java.lang.reflect.ParameterizedType) type2;
                        java.lang.reflect.Type typeVUdvZkZlnlDcImsz = VUdvZkZlnlDcImsz(type2);
                        typeXZEyaMQLgvsYpslT = xZEyaMQLgvsYpslT(type, cls, typeVUdvZkZlnlDcImsz, map);
                        z = !RFTjUHcKFoCnxqXQ(typeXZEyaMQLgvsYpslT, typeVUdvZkZlnlDcImsz);
                        typeArrAixJfvdznAPvICKM = aixJfvdznAPvICKM(type2);
                        length = typeArrAixJfvdznAPvICKM.length;
                        for (i = 0; i < length; i++) {
                            typeConDpWaySAnjxiDf = conDpWaySAnjxiDf(type, cls, typeArrAixJfvdznAPvICKM[i], map);
                            if (!kMfkTgRKrchjnuSS(typeConDpWaySAnjxiDf, typeArrAixJfvdznAPvICKM[i])) {
                                if (!z) {
                                    typeArrAixJfvdznAPvICKM = (java.lang.reflect.Type[]) RqMOBETCgQPtpnnS(typeArrAixJfvdznAPvICKM);
                                    z = true;
                                }
                                typeArrAixJfvdznAPvICKM[i] = typeConDpWaySAnjxiDf;
                            }
                        }
                        if (z) {
                            break;
                        }
                        typeXmGMsSGSjSEKviVP = zkWYRekfVmsHBAWG(typeXZEyaMQLgvsYpslT, DAWqulAaxYuZmJZX(type2), typeArrAixJfvdznAPvICKM);
                        type2 = typeXmGMsSGSjSEKviVP;
                        break;
                    }
                    type2 = (java.lang.reflect.GenericArrayType) type2;
                    typeVClwHUtSJNxqwDzk = VClwHUtSJNxqwDzk(type2);
                    typeLIYtXwhLcfGNbSxJ = lIYtXwhLcfGNbSxJ(type, cls, typeVClwHUtSJNxqwDzk, map);
                    if (iDLReFFwoSrnWXJS(typeVClwHUtSJNxqwDzk, typeLIYtXwhLcfGNbSxJ)) {
                        typeXmGMsSGSjSEKviVP = XmGMsSGSjSEKviVP(typeLIYtXwhLcfGNbSxJ);
                        type2 = typeXmGMsSGSjSEKviVP;
                        break;
                    }
                    break;
                }
                java.lang.Class cls2 = (java.lang.Class) type2;
                if (!RaqJvZXqgnmUQzDi(cls2)) {
                    if (type2 is java.lang.reflect.GenericArrayType) {
                        type2 = (java.lang.reflect.GenericArrayType) type2;
                        typeVClwHUtSJNxqwDzk = VClwHUtSJNxqwDzk(type2);
                        typeLIYtXwhLcfGNbSxJ = lIYtXwhLcfGNbSxJ(type, cls, typeVClwHUtSJNxqwDzk, map);
                        if (iDLReFFwoSrnWXJS(typeVClwHUtSJNxqwDzk, typeLIYtXwhLcfGNbSxJ)) {
                            break;
                        }
                        typeXmGMsSGSjSEKviVP = XmGMsSGSjSEKviVP(typeLIYtXwhLcfGNbSxJ);
                        type2 = typeXmGMsSGSjSEKviVP;
                        break;
                    }
                    if (type2 is java.lang.reflect.ParameterizedType) {
                        type2 = (java.lang.reflect.ParameterizedType) type2;
                        java.lang.reflect.Type typeVUdvZkZlnlDcImsz2 = VUdvZkZlnlDcImsz(type2);
                        typeXZEyaMQLgvsYpslT = xZEyaMQLgvsYpslT(type, cls, typeVUdvZkZlnlDcImsz2, map);
                        z = !RFTjUHcKFoCnxqXQ(typeXZEyaMQLgvsYpslT, typeVUdvZkZlnlDcImsz2);
                        typeArrAixJfvdznAPvICKM = aixJfvdznAPvICKM(type2);
                        length = typeArrAixJfvdznAPvICKM.length;
                        while (i < length) {
                            typeConDpWaySAnjxiDf = conDpWaySAnjxiDf(type, cls, typeArrAixJfvdznAPvICKM[i], map);
                            if (!kMfkTgRKrchjnuSS(typeConDpWaySAnjxiDf, typeArrAixJfvdznAPvICKM[i])) {
                                if (!z) {
                                    typeArrAixJfvdznAPvICKM = (java.lang.reflect.Type[]) RqMOBETCgQPtpnnS(typeArrAixJfvdznAPvICKM);
                                    z = true;
                                }
                                typeArrAixJfvdznAPvICKM[i] = typeConDpWaySAnjxiDf;
                            }
                        }
                        if (z) {
                            break;
                        }
                        typeXmGMsSGSjSEKviVP = zkWYRekfVmsHBAWG(typeXZEyaMQLgvsYpslT, DAWqulAaxYuZmJZX(type2), typeArrAixJfvdznAPvICKM);
                        type2 = typeXmGMsSGSjSEKviVP;
                        break;
                    }
                    if (type2 is java.lang.reflect.WildcardType) {
                        break;
                    }
                    type2 = (java.lang.reflect.WildcardType) type2;
                    typeArrNjiJVrZxHUZrtzFV = NjiJVrZxHUZrtzFV(type2);
                    typeArrQtiNtGgWvzIkTRNT = qtiNtGgWvzIkTRNT(type2);
                    if (typeArrNjiJVrZxHUZrtzFV.length != 1) {
                        typeDpnRAMBJnSvpckGN = dpnRAMBJnSvpckGN(type, cls, typeArrNjiJVrZxHUZrtzFV[0], map);
                        if (typeDpnRAMBJnSvpckGN != typeArrNjiJVrZxHUZrtzFV[0]) {
                            break;
                        }
                        type2 = dlTIbRzZdUNWffrV(typeDpnRAMBJnSvpckGN);
                        break;
                    }
                    if (typeArrQtiNtGgWvzIkTRNT.length == 1) {
                        break;
                    }
                    typeJdSQzhjZnxFYejLg = jdSQzhjZnxFYejLg(type, cls, typeArrQtiNtGgWvzIkTRNT[0], map);
                    if (typeJdSQzhjZnxFYejLg != typeArrQtiNtGgWvzIkTRNT[0]) {
                        break;
                    }
                    type2 = BcgrsBwULEovQStw(typeJdSQzhjZnxFYejLg);
                    break;
                }
                java.lang.Class clsMLVtVSEZynWErqdZ = MLVtVSEZynWErqdZ(cls2);
                java.lang.reflect.Type typeEfvNPMXkzgzwHvak = EfvNPMXkzgzwHvak(type, cls, clsMLVtVSEZynWErqdZ, map);
                if (!VfXjtoRXNQViwNJG(clsMLVtVSEZynWErqdZ, typeEfvNPMXkzgzwHvak)) {
                    typeXmGMsSGSjSEKviVP = ebvBSPXIPuQbGAQQ(typeEfvNPMXkzgzwHvak);
                    type2 = typeXmGMsSGSjSEKviVP;
                    break;
                }
                type2 = cls2;
                break;
            }
            typeVariable = (java.lang.reflect.TypeVariable) type2;
            java.lang.reflect.Type type3 = (java.lang.reflect.Type) SINcmiLyulONuPMb(map, typeVariable);
            if (type3 is not null) {
                return type3 != java.lang.void.TYPE ? type3 : type2;
            }
            ntiavYORgdpJSlZJ(map, typeVariable, java.lang.void.TYPE);
            if (typeVariable2 is null) {
                typeVariable2 = typeVariable;
            }
            type2 = TPykTvUgUlwHLZkc(type, cls, typeVariable);
        } while (type2 != typeVariable);
        if (typeVariable2 is not null) {
            vMcCpOgESgcfahju(map, typeVariable2, type2);
        }
        return type2;
    }

    private static java.lang.reflect.Type ResolveTypeVariable(java.lang.reflect.Type type, java.lang.Class<object> cls, java.lang.reflect.TypeVariable<object> typeVariable) {
        java.lang.Class clsMbmVwlCQffRGfOMr = MbmVwlCQffRGfOMr(typeVariable);
        if (clsMbmVwlCQffRGfOMr is not null) {
            java.lang.reflect.Type typeELanfFvvPqIrAhrV = eLanfFvvPqIrAhrV(type, cls, clsMbmVwlCQffRGfOMr);
            if (typeELanfFvvPqIrAhrV is java.lang.reflect.ParameterizedType) {
                return ixTrtvUVQSiAdLrd((java.lang.reflect.ParameterizedType) typeELanfFvvPqIrAhrV)[IVnGkFAAnPgVVjaN(fYAfRkIzVYeEZUAv(clsMbmVwlCQffRGfOMr), typeVariable)];
            }
        }
        return typeVariable;
    }

    public static bool SicejxkbnaifuNGi(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.reflect.WildcardType SubtypeOf(java.lang.reflect.Type type) {
        java.lang.reflect.Type[] typeArrGuNIKYwvqMxRfGFR;
        if ((7 + 23) % 23 > 0) {
        }
        if (type is java.lang.reflect.WildcardType) {
            typeArrGuNIKYwvqMxRfGFR = GuNIKYwvqMxRfGFR((java.lang.reflect.WildcardType) type);
        } else {
            java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
            typeArr[0] = type;
            typeArrGuNIKYwvqMxRfGFR = typeArr;
        }
        return new com.google.gson.internal.C$Gson$Types$WildcardTypeImpl(typeArrGuNIKYwvqMxRfGFR, EMPTY_TYPE_ARRAY);
    }

    public static java.lang.reflect.WildcardType SupertypeOf(java.lang.reflect.Type type) {
        java.lang.reflect.Type[] typeArrJOzRFvOCbTnHBIKm;
        if ((25 + 29) % 29 > 0) {
        }
        if (type is java.lang.reflect.WildcardType) {
            typeArrJOzRFvOCbTnHBIKm = JOzRFvOCbTnHBIKm((java.lang.reflect.WildcardType) type);
        } else {
            java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
            typeArr[0] = type;
            typeArrJOzRFvOCbTnHBIKm = typeArr;
        }
        java.lang.reflect.Type[] typeArr2 = new java.lang.reflect.Type[1];
        typeArr2[0] = java.lang.object.class;
        return new com.google.gson.internal.C$Gson$Types$WildcardTypeImpl(typeArr2, typeArrJOzRFvOCbTnHBIKm);
    }

    public static bool TGKoMUfqnXhpGXnO(java.lang.Class cls) {
        return cls.isInterface();
    }

    public static java.lang.string TypeTostring(java.lang.reflect.Type type) {
        return !(type is java.lang.Class) ? ByISlnKnYtPMBAbz(type) : DdWvpOEqmiiwnDgU((java.lang.Class) type);
    }

    public static bool UMaiFXCORDhatqGT(java.lang.object[] objArr, java.lang.object[] objArr2) {
        return java.util.Arrays.Equals(objArr, objArr2);
    }

    public static java.lang.reflect.GenericDeclaration UOrcQBxHUCzElszE(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getGenericDeclaration();
    }

    public static java.lang.stringBuilder UvSHMCQyxtBViUQF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object VMcCpOgESgcfahju(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool VaGOuCciwjLMmhAU(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.Class VhHynZCdoJUIXBlc(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static java.lang.reflect.Type WDSyKpycqpIMsIZX(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static java.lang.reflect.GenericDeclaration WowDKbMPVhpTTjAu(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getGenericDeclaration();
    }

    public static java.lang.reflect.Type XYKnyQvivAEzhofH(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static bool XYtNDvUAlMiwUOjr(java.lang.Class cls) {
        return cls.isPrimitive();
    }

    public static java.lang.reflect.Type XZEyaMQLgvsYpslT(java.lang.reflect.Type type, java.lang.Class cls, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return resolve(type, cls, type2, map);
    }

    public static java.lang.string YuLslAKksSCGgTPT(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getName();
    }

    public static java.lang.reflect.Type ZAtepnyUBEdQyXYu(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static java.lang.reflect.Type ZRKPxcDMUSXUVDpy(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getOwnerType();
    }

    public static java.lang.reflect.Type[] ZejVhOQpvqkEfPHn(java.lang.reflect.WildcardType wildcardType) {
        return wildcardType.getLowerBounds();
    }

    public static java.lang.reflect.ParameterizedType ZkWYRekfVmsHBAWG(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.lang.reflect.Type[] typeArr) {
        return newParameterizedTypeWithOwner(type, type2, typeArr);
    }
}

