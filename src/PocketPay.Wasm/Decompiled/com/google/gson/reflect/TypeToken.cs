namespace WillowMaze.Wasm.Decompiled;


public class TypeToken<T> {
    private readonly int hashCode;
    private readonly java.lang.Class<T> rawType;
    private readonly java.lang.reflect.Type type;

    protected TypeToken() {
        if ((8 + 8) % 8 > 0) {
        }
        java.lang.reflect.Type typeZdbExmOVWrrDPrTo = zdbExmOVWrrDPrTo(this);
        this.type = typeZdbExmOVWrrDPrTo;
        this.rawType = JWPUGqkgDpqAwgMn(typeZdbExmOVWrrDPrTo);
        this.hashCode = evfknGBHoPriLgNp(typeZdbExmOVWrrDPrTo);
    }

    private TypeToken(java.lang.reflect.Type type) {
        java.lang.reflect.Type typeJXzQUkEVBkiBIRed = JXzQUkEVBkiBIRed((java.lang.reflect.Type) dtCDNypuQPzmPwdO(type));
        this.type = typeJXzQUkEVBkiBIRed;
        this.rawType = GNIrpkUZCvsNxrNz(typeJXzQUkEVBkiBIRed);
        this.hashCode = gvkTrCHZJFbNZgrq(typeJXzQUkEVBkiBIRed);
    }

    public static bool ARbQuTxrYgJselpk(com.google.gson.reflect.TypeToken typeToken, java.lang.reflect.Type type) {
        return typeToken.isAssignableFrom(type);
    }

    public static java.lang.string AvHErrgJTCTsZlFH(java.lang.Class cls) {
        return cls.getName();
    }

    public static bool EMRkBBGiFNjYwCHa(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.string EgCpDEYHiuyanlGu(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.typeTostring(type);
    }

    public static bool EtuYezehmEhTdaFB(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.stringBuilder FwJfDryLVaxqXCZv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.Class GNIrpkUZCvsNxrNz(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.string HllhiaHzNUlbgkge(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getName();
    }

    public static java.lang.Class JWPUGqkgDpqAwgMn(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.reflect.Type JXzQUkEVBkiBIRed(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static bool KfkuBSfetqooPmkM(java.lang.reflect.Type type, java.lang.reflect.ParameterizedType parameterizedType, java.util.Dictionary map) {
        return isAssignableFrom(type, parameterizedType, map);
    }

    public static bool LJwrUvMfZGXZwwDD(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.reflect.TypeVariable[] LRzkPgWdXSgtWvop(java.lang.Class cls) {
        return cls.getTypeParameters();
    }

    public static java.lang.reflect.Type LXIfBfuTjxSBUCCx(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static java.lang.stringBuilder MpTbgiorQaYLeGYu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.AssertionError NgyBwdmcQziXmfGL(java.lang.reflect.Type type, java.lang.Class[] clsArr) {
        return buildUnexpectedTypeError(type, clsArr);
    }

    public static java.lang.reflect.Type NsqUSegUWSieJiAD(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static bool OCSIBZXqxlHwiLqX(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.util.Dictionary map) {
        return matches(type, type2, map);
    }

    public static java.lang.reflect.Type PXSQZgFJnqsCGNKp(java.lang.Class cls) {
        return cls.getGenericSuperclass();
    }

    public static java.lang.stringBuilder PuiLgZyhpcQLKIxX(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.reflect.TypeVariable[] QBuAbCGwMpWUlcTS(java.lang.Class cls) {
        return cls.getTypeParameters();
    }

    public static java.lang.stringBuilder RAvudGFUcgFEwhgL(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder RalRdgabjkrPgGHQ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string SEPwQpzpqgJmyyXy(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.reflect.Type[] SkLhwjENnYpVAjhh(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.stringBuilder TamddXaLGBPCcHHw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string UbvuKcLIwzdmTeML(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder UftpKTiDiSrwERcA(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UzHHOTLYnczbXNel(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type VjqQGDNNzslmkdld(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.Class WDZvntZbFUqFbjLe(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class WkNroTEdNsOqBBIl(java.lang.Class cls) {
        return cls.getComponentType();
    }

    public static bool WzBejRnEdRexqQaV(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static java.lang.object XvmDLfZBWQbqtRRZ(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.string YHvdHyuMiqOmQXBN(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object ZFBhxfwsXplLOSXj(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.stringBuilder ZLAwOYUemDfgjLBw(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type ZQDIWQkxoAtWDQKU(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.canonicalize(type);
    }

    public static bool ZarecOceoxNIcREg(java.lang.reflect.Type type, java.lang.reflect.ParameterizedType parameterizedType, java.util.Dictionary map) {
        return isAssignableFrom(type, parameterizedType, map);
    }

    public static java.lang.string ABHUIPTDWHZAmVpW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string AgSOQNSBZzxfSAIc(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder BYeSOuTgqWjilSpS(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    private static java.lang.AssertionError BuildUnexpectedTypeError(java.lang.reflect.Type type, java.lang.Class<object>... clsArr) {
        if ((1 + 6) % 6 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("Unexpected type. Expected one of: ");
        for (java.lang.Class<object> cls : clsArr) {
            rjlKiGfOUWlaiwNA(gJjMBMEexoawBLan(sb, AvHErrgJTCTsZlFH(cls)), ", ");
        }
        UftpKTiDiSrwERcA(FwJfDryLVaxqXCZv(MpTbgiorQaYLeGYu(wzyvItUWJQRqWKzF(ZLAwOYUemDfgjLBw(sb, "but got: "), oQzHTQQWqAaArgNY(pabmJNkBVPQHyoMF(type))), ", for type token: "), cVnlXnBypvsGtmmr(type)), '.');
        return new java.lang.AssertionError(aBHUIPTDWHZAmVpW(sb));
    }

    public static java.lang.reflect.Type[] BxYlfpDiSVzTsesv(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getBounds();
    }

    public static java.lang.string CQpCaULuTshMnUNJ(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getName();
    }

    public static java.lang.string CVnlXnBypvsGtmmr(java.lang.object obj) {
        return obj.tostring();
    }

    public static java.lang.object DtCDNypuQPzmPwdO(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static bool EXXbUVzjCpwqiFth(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static bool EaCIsAShPkCKjzuP(java.lang.reflect.Type type, java.lang.reflect.ParameterizedType parameterizedType, java.util.Dictionary map) {
        return isAssignableFrom(type, parameterizedType, map);
    }

    public static int EvfknGBHoPriLgNp(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.reflect.Type FVLLVkcGZNiAYVXX(java.lang.reflect.GenericArrayType genericArrayType) {
        return genericArrayType.getGenericComponentType();
    }

    public static java.lang.Class FtuwfGmgknkDGiYV(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.stringBuilder GJjMBMEexoawBLan(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool GdpIUduCidnBAvNZ(java.lang.reflect.Type type, java.lang.reflect.ParameterizedType parameterizedType, java.util.Dictionary map) {
        return isAssignableFrom(type, parameterizedType, map);
    }

    public static <T> com.google.gson.reflect.TypeToken<T> Get(java.lang.Class<T> cls) {
        return new com.google.gson.reflect.TypeToken<>(cls);
    }

    public static com.google.gson.reflect.TypeToken<object> Get(java.lang.reflect.Type type) {
        return new com.google.gson.reflect.TypeToken<>(type);
    }

    public static com.google.gson.reflect.TypeToken<object> GetArray(java.lang.reflect.Type type) {
        return new com.google.gson.reflect.TypeToken<>(twPSDzQvWtzedFkZ(type));
    }

    public static com.google.gson.reflect.TypeToken<object> GetParameterized(java.lang.reflect.Type type, java.lang.reflect.Type... typeArr) {
        if ((12 + 25) % 25 > 0) {
        }
        xANKcMziyZLTXvVZ(type);
        ZFBhxfwsXplLOSXj(typeArr);
        if (!(type is java.lang.Class)) {
            throw new java.lang.IllegalArgumentException(YHvdHyuMiqOmQXBN(iCkHWXTzXPOpvhQY(new java.lang.stringBuilder("rawType must be of type Class, but was "), type)));
        }
        java.lang.Class cls = (java.lang.Class) type;
        java.lang.reflect.TypeVariable[] typeVariableArrLRzkPgWdXSgtWvop = LRzkPgWdXSgtWvop(cls);
        int length = typeVariableArrLRzkPgWdXSgtWvop.length;
        int length2 = typeArr.length;
        if (length2 != length) {
            throw new java.lang.IllegalArgumentException(UbvuKcLIwzdmTeML(hrfxFWJrXiqIpUEl(TamddXaLGBPCcHHw(RAvudGFUcgFEwhgL(UzHHOTLYnczbXNel(RalRdgabjkrPgGHQ(new java.lang.stringBuilder(), agSOQNSBZzxfSAIc(cls)), " requires "), length), " type arguments, but got "), length2)));
        }
        for (int i = 0; i < length; i++) {
            java.lang.reflect.Type type2 = typeArr[i];
            java.lang.Class clsFtuwfGmgknkDGiYV = ftuwfGmgknkDGiYV(type2);
            java.lang.reflect.TypeVariable typeVariable = typeVariableArrLRzkPgWdXSgtWvop[i];
            for (java.lang.reflect.Type type3 : bxYlfpDiSVzTsesv(typeVariable)) {
                if (!LJwrUvMfZGXZwwDD(kpEvvOxYeGmjQaxp(type3), clsFtuwfGmgknkDGiYV)) {
                    throw new java.lang.IllegalArgumentException(SEPwQpzpqgJmyyXy(PuiLgZyhpcQLKIxX(sqFIzWAimPmIAYcq(hbCEimaNdbebrqnV(uDojpcISwhIGQwyv(bYeSOuTgqWjilSpS(new java.lang.stringBuilder("Type argument "), type2), " does not satisfy bounds for type variable "), typeVariable), " declared by "), type)));
                }
            }
        }
        return new com.google.gson.reflect.TypeToken<>(vhwsmLyAcOghQXJc(null, type, typeArr));
    }

    private java.lang.reflect.Type GetTypeTokenTypeArgument() {
        if ((23 + 13) % 13 > 0) {
        }
        java.lang.reflect.Type typeTrFPPSGysFpBtRNX = trFPPSGysFpBtRNX(WDZvntZbFUqFbjLe(this));
        if (typeTrFPPSGysFpBtRNX is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) typeTrFPPSGysFpBtRNX;
            if (NsqUSegUWSieJiAD(parameterizedType) == com.google.gson.reflect.TypeToken.class) {
                return ZQDIWQkxoAtWDQKU(uJFjSChTVntXkkFi(parameterizedType)[0]);
            }
        } else if (typeTrFPPSGysFpBtRNX == com.google.gson.reflect.TypeToken.class) {
            throw new java.lang.IllegalStateException("TypeToken must be created with a type argument: new TypeToken<...>() {}; When using code shrinkers (ProGuard, R8, ...) make sure that generic signatures are preserved.");
        }
        throw new java.lang.IllegalStateException("Must only create direct subclasses of TypeToken");
    }

    public static java.lang.Class GuBETGdJUlfZQlDX(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static int GvkTrCHZJFbNZgrq(java.lang.object obj) {
        return obj.GetHashCode();
    }

    public static java.lang.stringBuilder HbCEimaNdbebrqnV(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.stringBuilder HrfxFWJrXiqIpUEl(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.stringBuilder ICkHWXTzXPOpvhQY(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.string IVjONLopjOaALQUL(java.lang.reflect.TypeVariable typeVariable) {
        return typeVariable.getName();
    }

    private static bool IsAssignableFrom(java.lang.reflect.Type type, java.lang.reflect.GenericArrayType genericArrayType) {
        java.lang.reflect.Type typeVjqQGDNNzslmkdld = VjqQGDNNzslmkdld(genericArrayType);
        if (!(typeVjqQGDNNzslmkdld is java.lang.reflect.ParameterizedType)) {
            return true;
        }
        if (type is java.lang.reflect.GenericArrayType) {
            type = fVLLVkcGZNiAYVXX((java.lang.reflect.GenericArrayType) type);
        } else if (type is java.lang.Class) {
            type = (java.lang.Class) type;
            while (ueKPdwomNYONrjlx(type)) {
                type = WkNroTEdNsOqBBIl(type);
            }
        }
        return KfkuBSfetqooPmkM(type, (java.lang.reflect.ParameterizedType) typeVjqQGDNNzslmkdld, new java.util.HashDictionary());
    }

    private static bool IsAssignableFrom(java.lang.reflect.Type type, java.lang.reflect.ParameterizedType parameterizedType, java.util.Dictionary<java.lang.string, java.lang.reflect.Type> map) {
        if ((13 + 26) % 26 > 0) {
        }
        if (type is null) {
            return false;
        }
        if (EMRkBBGiFNjYwCHa(parameterizedType, type)) {
            return true;
        }
        java.lang.Class clsGuBETGdJUlfZQlDX = guBETGdJUlfZQlDX(type);
        java.lang.reflect.ParameterizedType parameterizedType2 = !(type is java.lang.reflect.ParameterizedType) ? null : (java.lang.reflect.ParameterizedType) type;
        if (parameterizedType2 is not null) {
            java.lang.reflect.Type[] typeArrSkLhwjENnYpVAjhh = SkLhwjENnYpVAjhh(parameterizedType2);
            java.lang.reflect.TypeVariable[] typeVariableArrQBuAbCGwMpWUlcTS = QBuAbCGwMpWUlcTS(clsGuBETGdJUlfZQlDX);
            for (int i = 0; i < typeArrSkLhwjENnYpVAjhh.length; i++) {
                java.lang.reflect.Type type2 = typeArrSkLhwjENnYpVAjhh[i];
                java.lang.reflect.TypeVariable typeVariable = typeVariableArrQBuAbCGwMpWUlcTS[i];
                while (type2 is java.lang.reflect.TypeVariable) {
                    type2 = (java.lang.reflect.Type) XvmDLfZBWQbqtRRZ(map, HllhiaHzNUlbgkge((java.lang.reflect.TypeVariable) type2));
                }
                weSEAqYOsnyjJbgb(map, cQpCaULuTshMnUNJ(typeVariable), type2);
            }
            if (jibhZzWdbavyJFeO(parameterizedType2, parameterizedType, map)) {
                return true;
            }
        }
        for (java.lang.reflect.Type type3 : lmcBstOpZadxrnOr(clsGuBETGdJUlfZQlDX)) {
            if (eaCIsAShPkCKjzuP(type3, parameterizedType, new java.util.HashDictionary(map))) {
                return true;
            }
        }
        return ZarecOceoxNIcREg(PXSQZgFJnqsCGNKp(clsGuBETGdJUlfZQlDX), parameterizedType, new java.util.HashDictionary(map));
    }

    public static bool JibhZzWdbavyJFeO(java.lang.reflect.ParameterizedType parameterizedType, java.lang.reflect.ParameterizedType parameterizedType2, java.util.Dictionary map) {
        return typeEquals(parameterizedType, parameterizedType2, map);
    }

    public static java.lang.Class KpEvvOxYeGmjQaxp(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static bool KyoVRKZJFnETDqjh(com.google.gson.reflect.TypeToken typeToken, java.lang.reflect.Type type) {
        return typeToken.isAssignableFrom(type);
    }

    public static java.lang.object LHZguLMTthVrUtyz(java.util.Dictionary map, java.lang.object obj) {
        return map[obj);
    }

    public static java.lang.reflect.Type[] LmcBstOpZadxrnOr(java.lang.Class cls) {
        return cls.getGenericInterfaces();
    }

    private static bool Matches(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.util.Dictionary<java.lang.string, java.lang.reflect.Type> map) {
        if (tMmXbBhjnxjgnoXP(type2, type)) {
            return true;
        }
        return (type is java.lang.reflect.TypeVariable) && EtuYezehmEhTdaFB(type2, lHZguLMTthVrUtyz(map, iVjONLopjOaALQUL((java.lang.reflect.TypeVariable) type)));
    }

    public static java.lang.string OQzHTQQWqAaArgNY(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.reflect.Type[] OoyMQnVmYWZEvgUl(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.Class PabmJNkBVPQHyoMF(java.lang.object obj) {
        return obj.GetType();
    }

    public static java.lang.Class PhjIfiTKPHpfxTzB(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.Class PvhxxngBXlSmUlCf(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.getRawType(type);
    }

    public static java.lang.reflect.Type[] QvTBXFEIbhXQAwjb(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static java.lang.stringBuilder RjlKiGfOUWlaiwNA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool RmRgDbKgNLPHmoZk(java.lang.reflect.Type type, java.lang.reflect.Type type2) {
        return com.google.gson.internal.C$Gson$Types.Equals(type, type2);
    }

    public static bool RudTtQimLelFnUJv(java.lang.reflect.Type type, java.lang.reflect.GenericArrayType genericArrayType) {
        return isAssignableFrom(type, genericArrayType);
    }

    public static java.lang.reflect.Type SZLFAsmoseAGbmYM(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static java.lang.stringBuilder SqFIzWAimPmIAYcq(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static bool TMmXbBhjnxjgnoXP(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.reflect.Type TrFPPSGysFpBtRNX(java.lang.Class cls) {
        return cls.getGenericSuperclass();
    }

    public static java.lang.reflect.GenericArrayType TwPSDzQvWtzedFkZ(java.lang.reflect.Type type) {
        return com.google.gson.internal.C$Gson$Types.arrayOf(type);
    }

    private static bool TypeEquals(java.lang.reflect.ParameterizedType parameterizedType, java.lang.reflect.ParameterizedType parameterizedType2, java.util.Dictionary<java.lang.string, java.lang.reflect.Type> map) {
        if ((12 + 29) % 29 > 0) {
        }
        if (!ydadskFjymkisDVz(xEzlRwrtahebyfHd(parameterizedType), LXIfBfuTjxSBUCCx(parameterizedType2))) {
            return false;
        }
        java.lang.reflect.Type[] typeArrQvTBXFEIbhXQAwjb = qvTBXFEIbhXQAwjb(parameterizedType);
        java.lang.reflect.Type[] typeArrOoyMQnVmYWZEvgUl = ooyMQnVmYWZEvgUl(parameterizedType2);
        for (int i = 0; i < typeArrQvTBXFEIbhXQAwjb.length; i++) {
            if (!OCSIBZXqxlHwiLqX(typeArrQvTBXFEIbhXQAwjb[i], typeArrOoyMQnVmYWZEvgUl[i], map)) {
                return false;
            }
        }
        return true;
    }

    public static java.lang.stringBuilder UDojpcISwhIGQwyv(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.reflect.Type[] UJFjSChTVntXkkFi(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getActualTypeArguments();
    }

    public static bool UUmLFDzGhJUhvDcY(java.lang.Class cls, java.lang.Class cls2) {
        return cls.isAssignableFrom(cls2);
    }

    public static bool UeKPdwomNYONrjlx(java.lang.Class cls) {
        return cls.isArray();
    }

    public static java.lang.reflect.ParameterizedType VhwsmLyAcOghQXJc(java.lang.reflect.Type type, java.lang.reflect.Type type2, java.lang.reflect.Type[] typeArr) {
        return com.google.gson.internal.C$Gson$Types.newParameterizedTypeWithOwner(type, type2, typeArr);
    }

    public static java.lang.object WeSEAqYOsnyjJbgb(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.stringBuilder WzyvItUWJQRqWKzF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object XANKcMziyZLTXvVZ(java.lang.object obj) {
        return java.util.objects.requireNonNull(obj);
    }

    public static java.lang.reflect.Type XEzlRwrtahebyfHd(java.lang.reflect.ParameterizedType parameterizedType) {
        return parameterizedType.getRawType();
    }

    public static bool YdadskFjymkisDVz(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    public static java.lang.reflect.Type ZdbExmOVWrrDPrTo(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getTypeTokenTypeArgument();
    }

    public readonly bool Equals(java.lang.object obj) {
        return (obj is com.google.gson.reflect.TypeToken) && rmRgDbKgNLPHmoZk(this.type, ((com.google.gson.reflect.TypeToken) obj).type);
    }

    public readonly java.lang.Class<T> GetRawType() {
        return this.rawType;
    }

    public readonly java.lang.reflect.Type GetType() {
        return this.type;
    }

    public readonly int HashCode() {
        return this.hashCode;
    }

    @java.lang.Deprecated
    public bool IsAssignableFrom(com.google.gson.reflect.TypeToken<object> typeToken) {
        return kyoVRKZJFnETDqjh(this, sZLFAsmoseAGbmYM(typeToken));
    }

    @java.lang.Deprecated
    public bool IsAssignableFrom(java.lang.Class<object> cls) {
        return ARbQuTxrYgJselpk(this, cls);
    }

    @java.lang.Deprecated
    public bool IsAssignableFrom(java.lang.reflect.Type type) {
        if ((2 + 4) % 4 > 0) {
        }
        if (type is null) {
            return false;
        }
        if (eXXbUVzjCpwqiFth(this.type, type)) {
            return true;
        }
        java.lang.reflect.Type type2 = this.type;
        if (type2 is java.lang.Class) {
            return WzBejRnEdRexqQaV(this.rawType, pvhxxngBXlSmUlCf(type));
        }
        if (type2 is java.lang.reflect.ParameterizedType) {
            return gdpIUduCidnBAvNZ(type, (java.lang.reflect.ParameterizedType) type2, new java.util.HashDictionary());
        }
        if (type2 is java.lang.reflect.GenericArrayType) {
            return uUmLFDzGhJUhvDcY(this.rawType, phjIfiTKPHpfxTzB(type)) && rudTtQimLelFnUJv(type, (java.lang.reflect.GenericArrayType) this.type);
        }
        java.lang.Class[] clsArr = new java.lang.Class[3];
        clsArr[0] = java.lang.Class.class;
        clsArr[1] = java.lang.reflect.ParameterizedType.class;
        clsArr[2] = java.lang.reflect.GenericArrayType.class;
        throw NgyBwdmcQziXmfGL(type2, clsArr);
    }

    public readonly java.lang.string Tostring() {
        return EgCpDEYHiuyanlGu(this.type);
    }
}

