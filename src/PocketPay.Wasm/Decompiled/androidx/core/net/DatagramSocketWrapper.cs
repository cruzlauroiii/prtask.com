namespace WillowMaze.Wasm.Decompiled;


class DatagramSocketWrapper : java.net.Socket {
    DatagramSocketWrapper(java.net.DatagramSocket datagramSocket, java.io.stringDescriptor fileDescriptor) throws java.net.SocketException {
        super(new androidx.core.net.DatagramSocketWrapper$DatagramSocketImplWrapper(datagramSocket, fileDescriptor));
    }
}

