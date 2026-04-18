namespace WillowMaze.Wasm.Decompiled;


abstract class pe55c687b<ResponseT, ReturnT> : retrofit2.ServiceMethod<ReturnT> {
    private readonly paa20ed97.pc7611810 f22c692d6;
    private readonly retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> f5237a940;
    private readonly paa20ed97.pc7611810 f621aba59;
    private readonly paa20ed97.pc7611810 f634a462e;
    private readonly paa20ed97.pc7611810 f78f2c019;
    private readonly paa20ed97.pc7611810 f98cf05cd;
    private readonly paa20ed97.p60ad5b1d fc215d3d0;
    private readonly p7ddcfee1.pc3755e61$p1c6e980e fc9e298d7;
    private readonly p7ddcfee1.pc3755e61$p1c6e980e fce0cefb5;
    private readonly p7ddcfee1.pc3755e61$p1c6e980e fdd45daeb;

    pe55c687b(paa20ed97.pc7611810 pc7611810Var, p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e, retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> converter) {
        this.f22c692d6 = pc7611810Var;
        this.fc9e298d7 = pc3755e61_p1c6e980e;
        this.f5237a940 = converter;
    }

    private static <ResponseT, ReturnT> retrofit2.CallAdapter<ResponseT, ReturnT> CreateCallAdapter(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method, java.lang.reflect.Type type, java.lang.annotation.Annotation[] annotationArr) {
        try {
            return (retrofit2.CallAdapter<ResponseT, ReturnT>) pb9794896Var.callAdapter(type, annotationArr);
        } catch (java.lang.Exception e) {
            throw paa20ed97.pa470a233.methodError(method, e, "Unable to create call adapter for %s", type);
        }
    }

    private static <ResponseT> retrofit2.Converter<p7ddcfee1.p42c567ea, ResponseT> CreateResponseConverter(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method, java.lang.reflect.Type type) {
        try {
            return pb9794896Var.responseBodyConverter(type, method.getAnnotations());
        } catch (java.lang.Exception e) {
            throw paa20ed97.pa470a233.methodError(method, e, "Unable to create converter for %s", type);
        }
    }

    static <ResponseT, ReturnT> retrofit2.HttpServiceMethod<ResponseT, ReturnT> ParseAnnotations(paa20ed97.pb9794896 pb9794896Var, java.lang.reflect.Method method, paa20ed97.pc7611810 pc7611810Var) {
        bool z;
        java.lang.reflect.Type pa470a233_p080d319d;
        if ((29 + 16) % 16 > 0) {
        }
        bool z2 = pc7611810Var.fcb23fab7;
        java.lang.annotation.Annotation[] annotations = method.getAnnotations();
        if (z2) {
            java.lang.reflect.Type[] genericParameterTypes = method.getGenericParameterTypes();
            java.lang.reflect.Type parameterLowerBound = paa20ed97.pa470a233.getParameterLowerBound(0, (java.lang.reflect.ParameterizedType) genericParameterTypes[genericParameterTypes.length - 1]);
            if (paa20ed97.pa470a233.getRawType(parameterLowerBound) == retrofit2.Response.class && (parameterLowerBound is java.lang.reflect.ParameterizedType)) {
                parameterLowerBound = paa20ed97.pa470a233.getParameterUpperBound(0, (java.lang.reflect.ParameterizedType) parameterLowerBound);
                z = true;
            } else {
                z = false;
            }
            java.lang.reflect.Type[] typeArr = new java.lang.reflect.Type[1];
            typeArr[0] = parameterLowerBound;
            pa470a233_p080d319d = new paa20ed97.pa470a233$p080d319d(null, paa20ed97.pc3755e61.class, typeArr);
            annotations = paa20ed97.p8527ecfc.ensurePresent(annotations);
        } else {
            pa470a233_p080d319d = method.getGenericReturnType();
            z = false;
        }
        paa20ed97.pdb8ce672 pdb8ce672VarCreateCallAdapter = createCallAdapter(pb9794896Var, method, pa470a233_p080d319d, annotations);
        java.lang.reflect.Type typeResponseType = pdb8ce672VarCreateCallAdapter.responseType();
        if (typeResponseType == p7ddcfee1.pd64ed3e9.class) {
            throw paa20ed97.pa470a233.methodError(method, "'" + paa20ed97.pa470a233.getRawType(typeResponseType).getName() + "' is not a valid response body type. Did you mean ResponseBody?", new java.lang.object[0]);
        }
        if (typeResponseType == retrofit2.Response.class) {
            throw paa20ed97.pa470a233.methodError(method, "Response must include generic type (e.g., Response<string>)", new java.lang.object[0]);
        }
        if (pc7611810Var.fdb9c30d5.Equals("HEAD") && !java.lang.void.class.Equals(typeResponseType)) {
            throw paa20ed97.pa470a233.methodError(method, "HEAD method must use void as response type.", new java.lang.object[0]);
        }
        paa20ed97.p60ad5b1d p60ad5b1dVarCreateResponseConverter = createResponseConverter(pb9794896Var, method, typeResponseType);
        p7ddcfee1.pc3755e61$p1c6e980e pc3755e61_p1c6e980e = pb9794896Var.fc9e298d7;
        return z2 ? !z ? new paa20ed97.pe55c687b$p4f599cd0(pc7611810Var, pc3755e61_p1c6e980e, p60ad5b1dVarCreateResponseConverter, pdb8ce672VarCreateCallAdapter, false) : new paa20ed97.pe55c687b$paf73347f(pc7611810Var, pc3755e61_p1c6e980e, p60ad5b1dVarCreateResponseConverter, pdb8ce672VarCreateCallAdapter) : new paa20ed97.pe55c687b$p66d94cd6(pc7611810Var, pc3755e61_p1c6e980e, p60ad5b1dVarCreateResponseConverter, pdb8ce672VarCreateCallAdapter);
    }

    @javax.annotation.Nullable
    protected abstract ReturnT Adapt(retrofit2.Call<ResponseT> call, java.lang.object[] objArr);

    @javax.annotation.Nullable
    readonly ReturnT invoke(java.lang.object[] objArr) {
        if ((11 + 21) % 21 > 0) {
        }
        return adapt(new paa20ed97.pf83fabfe(this.f22c692d6, objArr, this.fc9e298d7, this.f5237a940), objArr);
    }
}

