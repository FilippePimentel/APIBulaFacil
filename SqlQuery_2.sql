﻿ALTER TABLE "dbo"."USUMOBILE_UMB" RENAME TO "USUMOBILE_USM"
;

ALTER TABLE "dbo"."USUMOBILE_USM" RENAME COLUMN "UMB_USUARIO_USU_FK" TO "USM_USUARIO_USU_FK"
;

ALTER TABLE "dbo"."USUMOBILE_USM" RENAME COLUMN "UMB_CPF" TO "USM_CPF"
;

ALTER TABLE "dbo"."USUMOBILE_USM" RENAME COLUMN "UMB_SEXO" TO "USM_SEXO"
;

ALTER TABLE "dbo"."USUMOBILE_USM" RENAME COLUMN "UMB_DTNASCIMENTO" TO "USM_DTNASCIMENTO"
;

ALTER INDEX IF EXISTS dbo."IX_UMB_USUARIO_USU_FK" RENAME TO "IX_USM_USUARIO_USU_FK"
;

CREATE SCHEMA IF NOT EXISTS "dbo"
;

CREATE TABLE "dbo"."BULAFACIL_BFA"("BFA_IDBULAFACIL" serial4 NOT NULL,"BFA_BULALINK" varchar(500) NOT NULL,"BFA_SUBSTANCIA" varchar(1000) NOT NULL,"BFA_VALIDO" varchar(1) NOT NULL,"BFA_RFMED" int4 NOT NULL,CONSTRAINT "PK_dbo.BULAFACIL_BFA" PRIMARY KEY ("BFA_IDBULAFACIL"))
;

CREATE TABLE "dbo"."CONTRAINDICACAO_CON"("CON_IDBULAFACIL" serial4 NOT NULL,"CON_CONTRAINDICACAO" varchar(150) NOT NULL,CONSTRAINT "PK_dbo.CONTRAINDICACAO_CON" PRIMARY KEY ("CON_IDBULAFACIL"))
;

CREATE TABLE "dbo"."INDICACAO_IND"("IND_IDINDICACAO" serial4 NOT NULL,"IND_DSINDICACAO" varchar(150) NOT NULL,CONSTRAINT "PK_dbo.INDICACAO_IND" PRIMARY KEY ("IND_IDINDICACAO"))
;

CREATE TABLE "dbo"."POSOLOGIA_POS"("POS_IDPOSOLOGIA" serial4 NOT NULL,"POS_UNIMEDIDA" varchar(100) NOT NULL,"POS_QUANTIDADE" numeric(18,2) NOT NULL,"POS_INTERVALO" varchar(150) NOT NULL,"POS_MODODEUSO" varchar(150) NOT NULL,CONSTRAINT "PK_dbo.POSOLOGIA_POS" PRIMARY KEY ("POS_IDPOSOLOGIA"))
;

CREATE TABLE "dbo"."BULACONTRAINDICACAO_BCI"("BCI_RFBFA" int4 NOT NULL,"BCI_RFCON" int4 NOT NULL,CONSTRAINT "PK_dbo.BULACONTRAINDICACAO_BCI" PRIMARY KEY ("BCI_RFBFA","BCI_RFCON"))
;

CREATE TABLE "dbo"."BULAINDICACAO_BIN"("BIN_RFBFA" int4 NOT NULL,"BIN_RFIND" int4 NOT NULL,CONSTRAINT "PK_dbo.BULAINDICACAO_BIN" PRIMARY KEY ("BIN_RFBFA","BIN_RFIND"))
;

CREATE TABLE "dbo"."BULAPOSOLOGIA_BPO"("BPO_RFBFA" int4 NOT NULL,"BPO_RFPOS" int4 NOT NULL,CONSTRAINT "PK_dbo.BULAPOSOLOGIA_BPO" PRIMARY KEY ("BPO_RFBFA","BPO_RFPOS"))
;

CREATE INDEX "BULAFACIL_BFA_IX_BFA_RFMED" ON "dbo"."BULAFACIL_BFA" ("BFA_RFMED")
;

CREATE INDEX "BULACONTRAINDICACAO_BCI_IX_BCI_RFBFA" ON "dbo"."BULACONTRAINDICACAO_BCI" ("BCI_RFBFA")
;

CREATE INDEX "BULACONTRAINDICACAO_BCI_IX_BCI_RFCON" ON "dbo"."BULACONTRAINDICACAO_BCI" ("BCI_RFCON")
;

CREATE INDEX "BULAINDICACAO_BIN_IX_BIN_RFBFA" ON "dbo"."BULAINDICACAO_BIN" ("BIN_RFBFA")
;

CREATE INDEX "BULAINDICACAO_BIN_IX_BIN_RFIND" ON "dbo"."BULAINDICACAO_BIN" ("BIN_RFIND")
;

CREATE INDEX "BULAPOSOLOGIA_BPO_IX_BPO_RFBFA" ON "dbo"."BULAPOSOLOGIA_BPO" ("BPO_RFBFA")
;

CREATE INDEX "BULAPOSOLOGIA_BPO_IX_BPO_RFPOS" ON "dbo"."BULAPOSOLOGIA_BPO" ("BPO_RFPOS")
;

ALTER TABLE "dbo"."BULAFACIL_BFA" ADD CONSTRAINT "FK_dbo.BULAFACIL_BFA_dbo.MEDICAMENTO_MED_BFA_RFMED" FOREIGN KEY ("BFA_RFMED") REFERENCES "dbo"."MEDICAMENTO_MED" ("MED_IDMEDICAMENTO")
;

ALTER TABLE "dbo"."BULACONTRAINDICACAO_BCI" ADD CONSTRAINT "FK_dbo.BULACONTRAINDICACAO_BCI_dbo.BULAFACIL_BFA_BCI_RFBFA" FOREIGN KEY ("BCI_RFBFA") REFERENCES "dbo"."BULAFACIL_BFA" ("BFA_IDBULAFACIL")
;

ALTER TABLE "dbo"."BULACONTRAINDICACAO_BCI" ADD CONSTRAINT "FK_dbo.BULACONTRAINDICACAO_BCI_dbo.CONTRAINDICACAO_CON_BCI_RFCON" FOREIGN KEY ("BCI_RFCON") REFERENCES "dbo"."CONTRAINDICACAO_CON" ("CON_IDBULAFACIL")
;

ALTER TABLE "dbo"."BULAINDICACAO_BIN" ADD CONSTRAINT "FK_dbo.BULAINDICACAO_BIN_dbo.BULAFACIL_BFA_BIN_RFBFA" FOREIGN KEY ("BIN_RFBFA") REFERENCES "dbo"."BULAFACIL_BFA" ("BFA_IDBULAFACIL")
;

ALTER TABLE "dbo"."BULAINDICACAO_BIN" ADD CONSTRAINT "FK_dbo.BULAINDICACAO_BIN_dbo.INDICACAO_IND_BIN_RFIND" FOREIGN KEY ("BIN_RFIND") REFERENCES "dbo"."INDICACAO_IND" ("IND_IDINDICACAO")
;

ALTER TABLE "dbo"."BULAPOSOLOGIA_BPO" ADD CONSTRAINT "FK_dbo.BULAPOSOLOGIA_BPO_dbo.BULAFACIL_BFA_BPO_RFBFA" FOREIGN KEY ("BPO_RFBFA") REFERENCES "dbo"."BULAFACIL_BFA" ("BFA_IDBULAFACIL")
;

ALTER TABLE "dbo"."BULAPOSOLOGIA_BPO" ADD CONSTRAINT "FK_dbo.BULAPOSOLOGIA_BPO_dbo.POSOLOGIA_POS_BPO_RFPOS" FOREIGN KEY ("BPO_RFPOS") REFERENCES "dbo"."POSOLOGIA_POS" ("POS_IDPOSOLOGIA")
;

INSERT INTO "dbo"."__MigrationHistory"("MigrationId","ContextKey","Model","ProductVersion") VALUES (E'201912080147293_AutomaticMigration',E'APIBulaFacil.Infra.Data.Migrations.Configuration',decode('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', 'base64'),E'6.2.0-61023')