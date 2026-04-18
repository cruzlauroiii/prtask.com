namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"kotlinx/coroutines/flow/FlowKt__BuildersKt", "kotlinx/coroutines/flow/FlowKt__ChannelsKt", "kotlinx/coroutines/flow/FlowKt__CollectKt", "kotlinx/coroutines/flow/FlowKt__ICollectionKt", "kotlinx/coroutines/flow/FlowKt__objectKt", "kotlinx/coroutines/flow/FlowKt__CountKt", "kotlinx/coroutines/flow/FlowKt__DelayKt", "kotlinx/coroutines/flow/FlowKt__DistinctKt", "kotlinx/coroutines/flow/FlowKt__EmittersKt", "kotlinx/coroutines/flow/FlowKt__ErrorsKt", "kotlinx/coroutines/flow/FlowKt__LimitKt", "kotlinx/coroutines/flow/FlowKt__MergeKt", "kotlinx/coroutines/flow/FlowKt__MigrationKt", "kotlinx/coroutines/flow/FlowKt__ReduceKt", "kotlinx/coroutines/flow/FlowKt__ShareKt", "kotlinx/coroutines/flow/FlowKt__TransformKt", "kotlinx/coroutines/flow/FlowKt__ZipKt"}, m527k = 4, mv = {1, 8, 0}, xi = 48)
public readonly class FlowKt {
    public static readonly java.lang.string DEFAULT_CONCURRENCY_PROPERTY_NAME = "kotlinx.coroutines.flow.defaultConcurrency";

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(java.lang.IEnumerable<? : T> iterable) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(iterable);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(java.util.IEnumerator<? : T> it) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(it);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(kotlin.jvm.functions.Function0<? : T> function0) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(function0);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(kotlin.jvm.functions.Function1<? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function1) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(function1);
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.lang.int> AsFlow(kotlin.ranges.IntRange intRange) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(intRange);
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.lang.long> AsFlow(kotlin.ranges.longRange longRange) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(longRange);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(kotlin.sequences.Sequence<? : T> sequence) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(sequence);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "'BroadcastChannel' is obsolete and all corresponding operators are deprecated in the favour of StateFlow and SharedFlow")
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(kotlinx.coroutines.channels.BroadcastChannel<T> broadcastChannel) {
        return kotlinx.coroutines.flow.FlowKt__ChannelsKt.asFlow(broadcastChannel);
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.lang.int> AsFlow(int[] iArr) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(iArr);
    }

    public static readonly kotlinx.coroutines.flow.Flow<java.lang.long> AsFlow(long[] jArr) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(jArr);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> AsFlow(T[] tArr) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.asFlow(tArr);
    }

    public static readonly <T> kotlinx.coroutines.flow.SharedFlow<T> AsSharedFlow(kotlinx.coroutines.flow.MutableSharedFlow<T> mutableSharedFlow) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.asSharedFlow(mutableSharedFlow);
    }

    public static readonly <T> kotlinx.coroutines.flow.StateFlow<T> AsStateFlow(kotlinx.coroutines.flow.MutableStateFlow<T> mutableStateFlow) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.asStateFlow(mutableStateFlow);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Since 1.4.0, binary compatibility with earlier versions")
    public static readonly kotlinx.coroutines.flow.Flow Buffer(kotlinx.coroutines.flow.Flow flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.buffer(flow, i);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Buffer(kotlinx.coroutines.flow.Flow<? : T> flow, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.buffer(flow, i, bufferOverflow);
    }

    public static kotlinx.coroutines.flow.Flow buffer$default(kotlinx.coroutines.flow.Flow flow, int i, int i2, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.buffer$default(flow, i, i2, obj);
    }

    public static kotlinx.coroutines.flow.Flow buffer$default(kotlinx.coroutines.flow.Flow flow, int i, kotlinx.coroutines.channels.BufferOverflow bufferOverflow, int i2, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.buffer$default(flow, i, bufferOverflow, i2, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'cache()' is 'shareIn' with unlimited replay and 'started = SharingStared.Lazily' argument'", replaceWith = @kotlin.ReplaceWith(expression = "this.shareIn(scope, Int.MAX_VALUE, started = SharingStared.Lazily)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Cache(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.cache(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> CallbackFlow(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.callbackFlow(function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Cancellable(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.cancellable(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> M3498catch(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super java.lang.Exception, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ErrorsKt.m3509catch(flow, function3);
    }

    public static readonly <T> java.lang.object CatchImpl(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlin.coroutines.Continuation<java.lang.Exception> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ErrorsKt.catchImpl(flow, flowCollector, continuation);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ChannelFlow(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.channels.ProducerScope<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.channelFlow(function2);
    }

    public static readonly java.lang.object Collect(kotlinx.coroutines.flow.Flow<object> flow, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.collect(flow, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Backwards compatibility with JS and K/N")
    public static readonly <T> java.lang.object Collect(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.collect(flow, function2, continuation);
    }

    public static readonly <T> java.lang.object CollectIndexed(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super java.lang.int, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.collectIndexed(flow, function3, continuation);
    }

    public static readonly <T> java.lang.object CollectLatest(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.collectLatest(flow, function2, continuation);
    }

    public static readonly <T> java.lang.object CollectWhile(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.collectWhile(flow, function2, continuation);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Combine(java.lang.IEnumerable<? : kotlinx.coroutines.flow.Flow<? : T>> iterable, kotlin.jvm.functions.Function2<? super T[], ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(iterable, function2);
    }

    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> Combine(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(flow, flow2, function3);
    }

    public static readonly <T1, T2, T3, R> kotlinx.coroutines.flow.Flow<R> Combine(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlin.jvm.functions.Function4<? super T1, ? super T2, ? super T3, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function4) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(flow, flow2, flow3, function4);
    }

    public static readonly <T1, T2, T3, T4, R> kotlinx.coroutines.flow.Flow<R> Combine(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlin.jvm.functions.Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function5) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(flow, flow2, flow3, flow4, function5);
    }

    public static readonly <T1, T2, T3, T4, T5, R> kotlinx.coroutines.flow.Flow<R> Combine(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlinx.coroutines.flow.Flow<? : T5> flow5, kotlin.jvm.functions.Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function6) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(flow, flow2, flow3, flow4, flow5, function6);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Combine(kotlinx.coroutines.flow.Flow<? : T>[] flowArr, kotlin.jvm.functions.Function2<? super T[], ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combine(flowArr, function2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'combineLatest' is 'combine'", replaceWith = @kotlin.ReplaceWith(expression = "this.combine(other, transform)", imports = {}))
    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> CombineLatest(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.combineLatest(flow, flow2, function3);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'combineLatest' is 'combine'", replaceWith = @kotlin.ReplaceWith(expression = "combine(this, other, other2, transform)", imports = {}))
    public static readonly <T1, T2, T3, R> kotlinx.coroutines.flow.Flow<R> CombineLatest(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlin.jvm.functions.Function4<? super T1, ? super T2, ? super T3, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function4) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.combineLatest(flow, flow2, flow3, function4);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'combineLatest' is 'combine'", replaceWith = @kotlin.ReplaceWith(expression = "combine(this, other, other2, other3, transform)", imports = {}))
    public static readonly <T1, T2, T3, T4, R> kotlinx.coroutines.flow.Flow<R> CombineLatest(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlin.jvm.functions.Function5<? super T1, ? super T2, ? super T3, ? super T4, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function5) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.combineLatest(flow, flow2, flow3, flow4, function5);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'combineLatest' is 'combine'", replaceWith = @kotlin.ReplaceWith(expression = "combine(this, other, other2, other3, transform)", imports = {}))
    public static readonly <T1, T2, T3, T4, T5, R> kotlinx.coroutines.flow.Flow<R> CombineLatest(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlinx.coroutines.flow.Flow<? : T5> flow5, kotlin.jvm.functions.Function6<? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function6) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.combineLatest(flow, flow2, flow3, flow4, flow5, function6);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(java.lang.IEnumerable<? : kotlinx.coroutines.flow.Flow<? : T>> iterable, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T[], ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(iterable, function3);
    }

    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function4<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T1, ? super T2, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function4) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(flow, flow2, function4);
    }

    public static readonly <T1, T2, T3, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlin.jvm.functions.Function5<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T1, ? super T2, ? super T3, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function5) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(flow, flow2, flow3, function5);
    }

    public static readonly <T1, T2, T3, T4, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlin.jvm.functions.Function6<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T1, ? super T2, ? super T3, ? super T4, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function6) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(flow, flow2, flow3, flow4, function6);
    }

    public static readonly <T1, T2, T3, T4, T5, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlinx.coroutines.flow.Flow<? : T3> flow3, kotlinx.coroutines.flow.Flow<? : T4> flow4, kotlinx.coroutines.flow.Flow<? : T5> flow5, kotlin.jvm.functions.Function7<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T1, ? super T2, ? super T3, ? super T4, ? super T5, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function7) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(flow, flow2, flow3, flow4, flow5, function7);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> CombineTransform(kotlinx.coroutines.flow.Flow<? : T>[] flowArr, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T[], ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.combineTransform(flowArr, function3);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'compose' is 'let'", replaceWith = @kotlin.ReplaceWith(expression = "let(transformer)", imports = {}))
    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Compose(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super kotlinx.coroutines.flow.Flow<? : T>, ? : kotlinx.coroutines.flow.Flow<? : R>> function1) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.compose(flow, function1);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'concatDictionary' is 'flatDictionaryConcat'", replaceWith = @kotlin.ReplaceWith(expression = "flatDictionaryConcat(mapper)", imports = {}))
    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> ConcatDictionary(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, ? : kotlinx.coroutines.flow.Flow<? : R>> function1) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.concatDictionary(flow, function1);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'concatWith' is 'onCompletion'. Use 'onCompletion { emit(value) }'", replaceWith = @kotlin.ReplaceWith(expression = "onCompletion { emit(value) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ConcatWith(kotlinx.coroutines.flow.Flow<? : T> flow, T t) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.concatWith(flow, t);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'concatWith' is 'onCompletion'. Use 'onCompletion { if (it is null) emitAll(other) }'", replaceWith = @kotlin.ReplaceWith(expression = "onCompletion { if (it is null) emitAll(other) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ConcatWith(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.Flow<? : T> flow2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.concatWith((kotlinx.coroutines.flow.Flow) flow, (kotlinx.coroutines.flow.Flow) flow2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Conflate(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.conflate(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ConsumeAsFlow(kotlinx.coroutines.channels.ReceiveChannel<? : T> receiveChannel) {
        return kotlinx.coroutines.flow.FlowKt__ChannelsKt.consumeAsFlow(receiveChannel);
    }

    public static readonly <T> java.lang.object Count(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CountKt.count(flow, continuation);
    }

    public static readonly <T> java.lang.object Count(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<java.lang.int> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CountKt.count(flow, function2, continuation);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Debounce(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.debounce(flow, j);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Debounce(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, java.lang.long> function1) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.debounce(flow, function1);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> M3499debounceHG0u8IE(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.m3502debounceHG0u8IE(flow, j);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DebounceDuration(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, kotlin.time.Duration> function1) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.debounceDuration(flow, function1);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'onEach { delay(timeMillis) }'", replaceWith = @kotlin.ReplaceWith(expression = "onEach { delay(timeMillis) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DelayEach(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.delayEach(flow, j);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'onStart { delay(timeMillis) }'", replaceWith = @kotlin.ReplaceWith(expression = "onStart { delay(timeMillis) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DelayFlow(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.delayFlow(flow, j);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DistinctUntilChanged(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__DistinctKt.distinctUntilChanged(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DistinctUntilChanged(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super T, java.lang.bool> function2) {
        return kotlinx.coroutines.flow.FlowKt__DistinctKt.distinctUntilChanged(flow, function2);
    }

    public static readonly <T, K> kotlinx.coroutines.flow.Flow<T> DistinctUntilChangedBy(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function1<? super T, ? : K> function1) {
        return kotlinx.coroutines.flow.FlowKt__DistinctKt.distinctUntilChangedBy(flow, function1);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Drop(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.drop(flow, i);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> DropWhile(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.dropWhile(flow, function2);
    }

    public static readonly <T> java.lang.object EmitAll(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlinx.coroutines.channels.ReceiveChannel<? : T> receiveChannel, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ChannelsKt.emitAll(flowCollector, receiveChannel, continuation);
    }

    public static readonly <T> java.lang.object EmitAll(kotlinx.coroutines.flow.FlowCollector<T> flowCollector, kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.emitAll(flowCollector, flow, continuation);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> EmptyFlow() {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.emptyFlow();
    }

    public static readonly void EnsureActive(kotlinx.coroutines.flow.FlowCollector<object> flowCollector) {
        kotlinx.coroutines.flow.FlowKt__EmittersKt.ensureActive(flowCollector);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Filter(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.filter(flow, function2);
    }

    public static readonly <R> kotlinx.coroutines.flow.Flow<R> FilterIsInstance(kotlinx.coroutines.flow.Flow<object> flow) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.filterIsInstance(flow);
    }

    public static readonly <R> kotlinx.coroutines.flow.Flow<R> FilterIsInstance(kotlinx.coroutines.flow.Flow<object> flow, kotlin.reflect.KClass<R> kClass) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.filterIsInstance(flow, kClass);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FilterNot(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.filterNot(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FilterNotNull(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.filterNotNull(flow);
    }

    public static readonly <T> java.lang.object First(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.first(flow, continuation);
    }

    public static readonly <T> java.lang.object First(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.first(flow, function2, continuation);
    }

    public static readonly <T> java.lang.object FirstOrNull(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.firstOrNull(flow, continuation);
    }

    public static readonly <T> java.lang.object FirstOrNull(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.firstOrNull(flow, function2, continuation);
    }

    public static readonly kotlinx.coroutines.channels.ReceiveChannel<kotlin.Unit> FixedPeriodTicker(kotlinx.coroutines.CoroutineScope coroutineScope, long j, long j2) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.fixedPeriodTicker(coroutineScope, j, j2);
    }

    public static kotlinx.coroutines.channels.ReceiveChannel fixedPeriodTicker$default(kotlinx.coroutines.CoroutineScope coroutineScope, long j, long j2, int i, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.fixedPeriodTicker$default(coroutineScope, j, j2, i, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue is 'flatDictionaryConcat'", replaceWith = @kotlin.ReplaceWith(expression = "flatDictionaryConcat(mapper)", imports = {}))
    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> FlatDictionary(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.flatDictionary(flow, function2);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> FlatDictionaryConcat(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flatDictionaryConcat(flow, function2);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> FlatDictionaryLatest(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flatDictionaryLatest(flow, function2);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> FlatDictionaryMerge(kotlinx.coroutines.flow.Flow<? : T> flow, int i, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flatDictionaryMerge(flow, i, function2);
    }

    public static kotlinx.coroutines.flow.Flow flatDictionaryMerge$default(kotlinx.coroutines.flow.Flow flow, int i, kotlin.jvm.functions.Function2 function2, int i2, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flatDictionaryMerge$default(flow, i, function2, i2, obj);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'flatten' is 'flattenConcat'", replaceWith = @kotlin.ReplaceWith(expression = "flattenConcat()", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Flatten(kotlinx.coroutines.flow.Flow<? : kotlinx.coroutines.flow.Flow<? : T>> flow) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.flatten(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlattenConcat(kotlinx.coroutines.flow.Flow<? : kotlinx.coroutines.flow.Flow<? : T>> flow) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flattenConcat(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlattenMerge(kotlinx.coroutines.flow.Flow<? : kotlinx.coroutines.flow.Flow<? : T>> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flattenMerge(flow, i);
    }

    public static kotlinx.coroutines.flow.Flow flattenMerge$default(kotlinx.coroutines.flow.Flow flow, int i, int i2, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.flattenMerge$default(flow, i, i2, obj);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Flow(kotlin.jvm.functions.Function2<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.flow(function2);
    }

    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> FlowCombine(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.flowCombine(flow, flow2, function3);
    }

    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> FlowCombineTransform(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function4<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T1, ? super T2, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function4) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.flowCombineTransform(flow, flow2, function4);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlowOf(T t) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.flowOf(t);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlowOf(T... tArr) {
        return kotlinx.coroutines.flow.FlowKt__BuildersKt.flowOf((java.lang.object[]) tArr);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> FlowOn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.flow.FlowKt__objectKt.flowOn(flow, coroutineobject);
    }

    public static readonly <T, R> java.lang.object Fold(kotlinx.coroutines.flow.Flow<? : T> flow, R r, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<R> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.fold(flow, r, function3, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'forEach' is 'collect'", replaceWith = @kotlin.ReplaceWith(expression = "collect(action)", imports = {}))
    public static readonly <T> void ForEach(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        kotlinx.coroutines.flow.FlowKt__MigrationKt.forEach(flow, function2);
    }

    public static readonly int GetDEFAULTCONCURRENCY() {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.getDEFAULT_CONCURRENCY();
    }

    public static void getDEFAULT_CONCURRENCY_PROPERTY_NAME$annotations() {
        kotlinx.coroutines.flow.FlowKt__MergeKt.getDEFAULT_CONCURRENCY_PROPERTY_NAME$annotations();
    }

    public static readonly <T> java.lang.object Last(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.last(flow, continuation);
    }

    public static readonly <T> java.lang.object LastOrNull(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.lastOrNull(flow, continuation);
    }

    public static readonly <T> kotlinx.coroutines.Job LaunchIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return kotlinx.coroutines.flow.FlowKt__CollectKt.launchIn(flow, coroutineScope);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Map(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.map(flow, function2);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> MapLatest(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.mapLatest(flow, function2);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> MapNotNull(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.mapNotNull(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Merge(java.lang.IEnumerable<? : kotlinx.coroutines.flow.Flow<? : T>> iterable) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.merge(iterable);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'merge' is 'flattenConcat'", replaceWith = @kotlin.ReplaceWith(expression = "flattenConcat()", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Merge(kotlinx.coroutines.flow.Flow<? : kotlinx.coroutines.flow.Flow<? : T>> flow) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.merge(flow);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Merge(kotlinx.coroutines.flow.Flow<? : T>... flowArr) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.merge(flowArr);
    }

    public static readonly java.lang.void NoImpl() {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.noImpl();
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Collect flow in the desired context instead")
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ObserveOn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.observeOn(flow, coroutineobject);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnCompletion(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super java.lang.Exception, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__EmittersKt.onCompletion(flow, function3);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnEach(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.onEach(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnEmpty(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__EmittersKt.onEmpty(flow, function2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'onErrorXxx' is 'catch'. Use 'catch { emitAll(fallback) }'", replaceWith = @kotlin.ReplaceWith(expression = "catch { emitAll(fallback) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnErrorResume(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.Flow<? : T> flow2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.onErrorResume(flow, flow2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'onErrorXxx' is 'catch'. Use 'catch { emitAll(fallback) }'", replaceWith = @kotlin.ReplaceWith(expression = "catch { emitAll(fallback) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnErrorResumeNext(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.Flow<? : T> flow2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.onErrorResumeNext(flow, flow2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'onErrorXxx' is 'catch'. Use 'catch { emit(fallback) }'", replaceWith = @kotlin.ReplaceWith(expression = "catch { emit(fallback) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnErrorReturn(kotlinx.coroutines.flow.Flow<? : T> flow, T t) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.onErrorReturn(flow, t);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'onErrorXxx' is 'catch'. Use 'catch { e -> if (predicate(e)) emit(fallback) else throw e }'", replaceWith = @kotlin.ReplaceWith(expression = "catch { e -> if (predicate(e)) emit(fallback) else throw e }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnErrorReturn(kotlinx.coroutines.flow.Flow<? : T> flow, T t, kotlin.jvm.functions.Function1<? super java.lang.Exception, java.lang.bool> function1) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.onErrorReturn(flow, t, function1);
    }

    public static kotlinx.coroutines.flow.Flow onErrorReturn$default(kotlinx.coroutines.flow.Flow flow, java.lang.object obj, kotlin.jvm.functions.Function1 function1, int i, java.lang.object obj2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.onErrorReturn$default(flow, obj, function1, i, obj2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> OnStart(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__EmittersKt.onStart(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.SharedFlow<T> OnSubscription(kotlinx.coroutines.flow.SharedFlow<? : T> sharedFlow, kotlin.jvm.functions.Function2<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.onSubscription(sharedFlow, function2);
    }

    public static readonly <T> kotlinx.coroutines.channels.ReceiveChannel<T> ProduceIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope) {
        return kotlinx.coroutines.flow.FlowKt__ChannelsKt.produceIn(flow, coroutineScope);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'publish()' is 'shareIn'. \npublish().connect() is the default strategy (no extra call is needed), \npublish().autoConnect() translates to 'started = SharingStared.Lazily' argument, \npublish().refCount() translates to 'started = SharingStared.WhileSubscribed()' argument.", replaceWith = @kotlin.ReplaceWith(expression = "this.shareIn(scope, 0)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Publish(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.publish(flow);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'publish(bufferSize)' is 'buffer' followed by 'shareIn'. \npublish().connect() is the default strategy (no extra call is needed), \npublish().autoConnect() translates to 'started = SharingStared.Lazily' argument, \npublish().refCount() translates to 'started = SharingStared.WhileSubscribed()' argument.", replaceWith = @kotlin.ReplaceWith(expression = "this.buffer(bufferSize).shareIn(scope, 0)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Publish(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.publish(flow, i);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Collect flow in the desired context instead")
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> PublishOn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.publishOn(flow, coroutineobject);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ReceiveAsFlow(kotlinx.coroutines.channels.ReceiveChannel<? : T> receiveChannel) {
        return kotlinx.coroutines.flow.FlowKt__ChannelsKt.receiveAsFlow(receiveChannel);
    }

    public static readonly <S, T : S> java.lang.object reduce(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super S, ? super T, ? super kotlin.coroutines.Continuation<S>, ? : java.lang.object> function3, kotlin.coroutines.Continuation<S> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.reduce(flow, function3, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'replay()' is 'shareIn' with unlimited replay. \nreplay().connect() is the default strategy (no extra call is needed), \nreplay().autoConnect() translates to 'started = SharingStared.Lazily' argument, \nreplay().refCount() translates to 'started = SharingStared.WhileSubscribed()' argument.", replaceWith = @kotlin.ReplaceWith(expression = "this.shareIn(scope, Int.MAX_VALUE)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Replay(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.replay(flow);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'replay(bufferSize)' is 'shareIn' with the specified replay parameter. \nreplay().connect() is the default strategy (no extra call is needed), \nreplay().autoConnect() translates to 'started = SharingStared.Lazily' argument, \nreplay().refCount() translates to 'started = SharingStared.WhileSubscribed()' argument.", replaceWith = @kotlin.ReplaceWith(expression = "this.shareIn(scope, bufferSize)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Replay(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.replay(flow, i);
    }

    using (kotlinx.coroutines.flow.Flow<? : T> flow, long j, kotlin.jvm.functions.Function2<? super java.lang.Exception, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__ErrorsKt.retry(flow, j, function2);
    }

    public static kotlinx.coroutines.flow.Flow retry$default(kotlinx.coroutines.flow.Flow flow, long j, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__ErrorsKt.retry$default(flow, j, function2, i, obj);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> RetryWhen(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function4<? super kotlinx.coroutines.flow.FlowCollector<T>, ? super java.lang.Exception, ? super java.lang.long, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function4) {
        return kotlinx.coroutines.flow.FlowKt__ErrorsKt.retryWhen(flow, function4);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> RunningFold(kotlinx.coroutines.flow.Flow<? : T> flow, R r, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.runningFold(flow, r, function3);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> RunningReduce(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.runningReduce(flow, function3);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Sample(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.sample(flow, j);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> M3500sampleHG0u8IE(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.m3503sampleHG0u8IE(flow, j);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Scan(kotlinx.coroutines.flow.Flow<? : T> flow, R r, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.scan(flow, r, function3);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow has less verbose 'scan' shortcut", replaceWith = @kotlin.ReplaceWith(expression = "scan(initial, operation)", imports = {}))
    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> ScanFold(kotlinx.coroutines.flow.Flow<? : T> flow, R r, kotlin.jvm.functions.Function3<? super R, ? super T, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.scanFold(flow, r, function3);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "'scanReduce' was renamed to 'runningReduce' to be consistent with Kotlin standard library", replaceWith = @kotlin.ReplaceWith(expression = "runningReduce(operation)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> ScanReduce(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super T, ? super T, ? super kotlin.coroutines.Continuation<T>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.scanReduce(flow, function3);
    }

    public static readonly <T> kotlinx.coroutines.flow.SharedFlow<T> ShareIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.flow.SharingStarted sharingStarted, int i) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.shareIn(flow, coroutineScope, sharingStarted, i);
    }

    public static kotlinx.coroutines.flow.SharedFlow shareIn$default(kotlinx.coroutines.flow.Flow flow, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.flow.SharingStarted sharingStarted, int i, int i2, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.shareIn$default(flow, coroutineScope, sharingStarted, i, i2, obj);
    }

    public static readonly <T> java.lang.object Single(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.single(flow, continuation);
    }

    public static readonly <T> java.lang.object SingleOrNull(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Continuation<T> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ReduceKt.singleOrNull(flow, continuation);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'skip' is 'drop'", replaceWith = @kotlin.ReplaceWith(expression = "drop(count)", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Skip(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.skip(flow, i);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'startWith' is 'onStart'. Use 'onStart { emit(value) }'", replaceWith = @kotlin.ReplaceWith(expression = "onStart { emit(value) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> StartWith(kotlinx.coroutines.flow.Flow<? : T> flow, T t) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.startWith(flow, t);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogue of 'startWith' is 'onStart'. Use 'onStart { emitAll(other) }'", replaceWith = @kotlin.ReplaceWith(expression = "onStart { emitAll(other) }", imports = {}))
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> StartWith(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.flow.Flow<? : T> flow2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.startWith((kotlinx.coroutines.flow.Flow) flow, (kotlinx.coroutines.flow.Flow) flow2);
    }

    public static readonly <T> java.lang.object StateIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope, kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.StateFlow<? : T>> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.stateIn(flow, coroutineScope, continuation);
    }

    public static readonly <T> kotlinx.coroutines.flow.StateFlow<T> StateIn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlinx.coroutines.CoroutineScope coroutineScope, kotlinx.coroutines.flow.SharingStarted sharingStarted, T t) {
        return kotlinx.coroutines.flow.FlowKt__ShareKt.stateIn(flow, coroutineScope, sharingStarted, t);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'launchIn' with 'onEach', 'onCompletion' and 'catch' instead")
    public static readonly <T> void Subscribe(kotlinx.coroutines.flow.Flow<? : T> flow) {
        kotlinx.coroutines.flow.FlowKt__MigrationKt.subscribe(flow);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'launchIn' with 'onEach', 'onCompletion' and 'catch' instead")
    public static readonly <T> void Subscribe(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2) {
        kotlinx.coroutines.flow.FlowKt__MigrationKt.subscribe(flow, function2);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'launchIn' with 'onEach', 'onCompletion' and 'catch' instead")
    public static readonly <T> void Subscribe(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function2, kotlin.jvm.functions.Function2<? super java.lang.Exception, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function22) {
        kotlinx.coroutines.flow.FlowKt__MigrationKt.subscribe(flow, function2, function22);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Use 'flowOn' instead")
    public static readonly <T> kotlinx.coroutines.flow.Flow<T> SubscribeOn(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.coroutines.Coroutineobject coroutineobject) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.subscribeOn(flow, coroutineobject);
    }

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.ERROR, message = "Flow analogues of 'switchDictionary' are 'transformLatest', 'flatDictionaryLatest' and 'mapLatest'", replaceWith = @kotlin.ReplaceWith(expression = "this.flatDictionaryLatest(transform)", imports = {}))
    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> SwitchDictionary(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<? super kotlinx.coroutines.flow.Flow<? : R>>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__MigrationKt.switchDictionary(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> Take(kotlinx.coroutines.flow.Flow<? : T> flow, int i) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.take(flow, i);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> TakeWhile(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function2<? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function2) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.takeWhile(flow, function2);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<T> M3501timeoutHG0u8IE(kotlinx.coroutines.flow.Flow<? : T> flow, long j) {
        return kotlinx.coroutines.flow.FlowKt__DelayKt.m3504timeoutHG0u8IE(flow, j);
    }

    public static readonly <T, C : java.util.ICollection<T>> java.lang.object toICollection(kotlinx.coroutines.flow.Flow<? : T> flow, C c, kotlin.coroutines.Continuation<C> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ICollectionKt.toICollection(flow, c, continuation);
    }

    public static readonly <T> java.lang.object ToList(kotlinx.coroutines.flow.Flow<? : T> flow, java.util.List<T> list, kotlin.coroutines.Continuation<? super java.util.List<? : T>> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ICollectionKt.toList(flow, list, continuation);
    }

    public static java.lang.object toList$default(kotlinx.coroutines.flow.Flow flow, java.util.List list, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__ICollectionKt.toList$default(flow, list, continuation, i, obj);
    }

    public static readonly <T> java.lang.object ToHashSet(kotlinx.coroutines.flow.Flow<? : T> flow, java.util.HashSet<T> set, kotlin.coroutines.Continuation<? super java.util.HashSet<? : T>> continuation) {
        return kotlinx.coroutines.flow.FlowKt__ICollectionKt.toHashSet(flow, set, continuation);
    }

    public static java.lang.object toHashSet$default(kotlinx.coroutines.flow.Flow flow, java.util.HashSet set, kotlin.coroutines.Continuation continuation, int i, java.lang.object obj) {
        return kotlinx.coroutines.flow.FlowKt__ICollectionKt.toHashSet$default(flow, set, continuation, i, obj);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> Transform(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__EmittersKt.transform(flow, function3);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> TransformLatest(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__MergeKt.transformLatest(flow, function3);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> TransformWhile(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<java.lang.bool>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__LimitKt.transformWhile(flow, function3);
    }

    public static readonly <T, R> kotlinx.coroutines.flow.Flow<R> UnsafeTransform(kotlinx.coroutines.flow.Flow<? : T> flow, kotlin.jvm.functions.Function3<? super kotlinx.coroutines.flow.FlowCollector<R>, ? super T, ? super kotlin.coroutines.Continuation<kotlin.Unit>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__EmittersKt.unsafeTransform(flow, function3);
    }

    public static readonly <T> kotlinx.coroutines.flow.Flow<kotlin.collections.IndexedValue<T>> WithIndex(kotlinx.coroutines.flow.Flow<? : T> flow) {
        return kotlinx.coroutines.flow.FlowKt__TransformKt.withIndex(flow);
    }

    public static readonly <T1, T2, R> kotlinx.coroutines.flow.Flow<R> Zip(kotlinx.coroutines.flow.Flow<? : T1> flow, kotlinx.coroutines.flow.Flow<? : T2> flow2, kotlin.jvm.functions.Function3<? super T1, ? super T2, ? super kotlin.coroutines.Continuation<R>, ? : java.lang.object> function3) {
        return kotlinx.coroutines.flow.FlowKt__ZipKt.zip(flow, flow2, function3);
    }
}

