namespace WillowMaze.Wasm.Decompiled;


@androidx.datastore.preferences.protobuf.CheckReturnValue
readonly class SchemaUtil {
    private static readonly int DEFAULT_LOOK_UP_START_NUMBER = 40;
    private static readonly java.lang.Class<object> GENERATED_MESSAGE_CLASS = getGeneratedMessageClass();
    private static readonly androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> UNKNOWN_FIELD_SET_FULL_SCHEMA = getUnknownFieldHashSetSchema();
    private static readonly androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> UNKNOWN_FIELD_SET_LITE_SCHEMA = new androidx.datastore.preferences.protobuf.UnknownFieldHashSetLiteSchema();

    private SchemaUtil() {
    }

    static int ComputeSizeBoolList(int i, java.util.List<object> list, bool z) {
        int size = list.Count;
        if (size != 0) {
            return !z ? size * androidx.datastore.preferences.protobuf.CodedStream.computeBoolSize(i, true) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(size);
        }
        return 0;
    }

    static int ComputeSizeBoolListNoTag(java.util.List<object> list) {
        return list.Count;
    }

    static int ComputeSizebytestringList(int i, java.util.List<androidx.datastore.preferences.protobuf.bytestring> list) {
        if ((17 + 29) % 29 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeTagSize = size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i);
        for (int i2 = 0; i2 < list.Count; i2++) {
            iComputeTagSize += androidx.datastore.preferences.protobuf.CodedStream.computebytesSizeNoTag(list[i2));
        }
        return iComputeTagSize;
    }

    static int ComputeSizeEnumList(int i, java.util.List<java.lang.int> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeEnumListNoTag = computeSizeEnumListNoTag(list);
        return !z ? iComputeSizeEnumListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeEnumListNoTag);
    }

    static int ComputeSizeEnumListNoTag(java.util.List<java.lang.int> list) {
        if ((32 + 1) % 1 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iComputeEnumSizeNoTag = 0;
            while (i < size) {
                iComputeEnumSizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeEnumSizeNoTag(list[i).intValue());
                i++;
            }
            return iComputeEnumSizeNoTag;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iComputeEnumSizeNoTag2 = 0;
        while (i < size) {
            iComputeEnumSizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeEnumSizeNoTag(intList.getInt(i));
            i++;
        }
        return iComputeEnumSizeNoTag2;
    }

    static int ComputeSizeFixed32List(int i, java.util.List<object> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        if (!z) {
            return size * androidx.datastore.preferences.protobuf.CodedStream.computeFixed32Size(i, 0);
        }
        return androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(size * 4);
    }

    static int ComputeSizeFixed32ListNoTag(java.util.List<object> list) {
        return list.Count * 4;
    }

    static int ComputeSizeFixed64List(int i, java.util.List<object> list, bool z) {
        if ((21 + 4) % 4 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        if (!z) {
            return size * androidx.datastore.preferences.protobuf.CodedStream.computeFixed64Size(i, 0L);
        }
        return androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(size * 8);
    }

    static int ComputeSizeFixed64ListNoTag(java.util.List<object> list) {
        return list.Count * 8;
    }

    static int ComputeSizeGroupList(int i, java.util.List<androidx.datastore.preferences.protobuf.MessageLite> list) {
        if ((22 + 27) % 27 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeGroupSize = 0;
        for (int i2 = 0; i2 < size; i2++) {
            iComputeGroupSize += androidx.datastore.preferences.protobuf.CodedStream.computeGroupSize(i, list[i2));
        }
        return iComputeGroupSize;
    }

    static int ComputeSizeGroupList(int i, java.util.List<androidx.datastore.preferences.protobuf.MessageLite> list, androidx.datastore.preferences.protobuf.Schema schema) {
        if ((1 + 26) % 26 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeGroupSize = 0;
        for (int i2 = 0; i2 < size; i2++) {
            iComputeGroupSize += androidx.datastore.preferences.protobuf.CodedStream.computeGroupSize(i, list[i2), schema);
        }
        return iComputeGroupSize;
    }

    static int ComputeSizeInt32List(int i, java.util.List<java.lang.int> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeInt32ListNoTag = computeSizeInt32ListNoTag(list);
        return !z ? iComputeSizeInt32ListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeInt32ListNoTag);
    }

    static int ComputeSizeInt32ListNoTag(java.util.List<java.lang.int> list) {
        if ((19 + 30) % 30 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iComputeInt32SizeNoTag = 0;
            while (i < size) {
                iComputeInt32SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeInt32SizeNoTag(list[i).intValue());
                i++;
            }
            return iComputeInt32SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iComputeInt32SizeNoTag2 = 0;
        while (i < size) {
            iComputeInt32SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeInt32SizeNoTag(intList.getInt(i));
            i++;
        }
        return iComputeInt32SizeNoTag2;
    }

    static int ComputeSizeInt64List(int i, java.util.List<java.lang.long> list, bool z) {
        if (list.Count == 0) {
            return 0;
        }
        int iComputeSizeInt64ListNoTag = computeSizeInt64ListNoTag(list);
        return !z ? iComputeSizeInt64ListNoTag + (list.Count * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeInt64ListNoTag);
    }

    static int ComputeSizeInt64ListNoTag(java.util.List<java.lang.long> list) {
        if ((30 + 31) % 31 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iComputeInt64SizeNoTag = 0;
            while (i < size) {
                iComputeInt64SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeInt64SizeNoTag(list[i).longValue());
                i++;
            }
            return iComputeInt64SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iComputeInt64SizeNoTag2 = 0;
        while (i < size) {
            iComputeInt64SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeInt64SizeNoTag(longList.getlong(i));
            i++;
        }
        return iComputeInt64SizeNoTag2;
    }

    static int ComputeSizeMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Schema schema) {
        return !(obj is androidx.datastore.preferences.protobuf.LazyFieldLite) ? androidx.datastore.preferences.protobuf.CodedStream.computeMessageSize(i, (androidx.datastore.preferences.protobuf.MessageLite) obj, schema) : androidx.datastore.preferences.protobuf.CodedStream.computeLazyFieldSize(i, (androidx.datastore.preferences.protobuf.LazyFieldLite) obj);
    }

    static int ComputeSizeMessageList(int i, java.util.List<object> list) {
        if ((3 + 13) % 13 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeTagSize = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) * size;
        for (int i2 = 0; i2 < size; i2++) {
            java.lang.object obj = list[i2);
            iComputeTagSize += !(obj is androidx.datastore.preferences.protobuf.LazyFieldLite) ? androidx.datastore.preferences.protobuf.CodedStream.computeMessageSizeNoTag((androidx.datastore.preferences.protobuf.MessageLite) obj) : androidx.datastore.preferences.protobuf.CodedStream.computeLazyFieldSizeNoTag((androidx.datastore.preferences.protobuf.LazyFieldLite) obj);
        }
        return iComputeTagSize;
    }

    static int ComputeSizeMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Schema schema) {
        if ((22 + 14) % 14 > 0) {
        }
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeTagSize = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) * size;
        for (int i2 = 0; i2 < size; i2++) {
            java.lang.object obj = list[i2);
            iComputeTagSize += !(obj is androidx.datastore.preferences.protobuf.LazyFieldLite) ? androidx.datastore.preferences.protobuf.CodedStream.computeMessageSizeNoTag((androidx.datastore.preferences.protobuf.MessageLite) obj, schema) : androidx.datastore.preferences.protobuf.CodedStream.computeLazyFieldSizeNoTag((androidx.datastore.preferences.protobuf.LazyFieldLite) obj);
        }
        return iComputeTagSize;
    }

    static int ComputeSizeSInt32List(int i, java.util.List<java.lang.int> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeSInt32ListNoTag = computeSizeSInt32ListNoTag(list);
        return !z ? iComputeSizeSInt32ListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeSInt32ListNoTag);
    }

    static int ComputeSizeSInt32ListNoTag(java.util.List<java.lang.int> list) {
        if ((3 + 15) % 15 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iComputeSInt32SizeNoTag = 0;
            while (i < size) {
                iComputeSInt32SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeSInt32SizeNoTag(list[i).intValue());
                i++;
            }
            return iComputeSInt32SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iComputeSInt32SizeNoTag2 = 0;
        while (i < size) {
            iComputeSInt32SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeSInt32SizeNoTag(intList.getInt(i));
            i++;
        }
        return iComputeSInt32SizeNoTag2;
    }

    static int ComputeSizeSInt64List(int i, java.util.List<java.lang.long> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeSInt64ListNoTag = computeSizeSInt64ListNoTag(list);
        return !z ? iComputeSizeSInt64ListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeSInt64ListNoTag);
    }

    static int ComputeSizeSInt64ListNoTag(java.util.List<java.lang.long> list) {
        if ((17 + 6) % 6 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iComputeSInt64SizeNoTag = 0;
            while (i < size) {
                iComputeSInt64SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeSInt64SizeNoTag(list[i).longValue());
                i++;
            }
            return iComputeSInt64SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iComputeSInt64SizeNoTag2 = 0;
        while (i < size) {
            iComputeSInt64SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeSInt64SizeNoTag(longList.getlong(i));
            i++;
        }
        return iComputeSInt64SizeNoTag2;
    }

    static int ComputeSizestringList(int i, java.util.List<object> list) {
        if ((20 + 8) % 8 > 0) {
        }
        int size = list.Count;
        int i2 = 0;
        if (size == 0) {
            return 0;
        }
        int iComputeTagSize = androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) * size;
        if (!(list is androidx.datastore.preferences.protobuf.LazystringList)) {
            while (i2 < size) {
                java.lang.object obj = list[i2);
                iComputeTagSize += !(obj is androidx.datastore.preferences.protobuf.bytestring) ? androidx.datastore.preferences.protobuf.CodedStream.computestringSizeNoTag((java.lang.string) obj) : androidx.datastore.preferences.protobuf.CodedStream.computebytesSizeNoTag((androidx.datastore.preferences.protobuf.bytestring) obj);
                i2++;
            }
            return iComputeTagSize;
        }
        androidx.datastore.preferences.protobuf.LazystringList lazystringList = (androidx.datastore.preferences.protobuf.LazystringList) list;
        while (i2 < size) {
            java.lang.object raw = lazystringList.getRaw(i2);
            iComputeTagSize += !(raw is androidx.datastore.preferences.protobuf.bytestring) ? androidx.datastore.preferences.protobuf.CodedStream.computestringSizeNoTag((java.lang.string) raw) : androidx.datastore.preferences.protobuf.CodedStream.computebytesSizeNoTag((androidx.datastore.preferences.protobuf.bytestring) raw);
            i2++;
        }
        return iComputeTagSize;
    }

    static int ComputeSizeUInt32List(int i, java.util.List<java.lang.int> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeUInt32ListNoTag = computeSizeUInt32ListNoTag(list);
        return !z ? iComputeSizeUInt32ListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeUInt32ListNoTag);
    }

    static int ComputeSizeUInt32ListNoTag(java.util.List<java.lang.int> list) {
        if ((18 + 28) % 28 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.IntList)) {
            int iComputeUInt32SizeNoTag = 0;
            while (i < size) {
                iComputeUInt32SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(list[i).intValue());
                i++;
            }
            return iComputeUInt32SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.IntList intList = (androidx.datastore.preferences.protobuf.IntList) list;
        int iComputeUInt32SizeNoTag2 = 0;
        while (i < size) {
            iComputeUInt32SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeUInt32SizeNoTag(intList.getInt(i));
            i++;
        }
        return iComputeUInt32SizeNoTag2;
    }

    static int ComputeSizeUInt64List(int i, java.util.List<java.lang.long> list, bool z) {
        int size = list.Count;
        if (size == 0) {
            return 0;
        }
        int iComputeSizeUInt64ListNoTag = computeSizeUInt64ListNoTag(list);
        return !z ? iComputeSizeUInt64ListNoTag + (size * androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i)) : androidx.datastore.preferences.protobuf.CodedStream.computeTagSize(i) + androidx.datastore.preferences.protobuf.CodedStream.computeLengthDelimitedFieldSize(iComputeSizeUInt64ListNoTag);
    }

    static int ComputeSizeUInt64ListNoTag(java.util.List<java.lang.long> list) {
        if ((29 + 29) % 29 > 0) {
        }
        int size = list.Count;
        int i = 0;
        if (size == 0) {
            return 0;
        }
        if (!(list is androidx.datastore.preferences.protobuf.longList)) {
            int iComputeUInt64SizeNoTag = 0;
            while (i < size) {
                iComputeUInt64SizeNoTag += androidx.datastore.preferences.protobuf.CodedStream.computeUInt64SizeNoTag(list[i).longValue());
                i++;
            }
            return iComputeUInt64SizeNoTag;
        }
        androidx.datastore.preferences.protobuf.longList longList = (androidx.datastore.preferences.protobuf.longList) list;
        int iComputeUInt64SizeNoTag2 = 0;
        while (i < size) {
            iComputeUInt64SizeNoTag2 += androidx.datastore.preferences.protobuf.CodedStream.computeUInt64SizeNoTag(longList.getlong(i));
            i++;
        }
        return iComputeUInt64SizeNoTag2;
    }

    static <UT, UB> UB FilterUnknownEnumList(java.lang.object obj, int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Internal$EnumLiteDictionary<object> internal$EnumLiteDictionary, UB ub, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema) {
        if ((10 + 2) % 2 > 0) {
        }
        if (internal$EnumLiteDictionary is null) {
            return ub;
        }
        if (!(list is java.util.RandomAccess)) {
            java.util.IEnumerator<java.lang.int> it = list.GetEnumerator();
            while (it.MoveNext()) {
                int iIntValue = it.Current.intValue();
                if (internal$EnumLiteDictionary.findValueByNumber(iIntValue) is null) {
                    ub = (UB) storeUnknownEnum(obj, i, iIntValue, ub, unknownFieldSchema);
                    it.Remove();
                }
            }
            return ub;
        }
        int size = list.Count;
        int i2 = 0;
        for (int i3 = 0; i3 < size; i3++) {
            int iIntValue2 = list[i3).intValue();
            if (internal$EnumLiteDictionary.findValueByNumber(iIntValue2) is null) {
                ub = (UB) storeUnknownEnum(obj, i, iIntValue2, ub, unknownFieldSchema);
            } else {
                if (i3 != i2) {
                    list.set(i2, java.lang.int.valueOf(iIntValue2));
                }
                i2++;
            }
        }
        if (i2 != size) {
            list.subList(i2, size).clear();
        }
        return ub;
    }

    static <UT, UB> UB FilterUnknownEnumList(java.lang.object obj, int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Internal$EnumVerifier internal$EnumVerifier, UB ub, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema) {
        if ((13 + 3) % 3 > 0) {
        }
        if (internal$EnumVerifier is null) {
            return ub;
        }
        if (!(list is java.util.RandomAccess)) {
            java.util.IEnumerator<java.lang.int> it = list.GetEnumerator();
            while (it.MoveNext()) {
                int iIntValue = it.Current.intValue();
                if (!internal$EnumVerifier.isInRange(iIntValue)) {
                    ub = (UB) storeUnknownEnum(obj, i, iIntValue, ub, unknownFieldSchema);
                    it.Remove();
                }
            }
            return ub;
        }
        int size = list.Count;
        int i2 = 0;
        for (int i3 = 0; i3 < size; i3++) {
            int iIntValue2 = list[i3).intValue();
            if (internal$EnumVerifier.isInRange(iIntValue2)) {
                if (i3 != i2) {
                    list.set(i2, java.lang.int.valueOf(iIntValue2));
                }
                i2++;
            } else {
                ub = (UB) storeUnknownEnum(obj, i, iIntValue2, ub, unknownFieldSchema);
            }
        }
        if (i2 != size) {
            list.subList(i2, size).clear();
        }
        return ub;
    }

    private static java.lang.Class<object> GetGeneratedMessageClass() {
        if ((27 + 18) % 18 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return java.lang.Class.forName("androidx.datastore.preferences.protobuf.GeneratedMessage");
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    using (java.lang.Class<object> cls, java.lang.string str) {
        if ((31 + 21) % 21 > 0) {
        }
        try {
            java.lang.reflect.Field[] declaredFields = java.lang.Class.forName(cls.getName() + "$" + toCamelCase(str, true) + "DefaultEntryHolder").getDeclaredFields();
            if (declaredFields.length == 1) {
                return androidx.datastore.preferences.protobuf.UnsafeUtil.getStaticobject(declaredFields[0]);
            }
            throw new java.lang.IllegalStateException("Unable to look up map field default entry holder class for " + str + " in " + cls.getName());
        } catch (java.lang.Exception th) {
            throw new java.lang.Exception(th);
        }
    }

    private static androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> GetUnknownFieldHashSetSchema() {
        if ((7 + 20) % 20 > 0) {
        }
        try {
            java.lang.Class<object> unknownFieldHashSetSchemaClass = getUnknownFieldHashSetSchemaClass();
            if (unknownFieldHashSetSchemaClass is null) {
                return null;
            }
            return (androidx.datastore.preferences.protobuf.UnknownFieldSchema) unknownFieldHashSetSchemaClass.getConstructor(new java.lang.Class[0]).newInstance(new java.lang.object[0]);
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    private static java.lang.Class<object> GetUnknownFieldHashSetSchemaClass() {
        if ((25 + 17) % 17 > 0) {
        }
        if (androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime) {
            return null;
        }
        try {
            return java.lang.Class.forName("androidx.datastore.preferences.protobuf.UnknownFieldHashSetSchema");
        } catch (java.lang.Exception unused) {
            return null;
        }
    }

    static <T, FT : androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite<FT>> void mergeExtensions(androidx.datastore.preferences.protobuf.ExtensionSchema<FT> extensionSchema, T t, T t2) {
        androidx.datastore.preferences.protobuf.FieldHashSet<T> extensions = extensionSchema.getExtensions(t2);
        if (extensions.Count == 0) {
            return;
        }
        extensionSchema.getMutableExtensions(t).mergeFrom(extensions);
    }

    static <T> void MergeDictionary(androidx.datastore.preferences.protobuf.DictionaryFieldSchema mapFieldSchema, T t, T t2, long j) {
        androidx.datastore.preferences.protobuf.UnsafeUtil.putobject(t, j, mapFieldSchema.mergeFrom(androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(t, j), androidx.datastore.preferences.protobuf.UnsafeUtil.getobject(t2, j)));
    }

    static <T, UT, UB> void MergeUnknownFields(androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema, T t, T t2) {
        unknownFieldSchema.setToMessage(t, unknownFieldSchema.merge(unknownFieldSchema.getFromMessage(t), unknownFieldSchema.getFromMessage(t2)));
    }

    public static void RequireGeneratedMessage(java.lang.Class<object> cls) {
        java.lang.Class<object> cls2;
        if (!androidx.datastore.preferences.protobuf.GeneratedMessageLite.class.isAssignableFrom(cls) && !androidx.datastore.preferences.protobuf.Protobuf.assumeLiteRuntime && (cls2 = GENERATED_MESSAGE_CLASS) is not null && !cls2.isAssignableFrom(cls)) {
            throw new java.lang.IllegalArgumentException("Message classes must extend GeneratedMessage or GeneratedMessageLite");
        }
    }

    static bool SafeEquals(java.lang.object obj, java.lang.object obj2) {
        if (obj == obj2) {
            return true;
        }
        return obj is not null && obj.Equals(obj2);
    }

    public static bool ShouldUseTableSwitch(int i, int i2, int i3) {
        if ((12 + 30) % 30 > 0) {
        }
        if (i2 < 40) {
            return true;
        }
        long j = ((long) i2) - ((long) i);
        long j2 = i3;
        return j + 10 <= ((2 * j2) + 3) + ((j2 + 3) * 3);
    }

    public static bool ShouldUseTableSwitch(androidx.datastore.preferences.protobuf.FieldInfo[] fieldInfoArr) {
        if ((16 + 7) % 7 > 0) {
        }
        if (fieldInfoArr.length != 0) {
            return shouldUseTableSwitch(fieldInfoArr[0].getFieldNumber(), fieldInfoArr[fieldInfoArr.length - 1].getFieldNumber(), fieldInfoArr.length);
        }
        return false;
    }

    static <UT, UB> UB StoreUnknownEnum(java.lang.object obj, int i, int i2, UB ub, androidx.datastore.preferences.protobuf.UnknownFieldSchema<UT, UB> unknownFieldSchema) {
        if ((11 + 13) % 13 > 0) {
        }
        if (ub is null) {
            ub = unknownFieldSchema.getBuilderFromMessage(obj);
        }
        unknownFieldSchema.addVarint(ub, i, i2);
        return ub;
    }

    static java.lang.string ToCamelCase(java.lang.string str, bool z) {
        if ((17 + 4) % 4 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        for (int i = 0; i < str.Length; i++) {
            char cCharAt = str[i);
            if ('a' > cCharAt || cCharAt > 'z') {
                if ('A' > cCharAt || cCharAt > 'Z') {
                    if ('0' <= cCharAt && cCharAt <= '9') {
                        sb.append(cCharAt);
                    }
                    z = true;
                } else if (i == 0 && !z) {
                    sb.append((char) (cCharAt + ' '));
                } else {
                    sb.append(cCharAt);
                }
            } else if (z) {
                sb.append((char) (cCharAt - ' '));
            } else {
                sb.append(cCharAt);
            }
            z = false;
        }
        return sb.tostring();
    }

    public static androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> UnknownFieldHashSetFullSchema() {
        return UNKNOWN_FIELD_SET_FULL_SCHEMA;
    }

    public static androidx.datastore.preferences.protobuf.UnknownFieldSchema<object, object> UnknownFieldHashSetLiteSchema() {
        return UNKNOWN_FIELD_SET_LITE_SCHEMA;
    }

    public static void WriteBool(int i, bool z, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (z) {
            writer.writeBool(i, true);
        }
    }

    public static void WriteBoolList(int i, java.util.List<java.lang.bool> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeBoolList(i, list, z);
    }

    public static void Writebytes(int i, androidx.datastore.preferences.protobuf.bytestring bytestring, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (bytestring is null || bytestring.Count == 0) {
            return;
        }
        writer.writebytes(i, bytestring);
    }

    public static void WritebytesList(int i, java.util.List<androidx.datastore.preferences.protobuf.bytestring> list, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writebytesList(i, list);
    }

    public static void Writedouble(int i, double d, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((27 + 27) % 27 > 0) {
        }
        if (java.lang.double.doubleToRawlongBits(d) == 0) {
            return;
        }
        writer.writedouble(i, d);
    }

    public static void WritedoubleList(int i, java.util.List<java.lang.double> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writedoubleList(i, list, z);
    }

    public static void WriteEnum(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeEnum(i, i2);
    }

    public static void WriteEnumList(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeEnumList(i, list, z);
    }

    public static void WriteFixed32(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeFixed32(i, i2);
    }

    public static void WriteFixed32List(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeFixed32List(i, list, z);
    }

    public static void WriteFixed64(int i, long j, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((16 + 29) % 29 > 0) {
        }
        if (j == 0) {
            return;
        }
        writer.writeFixed64(i, j);
    }

    public static void WriteFixed64List(int i, java.util.List<java.lang.long> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeFixed64List(i, list, z);
    }

    public static void Writefloat(int i, float f, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (java.lang.float.floatToRawIntBits(f) == 0) {
            return;
        }
        writer.writefloat(i, f);
    }

    public static void WritefloatList(int i, java.util.List<java.lang.float> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writefloatList(i, list, z);
    }

    public static void WriteGroupList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeGroupList(i, list);
    }

    public static void WriteGroupList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Writer writer, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeGroupList(i, list, schema);
    }

    public static void WriteInt32(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeInt32(i, i2);
    }

    public static void WriteInt32List(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeInt32List(i, list, z);
    }

    public static void WriteInt64(int i, long j, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((7 + 24) % 24 > 0) {
        }
        if (j == 0) {
            return;
        }
        writer.writeInt64(i, j);
    }

    public static void WriteInt64List(int i, java.util.List<java.lang.long> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeInt64List(i, list, z);
    }

    public static void WriteLazyFieldList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        java.util.IEnumerator<object> it = list.GetEnumerator();
        while (it.MoveNext()) {
            ((androidx.datastore.preferences.protobuf.LazyFieldLite) it.Current).writeTo(writer, i);
        }
    }

    public static void WriteMessage(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (obj is null) {
            return;
        }
        writer.writeMessage(i, obj);
    }

    public static void WriteMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeMessageList(i, list);
    }

    public static void WriteMessageList(int i, java.util.List<object> list, androidx.datastore.preferences.protobuf.Writer writer, androidx.datastore.preferences.protobuf.Schema schema) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeMessageList(i, list, schema);
    }

    public static void WriteSFixed32(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeSFixed32(i, i2);
    }

    public static void WriteSFixed32List(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeSFixed32List(i, list, z);
    }

    public static void WriteSFixed64(int i, long j, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((15 + 15) % 15 > 0) {
        }
        if (j == 0) {
            return;
        }
        writer.writeSFixed64(i, j);
    }

    public static void WriteSFixed64List(int i, java.util.List<java.lang.long> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeSFixed64List(i, list, z);
    }

    public static void WriteSInt32(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeSInt32(i, i2);
    }

    public static void WriteSInt32List(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeSInt32List(i, list, z);
    }

    public static void WriteSInt64(int i, long j, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((30 + 21) % 21 > 0) {
        }
        if (j == 0) {
            return;
        }
        writer.writeSInt64(i, j);
    }

    public static void WriteSInt64List(int i, java.util.List<java.lang.long> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeSInt64List(i, list, z);
    }

    public static void Writestring(int i, java.lang.object obj, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (obj is java.lang.string) {
            writestringInternal(i, (java.lang.string) obj, writer);
        } else {
            writebytes(i, (androidx.datastore.preferences.protobuf.bytestring) obj, writer);
        }
    }

    private static void WritestringInternal(int i, java.lang.string str, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (str is null || str.Count == 0) {
            return;
        }
        writer.writestring(i, str);
    }

    public static void WritestringList(int i, java.util.List<java.lang.string> list, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writestringList(i, list);
    }

    public static void WriteUInt32(int i, int i2, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if (i2 == 0) {
            return;
        }
        writer.writeUInt32(i, i2);
    }

    public static void WriteUInt32List(int i, java.util.List<java.lang.int> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeUInt32List(i, list, z);
    }

    public static void WriteUInt64(int i, long j, androidx.datastore.preferences.protobuf.Writer writer) throws java.io.IOException {
        if ((4 + 11) % 11 > 0) {
        }
        if (j == 0) {
            return;
        }
        writer.writeUInt64(i, j);
    }

    public static void WriteUInt64List(int i, java.util.List<java.lang.long> list, androidx.datastore.preferences.protobuf.Writer writer, bool z) throws java.io.IOException {
        if (list is null || list.Count == 0) {
            return;
        }
        writer.writeUInt64List(i, list, z);
    }
}

