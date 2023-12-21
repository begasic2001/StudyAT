IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Activities] (
    [Id] uniqueidentifier NOT NULL,
    [Title] nvarchar(max) NOT NULL,
    [Date] datetime2 NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [Category] nvarchar(max) NOT NULL,
    [City] nvarchar(max) NOT NULL,
    [Venue] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Activities] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [DisplayName] nvarchar(max) NOT NULL,
    [Bio] nvarchar(max) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [Category], [City], [Date], [Description], [Title], [Venue])
VALUES ('0c907e19-7354-4e3f-86b7-4299e72b2325', N'drinks', N'London', '2023-08-02T13:50:33.4602248Z', N'Activity 2 months ago', N'Past Activity 1', N'Pub'),
('44ebcf40-521c-487d-890a-823b92107d6b', N'culture', N'London', '2023-11-02T13:50:33.4602261Z', N'Activity 1 month in future', N'Future Activity 1', N'Natural History Museum'),
('4d6ca198-33d0-417c-9ba3-966300141259', N'music', N'London', '2024-04-02T13:50:33.4602284Z', N'Activity 6 months in future', N'Future Activity 6', N'Roundhouse Camden'),
('76ceb8fe-44bc-4f67-9dfd-3190a9501691', N'drinks', N'London', '2024-01-02T13:50:33.4602267Z', N'Activity 3 months in future', N'Future Activity 3', N'Another pub'),
('cd92123a-1045-4d55-975a-499ed40b06b0', N'film', N'London', '2024-06-02T13:50:33.4602290Z', N'Activity 8 months in future', N'Future Activity 8', N'Cinema'),
('d4cc3c79-a8a6-468c-a116-d497b58b24af', N'drinks', N'London', '2024-03-02T13:50:33.4602272Z', N'Activity 5 months in future', N'Future Activity 5', N'Just another pub'),
('e88946c8-2b50-49d0-8d6f-e6ae3d372ddb', N'music', N'London', '2023-12-02T13:50:33.4602265Z', N'Activity 2 months in future', N'Future Activity 2', N'O2 Arena'),
('e910222b-06c7-4008-b1b3-5ba39d3865c9', N'culture', N'Paris', '2023-09-02T13:50:33.4602258Z', N'Activity 1 month ago', N'Past Activity 2', N'Louvre'),
('f1ff2bcb-df7d-4413-b9ea-abcef96930ce', N'drinks', N'London', '2024-02-02T13:50:33.4602270Z', N'Activity 4 months in future', N'Future Activity 4', N'Yet another pub'),
('f9d1f61c-193e-4cc4-99a9-2260c7008e4d', N'travel', N'London', '2024-05-02T13:50:33.4602287Z', N'Activity 2 months ago', N'Future Activity 7', N'Somewhere on the Thames');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] OFF;
GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231002135033_Add Identity', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Activities]
WHERE [Id] = '0c907e19-7354-4e3f-86b7-4299e72b2325';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '44ebcf40-521c-487d-890a-823b92107d6b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '4d6ca198-33d0-417c-9ba3-966300141259';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '76ceb8fe-44bc-4f67-9dfd-3190a9501691';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'cd92123a-1045-4d55-975a-499ed40b06b0';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'd4cc3c79-a8a6-468c-a116-d497b58b24af';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'e88946c8-2b50-49d0-8d6f-e6ae3d372ddb';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'e910222b-06c7-4008-b1b3-5ba39d3865c9';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'f1ff2bcb-df7d-4413-b9ea-abcef96930ce';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'f9d1f61c-193e-4cc4-99a9-2260c7008e4d';
SELECT @@ROWCOUNT;

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[AspNetUsers]') AND [c].[name] = N'Bio');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [AspNetUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [AspNetUsers] ALTER COLUMN [Bio] nvarchar(max) NULL;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [Category], [City], [Date], [Description], [Title], [Venue])
VALUES ('1e30fc5f-4458-49b5-8723-ceba94d1a694', N'drinks', N'London', '2024-01-02T14:49:13.2846373Z', N'Activity 3 months in future', N'Future Activity 3', N'Another pub'),
('22442771-c585-4983-a599-8632949886aa', N'drinks', N'London', '2024-02-02T14:49:13.2846378Z', N'Activity 4 months in future', N'Future Activity 4', N'Yet another pub'),
('456c20de-6fd8-4919-8629-040c4c0d48d9', N'culture', N'Paris', '2023-09-02T14:49:13.2846334Z', N'Activity 1 month ago', N'Past Activity 2', N'Louvre'),
('5fd4eef0-1e45-44a2-a73b-006118fb1e71', N'music', N'London', '2024-04-02T14:49:13.2846384Z', N'Activity 6 months in future', N'Future Activity 6', N'Roundhouse Camden'),
('79e6c02d-d932-4e1f-9057-cef1503c3b31', N'drinks', N'London', '2023-08-02T14:49:13.2846318Z', N'Activity 2 months ago', N'Past Activity 1', N'Pub'),
('80273ed9-888f-42b6-9c44-95bcba4e9b1c', N'music', N'London', '2023-12-02T14:49:13.2846367Z', N'Activity 2 months in future', N'Future Activity 2', N'O2 Arena'),
('b08260e5-bde1-4c6a-b02d-4bcd9b2a1805', N'film', N'London', '2024-06-02T14:49:13.2846390Z', N'Activity 8 months in future', N'Future Activity 8', N'Cinema'),
('ba3b93cd-04b0-4a0d-8fda-ca864a31b034', N'travel', N'London', '2024-05-02T14:49:13.2846387Z', N'Activity 2 months ago', N'Future Activity 7', N'Somewhere on the Thames'),
('d191a982-8cc5-4c4f-9d14-ff80ef2579e1', N'drinks', N'London', '2024-03-02T14:49:13.2846381Z', N'Activity 5 months in future', N'Future Activity 5', N'Just another pub'),
('f0ed79e9-3260-4e42-92f4-0e00b8bb35c3', N'culture', N'London', '2023-11-02T14:49:13.2846360Z', N'Activity 1 month in future', N'Future Activity 1', N'Natural History Museum');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'Bio', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] ON;
INSERT INTO [AspNetUsers] ([Id], [AccessFailedCount], [Bio], [ConcurrencyStamp], [DisplayName], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName])
VALUES (N'69db53db-fd28-427d-bb0a-b974afca3941', 0, NULL, N'cf21f31b-e50d-488e-948d-dfcc0cf4953c', N'Mi ong', N'miong@gmail.com', CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, N'123456', NULL, CAST(0 AS bit), N'22864308-ad47-4808-a937-52744f6eebbc', CAST(0 AS bit), N'Miong'),
(N'78038b8f-5e6d-40db-b3bd-431e91c4c04f', 0, NULL, N'cbe22d9c-838d-41ef-bf7f-51f18962e1be', N'Jenifer', N'jenifer@gmail.com', CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, N'123456', NULL, CAST(0 AS bit), N'254f21c8-1763-4133-a940-5f4061cc4d58', CAST(0 AS bit), N'jenifer'),
(N'ad14796d-b212-4aec-ac11-86f77e99822b', 0, NULL, N'7de7c640-82a1-482d-8c3f-55227318111f', N'Mi mi', N'mimi@gmail.com', CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, N'123456', NULL, CAST(0 AS bit), N'83a877ca-4057-4c08-b946-1e1e15c376f3', CAST(0 AS bit), N'Mimi'),
(N'f773d3f1-8593-429c-bc3d-662f49d13943', 0, NULL, N'd835ff25-f17a-45cf-9d30-f9bda7a76059', N'Mi panda', N'mipanda@gmail.com', CAST(0 AS bit), CAST(0 AS bit), NULL, NULL, NULL, N'123456', NULL, CAST(0 AS bit), N'dd19256c-d2ae-4ed6-b9ea-9f8bcac97334', CAST(0 AS bit), N'Mipanda');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AccessFailedCount', N'Bio', N'ConcurrencyStamp', N'DisplayName', N'Email', N'EmailConfirmed', N'LockoutEnabled', N'LockoutEnd', N'NormalizedEmail', N'NormalizedUserName', N'PasswordHash', N'PhoneNumber', N'PhoneNumberConfirmed', N'SecurityStamp', N'TwoFactorEnabled', N'UserName') AND [object_id] = OBJECT_ID(N'[AspNetUsers]'))
    SET IDENTITY_INSERT [AspNetUsers] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231002144913_Add Seed And Change Type AppUser', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Activities]
WHERE [Id] = '1e30fc5f-4458-49b5-8723-ceba94d1a694';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '22442771-c585-4983-a599-8632949886aa';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '456c20de-6fd8-4919-8629-040c4c0d48d9';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '5fd4eef0-1e45-44a2-a73b-006118fb1e71';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '79e6c02d-d932-4e1f-9057-cef1503c3b31';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '80273ed9-888f-42b6-9c44-95bcba4e9b1c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'b08260e5-bde1-4c6a-b02d-4bcd9b2a1805';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'ba3b93cd-04b0-4a0d-8fda-ca864a31b034';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'd191a982-8cc5-4c4f-9d14-ff80ef2579e1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'f0ed79e9-3260-4e42-92f4-0e00b8bb35c3';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'69db53db-fd28-427d-bb0a-b974afca3941';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'78038b8f-5e6d-40db-b3bd-431e91c4c04f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'ad14796d-b212-4aec-ac11-86f77e99822b';
SELECT @@ROWCOUNT;

GO

DELETE FROM [AspNetUsers]
WHERE [Id] = N'f773d3f1-8593-429c-bc3d-662f49d13943';
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [Category], [City], [Date], [Description], [Title], [Venue])
VALUES ('165f96b5-8b76-4aea-aa67-702a5d709663', N'culture', N'Paris', '2023-09-03T17:00:21.5353681Z', N'Activity 1 month ago', N'Past Activity 2', N'Louvre'),
('1d9448fb-6867-485f-bbc7-35037ba4b26d', N'drinks', N'London', '2023-08-03T17:00:21.5353671Z', N'Activity 2 months ago', N'Past Activity 1', N'Pub'),
('2cde01f5-806d-4023-934b-2fe449860bc2', N'film', N'London', '2024-06-03T17:00:21.5353723Z', N'Activity 8 months in future', N'Future Activity 8', N'Cinema'),
('3f98e72f-3eb9-47c5-83f6-bc4ea4e666c1', N'drinks', N'London', '2024-03-03T17:00:21.5353696Z', N'Activity 5 months in future', N'Future Activity 5', N'Just another pub'),
('879494bc-e6fd-498b-a14e-91a9b539a1e9', N'music', N'London', '2023-12-03T17:00:21.5353687Z', N'Activity 2 months in future', N'Future Activity 2', N'O2 Arena'),
('ae72ba70-8730-4fc7-a992-75aca2e3e3b5', N'culture', N'London', '2023-11-03T17:00:21.5353685Z', N'Activity 1 month in future', N'Future Activity 1', N'Natural History Museum'),
('bf705cd6-c763-41db-81f5-bb7aa618d1d9', N'drinks', N'London', '2024-01-03T17:00:21.5353691Z', N'Activity 3 months in future', N'Future Activity 3', N'Another pub'),
('c0927bbb-578e-4cff-a67d-1e6c6969f98e', N'travel', N'London', '2024-05-03T17:00:21.5353721Z', N'Activity 2 months ago', N'Future Activity 7', N'Somewhere on the Thames'),
('c8a70839-170f-4a02-876a-960e496f81af', N'music', N'London', '2024-04-03T17:00:21.5353716Z', N'Activity 6 months in future', N'Future Activity 6', N'Roundhouse Camden'),
('e45e00a3-bfea-4ba5-825c-d3fa8a7aefa1', N'drinks', N'London', '2024-02-03T17:00:21.5353693Z', N'Activity 4 months in future', N'Future Activity 4', N'Yet another pub');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231003170021_Change seed data', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Activities]
WHERE [Id] = '165f96b5-8b76-4aea-aa67-702a5d709663';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '1d9448fb-6867-485f-bbc7-35037ba4b26d';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '2cde01f5-806d-4023-934b-2fe449860bc2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '3f98e72f-3eb9-47c5-83f6-bc4ea4e666c1';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '879494bc-e6fd-498b-a14e-91a9b539a1e9';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'ae72ba70-8730-4fc7-a992-75aca2e3e3b5';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'bf705cd6-c763-41db-81f5-bb7aa618d1d9';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'c0927bbb-578e-4cff-a67d-1e6c6969f98e';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'c8a70839-170f-4a02-876a-960e496f81af';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'e45e00a3-bfea-4ba5-825c-d3fa8a7aefa1';
SELECT @@ROWCOUNT;

GO

CREATE TABLE [ActivityAttendees] (
    [AppUserId] nvarchar(450) NOT NULL,
    [ActivityId] uniqueidentifier NOT NULL,
    [IsHost] bit NOT NULL,
    CONSTRAINT [PK_ActivityAttendees] PRIMARY KEY ([ActivityId], [AppUserId]),
    CONSTRAINT [FK_ActivityAttendees_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ActivityAttendees_AspNetUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [Category], [City], [Date], [Description], [Title], [Venue])
VALUES ('13d8e975-72fe-4b01-8bad-4d1bda0f0dba', N'travel', N'London', '2024-05-08T04:46:23.1058253Z', N'Activity 2 months ago', N'Future Activity 7', N'Somewhere on the Thames'),
('1618ce0b-18d1-4a00-9de6-a091f933a21f', N'drinks', N'London', '2023-08-08T04:46:23.1058215Z', N'Activity 2 months ago', N'Past Activity 1', N'Pub'),
('45717148-3bd6-4478-b73f-5f582df9afe2', N'music', N'London', '2024-04-08T04:46:23.1058247Z', N'Activity 6 months in future', N'Future Activity 6', N'Roundhouse Camden'),
('57e1d75b-fb07-442a-b177-b5dfc0929216', N'film', N'London', '2024-06-08T04:46:23.1058256Z', N'Activity 8 months in future', N'Future Activity 8', N'Cinema'),
('5fc376c7-7d42-452d-a410-cd089c9d40f8', N'drinks', N'London', '2024-03-08T04:46:23.1058245Z', N'Activity 5 months in future', N'Future Activity 5', N'Just another pub'),
('9a1fe0b7-c074-4432-aa16-e97d2ddda881', N'culture', N'Paris', '2023-09-08T04:46:23.1058229Z', N'Activity 1 month ago', N'Past Activity 2', N'Louvre'),
('ab750b4a-9fa4-4fb0-81f6-edb4b322d212', N'culture', N'London', '2023-11-08T04:46:23.1058232Z', N'Activity 1 month in future', N'Future Activity 1', N'Natural History Museum'),
('b8ad1e24-7eb9-4e35-8544-0970994f5502', N'music', N'London', '2023-12-08T04:46:23.1058235Z', N'Activity 2 months in future', N'Future Activity 2', N'O2 Arena'),
('eea9ac3d-f79b-4daa-a2ed-ceb62276b722', N'drinks', N'London', '2024-02-08T04:46:23.1058242Z', N'Activity 4 months in future', N'Future Activity 4', N'Yet another pub'),
('fe3194e4-4b75-4660-a6ff-c9d101c56a5f', N'drinks', N'London', '2024-01-08T04:46:23.1058238Z', N'Activity 3 months in future', N'Future Activity 3', N'Another pub');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] OFF;
GO

CREATE INDEX [IX_ActivityAttendees_AppUserId] ON [ActivityAttendees] ([AppUserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231008044623_Add new relationship ActivityAttendees', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Activities]
WHERE [Id] = '13d8e975-72fe-4b01-8bad-4d1bda0f0dba';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '1618ce0b-18d1-4a00-9de6-a091f933a21f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '45717148-3bd6-4478-b73f-5f582df9afe2';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '57e1d75b-fb07-442a-b177-b5dfc0929216';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '5fc376c7-7d42-452d-a410-cd089c9d40f8';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '9a1fe0b7-c074-4432-aa16-e97d2ddda881';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'ab750b4a-9fa4-4fb0-81f6-edb4b322d212';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'b8ad1e24-7eb9-4e35-8544-0970994f5502';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'eea9ac3d-f79b-4daa-a2ed-ceb62276b722';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'fe3194e4-4b75-4660-a6ff-c9d101c56a5f';
SELECT @@ROWCOUNT;

GO

ALTER TABLE [Activities] ADD [IsCancelled] bit NOT NULL DEFAULT CAST(0 AS bit);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'IsCancelled', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] ON;
INSERT INTO [Activities] ([Id], [Category], [City], [Date], [Description], [IsCancelled], [Title], [Venue])
VALUES ('02793109-ddcd-47f3-88e7-f8e9a03e29bd', N'drinks', N'London', '2024-01-08T11:28:23.3004353Z', N'Activity 3 months in future', CAST(0 AS bit), N'Future Activity 3', N'Another pub'),
('113ef67c-da07-4356-9008-95d72040c560', N'culture', N'Paris', '2023-09-08T11:28:23.3004342Z', N'Activity 1 month ago', CAST(0 AS bit), N'Past Activity 2', N'Louvre'),
('21a7bda3-da91-4c33-aa47-4892e2b26b6c', N'culture', N'London', '2023-11-08T11:28:23.3004346Z', N'Activity 1 month in future', CAST(0 AS bit), N'Future Activity 1', N'Natural History Museum'),
('5f4ea299-80ec-486d-b6ad-e5d9bc396158', N'drinks', N'London', '2024-02-08T11:28:23.3004357Z', N'Activity 4 months in future', CAST(0 AS bit), N'Future Activity 4', N'Yet another pub'),
('61fc29e1-4608-4df5-88c9-8e5770ad2ddc', N'travel', N'London', '2024-05-08T11:28:23.3004386Z', N'Activity 2 months ago', CAST(0 AS bit), N'Future Activity 7', N'Somewhere on the Thames'),
('63b63cfd-d708-45e0-988e-5fe897fff718', N'music', N'London', '2024-04-08T11:28:23.3004383Z', N'Activity 6 months in future', CAST(0 AS bit), N'Future Activity 6', N'Roundhouse Camden'),
('825bed9f-a07d-49ff-9e87-2f365cf86655', N'drinks', N'London', '2024-03-08T11:28:23.3004379Z', N'Activity 5 months in future', CAST(0 AS bit), N'Future Activity 5', N'Just another pub'),
('8a446504-4771-42ac-97e0-7dc8e3b912c5', N'music', N'London', '2023-12-08T11:28:23.3004350Z', N'Activity 2 months in future', CAST(0 AS bit), N'Future Activity 2', N'O2 Arena'),
('96585622-7480-40ca-913a-66d8fd9eaf4f', N'film', N'London', '2024-06-08T11:28:23.3004390Z', N'Activity 8 months in future', CAST(0 AS bit), N'Future Activity 8', N'Cinema'),
('defd3df2-597e-4b61-a31e-9a1f2eeea533', N'drinks', N'London', '2023-08-08T11:28:23.3004329Z', N'Activity 2 months ago', CAST(0 AS bit), N'Past Activity 1', N'Pub');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Category', N'City', N'Date', N'Description', N'IsCancelled', N'Title', N'Venue') AND [object_id] = OBJECT_ID(N'[Activities]'))
    SET IDENTITY_INSERT [Activities] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231008112823_Add column IsCancelled', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

DELETE FROM [Activities]
WHERE [Id] = '02793109-ddcd-47f3-88e7-f8e9a03e29bd';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '113ef67c-da07-4356-9008-95d72040c560';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '21a7bda3-da91-4c33-aa47-4892e2b26b6c';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '5f4ea299-80ec-486d-b6ad-e5d9bc396158';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '61fc29e1-4608-4df5-88c9-8e5770ad2ddc';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '63b63cfd-d708-45e0-988e-5fe897fff718';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '825bed9f-a07d-49ff-9e87-2f365cf86655';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '8a446504-4771-42ac-97e0-7dc8e3b912c5';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = '96585622-7480-40ca-913a-66d8fd9eaf4f';
SELECT @@ROWCOUNT;

GO

DELETE FROM [Activities]
WHERE [Id] = 'defd3df2-597e-4b61-a31e-9a1f2eeea533';
SELECT @@ROWCOUNT;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231009095515_Refactor Seed Data', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Photos] (
    [Id] nvarchar(450) NOT NULL,
    [ImageUrl] nvarchar(max) NOT NULL,
    [IsMain] bit NOT NULL,
    [AppUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_Photos] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Photos_AspNetUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [AspNetUsers] ([Id])
);
GO

CREATE INDEX [IX_Photos_AppUserId] ON [Photos] ([AppUserId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231013161147_Add Photo Entity', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Comments] (
    [Id] int NOT NULL IDENTITY,
    [Body] nvarchar(max) NOT NULL,
    [AuthorId] nvarchar(450) NULL,
    [ActivityId] uniqueidentifier NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Comments_Activities_ActivityId] FOREIGN KEY ([ActivityId]) REFERENCES [Activities] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Comments_AspNetUsers_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [AspNetUsers] ([Id])
);
GO

CREATE INDEX [IX_Comments_ActivityId] ON [Comments] ([ActivityId]);
GO

CREATE INDEX [IX_Comments_AuthorId] ON [Comments] ([AuthorId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231029091316_Add Model Comment', N'7.0.11');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [UserFollowings] (
    [ObserverId] nvarchar(450) NOT NULL,
    [TargetId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserFollowings] PRIMARY KEY ([ObserverId], [TargetId]),
    CONSTRAINT [FK_UserFollowings_AspNetUsers_ObserverId] FOREIGN KEY ([ObserverId]) REFERENCES [AspNetUsers] ([Id]),
    CONSTRAINT [FK_UserFollowings_AspNetUsers_TargetId] FOREIGN KEY ([TargetId]) REFERENCES [AspNetUsers] ([Id])
);
GO

CREATE INDEX [IX_UserFollowings_TargetId] ON [UserFollowings] ([TargetId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20231215031037_Add Following Entity', N'7.0.11');
GO

COMMIT;
GO

