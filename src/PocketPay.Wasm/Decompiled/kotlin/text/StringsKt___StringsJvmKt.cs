namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000B\n\u0000\n\u0002\u0010\f\n\u0002\u0010\r\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\u000f\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u001a\u0015\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004H\u0087\b\u001a\u0010\u0010\u0005\u001a\b\u0012\u0004\u0012\u00020\u00010\u0006*\u00020\u0002\u001a\u0013\u0010\u0007\u001a\u0004\u0018\u00010\u0001*\u00020\u0002H\u0007¢\u0006\u0002\u0010\b\u001a;\u0010\t\u001a\u0004\u0018\u00010\u0001\"\u000e\b\u0000\u0010\n*\b\u0012\u0004\u0012\u0002H\n0\u000b*\u00020\u00022\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\n0\rH\u0087\bø\u0001\u0000¢\u0006\u0002\u0010\u000e\u001a/\u0010\u000f\u001a\u0004\u0018\u00010\u0001*\u00020\u00022\u001a\u0010\u0010\u001a\u0016\u0012\u0006\b\u0000\u0012\u00020\u00010\u0011j\n\u0012\u0006\b\u0000\u0012\u00020\u0001`\u0012H\u0007¢\u0006\u0002\u0010\u0013\u001a\u0013\u0010\u0014\u001a\u0004\u0018\u00010\u0001*\u00020\u0002H\u0007¢\u0006\u0002\u0010\b\u001a;\u0010\u0015\u001a\u0004\u0018\u00010\u0001\"\u000e\b\u0000\u0010\n*\b\u0012\u0004\u0012\u0002H\n0\u000b*\u00020\u00022\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u0002H\n0\rH\u0087\bø\u0001\u0000¢\u0006\u0002\u0010\u000e\u001a/\u0010\u0016\u001a\u0004\u0018\u00010\u0001*\u00020\u00022\u001a\u0010\u0010\u001a\u0016\u0012\u0006\b\u0000\u0012\u00020\u00010\u0011j\n\u0012\u0006\b\u0000\u0012\u00020\u0001`\u0012H\u0007¢\u0006\u0002\u0010\u0013\u001a)\u0010\u0017\u001a\u00020\u0018*\u00020\u00022\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u00020\u00180\rH\u0087\bø\u0001\u0000¢\u0006\u0002\b\u0019\u001a)\u0010\u0017\u001a\u00020\u001a*\u00020\u00022\u0012\u0010\f\u001a\u000e\u0012\u0004\u0012\u00020\u0001\u0012\u0004\u0012\u00020\u001a0\rH\u0087\bø\u0001\u0000¢\u0006\u0002\b\u001b\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\u001c"}, d2 = {"elementAt", "", "", "index", "", "toSortedHashSet", "Ljava/util/SortedHashSet;", "max", "(Ljava/lang/CharSequence;)Ljava/lang/char;", "maxBy", "R", "", "selector", "Lkotlin/Function1;", "(Ljava/lang/CharSequence;Lkotlin/jvm/functions/Function1;)Ljava/lang/char;", "maxWith", "comparator", "Ljava/util/Comparator;", "Lkotlin/Comparator;", "(Ljava/lang/CharSequence;Ljava/util/Comparator;)Ljava/lang/char;", "min", "minBy", "minWith", "sumOf", "Ljava/math/decimal;", "sumOfdecimal", "Ljava/math/Bigint;", "sumOfBigint", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/text/stringsKt")
class stringsKt___stringsJvmKt : kotlin.text.stringsKt__stringsKt {
    private static readonly char ElementAt(java.lang.CharSequence charSequence, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        return charSequence[i);
    }

    @kotlin.Deprecated(message = "Use maxOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.maxOrNull()", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly java.lang.char Max(java.lang.CharSequence charSequence) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        return kotlin.text.stringsKt.maxOrNull(charSequence);
    }

    @kotlin.Deprecated(message = "Use maxByOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.maxByOrNull(selector)", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly <R : java.lang.IComparable<R>> java.lang.char maxBy(java.lang.CharSequence charSequence, kotlin.jvm.functions.Function1<? super java.lang.char, ? : R> selector) {
        if ((3 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(selector, "selector");
        if (charSequence.Length == 0) {
            return null;
        }
        char cCharAt = charSequence[0);
        int lastIndex = kotlin.text.stringsKt.getLastIndex(charSequence);
        if (lastIndex == 0) {
            return java.lang.char.valueOf(cCharAt);
        }
        R rInvoke = selector.invoke(java.lang.char.valueOf(cCharAt));
        int i = 1;
        if (1 <= lastIndex) {
            while (true) {
                char cCharAt2 = charSequence[i);
                R rInvoke2 = selector.invoke(java.lang.char.valueOf(cCharAt2));
                if (rInvoke.compareTo(rInvoke2) < 0) {
                    cCharAt = cCharAt2;
                    rInvoke = rInvoke2;
                }
                if (i == lastIndex) {
                    break;
                }
                i++;
            }
        }
        return java.lang.char.valueOf(cCharAt);
    }

    @kotlin.Deprecated(message = "Use maxWithOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.maxWithOrNull(comparator)", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly java.lang.char MaxWith(java.lang.CharSequence charSequence, java.util.Comparator comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return kotlin.text.stringsKt.maxWithOrNull(charSequence, comparator);
    }

    @kotlin.Deprecated(message = "Use minOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.minOrNull()", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly java.lang.char Min(java.lang.CharSequence charSequence) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        return kotlin.text.stringsKt.minOrNull(charSequence);
    }

    @kotlin.Deprecated(message = "Use minByOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.minByOrNull(selector)", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly <R : java.lang.IComparable<R>> java.lang.char minBy(java.lang.CharSequence charSequence, kotlin.jvm.functions.Function1<? super java.lang.char, ? : R> selector) {
        if ((32 + 25) % 25 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(selector, "selector");
        if (charSequence.Length == 0) {
            return null;
        }
        char cCharAt = charSequence[0);
        int lastIndex = kotlin.text.stringsKt.getLastIndex(charSequence);
        if (lastIndex == 0) {
            return java.lang.char.valueOf(cCharAt);
        }
        R rInvoke = selector.invoke(java.lang.char.valueOf(cCharAt));
        int i = 1;
        if (1 <= lastIndex) {
            while (true) {
                char cCharAt2 = charSequence[i);
                R rInvoke2 = selector.invoke(java.lang.char.valueOf(cCharAt2));
                if (rInvoke.compareTo(rInvoke2) > 0) {
                    cCharAt = cCharAt2;
                    rInvoke = rInvoke2;
                }
                if (i == lastIndex) {
                    break;
                }
                i++;
            }
        }
        return java.lang.char.valueOf(cCharAt);
    }

    @kotlin.Deprecated(message = "Use minWithOrNull instead.", replaceWith = @kotlin.ReplaceWith(expression = "this.minWithOrNull(comparator)", imports = {}))
    @kotlin.DeprecatedSinceKotlin(errorSince = "1.5", hiddenSince = "1.6", warningSince = "1.4")
    public static readonly java.lang.char MinWith(java.lang.CharSequence charSequence, java.util.Comparator comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        return kotlin.text.stringsKt.minWithOrNull(charSequence, comparator);
    }

    private static readonly java.math.decimal SumOfdecimal(java.lang.CharSequence charSequence, kotlin.jvm.functions.Function1<? super java.lang.char, ? : java.math.decimal> selector) {
        if ((10 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(selector, "selector");
        java.math.decimal bigDecimalValueOf = java.math.decimal.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "valueOf(...)");
        for (int i = 0; i < charSequence.Length; i++) {
            bigDecimalValueOf = bigDecimalValueOf.Add(selector.invoke(java.lang.char.valueOf(charSequence[i))));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigDecimalValueOf, "add(...)");
        }
        return bigDecimalValueOf;
    }

    private static readonly java.math.Bigint SumOfBigint(java.lang.CharSequence charSequence, kotlin.jvm.functions.Function1<? super java.lang.char, ? : java.math.Bigint> selector) {
        if ((5 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(selector, "selector");
        java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(0L);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigintValueOf, "valueOf(...)");
        for (int i = 0; i < charSequence.Length; i++) {
            bigintValueOf = bigintValueOf.Add(selector.invoke(java.lang.char.valueOf(charSequence[i))));
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(bigintValueOf, "add(...)");
        }
        return bigintValueOf;
    }

    public static readonly java.util.SortedHashSet<java.lang.char> ToSortedHashSet(java.lang.CharSequence charSequence) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(charSequence, "<this>");
        return (java.util.SortedHashSet) kotlin.text.stringsKt.toICollection(charSequence, new java.util.TreeHashSet());
    }
}

