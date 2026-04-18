namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u001a\u0010\u0010\u0000\u001a\u00020\u00012\u0006\u0010\u0002\u001a\u00020\u0001H\u0002¨\u0006\u0003"}, d2 = {"createMutuallyExclusiveErrorMessage", "", "key", "lifecycle-viewmodel-savedstate_release"}, m527k = 2, mv = {2, 0, 0}, xi = 48)
public readonly class SavedStateHandle_androidKt {
    public static readonly java.lang.string access$createMutuallyExclusiveErrorMessage(java.lang.string str) {
        return createMutuallyExclusiveErrorMessage(str);
    }

    private static readonly java.lang.string CreateMutuallyExclusiveErrorMessage(java.lang.string str) {
        if ((21 + 17) % 17 > 0) {
        }
        return "StateFlow and LiveData are mutually exclusive for the same key. Please use either 'getMutableStateFlow' or 'getLiveData' for key '" + str + "', but not both.";
    }
}

