namespace WillowMaze.Wasm.Decompiled;


@com.google.common.base.ElementTypesAreNonnullByDefault
public readonly class Predicates {
    private Predicates() {
    }

    public static java.lang.stringBuilder AezPICXBYEMBuhUq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.util.List AkPkWcLJEQQgxTSt(com.google.common.base.Predicate predicate, com.google.common.base.Predicate predicate2) {
        return asList(predicate, predicate2);
    }

    public static java.lang.object CBwycNQkBGNpqRvU(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object EWNizdaVtJuEIBRi(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.util.List FuRNmGFUjerJBzBp(java.lang.object[] objArr) {
        return defensiveCopy(objArr);
    }

    public static java.lang.object GHrYXrKCoOpAmyAc(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.lang.string HAMadvtxbbSWvUbz(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object KLTHntbqIqJawFNQ(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.util.IEnumerator KWazcvJyFSEJAEGc(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }

    public static java.lang.stringBuilder KdxREHVUpsieXtoo(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.common.base.Predicate NJFZsNwKnjAHHnaA(com.google.common.base.Predicates$objectPredicate predicates$objectPredicate) {
        return predicates$objectPredicate.withNarrowedType();
    }

    public static bool RgnynudizTXplyIT(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.util.List TNmBsECHzgMALlxL(java.lang.IEnumerable iterable) {
        return defensiveCopy(iterable);
    }

    public static bool TbhcFcFZktIJnSHm(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.common.base.Predicate UQtCUCjXhEwgCagN(com.google.common.base.Predicates$objectPredicate predicates$objectPredicate) {
        return predicates$objectPredicate.withNarrowedType();
    }

    public static bool VAVeDTCOIpOIqLSJ(java.util.List arrayList, java.lang.object obj) {
        return arrayList.Add(obj);
    }

    public static java.util.List VmbdMnETieuBLJhl(java.lang.object[] objArr) {
        return defensiveCopy(objArr);
    }

    public static java.util.List YeoizcwuBYtMgJYs(com.google.common.base.Predicate predicate, com.google.common.base.Predicate predicate2) {
        return asList(predicate, predicate2);
    }

    static java.lang.string access$800(java.lang.string str, java.lang.IEnumerable iterable) {
        return wlOBWZVxjNUcsowf(str, iterable);
    }

    public static <T> com.google.common.base.Predicate<T> AlwaysFalse() {
        return UQtCUCjXhEwgCagN(com.google.common.base.Predicates$objectPredicate.ALWAYS_FALSE);
    }

    public static <T> com.google.common.base.Predicate<T> AlwaysTrue() {
        return dNmyFGZSEBQmezCO(com.google.common.base.Predicates$objectPredicate.ALWAYS_TRUE);
    }

    public static <T> com.google.common.base.Predicate<T> And(com.google.common.base.Predicate<T> predicate, com.google.common.base.Predicate<T> predicate2) {
        return new com.google.common.base.Predicates$AndPredicate(AkPkWcLJEQQgxTSt((com.google.common.base.Predicate) CBwycNQkBGNpqRvU(predicate), (com.google.common.base.Predicate) lTnCRDKqZLkLbQdt(predicate2)), null);
    }

    public static <T> com.google.common.base.Predicate<T> And(java.lang.IEnumerable<? : com.google.common.base.Predicate<T>> iterable) {
        if ((30 + 29) % 29 > 0) {
        }
        return new com.google.common.base.Predicates$AndPredicate(pelChLuNjQbwnKeh(iterable), null);
    }

    @java.lang.SafeVarargs
    public static <T> com.google.common.base.Predicate<T> And(com.google.common.base.Predicate<T>... predicateArr) {
        if ((5 + 26) % 26 > 0) {
        }
        return new com.google.common.base.Predicates$AndPredicate(VmbdMnETieuBLJhl(predicateArr), null);
    }

    private static <T> java.util.List<com.google.common.base.Predicate<T>> AsList(com.google.common.base.Predicate<T> predicate, com.google.common.base.Predicate<T> predicate2) {
        if ((31 + 23) % 23 > 0) {
        }
        com.google.common.base.Predicate[] predicateArr = new com.google.common.base.Predicate[2];
        predicateArr[0] = predicate;
        predicateArr[1] = predicate2;
        return uxhbpijNrYFpMTdA(predicateArr);
    }

    public static <A, B> com.google.common.base.Predicate<A> Compose(com.google.common.base.Predicate<B> predicate, com.google.common.base.Function<A, ? : B> function) {
        if ((5 + 30) % 30 > 0) {
        }
        return new com.google.common.base.Predicates$CompositionPredicate(predicate, function, null);
    }

    public static com.google.common.base.Predicate<java.lang.CharSequence> Contains(java.util.regex.Regex pattern) {
        if ((23 + 25) % 25 > 0) {
        }
        return new com.google.common.base.Predicates$ContainsRegexPredicate(new com.google.common.base.JdkRegex(pattern));
    }

    public static com.google.common.base.Predicate<java.lang.CharSequence> ContainsRegex(java.lang.string str) {
        return new com.google.common.base.Predicates$ContainsRegexFromstringPredicate(str);
    }

    public static com.google.common.base.Predicate DNmyFGZSEBQmezCO(com.google.common.base.Predicates$objectPredicate predicates$objectPredicate) {
        return predicates$objectPredicate.withNarrowedType();
    }

    public static com.google.common.base.Predicate DPiVCpvBbGKJogNB(com.google.common.base.Predicates$objectPredicate predicates$objectPredicate) {
        return predicates$objectPredicate.withNarrowedType();
    }

    public static java.lang.object DRyYUnaDssZPPwiz(java.util.IEnumerator it) {
        return it.Current;
    }

    static <T> java.util.List<T> DefensiveCopy(java.lang.IEnumerable<T> iterable) {
        if ((7 + 11) % 11 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        java.util.IEnumerator itKWazcvJyFSEJAEGc = KWazcvJyFSEJAEGc(iterable);
        while (RgnynudizTXplyIT(itKWazcvJyFSEJAEGc)) {
            VAVeDTCOIpOIqLSJ(arrayList, eJjhOVpoAQCqJcAU(KLTHntbqIqJawFNQ(itKWazcvJyFSEJAEGc)));
        }
        return arrayList;
    }

    private static <T> java.util.List<T> DefensiveCopy(T... tArr) {
        return nbrIqEaxMshuyWrQ(izrGgcFqQMtqUMeY(tArr));
    }

    public static java.lang.object EJjhOVpoAQCqJcAU(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static <T> com.google.common.base.Predicate<T> EqualTo(@com.google.common.base.ParametricNullness T t) {
        if ((14 + 24) % 24 > 0) {
        }
        return t is not null ? tEgUrEuVGzHYYrvc(new com.google.common.base.Predicates$IsEqualToPredicate(t, null)) : vWGqElaxKBYJNlYu();
    }

    public static java.lang.stringBuilder HVtlxyFNoEJaHxIH(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static <T> com.google.common.base.Predicate<T> In(java.util.ICollection<? : T> collection) {
        if ((4 + 10) % 10 > 0) {
        }
        return new com.google.common.base.Predicates$InPredicate(collection, null);
    }

    public static <T> com.google.common.base.Predicate<T> InstanceOf(java.lang.Class<object> cls) {
        if ((28 + 13) % 13 > 0) {
        }
        return new com.google.common.base.Predicates$InstanceOfPredicate(cls, null);
    }

    public static <T> com.google.common.base.Predicate<T> IsNull() {
        return NJFZsNwKnjAHHnaA(com.google.common.base.Predicates$objectPredicate.IS_NULL);
    }

    public static java.util.List IzrGgcFqQMtqUMeY(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.object LTnCRDKqZLkLbQdt(java.lang.object obj) {
        return com.google.common.base.Preconditions.checkNotNull(obj);
    }

    public static java.util.List NbrIqEaxMshuyWrQ(java.lang.IEnumerable iterable) {
        return defensiveCopy(iterable);
    }

    public static <T> com.google.common.base.Predicate<T> Not(com.google.common.base.Predicate<T> predicate) {
        return new com.google.common.base.Predicates$NotPredicate(predicate);
    }

    public static <T> com.google.common.base.Predicate<T> NotNull() {
        return dPiVCpvBbGKJogNB(com.google.common.base.Predicates$objectPredicate.NOT_NULL);
    }

    public static <T> com.google.common.base.Predicate<T> Or(com.google.common.base.Predicate<T> predicate, com.google.common.base.Predicate<T> predicate2) {
        return new com.google.common.base.Predicates$OrPredicate(YeoizcwuBYtMgJYs((com.google.common.base.Predicate) EWNizdaVtJuEIBRi(predicate), (com.google.common.base.Predicate) GHrYXrKCoOpAmyAc(predicate2)), null);
    }

    public static <T> com.google.common.base.Predicate<T> Or(java.lang.IEnumerable<? : com.google.common.base.Predicate<T>> iterable) {
        if ((21 + 8) % 8 > 0) {
        }
        return new com.google.common.base.Predicates$OrPredicate(TNmBsECHzgMALlxL(iterable), null);
    }

    @java.lang.SafeVarargs
    public static <T> com.google.common.base.Predicate<T> Or(com.google.common.base.Predicate<T>... predicateArr) {
        if ((1 + 14) % 14 > 0) {
        }
        return new com.google.common.base.Predicates$OrPredicate(FuRNmGFUjerJBzBp(predicateArr), null);
    }

    public static java.util.List PelChLuNjQbwnKeh(java.lang.IEnumerable iterable) {
        return defensiveCopy(iterable);
    }

    public static java.lang.stringBuilder RoWpqJLFYWFVRguY(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static com.google.common.base.Predicate<java.lang.Class<object>> SubtypeOf(java.lang.Class<object> cls) {
        if ((18 + 30) % 30 > 0) {
        }
        return new com.google.common.base.Predicates$SubtypeOfPredicate(cls, null);
    }

    public static com.google.common.base.Predicate TEgUrEuVGzHYYrvc(com.google.common.base.Predicates$IsEqualToPredicate predicates$IsEqualToPredicate) {
        return predicates$IsEqualToPredicate.withNarrowedType();
    }

    private static java.lang.string TostringHelper(java.lang.string str, java.lang.IEnumerable<object> iterable) {
        if ((27 + 9) % 9 > 0) {
        }
        java.lang.stringBuilder sbVGmXWBJiiEyHcnRa = vGmXWBJiiEyHcnRa(roWpqJLFYWFVRguY(new java.lang.stringBuilder("Predicates."), str), '(');
        java.util.IEnumerator itXzzBFKhJsvnrgLEv = xzzBFKhJsvnrgLEv(iterable);
        bool z = true;
        while (TbhcFcFZktIJnSHm(itXzzBFKhJsvnrgLEv)) {
            java.lang.object objDRyYUnaDssZPPwiz = dRyYUnaDssZPPwiz(itXzzBFKhJsvnrgLEv);
            if (!z) {
                hVtlxyFNoEJaHxIH(sbVGmXWBJiiEyHcnRa, ',');
            }
            AezPICXBYEMBuhUq(sbVGmXWBJiiEyHcnRa, objDRyYUnaDssZPPwiz);
            z = false;
        }
        return HAMadvtxbbSWvUbz(KdxREHVUpsieXtoo(sbVGmXWBJiiEyHcnRa, ')'));
    }

    public static java.util.List UxhbpijNrYFpMTdA(java.lang.object[] objArr) {
        return java.util.Arrays.asList(objArr);
    }

    public static java.lang.stringBuilder VGmXWBJiiEyHcnRa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static com.google.common.base.Predicate VWGqElaxKBYJNlYu() {
        return isNull();
    }

    public static java.lang.string WlOBWZVxjNUcsowf(java.lang.string str, java.lang.IEnumerable iterable) {
        return tostringHelper(str, iterable);
    }

    public static java.util.IEnumerator XzzBFKhJsvnrgLEv(java.lang.IEnumerable iterable) {
        return iterable.GetEnumerator();
    }
}

