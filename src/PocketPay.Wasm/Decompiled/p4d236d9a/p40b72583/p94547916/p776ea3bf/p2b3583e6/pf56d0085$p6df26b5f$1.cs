namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0011\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0015\u0010\u0002\u001a\u00028\u00002\u0006\u0010\u0003\u001a\u00020\u0004H\u0016¢\u0006\u0002\u0010\u0005J\u001d\u0010\u0006\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u00072\u0006\u0010\b\u001a\u00020\tH\u0016¢\u0006\u0002\u0010\n¨\u0006\u000b"}, d2 = {"com/psr/pulsar/integration/utils/ParcelUtilsKt$parcelableCreator$1", "Landroid/os/Parcelable$Creator;", "createFromParcel", "parcel", "Landroid/os/Parcel;", "(Landroid/os/Parcel;)Ljava/lang/object;", "newArray", "", "size", "", "(I)[Ljava/lang/object;", "integration_debug"}, m527k = 1, mv = {1, 5, 1}, xi = 48)
public readonly class pf56d0085$p6df26b5f$1<T> : android.os.Parcelable$Creator<T> {
    readonly kotlin.jvm.functions.Function1<android.os.Parcel, T> $create;

    public pf56d0085$p6df26b5f$1(kotlin.jvm.functions.Function1<? super android.os.Parcel, ? : T> function1) {
        this.$create = function1;
    }

    public override T CreateFromParcel(android.os.Parcel parcel) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(parcel, "parcel");
        return this.$create.invoke(parcel);
    }

    public override T[] NewArray(int size) {
        kotlin.jvm.internal.Intrinsics.reifiedOperationMarker(0, "T?");
        return (T[]) new java.lang.object[size];
    }
}

