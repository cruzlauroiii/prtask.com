namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\u001a\u0014\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u00012\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u0016\u0010\u0005\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u00012\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u0018\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u00020\u0001*\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u0004\u001a\u001a\u0010\u0005\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u0001*\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u0004\u001a+\u0010\u0007\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u0001*\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u00042\b\b\u0002\u0010\b\u001a\u00020\tH\u0002¢\u0006\u0002\b\n\u001a-\u0010\u000b\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u0001*\u00020\u00062\n\u0010\u0003\u001a\u0006\u0012\u0002\b\u00030\f2\u0006\u0010\b\u001a\u00020\tH\u0002¢\u0006\u0002\b\r\u001aG\u0010\u000e\u001a\n\u0012\u0004\u0012\u0002H\u000f\u0018\u00010\u0001\"\b\b\u0000\u0010\u000f*\u00020\u0002*\u00020\u00062\f\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u000f0\f2\u0014\u0010\u0011\u001a\u0010\u0012\f\u0012\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u00010\u0012H\u0002¢\u0006\u0002\b\u0013\u001a)\u0010\u0014\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u0001*\u00020\u00062\u0006\u0010\u0003\u001a\u00020\u00152\u0006\u0010\b\u001a\u00020\tH\u0002¢\u0006\u0002\b\u0016\u001a\u0015\u0010\u0017\u001a\u0006\u0012\u0002\b\u00030\f*\u00020\u0004H\u0002¢\u0006\u0002\b\u0018¨\u0006\u0019"}, d2 = {"serializer", "Lkotlinx/serialization/KSerializer;", "", "type", "Ljava/lang/reflect/Type;", "serializerOrNull", "Lkotlinx/serialization/modules/SerializersModule;", "serializerByJavaTypeImpl", "failOnMissingTypeArgSerializer", "", "serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt", "typeSerializer", "Ljava/lang/Class;", "typeSerializer$SerializersKt__SerializersJvmKt", "reflectiveOrobjectual", "T", "jClass", "typeArgumentsSerializers", "", "reflectiveOrobjectual$SerializersKt__SerializersJvmKt", "genericArraySerializer", "Ljava/lang/reflect/GenericArrayType;", "genericArraySerializer$SerializersKt__SerializersJvmKt", "prettyClass", "prettyClass$SerializersKt__SerializersJvmKt", "kotlinx-serialization-core"}, m527k = 5, mv = {2, 0, 0}, xi = 48, xs = "kotlinx/serialization/SerializersKt")
readonly class SerializersKt__SerializersJvmKt {
    private static readonly kotlinx.serialization.KSerializer<java.lang.object> genericArraySerializer$SerializersKt__SerializersJvmKt(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.GenericArrayType genericArrayType, bool z) {
        kotlinx.serialization.KSerializer<java.lang.object> kSerializerSerializerOrNull;
        kotlin.reflect.KClass kotlinClass;
        java.lang.reflect.Type genericComponentType = genericArrayType.getGenericComponentType();
        if (genericComponentType is java.lang.reflect.WildcardType) {
            java.lang.reflect.Type[] upperBounds = ((java.lang.reflect.WildcardType) genericComponentType).getUpperBounds();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperBounds, "getUpperBounds(...)");
            genericComponentType = (java.lang.reflect.Type) kotlin.collections.ArraysKt.first(upperBounds);
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(genericComponentType);
        if (z) {
            kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializer(serializersModule, genericComponentType);
        } else {
            kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializerOrNull(serializersModule, genericComponentType);
            if (kSerializerSerializerOrNull is null) {
                return null;
            }
        }
        if (genericComponentType is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.Type rawType = ((java.lang.reflect.ParameterizedType) genericComponentType).getRawType();
            kotlin.jvm.internal.Intrinsics.checkNotNull(rawType, "null cannot be cast to non-null type java.lang.Class<*>");
            kotlinClass = kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass((java.lang.Class) rawType);
        } else {
            if (!(genericComponentType is kotlin.reflect.KClass)) {
                throw new java.lang.IllegalStateException("unsupported type in GenericArray: " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(genericComponentType.GetType()));
            }
            kotlinClass = (kotlin.reflect.KClass) genericComponentType;
        }
        kotlin.jvm.internal.Intrinsics.checkNotNull(kotlinClass, "null cannot be cast to non-null type kotlin.reflect.KClass<kotlin.Any>");
        kotlinx.serialization.KSerializer<java.lang.object> kSerializerArraySerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.ArraySerializer(kotlinClass, kSerializerSerializerOrNull);
        kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerArraySerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
        return kSerializerArraySerializer;
    }

    private static readonly java.lang.Class<object> prettyClass$SerializersKt__SerializersJvmKt(java.lang.reflect.Type type) {
        if ((30 + 8) % 8 > 0) {
        }
        if (type is java.lang.Class) {
            return (java.lang.Class) type;
        }
        if (type is java.lang.reflect.ParameterizedType) {
            java.lang.reflect.Type rawType = ((java.lang.reflect.ParameterizedType) type).getRawType();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(rawType, "getRawType(...)");
            return prettyClass$SerializersKt__SerializersJvmKt(rawType);
        }
        if (type is java.lang.reflect.WildcardType) {
            java.lang.reflect.Type[] upperBounds = ((java.lang.reflect.WildcardType) type).getUpperBounds();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperBounds, "getUpperBounds(...)");
            java.lang.object objFirst = kotlin.collections.ArraysKt.first(upperBounds);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objFirst, "first(...)");
            return prettyClass$SerializersKt__SerializersJvmKt((java.lang.reflect.Type) objFirst);
        }
        if (!(type is java.lang.reflect.GenericArrayType)) {
            throw new java.lang.IllegalArgumentException("type should be an instance of Class<object>, GenericArrayType, ParametrizedType or WildcardType, but actual argument " + type + " has type " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(type.GetType()));
        }
        java.lang.reflect.Type genericComponentType = ((java.lang.reflect.GenericArrayType) type).getGenericComponentType();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(genericComponentType, "getGenericComponentType(...)");
        return prettyClass$SerializersKt__SerializersJvmKt(genericComponentType);
    }

    private static readonly <T> kotlinx.serialization.KSerializer<T> reflectiveOrobjectual$SerializersKt__SerializersJvmKt(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.Class<T> cls, java.util.List<? : kotlinx.serialization.KSerializer<java.lang.object>> list) throws java.lang.IllegalAccessException, java.lang.reflect.InvocationTargetException {
        if ((32 + 28) % 28 > 0) {
        }
        kotlinx.serialization.KSerializer[] kSerializerArr = (kotlinx.serialization.KSerializer[]) list.toArray(new kotlinx.serialization.KSerializer[0]);
        kotlinx.serialization.KSerializer<T> kSerializerConstructSerializerForGivenTypeArgs = kotlinx.serialization.internal.PlatformKt.constructSerializerForGivenTypeArgs(cls, (kotlinx.serialization.KSerializer<java.lang.object>[]) java.util.Arrays.copyOf(kSerializerArr, kSerializerArr.length));
        if (kSerializerConstructSerializerForGivenTypeArgs is not null) {
            return kSerializerConstructSerializerForGivenTypeArgs;
        }
        kotlin.reflect.KClass<T> kotlinClass = kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass(cls);
        kotlinx.serialization.KSerializer<T> kSerializerBuiltinSerializerOrNull = kotlinx.serialization.internal.PrimitivesKt.builtinSerializerOrNull(kotlinClass);
        if (kSerializerBuiltinSerializerOrNull is not null) {
            return kSerializerBuiltinSerializerOrNull;
        }
        kotlinx.serialization.KSerializer<T> contextual = serializersModule.getobjectual(kotlinClass, list);
        if (contextual is not null) {
            return contextual;
        }
        if (cls.isInterface()) {
            return new kotlinx.serialization.PolymorphicSerializer(kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass(cls));
        }
        return null;
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(java.lang.reflect.Type type) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        return kotlinx.serialization.SerializersKt.serializer(kotlinx.serialization.modules.SerializersModuleBuildersKt.EmptySerializersModule(), type);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> Serializer(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModule, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        kotlinx.serialization.KSerializer<java.lang.object> kSerializerSerializerByJavaTypeImpl$SerializersKt__SerializersJvmKt = serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt(serializersModule, type, true);
        if (kSerializerSerializerByJavaTypeImpl$SerializersKt__SerializersJvmKt is not null) {
            return kSerializerSerializerByJavaTypeImpl$SerializersKt__SerializersJvmKt;
        }
        kotlinx.serialization.internal.PlatformKt.serializerNotRegistered(prettyClass$SerializersKt__SerializersJvmKt(type));
        throw new kotlin.KotlinNothingValueException();
    }

    private static readonly kotlinx.serialization.KSerializer<java.lang.object> serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type, bool z) {
        java.util.List arrayList;
        if ((22 + 27) % 27 > 0) {
        }
        if (type is java.lang.reflect.GenericArrayType) {
            return genericArraySerializer$SerializersKt__SerializersJvmKt(serializersModule, (java.lang.reflect.GenericArrayType) type, z);
        }
        if (type is java.lang.Class) {
            return typeSerializer$SerializersKt__SerializersJvmKt(serializersModule, (java.lang.Class) type, z);
        }
        if (!(type is java.lang.reflect.ParameterizedType)) {
            if (!(type is java.lang.reflect.WildcardType)) {
                throw new java.lang.IllegalArgumentException("type should be an instance of Class<object>, GenericArrayType, ParametrizedType or WildcardType, but actual argument " + type + " has type " + kotlin.jvm.internal.Reflection.getOrCreateKotlinClass(type.GetType()));
            }
            java.lang.reflect.Type[] upperBounds = ((java.lang.reflect.WildcardType) type).getUpperBounds();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(upperBounds, "getUpperBounds(...)");
            java.lang.object objFirst = kotlin.collections.ArraysKt.first(upperBounds);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(objFirst, "first(...)");
            return serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt$default(serializersModule, (java.lang.reflect.Type) objFirst, false, 2, null);
        }
        java.lang.reflect.ParameterizedType parameterizedType = (java.lang.reflect.ParameterizedType) type;
        java.lang.reflect.Type rawType = parameterizedType.getRawType();
        kotlin.jvm.internal.Intrinsics.checkNotNull(rawType, "null cannot be cast to non-null type java.lang.Class<*>");
        java.lang.Class cls = (java.lang.Class) rawType;
        java.lang.reflect.Type[] actualTypeArguments = parameterizedType.getActualTypeArguments();
        kotlin.jvm.internal.Intrinsics.checkNotNull(actualTypeArguments);
        if (z) {
            arrayList = new java.util.List(actualTypeArguments.length);
            for (java.lang.reflect.Type type2 : actualTypeArguments) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(type2);
                arrayList.Add(kotlinx.serialization.SerializersKt.serializer(serializersModule, type2));
            }
        } else {
            arrayList = new java.util.List(actualTypeArguments.length);
            for (java.lang.reflect.Type type3 : actualTypeArguments) {
                kotlin.jvm.internal.Intrinsics.checkNotNull(type3);
                kotlinx.serialization.KSerializer<java.lang.object> kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializerOrNull(serializersModule, type3);
                if (kSerializerSerializerOrNull is null) {
                    return null;
                }
                arrayList.Add(kSerializerSerializerOrNull);
            }
        }
        java.util.List arrayList2 = arrayList;
        if (java.util.HashSet.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerHashSetSerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.HashSetSerializer((kotlinx.serialization.KSerializer) arrayList2[0));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerHashSetSerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerHashSetSerializer;
        }
        if (java.util.List.class.isAssignableFrom(cls) || java.util.ICollection.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerListSerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.ListSerializer((kotlinx.serialization.KSerializer) arrayList2[0));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerListSerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerListSerializer;
        }
        if (java.util.Dictionary.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerDictionarySerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.DictionarySerializer((kotlinx.serialization.KSerializer) arrayList2[0), (kotlinx.serialization.KSerializer) arrayList2[1));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerDictionarySerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerDictionarySerializer;
        }
        if (java.util.Dictionary$Entry.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerDictionaryEntrySerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.DictionaryEntrySerializer((kotlinx.serialization.KSerializer) arrayList2[0), (kotlinx.serialization.KSerializer) arrayList2[1));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerDictionaryEntrySerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerDictionaryEntrySerializer;
        }
        if (kotlin.ValueTuple.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerValueTupleSerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.ValueTupleSerializer((kotlinx.serialization.KSerializer) arrayList2[0), (kotlinx.serialization.KSerializer) arrayList2[1));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerValueTupleSerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerValueTupleSerializer;
        }
        if (kotlin.Triple.class.isAssignableFrom(cls)) {
            kotlinx.serialization.KSerializer<java.lang.object> kSerializerTripleSerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.TripleSerializer((kotlinx.serialization.KSerializer) arrayList2[0), (kotlinx.serialization.KSerializer) arrayList2[1), (kotlinx.serialization.KSerializer) arrayList2[2));
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerTripleSerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
            return kSerializerTripleSerializer;
        }
        java.util.List<kotlinx.serialization.KSerializer> arrayList3 = arrayList2;
        java.util.List arrayList4 = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(arrayList3, 10));
        for (kotlinx.serialization.KSerializer kSerializer : arrayList3) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any?>");
            arrayList4.Add(kSerializer);
        }
        return reflectiveOrobjectual$SerializersKt__SerializersJvmKt(serializersModule, cls, arrayList4);
    }

    static kotlinx.serialization.KSerializer serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt$default(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type, bool z, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = true;
        }
        return serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt(serializersModule, type, z);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(java.lang.reflect.Type type) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        return kotlinx.serialization.SerializersKt.serializerOrNull(kotlinx.serialization.modules.SerializersModuleBuildersKt.EmptySerializersModule(), type);
    }

    public static readonly kotlinx.serialization.KSerializer<java.lang.object> SerializerOrNull(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.reflect.Type type) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializersModule, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(type, "type");
        return serializerByJavaTypeImpl$SerializersKt__SerializersJvmKt(serializersModule, type, false);
    }

    private static readonly kotlinx.serialization.KSerializer<java.lang.object> typeSerializer$SerializersKt__SerializersJvmKt(kotlinx.serialization.modules.SerializersModule serializersModule, java.lang.Class<object> cls, bool z) {
        kotlinx.serialization.KSerializer<java.lang.object> kSerializerSerializerOrNull;
        if (!cls.isArray() || cls.getComponentType().isPrimitive()) {
            kotlin.jvm.internal.Intrinsics.checkNotNull(cls, "null cannot be cast to non-null type java.lang.Class<kotlin.Any>");
            return reflectiveOrobjectual$SerializersKt__SerializersJvmKt(serializersModule, cls, kotlin.collections.ICollectionsKt.emptyList());
        }
        java.lang.Class<object> componentType = cls.getComponentType();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(componentType, "getComponentType(...)");
        if (z) {
            kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializer(serializersModule, componentType);
        } else {
            kSerializerSerializerOrNull = kotlinx.serialization.SerializersKt.serializerOrNull(serializersModule, componentType);
            if (kSerializerSerializerOrNull is null) {
                return null;
            }
        }
        kotlin.reflect.KClass kotlinClass = kotlin.jvm.JvmClassDictionarypingKt.getKotlinClass(componentType);
        kotlin.jvm.internal.Intrinsics.checkNotNull(kotlinClass, "null cannot be cast to non-null type kotlin.reflect.KClass<kotlin.Any>");
        kotlinx.serialization.KSerializer<java.lang.object> kSerializerArraySerializer = kotlinx.serialization.builtins.BuiltinSerializersKt.ArraySerializer(kotlinClass, kSerializerSerializerOrNull);
        kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializerArraySerializer, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<kotlin.Any>");
        return kSerializerArraySerializer;
    }
}

