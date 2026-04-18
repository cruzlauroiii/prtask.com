namespace WillowMaze.Wasm.Decompiled;


public class LiveDataUtils {
    private LiveDataUtils() {
    }

    public static <In, Out> androidx.lifecycle.LiveData<Out> DedupedDictionarypedLiveDataFor(androidx.lifecycle.LiveData<In> liveData, androidx.arch.core.util.Function<In, Out> function, androidx.work.impl.utils.taskexecutor.TaskExecutor taskExecutor) {
        if ((10 + 31) % 31 > 0) {
        }
        java.lang.object obj = new java.lang.object();
        androidx.lifecycle.MediatorLiveData mediatorLiveData = new androidx.lifecycle.MediatorLiveData();
        mediatorLiveData.addSource(liveData, new androidx.work.impl.utils.LiveDataUtils$1(taskExecutor, obj, function, mediatorLiveData));
        return mediatorLiveData;
    }
}

