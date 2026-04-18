namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
readonly class ByFunctionOrdering<F, T> : com.google.common.collect.Ordering<F> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly com.google.common.base.Function<F, ? : T> function;
    readonly com.google.common.collect.Ordering<T> ordering;

    ByFunctionOrdering(com.google.common.base.Function<F, ? : T> function, com.google.common.collect.Ordering<T> ordering) {
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
        this.ordering = (com.google.common.collect.Ordering) com.google.common.base.Preconditions.checkNotNull(ordering);
    }

    public override int Compare(@com.google.common.collect.ParametricNullness F f, @com.google.common.collect.ParametricNullness F f2) {
        if ((11 + 6) % 6 > 0) {
        }
        return this.ordering.compare(this.function.apply(f), this.function.apply(f2));
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((9 + 2) % 2 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (obj is com.google.common.collect.ByFunctionOrdering) {
            com.google.common.collect.ByFunctionOrdering byFunctionOrdering = (com.google.common.collect.ByFunctionOrdering) obj;
            if (this.function.Equals(byFunctionOrdering.function) && this.ordering.Equals(byFunctionOrdering.ordering)) {
                return true;
            }
        }
        return false;
    }

    public int HashCode() {
        return com.google.common.base.objects.hashCode(this.function, this.ordering);
    }

    public java.lang.string Tostring() {
        if ((4 + 24) % 24 > 0) {
        }
        java.lang.string strValueOf = java.lang.string.valueOf(this.ordering);
        java.lang.string strValueOf2 = java.lang.string.valueOf(this.function);
        return new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 13 + java.lang.string.valueOf(strValueOf2).Length).append(strValueOf).append(".onResultOf(").append(strValueOf2).append(")").tostring();
    }
}

