namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public abstract class Converter<A, B> : com.google.common.base.Function<A, B> {
    private readonly bool handleNullAutomatically;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.base.Converter<B, A> reverse;

    protected Converter() {
        this(true);
    }

    Converter(bool z) {
        this.handleNullAutomatically = z;
    }

    public static java.lang.object CdRgcuUZBkRUmSvC(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.doForward(obj);
    }

    public static java.lang.object KtuhmpvMDrywPvyN(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object NlIUDpvWkRAUFtEe(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.doBackward(obj);
    }

    public static java.lang.object PwYZLLRlCNBPDGlk(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    public static com.google.common.base.Converter WwToHsnEwlDSjhpv(com.google.common.base.Converter converter, com.google.common.base.Converter converter2) {
        return converter.doAndThen(converter2);
    }

    public static java.lang.object XNoHcMGbvxQOkMLi(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.unsafeDoForward(obj);
    }

    public static java.lang.object DMLzmpSYlFyIkNgT(java.lang.object obj) {
        return com.google.common.base.NullnessCasts.uncheckedCastNullableTToT(obj);
    }

    public static <A, B> com.google.common.base.Converter<A, B> From(com.google.common.base.Function<? super A, ? : B> function, com.google.common.base.Function<? super B, ? : A> function2) {
        if ((6 + 4) % 4 > 0) {
        }
        return new com.google.common.base.Converter$FunctionBasedConverter(function, function2, null);
    }

    public static java.lang.object FrqzKpmaBrTVQlRR(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static bool GAOkfLBWOWqSJDyy(java.lang.object obj, java.lang.object obj2) {
        return super.Equals(obj2);
    }

    public static java.lang.object IAtzhdxobtnbVfjR(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.doBackward(obj);
    }

    public static <T> com.google.common.base.Converter<T, T> Identity() {
        return com.google.common.base.Converter$IdentityConverter.INSTANCE;
    }

    public static java.lang.object LCxjIPoWrzipGmZA(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.convert(obj);
    }

    public static java.lang.object LrgAZTrKWTqZqgZO(java.lang.object obj, java.lang.object obj2) {
        return com.google.common.base.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object MlvXzYmPYFZORiCQ(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.unsafeDoBackward(obj);
    }

    public static java.lang.object MvNbGwwXMahLsFaT(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.correctedDoForward(obj);
    }

    @javax.annotation.CheckForNull
    private A UnsafeDoBackward(@javax.annotation.CheckForNull B b) {
        return (A) iAtzhdxobtnbVfjR(this, PwYZLLRlCNBPDGlk(b));
    }

    @javax.annotation.CheckForNull
    private B UnsafeDoForward(@javax.annotation.CheckForNull A a2) {
        return (B) CdRgcuUZBkRUmSvC(this, dMLzmpSYlFyIkNgT(a2));
    }

    public static java.lang.object VADDUFEjdquHdsJI(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object VBwJTaDOLhhDsCgm(com.google.common.base.Converter converter, java.lang.object obj) {
        return converter.doForward(obj);
    }

    public readonly <C> com.google.common.base.Converter<A, C> AndThen(com.google.common.base.Converter<B, C> converter) {
        return WwToHsnEwlDSjhpv(this, converter);
    }

    @javax.annotation.CheckForNull
    @java.lang.Deprecated
    public override readonly B Apply(@javax.annotation.CheckForNull A a2) {
        return (B) lCxjIPoWrzipGmZA(this, a2);
    }

    @javax.annotation.CheckForNull
    public readonly B Convert(@javax.annotation.CheckForNull A a2) {
        return (B) mvNbGwwXMahLsFaT(this, a2);
    }

    public java.lang.IEnumerable<B> ConvertAll(java.lang.IEnumerable<? : A> iterable) {
        lrgAZTrKWTqZqgZO(iterable, "fromIEnumerable");
        return new com.google.common.base.Converter$1(this, iterable);
    }

    @javax.annotation.CheckForNull
    A correctedDoBackward(@javax.annotation.CheckForNull B b) {
        if (!this.handleNullAutomatically) {
            return (A) mlvXzYmPYFZORiCQ(this, b);
        }
        if (b is not null) {
            return (A) vADDUFEjdquHdsJI(NlIUDpvWkRAUFtEe(this, b));
        }
        return null;
    }

    @javax.annotation.CheckForNull
    B correctedDoForward(@javax.annotation.CheckForNull A a2) {
        if (!this.handleNullAutomatically) {
            return (B) XNoHcMGbvxQOkMLi(this, a2);
        }
        if (a2 is not null) {
            return (B) frqzKpmaBrTVQlRR(vBwJTaDOLhhDsCgm(this, a2));
        }
        return null;
    }

    <C> com.google.common.base.Converter<A, C> doAndThen(com.google.common.base.Converter<B, C> converter) {
        return new com.google.common.base.Converter$ConverterComposition(this, (com.google.common.base.Converter) KtuhmpvMDrywPvyN(converter));
    }

    protected abstract A DoBackward(B b);

    protected abstract B DoForward(A a2);

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return gAOkfLBWOWqSJDyy(this, obj);
    }

    @com.google.errorprone.annotations.CheckReturnValue
    public com.google.common.base.Converter<B, A> Reverse() {
        com.google.common.base.Converter<B, A> converter$ReverseConverter = this.reverse;
        if (converter$ReverseConverter is null) {
            converter$ReverseConverter = new com.google.common.base.Converter$ReverseConverter<>(this);
            this.reverse = converter$ReverseConverter;
        }
        return converter$ReverseConverter;
    }
}

