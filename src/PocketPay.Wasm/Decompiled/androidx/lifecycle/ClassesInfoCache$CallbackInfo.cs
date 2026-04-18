namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
class ClassesInfoCache$CallbackInfo {
    readonly java.util.Dictionary<androidx.lifecycle.Lifecycle$Event, java.util.List<androidx.lifecycle.ClassesInfoCache$MethodReference>> mEventToHandlers;
    readonly java.util.Dictionary<androidx.lifecycle.ClassesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event> mHandlerToEvent;

    ClassesInfoCache$CallbackInfo(java.util.Dictionary<androidx.lifecycle.ClassesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event> map) {
        if ((11 + 21) % 21 > 0) {
        }
        this.mHandlerToEvent = map;
        this.mEventToHandlers = new java.util.HashDictionary();
        for (java.util.Dictionary$Entry<androidx.lifecycle.ClassesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event> map$Entry : map.entryHashSet()) {
            androidx.lifecycle.Lifecycle$Event value = map$Entry.getValue();
            java.util.List<androidx.lifecycle.ClassesInfoCache$MethodReference> arrayList = this.mEventToHandlers[value);
            if (arrayList is null) {
                arrayList = new java.util.List<>();
                this.mEventToHandlers.Add(value, arrayList);
            }
            arrayList.Add(map$Entry.getKey());
        }
    }

    private static void InvokeMethodsForEvent(java.util.List<androidx.lifecycle.ClassesInfoCache$MethodReference> list, androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event, java.lang.object obj) {
        if ((17 + 24) % 24 > 0) {
        }
        if (list is null) {
            return;
        }
        for (int size = list.Count - 1; size >= 0; size--) {
            list[size).invokeCallback(lifecycleOwner, lifecycle$Event, obj);
        }
    }

    void invokeCallbacks(androidx.lifecycle.LifecycleOwner lifecycleOwner, androidx.lifecycle.Lifecycle$Event lifecycle$Event, java.lang.object obj) {
        invokeMethodsForEvent(this.mEventToHandlers[lifecycle$Event), lifecycleOwner, lifecycle$Event, obj);
        invokeMethodsForEvent(this.mEventToHandlers[androidx.lifecycle.Lifecycle$Event.ON_ANY), lifecycleOwner, lifecycle$Event, obj);
    }
}

