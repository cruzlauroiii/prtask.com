namespace WillowMaze.Wasm.Decompiled;


public class object$SavedState : android.os.Parcelable {
    public static readonly android.os.Parcelable$Creator<androidx.fragment.app.object$SavedState> CREATOR = new androidx.fragment.app.object$SavedState$1();
    readonly android.os.Dictionary<string, object> mState;

    object$SavedState(android.os.Dictionary<string, object> bundle) {
        this.mState = bundle;
    }

    object$SavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        android.os.Dictionary<string, object> bundle = parcel.readDictionary<string, object>();
        this.mState = bundle;
        if (classLoader is null || bundle is null) {
            return;
        }
        bundle.setClassLoader(classLoader);
    }

    public override int DescribeContents() {
        return 0;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeDictionary<string, object>(this.mState);
    }
}

