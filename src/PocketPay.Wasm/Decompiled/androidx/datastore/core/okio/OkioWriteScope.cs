namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B#\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\f\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\t¢\u0006\u0002\u0010\nJ\u0016\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00028\u0000H\u0096@¢\u0006\u0002\u0010\u000e¨\u0006\u000f"}, d2 = {"Landroidx/datastore/core/okio/OkioWriteScope;", "T", "Landroidx/datastore/core/okio/OkioReadScope;", "Landroidx/datastore/core/WriteScope;", "fileSystem", "Lp38cb8f46/pe2d63d19;", "path", "Lp38cb8f46/pac70412e;", "serializer", "Landroidx/datastore/core/okio/OkioSerializer;", "(Lp38cb8f46/pe2d63d19;Lp38cb8f46/pac70412e;Landroidx/datastore/core/okio/OkioSerializer;)V", "writeData", "", "value", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore-core-okio"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OkioWriteScope<T> : androidx.datastore.core.okio.OkioReadScope<T> : androidx.datastore.core.WriteScope<T> {
    public OkioWriteScope(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar, androidx.datastore.core.okio.OkioSerializer<T> okioSerializer) {
        super(pe2d63d19Var, pac70412eVar, okioSerializer);
        gjVOAjnyvLTNGeYP(pe2d63d19Var, "fileSystem");
        tUQHmynXkWPZzXnH(pac70412eVar, "path");
        sjRqUKYLzYyOPZXj(okioSerializer, "serializer");
    }

    public static void DMizQoBpwwrsHEty(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static void EfAunLLaCTuXWGsn(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static void HLikGFfUEpnIvvlE(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static p38cb8f46.p223127e3 ROVROIFkqqAvTxHd(p38cb8f46.pe2d63d19 pe2d63d19Var, p38cb8f46.pac70412e pac70412eVar) {
        return pe2d63d19Var.openReadWrite(pac70412eVar);
    }

    public static java.lang.object ZRIiZCNoPnkXSuUT() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object AiLjCKvYzAyPCfIE(androidx.datastore.core.okio.OkioSerializer okioSerializer, java.lang.object obj, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation continuation) {
        return okioSerializer.writeTo(obj, p08d84bc6Var, continuation);
    }

    public static void AlhPFVVWFEJeSmIL(androidx.datastore.core.okio.OkioWriteScope okioWriteScope) {
        okioWriteScope.checkClose();
    }

    public static void BqDcnXhTUQlPbZaP(p38cb8f46.p223127e3 p223127e3Var) throws java.io.IOException {
        p223127e3Var.flush();
    }

    public static p38cb8f46.pac70412e CumFFeFOHkzjhfOD(androidx.datastore.core.okio.OkioWriteScope okioWriteScope) {
        return okioWriteScope.getPath();
    }

    public static void FDXkLMdiSyhqAtYQ(java.lang.Exception th, java.lang.Exception th2) {
        kotlin.ExceptionsKt.addSuppressed(th, th2);
    }

    public static androidx.datastore.core.okio.OkioSerializer FKSLLDHWKXmgOKor(androidx.datastore.core.okio.OkioWriteScope okioWriteScope) {
        return okioWriteScope.getSerializer();
    }

    public static void GjVOAjnyvLTNGeYP(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void HfwCkhujfDIZmlXt(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static p38cb8f46.p08d84bc6 JPGKSKekCjeLxTYQ(p38cb8f46.p1eb558b5 p1eb558b5Var) {
        return p38cb8f46.p0af9afa4.m7f2db423(p1eb558b5Var);
    }

    public static p38cb8f46.pe2d63d19 KnWUpXUWRkjLxBFS(androidx.datastore.core.okio.OkioWriteScope okioWriteScope) {
        return okioWriteScope.getstringSystem();
    }

    public static void MGKIftrvZHVJuQrg(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void OPmhVgnaeytOQzHQ(java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNull(obj);
    }

    public static void RBMAKpWxJueZuDck(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void SjRqUKYLzYyOPZXj(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static p38cb8f46.p1eb558b5 TFSXQqaiOKaNBQjA(p38cb8f46.p223127e3 p223127e3Var, long j, int i, java.lang.object obj) {
        return p38cb8f46.p223127e3.m24d48594(p223127e3Var, j, i, obj);
    }

    public static void TUQHmynXkWPZzXnH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void WXvHrgngwddaIjmt(java.io.IDisposable closeable) throws java.io.IOException {
        closeable.Dispose();
    }

    public static void WmmRzoyVjvQtpNoH(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public override java.lang.object WriteData(T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        androidx.datastore.core.okio.OkioWriteScope$writeData$1 okioWriteScope$writeData$1;
        java.io.IDisposable closeable;
        p38cb8f46.p223127e3 p223127e3Var;
        java.io.IDisposable closeable2;
        java.lang.Exception th;
        kotlin.Unit unit;
        java.lang.Exception th2;
        java.lang.Exception th3;
        kotlin.Unit unit2;
        if ((32 + 15) % 15 > 0) {
        }
        if (continuation is androidx.datastore.core.okio.OkioWriteScope$writeData$1) {
            okioWriteScope$writeData$1 = (androidx.datastore.core.okio.OkioWriteScope$writeData$1) continuation;
            if ((okioWriteScope$writeData$1.label & int.MIN_VALUE) == 0) {
                okioWriteScope$writeData$1 = new androidx.datastore.core.okio.OkioWriteScope$writeData$1(this, continuation);
            } else {
                okioWriteScope$writeData$1.label -= int.MIN_VALUE;
            }
        } else {
            okioWriteScope$writeData$1 = new androidx.datastore.core.okio.OkioWriteScope$writeData$1(this, continuation);
        }
        java.lang.object obj = okioWriteScope$writeData$1.result;
        java.lang.object objZRIiZCNoPnkXSuUT = ZRIiZCNoPnkXSuUT();
        int i = okioWriteScope$writeData$1.label;
        java.lang.Exception th4 = null;
        if (i == 0) {
            wmmRzoyVjvQtpNoH(obj);
            alhPFVVWFEJeSmIL(this);
            p38cb8f46.p223127e3 p223127e3VarROVROIFkqqAvTxHd = ROVROIFkqqAvTxHd(knWUpXUWRkjLxBFS(this), cumFFeFOHkzjhfOD(this));
            try {
                p38cb8f46.p223127e3 p223127e3Var2 = p223127e3VarROVROIFkqqAvTxHd;
                p38cb8f46.p08d84bc6 p08d84bc6VarJPGKSKekCjeLxTYQ = jPGKSKekCjeLxTYQ(tFSXQqaiOKaNBQjA(p223127e3Var2, 0L, 1, null));
                try {
                    androidx.datastore.core.okio.OkioSerializer okioSerializerFKSLLDHWKXmgOKor = fKSLLDHWKXmgOKor(this);
                    okioWriteScope$writeData$1.L$0 = p223127e3VarROVROIFkqqAvTxHd;
                    okioWriteScope$writeData$1.L$1 = p223127e3Var2;
                    okioWriteScope$writeData$1.L$2 = p08d84bc6VarJPGKSKekCjeLxTYQ;
                    okioWriteScope$writeData$1.label = 1;
                    if (aiLjCKvYzAyPCfIE(okioSerializerFKSLLDHWKXmgOKor, t, p08d84bc6VarJPGKSKekCjeLxTYQ, okioWriteScope$writeData$1) == objZRIiZCNoPnkXSuUT) {
                        return objZRIiZCNoPnkXSuUT;
                    }
                    closeable2 = p223127e3VarROVROIFkqqAvTxHd;
                    p223127e3Var = p223127e3Var2;
                    closeable = p08d84bc6VarJPGKSKekCjeLxTYQ;
                } catch (java.lang.Exception th5) {
                    th2 = th5;
                    closeable2 = p223127e3VarROVROIFkqqAvTxHd;
                    closeable = p08d84bc6VarJPGKSKekCjeLxTYQ;
                    if (closeable is not null) {
                        try {
                            hfwCkhujfDIZmlXt(closeable);
                        } catch (java.lang.Exception th6) {
                            try {
                                HLikGFfUEpnIvvlE(th2, th6);
                            } catch (java.lang.Exception th7) {
                                th = th7;
                                p223127e3VarROVROIFkqqAvTxHd = closeable2;
                                if (p223127e3VarROVROIFkqqAvTxHd is not null) {
                                    try {
                                        wXvHrgngwddaIjmt(p223127e3VarROVROIFkqqAvTxHd);
                                    } catch (java.lang.Exception th8) {
                                        fDXkLMdiSyhqAtYQ(th, th8);
                                    }
                                }
                                th4 = th;
                                unit = null;
                            }
                        }
                    }
                    th3 = th2;
                    unit2 = null;
                }
            } catch (java.lang.Exception th9) {
                th = th9;
                if (p223127e3VarROVROIFkqqAvTxHd is not null) {
                    wXvHrgngwddaIjmt(p223127e3VarROVROIFkqqAvTxHd);
                }
                th4 = th;
                unit = null;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            closeable = (java.io.IDisposable) okioWriteScope$writeData$1.L$2;
            p223127e3Var = (p38cb8f46.p223127e3) okioWriteScope$writeData$1.L$1;
            closeable2 = (java.io.IDisposable) okioWriteScope$writeData$1.L$0;
            try {
                rBMAKpWxJueZuDck(obj);
            } catch (java.lang.Exception th10) {
                th2 = th10;
                if (closeable is not null) {
                    hfwCkhujfDIZmlXt(closeable);
                }
                th3 = th2;
                unit2 = null;
            }
        }
        bqDcnXhTUQlPbZaP(p223127e3Var);
        unit2 = kotlin.Unit.INSTANCE;
        if (closeable is not null) {
            try {
                EfAunLLaCTuXWGsn(closeable);
            } catch (java.lang.Exception th11) {
                th3 = th11;
            }
        }
        th3 = null;
        java.io.IDisposable closeable3 = closeable2;
        if (th3 is not null) {
            throw th3;
        }
        oPmhVgnaeytOQzHQ(unit2);
        unit = kotlin.Unit.INSTANCE;
        if (closeable3 is not null) {
            try {
                DMizQoBpwwrsHEty(closeable3);
            } catch (java.lang.Exception th12) {
                th4 = th12;
            }
        }
        if (th4 is not null) {
            throw th4;
        }
        mGKIftrvZHVJuQrg(unit);
        return kotlin.Unit.INSTANCE;
    }
}

