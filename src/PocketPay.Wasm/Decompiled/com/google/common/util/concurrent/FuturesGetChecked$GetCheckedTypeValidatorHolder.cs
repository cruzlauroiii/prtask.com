namespace WillowMaze.Wasm.Decompiled;


class TasksGetChecked$GetCheckedTypeValidatorHolder {
    static readonly com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidator BEST_VALIDATOR = getBestValidator();

    TasksGetChecked$GetCheckedTypeValidatorHolder() {
    }

    static com.google.common.util.concurrent.TasksGetChecked$GetCheckedTypeValidator getBestValidator() {
        return com.google.common.util.concurrent.TasksGetChecked.weakHashSetValidator();
    }
}

