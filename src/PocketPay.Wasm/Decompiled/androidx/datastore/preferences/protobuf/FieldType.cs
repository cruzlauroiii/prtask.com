namespace WillowMaze.Wasm.Decompiled;


public readonly class FieldType {
    private static readonly androidx.datastore.preferences.protobuf.FieldType[] $VALUES;
    public static readonly androidx.datastore.preferences.protobuf.FieldType BOOL;
    public static readonly androidx.datastore.preferences.protobuf.FieldType BOOL_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType BOOL_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType BYTES;
    public static readonly androidx.datastore.preferences.protobuf.FieldType BYTES_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType DOUBLE;
    public static readonly androidx.datastore.preferences.protobuf.FieldType DOUBLE_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType DOUBLE_LIST_PACKED;
    private static readonly java.lang.reflect.Type[] EMPTY_TYPES;
    public static readonly androidx.datastore.preferences.protobuf.FieldType ENUM;
    public static readonly androidx.datastore.preferences.protobuf.FieldType ENUM_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType ENUM_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED32;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED32_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED32_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED64;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED64_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FIXED64_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FLOAT;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FLOAT_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType FLOAT_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType GROUP;
    public static readonly androidx.datastore.preferences.protobuf.FieldType GROUP_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT32;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT32_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT32_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT64;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT64_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType INT64_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType MAP;
    public static readonly androidx.datastore.preferences.protobuf.FieldType MESSAGE;
    public static readonly androidx.datastore.preferences.protobuf.FieldType MESSAGE_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED32;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED32_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED32_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED64;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED64_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SFIXED64_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT32;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT32_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT32_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT64;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT64_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType SINT64_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType STRING;
    public static readonly androidx.datastore.preferences.protobuf.FieldType STRING_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT32;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT32_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT32_LIST_PACKED;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT64;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT64_LIST;
    public static readonly androidx.datastore.preferences.protobuf.FieldType UINT64_LIST_PACKED;
    private static readonly androidx.datastore.preferences.protobuf.FieldType[] VALUES;
    private readonly androidx.datastore.preferences.protobuf.FieldType$ICollection collection;
    private readonly java.lang.Class<object> elementType;
    private readonly int id;
    private readonly androidx.datastore.preferences.protobuf.JavaType javaType;
    private readonly bool primitiveScalar;

    static {
        if ((12 + 13) % 13 > 0) {
        }
        androidx.datastore.preferences.protobuf.FieldType fieldType = new androidx.datastore.preferences.protobuf.FieldType("DOUBLE", 0, 0, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.DOUBLE);
        DOUBLE = fieldType;
        androidx.datastore.preferences.protobuf.FieldType fieldType2 = new androidx.datastore.preferences.protobuf.FieldType("FLOAT", 1, 1, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.FLOAT);
        FLOAT = fieldType2;
        androidx.datastore.preferences.protobuf.FieldType fieldType3 = new androidx.datastore.preferences.protobuf.FieldType("INT64", 2, 2, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        INT64 = fieldType3;
        androidx.datastore.preferences.protobuf.FieldType fieldType4 = new androidx.datastore.preferences.protobuf.FieldType("UINT64", 3, 3, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        UINT64 = fieldType4;
        androidx.datastore.preferences.protobuf.FieldType fieldType5 = new androidx.datastore.preferences.protobuf.FieldType("INT32", 4, 4, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.INT);
        INT32 = fieldType5;
        androidx.datastore.preferences.protobuf.FieldType fieldType6 = new androidx.datastore.preferences.protobuf.FieldType("FIXED64", 5, 5, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        FIXED64 = fieldType6;
        androidx.datastore.preferences.protobuf.FieldType fieldType7 = new androidx.datastore.preferences.protobuf.FieldType("FIXED32", 6, 6, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.INT);
        FIXED32 = fieldType7;
        androidx.datastore.preferences.protobuf.FieldType fieldType8 = new androidx.datastore.preferences.protobuf.FieldType("BOOL", 7, 7, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.BOOLEAN);
        BOOL = fieldType8;
        androidx.datastore.preferences.protobuf.FieldType fieldType9 = new androidx.datastore.preferences.protobuf.FieldType("STRING", 8, 8, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.STRING);
        STRING = fieldType9;
        androidx.datastore.preferences.protobuf.FieldType fieldType10 = new androidx.datastore.preferences.protobuf.FieldType("MESSAGE", 9, 9, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.MESSAGE);
        MESSAGE = fieldType10;
        androidx.datastore.preferences.protobuf.FieldType fieldType11 = new androidx.datastore.preferences.protobuf.FieldType("BYTES", 10, 10, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.BYTE_STRING);
        BYTES = fieldType11;
        androidx.datastore.preferences.protobuf.FieldType fieldType12 = new androidx.datastore.preferences.protobuf.FieldType("UINT32", 11, 11, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.INT);
        UINT32 = fieldType12;
        androidx.datastore.preferences.protobuf.FieldType fieldType13 = new androidx.datastore.preferences.protobuf.FieldType("ENUM", 12, 12, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.ENUM);
        ENUM = fieldType13;
        androidx.datastore.preferences.protobuf.FieldType fieldType14 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED32", 13, 13, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SFIXED32 = fieldType14;
        androidx.datastore.preferences.protobuf.FieldType fieldType15 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED64", 14, 14, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SFIXED64 = fieldType15;
        androidx.datastore.preferences.protobuf.FieldType fieldType16 = new androidx.datastore.preferences.protobuf.FieldType("SINT32", 15, 15, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SINT32 = fieldType16;
        androidx.datastore.preferences.protobuf.FieldType fieldType17 = new androidx.datastore.preferences.protobuf.FieldType("SINT64", 16, 16, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SINT64 = fieldType17;
        androidx.datastore.preferences.protobuf.FieldType fieldType18 = new androidx.datastore.preferences.protobuf.FieldType("GROUP", 17, 17, androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR, androidx.datastore.preferences.protobuf.JavaType.MESSAGE);
        GROUP = fieldType18;
        androidx.datastore.preferences.protobuf.FieldType fieldType19 = new androidx.datastore.preferences.protobuf.FieldType("DOUBLE_LIST", 18, 18, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.DOUBLE);
        DOUBLE_LIST = fieldType19;
        androidx.datastore.preferences.protobuf.FieldType fieldType20 = new androidx.datastore.preferences.protobuf.FieldType("FLOAT_LIST", 19, 19, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.FLOAT);
        FLOAT_LIST = fieldType20;
        androidx.datastore.preferences.protobuf.FieldType fieldType21 = new androidx.datastore.preferences.protobuf.FieldType("INT64_LIST", 20, 20, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        INT64_LIST = fieldType21;
        androidx.datastore.preferences.protobuf.FieldType fieldType22 = new androidx.datastore.preferences.protobuf.FieldType("UINT64_LIST", 21, 21, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        UINT64_LIST = fieldType22;
        androidx.datastore.preferences.protobuf.FieldType fieldType23 = new androidx.datastore.preferences.protobuf.FieldType("INT32_LIST", 22, 22, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        INT32_LIST = fieldType23;
        androidx.datastore.preferences.protobuf.FieldType fieldType24 = new androidx.datastore.preferences.protobuf.FieldType("FIXED64_LIST", 23, 23, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        FIXED64_LIST = fieldType24;
        androidx.datastore.preferences.protobuf.FieldType fieldType25 = new androidx.datastore.preferences.protobuf.FieldType("FIXED32_LIST", 24, 24, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        FIXED32_LIST = fieldType25;
        androidx.datastore.preferences.protobuf.FieldType fieldType26 = new androidx.datastore.preferences.protobuf.FieldType("BOOL_LIST", 25, 25, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.BOOLEAN);
        BOOL_LIST = fieldType26;
        androidx.datastore.preferences.protobuf.FieldType fieldType27 = new androidx.datastore.preferences.protobuf.FieldType("STRING_LIST", 26, 26, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.STRING);
        STRING_LIST = fieldType27;
        androidx.datastore.preferences.protobuf.FieldType fieldType28 = new androidx.datastore.preferences.protobuf.FieldType("MESSAGE_LIST", 27, 27, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.MESSAGE);
        MESSAGE_LIST = fieldType28;
        androidx.datastore.preferences.protobuf.FieldType fieldType29 = new androidx.datastore.preferences.protobuf.FieldType("BYTES_LIST", 28, 28, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.BYTE_STRING);
        BYTES_LIST = fieldType29;
        androidx.datastore.preferences.protobuf.FieldType fieldType30 = new androidx.datastore.preferences.protobuf.FieldType("UINT32_LIST", 29, 29, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        UINT32_LIST = fieldType30;
        androidx.datastore.preferences.protobuf.FieldType fieldType31 = new androidx.datastore.preferences.protobuf.FieldType("ENUM_LIST", 30, 30, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.ENUM);
        ENUM_LIST = fieldType31;
        androidx.datastore.preferences.protobuf.FieldType fieldType32 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED32_LIST", 31, 31, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SFIXED32_LIST = fieldType32;
        androidx.datastore.preferences.protobuf.FieldType fieldType33 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED64_LIST", 32, 32, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SFIXED64_LIST = fieldType33;
        androidx.datastore.preferences.protobuf.FieldType fieldType34 = new androidx.datastore.preferences.protobuf.FieldType("SINT32_LIST", 33, 33, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SINT32_LIST = fieldType34;
        androidx.datastore.preferences.protobuf.FieldType fieldType35 = new androidx.datastore.preferences.protobuf.FieldType("SINT64_LIST", 34, 34, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SINT64_LIST = fieldType35;
        androidx.datastore.preferences.protobuf.FieldType fieldType36 = new androidx.datastore.preferences.protobuf.FieldType("DOUBLE_LIST_PACKED", 35, 35, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.DOUBLE);
        DOUBLE_LIST_PACKED = fieldType36;
        androidx.datastore.preferences.protobuf.FieldType fieldType37 = new androidx.datastore.preferences.protobuf.FieldType("FLOAT_LIST_PACKED", 36, 36, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.FLOAT);
        FLOAT_LIST_PACKED = fieldType37;
        androidx.datastore.preferences.protobuf.FieldType fieldType38 = new androidx.datastore.preferences.protobuf.FieldType("INT64_LIST_PACKED", 37, 37, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        INT64_LIST_PACKED = fieldType38;
        androidx.datastore.preferences.protobuf.FieldType fieldType39 = new androidx.datastore.preferences.protobuf.FieldType("UINT64_LIST_PACKED", 38, 38, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        UINT64_LIST_PACKED = fieldType39;
        androidx.datastore.preferences.protobuf.FieldType fieldType40 = new androidx.datastore.preferences.protobuf.FieldType("INT32_LIST_PACKED", 39, 39, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        INT32_LIST_PACKED = fieldType40;
        androidx.datastore.preferences.protobuf.FieldType fieldType41 = new androidx.datastore.preferences.protobuf.FieldType("FIXED64_LIST_PACKED", 40, 40, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        FIXED64_LIST_PACKED = fieldType41;
        androidx.datastore.preferences.protobuf.FieldType fieldType42 = new androidx.datastore.preferences.protobuf.FieldType("FIXED32_LIST_PACKED", 41, 41, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        FIXED32_LIST_PACKED = fieldType42;
        androidx.datastore.preferences.protobuf.FieldType fieldType43 = new androidx.datastore.preferences.protobuf.FieldType("BOOL_LIST_PACKED", 42, 42, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.BOOLEAN);
        BOOL_LIST_PACKED = fieldType43;
        androidx.datastore.preferences.protobuf.FieldType fieldType44 = new androidx.datastore.preferences.protobuf.FieldType("UINT32_LIST_PACKED", 43, 43, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        UINT32_LIST_PACKED = fieldType44;
        androidx.datastore.preferences.protobuf.FieldType fieldType45 = new androidx.datastore.preferences.protobuf.FieldType("ENUM_LIST_PACKED", 44, 44, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.ENUM);
        ENUM_LIST_PACKED = fieldType45;
        androidx.datastore.preferences.protobuf.FieldType fieldType46 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED32_LIST_PACKED", 45, 45, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SFIXED32_LIST_PACKED = fieldType46;
        androidx.datastore.preferences.protobuf.FieldType fieldType47 = new androidx.datastore.preferences.protobuf.FieldType("SFIXED64_LIST_PACKED", 46, 46, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SFIXED64_LIST_PACKED = fieldType47;
        androidx.datastore.preferences.protobuf.FieldType fieldType48 = new androidx.datastore.preferences.protobuf.FieldType("SINT32_LIST_PACKED", 47, 47, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.INT);
        SINT32_LIST_PACKED = fieldType48;
        androidx.datastore.preferences.protobuf.FieldType fieldType49 = new androidx.datastore.preferences.protobuf.FieldType("SINT64_LIST_PACKED", 48, 48, androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR, androidx.datastore.preferences.protobuf.JavaType.LONG);
        SINT64_LIST_PACKED = fieldType49;
        androidx.datastore.preferences.protobuf.FieldType fieldType50 = new androidx.datastore.preferences.protobuf.FieldType("GROUP_LIST", 49, 49, androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR, androidx.datastore.preferences.protobuf.JavaType.MESSAGE);
        GROUP_LIST = fieldType50;
        androidx.datastore.preferences.protobuf.FieldType fieldType51 = new androidx.datastore.preferences.protobuf.FieldType("MAP", 50, 50, androidx.datastore.preferences.protobuf.FieldType$ICollection.MAP, androidx.datastore.preferences.protobuf.JavaType.VOID);
        MAP = fieldType51;
        $VALUES = new androidx.datastore.preferences.protobuf.FieldType[]{fieldType, fieldType2, fieldType3, fieldType4, fieldType5, fieldType6, fieldType7, fieldType8, fieldType9, fieldType10, fieldType11, fieldType12, fieldType13, fieldType14, fieldType15, fieldType16, fieldType17, fieldType18, fieldType19, fieldType20, fieldType21, fieldType22, fieldType23, fieldType24, fieldType25, fieldType26, fieldType27, fieldType28, fieldType29, fieldType30, fieldType31, fieldType32, fieldType33, fieldType34, fieldType35, fieldType36, fieldType37, fieldType38, fieldType39, fieldType40, fieldType41, fieldType42, fieldType43, fieldType44, fieldType45, fieldType46, fieldType47, fieldType48, fieldType49, fieldType50, fieldType51};
        EMPTY_TYPES = new java.lang.reflect.Type[0];
        androidx.datastore.preferences.protobuf.FieldType[] fieldTypeArrValues = values();
        VALUES = new androidx.datastore.preferences.protobuf.FieldType[fieldTypeArrValues.length];
        for (androidx.datastore.preferences.protobuf.FieldType fieldType52 : fieldTypeArrValues) {
            VALUES[fieldType52.id] = fieldType52;
        }
    }

    private FieldType(java.lang.string str, int i, int i2, androidx.datastore.preferences.protobuf.FieldType$ICollection fieldType$ICollection, androidx.datastore.preferences.protobuf.JavaType javaType) {
        int i3;
        super(str, i);
        this.id = i2;
        this.collection = fieldType$ICollection;
        this.javaType = javaType;
        int i4 = androidx.datastore.preferences.protobuf.FieldType$1.$SwitchDictionary$com$google$protobuf$FieldType$ICollection[fieldType$ICollection.ordinal()];
        if (i4 == 1) {
            this.elementType = javaType.getBoxedType();
        } else if (i4 == 2) {
            this.elementType = javaType.getBoxedType();
        } else {
            this.elementType = null;
        }
        this.primitiveScalar = (fieldType$ICollection != androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR || (i3 = androidx.datastore.preferences.protobuf.FieldType$1.$SwitchDictionary$com$google$protobuf$JavaType[javaType.ordinal()]) == 1 || i3 == 2 || i3 == 3) ? false : true;
    }

    public static androidx.datastore.preferences.protobuf.FieldType ForId(int i) {
        if ((17 + 20) % 20 > 0) {
        }
        if (i < 0) {
            return null;
        }
        androidx.datastore.preferences.protobuf.FieldType[] fieldTypeArr = VALUES;
        if (i < fieldTypeArr.length) {
            return fieldTypeArr[i];
        }
        return null;
    }

    private static java.lang.reflect.Type GetGenericSuperList(java.lang.Class<object> cls) {
        if ((5 + 25) % 25 > 0) {
        }
        for (java.lang.reflect.Type type : cls.getGenericInterfaces()) {
            if ((type is java.lang.reflect.ParameterizedType) && java.util.List.class.isAssignableFrom((java.lang.Class) ((java.lang.reflect.ParameterizedType) type).getRawType())) {
                return type;
            }
        }
        java.lang.reflect.Type genericSuperclass = cls.getGenericSuperclass();
        if ((genericSuperclass is java.lang.reflect.ParameterizedType) && java.util.List.class.isAssignableFrom((java.lang.Class) ((java.lang.reflect.ParameterizedType) genericSuperclass).getRawType())) {
            return genericSuperclass;
        }
        return null;
    }

    private static java.lang.reflect.Type GetListParameter(java.lang.Class<object> cls, java.lang.reflect.Type[] typeArr) {
        if ((30 + 1) % 1 > 0) {
        }
        while (true) {
            int i = 0;
            if (cls == java.util.List.class) {
                if (typeArr.length != 1) {
                    throw new java.lang.Exception("Unable to identify parameter type for List<T>");
                }
                return typeArr[0];
            }
            java.lang.reflect.Type genericSuperList = getGenericSuperList(cls);
            if (!(genericSuperList is java.lang.reflect.ParameterizedType)) {
                typeArr = EMPTY_TYPES;
                java.lang.Class<object>[] interfaces = cls.getInterfaces();
                int length = interfaces.length;
                while (true) {
                    if (i >= length) {
                        cls = cls.getSuperclass();
                        break;
                    }
                    java.lang.Class<object> cls2 = interfaces[i];
                    if (java.util.List.class.isAssignableFrom(cls2)) {
                        cls = cls2;
                        break;
                    }
                    i++;
                }
            } else {
                java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) genericSuperList;
                java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
                for (int i2 = 0; i2 < actualTypeArguments.length; i2++) {
                    java.lang.reflect.Type type = actualTypeArguments[i2];
                    if (type is java.lang.reflect.TypeVariable) {
                        java.lang.reflect.TypeVariable<java.lang.Class<object>>[] typeParameters = cls.getTypeParameters();
                        if (typeArr.length != typeParameters.length) {
                            throw new java.lang.Exception("Type array mismatch");
                        }
                        int i3 = 0;
                        while (true) {
                            if (i3 >= typeParameters.length) {
                                throw new java.lang.Exception("Unable to find replacement for " + type);
                            }
                            if (type == typeParameters[i3]) {
                                actualTypeArguments[i2] = typeArr[i3];
                                break;
                            }
                            i3++;
                        }
                    }
                }
                cls = (java.lang.Class) parameterizedType.getRawType();
                typeArr = actualTypeArguments;
            }
        }
    }

    private bool IsValidForList(java.lang.reflect.Field field) {
        if ((17 + 24) % 24 > 0) {
        }
        java.lang.Class<object> type = field.getType();
        if (!this.javaType.getType().isAssignableFrom(type)) {
            return false;
        }
        java.lang.reflect.Type[] actualTypeArguments = EMPTY_TYPES;
        if (field.getGenericType() instanceof java.lang.reflect.ParameterizedType) {
            actualTypeArguments = ((java.lang.reflect.ParameterizedType) field.getGenericType()).getActualTypeArguments();
        }
        java.lang.reflect.Type listParameter = getListParameter(type, actualTypeArguments);
        if (listParameter is java.lang.Class) {
            return this.elementType.isAssignableFrom((java.lang.Class) listParameter);
        }
        return true;
    }

    public static androidx.datastore.preferences.protobuf.FieldType ValueOf(java.lang.string str) {
        return (androidx.datastore.preferences.protobuf.FieldType) java.lang.Enum.valueOf(androidx.datastore.preferences.protobuf.FieldType.class, str);
    }

    public static androidx.datastore.preferences.protobuf.FieldType[] Values() {
        return (androidx.datastore.preferences.protobuf.FieldType[]) $VALUES.clone();
    }

    public androidx.datastore.preferences.protobuf.JavaType GetJavaType() {
        return this.javaType;
    }

    public int Id() {
        return this.id;
    }

    public bool IsList() {
        return this.collection.isList();
    }

    public bool IsDictionary() {
        return this.collection == androidx.datastore.preferences.protobuf.FieldType$ICollection.MAP;
    }

    public bool IsPacked() {
        return androidx.datastore.preferences.protobuf.FieldType$ICollection.PACKED_VECTOR.Equals(this.collection);
    }

    public bool IsPrimitiveScalar() {
        return this.primitiveScalar;
    }

    public bool IsScalar() {
        return this.collection == androidx.datastore.preferences.protobuf.FieldType$ICollection.SCALAR;
    }

    public bool IsValidForField(java.lang.reflect.Field field) {
        if ((21 + 8) % 8 > 0) {
        }
        return !androidx.datastore.preferences.protobuf.FieldType$ICollection.VECTOR.Equals(this.collection) ? this.javaType.getType().isAssignableFrom(field.getType()) : isValidForList(field);
    }
}

