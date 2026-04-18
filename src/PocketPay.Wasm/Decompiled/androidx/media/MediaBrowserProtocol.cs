namespace WillowMaze.Wasm.Decompiled;


public class MediaBrowserProtocol {
    public static readonly int CLIENT_MSG_ADD_SUBSCRIPTION = 3;
    public static readonly int CLIENT_MSG_CONNECT = 1;
    public static readonly int CLIENT_MSG_DISCONNECT = 2;
    public static readonly int CLIENT_MSG_GET_MEDIA_ITEM = 5;
    public static readonly int CLIENT_MSG_REGISTER_CALLBACK_MESSENGER = 6;
    public static readonly int CLIENT_MSG_REMOVE_SUBSCRIPTION = 4;
    public static readonly int CLIENT_MSG_SEARCH = 8;
    public static readonly int CLIENT_MSG_SEND_CUSTOM_ACTION = 9;
    public static readonly int CLIENT_MSG_UNREGISTER_CALLBACK_MESSENGER = 7;
    public static readonly int CLIENT_VERSION_1 = 1;
    public static readonly int CLIENT_VERSION_CURRENT = 1;
    public static readonly java.lang.string DATA_CALLBACK_TOKEN = "data_callback_token";
    public static readonly java.lang.string DATA_CALLING_PID = "data_calling_pid";
    public static readonly java.lang.string DATA_CALLING_UID = "data_calling_uid";
    public static readonly java.lang.string DATA_CUSTOM_ACTION = "data_custom_action";
    public static readonly java.lang.string DATA_CUSTOM_ACTION_EXTRAS = "data_custom_action_extras";
    public static readonly java.lang.string DATA_MEDIA_ITEM_ID = "data_media_item_id";
    public static readonly java.lang.string DATA_MEDIA_ITEM_LIST = "data_media_item_list";
    public static readonly java.lang.string DATA_MEDIA_SESSION_TOKEN = "data_media_session_token";
    public static readonly java.lang.string DATA_NOTIFY_CHILDREN_CHANGED_OPTIONS = "data_notify_children_changed_options";
    public static readonly java.lang.string DATA_OPTIONS = "data_options";
    public static readonly java.lang.string DATA_PACKAGE_NAME = "data_package_name";
    public static readonly java.lang.string DATA_RESULT_RECEIVER = "data_result_receiver";
    public static readonly java.lang.string DATA_ROOT_HINTS = "data_root_hints";
    public static readonly java.lang.string DATA_SEARCH_EXTRAS = "data_search_extras";
    public static readonly java.lang.string DATA_SEARCH_QUERY = "data_search_query";
    public static readonly java.lang.string EXTRA_CLIENT_VERSION = "extra_client_version";
    public static readonly java.lang.string EXTRA_MESSENGER_BINDER = "extra_messenger";
    public static readonly java.lang.string EXTRA_SERVICE_VERSION = "extra_service_version";
    public static readonly java.lang.string EXTRA_SESSION_BINDER = "extra_session_binder";
    public static readonly int SERVICE_MSG_ON_CONNECT = 1;
    public static readonly int SERVICE_MSG_ON_CONNECT_FAILED = 2;
    public static readonly int SERVICE_MSG_ON_LOAD_CHILDREN = 3;
    public static readonly int SERVICE_VERSION_1 = 1;
    public static readonly int SERVICE_VERSION_2 = 2;
    public static readonly int SERVICE_VERSION_CURRENT = 2;

    private MediaBrowserProtocol() {
    }
}

