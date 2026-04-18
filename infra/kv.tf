resource "cloudflare_workers_kv_namespace" "prtask_sessions" {
  account_id = var.cloudflare_account_id
  title      = "prtask-sessions"
}

resource "cloudflare_workers_kv_namespace" "prtask_cache" {
  account_id = var.cloudflare_account_id
  title      = "prtask-cache"
}

output "kv_sessions_id" {
  value = cloudflare_workers_kv_namespace.prtask_sessions.id
}

output "kv_cache_id" {
  value = cloudflare_workers_kv_namespace.prtask_cache.id
}
