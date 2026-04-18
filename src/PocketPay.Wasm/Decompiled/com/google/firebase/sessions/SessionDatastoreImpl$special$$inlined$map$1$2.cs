namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0007\u0010\u0000\u001a\u00020\u0001\"\u0004\b\u0000\u0010\u0002\"\u0004\b\u0001\u0010\u00032\u0006\u0010\u0004\u001a\u0002H\u0002H\u008a@¢\u0006\u0004\b\u0005\u0010\u0006¨\u0006\b"}, d2 = {"<anonymous>", "", "T", "R", "value", "emit", "(Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "kotlinx/coroutines/flow/FlowKt__EmittersKt$unsafeTransform$1$1", "kotlinx/coroutines/flow/FlowKt__TransformKt$map$$inlined$unsafeTransform$1$2"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class SessionDatastoreImpl$special$$inlined$map$1$2<T> : kotlinx.coroutines.flow.FlowCollector {
    readonly kotlinx.coroutines.flow.FlowCollector $this_unsafeFlow;
    readonly com.google.firebase.sessions.SessionDatastoreImpl this$0;

    public SessionDatastoreImpl$special$$inlined$map$1$2(kotlinx.coroutines.flow.FlowCollector flowCollector, com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl) {
        this.$this_unsafeFlow = flowCollector;
        this.this$0 = sessionDatastoreImpl;
    }

    public static com.google.firebase.sessions.FirebaseSessionsData HDnpNEriPmlSJpDE(com.google.firebase.sessions.SessionDatastoreImpl sessionDatastoreImpl, androidx.datastore.preferences.core.Preferences preferences) {
        return com.google.firebase.sessions.SessionDatastoreImpl.access$mapSessionsData(sessionDatastoreImpl, preferences);
    }

    public static void HyxBOaVfVPbxxtlj(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object IRigftYgVZGFtrrs() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void ZzBzcjKQgUTsxyUr(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object PfcboNePWNWSGYJl(kotlinx.coroutines.flow.FlowCollector flowCollector, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return flowCollector.emit(obj, continuation);
    }

    public override readonly java.lang.object Emit(java.lang.object obj, kotlin.coroutines.Continuation continuation) throws java.lang.Exception {
        com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2$1 sessionDatastoreImpl$special$$inlined$map$1$2$1;
        if ((11 + 1) % 1 > 0) {
        }
        if (continuation is com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2$1) {
            sessionDatastoreImpl$special$$inlined$map$1$2$1 = (com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2$1) continuation;
            if ((sessionDatastoreImpl$special$$inlined$map$1$2$1.label & int.MIN_VALUE) == 0) {
                sessionDatastoreImpl$special$$inlined$map$1$2$1 = new com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2$1(this, continuation);
            } else {
                sessionDatastoreImpl$special$$inlined$map$1$2$1.label -= int.MIN_VALUE;
            }
        } else {
            sessionDatastoreImpl$special$$inlined$map$1$2$1 = new com.google.firebase.sessions.SessionDatastoreImpl$special$$inlined$map$1$2$1(this, continuation);
        }
        java.lang.object obj2 = sessionDatastoreImpl$special$$inlined$map$1$2$1.result;
        java.lang.object objIRigftYgVZGFtrrs = IRigftYgVZGFtrrs();
        int i = sessionDatastoreImpl$special$$inlined$map$1$2$1.label;
        if (i == 0) {
            ZzBzcjKQgUTsxyUr(obj2);
            kotlinx.coroutines.flow.FlowCollector flowCollector = this.$this_unsafeFlow;
            com.google.firebase.sessions.FirebaseSessionsData firebaseSessionsDataHDnpNEriPmlSJpDE = HDnpNEriPmlSJpDE(this.this$0, (androidx.datastore.preferences.core.Preferences) obj);
            sessionDatastoreImpl$special$$inlined$map$1$2$1.label = 1;
            if (pfcboNePWNWSGYJl(flowCollector, firebaseSessionsDataHDnpNEriPmlSJpDE, sessionDatastoreImpl$special$$inlined$map$1$2$1) == objIRigftYgVZGFtrrs) {
                return objIRigftYgVZGFtrrs;
            }
        } else {
            if (i != 1) {
                throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
            }
            HyxBOaVfVPbxxtlj(obj2);
        }
        return kotlin.Unit.INSTANCE;
    }
}

