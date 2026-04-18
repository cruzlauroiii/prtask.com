namespace WillowMaze.Wasm.Decompiled;


public readonly class p9feacbac : paa20ed97.pdb8ce672$p1c6e980e {
    private readonly io.reactivex.rxjava3.core.Scheduler f09cf96a5;
    private readonly io.reactivex.rxjava3.core.Scheduler f45ede365;

    @javax.annotation.Nullable
    private readonly io.reactivex.rxjava3.core.Scheduler f499f31e7;
    private readonly io.reactivex.rxjava3.core.Scheduler f4e59ac6e;
    private readonly bool f67a4ecce;
    private readonly bool fcbeb20cd;

    private p9feacbac(@javax.annotation.Nullable io.reactivex.rxjava3.core.Scheduler scheduler, bool z) {
        this.f499f31e7 = scheduler;
        this.f67a4ecce = z;
    }

    public static paa20ed97.p8a7a38cf.p90676d7c.p9feacbac Create() {
        if ((10 + 3) % 3 > 0) {
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p9feacbac(null, true);
    }

    public static paa20ed97.p8a7a38cf.p90676d7c.p9feacbac CreateSynchronous() {
        if ((13 + 30) % 30 > 0) {
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p9feacbac(null, false);
    }

    public static paa20ed97.p8a7a38cf.p90676d7c.p9feacbac CreateWithScheduler(io.reactivex.rxjava3.core.Scheduler scheduler) {
        if ((3 + 6) % 6 > 0) {
        }
        if (scheduler is null) {
            throw new java.lang.NullPointerException("scheduler is null");
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p9feacbac(scheduler, false);
    }

    @javax.annotation.Nullable
    public override retrofit2.CallAdapter<object, object> Get(java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr, paa20ed97.pb9794896 pb9794896Var) {
        java.lang.reflect.Type parameterUpperBound;
        bool z;
        bool z2;
        if ((4 + 7) % 7 > 0) {
        }
        java.lang.Class<object> rawType = getRawType(type);
        if (rawType == io.reactivex.rxjava3.core.Completable.class) {
            return new paa20ed97.p8a7a38cf.p90676d7c.p2ea9d71e(java.lang.void.class, this.f499f31e7, this.f67a4ecce, false, true, false, false, false, true);
        }
        bool z3 = rawType == io.reactivex.rxjava3.core.Flowable.class;
        bool z4 = rawType == io.reactivex.rxjava3.core.Single.class;
        bool z5 = rawType == io.reactivex.rxjava3.core.Maybe.class;
        if (rawType != io.reactivex.rxjava3.core.Observable.class && !z3 && !z4 && !z5) {
            return null;
        }
        if (!(type is java.lang.reflect.ParameterizedType)) {
            java.lang.string str = z3 ? "Flowable" : z4 ? "Single" : !z5 ? "Observable" : "Maybe";
            throw new java.lang.IllegalStateException(str + " return type must be parameterized as " + str + "<Foo> or " + str + "<? : Foo>");
        }
        java.lang.reflect.Type parameterUpperBound2 = getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) type);
        java.lang.Class<object> rawType2 = getRawType(parameterUpperBound2);
        if (rawType2 != retrofit2.Response.class) {
            if (rawType2 != paa20ed97.p8a7a38cf.p90676d7c.p8eea6208.class) {
                parameterUpperBound = parameterUpperBound2;
                z = true;
                z2 = false;
            } else {
                if (!(parameterUpperBound2 is java.lang.reflect.ParameterizedType)) {
                    throw new java.lang.IllegalStateException("Result must be parameterized as Result<Foo> or Result<? : Foo>");
                }
                parameterUpperBound = getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) parameterUpperBound2);
                z2 = true;
                z = false;
            }
        } else {
            if (!(parameterUpperBound2 is java.lang.reflect.ParameterizedType)) {
                throw new java.lang.IllegalStateException("Response must be parameterized as Response<Foo> or Response<? : Foo>");
            }
            parameterUpperBound = getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) parameterUpperBound2);
            z2 = false;
            z = false;
        }
        return new paa20ed97.p8a7a38cf.p90676d7c.p2ea9d71e(parameterUpperBound, this.f499f31e7, this.f67a4ecce, z2, z, z3, z4, z5, false);
    }
}

