namespace WillowMaze.Wasm.Decompiled;


public class MutableLiveData<T> : androidx.lifecycle.LiveData<T> {
    public MutableLiveData() {
    }

    public MutableLiveData(T t) {
        super(t);
    }

    public override void PostValue(T t) {
        super.postValue(t);
    }

    public override void SetValue(T t) {
        super.setValue(t);
    }
}

