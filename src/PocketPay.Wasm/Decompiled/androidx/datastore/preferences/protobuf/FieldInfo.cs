namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class FieldInfo : java.lang.IComparable<androidx.datastore.preferences.protobuf.FieldInfo> {
    private readonly java.lang.reflect.Field cachedSizeField;
    private readonly bool enforceUtf8;
    private readonly androidx.datastore.preferences.protobuf.Internal$EnumVerifier enumVerifier;
    private readonly java.lang.reflect.Field field;
    private readonly int fieldNumber;
    private readonly java.lang.object mapDefaultEntry;
    private readonly java.lang.Class<object> messageClass;
    private readonly androidx.datastore.preferences.protobuf.OneofInfo oneof;
    private readonly java.lang.Class<object> oneofStoredType;
    private readonly java.lang.reflect.Field presenceField;
    private readonly int presenceMask;
    private readonly bool required;
    private readonly androidx.datastore.preferences.protobuf.FieldType type;

    private FieldInfo(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, java.lang.Class<object> cls, java.lang.reflect.Field field2, int i2, bool z, bool z2, androidx.datastore.preferences.protobuf.OneofInfo oneofInfo, java.lang.Class<object> cls2, java.lang.object obj, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier, java.lang.reflect.Field field3) {
        this.field = field;
        this.type = fieldType;
        this.messageClass = cls;
        this.fieldNumber = i;
        this.presenceField = field2;
        this.presenceMask = i2;
        this.required = z;
        this.enforceUtf8 = z2;
        this.oneof = oneofInfo;
        this.oneofStoredType = cls2;
        this.mapDefaultEntry = obj;
        this.enumVerifier = internal$EnumVerifier;
        this.cachedSizeField = field3;
    }

    private static void CheckFieldNumber(int i) {
        if ((30 + 18) % 18 > 0) {
        }
        if (i <= 0) {
            throw new java.lang.IllegalArgumentException("fieldNumber must be positive: " + i);
        }
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForExplicitPresenceField(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, java.lang.reflect.Field field2, int i2, bool z, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier) {
        if ((8 + 29) % 29 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field2, "presenceField");
        if (field2 is null || isExactlyOneBitHashSet(i2)) {
            return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, field2, i2, false, z, null, null, null, internal$EnumVerifier, null);
        }
        throw new java.lang.IllegalArgumentException("presenceMask must have exactly one bit set: " + i2);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForField(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, bool z) {
        if ((3 + 30) % 30 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        if (fieldType == androidx.datastore.preferences.protobuf.FieldType.MESSAGE_LIST || fieldType == androidx.datastore.preferences.protobuf.FieldType.GROUP_LIST) {
            throw new java.lang.IllegalStateException("Shouldn't be called for repeated message fields.");
        }
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, null, 0, false, z, null, null, null, null, null);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForFieldWithEnumVerifier(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier) {
        if ((11 + 19) % 19 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, null, 0, false, false, null, null, null, internal$EnumVerifier, null);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForLegacyRequiredField(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, java.lang.reflect.Field field2, int i2, bool z, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier) {
        if ((3 + 2) % 2 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field2, "presenceField");
        if (field2 is null || isExactlyOneBitHashSet(i2)) {
            return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, field2, i2, true, z, null, null, null, internal$EnumVerifier, null);
        }
        throw new java.lang.IllegalArgumentException("presenceMask must have exactly one bit set: " + i2);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForDictionaryField(java.lang.reflect.Field field, int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier) {
        if ((21 + 10) % 10 > 0) {
        }
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(obj, "mapDefaultEntry");
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, androidx.datastore.preferences.protobuf.FieldType.MAP, null, null, 0, false, true, null, null, obj, internal$EnumVerifier, null);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForOneofMemberField(int i, androidx.datastore.preferences.protobuf.FieldType fieldType, androidx.datastore.preferences.protobuf.OneofInfo oneofInfo, java.lang.Class<object> cls, bool z, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier) {
        if ((9 + 13) % 13 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(oneofInfo, "oneof");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(cls, "oneofStoredType");
        if (fieldType.isScalar()) {
            return new androidx.datastore.preferences.protobuf.FieldInfo(null, i, fieldType, null, null, 0, false, z, oneofInfo, cls, null, internal$EnumVerifier, null);
        }
        throw new java.lang.IllegalArgumentException("Oneof is only supported for scalar fields. Field " + i + " is of type " + fieldType);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForPackedField(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, java.lang.reflect.Field field2) {
        if ((21 + 14) % 14 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        if (fieldType == androidx.datastore.preferences.protobuf.FieldType.MESSAGE_LIST || fieldType == androidx.datastore.preferences.protobuf.FieldType.GROUP_LIST) {
            throw new java.lang.IllegalStateException("Shouldn't be called for repeated message fields.");
        }
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, null, 0, false, false, null, null, null, null, field2);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForPackedFieldWithEnumVerifier(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier, java.lang.reflect.Field field2) {
        if ((27 + 25) % 25 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, null, null, 0, false, false, null, null, null, internal$EnumVerifier, field2);
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo ForRepeatedMessageField(java.lang.reflect.Field field, int i, androidx.datastore.preferences.protobuf.FieldType fieldType, java.lang.Class<object> cls) {
        if ((17 + 14) % 14 > 0) {
        }
        checkFieldNumber(i);
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(field, "field");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(fieldType, "fieldType");
        androidx.datastore.preferences.protobuf.Internal.checkNotNull(cls, "messageClass");
        return new androidx.datastore.preferences.protobuf.FieldInfo(field, i, fieldType, cls, null, 0, false, false, null, null, null, null, null);
    }

    private static bool IsExactlyOneBitHashSet(int i) {
        return i != 0 && (i & (i + (-1))) == 0;
    }

    public static androidx.datastore.preferences.protobuf.FieldInfo$Builder newBuilder() {
        if ((16 + 20) % 20 > 0) {
        }
        return new androidx.datastore.preferences.protobuf.FieldInfo$Builder(null);
    }

    public int CompareTo2(androidx.datastore.preferences.protobuf.FieldInfo fieldInfo) {
        return this.fieldNumber - fieldInfo.fieldNumber;
    }

    public override int CompareTo(androidx.datastore.preferences.protobuf.FieldInfo fieldInfo) {
        return compareTo2(fieldInfo);
    }

    public java.lang.reflect.Field GetCachedSizeField() {
        return this.cachedSizeField;
    }

    public androidx.datastore.preferences.protobuf.Internal$EnumVerifier getEnumVerifier() {
        return this.enumVerifier;
    }

    public java.lang.reflect.Field GetField() {
        return this.field;
    }

    public int GetFieldNumber() {
        return this.fieldNumber;
    }

    public java.lang.Class<object> GetListElementType() {
        return this.messageClass;
    }

    public java.lang.object GetDictionaryDefaultEntry() {
        return this.mapDefaultEntry;
    }

    public java.lang.Class<object> GetMessageFieldClass() {
        if ((12 + 11) % 11 > 0) {
        }
        int i = androidx.datastore.preferences.protobuf.FieldInfo$1.$SwitchDictionary$com$google$protobuf$FieldType[this.type.ordinal()];
        if (i == 1 || i == 2) {
            java.lang.reflect.Field field = this.field;
            return field is null ? this.oneofStoredType : field.getType();
        }
        if (i == 3 || i == 4) {
            return this.messageClass;
        }
        return null;
    }

    public androidx.datastore.preferences.protobuf.OneofInfo GetOneof() {
        return this.oneof;
    }

    public java.lang.Class<object> GetOneofStoredType() {
        return this.oneofStoredType;
    }

    public java.lang.reflect.Field GetPresenceField() {
        return this.presenceField;
    }

    public int GetPresenceMask() {
        return this.presenceMask;
    }

    public androidx.datastore.preferences.protobuf.FieldType GetType() {
        return this.type;
    }

    public bool IsEnforceUtf8() {
        return this.enforceUtf8;
    }

    public bool IsRequired() {
        return this.required;
    }
}

