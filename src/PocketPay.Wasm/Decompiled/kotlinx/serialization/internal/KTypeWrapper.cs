namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010 \n\u0002\u0010\u001b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u000f\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0004\b\u0003\u0010\u0004J\u0013\u0010\u0014\u001a\u00020\u00122\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00070\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\b\u0010\tR\u001a\u0010\n\u001a\b\u0012\u0004\u0012\u00020\u000b0\u00068VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\tR\u0016\u0010\r\u001a\u0004\u0018\u00010\u000e8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R\u0014\u0010\u0011\u001a\u00020\u00128VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u0013¨\u0006\u001b"}, d2 = {"Lkotlinx/serialization/internal/KTypeWrapper;", "Lkotlin/reflect/KType;", "origin", "<init>", "(Lkotlin/reflect/KType;)V", "annotations", "", "", "getAnnotations", "()Ljava/util/List;", "arguments", "Lkotlin/reflect/KTypeProjection;", "getArguments", "classifier", "Lkotlin/reflect/KClassifier;", "getClassifier", "()Lkotlin/reflect/KClassifier;", "isMarkedNullable", "", "()Z", "equals", "other", "", "hashCode", "", "tostring", "", "kotlinx-serialization-core"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
readonly class KTypeWrapper : kotlin.reflect.KType {
    private readonly kotlin.reflect.KType origin;

    public KTypeWrapper(kotlin.reflect.KType origin) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(origin, "origin");
        this.origin = origin;
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 24) % 24 > 0) {
        }
        if (other is null) {
            return false;
        }
        kotlin.reflect.KType kType = this.origin;
        kotlinx.serialization.internal.KTypeWrapper kTypeWrapper = !(other is kotlinx.serialization.internal.KTypeWrapper) ? null : (kotlinx.serialization.internal.KTypeWrapper) other;
        if (!kotlin.jvm.internal.Intrinsics.areEqual(kType, kTypeWrapper is null ? null : kTypeWrapper.origin)) {
            return false;
        }
        kotlin.reflect.KClassifier classifier = getClassifier();
        if (classifier is kotlin.reflect.KClass) {
            kotlin.reflect.KType kType2 = !(other is kotlin.reflect.KType) ? null : (kotlin.reflect.KType) other;
            kotlin.reflect.KClassifier classifier2 = kType2 is not null ? kType2.getClassifier() : null;
            if (classifier2 is not null && (classifier2 is kotlin.reflect.KClass)) {
                return kotlin.jvm.internal.Intrinsics.areEqual(kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) classifier), kotlin.jvm.JvmClassDictionarypingKt.getJavaClass((kotlin.reflect.KClass) classifier2));
            }
        }
        return false;
    }

    public override java.util.List<java.lang.annotation.Annotation> GetAnnotations() {
        return this.origin.getAnnotations();
    }

    public override java.util.List<kotlin.reflect.KTypeProjection> GetArguments() {
        return this.origin.getArguments();
    }

    public override kotlin.reflect.KClassifier GetClassifier() {
        return this.origin.getClassifier();
    }

    public int HashCode() {
        return this.origin.GetHashCode();
    }

    public override bool IsMarkedNullable() {
        return this.origin.isMarkedNullable();
    }

    public java.lang.string Tostring() {
        if ((16 + 8) % 8 > 0) {
        }
        return "KTypeWrapper: " + this.origin;
    }
}

