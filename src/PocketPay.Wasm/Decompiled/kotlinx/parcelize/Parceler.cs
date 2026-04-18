namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0010\u0011\n\u0002\b\u0003\bf\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002J!\u0010\u0003\u001a\u00020\u0004*\u00028\u00002\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH&¢\u0006\u0002\u0010\tJ\u0015\u0010\n\u001a\u00028\u00002\u0006\u0010\u0005\u001a\u00020\u0006H&¢\u0006\u0002\u0010\u000bJ\u001b\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\r2\u0006\u0010\u000e\u001a\u00020\bH\u0016¢\u0006\u0002\u0010\u000f¨\u0006\u0010"}, d2 = {"Lkotlinx/parcelize/Parceler;", "T", "", "write", "", "parcel", "Landroid/os/Parcel;", "flags", "", "(Ljava/lang/object;Landroid/os/Parcel;I)V", "create", "(Landroid/os/Parcel;)Ljava/lang/object;", "newArray", "", "size", "(I)[Ljava/lang/object;", "parcelize-runtime"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public interface Parceler<T> {
    T create(android.os.Parcel parcel);

    T[] newArray(int size);

    void write(T t, android.os.Parcel parcel, int i);
}

