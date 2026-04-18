namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B\u0013\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004¢\u0006\u0002\u0010\u0005J\u0016\u0010\t\u001a\u00028\u00002\u0006\u0010\n\u001a\u00020\u000bH\u0096@¢\u0006\u0002\u0010\fJ\u001e\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00028\u00002\u0006\u0010\u0010\u001a\u00020\u0011H\u0096@¢\u0006\u0002\u0010\u0012R\u0014\u0010\u0006\u001a\u00028\u00008VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0007\u0010\bR\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0013"}, d2 = {"Landroidx/datastore/OkioSerializerWrapper;", "T", "Landroidx/datastore/core/okio/OkioSerializer;", "delegate", "Landroidx/datastore/core/Serializer;", "(Landroidx/datastore/core/Serializer;)V", "defaultValue", "getDefaultValue", "()Ljava/lang/object;", "readFrom", "source", "Lp38cb8f46/pcc81e3f6;", "(Lp38cb8f46/pcc81e3f6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "writeTo", "", "t", "sink", "Lp38cb8f46/p08d84bc6;", "(Ljava/lang/object;Lp38cb8f46/p08d84bc6;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "datastore_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OkioSerializerWrapper<T> : androidx.datastore.core.okio.OkioSerializer<T> {
    private readonly androidx.datastore.core.Serializer<T> delegate;

    public OkioSerializerWrapper(androidx.datastore.core.Serializer<T> serializer) {
        gfbFWmAySBIILNpn(serializer, "delegate");
        this.delegate = serializer;
    }

    public static java.lang.object JUORrayHJcOgFunF(androidx.datastore.core.Serializer serializer) {
        return serializer.getDefaultValue();
    }

    public static java.lang.object PlrXugYnzBVVtLhb(androidx.datastore.core.Serializer serializer, java.io.Stream inputStream, kotlin.coroutines.Continuation continuation) {
        return serializer.readFrom(inputStream, continuation);
    }

    public static void GfbFWmAySBIILNpn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static java.io.Stream MgOvIehFrXJDkIlR(p38cb8f46.pcc81e3f6 pcc81e3f6Var) {
        return pcc81e3f6Var.inputStream();
    }

    public static java.lang.object NukbRWnICfCbsCWg() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.io.Stream RQAOKQGlpZiOnOlp(p38cb8f46.p08d84bc6 p08d84bc6Var) {
        return p08d84bc6Var.outputStream();
    }

    public static java.lang.object ZHtRKQgZKPlUeVMV(androidx.datastore.core.Serializer serializer, java.lang.object obj, java.io.Stream outputStream, kotlin.coroutines.Continuation continuation) {
        return serializer.writeTo(obj, outputStream, continuation);
    }

    public override T GetDefaultValue() {
        return (T) JUORrayHJcOgFunF(this.delegate);
    }

    public override java.lang.object ReadFrom(p38cb8f46.pcc81e3f6 pcc81e3f6Var, kotlin.coroutines.Continuation<T> continuation) {
        return PlrXugYnzBVVtLhb(this.delegate, mgOvIehFrXJDkIlR(pcc81e3f6Var), continuation);
    }

    public override java.lang.object WriteTo(T t, p38cb8f46.p08d84bc6 p08d84bc6Var, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objZHtRKQgZKPlUeVMV = zHtRKQgZKPlUeVMV(this.delegate, t, rQAOKQGlpZiOnOlp(p08d84bc6Var), continuation);
        return objZHtRKQgZKPlUeVMV != nukbRWnICfCbsCWg() ? kotlin.Unit.INSTANCE : objZHtRKQgZKPlUeVMV;
    }
}

