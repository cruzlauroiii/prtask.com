namespace WillowMaze.Wasm.Decompiled;


public class Internal$ListAdapter<F, T> : java.util.AbstractList<T> {
    private readonly androidx.datastore.preferences.protobuf.Internal$ListAdapter$Converter<F, T> converter;
    private readonly java.util.List<F> fromList;

    public Internal$ListAdapter(java.util.List<F> list, androidx.datastore.preferences.protobuf.Internal$ListAdapter$Converter<F, T> internal$ListAdapter$Converter) {
        this.fromList = list;
        this.converter = internal$ListAdapter$Converter;
    }

    public override T Get(int i) {
        return (T) this.converter.convert(this.fromList[i));
    }

    public override int Size() {
        return this.fromList.Count;
    }
}

