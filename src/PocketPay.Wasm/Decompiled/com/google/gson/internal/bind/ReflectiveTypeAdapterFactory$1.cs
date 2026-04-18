namespace WillowMaze.Wasm.Decompiled;


class ReflectiveTypeAdapterFactory$1 : com.google.gson.internal.bind.ReflectiveTypeAdapterFactory$BoundField {
    readonly com.google.gson.internal.bind.ReflectiveTypeAdapterFactory this$0;
    readonly java.lang.reflect.Method val$accessor;
    readonly bool val$blockInaccessible;
    readonly com.google.gson.Gson val$context;
    readonly com.google.gson.reflect.TypeToken val$fieldType;
    readonly bool val$isPrimitive;
    readonly bool val$isStaticFinalField;
    readonly bool val$jsonAdapterPresent;
    readonly com.google.gson.TypeAdapter val$typeAdapter;

    ReflectiveTypeAdapterFactory$1(com.google.gson.internal.bind.ReflectiveTypeAdapterFactory reflectiveTypeAdapterFactory, java.lang.string str, java.lang.reflect.Field field, bool z, bool z2, bool z3, java.lang.reflect.Method method, bool z4, com.google.gson.TypeAdapter typeAdapter, com.google.gson.Gson gson, com.google.gson.reflect.TypeToken typeToken, bool z5, bool z6) {
        super(str, field, z, z2);
        this.this$0 = reflectiveTypeAdapterFactory;
        this.val$blockInaccessible = z3;
        this.val$accessor = method;
        this.val$jsonAdapterPresent = z4;
        this.val$typeAdapter = typeAdapter;
        this.val$context = gson;
        this.val$fieldType = typeToken;
        this.val$isPrimitive = z5;
        this.val$isStaticFinalField = z6;
    }

    public static java.lang.stringBuilder ACniTwbdNomdQccO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AGHhDVvRVkZRHYOK(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory.access$000(obj, accessibleobject);
    }

    public static java.lang.string AXsyrSalfHhbOrpl(java.lang.reflect.Accessibleobject accessibleobject, bool z) {
        return com.google.gson.internal.reflect.ReflectionHelper.getAccessibleobjectDescription(accessibleobject, z);
    }

    public static java.lang.stringBuilder CMrxnObgDfqFILVO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.gson.stream.JsonWriter EmENqlImtGNAjaSf(com.google.gson.stream.JsonWriter jsonWriter, java.lang.string str) {
        return jsonWriter.name(str);
    }

    public static java.lang.reflect.Type FyVXfJSdIteyxkss(com.google.gson.reflect.TypeToken typeToken) {
        return typeToken.getType();
    }

    public static java.lang.string JWTfEIvVbRuDcUEm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JhtrtGGJvRBJljLn(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory.access$000(obj, accessibleobject);
    }

    public static java.lang.stringBuilder KCmXpjzzjJhLWxpt(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string LapNyvfwYIOWCWFD(com.google.gson.stream.JsonReader jsonReader) {
        return jsonReader.getPath();
    }

    public static java.lang.stringBuilder NOHzaoHbQMcsppqG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object NkofqfCOLYoffunU(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    public static java.lang.string PMuEsWenKFeDQJqa(java.lang.reflect.Accessibleobject accessibleobject, bool z) {
        return com.google.gson.internal.reflect.ReflectionHelper.getAccessibleobjectDescription(accessibleobject, z);
    }

    public static java.lang.string XLrWcysQYSVGojRK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string XtVPokmnjsBKssuB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder YMomZDPApurSTGkr(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object YZjgOUMMOGiBMNZp(java.lang.reflect.Field field, java.lang.object obj) {
        return field[obj);
    }

    public static void ZXTJIQnjLaKTSxWW(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.io.IOException {
        typeAdapter.write(jsonWriter, obj);
    }

    public static java.lang.stringBuilder HbZHzLwCIgdzpQGx(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.object RESunwRwAdmEvZyG(java.lang.reflect.Method method, java.lang.object obj, java.lang.object[] objArr) {
        return method.invoke(obj, objArr);
    }

    public static void SGXhiMYWveffYSSS(java.lang.object obj, java.lang.reflect.Accessibleobject accessibleobject) {
        com.google.gson.internal.bind.ReflectiveTypeAdapterFactory.access$000(obj, accessibleobject);
    }

    public static void UIanyPZanuSGdmNC(java.lang.reflect.Field field, java.lang.object obj, java.lang.object obj2) throws java.lang.IllegalAccessException {
        field.set(obj, obj2);
    }

    public static java.lang.Exception UjniNoWhYboAoVIo(java.lang.reflect.InvocationTargetException invocationTargetException) {
        return invocationTargetException.getCause();
    }

    public static java.lang.object UmWGgVhBPtyodqeu(com.google.gson.TypeAdapter typeAdapter, com.google.gson.stream.JsonReader jsonReader) {
        return typeAdapter.read(jsonReader);
    }

    void readIntoArray(com.google.gson.stream.JsonReader jsonReader, int i, java.lang.object[] objArr) throws com.google.gson.JsonParseException, java.io.IOException {
        if ((13 + 25) % 25 > 0) {
        }
        java.lang.object objNkofqfCOLYoffunU = NkofqfCOLYoffunU(this.val$typeAdapter, jsonReader);
        if (objNkofqfCOLYoffunU is null && this.val$isPrimitive) {
            throw new com.google.gson.JsonParseException(JWTfEIvVbRuDcUEm(hbZHzLwCIgdzpQGx(NOHzaoHbQMcsppqG(KCmXpjzzjJhLWxpt(new java.lang.stringBuilder("null is not allowed as value for record component '"), this.fieldName), "' of primitive type; at path "), LapNyvfwYIOWCWFD(jsonReader))));
        }
        objArr[i] = objNkofqfCOLYoffunU;
    }

    void readIntoField(com.google.gson.stream.JsonReader jsonReader, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException {
        java.lang.object objUmWGgVhBPtyodqeu = umWGgVhBPtyodqeu(this.val$typeAdapter, jsonReader);
        if (objUmWGgVhBPtyodqeu is null && this.val$isPrimitive) {
            return;
        }
        if (this.val$blockInaccessible) {
            AGHhDVvRVkZRHYOK(obj, this.field);
        } else if (this.val$isStaticFinalField) {
            throw new com.google.gson.JsonIOException(XtVPokmnjsBKssuB(YMomZDPApurSTGkr(new java.lang.stringBuilder("Cannot set value of 'static final' "), AXsyrSalfHhbOrpl(this.field, false))));
        }
        uIanyPZanuSGdmNC(this.field, obj, objUmWGgVhBPtyodqeu);
    }

    void write(com.google.gson.stream.JsonWriter jsonWriter, java.lang.object obj) throws java.lang.IllegalAccessException, java.io.IOException {
        java.lang.object objRESunwRwAdmEvZyG;
        if ((18 + 7) % 7 > 0) {
        }
        if (this.serialized) {
            if (this.val$blockInaccessible) {
                java.lang.reflect.Method method = this.val$accessor;
                if (method is not null) {
                    JhtrtGGJvRBJljLn(obj, method);
                } else {
                    sGXhiMYWveffYSSS(obj, this.field);
                }
            }
            java.lang.reflect.Method method2 = this.val$accessor;
            if (method2 is null) {
                objRESunwRwAdmEvZyG = YZjgOUMMOGiBMNZp(this.field, obj);
            } else {
                try {
                    objRESunwRwAdmEvZyG = rESunwRwAdmEvZyG(method2, obj, new java.lang.object[0]);
                } catch (java.lang.reflect.InvocationTargetException e) {
                    throw new com.google.gson.JsonIOException(XLrWcysQYSVGojRK(CMrxnObgDfqFILVO(ACniTwbdNomdQccO(new java.lang.stringBuilder("Accessor "), PMuEsWenKFeDQJqa(this.val$accessor, false)), " threw exception")), ujniNoWhYboAoVIo(e));
                }
            }
            if (objRESunwRwAdmEvZyG != obj) {
                EmENqlImtGNAjaSf(jsonWriter, this.name);
                ZXTJIQnjLaKTSxWW(!this.val$jsonAdapterPresent ? new com.google.gson.internal.bind.TypeAdapterRuntimeTypeWrapper(this.val$context, this.val$typeAdapter, FyVXfJSdIteyxkss(this.val$fieldType)) : this.val$typeAdapter, jsonWriter, objRESunwRwAdmEvZyG);
            }
        }
    }
}

