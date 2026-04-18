variable "cloudflare_api_key" {
  type      = string
  sensitive = true
}

variable "cloudflare_email" {
  type = string
}

variable "cloudflare_account_id" {
  type = string
}

variable "cloudflare_zone_id" {
  type = string
}

variable "maya_public_key" {
  type = string
}

variable "maya_secret_key" {
  type      = string
  sensitive = true
}

variable "github_client_id" {
  type = string
}

variable "github_client_secret" {
  type      = string
  sensitive = true
}

variable "google_client_id" {
  type = string
}

variable "google_client_secret" {
  type      = string
  sensitive = true
}

variable "azure_client_id" {
  type = string
}

variable "azure_client_secret" {
  type      = string
  sensitive = true
}

variable "okta_client_id" {
  type = string
}

variable "okta_client_secret" {
  type      = string
  sensitive = true
}

variable "okta_domain" {
  type = string
}

variable "session_secret" {
  type      = string
  sensitive = true
}
