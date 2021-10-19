IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [JobAds] (
    [id] nvarchar(450) NOT NULL,
    [headline] nvarchar(max) NULL,
    [publication_date] datetime2 NOT NULL,
    [descriptionText] nvarchar(max) NULL,
    [duration_concept_id] nvarchar(max) NULL,
    [duration_label] nvarchar(max) NULL,
    [workingHoursType_label] nvarchar(max) NULL,
    [employer_organization_number] nvarchar(max) NULL,
    [employer_name] nvarchar(max) NULL,
    [employer_workplace] nvarchar(max) NULL,
    [applicationDetails_email] nvarchar(max) NULL,
    [applicationDetails_url] nvarchar(max) NULL,
    [occupation_concept_id] nvarchar(max) NULL,
    [occupation_label] nvarchar(max) NULL,
    [occupationGroup_concept_id] nvarchar(max) NULL,
    [occupationGroup_label] nvarchar(max) NULL,
    [workplaceAddress_street_address] nvarchar(max) NULL,
    [workplaceAddress_postcode] nvarchar(max) NULL,
    [workplaceAddress_city] nvarchar(max) NULL,
    CONSTRAINT [PK_JobAds] PRIMARY KEY ([id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211018172341_Inital', N'3.1.20');

GO

