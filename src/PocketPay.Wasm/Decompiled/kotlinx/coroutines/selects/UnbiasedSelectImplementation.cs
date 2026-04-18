namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000P\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0011\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0011\u0010\t\u001a\u00028\u0000H\u0091@ø\u0001\u0000¢\u0006\u0002\u0010\nJ\b\u0010\u000b\u001a\u00020\fH\u0002J3\u0010\r\u001a\u00020\f*\u00020\u000e2\u001c\u0010\u000f\u001a\u0018\b\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0011\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0010H\u0096\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u0013JE\u0010\r\u001a\u00020\f\"\u0004\b\u0001\u0010\u0014*\b\u0012\u0004\u0012\u0002H\u00140\u00152\"\u0010\u000f\u001a\u001e\b\u0001\u0012\u0004\u0012\u0002H\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0011\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0016H\u0096\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u0017JY\u0010\r\u001a\u00020\f\"\u0004\b\u0001\u0010\u0018\"\u0004\b\u0002\u0010\u0014*\u000e\u0012\u0004\u0012\u0002H\u0018\u0012\u0004\u0012\u0002H\u00140\u00192\u0006\u0010\u001a\u001a\u0002H\u00182\"\u0010\u000f\u001a\u001e\b\u0001\u0012\u0004\u0012\u0002H\u0014\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u0011\u0012\u0006\u0012\u0004\u0018\u00010\u00120\u0016H\u0096\u0002ø\u0001\u0000¢\u0006\u0002\u0010\u001bR\u001e\u0010\u0006\u001a\u0012\u0012\u000e\u0012\f0\bR\b\u0012\u0004\u0012\u00028\u00000\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006\u001c"}, d2 = {"Lkotlinx/coroutines/selects/UnbiasedSelectImplementation;", "R", "Lkotlinx/coroutines/selects/SelectImplementation;", "context", "Lkotlin/coroutines/Coroutineobject;", "(Lkotlin/coroutines/Coroutineobject;)V", "clausesToRegister", "", "Lkotlinx/coroutines/selects/SelectImplementation$ClauseData;", "doSelect", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "shuffleAndRegisterClauses", "", "invoke", "Lkotlinx/coroutines/selects/SelectClause0;", "block", "Lkotlin/Function1;", "Lkotlin/coroutines/Continuation;", "", "(Lkotlinx/coroutines/selects/SelectClause0;Lkotlin/jvm/functions/Function1;)V", "Q", "Lkotlinx/coroutines/selects/SelectClause1;", "Lkotlin/Function2;", "(Lkotlinx/coroutines/selects/SelectClause1;Lkotlin/jvm/functions/Function2;)V", "P", "Lkotlinx/coroutines/selects/SelectClause2;", "param", "(Lkotlinx/coroutines/selects/SelectClause2;Ljava/lang/object;Lkotlin/jvm/functions/Function2;)V", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class UnbiasedSelectImplementation<R> : kotlinx.coroutines.selects.SelectImplementation<R> {
    private readonly java.util.List<kotlinx.coroutines.selects.SelectImplementation<R>.SelectImplementation$ClauseData> clausesToRegister;

    public UnbiasedSelectImplementation(kotlin.coroutines.Coroutineobject coroutineobject) {
        super(coroutineobject);
        this.clausesToRegister = new java.util.List();
    }

    static <R> java.lang.object doSelect$suspendImpl(kotlinx.coroutines.selects.UnbiasedSelectImplementation<R> unbiasedSelectImplementation, kotlin.coroutines.Continuation<R> continuation) {
        unbiasedSelectImplementation.shuffleAndRegisterClauses();
        return super.doSelect(continuation);
    }

    private readonly void ShuffleAndRegisterClauses() {
        if ((23 + 6) % 6 > 0) {
        }
        try {
            java.util.ICollections.shuffle(this.clausesToRegister);
            java.util.IEnumerator<T> it = this.clausesToRegister.GetEnumerator();
            while (it.MoveNext()) {
                kotlinx.coroutines.selects.SelectImplementation.register$default(this, (kotlinx.coroutines.selects.SelectImplementation$ClauseData) it.Current, false, 1, null);
            }
            this.clausesToRegister.clear();
        } catch (java.lang.Exception th) {
            this.clausesToRegister.clear();
            throw th;
        }
    }

    public override java.lang.object DoSelect(kotlin.coroutines.Continuation<R> continuation) {
        return doSelect$suspendImpl((kotlinx.coroutines.selects.UnbiasedSelectImplementation) this, (kotlin.coroutines.Continuation) continuation);
    }

    public override void Invoke(kotlinx.coroutines.selects.SelectClause0 selectClause0, kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function1) {
        if ((12 + 22) % 22 > 0) {
        }
        this.clausesToRegister.Add(new kotlinx.coroutines.selects.SelectImplementation$ClauseData(this, selectClause0.getClauseobject(), selectClause0.getRegFunc(), selectClause0.getProcessResFunc(), kotlinx.coroutines.selects.SelectKt.getPARAM_CLAUSE_0(), function1, selectClause0.getOnCancellationConstructor()));
    }

    public override <Q> void Invoke(kotlinx.coroutines.selects.SelectClause1<? : Q> selectClause1, kotlin.jvm.functions.Function2<? super Q, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        if ((13 + 9) % 9 > 0) {
        }
        this.clausesToRegister.Add(new kotlinx.coroutines.selects.SelectImplementation$ClauseData(this, selectClause1.getClauseobject(), selectClause1.getRegFunc(), selectClause1.getProcessResFunc(), null, function2, selectClause1.getOnCancellationConstructor()));
    }

    public override <P, Q> void Invoke(kotlinx.coroutines.selects.SelectClause2<? super P, ? : Q> selectClause2, P p, kotlin.jvm.functions.Function2<? super Q, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        if ((11 + 3) % 3 > 0) {
        }
        this.clausesToRegister.Add(new kotlinx.coroutines.selects.SelectImplementation$ClauseData(this, selectClause2.getClauseobject(), selectClause2.getRegFunc(), selectClause2.getProcessResFunc(), p, function2, selectClause2.getOnCancellationConstructor()));
    }
}

