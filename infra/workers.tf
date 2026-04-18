resource "cloudflare_workers_script" "prtask_api" {
  account_id = var.cloudflare_account_id
  name       = "prtask-api"
  content    = file("${path.module}/worker.js")
  module     = true

  d1_database_binding {
    name        = "DB"
    database_id = cloudflare_d1_database.prtask.id
  }

  kv_namespace_binding {
    name         = "SESSIONS"
    namespace_id = cloudflare_workers_kv_namespace.prtask_sessions.id
  }

  kv_namespace_binding {
    name         = "CACHE"
    namespace_id = cloudflare_workers_kv_namespace.prtask_cache.id
  }

  r2_bucket_binding {
    name        = "DIFFS"
    bucket_name = cloudflare_r2_bucket.prtask_diffs.name
  }

  r2_bucket_binding {
    name        = "AVATARS"
    bucket_name = cloudflare_r2_bucket.prtask_avatars.name
  }

  plain_text_binding {
    name = "DURABLE_OBJECT_CLASS"
    text = "TaskDurableObject"
  }

  plain_text_binding {
    name = "GOOGLE_CLIENT_ID"
    text = var.google_client_id
  }

  secret_text_binding {
    name = "GOOGLE_CLIENT_SECRET"
    text = var.google_client_secret
  }

  plain_text_binding {
    name = "GITHUB_CLIENT_ID"
    text = var.github_client_id
  }

  secret_text_binding {
    name = "GITHUB_CLIENT_SECRET"
    text = var.github_client_secret
  }

  plain_text_binding {
    name = "AZURE_CLIENT_ID"
    text = var.azure_client_id
  }

  secret_text_binding {
    name = "AZURE_CLIENT_SECRET"
    text = var.azure_client_secret
  }

  plain_text_binding {
    name = "OKTA_CLIENT_ID"
    text = var.okta_client_id
  }

  secret_text_binding {
    name = "OKTA_CLIENT_SECRET"
    text = var.okta_client_secret
  }

  plain_text_binding {
    name = "OKTA_DOMAIN"
    text = var.okta_domain
  }
}

resource "cloudflare_workers_route" "prtask_api" {
  zone_id     = var.cloudflare_zone_id
  pattern     = "prtask.com/api/*"
  script_name = cloudflare_workers_script.prtask_api.name
}
