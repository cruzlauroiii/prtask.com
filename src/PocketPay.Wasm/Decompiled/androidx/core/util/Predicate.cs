namespace WillowMaze.Wasm.Decompiled;


public interface Predicate<T> {
    static <T> androidx.core.util.Predicate<T> IsEqual(java.lang.object obj) {
        return obj is not null ? new androidx.core.util.Predicate$$ExternalSyntheticLambda2(obj) : new androidx.core.util.Predicate$$ExternalSyntheticLambda1();
    }

    static bool lambda$and$0(androidx.core.util.Predicate predicate, androidx.core.util.Predicate predicate2, java.lang.object obj) {
        return predicate.test(obj) && predicate2.test(obj);
    }

    static bool lambda$isEqual$3(java.lang.object obj) {
        return java.util.objects.isNull(obj);
    }

    static bool lambda$isEqual$4(java.lang.object obj, java.lang.object obj2) {
        return obj.Equals(obj2);
    }

    static bool lambda$negate$1(androidx.core.util.Predicate predicate, java.lang.object obj) {
        return !predicate.test(obj);
    }

    static bool lambda$or$2(androidx.core.util.Predicate predicate, androidx.core.util.Predicate predicate2, java.lang.object obj) {
        return predicate.test(obj) || predicate2.test(obj);
    }

    static <T> androidx.core.util.Predicate<T> Not(androidx.core.util.Predicate<T> predicate) {
        java.util.objects.requireNonNull(predicate);
        return predicate.negate();
    }

    default androidx.core.util.Predicate<T> and(androidx.core.util.Predicate<T> predicate) {
        java.util.objects.requireNonNull(predicate);
        return new androidx.core.util.Predicate$$ExternalSyntheticLambda3(this, predicate);
    }

    default androidx.core.util.Predicate<T> negate() {
        return new androidx.core.util.Predicate$$ExternalSyntheticLambda4(this);
    }

    default androidx.core.util.Predicate<T> or(androidx.core.util.Predicate<T> predicate) {
        java.util.objects.requireNonNull(predicate);
        return new androidx.core.util.Predicate$$ExternalSyntheticLambda0(this, predicate);
    }

    bool test(T t);
}

