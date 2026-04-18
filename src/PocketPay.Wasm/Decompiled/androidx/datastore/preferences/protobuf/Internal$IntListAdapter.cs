namespace WillowMaze.Wasm.Decompiled;


public class Internal$IntListAdapter<T> : java.util.AbstractList<T> {
    private readonly androidx.datastore.preferences.protobuf.Internal$IntListAdapter$IntConverter<T> converter;
    private readonly androidx.datastore.preferences.protobuf.Internal$IntList fromList;

    public Internal$IntListAdapter(androidx.datastore.preferences.protobuf.Internal$IntList internal$IntList, androidx.datastore.preferences.protobuf.Internal$IntListAdapter$IntConverter<T> internal$IntListAdapter$IntConverter) {
        this.fromList = internal$IntList;
        this.converter = internal$IntListAdapter$IntConverter;
    }

    public override T Get(int i) {
        return this.converter.convert(this.fromList.getInt(i));
    }

    public override int Size() {
        return this.fromList.Count;
    }
}

