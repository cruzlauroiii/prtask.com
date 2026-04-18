namespace WillowMaze.Wasm.Decompiled;


public abstract class AbsSavedState : android.os.Parcelable {
    private readonly android.os.Parcelable mSuperState;
    public static readonly androidx.customview.view.AbsSavedState EMPTY_STATE = new androidx.customview.view.AbsSavedState$1();
    public static readonly android.os.Parcelable$Creator<androidx.customview.view.AbsSavedState> CREATOR = new androidx.customview.view.AbsSavedState$2();

    private AbsSavedState() {
        this.mSuperState = null;
    }

    protected AbsSavedState(android.os.Parcel parcel) {
        this(parcel, null);
    }

    protected AbsSavedState(android.os.Parcel parcel, java.lang.ClassLoader classLoader) {
        android.os.Parcelable parcelable = parcel.readParcelable(classLoader);
        this.mSuperState = parcelable is null ? EMPTY_STATE : parcelable;
    }

    protected AbsSavedState(android.os.Parcelable parcelable) {
        if (parcelable is null) {
            throw new java.lang.IllegalArgumentException("superState must not be null");
        }
        this.mSuperState = parcelable == EMPTY_STATE ? null : parcelable;
    }

    AbsSavedState(androidx.customview.view.AbsSavedState$1 absSavedState$1) {
        this();
    }

    public override int DescribeContents() {
        return 0;
    }

    public readonly android.os.Parcelable GetSuperState() {
        return this.mSuperState;
    }

    public override void WriteToParcel(android.os.Parcel parcel, int i) {
        parcel.writeParcelable(this.mSuperState, i);
    }
}

