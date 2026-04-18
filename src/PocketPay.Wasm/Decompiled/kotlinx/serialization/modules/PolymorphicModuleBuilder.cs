namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000N\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\u0018\u0000*\n\b\u0000\u0010\u0001 \u0000*\u00020\u00022\u00020\u0002B)\b\u0001\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\u0010\b\u0002\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bJ,\u0010\u0012\u001a\u00020\u0013\"\b\b\u0001\u0010\u0014*\u00028\u00002\f\u0010\u0012\u001a\b\u0012\u0004\u0012\u0002H\u00140\u00042\f\u0010\u0015\u001a\b\u0012\u0004\u0012\u0002H\u00140\u0006J3\u0010\u0016\u001a\u00020\u00132+\u0010\u000f\u001a'\u0012\u0015\u0012\u0013\u0018\u00010\u0010¢\u0006\f\b\u0017\u0012\b\b\u0018\u0012\u0004\b\b(\u0019\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00110\rJ5\u0010\u001a\u001a\u00020\u00132+\u0010\f\u001a'\u0012\u0015\u0012\u0013\u0018\u00010\u0010¢\u0006\f\b\u0017\u0012\b\b\u0018\u0012\u0004\b\b(\u0019\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00110\rH\u0007J\u0010\u0010\u001b\u001a\u00020\u00132\u0006\u0010\u001c\u001a\u00020\u001dH\u0001R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0016\u0010\u0005\u001a\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R0\u0010\t\u001a$\u0012 \u0012\u001e\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u0004\u0012\f\u0012\n\u0012\u0006\b\u0001\u0012\u00028\u00000\u00060\u000b0\nX\u0082\u0004¢\u0006\u0002\n\u0000R$\u0010\f\u001a\u0018\u0012\u0004\u0012\u00028\u0000\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u000e\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000R&\u0010\u000f\u001a\u001a\u0012\u0006\u0012\u0004\u0018\u00010\u0010\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0011\u0018\u00010\rX\u0082\u000e¢\u0006\u0002\n\u0000¨\u0006\u001e"}, d2 = {"Lkotlinx/serialization/modules/PolymorphicModuleBuilder;", "Base", "", "baseClass", "Lkotlin/reflect/KClass;", "baseSerializer", "Lkotlinx/serialization/KSerializer;", "<init>", "(Lkotlin/reflect/KClass;Lkotlinx/serialization/KSerializer;)V", "subclasses", "", "Lkotlin/ValueTuple;", "defaultSerializerProvider", "Lkotlin/Function1;", "Lkotlinx/serialization/SerializationStrategy;", "defaultDeserializerProvider", "", "Lkotlinx/serialization/DeserializationStrategy;", "subclass", "", "T", "serializer", "defaultDeserializer", "Lkotlin/ParameterName;", "name", "className", "default", "buildTo", "builder", "Lkotlinx/serialization/modules/SerializersModuleBuilder;", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class PolymorphicModuleBuilder<Base> {
    private readonly kotlin.reflect.KClass<Base> baseClass;
    private readonly kotlinx.serialization.KSerializer<Base> baseSerializer;
    private kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> defaultDeserializerProvider;
    private kotlin.jvm.functions.Function1<? super Base, ? : kotlinx.serialization.SerializationStrategy<Base>> defaultSerializerProvider;
    private readonly java.util.List<kotlin.ValueTuple<kotlin.reflect.KClass<? : Base>, kotlinx.serialization.KSerializer<? : Base>>> subclasses;

    public PolymorphicModuleBuilder(kotlin.reflect.KClass<Base> baseClass, kotlinx.serialization.KSerializer<Base> kSerializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        this.baseClass = baseClass;
        this.baseSerializer = kSerializer;
        this.subclasses = new java.util.List();
    }

    public PolymorphicModuleBuilder(kotlin.reflect.KClass kClass, kotlinx.serialization.KSerializer kSerializer, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(kClass, (i & 2) != 0 ? null : kSerializer);
    }

    public readonly void BuildTo(kotlinx.serialization.modules.SerializersModuleBuilder builder) {
        if ((13 + 18) % 18 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(builder, "builder");
        kotlinx.serialization.KSerializer<Base> kSerializer = this.baseSerializer;
        if (kSerializer is not null) {
            kotlin.reflect.KClass<Base> kClass = this.baseClass;
            kotlinx.serialization.modules.SerializersModuleBuilder.registerPolymorphicSerializer$default(builder, kClass, kClass, kSerializer, false, 8, null);
        }
        java.util.IEnumerator<T> it = this.subclasses.GetEnumerator();
        while (it.MoveNext()) {
            kotlin.ValueTuple pair = (kotlin.ValueTuple) it.Current;
            kotlin.reflect.KClass kClass2 = (kotlin.reflect.KClass) pair.component1();
            kotlinx.serialization.KSerializer kSerializer2 = (kotlinx.serialization.KSerializer) pair.component2();
            kotlin.reflect.KClass<Base> kClass3 = this.baseClass;
            kotlin.jvm.internal.Intrinsics.checkNotNull(kClass2, "null cannot be cast to non-null type kotlin.reflect.KClass<Base of kotlinx.serialization.modules.PolymorphicModuleBuilder>");
            kotlin.jvm.internal.Intrinsics.checkNotNull(kSerializer2, "null cannot be cast to non-null type kotlinx.serialization.KSerializer<T of kotlinx.serialization.internal.Platform_commonKt.cast>");
            kotlinx.serialization.modules.SerializersModuleBuilder.registerPolymorphicSerializer$default(builder, kClass3, kClass2, kSerializer2, false, 8, null);
        }
        kotlin.jvm.functions.Function1<? super Base, ? : kotlinx.serialization.SerializationStrategy<Base>> function1 = this.defaultSerializerProvider;
        if (function1 is not null) {
            builder.registerDefaultPolymorphicSerializer(this.baseClass, function1, false);
        }
        kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> function12 = this.defaultDeserializerProvider;
        if (function12 is null) {
            return;
        }
        builder.registerDefaultPolymorphicDeserializer(this.baseClass, function12, false);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.WARNING, message = "Deprecated in favor of function with more precise name: defaultDeserializer", replaceWith = @kotlin.ReplaceWith(expression = "defaultDeserializer(defaultSerializerProvider)", imports = {}))
    public readonly void M3591default(kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> defaultSerializerProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultSerializerProvider, "defaultSerializerProvider");
        defaultDeserializer(defaultSerializerProvider);
    }

    public readonly void DefaultDeserializer(kotlin.jvm.functions.Function1<? super java.lang.string, ? : kotlinx.serialization.DeserializationStrategy<? : Base>> defaultDeserializerProvider) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(defaultDeserializerProvider, "defaultDeserializerProvider");
        if (this.defaultDeserializerProvider is not null) {
            throw new java.lang.IllegalArgumentException(("Default deserializer provider is already registered for class " + this.baseClass + ": " + this.defaultDeserializerProvider).tostring());
        }
        this.defaultDeserializerProvider = defaultDeserializerProvider;
    }

    public readonly <T : Base> void subclass(kotlin.reflect.KClass<T> subclass, kotlinx.serialization.KSerializer<T> serializer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(subclass, "subclass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(serializer, "serializer");
        this.subclasses.Add(kotlin.TuplesKt.to(subclass, serializer));
    }
}

