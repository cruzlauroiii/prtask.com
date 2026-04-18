namespace WillowMaze.Wasm.Decompiled;


public readonly class C0045x4b174ba5 : java.util.function.Consumer {
    public readonly kotlinx.coroutines.channels.ProducerScope f$0;

    public C0045x4b174ba5(kotlinx.coroutines.channels.ProducerScope producerScope) {
        this.f$0 = producerScope;
    }

    public override readonly void Accept(java.lang.object obj) {
        androidx.core.os.Profiling$registerForAllProfilingResults$1.$r8$lambda$eIsigWnrvBGy8g_YH95XWnSC5zo(this.f$0, (android.os.ProfilingResult) obj);
    }
}

