CREATE TABLE IF NOT EXISTS documents (
    id text PRIMARY KEY,
    filename text NOT NULL,
    department text,
    total_chunks integer DEFAULT 0,
    created_at timestamp with time zone DEFAULT now()
);

-- Menambahkan kolom object storage
ALTER TABLE documents ADD COLUMN IF NOT EXISTS storage_bucket text;
ALTER TABLE documents ADD COLUMN IF NOT EXISTS storage_object_key text;
ALTER TABLE documents ADD COLUMN IF NOT EXISTS content_type text;