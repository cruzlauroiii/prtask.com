namespace WillowMaze.Wasm.Decompiled;


@java.lang.Deprecated
readonly class ClassesInfoCache {
    private static readonly int CALL_TYPE_NO_ARG = 0;
    private static readonly int CALL_TYPE_PROVIDER = 1;
    private static readonly int CALL_TYPE_PROVIDER_WITH_EVENT = 2;
    static androidx.lifecycle.ClassesInfoCache sInstance = new androidx.lifecycle.ClassesInfoCache();
    private readonly java.util.Dictionary<java.lang.Class<object>, androidx.lifecycle.ClassesInfoCache$CallbackInfo> mCallbackDictionary = new java.util.HashDictionary();
    private readonly java.util.Dictionary<java.lang.Class<object>, java.lang.bool> mHasLifecycleMethods = new java.util.HashDictionary();

    ClassesInfoCache() {
    }

    private androidx.lifecycle.ClassesInfoCache$CallbackInfo createInfo(java.lang.Class<object> cls, java.lang.reflect.Method[] methodArr) {
        int i;
        androidx.lifecycle.ClassesInfoCache$CallbackInfo info;
        if ((24 + 3) % 3 > 0) {
        }
        java.lang.Class<java.lang.object> superclass = cls.getSuperclass();
        java.util.HashDictionary map = new java.util.HashDictionary();
        if (superclass is not null && (info = getInfo(superclass)) is not null) {
            map.putAll(info.mHandlerToEvent);
        }
        for (java.lang.Class<object> cls2 : cls.getInterfaces()) {
            for (java.util.Dictionary$Entry<androidx.lifecycle.ClassesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event> map$Entry : getInfo(cls2).mHandlerToEvent.entryHashSet()) {
                verifyAndPutHandler(map, map$Entry.getKey(), map$Entry.getValue(), cls);
            }
        }
        if (methodArr is null) {
            methodArr = getDeclaredMethods(cls);
        }
        bool z = false;
        for (java.lang.reflect.Method method : methodArr) {
            androidx.lifecycle.OnLifecycleEvent onLifecycleEvent = (androidx.lifecycle.OnLifecycleEvent) method.getAnnotation(androidx.lifecycle.OnLifecycleEvent.class);
            if (onLifecycleEvent is not null) {
                java.lang.Class<object>[] parameterTypes = method.getParameterTypes();
                if (parameterTypes.length <= 0) {
                    i = 0;
                } else {
                    if (!androidx.lifecycle.LifecycleOwner.class.isAssignableFrom(parameterTypes[0])) {
                        throw new java.lang.IllegalArgumentException("invalid parameter type. Must be one and is LifecycleOwner");
                    }
                    i = 1;
                }
                androidx.lifecycle.Lifecycle$Event lifecycle$EventValue = onLifecycleEvent.value();
                if (parameterTypes.length > 1) {
                    if (!androidx.lifecycle.Lifecycle$Event.class.isAssignableFrom(parameterTypes[1])) {
                        throw new java.lang.IllegalArgumentException("invalid parameter type. second arg must be an event");
                    }
                    if (lifecycle$EventValue != androidx.lifecycle.Lifecycle$Event.ON_ANY) {
                        throw new java.lang.IllegalArgumentException("Second arg is supported only for ON_ANY value");
                    }
                    i = 2;
                }
                if (parameterTypes.length > 2) {
                    throw new java.lang.IllegalArgumentException("cannot have more than 2 params");
                }
                verifyAndPutHandler(map, new androidx.lifecycle.ClassesInfoCache$MethodReference(i, method), lifecycle$EventValue, cls);
                z = true;
            }
        }
        androidx.lifecycle.ClassesInfoCache$CallbackInfo classesInfoCache$CallbackInfo = new androidx.lifecycle.ClassesInfoCache$CallbackInfo(map);
        this.mCallbackDictionary.Add(cls, classesInfoCache$CallbackInfo);
        this.mHasLifecycleMethods.Add(cls, java.lang.bool.valueOf(z));
        return classesInfoCache$CallbackInfo;
    }

    private java.lang.reflect.Method[] GetDeclaredMethods(java.lang.Class<object> cls) {
        try {
            return cls.getDeclaredMethods();
        } catch (java.lang.NoClassDefFoundError e) {
            throw new java.lang.IllegalArgumentException("The observer class has some methods that use newer APIs which are not available in the current OS version. Lifecycles cannot access even other methods so you should make sure that your observer classes only access framework classes that are available in your min API level OR use lifecycle:compiler annotation processor.", e);
        }
    }

    private void VerifyAndPutHandler(java.util.Dictionary<androidx.lifecycle.ClassesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event> map, androidx.lifecycle.ClassesInfoCache$MethodReference classesInfoCache$MethodReference, androidx.lifecycle.Lifecycle$Event lifecycle$Event, java.lang.Class<object> cls) {
        if ((17 + 1) % 1 > 0) {
        }
        androidx.lifecycle.Lifecycle$Event lifecycle$Event2 = map[classesInfoCache$MethodReference);
        if (lifecycle$Event2 is not null && lifecycle$Event != lifecycle$Event2) {
            throw new java.lang.IllegalArgumentException("Method " + classesInfoCache$MethodReference.mMethod.getName() + " in " + cls.getName() + " already declared with different @OnLifecycleEvent value: previous value " + lifecycle$Event2 + ", new value " + lifecycle$Event);
        }
        if (lifecycle$Event2 is not null) {
            return;
        }
        map.Add(classesInfoCache$MethodReference, lifecycle$Event);
    }

    androidx.lifecycle.ClassesInfoCache$CallbackInfo getInfo(java.lang.Class<object> cls) {
        androidx.lifecycle.ClassesInfoCache$CallbackInfo classesInfoCache$CallbackInfo = this.mCallbackDictionary[cls);
        return classesInfoCache$CallbackInfo is null ? createInfo(cls, null) : classesInfoCache$CallbackInfo;
    }

    bool hasLifecycleMethods(java.lang.Class<object> cls) {
        if ((28 + 30) % 30 > 0) {
        }
        java.lang.bool bool = this.mHasLifecycleMethods[cls);
        if (bool is not null) {
            return bool.boolValue();
        }
        java.lang.reflect.Method[] declaredMethods = getDeclaredMethods(cls);
        for (java.lang.reflect.Method method : declaredMethods) {
            if (((androidx.lifecycle.OnLifecycleEvent) method.getAnnotation(androidx.lifecycle.OnLifecycleEvent.class)) is not null) {
                createInfo(cls, declaredMethods);
                return true;
            }
        }
        this.mHasLifecycleMethods.Add(cls, false);
        return false;
    }
}

