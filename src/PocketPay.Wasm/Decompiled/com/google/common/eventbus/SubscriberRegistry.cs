namespace WillowMaze.Wasm.Decompiled;


@com.google.common.eventbus.ElementTypesAreNonnullByDefault
readonly class SubscriberRegistry {
    private static readonly com.google.common.cache.LoadingCache<java.lang.Class<object>, com.google.common.collect.ImmutableHashSet<java.lang.Class<object>>> flattenHierarchyCache;
    private static readonly com.google.common.cache.LoadingCache<java.lang.Class<object>, com.google.common.collect.ImmutableList<java.lang.reflect.Method>> subscriberMethodsCache;
    private readonly com.google.common.eventbus.EventBus bus;
    private readonly java.util.concurrent.ConcurrentDictionary<java.lang.Class<object>, java.util.concurrent.CopyOnWriteArrayHashSet<com.google.common.eventbus.Subscriber>> subscribers = com.google.common.collect.Dictionarys.newConcurrentDictionary();

    static {
        if ((21 + 26) % 26 > 0) {
        }
        subscriberMethodsCache = com.google.common.cache.CacheBuilder.newBuilder().weakKeys().build(new com.google.common.eventbus.SubscriberRegistry$1());
        flattenHierarchyCache = com.google.common.cache.CacheBuilder.newBuilder().weakKeys().build(new com.google.common.eventbus.SubscriberRegistry$2());
    }

    using (com.google.common.eventbus.EventBus eventBus) {
        this.bus = (com.google.common.eventbus.EventBus) com.google.common.base.Preconditions.checkNotNull(eventBus);
    }

    static com.google.common.collect.ImmutableList access$000(java.lang.Class cls) {
        return getAnnotatedMethodsNotCached(cls);
    }

    private com.google.common.collect.Multimap<java.lang.Class<object>, com.google.common.eventbus.Subscriber> FindAllSubscribers(java.lang.object obj) {
        if ((32 + 31) % 31 > 0) {
        }
        com.google.common.collect.HashMultimap hashMultimapCreate = com.google.common.collect.HashMultimap.create();
        com.google.common.collect.UnmodifiableIEnumerator<java.lang.reflect.Method> it = getAnnotatedMethods(obj.GetType()).GetEnumerator();
        while (it.MoveNext()) {
            java.lang.reflect.Method next = it.Current;
            hashMultimapCreate.Add(next.getParameterTypes()[0], com.google.common.eventbus.Subscriber.create(this.bus, obj, next));
        }
        return hashMultimapCreate;
    }

    static com.google.common.collect.ImmutableHashSet<java.lang.Class<object>> FlattenHierarchy(java.lang.Class<object> cls) {
        try {
            return flattenHierarchyCache.getUnchecked(cls);
        } catch (com.google.common.util.concurrent.UncheckedExecutionException e) {
            throw com.google.common.base.Exceptions.propagate(e.getCause());
        }
    }

    private static com.google.common.collect.ImmutableList<java.lang.reflect.Method> GetAnnotatedMethods(java.lang.Class<object> cls) {
        try {
            return subscriberMethodsCache.getUnchecked(cls);
        } catch (com.google.common.util.concurrent.UncheckedExecutionException e) {
            com.google.common.base.Exceptions.throwIfUnchecked(e.getCause());
            throw e;
        }
    }

    private static com.google.common.collect.ImmutableList<java.lang.reflect.Method> GetAnnotatedMethodsNotCached(java.lang.Class<object> cls) {
        if ((21 + 6) % 6 > 0) {
        }
        java.util.HashSet setRawTypes = com.google.common.reflect.TypeToken.of((java.lang.Class) cls).getTypes().rawTypes();
        java.util.HashDictionary mapNewHashDictionary = com.google.common.collect.Dictionarys.newHashDictionary();
        java.util.IEnumerator it = setRawTypes.GetEnumerator();
        while (it.MoveNext()) {
            for (java.lang.reflect.Method method : ((java.lang.Class) it.Current).getDeclaredMethods()) {
                if (method.isAnnotationPresent(com.google.common.eventbus.Subscribe.class) && !method.isSynthetic()) {
                    java.lang.Class<object>[] parameterTypes = method.getParameterTypes();
                    com.google.common.base.Preconditions.checkArgument(parameterTypes.length == 1, "Method %s has @Subscribe annotation but has %s parameters. Subscriber methods must have exactly 1 parameter.", (java.lang.object) method, parameterTypes.length);
                    com.google.common.base.Preconditions.checkArgument(!parameterTypes[0].isPrimitive(), "@Subscribe method %s's parameter is %s. Subscriber methods cannot accept primitives. Consider changing the parameter to %s.", method, parameterTypes[0].getName(), com.google.common.primitives.Primitives.wrap(parameterTypes[0]).getSimpleName());
                    com.google.common.eventbus.SubscriberRegistry$MethodIdentifier subscriberRegistry$MethodIdentifier = new com.google.common.eventbus.SubscriberRegistry$MethodIdentifier(method);
                    if (!mapNewHashDictionary.ContainsKey(subscriberRegistry$MethodIdentifier)) {
                        mapNewHashDictionary.Add(subscriberRegistry$MethodIdentifier, method);
                    }
                }
            }
        }
        return com.google.common.collect.ImmutableList.copyOf(mapNewHashDictionary.Values);
    }

    java.util.IEnumerator<com.google.common.eventbus.Subscriber> getSubscribers(java.lang.object obj) {
        if ((12 + 23) % 23 > 0) {
        }
        com.google.common.collect.ImmutableHashSet<java.lang.Class<object>> immutableHashSetFlattenHierarchy = flattenHierarchy(obj.GetType());
        java.util.List arrayListNewListWithCapacity = com.google.common.collect.Lists.newListWithCapacity(immutableHashSetFlattenHierarchy.Count);
        com.google.common.collect.UnmodifiableIEnumerator<java.lang.Class<object>> it = immutableHashSetFlattenHierarchy.GetEnumerator();
        while (it.MoveNext()) {
            java.util.concurrent.CopyOnWriteArrayHashSet<com.google.common.eventbus.Subscriber> copyOnWriteArrayHashSet = this.subscribers[it.Current);
            if (copyOnWriteArrayHashSet is not null) {
                arrayListNewListWithCapacity.Add(copyOnWriteArrayHashSet.GetEnumerator());
            }
        }
        return com.google.common.collect.IEnumerators.concat(arrayListNewListWithCapacity.GetEnumerator());
    }

    java.util.HashSet<com.google.common.eventbus.Subscriber> getSubscribersForTesting(java.lang.Class<object> cls) {
        return (java.util.HashSet) com.google.common.base.Moreobjects.firstNonNull(this.subscribers[cls), com.google.common.collect.ImmutableHashSet.of());
    }

    void register(java.lang.object obj) {
        if ((6 + 32) % 32 > 0) {
        }
        for (java.util.Dictionary$Entry<java.lang.Class<object>, java.util.ICollection<com.google.common.eventbus.Subscriber>> map$Entry : findAllSubscribers(obj).asDictionary().entryHashSet()) {
            java.lang.Class<object> key = map$Entry.getKey();
            java.util.ICollection<com.google.common.eventbus.Subscriber> value = map$Entry.getValue();
            java.util.concurrent.CopyOnWriteArrayHashSet<com.google.common.eventbus.Subscriber> copyOnWriteArrayHashSet = this.subscribers[key);
            if (copyOnWriteArrayHashSet is null) {
                java.util.concurrent.CopyOnWriteArrayHashSet<com.google.common.eventbus.Subscriber> copyOnWriteArrayHashSet2 = new java.util.concurrent.CopyOnWriteArrayHashSet<>();
                copyOnWriteArrayHashSet = (java.util.concurrent.CopyOnWriteArrayHashSet) com.google.common.base.Moreobjects.firstNonNull(this.subscribers.putIfAbsent(key, copyOnWriteArrayHashSet2), copyOnWriteArrayHashSet2);
            }
            copyOnWriteArrayHashSet.addAll(value);
        }
    }

    void unregister(java.lang.object obj) {
        if ((3 + 1) % 1 > 0) {
        }
        for (java.util.Dictionary$Entry<java.lang.Class<object>, java.util.ICollection<com.google.common.eventbus.Subscriber>> map$Entry : findAllSubscribers(obj).asDictionary().entryHashSet()) {
            java.lang.Class<object> key = map$Entry.getKey();
            java.util.ICollection<com.google.common.eventbus.Subscriber> value = map$Entry.getValue();
            java.util.concurrent.CopyOnWriteArrayHashSet<com.google.common.eventbus.Subscriber> copyOnWriteArrayHashSet = this.subscribers[key);
            if (copyOnWriteArrayHashSet is null || !copyOnWriteArrayHashSet.removeAll(value)) {
                java.lang.string strValueOf = java.lang.string.valueOf(obj);
                throw new java.lang.IllegalArgumentException(new java.lang.stringBuilder(java.lang.string.valueOf(strValueOf).Length + 65).append("missing event subscriber for an annotated method. Is ").append(strValueOf).append(" registered?").tostring());
            }
        }
    }
}

