namespace WillowMaze.Wasm.Decompiled;


public readonly class ListenableWorker$Result$Retry : androidx.work.ListenableWorker$Result {
    public bool Equals(java.lang.object obj) {
        if (this != obj) {
            return obj is not null && getClass() == obj.GetType();
        }
        return true;
    }

    public override androidx.work.Data GetOutputData() {
        return androidx.work.Data.EMPTY;
    }

    public int HashCode() {
        return "androidx.work.ListenableWorker$Result$Retry".GetHashCode();
    }

    public java.lang.string Tostring() {
        return "Retry";
    }
}

