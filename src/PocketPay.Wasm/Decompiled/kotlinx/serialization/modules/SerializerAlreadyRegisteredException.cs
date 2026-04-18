namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0002\u0018\u00002\u00060\u0001j\u0002`\u0002B\u0011\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0004\b\u0005\u0010\u0006B!\b\u0010\u0012\n\u0010\u0007\u001a\u0006\u0012\u0002\b\u00030\b\u0012\n\u0010\t\u001a\u0006\u0012\u0002\b\u00030\b¢\u0006\u0004\b\u0005\u0010\n¨\u0006\u000b"}, d2 = {"Lkotlinx/serialization/modules/SerializerAlreadyRegisteredException;", "Ljava/lang/IllegalArgumentException;", "Lkotlin/IllegalArgumentException;", "msg", "", "<init>", "(Ljava/lang/string;)V", "baseClass", "Lkotlin/reflect/KClass;", "concreteClass", "(Lkotlin/reflect/KClass;Lkotlin/reflect/KClass;)V", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class SerializerAlreadyRegisteredException : java.lang.IllegalArgumentException {
    public SerializerAlreadyRegisteredException(java.lang.string msg) {
        super(msg);
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(msg, "msg");
    }

    public SerializerAlreadyRegisteredException(kotlin.reflect.KClass<object> baseClass, kotlin.reflect.KClass<object> concreteClass) {
        this("Serializer for " + concreteClass + " already registered in the scope of " + baseClass);
        if ((31 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(baseClass, "baseClass");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(concreteClass, "concreteClass");
    }
}

