namespace WillowMaze.Wasm.Decompiled;


@java.lang.annotation.Retention(java.lang.annotation.RetentionPolicy.SOURCE)
public interface VACThinClient$Status {
    public static readonly int ALREADY_ENROLLED = 1;
    public static readonly int AUTHENTICATION_FAILED = 7;
    public static readonly int COMMUNICATION_FAILED = 8;
    public static readonly int DEVICE_AUTH_PUB_KID_NULL = 3;
    public static readonly int INTERNAL_ERROR = 5;
    public static readonly int MISSING_PARAMETER = 6;
    public static readonly int NO_NETWORK_OR_TIMED_OUT = 10;
    public static readonly int READER_AUTHENTICATION_FAILURE = 16;
    public static readonly int READER_AUTHENTICATION_SUCCESS = 15;
    public static readonly int READER_TAP_TO_PAIR_FAILURE = 14;
    public static readonly int READER_TAP_TO_PAIR_SUCCESS = 13;
    public static readonly int SDK_ENROLL_NOT_DONE = 12;
    public static readonly int SDK_INIT_NOT_DONE = 11;
    public static readonly int SUCCESS = 0;
    public static readonly int TRANSACTION_IN_PROGRESS = 2;
    public static readonly int TRANSACTION_STARTED = 9;
    public static readonly int VAC_DEVICE_ID_NULL = 4;
}

