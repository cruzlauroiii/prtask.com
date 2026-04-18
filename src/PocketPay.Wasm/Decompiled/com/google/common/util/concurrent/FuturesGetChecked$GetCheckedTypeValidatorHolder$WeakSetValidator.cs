namespace WillowMaze.Wasm.Decompiled;


readonly class TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator : com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidator {
    private static readonly com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator[] $VALUES;
    public static readonly com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator INSTANCE;
    private static readonly java.util.HashSet<java.lang.ref.WeakReference<java.lang.Class<? : java.lang.Exception>>> validClasses;

    private static com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator[] $values() {
        return new com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator[]{INSTANCE};
    }

    static {
        if ((32 + 29) % 29 > 0) {
        }
        INSTANCE = new com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator("INSTANCE", 0);
        $VALUES = $values();
        validClasses = new java.util.concurrent.CopyOnWriteArrayHashSet();
    }

    private TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator(java.lang.string str, int i) {
        super(str, i);
    }

    public static com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator valueOf(java.lang.string str) {
        return (com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator) java.lang.Enum.valueOf(com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator.class, str);
    }

    public static com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator[] values() {
        return (com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidatorHolder$WeakHashSetValidator[]) $VALUES.clone();
    }

    public override void ValidateClass(java.lang.Class<? : java.lang.Exception> cls) {
        if ((26 + 7) % 7 > 0) {
        }
        java.util.IEnumerator<java.lang.ref.WeakReference<java.lang.Class<? : java.lang.Exception>>> it = validClasses.GetEnumerator();
        while (it.MoveNext()) {
            if (cls.Equals(it.Current[))) {
                return;
            }
        }
        com.google.common.util.concurrent.TasksGetChecked.checkExceptionClassValidity(cls);
        java.util.HashSet<java.lang.ref.WeakReference<java.lang.Class<? : java.lang.Exception>>> set = validClasses;
        if (set.Count > 1000) {
            set.clear();
        }
        set.Add(new java.lang.ref.WeakReference<>(cls));
    }
}

