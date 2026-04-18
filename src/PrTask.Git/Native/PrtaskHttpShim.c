/*
 * PrtaskHttpShim.c — HTTP transport abstraction for WASM
 *
 * Custom git transport that routes HTTP requests through C# HttpClient
 * which in turn goes through the Cloudflare Worker CORS proxy at /Git/*
 *
 * The actual HTTP calls are made via C# P/Invoke callbacks.
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* Callback for HTTP requests — implemented in C# */
typedef int (*HttpRequestCallback)(const char *Method, const char *Url,
                                    const char *Body, int BodyLen,
                                    char *ResponseBuf, int ResponseBufSize);

static HttpRequestCallback GHttpRequest = NULL;

void PrtaskHttpInit(HttpRequestCallback RequestCb) {
    GHttpRequest = RequestCb;
}

int PrtaskHttpGet(const char *Url, char *ResponseBuf, int BufSize) {
    if (GHttpRequest) return GHttpRequest("GET", Url, NULL, 0, ResponseBuf, BufSize);
    return -1;
}

int PrtaskHttpPost(const char *Url, const char *Body, int BodyLen,
                   char *ResponseBuf, int BufSize) {
    if (GHttpRequest) return GHttpRequest("POST", Url, Body, BodyLen, ResponseBuf, BufSize);
    return -1;
}
