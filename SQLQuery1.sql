CREATE TABLE [dbo].[LuanVan] (
    [IDLuanVan]     NVARCHAR (50) NOT NULL,
    [TenLuanVan]    NVARCHAR (50) NULL,
    [IDGiangVien]       NVARCHAR (50) NULL,
    [LinhVuc]        NVARCHAR(50)  NULL,
    PRIMARY KEY CLUSTERED ([IDLuanVan] ASC)
);

